
//using GABIZ.Base.HtmlAgilityPack;
//using GABIZ.Base.HtmlUrl;
//using QT.Entities;
//using QT.Entities.CrawlerProduct;
//using QT.Entities.RaoVat;
//using QT.Entities.Data;
//using QT.Entities.Data.SolrDb.SaleNews;
//using QT.Entities.Model;
//using QT.Entities.Model.MQTask;
//using QT.Entities.Model.SaleNews;
//using QT.Entities.MyConverter;
//using RabbitMQ.Client;
//using RabbitMQ.Client.Exceptions;
//using RabbitMQ.Client.Framing.Impl;
//using StackExchange.Redis;
//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading;
//using System.Threading.Tasks;
//using Websosanh.Core.Common.BAL;


//namespace QT.Entities.CrawlerProduct
//{
//    public class ConsumerCrawlerProduct : IDisposable
//    {
//        private QT.Entities.DBTableAdapters.ClassificationTableAdapter _adtClass;
//        private QT.Entities.DBTableAdapters.ProductTableAdapter _adtProduct;
//        private PriceLogAdapter priceLogAdapter;
//        //private ProductAdapter productAdapter;

//        public static int TypeCrawler_FullCrawler = 0;
//        public static int TypeCrawler_FindNewCrawler = 1;
//        public static int TypeCrawler_ReloadCrawler = 2;

//        //Log
//        log4net.ILog log = null;

//        public string IdUnique = Guid.NewGuid().ToString();

//        public delegate void EventReportOut(object sender, string urlLink);

//        public EventReportOut eventWhenVisitedLink;
//        public EventReportOut eventWhenGetExtractionLink;
//        public EventReportOut eventWhenGetProductLink;
//        public EventReportOut eventWhenStartConsumer;
//        public EventReportOut eventWhenAnalysisOK;
//        public EventReportOut eventWhenFinish;
//        public EventReportOut eventWhenAddQueue;
//        public EventReportOut eventProcessLink;
//        public EventReportOut eventWhenDispose;
//        public EventReportOut eventWhenException;
//        public EventReportOut eventWhenPause;

//        private RedisCrawlerProduct redisDB;

//        //RabbitMQ
//        private IModel channel;
//        string queueName = "crawl_product_waitTask";
//        QT.Entities.Data.CassandraDb cassandraDb;

//        //Dữ liệu liên quan SQL.
//        private SqlDb sqlDb;
//        private ProductSaleNewDataAdapter productSaleNewAdapter;
//        private RaoVatSQLAdapter configXPathsAdapter;

//        Dictionary<long,Configuration> dicConfig = null;
//        Dictionary<long, Company> dicCompany = null;

//        protected QT.Entities.AnaylysicData.HandlerContentOfHtml handleConnectHtml;
//        public bool IsPause;

//        public ConsumerCrawlerProduct(string name, ConnectionFactory factoryConnection, string queueNameInput = "sale_waitTask")
//        {
//            _adtClass = new QT.Entities.DBTableAdapters.ClassificationTableAdapter();
//            _adtProduct = new QT.Entities.DBTableAdapters.ProductTableAdapter();
//            this.priceLogAdapter = new PriceLogAdapter(new SqlDb(QT.Entities.Server.ConnectionStringCrawler));
//            //this.productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionStringCrawler));

//            this.name = name;
//            this.queueName = queueNameInput;

//            //Parameter 
//            this.bSaveData = true;
//            this.bSaveKeyWord = false;

//            //Local Variable
//            this.log = log4net.LogManager.GetLogger(typeof(ConsumerCrawlerProduct));
//            this.dicConfig = new Dictionary<long, Configuration>();
//            this.dicCompany = new Dictionary<long, Company>();
//            this.handleConnectHtml = new QT.Entities.AnaylysicData.HandlerContentOfHtml();

//            //Redis
//            var redisMultiplexer = ConnectionMultiplexer.Connect(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port);
//            this.redisDB = new RedisCrawlerProduct(redisMultiplexer.GetDatabase());

//            //CassandraDB
//            this.cassandraDb = CassandraDb.Instance;

//            //RabbitMQ
//            connectMQ = factoryConnection.CreateConnection();
//            channel = connectMQ.CreateModel();
//            channel.BasicQos(0, 1, false);
//            int timeToLive = 1000 * 60 * 60 * 24 * 2;
//            RabbitMQ.Client.QueueDeclareOk queueDelareInfo = channel.QueueDeclare(this.queueName, true, false, false, null);


