using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.CrawlerProduct.Cache;
using QT.Entities.Data;
using QT.Moduls;
using QT.Moduls.Crawler;
using QT.Moduls.CrawlerProduct.Cache;
using QT.Moduls.CrawlerProduct.RabbitMQ;
using RabbitMQ.Client;
using RabbitMQ.Client.Framing;
using QT.Moduls.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Core.Crawler
{
    public class WorkerReload : IWorker, IDisposable
    {
        public DelegateReportRun EventReportRun = null;
        private SqlDb sqlDb = new SqlDb(ConfigCrawler.ConnectProduct);

        public WorkerReload(long companyId, string nameThread)
        {
            _companyId = companyId;
            _nameThread = nameThread;
        }

        public CancellationToken Token = new CancellationToken();
        private IDownloadHtml _downloadHtml = new DownloadHtmlCrawler();
        private TypeEnd _typeEnd = TypeEnd.None;
        private int _countVisited = 0;
        private int _countChange = 0;
        private Queue<Job> _linksQueue = null;

        private readonly long _companyId = 0;

        private const int LimitProductsPerReload = 400;
        private CacheTrackDeleteProduct _cacheCheckDelete = null;
        private CacheProductHash _cacheProductHash = null;
        private RedisCompanyWaitCrawler _cacheWaitCrawler = null;
        private RedisLastUpdateProduct _redisLastCrl = null;
        private CacheProductDesciptioHash _cacheDesHash = null;
        private readonly ProductParse _productParse = new ProductParse();
        private Configuration _config = null;
        private Company _company = null;

        public CancellationTokenSource TokenSource = new CancellationTokenSource();


        private ProducerBasic _producerReportError = null;
        private ProducerBasic _producerProductChange = null;
        private ProducerBasic _producerPushCompanyReload = null;
        private ProducerBasic _producerDuplicateProduct = null;
        private ProducerBasic _producerEndCrawler = null;

        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(WorkerReload));
        private DateTime _timeStart = DateTime.Now;
        private readonly string _session = Guid.NewGuid().ToString();

        private Dictionary<long, long> _dicHashDesc = null;
        private Dictionary<long, ProductHash> _dicCacheProduct = null;
        private Dictionary<long, int> _dicTrackDie = null;

        private Dictionary<long, long> _dicDuplicate = null;
        private int _countProduct = 0;
        private readonly string _nameThread;
        private const int MaxHourReload = 24;

        public void StartCrawler()
        {
            _log.InfoFormat("ss: {0} Start crawler for c: {1}", _session, _companyId);
            if (Init())
            {
                UpdateLastCrawler();
                RunReportRunning();
                Crawl();
            }
        }

        private void UpdateLastCrawler()
        {
            bool bOk = this.sqlDb.RunQuery(string.Format("update Company Set LastCrawlerReload = GetDate(), LastEndCrawlerReload = NULL Where Id = {0}", this._companyId), CommandType.Text, null);
        }

        private void RunReportRunning()
        {
            var tokenReportSession = TokenSource.Token;
            Task.Factory.StartNew(() =>
            {
                ProducerBasic producerReportSessionRunning = null;
                try
                {

                    producerReportSessionRunning = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.ExchangeSessionRunning, ConfigCrawler.RoutingkeySessionRunning);
                    while (true)
                    {
                        tokenReportSession.ThrowIfCancellationRequested();
                        var mss = new ReportSessionRunning() { Thread = _nameThread, CompanyId = _companyId, Ip = Dns.GetHostName(), Session = _session, StartAt = _timeStart, Type = "Reload", MachineCode = Server.MachineCode };
                        producerReportSessionRunning.PublishString(Newtonsoft.Json.JsonConvert.SerializeObject(mss), true, 300);
                        _log.Info(string.Format("Running Reload {0} {1} {2}'", this._companyId, (this._company != null) ? this._company.Domain : "", (DateTime.Now - this._timeStart).Minutes));
                        Thread.Sleep(60000);
                    }
                }
                catch (OperationCanceledException ex)
                {
                    _log.Info(string.Format("Stop reporting session:{0}", _session));
                    if (producerReportSessionRunning != null) producerReportSessionRunning.Dispose();
                    return;
                }
                catch (Exception ex01)
                {
                    _producerReportError.PublishString(Newtonsoft.Json.JsonConvert.SerializeObject(new ErrorCrawler() { CompanyId = _companyId, ProductId = 0, TimeError = DateTime.Now, Message = ex01.Message + "\n" + ex01.StackTrace, Url = "" }), true, 0);
                }
            }, tokenReportSession);
        }

        private void Crawl()
        {
            try
            {
                LoadQueue();
                while (true)
                {
                    Token.ThrowIfCancellationRequested();
                    if (_linksQueue.Count == 0)
                    {
                        _typeEnd = TypeEnd.Success;
                        break;
                    }
                    else if ((DateTime.Now - _timeStart).TotalHours > MaxHourReload)
                    {
                        _typeEnd = TypeEnd.OverTime;
                        break;
                    }
                    else
                    {
                        var job = _linksQueue.Dequeue();
                        int statusProcess =  ProcessJob(job);
                        string strLog = string.Format("ss: {0} cQ: {1} tP: {2} cV: {3} pt: {4} {5} sst: {6} cmp: {7} {8}", _session, _linksQueue.Count, _company.TotalProduct, _countVisited, job.ProductId,
                            job.url, statusProcess, _companyId,
                            (this._company == null) ? "" : this._company.Domain);
                        if (EventReportRun != null) EventReportRun(strLog);
                        _log.Info(strLog);
                        if (_linksQueue.Count == 0)
                        {
                            LoadQueue();
                        }
                    }
                }
            }
            catch (OperationCanceledException)
            {
                _typeEnd = TypeEnd.Immediate;
                _producerPushCompanyReload.PublishString(_companyId.ToString(), true, 0);
                End();
                throw;
            }
            catch (Exception ex)
            {
                _typeEnd = TypeEnd.Error;
                _log.Error(ex);
            }
            End();
        }


        private void DelayTime()
        {
            Token.WaitHandle.WaitOne(_config.TimeDelay);
        }

        private bool IsLinkProduct(ProductEntity pt, string url)
        {
            return (Common.CheckRegex(url, _config.ProductUrlsRegex, null, false));
        }

        private string GetHtmlCode(string urlCurrent, out WebExceptionStatus expo)
        {
            var html = this._downloadHtml.GetHTML(urlCurrent, 45, 2, out expo);
            html = html.Replace("<form", "<div");
            html = html.Replace("</form", "</div");
            if (_config.UseClearHtml)
            {
                html = Common.TidyCleanR(html);
            }
            return html;
        }


        private void CheckChangeDesc(ProductEntity pt)
        {
            var hNew = pt.GetHashDesc();
            var hOld = (_dicHashDesc.ContainsKey(pt.ID)) ? _dicHashDesc[pt.ID] : 0;
            if (pt.Valid && hNew != hOld && !string.IsNullOrEmpty(pt.GetFullDesc()))
            {
                pt.StatusChange.IsChangeDesc = true;
            }
        }


        private int ProcessJob(Job job)
        {
            int statusEnd = 0;

            var pt = new ProductEntity()
            {
                ID = job.ProductId,
                DetailUrl = job.url,
                CompanyId = _companyId,
                Session = _session,
                LastUpdate = DateTime.Now
            };

            if (!IsLinkProduct(pt, job.url))
            {
                LoadProductFail(pt);
            }
            else
            {
                DelayTime();
                ParseProduct(job, pt);
            }

            if (pt.StatusChange.CheckChange())
            {
                _countChange++;
                PushChangeProduct(pt);
                if (EventReportRun != null)
                    EventReportRun(string.Format("Change product {0} {1} {2}  IsDelete:{3}", pt.ID, pt.DetailUrl, pt.StatusChange.IsChangeBasic, pt.StatusChange.IsDelete));
                statusEnd = 1;
            }
            else
            {
                statusEnd = 0;
            }
            return statusEnd;
        }
        private void PushChangeProduct(ProductEntity pt)
        {
            _producerProductChange.PublishString(pt.GetJSON(), true, 0);
        }

        private void LoadProductFail(ProductEntity pt)
        {
            pt.StatusChange.IsDelete = true;
        }

        private void ParseProduct(Job job, ProductEntity product)
        {
            DelayTime();
            WebExceptionStatus status;
            var htm = GetHtmlCode(job.url, out status);
            _countVisited++;
            if (status == WebExceptionStatus.Timeout || status == WebExceptionStatus.ConnectFailure)
            {
                _log.Info(string.Format("Fail download link: {0}", status));
            }
            else
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(htm);
                _productParse.Analytics(product, doc, job.url, _config, _company.Domain);
                if (product.IsSuccessData(_config.CheckPrice))
                {
                    CheckDuplicate(product); if (!product.StatusChange.IsDuplicate)
                    {
                        CheckDeleteProduct(product);
                        CheckChangeBasic(product);
                        CheckChangeDesc(product);
                        CheckChangePrice(product);
                        CheckChangeImg(product);
                    }
                }
                else
                {
                    CheckDelete(product);
                }
            }
        }

        private void CheckDeleteProduct(ProductEntity product)
        {
            product.StatusChange.IsDelete = !product.Valid;
        }

        private void CheckDuplicate(ProductEntity product)
        {
            if (_dicDuplicate.ContainsKey(product.GetHashDuplicate()) &&
                _dicDuplicate[product.GetHashDuplicate()] != product.ID)
            {
                product.StatusChange.IsDuplicate = true;
                _producerDuplicateProduct.PublishString(
                    Newtonsoft.Json.JsonConvert.SerializeObject(new ProductDuplicate()
                    {
                        CId = _companyId,
                        Id = product.ID,
                        Hash = product.GetHashDuplicate(),
                        IdDup = _dicDuplicate[product.GetHashDuplicate()],
                        Url = product.DetailUrl
                    }), true, 0);
            }
        }

        private void CheckDelete(ProductEntity pt)
        {
            if (_config.MaxToNoValid <= 1 ||
                _dicTrackDie.ContainsKey(pt.ID) && _dicTrackDie[pt.ID] > _config.MaxToNoValid)
            {
                pt.StatusChange.IsDelete = true;
            }
            else
            {
                _cacheCheckDelete.IncreatementDieProduct(_companyId, pt.ID);
            }
        }

        private void CheckChangeBasic(ProductEntity pt)
        {
            try
            {
                if (pt.GetHashChange() != _dicCacheProduct[pt.ID].HashChange)
                {
                    pt.StatusChange.IsChangeBasic = true;
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }

        private void CheckChangeImg(ProductEntity pt)
        {
            var ptCache = _dicCacheProduct[pt.ID];
            var hashImageNew = pt.GetHashImage();
            var hashImageOld = ptCache.HashImage;
            if (hashImageNew != hashImageOld)
            {
                pt.StatusChange.IsChangeImage = true;
            }
        }


        private void CheckChangePrice(ProductEntity pt)
        {
            var ptCache = _dicCacheProduct[pt.ID];
            if (pt.Price != ptCache.Price)
            {
                pt.StatusChange.IsChangePrice = true;
                pt.OldPrice = ptCache.Price;
                _log.Info(string.Format("ptID:{0} change price", pt.ID));
            }
        }



        public void Stop()
        {
        }

        public bool Init()
        {
            try
            {
                _cacheWaitCrawler = RedisCompanyWaitCrawler.Instance();
                _redisLastCrl = RedisLastUpdateProduct.Instance();
                _config = new Configuration(_companyId, true);
                _company = new Company(_companyId);
                _cacheDesHash = CacheProductDesciptioHash.Instance();

                var rabbitMQCrawler = RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler);
                _producerReportError = new ProducerBasic(rabbitMQCrawler, ConfigCrawler.ExchangeErorrCrawler, ConfigCrawler.RoutingKeyErrorCrawler);
                _producerProductChange = new ProducerBasic(rabbitMQCrawler, ConfigCrawler.ExchangeChangeProduct, ConfigCrawler.RoutingkeyChangeProduct);
                _producerDuplicateProduct = new ProducerBasic(rabbitMQCrawler, ConfigCrawler.ExchangeDuplicateProductToCache, ConfigCrawler.ExchangeDuplicateProductToCache);
                _producerPushCompanyReload = new ProducerBasic(rabbitMQCrawler, ConfigCrawler.ExchangeCompanyReload, ConfigCrawler.RoutingkeyCompanyReload);
                _producerEndCrawler = new ProducerBasic(rabbitMQCrawler, ConfigCrawler.ExchangeEndSession, ConfigCrawler.RoutingEndSession);

                _cacheCheckDelete = CacheTrackDeleteProduct.Instance();
                _cacheProductHash = CacheProductHash.Instance();
                _dicTrackDie = _cacheCheckDelete.GetDicTrackOfCompany(_companyId);

                _dicDuplicate = new Dictionary<long, long>();
                _dicCacheProduct = new Dictionary<long, ProductHash>();
                _dicHashDesc = new Dictionary<long, long>();
                _dicCacheProduct = new Dictionary<long, ProductHash>();
                _linksQueue = new Queue<Job>();



                _timeStart = DateTime.Now;
                _countChange = 0;
                _countVisited = 0;
                return true;
            }
            catch (Exception ex)
            {
                _log.Error(ex);

                if (_producerEndCrawler != null)
                {
                    _producerEndCrawler.PublishString(new CrawlerSessionLog()
                    {
                        CompanyId = _companyId,
                        CountChange = 0,
                        CountProduct = 0,
                        CountVisited = 0,
                        Domain = "",
                        EndAt = DateTime.Now,
                        Ip = Dns.GetHostName(),
                        NumberDuplicateProduct = 0,
                        Session = this._session,
                        StartAt = this._timeStart,
                        TotalProduct = 0,
                        TypeCrawler = 0,
                        TypeEnd = "Error Init",
                        TypeRun = "Auto"
                    }.ToJson());
                }

                string mss =
                    Newtonsoft.Json.JsonConvert.SerializeObject(new ErrorCrawler() { CompanyId = _companyId, ProductId = 0, TimeError = DateTime.Now, Message = "Init" + ex.Message + ex.StackTrace });
                _producerReportError.PublishString(mss, true, 20);
                return false;
            }
        }

        private void LoadQueue()
        {
            var lstProducts = _redisLastCrl.GetTopLastUpdate(_companyId, _timeStart, LimitProductsPerReload);
            _redisLastCrl.UpdateBathLastUpdateProduct(_companyId, lstProducts, DateTime.Now);
            foreach (var row in _cacheProductHash.GetAllProductHash(_companyId, lstProducts))
            {
                if (!_dicCacheProduct.ContainsKey(row.Id))
                    _dicCacheProduct.Add(row.Id, row);
                if (!_dicDuplicate.ContainsKey(row.HashDuplicate))
                {
                    _dicDuplicate.Add(row.HashDuplicate, row.Id);
                    _linksQueue.Enqueue(new Job()
                    {
                        ProductId = row.Id,
                        deep = 0,
                        url = row.url
                    });
                }
                else
                {
                    _log.Info(string.Format(@"Push duplicate product: {0}", row.Id));
                    PushChangeProduct(new ProductEntity()
                    {
                        ID = row.Id,
                        CompanyId = _companyId,
                        Session = _session,
                        DetailUrl = row.url,
                        LastUpdate = DateTime.Now,
                        StatusChange = new ProductStatusChange()
                        {
                            IsDuplicate = true
                        }
                    });
                }
            }
            foreach (var variable in _cacheDesHash.GetAllProductHash(_companyId, lstProducts))
            {
                if (!_dicHashDesc.ContainsKey(variable.Key))
                {
                    _dicHashDesc.Add(variable.Key, variable.Value);
                }
            }
        }

        public void End()
        {
            string strLog = string.Format("End crawler {1} {0}", _session, _typeEnd);
            if (EventReportRun != null) EventReportRun(strLog); _log.Info(strLog);
            UpdateEndCrawl(new CrawlerSessionLog()
            {
                CompanyId = _companyId,
                Domain = _company.Domain,
                StartAt = _timeStart,
                EndAt = DateTime.Now,
                CountVisited = _countVisited,
                Ip = Dns.GetHostName(),
                Session = _session,
                TypeRun = "AUTO",
                TypeCrawler = 1,
                CountChange = _countChange,
                TotalProduct = _company.TotalProduct,
                CountProduct = _countProduct,
                TypeEnd = _typeEnd.ToString()
            });

            _cacheWaitCrawler.SetNexReload(_companyId, _config.MinHourReload);
            _cacheWaitCrawler.SetRemoveRunningCrawler(_companyId);

            TokenSource.Cancel();
        }

        private void UpdateEndCrawl(CrawlerSessionLog crawlerSessionLog)
        {
            _producerEndCrawler.PublishString(crawlerSessionLog.ToJson());
        }

        public void Dispose()
        {
            if (_producerReportError != null) _producerReportError.Dispose();
            if (_producerProductChange != null) _producerProductChange.Dispose();
            if (_producerPushCompanyReload != null) _producerPushCompanyReload.Dispose();
            if (_producerDuplicateProduct != null) _producerDuplicateProduct.Dispose();
            if (_producerEndCrawler != null) _producerEndCrawler.Dispose();
        }


        public void StartCrawler(List<string> linkStarts)
        {

        }
    }
}
