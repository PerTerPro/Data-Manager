using System;
using System.Collections.Generic;
using QT.Entities;
using System.Threading;
using QT.Entities.Data;
using QT.Entities.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using System.Threading.Tasks;
using QT.Moduls.CrawlerProduct.Cache;
using QT.Entities.CrawlerProduct.Cache;

using NSCrawler = QT.Entities.CrawlerProduct.Reload;
using QT.Moduls.CrawlerProduct.RabbitMQ;
using System.Net;


namespace QT.Moduls.CrawlerProduct
{
    public class WorkerReloadProduct : IWorker
    {
        private int _countProduct = 0;
        private int _countVisited = 0;
        private int _countLink = 0;
        private int _countCompany = 0;
        private int _countChange = 0;
        private int _totalProductBefore = 0;

        private const int MaxFailToIgone = 4;
        private const int LimitIgoneWhenFail = 4;
        private const int LimitSleepLong = 2;
        private const int LimitCountVisitToSleep = 200;
        private const int NumberItemInOneLoop = 200;

        private RabbitMQServer _rabbitMQ = null;
        private PublisherDesciption _publiserDesciption = null;
        private readonly CacheTrackDeleteProduct _cacheCheckDelete = CacheTrackDeleteProduct.Instance();
        private readonly CacheProductHash _redisProductHash = CacheProductHash.Instance();
        private RedisCompanyWaitCrawler _redisWaitCrawler = null;
        private RedisCacheProductInfo _redisProduct = null;
        private RedisLastUpdateProduct _redisProductLastUpdate = null;
        private CacheProductDesciptioHash _redisDesHash = null;

        private Configuration _config = null;
        private Entities.Company _company = null;
        private MQLogChangeProduct _jobClientLogChangeProduct;
        private MqLogChangePrice _jobClientLogChangePrice;
        private ProductAdapter _productAdapter = null;
        public CancellationToken TokenCrawler = new CancellationToken();

        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(Worker));
        private long _companyId;
        public string Procedure;
        private DateTime _startCrawler = DateTime.Now;
        private JobCrawler _jobCompanyCrawler = null;
        private List<string> _crawlerRegexs;
        private List<string> _noCrawlerRegexs;
        private readonly int _indexThread = 0;
        private string _session = "";

        private readonly List<Product> _productWaitUpdateGroup = new List<Product>();
        private readonly List<Product> _productWaitInsertGroup = new List<Product>();
        private readonly List<long> _productIdWaitChangeImage = new List<long>();
        private readonly List<long> _productIdWaitDeleteGroup = new List<long>();
        private readonly List<Product> _productsWaitChangeDesc = new List<Product>();
        private readonly Dictionary<long, long> _dicHashDesc = new Dictionary<long, long>();

        private Dictionary<long, ProductCache> _dicCacheProduct = null;
        private Dictionary<long, int> _dicTrackDie = new Dictionary<long, int>();
        private Queue<Entities.CrawlerProduct.Reload.Job> _linksQueue = null;
        private DateTime _lastPushRunning = DateTime.Now.AddHours(-1);
        private Dictionary<long, long> _dicDuplicate = null;
        private const int MaxHourReload = 24;

        List<Tuple<Product,Product>> lstProductChange = new List<Tuple<Product, Product>>();

        public WorkerReloadProduct(bool bCheckOtherRunning)
        {
            _bCheckOtherRunning = bCheckOtherRunning;
        }

        private void Init()
        {
            _redisDesHash = CacheProductDesciptioHash.Instance();
            _jobClientLogChangePrice =new MqLogChangePrice();
            _jobClientLogChangeProduct = MQLogChangeProduct.Instance();
            _dicDuplicate = new Dictionary<long, long>();
            _dicCacheProduct = new Dictionary<long, ProductCache>();
            _linksQueue = new Queue<NSCrawler.Job>();
            _productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
            _redisWaitCrawler = RedisCompanyWaitCrawler.Instance();
            _redisProduct = RedisCacheProductInfo.Instance();
            _redisProductLastUpdate = RedisLastUpdateProduct.Instance();
            _publiserDesciption = new PublisherDesciption();
        }


        public void Start()
        {
            try
            {
                if (_config.NumberThreadCrawler > 1)
                {
                    Crawl(_config.NumberThreadCrawler);
                }
                else
                {
                    Crawl("NoName");
                }

                
            }
            catch (OperationCanceledException)
            {
                if (_company == null) throw;
                _redisWaitCrawler.SetRemoveRunningCrawler(_companyId);
                _redisWaitCrawler.SetNexReload(this._companyId, 1);
                throw;
            }
            catch (Exception ex02)
            {
                _log.Error(ex02);
            }
        }