//            //SQL
//            sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
//            //this.productSaleNewAdapter = new ProductSaleNewDataAdapter(this.sqlDb);
//            //this.configXPathsAdapter = new ConfigXpathsAdapter(this.sqlDb);


//            string Webdomain = "raovat";
//            string URLSolrConnect = "http://118.70.205.94:9104/solr/raovat";
//            SolrRaoVatDriver.Init(new Dictionary<string, string> { { Webdomain, URLSolrConnect } });
//            slr = SolrRaoVatDriver.GetDriver(SolrRaoVatDriver.GetInstance(Webdomain));
//        }


//        public string StartConsumer()
//        {
//            try
//            {
//                if (this.eventWhenStartConsumer != null) this.eventWhenStartConsumer(this,
//                    string.Format("Start consumer:{0}", this.name));

//                log.InfoFormat("{0}:StartConsumer", this.name);
//                QueueingBasicConsumer consumer = new QueueingBasicConsumer(this.channel);
//                String consumerTag = channel.BasicConsume(this.queueName, false, consumer);
//                while (!this.IsDispose)
//                {
//                    #region {Check maximum rabbitMQ queue}
//                    //while (true)
//                    //{
//                    //    RabbitMQ.Client.QueueDeclareOk queueDelareInfo = channel.QueueDeclare(this.queueName, true, false, false, null);
//                    //    if (queueDelareInfo.MessageCount > this.MaxJob)
//                    //    {
//                    //        log.InfoFormat("{0}:Wait less message (over).....", this.name);
//                    //        if (this.eventProcessLink != null)
//                    //            this.eventProcessLink(this, string.Format("Wait job < {0}", this.MaxJob));
//                    //        Thread.Sleep(1000);
//                    //    }
//                    //    else break;
//                    //}
//                    #endregion

//                    //Kiểm tra pause từ bên ngoài.
//                    while (true)
//                    {
//                        bool CheckPause = redisDB.CheckPauseInstance(QT.Entities.CrawlerProduct.InstanceCrawler.Instance.UniqueInstance);
//                        if (CheckPause)
//                        {
//                            if (this.eventWhenPause != null) this.eventWhenPause(this, "Pause!");
//                            Thread.Sleep(5000);
//                        }
//                        else break;
//                    }


//                    log.InfoFormat("{0}:Wait message.....", this.name);
//                    RabbitMQ.Client.Events.BasicDeliverEventArgs e = (RabbitMQ.Client.Events.BasicDeliverEventArgs)consumer.Queue.Dequeue();
//                    byte[] body = e.Body;

//                    TaskMQProduct task = null;
//                    try
//                    {
//                        task = Websosanh.Core.Common.BAL.ProtobufTool.DeSerialize<TaskMQProduct>(body);
//                    }
//                    catch (Exception ex2)
//                    {
//                        log.ErrorFormat("{0} Not valid MQTask:{1}", this.name, ex2.Message);
//                    }

//                    if (task != null && CheckDataInTask(task) && SyncConfig(task.CompanyID) && CheckSession(task.CompanyID, task.Session))
//                    {
//                        this.ProcessAJob(task);
//                    }
//                    channel.BasicAck(e.DeliveryTag, false);
//                    this.redisDB.SetValueSession(task.TypeCrawler.ToString()
//                        , task.CompanyID
//                        , RedisCrawlerProduct.FieldSession_LastJobAt
//                        , DateTime.Now.ToString(Common.Format_DateTime));
//                }
//                return "";
//            }
//            catch (Exception ex)
//            {
//                if (this.IsDispose)
//                {
//                    return "";
//                }
//                else
//                {
//                    this.Dispose();
//                    return ex.Message;
//                }
//            }
//        }

//        private bool CheckDataInTask(TaskMQProduct task)
//        {
//            return true;
//        }

//        /// <summary>
//        ///Xử lí TaskCrawler.
//        /// </summary>
//        /// <param name="task"></param>
//        private void ProcessAJob(TaskMQProduct task)
//        {
//            long idProduct = Common.GetIDProduct(task.Url);

//            //Chờ Delay cho những web chống crawler.
//            if (dicConfig[task.CompanyID].TimeDelay > 0) Thread.Sleep(dicConfig[task.CompanyID].TimeDelay);

