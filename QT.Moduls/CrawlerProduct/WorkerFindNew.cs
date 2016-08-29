using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;
using GABIZ.Base;
using GABIZ.Base.HtmlUrl;
using System.Text.RegularExpressions;
using System.Threading;
using System.Data.SqlClient;
using QT.Entities.Data;
using System.IO;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using QT.Entities.CrawlerProduct;
using StackExchange.Redis;
using Websosanh.Core.Drivers.RabbitMQ;
using QT.Moduls.Crawler;
using Websosanh.Core.JobServer;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Drivers.Redis;
using Newtonsoft.Json;
using System.Threading.Tasks;
using QT.Moduls.CrawlerProduct;
using QT.Moduls;
using QT.Moduls.LogCassandra;
using QT.Moduls.CrawlerProduct.Cache;
using QT.Moduls.CrawlerProduct.RabbitMQ;
using QT.Entities.CrawlerProduct.Cache;
using System.Net;

namespace QT.Moduls.CrawlerProduct
{
    public enum TypeFindNew
    {
        AutoNextCompany = 0,
        FixQueueCompany = 1
    }

    public  class WorkerFindNew   : IWorker {
        public DelegateShowLog _eventShowLog = null;
        public DelegateGetCompanyCrawler _eventGetCompanyCrawler;

        private int _totalProductBefore = 0;
        private int _countVisited = 0;
        private int _countLink = 0;
        private int _countCompany = 0;
        private int _countChange = 0;
        private int _totalProduct = 0; 
        private int _indexThread = 0;
        private long _companyId = 0;
        private const int MaxLengthUrl = 500;

        private DateTime _lastReportRedis = DateTime.Now.AddHours(-1);


        private MQLogQueueVisit _mqLogQueueVisit = null;
        private MQLogWarningFindNew _mqLogWarning = null;
        private MqLogChangePrice _mqLogChangePrice = null;

        private RedisCacheCompanyCrawler _redisCacheCompanyCrawler = null;
        private RedisCrcVisitedFindNew _redisCrcVisited = null;
        private RedisQueueFindNew _redisQueueFindNew = null;
        private RedisCompanyWaitCrawler _redisWaitCrawler = null;
        private RedisLastUpdateProduct _redisLastUpdateProduct = null;
        private CacheProductHash _cacheProductHash = CacheProductHash.Instance();
        private Configuration _config = null;
        private Entities.Company _company = null;
        private ProductAdapter _productAdapter = null;
        private CancellationToken _tokenCrawler = new CancellationToken();
        private Queue<string> _linkQueue = null;
        private log4net.ILog _log = log4net.LogManager.GetLogger(typeof(Worker));
        
        public string Procedure;
        private DateTime startCrawler = DateTime.Now;
        private JobCrawler jobCrawler = null;
        private List<string> _visitRegexs;
        private List<string> _noCrawlerRegexs;
        private List<string> _detailLinkRegexs;
        private List<string> _extraRegexNoVisitFn = null;
        
        private string _session = "";
        private List<long> _productsReloaded = null;
        private Uri _rootUri;
        private Dictionary<long, bool> _crcProductOldGroup;
        private Dictionary<long, bool> _visitedCrc;
        private Dictionary<long, long> _hsHashDuplicate = new Dictionary<long, long>();
        
        private string _urlCurrent;
        private int LIMIT_COUNT_VISIT_TO_SLEEP = 200;
        private int LIMIT_SLEEP_LONG = 2 * 60 * 1000;
       
        private TypeFindNew TypeRun = TypeFindNew.AutoNextCompany;
        private bool _bCheckOtherRunning;
     

        public WorkerFindNew(long idCongTy, string session)
        {
            InitData();
            this._companyId = idCongTy;
            this._session = session;
        }

        public WorkerFindNew()
        {
            InitData();
        }

        public WorkerFindNew(int indexThread, CancellationToken cancellationToken, string session, bool CheckRunning = true)
        {
            InitData();
            this._indexThread = indexThread;
            this._tokenCrawler = cancellationToken;
            this._session = session;
            this._bCheckOtherRunning = CheckRunning;
        }