        private void Crawl(int numberThread)
        {
            var tasks = new Task[numberThread];
            for (var i = 0; i < numberThread; i++)
            {
                var numberSubThread = i;
                var task = Task.Factory.StartNew(() => Crawl(numberSubThread.ToString()), TokenCrawler);
                tasks[i] = task;
            }
            Task.WaitAll(tasks);
        }

        private void Crawl(string nameSubThread = "")
        {
            while (_linksQueue.Count > 0 && (DateTime.Now - _startCrawler).TotalHours < MaxHourReload)
            {
                try
                {
                    TokenCrawler.ThrowIfCancellationRequested();
                    NSCrawler.Job jobReload = null;
                    lock (_linksQueue)
                    {
                        if (_linksQueue.Count > 0)
                        {
                            ReportToRedis();
                            jobReload = _linksQueue.Dequeue();
                        }
                    }
                    if (jobReload != null)
                    {
                        try
                        {
                            LogData(string.Format("[THR {0} / {9}] cCo: {4}. TTP: {1} cV: {2} cP: {3} Q: {5} P: {6} Comp: {7} {8}"
                                    , _indexThread
                                    , _totalProductBefore.ToString().PadLeft(4, ' ')
                                    , _countVisited.ToString().PadLeft(4, ' ')
                                    , _countProduct.ToString().PadLeft(4, ' ')
                                    , _countCompany.ToString().PadLeft(4, ' ')
                                    , _linksQueue.Count.ToString().PadLeft(4, ' ')
                                    , jobReload.ProductId.ToString().PadLeft(20, ' ')
                                    , _companyId.ToString().PadLeft(20, ' ')
                                    , _company.Domain.PadLeft(50, ' ')
                                    , nameSubThread.PadLeft(4, ' ')));

                            ProcessJob(jobReload.ProductId, jobReload.url);

                        }
                        catch (Exception ex1)
                        {
                            _log.Error(ex1);
                        }
                    }

                    if (_linksQueue.Count == 0)
                    {
                        PullQueue();
                    }
                }
                catch (OperationCanceledException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                }
            }

            EndSession();
        }

        private void PullQueue()
        {
            SaveChanges();
            LoadQueue();
        }

        private void ReportToRedis()
        {
            if (!((DateTime.Now - _lastPushRunning).TotalMinutes > 5)) return;
            _redisWaitCrawler.SetRunningCrawler(_companyId);
            _redisWaitCrawler.SetNexReload(_companyId, _config.MinHourReload);
            _lastPushRunning = DateTime.Now;
        }

        readonly object _objLockEndSession = new object();
        private void EndSession()
        {
            lock (_objLockEndSession)
            {
                if (_company != null)
                {
                    LogData(string.Format("!------:{0} END RELOAD {1} {2} Vs:{3}", _indexThread, _company.ID, _company.Domain, _countVisited));
                    _productAdapter.UpdateEndCrawl(_company.ID, 1, _startCrawler, DateTime.Now, _countLink, _countVisited, _countProduct, _countChange, _session, _totalProductBefore, QT.Entities.Server.IPHost, _company.Domain);
                    _redisWaitCrawler.SetNexReload(_companyId, _config.MinHourReload);
                    _redisWaitCrawler.SetRemoveRunningCrawler(_companyId);
                    _company = null;
                    _companyId = 0;
                }
            }
        }

        private void LogData(string logdata)
        {
            _log.Info(logdata);
            if (EventShowLog != null) EventShowLog(logdata);
        }