//            string sError = "";
//            //Lấy HTML
//            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(task.Url, 45, 2);
            
//            if (html != "")
//            {
//                html = html.Replace("<form", "<div");
//                html = html.Replace("</form", "</div");

//                int numberVisited = Convert.ToInt32(this.redisDB.GetValueSession(task.CompanyID, RedisCrawlerProduct.FieldSession_NumberVisited, "0", task.TypeCrawler.ToString()));
//                int numberProduct = Convert.ToInt32(this.redisDB.GetValueSession(task.CompanyID, RedisCrawlerProduct.FieldSession_NumberProduct, "0", task.TypeCrawler.ToString()));
//                int numberIgnored = Convert.ToInt32(this.redisDB.GetValueSession(task.CompanyID, RedisCrawlerProduct.FieldSession_NumberIgnored, "0", task.TypeCrawler.ToString()));

//                if (this.eventProcessLink != null)
//                    this.eventProcessLink(this, string.Format("NumberVisited:{0}. NumberProduct:{1}. UrlGet:{2}",
//                    numberVisited.ToString(), numberProduct.ToString(), task.Url));

//                HashIncrementFieldSession(task.CompanyID, RedisCrawlerProduct.FieldSession_NumberVisited, task.TypeCrawler.ToString());
//                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
//                if (this.dicConfig[task.CompanyID].UseClearHtml)
//                {
//                    html = Common.TidyCleanR(html);
//                }
//                doc.LoadHtml(html);

//                //Extraction
//                if (task.IsExtraction == true)
//                {
//                    var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");
//                    if (a_nodes != null)
//                    {
//                        #region add link to process
//                        for (int i = 0; i < a_nodes.Count; i++)
//                        {
//                            string s = Common.GetAbsoluteUrl(a_nodes[i].Attributes["href"].Value, new Uri(task.Url));
//                            long s_crc = Math.Abs(GABIZ.Base.Tools.getCRC64(LinkCanonicalization.NormalizeLink(s)));
//                            if (!this.CheckVisitedLink(task.CompanyID, s_crc))
//                            {
//                                if (CheckRegex(s, dicConfig[task.CompanyID].VisitUrlsRegex, dicConfig[task.CompanyID].NoVisitUrlRegex, false))
//                                    PublishTask(new TaskMQProduct()
//                                    {
//                                        CompanyID = task.CompanyID,
//                                        Deep = task.Deep + 1,
//                                        ImageUrl = "",
//                                        IsExtraction = true,
//                                        IsProduct = true,
//                                        Session = task.Session,
//                                        TypeCrawler = task.TypeCrawler,
//                                        Url = s,
//                                        IsTest = task.IsTest,
//                                        AllowSaveNewProduct = task.AllowSaveNewProduct,
//                                        AllowSaveOldProduct = task.AllowSaveOldProduct
//                                    });
//                                if (this.eventWhenAddQueue != null) this.eventWhenAddQueue(this, string.Format
//                                    ("AddToQueue. Url:{0} Session{1} TypeCrawler:{2} IsTest:{3}", s, task.Session, task.TypeCrawler, task.IsTest));
//                                this.SetVisited(task.CompanyID, s_crc, task.TypeCrawler.ToString());
//                            }
//                        }
//                        #endregion
//                    }
//                }

//                //Analysic product.
//                if (CheckRegex(task.Url, this.dicConfig[task.CompanyID].ProductUrlsRegex, null, false))
//                {
//                    bool bAnalysic = true;

//                    if (!task.AllowSaveOldProduct && productAdapter.CheckExistInDb(idProduct)) bAnalysic = false;
//                    else if (!task.AllowSaveNewProduct && !productAdapter.CheckExistInDb(idProduct)) bAnalysic = false;
//                    else bAnalysic = true;