        private void InitData()
        {
            _productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
           

            _linkQueue = new Queue<string>();
            _crcProductOldGroup = new Dictionary<long, bool>();
            _visitedCrc = new Dictionary<long, bool>();
            _productsReloaded = new List<long>();

            _redisQueueFindNew = RedisQueueFindNew.Instance();
            _redisCacheCompanyCrawler = RedisCacheCompanyCrawler.Instance();
            _redisLastUpdateProduct = RedisLastUpdateProduct.Instance();
            _redisWaitCrawler = RedisCompanyWaitCrawler.Instance();
            _redisCrcVisited = RedisCrcVisitedFindNew.Instance();

            _mqLogQueueVisit = MQLogQueueVisit.Instance();
            _mqLogWarning = MQLogWarningFindNew.Instance();
            _mqLogChangePrice = new MqLogChangePrice();
        }

        private void LoadVisitedCRC()
        {
            _visitedCrc.Clear();
            if (!_company.ClearQueueWhenFN)
            {

                foreach (long dr in this._redisCrcVisited.GetListCrc(_companyId))
                {
                    if (!_visitedCrc.ContainsKey(dr)) this._visitedCrc.Add(dr, true);
                }
            }

            foreach (var itemProduct in this._crcProductOldGroup)
            {
                if (!_visitedCrc.ContainsKey(itemProduct.Key)) this._visitedCrc.Add(itemProduct.Key, true);
            }
        }

        private void LoadOldQueue()
        {
            IEnumerable<string> lst = this._redisQueueFindNew.GetListCrc(this._companyId);
            foreach (var item in lst)
                _linkQueue.Enqueue(item);
            this._redisQueueFindNew.RemoveCompanyCache(this._companyId);
        }

        public void CrawlForCompany(long CompanyID)
        {
            try
            {
                this._companyId = CompanyID;
                if ((!_bCheckOtherRunning || !CheckOtherRunning()) && _productAdapter.AllowCrawlFindNew(_companyId))
                {
                    if (!_redisWaitCrawler.CheckHaveItemFindNew(_companyId))
                    {
                        _redisWaitCrawler.SetNexFindNew(_companyId, 1);
                        var company = new QT.Entities.Company(this._companyId);
                        _redisCacheCompanyCrawler.SetCompanyInfo(_companyId, company.Domain, 24, 24);
                    }
                    Crawl();
                }
                else
                {
                    _redisWaitCrawler.SetNexFindNew(_companyId, 1);
                }
            }
            catch (System.OperationCanceledException)
            {
                if (this._company != null)
                {
                    this._redisQueueFindNew.SaveQueue(this._companyId, this._linkQueue.ToArray());
                    this._redisWaitCrawler.SetRemoveRunningCrawler(_companyId);
                    this._redisWaitCrawler.SetNexFindNew(this._companyId, 1);
                    this._redisCrcVisited.SetForCompany(_companyId, new List<long>(this._visitedCrc.Keys));
                }
                throw;
            }
            catch (Exception ex02)
            {
                _log.Error(ex02);
            }
        }