        private void ProcessJob(long pId, string url)
        {
            if (string.IsNullOrEmpty(url)) return;
            if (!ExistInCache(pId, url)) return;
            if (!IsLinkProduct(pId, url)) return;

            ProductCache ptCache = null;
            if (_dicCacheProduct.ContainsKey(pId)) ptCache = _dicCacheProduct[pId];
            var pt = new Product() { ID = pId };
            DelayTime();
            var status = Analysic(pt, url);
            if (status == WebExceptionStatus.Timeout || status == WebExceptionStatus.ConnectFailure)
            {
                _log.Info(string.Format("Fail download link: {0}", status));
            }
            else
            {
                _countVisited++;
                if (pt.Valid)
                {
                    _countProduct++;
                    if (_dicDuplicate.ContainsKey(pt.GetHashCheckDuplicate()) && _dicDuplicate[pt.GetHashCheckDuplicate()] != pt.ID)
                    {
                        _productIdWaitDeleteGroup.Add(pt.ID);
                        LogProduct_ChangeInfo(DateTime.Now, pt.ImageUrl, pt.Name, "duplicate info", pt.Price, pt.ID, (int)pt.Instock, _session, url, pt.Valid);
                    }
                    else
                    {
                        CheckChangeDesc(pt);
                        if (ptCache == null || pt.GetHashChange() != ptCache.hash_change)
                        {
                            CheckChangePrice(pt, ptCache);
                            CheckChangeImg(pt, ptCache);
                            LogProduct_ChangeInfo(DateTime.Now, pt.ImageUrl, pt.Name, "change info", pt.Price, pt.ID, (int)pt.Instock, _session, url, pt.Valid);
                            if (_dicCacheProduct.ContainsKey(pt.ID))
                            {
                                lock (_productWaitUpdateGroup)
                                {
                                    _productWaitUpdateGroup.Add(pt);
                                }
                            }
                            else _productWaitInsertGroup.Add(pt);

                        }
                        else
                        {
                            LogProduct_ChangeInfo(DateTime.Now, "", "", "Not change", 0, pId, 0, _session, pt.DetailUrl, false);
                        }
                    }

                }
                else
                {
                    if (_dicTrackDie.ContainsKey(pt.ID) && _dicTrackDie[pt.ID] > 1)
                    {
                        _productIdWaitDeleteGroup.Add(pt.ID);
                    }
                    else
                    {
                        _cacheCheckDelete.IncreatementDieProduct(_companyId, pt.ID);
                    }
                }
            }
        }

        private void CheckChangeDesc(Product product)
        {
            var hNew = product.GetHashDesc();
            var hOld = (_dicHashDesc.ContainsKey(product.ID)) ? _dicHashDesc[product.ID] : 0;
            if (product.Valid && hNew != hOld && !string.IsNullOrEmpty(product.GetFullDesc()))
            {
                _productsWaitChangeDesc.Add(product);
            }
            else
            {
                EventShowLog(string.Format("c {0} p {1}  not change description", _companyId, product.ID));
            }
        }

        private void CheckChangeImg(Product product, ProductCache productInCache)
        {
            var hashImageNew = product.GetHashImage();
            var hashImageOld = productInCache.hash_image;
            if (product.Valid && hashImageNew != hashImageOld && !string.IsNullOrEmpty(product.ImageUrl))
            {
                _productIdWaitChangeImage.Add(product.ID);
            }
        }


        private bool IsLinkProduct(long productId, string url)
        {
            if (Common.CheckRegex(url, _config.ProductUrlsRegex, null, false))
            {
                return true;
            }
            else
            {
                _productIdWaitDeleteGroup.Add(productId);
                return false;
            }
        }


        private void CheckChangePrice(Product pt, ProductCache productInCache)
        {
            if (pt.Price != productInCache.price)
            {
                this._jobClientLogChangePrice.PushQueueChangePriceLog(new JobRabbitChangePrice()
                {
                    Name = pt.Name,
                    OldPrice = productInCache.price,
                    CompanyID = pt.IDCongTy,
                    ProductID = pt.ID,
                    NewPrice = pt.Price,
                });
            }
        }

        private void LogProduct_ChangeInfo(DateTime dateTime, string image, string name, string mss, long price, long productId, int instock, string session, string url, bool valid)
        {
            LogData(string.Format("------>{3}---:: Product: {1} - {2}", this._indexThread, productId, url, mss));
            _jobClientLogChangeProduct.PushChangeProduct(new QT.Entities.CrawlerProduct.RabbitMQ.MsProduct()
            {
                Date_Update = DateTime.Now,
                Image_Url = image,
                Is_Black_Link = false,
                Is_New = false,
                Name = name,
                Note = mss,
                Price = price,
                Product_Id = productId,
                Status = instock,
                Summary = "",
                CompanyId = this._companyId,
                Valid = true,
                Session = session,
                Url = url
            });
        }

      

        private bool ExistInCache(long p, string url)
        {
            if (!this._dicCacheProduct.ContainsKey(p))
            {
                _jobClientLogChangeProduct.PushChangeProduct(new QT.Entities.CrawlerProduct.RabbitMQ.MsProduct()
                {
                    Note = "not cache in product" + p,
                    Product_Id = p,
                    Session = _session,
                    CompanyId = this._companyId,
                    Url = url
                });
                return false;
            }
            return true;
        }