//                    if (bAnalysic)
//                    {
//                        #region analytic product
//                        QT.Entities.Product p = new Product();
//                        p.Analytics(doc, task.Url, dicConfig[task.CompanyID], false, this.dicCompany[task.CompanyID].Domain, null);
//                        p.IDCongTy = task.CompanyID;
//                        if (p != null)
//                        {
//                            if ((p.Price > 0) && (p.Name.Trim().Length > 0))
//                            {
//                                //Save data.
//                                HashIncrementFieldSession(task.CompanyID, RedisCrawlerProduct.FieldSession_NumberProduct, task.TypeCrawler.ToString());                             
//                                if (task.IsTest == false) UpdateProduct(p); //Chỉ lưu dữ liệu nếu ko phải test.
//                                if (eventWhenGetProductLink != null) eventWhenGetProductLink(this, string.Format("AnalysicProduct.Saved:{1}. ProductInfo:{0}", p.ToString(), task.IsTest));
//                            }
//                        }
//                        else
//                        {
//                            HashIncrementFieldSession(task.CompanyID, RedisCrawlerProduct.FieldSession_NumberIgnored, task.TypeCrawler.ToString());
//                        }
//                        #endregion
//                    }
//                }
//            }
//            //else
//            //{
//            //    //Reload dữ liệu=> Không lấy được dữ liệu.
//            //    if (task.TypeCrawler==1)
//            //    {
//            //        UpdateNotLoadProduct(idProduct);
//            //    }
//            //}
//        }

//        private void UpdateNotLoadProduct(long idProduct)
//        {
//            try
//            {
//                //this.productAdapter.UpdateNotLoadProduct(idProduct);   
//            }
//            catch (Exception ex)
//            {

//            }
//        }

//        public void UpdateProduct(Product _product)
//        {
//            try
//            {
//                //this.productAdapter.UpdateProduct(_product);
//            }
//            catch (Exception ex)
//            {
//                if (this.eventWhenException != null) this.eventWhenException(this, ex.Message);
//            }
//        }

//        private void AddNameCrc(long p)
//        {
//            throw new NotImplementedException();
//        }

//        private bool CheckExistsNameCrc(long p)
//        {
//            return true;
//        }

//        void InsertPriceLog(long productID, DateTime datePublic, int newsPrice, int oldPrice)
//        {
//            this.priceLogAdapter.Insert(
//                productID,
//                datePublic,
//                newsPrice,
//                oldPrice);
//        }


//        private void SetExistClassification(long p)
//        {
//            throw new NotImplementedException();
//        }

//        private bool CheckExistClassification(long p)
//        {
//            return true;
//        }

//        private void DeleteProduct(long product_ID)
//        {
//            this.cassandraDb.UpdateReloadFailProduct(product_ID);
//        }

//        private bool CheckExtraction(int typeCrawler, ConfigXPaths config, string urlNew)
//        {
//            bool bProduct = CheckRegex(urlNew, config.ProductUrlsRegex, config.NoProductUrlRegex, false);
//            //if (bProduct && config.AllowExtractProductLink) return true;
//            //else
//            //{
//            //    if (config.RegexReloadLikeFull || typeCrawler == ConsumerSaleNew.TypeCrawler_FullCrawler)
//            //    {
//            //        return CheckRegex(urlNew, config.VisitUrlsRegex, config.NoVisitUrlsRegex, false);
//            //    }
//            //    if (typeCrawler == ConsumerSaleNew.TypeCrawler_FindNewCrawler)
//            //    {
//            //        return CheckRegex(urlNew, config.ReloadVisitUrlsRegex, config.ReloadNoVisitUrlsRegex, false);
//            //    }
//            //}
//            return false;
//        }

//        /// <summary>
//        /// Kiểm tra các dữ liệu bên trong task để xử lí
//        /// </summary>
//        /// <param name="task"></param>
//        /// <returns></returns>
//        private bool CheckDataInTask(TaskMQ task)
//        {
//            try
//            {
//                Uri uri = new Uri(task.Url);
//            }
//            catch (Exception ex)
//            {
//                return false;
//            }
//            return true;
//        }

//        /// <summary>
//        /// Kiểm tra session cuổi cùng.
//        /// </summary>
//        /// <param name="configID"></param>
//        /// <param name="session"></param>
//        /// <returns></returns>
//        private bool CheckSession(long configID, int session)
//        {
//            if (session == 0) return true;
//            int currentSession = Convert.ToInt32(redisDB.GetValueSession(configID, RedisCrawlerProduct.FieldSession_SessionID, "0"));
//            bool bSucess = currentSession == session;
//            if (!bSucess) log.InfoFormat("Out of date session job. Company {0}. Session job: {1}. Current session: {2}", configID.ToString(), session, currentSession);
//            return bSucess;
//        }




//        private bool SyncConfig(long companyID)
//        {
//            QT.Entities.Server.ConnectionStringCrawler = @"Data Source=183.91.14.82;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_crawler;Password=11qsQEF4sJx@l9@ryJt9MT;connection timeout=5000";
//            QT.Entities.Server.ConnectionString = @"Data Source=183.91.14.82;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_crawler;Password=11qsQEF4sJx@l9@ryJt9MT;connection timeout=5000";