        private void Crawl()
        {
            InitSession();
            while (_linkQueue.Count > 0
                && (DateTime.Now - startCrawler).TotalHours < _config.MaxHourFindNew
                && _countVisited < _config.MaxLinksFindNew)
            {
                try
                {
                    this._tokenCrawler.ThrowIfCancellationRequested();
                    DelayCrawler();
                    _urlCurrent = _linkQueue.Dequeue();
                    
                    SetRunningCompany();

                    LogData(string.Format("THR: {4} Cmp: {5} Q: {0} cVs: {1}  cNP: {2} TTP: {6} cC: {7} Url: {3}"
                        , _linkQueue.Count, _countVisited, _totalProductBefore
                        , _urlCurrent, _indexThread
                        , _company.Domain.PadRight(50, ' ')
                        , _totalProduct
                        , _countCompany));

                    if (!IsNoVisitUrl(_urlCurrent))
                    {
                        _countVisited++;
                        var html = GetHtmlCode(_urlCurrent, _config.UseClearHtml);
                        PushLogVisited(_urlCurrent, false);
                        if (html != "")
                        {
                            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                            doc.LoadHtml(html);
                            AnalysicProduct(_urlCurrent, doc);
                            ExtractionLink(doc);
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    throw;
                }
                catch (Exception ex01)
                {
                    _log.Error(ex01);
                }
            }
            CheckWarningOverMax();
            EndSession();
        }

        private void CheckWarningOverMax()
        {
            string mss = "";
            if ((DateTime.Now - startCrawler).TotalHours > _config.MaxHourFindNew) mss = "Company:{0} Domain:{1} Over time find new";
            if (_countVisited > _config.MaxLinksFindNew) mss = "Company:{0} Domain:{1} Over number link visited";
            if (!string.IsNullOrEmpty(mss)) this._mqLogWarning.PushChangeProduct(mss);
        }

 

        private void PushLogVisited(string urlCurrent,bool bOK)
        {
            _mqLogQueueVisit.PushChangeProduct(new QT.Entities.CrawlerProduct.RabbitMQ.MssLogFindNewProduct()
                {
                    CRC=0,
                    Date_Log=DateTime.Now,
                    Detail_Url=urlCurrent,
                    is_OK=bOK,
                    Product_ID=0,
                    Session=this._session
                });
        }

        private void EndSession()
        {
            if (this._linkQueue.Count == 0)
            {
                _redisCrcVisited.RemoveCrcVited(_companyId);
            }
            else
            {
                _redisCrcVisited.SetForCompany(_companyId, new List<long>(_visitedCrc.Keys));
                _redisQueueFindNew.SaveQueue(_companyId, _linkQueue.ToArray());
            }
            _redisWaitCrawler.SetRemoveRunningCrawler(_companyId);
            _redisWaitCrawler.SetNexFindNew(_companyId, _config.MinHourFindNew);
            _productAdapter.UpdateEndCrawl(_company.ID, 0, startCrawler, DateTime.Now, _countLink, _countVisited, _totalProductBefore, _countChange, _session, _totalProduct + _totalProductBefore, QT.Entities.Server.IPHost,_company.Domain);

            LogData(string.Format("                    >>>>>>>  END SESSION {0} - Vs:{1}", _company.Domain, _countVisited));
            this._visitedCrc.Clear();
            this._linkQueue.Clear();
            this._companyId = 0;
            this._company = null;
        }

        private void SetRunningCompany()
        {
            if ((DateTime.Now - _lastReportRedis).TotalMinutes > 5)
            {
                _redisWaitCrawler.SetNexFindNew(_companyId, _config.MinHourFindNew);
                _redisWaitCrawler.SetRunningCrawler(_companyId);
                _lastReportRedis = DateTime.Now;
            }
        }

        private void ClearOldCache()
        {
            if ((DateTime.Now - this._redisCacheCompanyCrawler.GetLastClearQueueCrawler(_companyId)).Days > 4)
            {
                _redisCacheCompanyCrawler.SetLastClear(_companyId);
            }
        }

        private bool CheckOtherRunning()
        {
            if (_redisWaitCrawler.CheckRunningCrawler(this._companyId))
            {
                LogData(string.Format("Thead {0}. Other running {1} crawler with session {2}. Wait next session", _indexThread, _companyId, _session));
                this._redisWaitCrawler.SetNexReload(_companyId, 1);
                return true;
            }
            else return false;
        }

        private void InitSession()
        {

            _countVisited = 0;
            _totalProductBefore = 0;
            _countLink = 0;
            _countChange = 0;

            _session = Guid.NewGuid().ToString();
            _tokenCrawler.ThrowIfCancellationRequested();
            if (!_productAdapter.AllowCrawlFindNew(_companyId)) return;
            _company = new QT.Entities.Company(this._companyId);
            _config = new Configuration(_companyId, true);
            _visitRegexs = _config.VisitUrlsRegex;
            _detailLinkRegexs = _config.ProductUrlsRegex;

            _extraRegexNoVisitFn = _productAdapter.GetEtraRegexByTypeWeb(_companyId);
            _noCrawlerRegexs = _config.NoVisitUrlRegex;
            _noCrawlerRegexs.AddRange(Common.noCrawlerRegexDefault);
            _noCrawlerRegexs.AddRange(_extraRegexNoVisitFn);

            string rootUrl = _company.Website;
            _urlCurrent = "";
            startCrawler = DateTime.Now;
            _linkQueue.Clear();
            _visitedCrc.Clear();
            _rootUri = Common.GetUriFromUrl(_company.Website);
            ClearOldCache();
            _linkQueue.Enqueue(_company.Website);
            LoadOldData();
            _totalProduct = _crcProductOldGroup.Count;
           
           
        }

        private void LoadOldData()
        {
            _crcProductOldGroup.Clear();
            var lst  = _redisLastUpdateProduct.GetAllProduct(_companyId);
            foreach(var item in _cacheProductHash.GetAllProductHash(this._companyId,lst))
            {
                if (!_crcProductOldGroup.ContainsKey(item.Id)) _crcProductOldGroup.Add(item.Id, true);
                if (!_hsHashDuplicate.ContainsKey(item.HashDuplicate)) _hsHashDuplicate.Add(item.HashDuplicate,item.Id);
            }
            LoadVisitedCRC();
            LoadOldQueue();
        }

        private void ExtractionLink(GABIZ.Base.HtmlAgilityPack.HtmlDocument doc)
        {
            var nodeLinks = doc.DocumentNode.SelectNodes("//a[@href]");
            if (nodeLinks != null)
            {
                List<string> linkOfUrl = new List<string>();
                foreach (var itemNode in nodeLinks) linkOfUrl.Add(itemNode.Attributes["href"].Value.ToString());
                foreach (string newLink in linkOfUrl)
                {
                    string newLinkFull = System.Web.HttpUtility.HtmlDecode(Common.GetAbsoluteUrl(newLink, _rootUri)).Trim();
                    if (newLinkFull.Length < MaxLengthUrl)
                    {
                        long crcNewLink = Common.GetIDProduct(newLinkFull);
                        if (!_visitedCrc.ContainsKey(crcNewLink) && !IsNoVisitUrl(newLinkFull) && IsVisitLink(newLinkFull))
                        {
                            _visitedCrc.Add(crcNewLink, true);
                            _linkQueue.Enqueue(newLinkFull);
                        }
                    }
                }
            }
        }

        private void AnalysicProduct(string urlCurrent, GABIZ.Base.HtmlAgilityPack.HtmlDocument doc)
        {
            if (IsDetailUrl(urlCurrent, _detailLinkRegexs))
            {
                if (_company.Status == Common.CompanyStatus.TIN)
                {
                    Product product = new Product();
                    product.Analytics(doc, urlCurrent, _config, false, _company.Domain);
                }
                else
                {
                    var pt = new Product();
                    pt.Analytics(doc, urlCurrent, _config, false, _company.Domain);
                    if (pt.IsSuccessData(this._config.CheckPrice))
                    {
                        pt.Valid = false;
                        if (!IsExistsProduct(pt.ID))
                        {
                            if (!this._hsHashDuplicate.ContainsKey(pt.GetHashCheckDuplicate()))
                            {
                                _totalProductBefore++;
                                _productAdapter.InsertProduct(pt);

                                _redisLastUpdateProduct.UpdateBathLastUpdateProduct(this._companyId, new List<long> { pt.ID }, DateTime.Now);
                                _cacheProductHash.SetCacheProductHash(_companyId, new List<QT.Entities.CrawlerProduct.Cache.ProductHash>
                                    {
                                         new ProductHash()
                                         {
                                             HashChange=pt.GetHashChange(),
                                             HashDuplicate=pt.GetHashCheckDuplicate(),
                                             Id=pt.ID,
                                             Price=pt.Price,
                                             url=pt.DetailUrl,
                                             HashImage=pt.GetHashImage(),
                                         }
                                    });
                                //_productAdapter.PushMQChangeImage(new List<long> { pt.ID });
                                _mqLogChangePrice.PushQueueChangePriceLog(
                                    new JobRabbitChangePrice()
                                    {
                                        Name = pt.Name,
                                        OldPrice = 0,
                                        NewPrice = pt.Price,
                                        ProductID = pt.ID,
                                        CompanyID = pt.IDCongTy
                                    });

                                AddToDuplicate(pt.GetHashCheckDuplicate(), pt.ID);
                            }
                            else
                            {
                                _log.Info("Duplicate data");
                            }
                        }
                    }
                }
            }
        }

        private void AddToDuplicate(long hash, long productId)
        {
            _hsHashDuplicate.Add(hash, productId);
        }


        private bool IsExistsProduct(long productID)
        {
            return _crcProductOldGroup.ContainsKey(productID);
        }

        private bool IsDetailUrl(string url, List<string> detailLinkRegex)
        {
            for (int i = 0; i < detailLinkRegex.Count; i++)
            {
                Match m = Regex.Match(url, detailLinkRegex[i]);
                if (m.Success)
                    return true;
            }
            return false;
        }


        private bool IsVisitLink(string url)
        {
            for (int i = 0; i < _visitRegexs.Count; i++)
            {
                if (Regex.IsMatch(url, _visitRegexs[i])) return true;
            }
            return false;
        }

        private bool IsNoVisitUrl(string url)
        {
            try
            {
                if (url == _company.Website) return false;
                foreach (var regex in _noCrawlerRegexs)
                {
                    if (Regex.IsMatch(url, regex, RegexOptions.IgnoreCase)) return true;
                }
                foreach (var regex in _visitRegexs)
                {
                    if (Regex.IsMatch(url, regex)) return false;
                }
                return true;
            }
            catch (Exception ex1)
            {
                _log.Error("Fail regex" + ex1.Message + ex1.StackTrace);
                return true;
            }
        }

        private void DelayCrawler()
        {
            
                _tokenCrawler.WaitHandle.WaitOne(_config.TimeDelay);
        }

   

        private string GetHtmlCode(string urlCurrent, bool useClearHtml)
        {
            string html = HTMLTransmitter.getHTML(urlCurrent, 45, 2);
            html = html.Replace("<form", "<div");
            html = html.Replace("</form", "</div");
            if (_config.UseClearHtml)
            {
                html = Common.TidyCleanR(html);
            }
            return html;
        }

        public void Start()
        {
            while (true)
            {
                try
                {
                    _tokenCrawler.ThrowIfCancellationRequested();
                    this.jobCrawler = GetCompanyCrawler();
                    if (this.jobCrawler != null && this.jobCrawler.CompanyID > 0)
                    {
                        var companyId = this.jobCrawler.CompanyID;
                        if (companyId > 0)
                        {
                            _tokenCrawler.ThrowIfCancellationRequested();
                            _countCompany++;
                            CrawlForCompany(jobCrawler.CompanyID);
                        }
                    }
                    else
                    {
                        int sleepGetCompany = 10;
                        LogData(string.Format("TH {0} not company crawler. Sleep {1}s", _indexThread, sleepGetCompany));
                        _tokenCrawler.WaitHandle.WaitOne(sleepGetCompany * 1000);
                    }
                }
                catch (OperationCanceledException)
                {
                    return;
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                    Thread.Sleep(10000);
                }
            }
        }

        private JobCrawler GetCompanyCrawler()
        {
            if (this._eventGetCompanyCrawler != null)
                return new JobCrawler()
                {
                    CompanyID = _eventGetCompanyCrawler()
                };
            return null;
        }

        private void LogData(string logdata)
        {
            this._log.Info(logdata);
            if (this._eventShowLog != null) this._eventShowLog(logdata);
        }
        
    }
}