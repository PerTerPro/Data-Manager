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
using GABIZ.DAS.ContentAnalysis;
using QT.Entities.Data;
using OpenQA.Selenium.Firefox;
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
using ServiceStack.Logging;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmCrawlerProduct : Form
    {
        int iCompany = 0;
        CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        CancellationToken tokenCrawler;

        public delegate QT.Moduls.CrawlerProduct.JobCrawler DeletegateGetCompanyCrawler();
        public DeletegateGetCompanyCrawler _delegateGetCompanyCrawler;

        public Queue<long> QueueCompanyCrawler = new Queue<long>();
        public bool AutomaticCrawler { get; set; }


        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmCrawlerProductMQ));

        ProductAdapter productAdapterForm = null;
        QT.Entities.CrawlerProduct.CrawlerProductAdapter crawlerAdapter = null;

        private ProductLogAddAdapter productLogAddAdapter = null;
        private SqlDb sqlDbLog = null;


        private DBTableAdapters.ProductTableAdapter _adtProduct;
        public QT.Moduls.Crawler.DBCrawlerTableAdapters.Price_LogsTableAdapter _adtPriceLog;

        private QT.Entities.Company company;
        private List<long> queueLinkCrawlerCRC;


        private List<string> P_Show;
        private Uri rootUri;
        private bool pause = false;
        private int ignoredCount = 0;
        private QT.Entities.Configuration config;

        private bool showLog = true;
        public bool IsClose = false;
        public QT.Entities.Common.CrawlerCommand crawlerCommand;

        public bool _bTimSPMoi = false;
        public bool _bQuetSPCu = false;
        public QT.Entities.Common.ListWebCommand WebCommand = Common.ListWebCommand.ReloadManual;


        public int TypeCrawler = 0;
        private long IdCompany = 0;
        private bool showLogProduct = true;
        public string Procedure;
        private bool bChangeAll = false;
        private bool bCheckDumplicate;
        private DateTime dtStartCrawler = DateTime.Now;
        private JobCrawler JobRunning;

        public FrmCrawlerProduct(long idCongTy)
        {
            InitializeComponent();
            InitData();
            this.IdCompany = idCongTy;
        }

        public FrmCrawlerProduct()
        {
            InitializeComponent();
            InitData();
        }
        private void InitData()
        {
            _adtProduct = new DBTableAdapters.ProductTableAdapter();
            _adtProduct.Connection.ConnectionString = Server.ConnectionString;
            _adtPriceLog = new QT.Moduls.Crawler.DBCrawlerTableAdapters.Price_LogsTableAdapter();
            _adtPriceLog.Connection.ConnectionString = Server.ConnectionString;
            crawlerAdapter = new CrawlerProductAdapter(new SqlDb(QT.Entities.Server.ConnectionStringCrawler));
            this.productAdapterForm = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            this.Text = "W..";
        }

        private void LoadCongTy(long idCongTy)
        {
            this.productLogAddAdapter = new Entities.Data.ProductLogAddAdapter(this.sqlDbLog);
            this.IdCompany = idCongTy;
            this.company = new Entities.Company(IdCompany);
            this.config = new QT.Entities.Configuration(idCongTy, true);
        }



        private void HandlerCrawler(TaskCrawlerCompany taskCrawlerCompany)
        {
            if (this.TypeCrawler == 0)
            {
                HandlerAFindNewProduct(taskCrawlerCompany);
            }
            else if (this.TypeCrawler == 1 || this.TypeCrawler == 2)
            {
                HandlerCrawlerReload(taskCrawlerCompany);
            }
        }

        private void HandlerCrawlerReload(TaskCrawlerCompany task)
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            try
            {
                if (!productAdapter.CheckAllowCrawler(task.IdCompany) ||
                    (AutomaticCrawler && !productAdapter.CheckAllowAutoCrawlerReload(task.IdCompany))) return;

                bool bErrorWebsite = false;
                IdCompany = task.IdCompany;
                config = new Configuration(IdCompany, true);
                company = new Entities.Company(IdCompany);
                productAdapter.UpdateLastJobForDb(company.ID);
                productAdapter.UpdateLastReloadCrawler(company.ID);
                #region {Init variable}
                List<Product> lstProductChange = new List<Product>();           //DS hàng có thông tin thay đổi trong 1 session crawler.
                List<long> lstPushChangeImageToMQ = new List<long>();           //DS hàng có ảnh thay đổi cần push lên MQ
                List<long> lstAddToBlackList = new List<long>();
                dtStartCrawler = DateTime.Now;
                Queue<QT.Moduls.Crawler.Job> crawlerLink = new Queue<QT.Moduls.Crawler.Job>();
                List<long> visitedCRC = new List<long>();
                List<string> crawlerRegex = config.VisitUrlsRegex;
                List<string> detailLinkRegex = config.ProductUrlsRegex;
                List<string> noCrawlerRegex = config.NoVisitUrlRegex;
                int CountProducts = 0;
                int visitedCount = 0;
                string rootUrl = company.Website;

                try
                {
                    rootUri = new Uri(rootUrl);
                }
                catch (Exception ex01)
                {
                    crawlerAdapter.LogError(company.ID, ex01.Message + ex01.StackTrace);
                    productAdapter.UpdateCountProductAfterCrawler(this.company.ID, dtStartCrawler, DateTime.Now, this.TypeCrawler, "Error root link");
                }
                #endregion
                try
                {
                    this.Invoke(new Action(() =>
                    {
                        try
                        {
                            this.Text = "RL:" + iCompany.ToString() + ":" + company.Domain;
                            this.txtCompanyID.Text = company.ID.ToString();
                            this.timeDelayTextBox.Text = this.config.TimeDelay.ToString();
                            this.chkAutoDelete.Checked = config.AutoDelete;
                            this.chkAutoDelete.Enabled = true;
                            this.ckCheckDumplicate.Checked = true;
                            this.txtTotalProduct.Text = company.TotalProduct.ToString();
                            this.itemReCrawlerTextBox.Text = config.ItemReCrawler.ToString();
                        }
                        catch (Exception ex01) { }
                    }));
                }
                catch (Exception ex02) { }

                //Kiểm tra lỗi website.
                if (this.GetHtmlCode(company.Website, false) == "")
                {
                    bErrorWebsite = true;
                }
                else
                {
                    LoadProductNeedReload(task, crawlerLink, visitedCRC, productAdapter);
                    while (crawlerLink.Count > 0
                        && (DateTime.Now - dtStartCrawler).TotalHours < company.MaxHourCrawlerReload)
                    {
                        this.tokenCrawler.ThrowIfCancellationRequested();

                        productAdapter.UpdateLastJobForCompany(this.company.ID, this.TypeCrawler);

                        this.tokenCrawler.ThrowIfCancellationRequested();
                        visitedCount++;

                        this.Invoke(new Action(() =>
                        {
                            label1.Text = (120 * 60 - (DateTime.Now - dtStartCrawler).TotalSeconds).ToString();
                        }));

                        if (!pause)
                        {
                            QT.Moduls.Crawler.Job jobReload = crawlerLink.Dequeue();
                            try
                            {
                                #region {Sleep before crawler data advoid block from server}
                                if (visitedCount > 200 && visitedCount % 200 == 0)
                                {
                                    //Chờ 5 phút chạy tiếp.
                                    int iCountWait = 2 * 60;
                                    while (iCountWait > 0)
                                    {
                                        this.Invoke(new Action(() =>
                                        {
                                            laStickNormal.Text = iCountWait.ToString();
                                        }));
                                        iCountWait--;
                                        Thread.Sleep(1000);
                                    }
                                }
                                else
                                {
                                    Thread.Sleep(config.TimeDelay);
                                }
                                #endregion

                                #region {Analysic product from HTML}
                                Product _product = new Product() { ID = jobReload.ProductId };
                                string html = this.GetHtmlCode(jobReload.url, config.UseClearHtml);
                                if (html != "")
                                {
                                    GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                                    doc.LoadHtml(html);
                                    _product.Analytics(doc, jobReload.url, config, false, company.Domain);
                                    _product.ID = jobReload.ProductId;
                                }
                                #endregion

                                #region {Save product}

                                #region{Sync RedisDb If Not Exists}
                                if (!RedisCacheProductInfoAdapter.Instance().ExistsInCache(company.ID, jobReload.ProductId))
                                    productAdapter.SyncToCache(jobReload.ProductId);
                                #endregion

                                if (_product != null && _product.IsSuccessData())
                                {
                                    _product.Valid = true;
                                    RedisCacheProductInfoAdapter.Instance().ResetCountFail(_product.ID, _product.IDCongTy);
                                    long hashDumplicateCurrent = RedisCacheCheckDuplicateAdapter.Instace().GetProductIDOfHash(_product.IDCongTy, _product.GetHashCheckDumplicate());
                                    if (bCheckDumplicate && hashDumplicateCurrent > 0 && hashDumplicateCurrent != _product.ID)
                                    {
                                        _product.ProductDuplicate = hashDumplicateCurrent;
                                        _product.Valid = false;
                                    }
                                }
                                else if (this.config.MaxToNoValid >= 0)
                                {
                                    int FailCurrent = RedisCacheProductInfoAdapter.Instance().GetCountFail(_product.ID, _product.IDCongTy);

                                    if (this.config.MaxToNoValid == 0 || FailCurrent > config.MaxToNoValid)
                                    {
                                        _product.Valid = false;
                                    }
                                    RedisCacheProductInfoAdapter.Instance().IncrementCountFail(_product.ID, _product.IDCongTy);
                                    if (this.company.AllowAutoBlackLink && FailCurrent > 10)
                                    {
                                        lstAddToBlackList.Add(_product.ID);
                                    }
                                }


                                //CheckChange
                                long ProductHashChange = _product.GetHashChange();
                                long ProductHashOld = RedisCacheProductInfoAdapter.Instance().GetHashChangeOfProduct(_product.IDCongTy, _product.ID);
                                if (this.bChangeAll || ProductHashChange != ProductHashOld)
                                {
                                    RedisCacheProductInfoAdapter.Instance().SaveLastChangeProduct(_product);
                                    if (_product.IsSuccessData())
                                    {
                                        ShowProduct(_product);
                                    }
                                    else
                                    {
                                        this.Invoke(new Action(() =>
                                        {
                                            this.txtResult.AppendText(string.Format("\r\n NoVisible product: {0} : {1}", jobReload.ProductId, _product.DetailUrl));
                                        }));
                                    }

                                    #region {TrackPriceChange}
                                    try
                                    {
                                        long ProductPrice = _product.Price;
                                        long ProductPriceOld = RedisCacheProductInfoAdapter.Instance().GetPriceOfProduct(_product.IDCongTy, _product.ID);
                                        if (ProductPrice > 0 && ProductPrice != ProductPriceOld)
                                        {
                                            productAdapter.PushQueueChangePriceLog(jobReload.ProductId, ProductPrice, ProductPriceOld);
                                        }
                                    }
                                    catch (Exception ex01)
                                    {
                                        log.Error("Can't push price change to MQ:", ex01);
                                    }
                                    #endregion

                                    #region {Track Change Image}
                                    long ProductHashImage = _product.GetHashImage();
                                    long ProductHashImageOld = RedisCacheProductInfoAdapter.Instance().GetHashImageOfProduct(_product.ID);
                                    if ((bChangeAll && _product.Valid) ||
                                        (_product.Valid && ProductHashImage != ProductHashImageOld && !string.IsNullOrEmpty(_product.ImageUrl)))
                                    {
                                        lstPushChangeImageToMQ.Add(_product.ID);
                                    }
                                    #endregion

                                    CountProducts++;
                                    lstProductChange.Add(_product);
                                }
                                else
                                {
                                    this.Invoke(new Action(() =>
                                    {
                                        txtResult.AppendText(string.Format("\r\n Not change: {0} : {1} : {2}", jobReload.ProductId, jobReload.url, _product.Valid));
                                    }));
                                }
                                #endregion

                                #region {show log}
                                this.Invoke((MethodInvoker)delegate
                                {
                                    lblVisited.Text = visitedCount.ToString();
                                    lblQueue.Text = crawlerLink.Count.ToString();
                                    lblProduct.Text = CountProducts.ToString();
                                    txtUrlCurrent.Text = jobReload.url;
                                    var xx = DateTime.Now - dtStartCrawler;
                                    DateTime mydate = new DateTime(xx.Ticks);
                                    lblTime.Text = mydate.ToString("HH:mm:ss");
                                    lblIgnored.Text = ignoredCount.ToString();
                                });
                                #endregion
                            }
                            catch (Exception ex)
                            {
                                try
                                {
                                    this.Invoke(new Action(() =>
                                    {
                                        this.txtResult.AppendText(string.Format("\n\rException when process link:{0}.\n\r{1}.\n\r{2}.\n\r Wait 10s", jobReload, ex.Message, ex.StackTrace));
                                    }));
                                    Thread.Sleep(10000);
                                }
                                catch (Exception ex01)
                                {

                                }
                            }
                        }
                        else
                        {
                            Thread.Sleep(10000);
                        }

                        #region{Nạp thêm dữ liệu vào để xử lí}
                        //SaveChangeProduct(lstProductChange, productAdapter, lstPushChangeImageToMQ);
                        if (crawlerLink.Count == 0)
                        {
                            if (lstProductChange.Count > 100 || lstPushChangeImageToMQ.Count > 100)
                            {
                                SaveChangeProduct(lstProductChange, productAdapter, lstPushChangeImageToMQ);
                            }
                            LoadProductNeedReload(task, crawlerLink, visitedCRC, productAdapter);
                        }
                        #endregion
                    }
                }
                SaveChangeProduct(lstProductChange, productAdapter, lstPushChangeImageToMQ);
                SaveBlackListProduct(lstAddToBlackList, productAdapter, company.ID);

                #region {kết thúc và giải phóng bộ nhớ}

                productAdapter.UpdateLastEndForCompany(this.company.ID, this.TypeCrawler, (bErrorWebsite) ? "Error server" : "");
                productAdapter.UpdateCountProductAfterCrawler(this.company.ID, this.dtStartCrawler, DateTime.Now, this.TypeCrawler, "");

                this.tokenCrawler.ThrowIfCancellationRequested();
                this.Invoke((MethodInvoker)delegate
                {
                    this.laStatus.Text = "Crawler History Product finish waiting";
                    if (IsClose) { this.Close(); }
                    this.Text = "W...";
                });

                crawlerLink.Clear();
                crawlerLink = null;
                visitedCRC.Clear();
                visitedCRC = null;

                if (!this.AutomaticCrawler)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Text = "End crawler: " + company.Domain;
                    }));
                    Thread.Sleep(1000 * 60 * 60);
                }

                return;
                #endregion
            }
            catch (System.OperationCanceledException ex01)
            {
                if (this.company != null)
                {
                    productAdapter.UpdateCountProductAfterCrawler(company.ID, dtStartCrawler, DateTime.Now, this.TypeCrawler, "CancellationByUser");
                    productAdapter.UpdateWaitRLCrawler(company.ID);
                }
            }
            catch (Exception ex02)
            {
                //Lỗi khi crawl dữ liệu cần sửa. => Chạy lại.
                WriteLog(string.Format("Exception code when process a job crawler:{0}. Wait 1' to back process job", ex02.Message + ex02.StackTrace));
            }
        }
        private void LogTrackCrawler(string logData)
        {

        }

        private void SaveBlackListProduct(List<long> lstAddToBlackList, ProductAdapter productAdapter, long CompanyID)
        {
            lstAddToBlackList.Clear();
        }

        private void SaveChangeProduct(List<Product> lstProductChange, ProductAdapter productAdapter, List<long> lstPushChangeImageToMQ)
        {
            productAdapter.UpdateListProductChangeToDb(lstProductChange);
            AddToReusltText(string.Format("\r\nUpdated to database:{0} products", lstProductChange.Count.ToString()));
            productAdapter.PushProcessProductChangeImage(lstPushChangeImageToMQ, company.AllowAutoPushNewProduct);
            foreach (var productChanged in lstProductChange)
            {
                if (!lstPushChangeImageToMQ.Contains(productChanged.ID))
                {
                    RabbitMQAdapter.Instance.PushProductToQueueChangeMainInfo(productChanged.ID);
                }
            }
            lstProductChange.Clear();
            lstPushChangeImageToMQ.Clear();
        }

        private void AddToReusltText(string p)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    this.txtResult.AppendText(p);
                }));
            }
            catch (Exception ex01)
            {

            }
        }

        /// <summary>
        /// Đẩy dữ liệu cần Reload vào Queue
        /// </summary>
        /// <param name="task"></param>
        /// <param name="crawlerLink"></param>
        /// <param name="visitedCRC"></param>
        private void LoadProductNeedReload(TaskCrawlerCompany task, Queue<QT.Moduls.Crawler.Job> crawlerLink, List<long> visitedCRC, ProductAdapter productAdapter)
        {
            DataTable dtProduct = null;
            while (dtProduct == null)
            {
                dtProduct = productAdapter.GetNeedReloadProduct(IdCompany, task.DatePushJob, this.TypeCrawler);
                if (dtProduct == null) Thread.Sleep(10000);
            }

            for (int i = 0; i < dtProduct.Rows.Count; i++)
            {
                crawlerLink.Enqueue(new Crawler.Job()
                {
                    url = dtProduct.Rows[i]["DetailUrl"].ToString().Trim(),
                    ProductId = Convert.ToInt64(dtProduct.Rows[i]["ID"].ToString())
                });
            }
        }

        private void LogHtmlToCassandra(Product _product, ProductHtmlLogCassandra.ProductHtmlLogCassandraAdapter cassandraDbLogHtml, string html)
        {
            if (cassandraDbLogHtml != null)
                cassandraDbLogHtml.UpdateHtmlLog(_product.ID, company.ID, DateTime.Now, html, _product.DetailUrl);
        }

        private void HandlerAFindNewProduct(TaskCrawlerCompany task)
        {
            this.tokenCrawler.ThrowIfCancellationRequested();

            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            //Lặp lại hệ thống cho đến khi không còn lỗi xử lí bên trong.
            try
            {
                this.tokenCrawler.ThrowIfCancellationRequested();


                if (!productAdapter.CheckAllowCrawler(task.IdCompany) ||
                    (AutomaticCrawler && !productAdapter.CheckAllowAutoCrawlerFindNew(task.IdCompany))) return;

                #region {Int Data}
                //ProductHtmlLogCassandra.ProductHtmlLogCassandraAdapter cassandraDbLogHtml = null;
                //try
                //{
                //    cassandraDbLogHtml = ProductHtmlLogCassandra.ProductHtmlLogCassandraAdapter.Instance;
                //}
                //catch (Exception ex01)
                //{
                //    log.Error(ex01);
                //}

                DBQueue.QueueLinksDataTable dtQueueBulkCopy = new DBQueue.QueueLinksDataTable();
                DBQueue.VisitedLinksDataTable dtVisitedBulkCopy = new DBQueue.VisitedLinksDataTable();
                DateTime dtTickToReportRun = DateTime.Now;
                int CountInsert = 50;           //Số sản phẩm 1 lần cập nhật xuống Db
                int indexPositionQueue = 1;
                int indexPositionLinkVisited = 1;
                int iMaxLongFindNew = 60 * 10; //10 Tiếng
                string urlCurrent = "";

                DateTime dtStartCrawler = DateTime.Now;
                Queue<string> crawlerLink = new Queue<string>();
                List<long> visitedCRC = new List<long>();
                List<long> lstDeleteLinkCrc = new List<long>();
                this.TypeCrawler = task.iType;
                this.IdCompany = task.IdCompany;
                this.LoadCongTy(task.IdCompany);
                productAdapter.UpdateLastCrawlerFindNew(this.company.ID);
                productAdapter.LastJobCrawlerFindNew(this.company.ID);
                #endregion

                if (!this.IsHandleCreated) this.CreateHandle();
                this.Invoke(new Action(() =>
                {
                    this.Text = "FN:" + iCompany.ToString() + ":" + company.Domain;
                    this.txtCompanyID.Text = company.ID.ToString();
                    this.timeDelayTextBox.Text = this.config.TimeDelay.ToString();
                    this.chkAutoDelete.Checked = config.AutoDelete;
                    this.chkAutoDelete.Enabled = false;
                    this.txtTotalProduct.Text = company.TotalProduct.ToString();
                }));

                string rootUrl = company.Website;
                config = new Configuration(IdCompany, true);
                rootUri = Common.GetUriFromUrl(rootUrl);


                if (rootUri == null || (config.FixedLinkShow == true))
                {
                    productAdapter.UpdateLastEndForCompany(company.ID, this.TypeCrawler);
                    return;
                }
                else
                {
                    //Xóa queue
                    if (((DateTime.Now - RedisCompanyInfoAdapter.GetLastClearQueueCrawler(task.IdCompany)).Days > 4)
                        || this.company.ClearQueueWhenFN)
                    {
                        bool bRun = this.crawlerAdapter.ClearSessionCrawler(task.IdCompany);
                        if (bRun == true)
                        {
                            RedisCompanyInfoAdapter.SetLastClear(task.IdCompany);
                            this.log.Info("Clear queue crawler sucess");
                        }
                    }

                    #region Khởi tạo biến
                    queueLinkCrawlerCRC = new List<long>();
                    int visitedCount = 0;
                    List<string> crawlerRegex = config.VisitUrlsRegex;
                    List<string> detailLinkRegex = config.ProductUrlsRegex;
                    List<string> noCrawlerRegex = config.NoVisitUrlRegex;
                    P_Show = new List<string>();
                    int CountProducts = 0;
                    crawlerLink = new Queue<string>();
                    visitedCRC = new List<long>();
                    #endregion
                    crawlerLink.Enqueue(rootUrl);

                    #region Load link đã visited đưa vào visitedCRC
                    int CountVisited = LoadVisitedCrawler(task.IdCompany, visitedCRC, crawlerAdapter);
                    #endregion

                    #region Load Product đã quét vào visitedCRC để không quét lại.
                    int CountOldProduct = LoadOldProductToVisistedCrc(task.IdCompany, visitedCRC, productAdapter);
                    CountProducts = CountProducts + CountOldProduct;
                    #endregion

                    this.tokenCrawler.ThrowIfCancellationRequested();

                    #region Load queue đã lưu lại trong db
                    LoadOldQueueCrawler(crawlerAdapter, crawlerLink, queueLinkCrawlerCRC, task.IdCompany);
                    #endregion

                    #region Xử lí queue crawler
                    while (crawlerLink.Count > 0 &&
                        (DateTime.Now - dtStartCrawler).TotalHours < company.MaxHourCrawlerReload)
                    {
                        this.tokenCrawler.ThrowIfCancellationRequested();
                        if ((DateTime.Now - dtTickToReportRun).TotalMinutes > 5)
                        {
                            //Cập nhật LastJob cuối cùng.
                            dtTickToReportRun = productAdapter.LastJobCrawlerFindNew(this.company.ID);
                        }
                        WaitAfterCycle(config, visitedCount);

                        if (!pause)
                        {
                            urlCurrent = crawlerLink.Dequeue();
                            long crcLink = Common.GetIDProduct(urlCurrent);
                            ShowLogLink(-1, urlCurrent);
                            if (IsNoVisitUrl(urlCurrent, noCrawlerRegex))
                            {
                                DeleteQueueLinkCrawlerNew(task.IdCompany, crawlerAdapter, crcLink, lstDeleteLinkCrc);
                            }
                            else
                            {
                                int indexInVisited = visitedCRC.BinarySearch(crcLink);
                                if (indexInVisited > 0)
                                {
                                    DeleteQueueLinkCrawlerNew(task.IdCompany, crawlerAdapter, crcLink, lstDeleteLinkCrc);
                                }
                                else
                                {
                                    try
                                    {
                                        visitedCRC.Insert(~indexInVisited, crcLink);
                                        dtVisitedBulkCopy.Rows.Add(-indexPositionLinkVisited, crcLink, IdCompany);
                                        indexPositionLinkVisited++;

                                        Thread.Sleep(config.TimeDelay);
                                        string html = this.GetHtmlCode(urlCurrent, config.UseClearHtml);
                                        if (html != "")
                                        {
                                            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                                            doc.LoadHtml(html);

                                            #region {Extraction}
                                            var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");
                                            if (a_nodes != null)
                                            {
                                                List<string> lstLink = new List<string>();
                                                foreach (var itemNode in a_nodes) lstLink.Add(itemNode.Attributes["href"].Value.ToString());
                                                for (int i = 0; i < a_nodes.Count; i++)
                                                {
                                                    string url = System.Web.HttpUtility.HtmlDecode(Common.GetAbsoluteUrl(a_nodes[i].Attributes["href"].Value, rootUri)).Trim();
                                                    if (url.Length < 512)
                                                    {
                                                        long s_crc = Common.GetIDProduct(url);
                                                        if (!IsNoVisitUrl(url, noCrawlerRegex))
                                                        {
                                                            if (IsRelevantUrl(url, crawlerRegex))
                                                            {
                                                                int indexQueue = queueLinkCrawlerCRC.BinarySearch(s_crc);
                                                                if (indexQueue < 0)
                                                                {
                                                                    int indexVisited = visitedCRC.BinarySearch(s_crc);
                                                                    if (indexVisited < 0)
                                                                    {
                                                                        crawlerLink.Enqueue(url);
                                                                        queueLinkCrawlerCRC.Insert(~indexQueue, s_crc);
                                                                        dtQueueBulkCopy.Rows.Add(-indexPositionQueue, s_crc, this.IdCompany, url);
                                                                        indexPositionQueue++;
                                                                        this.ShowLogLink(crawlerLink.Count);
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }

                                                #region Inser db crawler {Lưu queue và visited lại nếu dữ liệu > 50}
                                                SaveQueuAndVisited(dtQueueBulkCopy, dtVisitedBulkCopy, CountInsert
                                                    , ref indexPositionQueue, ref indexPositionLinkVisited);
                                                #endregion
                                            }
                                            #endregion

                                            #region {AnalyicProduct}
                                            if (IsDetailUrl(urlCurrent, detailLinkRegex))
                                            {
                                                if (company.Status == Common.CompanyStatus.TIN)
                                                {
                                                    QT.Entities.Product _product = new Product();
                                                    _product.Analytics(doc, urlCurrent, config, false, company.Domain);
                                                    CountProducts++;
                                                    ShowProduct(_product);
                                                    InsertNews(_product);
                                                }
                                                else
                                                {
                                                    QT.Entities.Product _product = new Product();
                                                    _product.Analytics(doc, urlCurrent, config, false, company.Domain);
                                                    if (_product != null && _product.IsSuccessData())
                                                    {
                                                        if (!RedisCacheProductInfoAdapter.Instance().ExistsInCache(company.ID, _product.ID))
                                                        {
                                                            ShowProduct(_product);
                                                            //LogHtmlToCassandra(_product, cassandraDbLogHtml, html);
                                                            productAdapter.InsertProduct(_product);
                                                            CountProducts++;
                                                        }
                                                        else
                                                        {
                                                            this.Invoke(new Action(() =>
                                                            {
                                                                this.txtResult.AppendText(string.Format("\r\nExisted product {0} in db", _product.DetailUrl));
                                                            }));
                                                        }
                                                    }
                                                    else
                                                    {
                                                        ignoredCount++;
                                                    }
                                                }
                                            }
                                            #endregion

                                            if (showLog)
                                            {
                                                #region show log
                                                this.Invoke((MethodInvoker)delegate
                                                {
                                                    lblVisited.Text = visitedCount.ToString();
                                                    lblQueue.Text = crawlerLink.Count.ToString();
                                                    lblProduct.Text = CountProducts.ToString();
                                                    txtUrlCurrent.Text = urlCurrent;
                                                    var xx = DateTime.Now - dtStartCrawler;
                                                    DateTime mydate = new DateTime(xx.Ticks);
                                                    lblTime.Text = mydate.ToString("HH:mm:ss");
                                                    lblIgnored.Text = ignoredCount.ToString();
                                                    label9.Text = (((DateTime.Now - dtStartCrawler).TotalMinutes - iMaxLongFindNew) * 1).ToString() + "'";

                                                });
                                                #endregion
                                            }

                                        }
                    #endregion
                                    }
                                    catch (Exception ex)
                                    {
                                        log.Error(ex);
                                    }
                                }
                            }

                            #region show log
                            try
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    try
                                    {
                                        lblVisited.Text = visitedCount.ToString();
                                        lblQueue.Text = crawlerLink.Count.ToString();
                                        lblProduct.Text = CountProducts.ToString();
                                        txtUrlCurrent.Text = urlCurrent;
                                        var xx = DateTime.Now - dtStartCrawler;
                                        DateTime mydate = new DateTime(xx.Ticks);
                                        lblTime.Text = mydate.ToString("HH:mm:ss");
                                        lblIgnored.Text = ignoredCount.ToString();
                                    }
                                    catch (Exception ex01) { }
                                });
                            }
                            catch (Exception ex02) { }
                            #endregion
                        }
                        else
                        {
                            Thread.Sleep(10000);
                        }
                        visitedCount++;
                    }
                }

                #region kết thúc và giải phóng bộ nhớ
                if (crawlerLink.Count == 0) crawlerAdapter.ClearSessionCrawler(company.ID);
                productAdapter.UpdateLastEndForCompany(company.ID, this.TypeCrawler);
                this.Invoke((MethodInvoker)delegate
                {
                    if (IsClose) { this.Close(); }
                    this.Text = "W...";
                });
                this.ClearAfterCrawlerCompany();

                if (!this.AutomaticCrawler)
                {
                    try
                    {
                        this.Invoke(new Action(() =>
                        {
                            this.Text = "End FindNew: " + company.Domain;
                        }));
                    }
                    catch (Exception ex01) { }
                    Thread.Sleep(1000 * 60 * 60);
                }
                return;
                #endregion
            }
            catch (System.OperationCanceledException ex01)
            {
                if (this.company != null)
                {
                    productAdapter.UpdateCountProductAfterCrawler(company.ID, dtStartCrawler, DateTime.Now, this.TypeCrawler, "CancellationByUser");
                    productAdapter.UpdateWaitFNCrawler(company.ID);
                }
            }
            catch (Exception ex02)
            {
                WriteLog(string.Format("Exception code when process a job crawler:{0}. Wait 1' to back process job", ex02.Message + ex02.StackTrace));
                Thread.Sleep(10 * 1000);
            }
        }



        private void SaveQueuAndVisited(DBQueue.QueueLinksDataTable dtQueueBulkCopy, DBQueue.VisitedLinksDataTable dtVisitedBulkCopy, int CountInsert
            , ref int queuePosition, ref int visitedPosition)
        {
            try
            {
                if (dtQueueBulkCopy.Rows.Count >= CountInsert)
                {
                    SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionStringCrawler);
                    sqlConn.Open();
                    var bulkCopyQueue = new SqlBulkCopy(sqlConn);
                    bulkCopyQueue.DestinationTableName = "QueueLinks";
                    bulkCopyQueue.WriteToServer(dtQueueBulkCopy);
                    if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
                    dtQueueBulkCopy.Rows.Clear();
                    dtQueueBulkCopy = new DBQueue.QueueLinksDataTable();
                    queuePosition = 1;
                }
                if (dtVisitedBulkCopy.Rows.Count >= CountInsert)
                {
                    SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionStringCrawler);
                    sqlConn.Open();
                    var bulkCopyVisited = new SqlBulkCopy(sqlConn);
                    bulkCopyVisited.DestinationTableName = "VisitedLinks";
                    bulkCopyVisited.WriteToServer(dtVisitedBulkCopy);
                    if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
                    dtVisitedBulkCopy.Rows.Clear();
                    dtVisitedBulkCopy = new DBQueue.VisitedLinksDataTable();
                    visitedPosition = 1;
                }
            }
            catch (Exception ex01)
            {
                log.Error(ex01);
                Thread.Sleep(10 * 1000);
            }
        }

        private void WaitAfterCycle(Configuration config, int visitedCount)
        {
        }


        private string GetHtmlCode(string urlCurrent, bool UseClearHtml)
        {
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(urlCurrent, 45, 2);
            html = html.Replace("<form", "<div");
            html = html.Replace("</form", "</div");
            if (config.UseClearHtml)
            {
                html = Common.TidyCleanR(html);
            }
            return html;
        }


        private void DeleteQueueLinkCrawlerNew(long CompanyID, CrawlerProductAdapter crawlerAdapter, long s_crcNoCrawler, List<long> lstDeleteQueueLink)
        {
            lstDeleteQueueLink.Add(s_crcNoCrawler);
            if (lstDeleteQueueLink.Count > 100)
            {
                crawlerAdapter.DeleteQueueLink(lstDeleteQueueLink);
                lstDeleteQueueLink.Clear();
            }
        }

        private void LoadOldQueueCrawler(CrawlerProductAdapter crawlerAdapter, Queue<string> crawlerLink, List<long> queueLinkCrawlerCRC, long CompanYID)
        {
            int PageIndex = 0;
            DataTable tblQueue = null;
            do
            {
                tblQueue = crawlerAdapter.GetQueueOfCompany(CompanYID, PageIndex++);
                foreach (DataRow dr in tblQueue.Rows)
                {
                    int index = queueLinkCrawlerCRC.BinarySearch(Convert.ToInt64(dr["CRC"]));
                    if (index < 0)
                    {
                        crawlerLink.Enqueue(dr["URL"].ToString().Trim());
                        queueLinkCrawlerCRC.Insert(~index, Convert.ToInt64(dr["CRC"]));
                    }
                }
            }
            while (tblQueue.Rows.Count > 0);
        }

        private int LoadVisitedCrawler(long CompanyID, List<long> visitedCRC, CrawlerProductAdapter crawlerAdapter)
        {
            int iPage = 0;
            DataTable tblVisited = null;
            do
            {
                tblVisited = crawlerAdapter.GetVisitedLinkByCompany(CompanyID, iPage++);
                foreach (DataRow dr in tblVisited.Rows)
                {
                    int index = visitedCRC.BinarySearch(Convert.ToInt64(dr["CRC"]));
                    if (index < 0)
                    {
                        visitedCRC.Insert(~index, Convert.ToInt64(dr["CRC"]));
                    }
                }
            } while (tblVisited != null && tblVisited.Rows.Count > 0);
            crawlerAdapter.sqlDb.connection.Close();
            return 0;
        }

        private int LoadOldProductToVisistedCrc(long CompanyID, List<long> visitedCRC, ProductAdapter productAdapter)
        {
            int iCount = 0;
            int iPageProduct = 1;
            DataTable tbl = null;
            do
            {
                tbl = productAdapter.GetProductOfCompany(CompanyID, iPageProduct++);
                foreach (DataRow dr in tbl.Rows)
                {
                    int index = visitedCRC.BinarySearch(Convert.ToInt64(dr["ID"]));
                    if (index < 0) visitedCRC.Insert(~index, Convert.ToInt64(dr["ID"]));
                    iCount++;
                }
            } while (tbl != null && tbl.Rows.Count > 0);
            productAdapter.CloseConnect();
            return iCount;
        }


        private void ClearAfterCrawlerCompany()
        {
            this.Invoke(new Action(() =>
            {
                this.Text = "W...";
            }));
        }

        private void WriteLog(string log)
        {
            this.log.Info(string.Format("At {0}:{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), log));
        }


        private string GetDescProduct(Product product)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("------------------------------------------------------------------------------------------------------");
            sb.Append("\r\nURL\t:  " + product.DetailUrl);
            sb.Append("\r\nCategory\t:  " + Common.ConvertToString(product.Categories, " -> "));
            sb.Append("\r\nName\t:  " + product.Name + "\tID: " + product.ID + "\tValid: " + product.Valid.ToString() + "\tSuccess: " + product.IsSuccessData().ToString());
            sb.Append("\r\nPrice\t:  " + product.Price + " VND");
            sb.Append("\t\tWarranty\t:  " + (int)(product.Warranty / 30) + " months");
            sb.Append("\t\tStatus\t:  " + product.Status.ToString());
            sb.Append("\r\nImage\t:  " + product.ImageUrl + "\r\n");
            return sb.ToString();
        }
        void ShowProduct(Product _product)
        {
            if (showLogProduct)
            {
                string ss = GetDescProduct(_product);
                this.Invoke((MethodInvoker)delegate
                {
                    if (txtResult.Text.Length > 100000) txtResult.Clear();
                    txtResult.AppendText(ss);
                });
            }
        }




        void InsertPriceLog(long productID, DateTime datePublic, int newsPrice, int oldPrice)
        {
            try
            {
                if (_adtPriceLog.Connection.State == ConnectionState.Closed) _adtPriceLog.Connection.Open();
                _adtPriceLog.Insert(
                    productID,
                    datePublic,
                    newsPrice,
                    oldPrice);
                _adtPriceLog.Connection.Close();
            }
            catch (Exception)
            {
                _adtPriceLog.Connection.Close();
            }
        }

        //// doi promotion thanh date public
        void InsertNews(Product _product)
        {
            string image = "";
            if (_product.ImageUrls.Count > 0) { image = _product.ImageUrls[0]; }

            try
            {
                DateTime datepublic;
                DatetimeParsing.DateTimeFormat dtFormat;
                dtFormat = DatetimeParsing.DateTimeFormat.UK_DATE;
                string s = _product.Promotion.Replace("Ngày gửi: ", "");
                DateTime t1 = new DateTime(1900, 1, 1);
                DateTime t2 = new DateTime(1900, 1, 1);
                bool ok1 = DatetimeParsing.TryParseDate(s, dtFormat, out t1);
                bool ok2 = DatetimeParsing.TryParseTime(s, dtFormat, out t2);
                datepublic = new DateTime(t1.Year, t1.Month, t1.Day, t2.Hour, t2.Minute, t2.Second);
                if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();
                _adtProduct.Connection.Close();

                //Ghi log lên Price.
                InsertPriceLog(_product.ID, DateTime.Now, _product.Price, 0);

                //Cập nhật lên RedisLogPrice.
                RedisPriceLogAdapter.PushMerchantProductPrice(_product.ID, _product.Price, DateTime.Now);
            }
            catch (Exception ex)
            {
                FileLog.WriteAppendText(ex.ToString(), company.Domain + ".csv");
            }
        }



        private bool IsRelevantUrl(string url, List<string> crawlerRegex)
        {
            //url = url.ToLower();
            for (int i = 0; i < crawlerRegex.Count; i++)
            {
                Match m = Regex.Match(url, crawlerRegex[i]);
                if (m.Success)
                    return true;
            }
            return false;
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


            //url = url.ToLower();
            //for (int i = 0; i < detailLinkRegex.Count; i++)
            //{
            //    Match m = Regex.Match(url, detailLinkRegex[i].ToLower());
            //    if (m.Success)
            //        return true;
            //}
            //return false;
        }
        private bool IsNoVisitUrl(string url, List<string> noCrawlerRegex)
        {
            try
            {
                //url = url.ToLower();
                for (int i = 0; i < noCrawlerRegex.Count; i++)
                {
                    Match m = Regex.Match(url, noCrawlerRegex[i]);
                    if (m.Success)
                        return true;
                }
                Match m0 = Regex.Match(url, ".+.jpg$");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+.png$");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+facebook.+");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+twitter.+");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+filter.+");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+dispatch.+");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+product_compare.+");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+login.+");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+print.+");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+search.+");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+rao-vat.+");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+sort.+");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+price.+");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+view=.+");
                if (m0.Success) { return true; }
                m0 = Regex.Match(url, ".+=.+=.+=.+");
                if (m0.Success) { return true; }
                return false;
            }
            catch (Exception ex1)
            {
                //XT Note.- Cần sửa config
                return false;
            }
        }

        private void ShowLogLink(int numberItemInQUeue = -1, string urlCurrent = "")
        {
            this.Invoke(new Action(() =>
            {
                if (numberItemInQUeue != -1) this.lblQueue.Text = numberItemInQUeue.ToString();
                if (urlCurrent != "") this.txtUrlCurrent.Text = urlCurrent;
            }));
        }


        private void frmCrawlerProduct_Load(object sender, EventArgs e)
        {
            this.chkLog.Checked = true;
            this.ckCheckDumplicate.Checked = true;
            this.bCheckDumplicate = true;
        }

        private void frmCrawlerProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.Text == "W...") return;
                else if (this.TypeCrawler == 1) productAdapterForm.UpdateCompanyImediateStopReload(this.company.ID);
                else if (this.TypeCrawler == 0) productAdapterForm.UpdateCompanyImediateStopFindNew(this.company.ID);
                this._cancellationTokenSource.Cancel();
            }
            catch (Exception ex01)
            {
                log.Error(ex01);
            }
            //Cập nhật trạng thái IsStopCrawlerImediate cho trường hợp tìm mới.
            if (this.TypeCrawler == 0 && this.company != null) this.productAdapterForm.UpdateStateIsCloseImediate(this.company.ID, false);
            e.Cancel = false;

            this._cancellationTokenSource.Cancel();
        }

        private void frmCrawlerProduct_Shown(object sender, EventArgs e)
        {
            this.ctrLogMananger1.loadCompany(IdCompany);
        }






        private void chkLog_CheckedChanged(object sender, EventArgs e)
        {
            showLog = this.chkLog.Checked;
        }


        private void frmCrawlerProductRedis_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ckPause_CheckedChanged(object sender, EventArgs e)
        {
            this.pause = ckPause.Checked;
        }

        private void ckChangeAll_CheckedChanged(object sender, EventArgs e)
        {
            this.bChangeAll = ckChangeAll.Checked;
        }

        public void ChangeCheckAll(bool bCheck)
        {
            this.bChangeAll = bCheck;
            this.ckChangeAll.Checked = bCheck;
        }

        private void ckCheckDumplicate_CheckedChanged(object sender, EventArgs e)
        {
            this.bCheckDumplicate = ckCheckDumplicate.Checked;
        }

        public bool Start()
        {
            var token1 = _cancellationTokenSource.Token;
            this.tokenCrawler = _cancellationTokenSource.Token;
            Task.Factory.StartNew(() =>
            {
                doCrawlerData();
            }, this.tokenCrawler);
            
            Task.Factory.StartNew(() =>
            {
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                while (!tokenCrawler.IsCancellationRequested)
                {
                    if (this.company != null)
                    {
                        productAdapter.UpdateLastJobForCompany(this.company.ID, this.TypeCrawler);
                        RedisCacheCurrentCrawlerCompany.Instance().PushMssForCompany(this.company.ID, this.company.Domain, this.dtStartCrawler, this.TypeCrawler);
                        token1.WaitHandle.WaitOne(new TimeSpan(0, 1, 0));
                    }
                }
            }, token1);
            return true;
        }




        private void doCrawlerData()
        {
            if (this._delegateGetCompanyCrawler == null)
            {
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                while (true)
                {
                    try
                    {
                        this.tokenCrawler.ThrowIfCancellationRequested();
                        if (this.AutomaticCrawler == true)
                        {
                            DataTable tblCompanyReload = productAdapter.GetCompanyNeedCrawler(this.Procedure, CommandType.StoredProcedure);
                            productAdapter.sqlDb.connection.Close();
                            if (tblCompanyReload != null && tblCompanyReload.Rows.Count > 0)
                            {
                                this.iCompany++;

                                DataRow row = tblCompanyReload.Rows[0];
                                HandlerCrawler(new TaskCrawlerCompany()
                                {
                                    iType = this.TypeCrawler,
                                    Domain = row["Domain"].ToString(),
                                    IdCompany = Convert.ToInt64(row["ID"]),
                                    DatePushJob = Convert.ToDateTime(row["CurrentDate"])
                                });
                            }
                            else
                            {
                                this.Invoke(new Action(() =>
                                {
                                    txtResult.AppendText("\n\r Not have item to crawler. Wait 5'");

                                }));
                                Thread.Sleep(1000 * 60 * 5);
                            }
                        }
                        else
                        {
                            DataTable tblCompanyReload = productAdapter.GetCompanyNeedReload(this.IdCompany);
                            if (tblCompanyReload != null && tblCompanyReload.Rows.Count > 0)
                            {
                                DataRow row = tblCompanyReload.Rows[0];
                                HandlerCrawler(new TaskCrawlerCompany()
                                {
                                    iType = this.TypeCrawler,
                                    Domain = row["Domain"].ToString(),
                                    IdCompany = Convert.ToInt64(row["ID"]),
                                    DatePushJob = Convert.ToDateTime(row["CurrentDate"])
                                });
                            }
                        }
                    }
                    catch (OperationCanceledException threadException)
                    {
                        return;
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new Action(() =>
                        {
                            txtResult.AppendText("\n\nException when crawler:" + ex.Message + ex.StackTrace);
                        }));
                        Thread.Sleep(10000);
                    }
                }
            }
            else
            {

                //SuDungService
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                while (true)
                {
                    try
                    {
                        this.JobRunning = this._delegateGetCompanyCrawler();
                        if (this.JobRunning != null)
                        {
                            long companyID = this.JobRunning.CompanyID;
                            if (companyID > 0)
                            {
                                QT.Entities.Company company = new Entities.Company(companyID);
                                this.tokenCrawler.ThrowIfCancellationRequested();
                                this.iCompany++;
                                HandlerCrawler(new TaskCrawlerCompany()
                                {
                                    iType = this.TypeCrawler,
                                    Domain = company.Domain,
                                    IdCompany = companyID,
                                    DatePushJob = productAdapter.sqlDb.GetCurrent()
                                });
                            }
                        }
                        else
                        {
                            this.Invoke(new Action(() =>
                            {
                                txtResult.AppendText("\n\r Not have item to crawler. Wait 5'");

                            }));
                            Thread.Sleep(1000 * 60 * 5);
                        }

                    }
                    catch (OperationCanceledException threadException)
                    {
                        return;
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new Action(() =>
                        {
                            txtResult.AppendText("\n\nException when crawler:" + ex.Message + ex.StackTrace);
                        }));
                        Thread.Sleep(10000);
                    }
                }
            }
        }


    }
}