//            log.InfoFormat("->SyncConfig()");
//            bool bConfig = false;

//            //Không chứa key
//            if (!dicConfig.ContainsKey(companyID))
//            {
//                Configuration configNew = new Configuration(companyID);
//                if (configNew == null)
//                {
//                    this.dicConfig.Remove(companyID);
//                    bConfig = false;
//                }
//                else
//                {
//                    this.dicConfig.Add(companyID, new Configuration(companyID));
//                    this.dicCompany.Add(companyID, new Company(companyID));

//                    bConfig = true;
//                    log.InfoFormat("->Load new config from sql:{0}", companyID);
//                }
//                log.InfoFormat("->SyncConfig:{0} OK", companyID);
//            }
//            else
//            {
//                bConfig = true;
//            }
//            log.InfoFormat("<-Return:{0}", bConfig ? "Have config" : "No config");
//            return bConfig;
//        }

//        public override string ToString()
//        {
//            return this.name;
//        }
//        private void PublishTask(TaskMQProduct taskMQ)
//        {
//            var a = Websosanh.Core.Common.BAL.ProtobufTool.Serialize(taskMQ);
//            channel.QueueDeclare(this.queueName, true, false, false, null);
//            this.channel.BasicPublish("", this.queueName, null, a);
//        }

//        /// <summary>
//        /// Ghi lại link đã đâỷ vào queue
//        /// </summary>
//        /// <param name="companyID"></param>
//        /// <param name="s_crc"></param>
//        /// <param name="typeCrawler"></param>
//        private void SetVisited(long companyID, long s_crc, string typeCrawler)
//        {
//            this.redisDB.SetAdd(RedisCrawlerProduct.Prefix_Set_VisitedLink + typeCrawler + ":" + companyID.ToString(), s_crc.ToString());
//        }

//        /// <summary>
//        /// 1.Error Cassandra
//        /// 2.Error Solr
//        /// </summary>
//        /// <param name="product"></param>
//        /// <returns></returns>
//        private int SaveProduct(ProductSaleNew product)
//        {
//            try
//            {
//                bool bSaveCassandra = this.cassandraDb.SaveProductSaleNew(product);
//                product.wss_view_count = cassandraDb.GetViewCount(product.id);
//                bool bSaveToSolr = this.slr.SaveToSolr(product);
//                if (this.bSaveKeyWord && product.tags != null && product.tags.Count > 0)
//                {
//                    this.productSaleNewAdapter.SaveKeyWord(product);
//                }
//                return (bSaveCassandra && bSaveToSolr) ? 0 : 1;
//            }
//            catch (Exception ex)
//            {
//                log.ErrorFormat("Error when save product:{0} at link:{1}", ex.Message, product.url);
//                return 100;
//            }
//            return 0;
//        }

//        private void UpdateProductToDb(Product product)
//        {
//            bool bOK = this.sqlDb.AutoUpdateProduct(product, true, true);
//        }

//        /// <summary>
//        /// Kiểm tra link đã duyệt chưa
//        /// </summary>
//        /// <param name="companyID"></param>
//        /// <param name="s_crc"></param>
//        /// <returns></returns>
//        private bool CheckVisitedLink(long companyID, long s_crc)
//        {
//            int i = 0;
//            while (i < 5)
//            {
//                try
//                {
//                    i++;
//                    bool bVisited = this.redisDB.SetContains(RedisCrawlerProduct.Prefix_Set_VisitedLink + companyID, s_crc);
//                    return bVisited;
//                }
//                catch (Exception ex)
//                {
//                    Thread.Sleep(1000);
//                    log.ErrorFormat("Exception:{0}", ex.Message);
//                }
//            }
//            return false;
//        }



//        /// <summary>
//        /// Tăng các giá trị theo dõi của 1 session.
//        /// </summary>
//        /// <param name="companyID"></param>
//        /// <param name="field"></param>
//        private void HashIncrementFieldSession(long companyID, string field, string typeCrawler)
//        {
//            try
//            {
//                string key = RedisCrawlerProduct.Prefix_SessionKey + typeCrawler + ":" + companyID.ToString();
//                this.redisDB.HashIncrement(key, field);
//            }
//            catch (Exception ex)
//            {
//                log.ErrorFormat("Exception Redis:{0}", ex.Message);
//            }
//        }


