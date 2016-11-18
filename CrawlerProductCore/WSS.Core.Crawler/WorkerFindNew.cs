using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using GABIZ.Base.HtmlUrl;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.DsQTCrawlerTableAdapters;
using QT.Moduls;
using QT.Moduls.Crawler;
using QT.Moduls.CrawlerProduct.Cache;
using RabbitMQ.Client;
using RabbitMQ.Client.Framing;
using Websosanh.Core.Drivers.RabbitMQ;
using Configuration = QT.Entities.Configuration;using HtmlDocument = GABIZ.Base.HtmlAgilityPack.HtmlDocument;
using QT.Moduls.CrawlerProduct;

namespace WSS.Core.Crawler
{
    public class WorkerFindNew : IWorker,IDisposable
    {
        public DelegateReportRun EventReportRun = null;
        private IDownloadHtml htmDownloader = new DownloadHtmlCrawler();

        private CancellationToken _token;
        private const int MaxLengthUrl = 500;
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(WorkerFindNew));
        private List<string> _detailLinkRegexs = null;
        private List<string> _visitRegexs = null;
        private List<string> _noCrawlerRegexs = null;

        private Queue<JobFindNew> _linkQueue = null;
        private HashSet<long> _hsDuplicateProduct = null;
        
        private TypeEnd _typeEnd = TypeEnd.None;
        private HashSet<long> _visitedCrc;
        private HashSet<long> _crcProductOldGroup;
        private Dictionary<long, long> _dicDuplicate;
        private DateTime _timeStart = DateTime.Now;

        private CacheDuplicateProduct _cacheDuplicateProduct = null;
        private RedisCrcVisitedFindNew _cacheCrcVisited = null;
        private RedisCompanyWaitCrawler _cacheWaitCrawler = null;
        private RedisLastUpdateProduct _cacheLastUpdateProduct = null;
        private CacheProductHash _cacheProductHash = null;
        private RedisCacheCompanyCrawler _cacheCacheCompanyCrawler = null;

        private int _countVisited = 0;
        private int _countNewProduct = 0;
        private readonly long _companyId = 0;private Uri _rootUri = null;
        private Configuration _config = null;
        private Company _company = null;
        private CancellationToken _tokenCrawler = new CancellationToken();
        private readonly string _session = Guid.NewGuid().ToString();

        private ProducerBasic _producerReportSessionRunning = null;
        private ProducerBasic _producerReportError = null;
        private ProducerBasic _producerProductChange = null;
        private ProducerBasic _producerPushCompanyReload = null;
        private ProducerBasic _producerDuplicateProduct = null;
        private ProducerBasic _producerEndCrawler = null;private ProducerBasic _producerVisitedLinkFindNew = null;

        private readonly string _nameThread;
        private readonly CancellationTokenSource _tokenSource = new CancellationTokenSource();
        private List<string> _linksStart;
        private int LimitProductValid = 1000;

        public WorkerFindNew(long companyId, CancellationToken token, string nameThread)
        {
            _companyId = companyId;
            _nameThread = nameThread;
            _token = token;
        }

        private void LoadCrcOldProduct()
        {
            _crcProductOldGroup.Clear();
            var lst = _cacheLastUpdateProduct.GetAllProduct(_companyId);
            foreach (var item in _cacheProductHash.GetAllProductHash(_companyId, lst))
            {
                if (!_crcProductOldGroup.Contains(item.Id)) _crcProductOldGroup.Add(item.Id);
                if (!_dicDuplicate.ContainsKey(item.HashDuplicate))
                    _dicDuplicate.Add(item.HashDuplicate, item.Id);
            }
        }

        private void ClearOldCache()
        {
            if ((DateTime.Now - _cacheCacheCompanyCrawler.GetLastClearQueueCrawler(_companyId)).Days > 4)
            {
                _cacheCacheCompanyCrawler.SetLastClear(_companyId);
            }
        }