        private WebExceptionStatus Analysic(Product product, string url)
        {
            WebExceptionStatus outException;
            var html = this.GetHtmlCode(url, _config.UseClearHtml, out outException);
            if (html == "") return outException;
            var doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            product.Analytics(doc, url, _config, false, _company.Domain);
            product.Valid = product.IsSuccessData(_config.CheckPrice);
            return outException;
        }


        private void InitSession()
        {
            _session = Guid.NewGuid().ToString();
            if (!_productAdapter.AllowCrawlReload(this._companyId)) return;
            _config = new Configuration(_companyId, true);
            _company = new Entities.Company(_companyId);
            _productAdapter.UpdateLastJobForDb(_company.ID);
            _productAdapter.UpdateLastReloadCrawler(_company.ID);
            _startCrawler = DateTime.Now;
            _crawlerRegexs = _config.VisitUrlsRegex;
            _noCrawlerRegexs = _config.NoVisitUrlRegex;
            _countChange = 0;
            _countLink = 0;
            _countVisited = 0;
            _countProduct = 0;
            _totalProductBefore = _company.TotalProduct;
            _productWaitInsertGroup.Clear();
            _productIdWaitChangeImage.Clear();
            _linksQueue.Clear();
            _crawlerRegexs.Clear();
            _noCrawlerRegexs.Clear();
            _dicCacheProduct.Clear();
            _dicDuplicate.Clear();
            _dicTrackDie = _cacheCheckDelete.GetDicTrackOfCompany(_companyId);

            lock (_productWaitUpdateGroup)
            {
                _productWaitUpdateGroup.Clear();
            }

            LoadQueue();
        }

        readonly object _objLockLoadQueue = new object();
        private void LoadQueue()
        {
            lock (_objLockLoadQueue)
            {


                var lstProducts = _redisProductLastUpdate.GetTopLastUpdate(_companyId, _startCrawler, NumberItemInOneLoop);
                _redisProductLastUpdate.UpdateBathLastUpdateProduct(_companyId, lstProducts, DateTime.Now);

                foreach (var row in _redisProductHash.GetAllProductHash(_companyId, lstProducts))
                {
                    if (!_dicCacheProduct.ContainsKey(row.Id))
                        _dicCacheProduct.Add(row.Id, new ProductCache()
                        {
                            detail_url = row.url,
                            fail = 0,
                            hash_change = row.HashChange,
                            hash_image = row.HashImage,
                            id = row.Id,
                            igone = 0,
                            last_change = DateTime.Now,
                            price = row.Price
                        });

                    if (!_dicDuplicate.ContainsKey(row.HashDuplicate))
                    {
                        _dicDuplicate.Add(row.HashDuplicate, row.Id);

                        _linksQueue.Enqueue(new NSCrawler.Job()
                        {
                            ProductId = row.Id,
                            deep = 0,
                            url = row.url
                        });
                    }
                    else
                    {
                        _productIdWaitDeleteGroup.Add(row.Id);
                        _log.Info(string.Format("Duplicate product id {0} in db", row.Id));
                    }
                }

                foreach (var variable in _redisDesHash.GetAllProductHash(_companyId, lstProducts))
                {
                    if (!_dicHashDesc.ContainsKey(variable.Key))
                        _dicHashDesc.Add(variable.Key, variable.Value);
                }
            }
        }

        private void DelayTime()
        {
            if (_countVisited > 0 && _countVisited % LimitCountVisitToSleep == 0)
            {
                _log.InfoFormat("Thead {0}. Sleep long {1} ", _indexThread, _companyId);
                TokenCrawler.WaitHandle.WaitOne(LimitSleepLong);
            }
            else
            {
                TokenCrawler.WaitHandle.WaitOne(_config.TimeDelay);
            }
        }

        private TypeReload _typeRun = TypeReload.AutoNextCompany;
        public DelegateShowLog EventShowLog = null;
        public DelegateGetCompanyCrawler EventGetCompanyCrawler;
        private readonly bool _bCheckOtherRunning;
        private void SaveChanges()
        {
            lock (_objLockEndSession)
            {
                SaveInsert();
                SaveUpdate();
                SaveDelete();
                SaveChangeDesc();
                PushMqChangeImage();
            }
        }

        private void PushMqChangeImage()
        {
            //_productAdapter.PushMQChangeImage(this._productIdWaitChangeImage);
            _productIdWaitChangeImage.Clear();
        }