//        private void AddToQueue(string queueName, IEnumerable<string> arLink)
//        {

//            int timeToLive = 1000 * 60 * 60 * 24 * 2;
//            var properties = this.channel.CreateBasicProperties();
//            properties.SetPersistent(true);
//            if (timeToLive > 0) properties.Expiration = timeToLive.ToString();
//            properties.DeliveryMode = 2;
//            foreach (string strUrl in arLink)
//            {
//                if (this.eventWhenAddQueue != null) this.eventWhenAddQueue(this, strUrl);

//                byte[] arTaskUpdateLast = Websosanh.Core.Common.BAL.ProtobufTool.Serialize(new QT.Entities.Model.MQTask.MQ_CrawlerWaitLink() { url = strUrl });
//                this.channel.BasicPublish("", queueName, properties, arTaskUpdateLast);
//            }
//        }

//        private void AddToQueue(string queueName, string arLink)
//        {
//            this.AddToQueue(queueName, new List<string> { arLink });
//        }


//        private bool CheckRegex(string url, List<string> crawlerRegex, List<string> noCrawlerRegex, bool bDefault)
//        {
//            if (noCrawlerRegex != null && noCrawlerRegex.Count > 0)
//            {
//                for (int i = 0; i < noCrawlerRegex.Count; i++)
//                {
//                    Match m = Regex.Match(url, noCrawlerRegex[i]);
//                    if (m.Success)
//                        return false;
//                }
//            }

//            if (crawlerRegex != null && crawlerRegex.Count > 0)
//                for (int i = 0; i < crawlerRegex.Count; i++)
//                {
//                    Match m = Regex.Match(url, crawlerRegex[i]);
//                    if (m.Success)
//                        return true;
//                }

//            return bDefault;
//        }

//        private bool IsDetailUrl(string c_url, IList<string> detailLinkRegex)
//        {
//            if (detailLinkRegex == null) return true;
//            for (int i = 0; i < detailLinkRegex.Count; i++)
//            {
//                Match m = Regex.Match(c_url, detailLinkRegex[i]);
//                if (m.Success) return true;
//            }
//            return false;
//        }

//        public void  Dispose()
//        {
//            try
//            {
//                this.IsDispose = true;
//                if (channel != null && channel.IsOpen) channel.Close();
//                if (channel != null) channel.Dispose();
//                if (this.connectMQ != null && this.connectMQ.IsOpen) this.connectMQ.Close();
//                if (this.eventWhenDispose != null) this.eventWhenDispose(this, string.Format("Dispose consumer:{0}", this.name));
//            }
//            catch (Exception ex)
//            {
//                log.ErrorFormat("Dispose consumer: {0}" + ex.Message);
//            }
//        }


//        public void Pause()
//        {
//            this.IsPause = true;
//        }

//        public string baseLink { get; set; }

//        internal void SetBeginLink(string url)
//        {
//            this.Uri = new Uri(url);
//            this.BeginLink = url;
//            this.baseLink = Uri.Scheme + "://" + this.Uri.Host + "/";
//        }

//        public string BeginLink { get; set; }

//        public Uri Uri { get; set; }

//        public bool IsDispose = false;
//        private SolrRaoVatDriver slr = null;
//        public string name = "";

//        public List<string> GetListLinkAddQueue(Uri uri, HtmlDocument doc, ConfigXPaths config)
//        {
//            List<string> lst = new List<string>();
//            var nodes = doc.DocumentNode.SelectNodes(@"//a/@href");
//            if (nodes != null)
//            {
//                foreach (var node in nodes)
//                {
//                    string url = node.Attributes["href"].Value.ToString();
//                    string fullLink = (!url.Contains(uri.Host)) ? (uri.Scheme + @"://" + uri.Host + @"/" + url) : url;
//                    if (CheckRegex(fullLink, config.VisitUrlsRegex, config.NoVisitUrlRegex, false))
//                    {
//                        if (!lst.Contains(fullLink)) lst.Add(fullLink);
//                    }
//                }
//            }
//            return lst;
//        }

//        public bool bSaveData { get; set; }

//        public bool bSaveKeyWord { get; set; }

//        public void PushBeginLink(int configID, int typeCrawler)
//        {

//        }

//        private uint MaxJob = 2000000;
//        private IConnection connectMQ;
//    }
//}