        private void RunReportRunning()
        {
            var tokenReport = _tokenSource.Token;
            Task.Factory.StartNew(() =>
            {
                ProducerBasic _producerReportSessionRunning=null;
                try
                {
                    _producerReportSessionRunning = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.ExchangeSessionRunning, ConfigCrawler.RoutingkeySessionRunning);
                    while (true)
                    {
                        string mss =
                            Newtonsoft.Json.JsonConvert.SerializeObject(new ReportSessionRunning()
                            {
                                Thread = _nameThread,
                                CompanyId = _companyId,
                                Ip = Server.IPHost,
                                Session = _session,
                                StartAt = _timeStart,
                                Type = "FindNew",
                                MachineCode = Server.MachineCode
                            });
                        tokenReport.ThrowIfCancellationRequested();
                        _producerReportSessionRunning.PublishString(mss, true, 300);
                        Thread.Sleep(20000);
                    }
                }
                catch (OperationCanceledException ex)
                {
                    _log.Info("End thread report running");
                    if (_producerReportSessionRunning != null) _producerReportSessionRunning.Dispose();
                    return;
                }
                catch (Exception ex)
                {
                    // ignored
                }
            }, tokenReport);}

        public void StartCrawler(List<string> linksStart)
        {
            this._linksStart = linksStart;StartCrawler();
        }

        public void StartCrawler()
        {
            try
            {
                if (Init())
                {
                    RunReportRunning();
                    AddRootQueue();
                    _log.Info(GetPrefixLog());
                    while (!CheckEnd())
                    {
                        _token.ThrowIfCancellationRequested();var jobCrawl = _linkQueue.Dequeue();
                        string strLog = string.Format(GetPrefixLog() +
                                                      string.Format(" Url: {0} Deep: {1}", jobCrawl.Url, jobCrawl.Deep));
                        _log.Info(strLog);
                        if (EventReportRun != null) EventReportRun(strLog);
                        DelayCrawler();
                        if (!IsNoVisitUrl(jobCrawl.Url) &&
                            (_crcProductOldGroup.Count + _countNewProduct < LimitProductValid))
                        {
                            _countVisited++;
                            _producerVisitedLinkFindNew.PublishString(
                                Newtonsoft.Json.JsonConvert.SerializeObject(new VisitedLinkFindNew()
                                {
                                    CompanyId = _companyId,
                                    ProductId = jobCrawl.Id,
                                    Url = jobCrawl.Url,
                                    Session = _session,
                                    LastUpdate = DateTime.Now
                                }));
                            var html = GetHtmlCode(jobCrawl.Url, _config.UseClearHtml);
                            if (html != "")
                            {
                                ProcessLink(jobCrawl, html);
                            }
                        }
                    }
                    End();
                }
            }
            catch (OperationCanceledException oce)
            {
                _typeEnd = TypeEnd.Immediate;
                _log.Info("Push job back queue");
                _producerPushCompanyReload.PublishString(_companyId.ToString(), true, 0);
                End();
                throw;
            }
            catch (Exception ex01)
            {
                _log.Error(ex01);
                _producerReportError.PublishString(
                    Newtonsoft.Json.JsonConvert.SerializeObject(new ErrorCrawler()
                    {
                        CompanyId = _companyId,
                        ProductId = 0,
                        TimeError = DateTime.Now,
                        Message = ex01.Message + "\n" + ex01.StackTrace,
                        Url = ""
                    }), true, 0);
            }
        }



        private void ProcessLink(JobFindNew jobCrawl, string html)
        {
            _token.ThrowIfCancellationRequested();
            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            if (IsDetailUrl(jobCrawl.Url))
                Analysic(jobCrawl, doc);
            Extraction(doc, jobCrawl);
        }

        private bool CheckEnd()
        {
            if (_tokenCrawler.IsCancellationRequested)
            {
                _typeEnd = TypeEnd.Immediate;
                return true;
            }
            else if (_linkQueue.Count == 0)
            {
                _typeEnd = TypeEnd.Success;
                return true;
            }
            else if ((DateTime.Now - _timeStart).Hours >= _config.MaxHourFindNew)
            {
                _typeEnd = TypeEnd.OverTime;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AddRootQueue()
        {
            _linkQueue.Enqueue(new JobFindNew()
            {
                Url = _rootUri.AbsoluteUri,
                Id = Common.CrcProductID(_rootUri.AbsoluteUri),
                Deep = 0,
                ParentId = 0
            });
        }
        private void Extraction(HtmlDocument doc, JobFindNew job){
            var countLinkAdds = 0;
            var countLinks = 0;

            if (job.Deep > _config.MaxDeep){
                _log.Info("Over dee. Not extraction");
                return;
            }
            else if ( _visitedCrc.Count > _config.MaxLinksFindNew)
            {
                _log.Info("Over max link crc. Not extraction");
                return;
            }
            var nodeLinks = doc.DocumentNode.SelectNodes("//a[@href]");
            if (nodeLinks != null)
            {
                foreach (var nodelink in nodeLinks)
                {
                    countLinks++;
                    var link =
                        System.Web.HttpUtility.HtmlDecode(Common.GetAbsoluteUrl(nodelink.Attributes["href"].Value,
                            _rootUri)).Trim();

                    if (_companyId == 480254425312154563 && link.Contains("sid"))
                        link = link.Substring(0, link.IndexOf("sid", StringComparison.Ordinal) - 1);

                    if (link.Length < MaxLengthUrl)
                    {
                        var crcNewLink = Common.GetIDProduct(link);
                        if (!_visitedCrc.Contains(crcNewLink)
                            && !_crcProductOldGroup.Contains(crcNewLink)
                            && !_hsDuplicateProduct.Contains(crcNewLink)
                            && Common.CheckRegex(link, _config.VisitUrlsRegex, _config.NoVisitUrlRegex, false))
                        {
                            countLinkAdds++;
                            _visitedCrc.Add(crcNewLink);
                            _linkQueue.Enqueue(new JobFindNew()
                            {
                                Url = link,
                                Deep = job.Deep + 1,
                                ParentId = job.Id,
                                Id = Common.CrcProductID(link)
                            });
                        }
                    }
                }
            }
            _log.Info(GetPrefixLog() + string.Format("NumberLinkAdded {0}/{1}", countLinkAdds, countLinks));
        }

        private string GetPrefixLog()
        {
            var str = "";
            if (_session != "") str += string.Format(" TT: {0}", _nameThread);
            if (_session != "") str += string.Format(" SS: {0}", _session);
            if (_company != null) str += string.Format(" Cmp: {0} {1}", _company.ID, _company.Domain);
            if (_linkQueue != null) str += string.Format(" CQs: {0}", _linkQueue.Count);
            str += " CVs: " + _countVisited;
            str += " CNs: " + _countNewProduct;
            return str;
        }

   

        private bool IsExistsProduct(long productID)
        {
            return _crcProductOldGroup.Contains(productID);
        }



        private string GetHtmlCode(string urlCurrent, bool useClearHtml)
        {
            try
            {
                WebExceptionStatus webException = new WebExceptionStatus();
                string html = this.htmDownloader.GetHTML(urlCurrent, 45, 2, out webException);
                html = html.Replace("<form", "<div");
                html = html.Replace("</form", "</div");
                if (_config.UseClearHtml)
                {
                    html = Common.TidyCleanR(html);
                }
                return html;
            }
            catch(Exception ex)
            {
                _log.Error(ex);
                return "";}
        }

        private bool IsNoVisitUrl(string url)
        {
            try
            {
                if (url == _company.Website || url == (_company.Website + "/")) return false;
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


        private void Analysic(JobFindNew jobCrawl, HtmlDocument doc)
        {
            if (_company.Status == Common.CompanyStatus.TIN)
            {
                var product = new Product();
                product.Analytics(doc, jobCrawl.Url, _config, false, _company.Domain);
            }
            else
            {
                var product = new ProductEntity();
                var productParse = new ProductParse();
                productParse.Analytics(product, doc, jobCrawl.Url, _config, _company.Domain);

                if (product.IsSuccessData(_config.CheckPrice))
                {
                    product.Valid = false;
                    if (!IsExistsProduct(product.ID))
                    {

                        if (!_dicDuplicate.ContainsKey(product.GetHashDuplicate()))
                        {

                            product.StatusChange.IsNew = true;

                            PushChangeProduct(product);
                            _dicDuplicate.Add(product.GetHashDuplicate(), product.ID) ;
                            _crcProductOldGroup.Add(product.ID);
                            _countNewProduct++;

                        }

                        else
                        {
                            _producerDuplicateProduct.PublishString(
                                Newtonsoft.Json.JsonConvert.SerializeObject(new ProductDuplicate()
                                {
                                    CId = _companyId,
                                    Id = product.ID,
                                    Hash = product.GetHashDuplicate(),
                                    IdDup = _dicDuplicate[product.GetHashDuplicate()],
                                    Url = product.DetailUrl
                                }), true);
                        }
                    }
                }
            }
        }

        private void PushChangeProduct(ProductEntity pt)
        {
            _producerProductChange.PublishString(pt.GetJSON());
        }

        private bool IsDetailUrl(String url)
        {
            foreach (string t in _detailLinkRegexs)
            {
                var m = Regex.Match(url, t);
                if (m.Success)
                    return true;
            }
            return false;
        }


        public bool Init()
        {
            try
            {
                var rabbitMqCrawler = RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler);
                _producerReportSessionRunning = new ProducerBasic(rabbitMqCrawler, ConfigCrawler.ExchangeSessionRunning, ConfigCrawler.RoutingkeySessionRunning);
                _producerReportError = new ProducerBasic(rabbitMqCrawler, ConfigCrawler.ExchangeErorrCrawler, ConfigCrawler.RoutingKeyErrorCrawler);
                _producerProductChange = new ProducerBasic(rabbitMqCrawler, ConfigCrawler.ExchangeChangeProduct, ConfigCrawler.RoutingkeyChangeProduct);
                _producerDuplicateProduct = new ProducerBasic(rabbitMqCrawler, ConfigCrawler.ExchangeDuplicateProductToCache, ConfigCrawler.ExchangeDuplicateProductToCache);
                _producerPushCompanyReload = new ProducerBasic(rabbitMqCrawler, ConfigCrawler.ExchangeCompanyReload, ConfigCrawler.RoutingkeyCompanyReload);
                _producerEndCrawler = new ProducerBasic(rabbitMqCrawler, ConfigCrawler.ExchangeEndSession, ConfigCrawler.RoutingEndSession);
                _producerVisitedLinkFindNew = new ProducerBasic(rabbitMqCrawler, ConfigCrawler.ExchangeVisitedLinkFindNew, ConfigCrawler.RoutingKeyVisitedLinkFindNew);
                _company = new Company(_companyId);
                _config = new Configuration(_companyId);
                if (_config.LimitProductValid == 0) this.LimitProductValid = 1000000;
                _rootUri = new Uri(_company.Website);
                _cacheCrcVisited = RedisCrcVisitedFindNew.Instance();
                _cacheWaitCrawler = RedisCompanyWaitCrawler.Instance();
                _cacheLastUpdateProduct = RedisLastUpdateProduct.Instance();
                _cacheProductHash = CacheProductHash.Instance();
                _cacheCacheCompanyCrawler = RedisCacheCompanyCrawler.Instance();
                _cacheDuplicateProduct=CacheDuplicateProduct.Instance();
                _company = new Company(_companyId);
                _config = new Configuration(_companyId);
                _visitedCrc = new HashSet<long>();
                _linkQueue = new Queue<JobFindNew>();
                _crcProductOldGroup = new HashSet<long>();
                _dicDuplicate =new Dictionary<long, long>();
                _countVisited = 0;
                _countNewProduct = 0;
                _tokenCrawler.ThrowIfCancellationRequested();
                _visitRegexs = _config.VisitUrlsRegex;
                _detailLinkRegexs = _config.ProductUrlsRegex;
                _noCrawlerRegexs = _config.NoVisitUrlRegex;
                _noCrawlerRegexs.AddRange(UtilCrawlerProduct.NoCrawlerRegexDefault);
                _timeStart = DateTime.Now;
                _rootUri = Common.GetUriFromUrl(_company.Website);
                _hsDuplicateProduct = _cacheDuplicateProduct.GetHashDuplicate(_companyId);


                ClearOldCache();
                LoadCrcOldProduct();
                LoadOldQueue();

                return true;
            }
            catch (Exception ex)
            {
                _log.Error(string.Format("Company:{0} {1} {2}",_companyId, ex.Message, ex.StackTrace));
                string mss =
                    Newtonsoft.Json.JsonConvert.SerializeObject(new ErrorCrawler() {CompanyId = _companyId, ProductId = 0, TimeError = DateTime.Now, Message = "Init" + ex.Message + ex.StackTrace});
                _producerReportError.PublishString(mss, true);
                return false;
            }
        }

        private void SaveChange()
        {
            try
            {
                using (var adapter = new QueueTableAdapter())
                {
                    _log.Info(string.Format("Save to queue: {0} add", _linkQueue.Count));
                    adapter.Connection.ConnectionString = ConfigCrawler.ConnectionCrawlerQueue;
                    DsQTCrawler.QueueDataTable queueTable = new DsQTCrawler.QueueDataTable();
                    foreach (var job in _linkQueue)
                    {
                        var row = queueTable.NewQueueRow();
                        row.Deep = job.Deep;
                        row.Id = 0;
                        row.ParentId = job.ParentId;
                        row.Url = job.Url;
                        row.CompanyId = _companyId;
                        queueTable.AddQueueRow(row);
                    }
                    SqlBulkCopy bulkCopy = new SqlBulkCopy
                        (adapter.Connection,
                            SqlBulkCopyOptions.TableLock |
                            SqlBulkCopyOptions.FireTriggers |
                            SqlBulkCopyOptions.UseInternalTransaction,
                            null) {DestinationTableName = "Queue"};
                    adapter.Connection.Open();
                    bulkCopy.WriteToServer(queueTable);
                    adapter.Connection.Close();
                }
            }
            catch (Exception ex0)
            {
            }
        }

        private void LoadOldQueue()
        {
            if (_linksStart != null && _linksStart.Count > 0)
            {
                foreach (var link in _linksStart)
                {
                    _linkQueue.Enqueue(new JobFindNew() {Id = Common.CrcProductID(link), Deep = 0, ParentId = 0, Url = link});
                }
                LogImportantInfo(string.Format("Loaded {0} begin links", _linksStart.Count));
            }

            using (var adapter = new QueueTableAdapter())
            {
                adapter.Connection.ConnectionString = ConfigCrawler.ConnectionCrawlerQueue;
                var lst = new List<JobFindNew>();
                var tbl = adapter.FillByPageOfCompany(_companyId, 10000, 1);
                foreach (var a in tbl.Rows)
                {
                    DsQTCrawler.QueueRow row = a as DsQTCrawler.QueueRow;
                    _linkQueue.Enqueue(new JobFindNew()
                    {
                        Id = Common.CrcProductID(row.Url),
                        Deep = row.Deep,
                        ParentId = row.ParentId,
                        Url = row.Url
                    });
                }
                adapter.Connection.Close();
            }
        }

        public void LogImportantInfo(string info)
        {
            this._log.Info(info);
            if (this.EventReportRun != null) this.EventReportRun(info);
        }

        public void End()
        {
            string strLog = string.Format("End crawler {0}", _typeEnd);
            if (EventReportRun != null) EventReportRun(strLog);_log.Info(strLog);
            this.UpdateEndCrawl(new CrawlerSessionLog()
            {
                CompanyId = _companyId,
                Domain = _company.Domain,
                StartAt = _timeStart,
                EndAt = DateTime.Now,
                CountVisited = _countVisited,
                Ip = Server.IPHost,
                Session = _session,
                TypeRun = "AUTO",
                TypeCrawler = 0,
                CountChange = _countNewProduct,
                TotalProduct = _company.TotalProduct,
                CountProduct = 0,
                TypeEnd = _typeEnd.ToString(),
                NumberDuplicateProduct = _hsDuplicateProduct.Count
            });

            if (_typeEnd != TypeEnd.Success)
            {
                SaveChange();
            }
            else
            {
                var queueTableAdapter = new QueueTableAdapter();
                queueTableAdapter.Connection.ConnectionString = ConfigCrawler.ConnectionCrawlerQueue;
                queueTableAdapter.DeleteByCompanyId(_companyId);
                queueTableAdapter.Connection.Close();
                _cacheCrcVisited.RemoveCrcVited(_companyId);
            }
            _cacheWaitCrawler.SetRemoveRunningCrawler(_companyId);
            _cacheWaitCrawler.SetNexFindNew(_companyId, 1);
                                       
            _tokenSource.Cancel();
        }

        private void UpdateEndCrawl(CrawlerSessionLog crawlerSessionLog)
        {
            _producerEndCrawler.PublishString(crawlerSessionLog.ToJson());
        }

        public void Stop()
        {
        }

        public void Dispose()
        {
            if (_producerDuplicateProduct != null) _producerDuplicateProduct.Dispose();
            if (_producerEndCrawler != null) _producerEndCrawler.Dispose();
            if (_producerProductChange != null) _producerProductChange.Dispose();
            if (_producerPushCompanyReload != null) _producerPushCompanyReload.Dispose();
            if (_producerReportError != null) _producerReportError.Dispose();
            if (_producerReportSessionRunning != null) _producerReportSessionRunning.Dispose();
            if (_producerProductChange != null) _producerProductChange.Dispose();
        }
    }
}