        private void SaveChangeDesc()
        {
            if (_productsWaitChangeDesc.Count <= 0) return;
            _log.Info(string.Format(@"Save change desc for {0} {1}", _productsWaitChangeDesc.Count, _companyId));
            var lsTuple = new List<Tuple<long, long>>();
            foreach (var variable in _productsWaitChangeDesc)
            {
                _publiserDesciption.Publish(new JobMqChangeDesc()
                {
                    Id = variable.ID,
                    FullDesc = variable.FullDescHtml,
                    SpecDesc = variable.SpecsDescHtml,
                    ShortDesc = variable.ShortDescHtml,
                    VideoDesc = variable.VideoDescHtml
                });
                lsTuple.Add(new Tuple<long, long>(variable.ID, variable.GetHashDesc()));
            }
            _redisDesHash.SetHashDesc(_companyId, lsTuple);
            _productsWaitChangeDesc.Clear();
        }

        private void SaveDelete()
        {
            if (_productIdWaitDeleteGroup.Count > 0)
            {
                RabbitMQAdapter.Instance.PushProductToQueueChangeMainInfo(_productIdWaitDeleteGroup);
                _productAdapter.DeleteBathProduct(_productIdWaitDeleteGroup);
                _redisProductLastUpdate.RemoveBathProduct(_companyId, _productIdWaitDeleteGroup);
                _redisProductHash.RemoveBathProduct(_companyId, _productIdWaitDeleteGroup);
                _cacheCheckDelete.RemoveBathScore(_companyId, _productIdWaitDeleteGroup);
                _log.Info(string.Format("Deleted {0} product", _productIdWaitDeleteGroup.Count));
                _productIdWaitDeleteGroup.Clear();
            }
        }

        private void SaveUpdate()
        {
            lock (_productWaitUpdateGroup)
            {
                if (_productWaitUpdateGroup.Count > 0)
                {
                    var lstProductIdUpdate = new List<long>();
                    var lstUpdateToChacheHash = new List<ProductHash>();
                    foreach (var product in _productWaitUpdateGroup)
                    {
                        lstProductIdUpdate.Add(product.ID);
                        lstUpdateToChacheHash.Add(new ProductHash()
                        {
                            HashChange = product.GetHashChange(),
                            HashDuplicate = product.GetHashCheckDuplicate(),
                            HashImage = product.GetHashImage(),
                            Id = product.ID,
                            Price = product.Price,
                            url = product.DetailUrl
                        });
                    }
                    _productAdapter.UpdateProductsChangeToDb(_productWaitUpdateGroup);
                    _redisProductHash.SetCacheProductHash(_companyId, lstUpdateToChacheHash);
                    _cacheCheckDelete.SetBathScore(_companyId, lstProductIdUpdate, 0);
                    _log.Info(string.Format("Save changed {0} product", _productWaitUpdateGroup.Count));
                    _productWaitUpdateGroup.Clear();
                }
            }
        }

        private void SaveInsert()
        {
            if (_productWaitInsertGroup.Count <= 0) return;
            var lstUpdateToChacheHash = new List<ProductHash>();
            _productAdapter.InsertProductToDb(_productWaitInsertGroup);
            foreach (var product in _productWaitInsertGroup)
            {
                lstUpdateToChacheHash.Add(new ProductHash()
                {
                    HashChange = product.GetHashChange(),
                    HashDuplicate = product.GetHashCheckDuplicate(),
                    HashImage = product.GetHashImage(),
                    Id = product.ID,
                    Price = product.Price,
                    url = product.DetailUrl
                });
            }
            _redisProductHash.SetCacheProductHash(_companyId, lstUpdateToChacheHash);
            //_productAdapter.PushMQChangeImage(_productIdWaitChangeImage);
            _log.Info(string.Format("Inserted {0} product", _productWaitInsertGroup.Count));
            _productWaitInsertGroup.Clear();
        }

        private string GetHtmlCode(string urlCurrent, bool useClearHtml, out WebExceptionStatus expo)
        {
            var html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(urlCurrent, 45, 2, out expo);
            html = html.Replace("<form", "<div");
            html = html.Replace("</form", "</div");
            if (_config.UseClearHtml)
            {
                html = Common.TidyCleanR(html);
            }
            return html;
        }

    
        public void StartLoop(Queue<long> lstCompany)
        {
            _typeRun = TypeReload.FixQueueCompany;
            Start();
        }
    }
}