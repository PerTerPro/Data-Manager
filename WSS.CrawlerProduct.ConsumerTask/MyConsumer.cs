
using GABIZ.Base.HtmlUrl;
using QT.Entities;
using QT.Entities.Data;
using QT.Entities.Model.MQTask;
using RabbitMQ.Client;
using RabbitMQ.Client.Framing.Impl;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.CrawlerReloadPriceOfProduct
{
    public class MyConsumerTask
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(MyConsumerTask));
        public string NameConsumerTask = Guid.NewGuid().ToString();
        int iCount = 0;

        public delegate void DelegateLogData(string strMessage);
        public DelegateLogData eventLog;

        Dictionary<int, QT.Entities.Configuration> dicConfigurationCrawler = new Dictionary<int, QT.Entities.Configuration>();

        protected IModel changeReport;
        protected IConnection connection;
        protected SqlDb sqlDb;
        protected QT.Entities.AnaylysicData.HandlerContentOfHtml handleConnectHtml;

        protected IConnection connectionToPublish;
        protected IModel ModelToPublish;
        private bool IsStop = false;
        private string queueName;

        ConnectionFactory factory = null;

        public MyConsumerTask(string queueName)
        {
            this.factory = new ConnectionFactory()
            {
                HostName = QT.Entities.Server.RabbitMQ_Host,
                Port = QT.Entities.Server.RabbitMQ_Port,
                UserName = QT.Entities.Server.RabbitMQ_User,
                Password = QT.Entities.Server.RabbitMQ_Pass
            };

            this.connection = factory.CreateConnection();
            this.changeReport = connection.CreateModel();

            System.Collections.Generic.Dictionary<String, Object> args = new System.Collections.Generic.Dictionary<string, Object>();
            this.changeReport.QueueDeclare(queueName, true, false, false, args);
            var properties = changeReport.CreateBasicProperties();
            properties.SetPersistent(true);
            properties.Expiration = "10000";
            properties.DeliveryMode = 2;

            this.queueName = queueName;
            this.handleConnectHtml = new QT.Entities.AnaylysicData.HandlerContentOfHtml();
        }

        public void StartConsumer()
        {
            iCount = 0;
            string hostName = QT.Entities.Server.RabbitMQ_Host;
            int Port = QT.Entities.Server.RabbitMQ_Port;
            string userName = QT.Entities.Server.RabbitMQ_User;
            string password = QT.Entities.Server.RabbitMQ_Pass;
            string queueName = QT.Entities.Server.RabbitMQ_QueueTask;
            sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);

            ConnectionFactory connectionFactory = new ConnectionFactory();
            connectionFactory.UserName = userName;
            connectionFactory.Password = password;
            connectionFactory.Protocol = Protocols.DefaultProtocol;
            connectionFactory.HostName = hostName;
            connectionFactory.Port = Port;
            connection = connectionFactory.CreateConnection();
            connectionToPublish = connectionFactory.CreateConnection();

            ModelToPublish = connection.CreateModel();
            ModelToPublish.BasicQos(0, 1, false);
            ModelToPublish.QueueDeclare("CrawlerProduct_ReloadPrice", true, false, false, null);

            changeReport = connection.CreateModel();
            changeReport.BasicQos(0, 1, false);
            bool durable = true;

            changeReport.QueueDeclare("CrawlerProduct_ReloadPrice", durable, false, false, null);
            QueueingBasicConsumer consumer = new QueueingBasicConsumer(changeReport);
            bool autoAck = false;
            String consumerTag = changeReport.BasicConsume("CrawlerProduct_ReloadPrice", autoAck, consumer);
            while (true)
            {
                RabbitMQ.Client.Events.BasicDeliverEventArgs e = (RabbitMQ.Client.Events.BasicDeliverEventArgs)consumer.Queue.Dequeue();
                iCount++;
                IBasicProperties props = e.BasicProperties;
                byte[] body = e.Body;
                ProcessATaskMQ(body);
                changeReport.BasicAck(e.DeliveryTag, false);
            }
        }

        private void ProcessATaskMQ(byte[] body)
        {
            try
            {
                if (queueName == "product_crawler_new")
                {
                    MQTask_NewProduct taskCrawler = Websosanh.Core.Common.BAL.ProtobufTool.DeSerialize<MQTask_NewProduct>(body);
                    CrawlerNewProduct(taskCrawler);
                }
                //else if (queueName == WSS.ManageConnectStatic.ManagerConnect.Instance().RabbitMQ_QueueTaskCrawlReloadProduct)
                //{
                //    CrawlerReloadProduct crawler = new CrawlerReloadProduct();
                //    crawler.Start(message);
                //}
                //else if (queueName == WSS.ManageConnectStatic.ManagerConnect.Instance().RabbitMQ_QueueTaskCrawlReloadProductByCompany)
                //{
                //    MQTask_NewProduct taskCrawler = JsonConvert.DeserializeObject<MQTask_NewProduct>(message);
                //    List<Product> lstProduct = Crawler.Data.SQLServer.SqlDb.Instance.GetListProductByCompanyID(taskCrawler.company.ID);
                //    MyRabbitMqHandler.Instance.PublishToReportMessage(string.Format("Process queue: {0}  numberProductReload: {1}", queueName
                //        , lstProduct.Count));
                //    CrawlerReloadProduct crawlerReload = new CrawlerReloadProduct();
                //    foreach (Product product in lstProduct)
                //    {
                //        product.Domain = taskCrawler.company.Domain;
                //        MQTask_ReloadProduct taskNew = new MQTask_ReloadProduct()
                //        {
                //            Product = product,
                //            ConfigCrawler = taskCrawler.configCrawler
                //        };
                //        crawlerReload.Start(taskNew);
                //        //string messageMQ = JsonConvert.SerializeObject(taskNew);
                //        //MyRabbitMqHandler.Instance.Publish(WSS.ManageConnectStatic.ManagerConnect.Instance().RabbitMQ_QueueTaskCrawlReloadProduct, messageMQ, 0);
                //        //MyRabbitMqHandler.Instance.PublishToReportMessage(string.Format("Send message ProductID:{0} ConfigID:{1}"
                //        //    , taskNew.Product.ID, taskNew.ConfigCrawler.ID));
                //    }
                //}
                //else
                //{
                //    MyRabbitMqHandler.Instance.PublishToReportMessage("Queue not handle because don't exits method to process for it");
                //}
            }
            catch (Exception ex)
            {
            }
        }

        public void ReportData (string message)
        {

        }

        private void CrawlerNewProduct(MQTask_NewProduct taskCrawler)
        {
            if (taskCrawler.company == null)
            {
                ReportData("Company null in task");
            }
            else if (taskCrawler.Configuration == null)
            {
                ReportData("Config null in task");
            }
            else
            {
                //CrawlerNewProduct crawlerCore = new CrawlerNewProduct(taskCrawler.company, taskCrawler.configCrawler);
                //crawlerCore.bAllowInsertNewProduct = true;
                //crawlerCore.bAllowUpdateOldProduct = false;
                //crawlerCore.bTrackQueueToDb = true;
                //crawlerCore.iLevelMaxCrawler = 10;
                //crawlerCore.Start();

                string rootUrl = taskCrawler.company.Website;
                int visitedCount = 0;
                Configuration config = taskCrawler.Configuration;
                List<string> crawlerRegex = config.VisitUrlsRegex;
                List<string>  detailLinkRegex = config.ProductUrlsRegex;
                List<string> P_Show = new List<string>();
                List<Product> Products = new List<Product>();
                Queue<string> crawlerLink= new Queue<string>();
                List<long> visitedCRC = new List<long>();
                Uri rootUri = new Uri(rootUrl);
                crawlerLink.Enqueue(rootUrl);
                string currentUrl = "";
                bool finish = false;
                bool pause = false;
                int ignoredCount = 0;

                while (crawlerLink.Count > 0)
                {
                    if (Products.Count >= config.ItemReCrawler) { break; }
                    if (finish) { break; }
                    if (!pause)
                    {
                        try
                        {
                            string c_url = crawlerLink.Dequeue();
                            FileLog.WriteAppendText(DateTime.Now.ToString("dd/MM HH:mm:ss") + "\t, " + c_url, rootUri.Host + ".txt");
                            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(c_url, 45, 2);
                            if (html != "")
                            {
                                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                                if (config.UseClearHtml)
                                {
                                    html = Common.TidyCleanR(html);
                                }
                                doc.LoadHtml(html);

                                var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");
                                if (a_nodes != null)
                                {
                                    for (int i = 0; i < a_nodes.Count; i++)
                                    {
                                        string s = Common.GetAbsoluteUrl(a_nodes[i].Attributes["href"].Value, rootUri);

                                        long s_crc = GABIZ.Base.Tools.getCRC64(LinkCanonicalization.NormalizeLink(s));
                                        int index = visitedCRC.BinarySearch(s_crc);
                                        if (index < 0)
                                        {
                                            if (IsRelevantUrl(s))
                                                crawlerLink.Enqueue(s);
                                            visitedCRC.Insert(~index, s_crc);
                                        }
                                    }
                                }

                                if (IsDetailUrl(c_url,detailLinkRegex))
                                {

                                    QT.Entities.Product p = new Product();
                                    p.Analytics(doc, c_url, config,false,taskCrawler.company.Domain);

                                    if (p != null)
                                    {
                                        if (p.Name != null)
                                        {
                                            if (p.Name.Trim() != "")
                                            {
                                                Products.Add(p);
                                            }
                                            else
                                            {
                                                FileLog.WriteAppendText(DateTime.Now.ToString("dd/MM HH:mm:ss") + "\t, " + "Product not name", rootUri.Host + ".txt");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        ignoredCount++;
                                    }
                                }
                            }

                            visitedCount++;
                            currentUrl = c_url;
                            Thread.Sleep(config.TimeDelay);
                        }
                        catch (Exception ex)
                        {
                            FileLog.WriteAppendText(DateTime.Now.ToString("dd/MM HH:mm:ss") + "\t, " + ex.ToString(), rootUri.Host + ".txt");
                        }

                    }
                }
                finish = true;
  
            }
        }

        private bool IsRelevantUrl(string s)
        {
            throw new NotImplementedException();
        }

        private bool IsDetailUrl(string c_url, IList<string> detailLinkRegex)
        {
            for (int i = 0; i < detailLinkRegex.Count; i++)
            {
                Match m = Regex.Match(c_url, detailLinkRegex[i]);
                if (m.Success)
                    return true;
            }
            return false;
        }

        internal void Dispose()
        {
            IsStop = true;

            ModelToPublish.Close();
            changeReport.Close();

            //connection.Close();
            //connection.Close();

            changeReport.Dispose();
            ModelToPublish.Dispose();

            connectionToPublish.Dispose();
            connection.Dispose();
        }
    }
}
