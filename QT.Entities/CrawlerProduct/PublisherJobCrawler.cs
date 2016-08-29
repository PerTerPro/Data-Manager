//using QT.Entities;
//using QT.Entities.CrawlerProduct;
//using QT.Entities.Data;
//using QT.Entities.Model.SaleNews;
//using RabbitMQ.Client;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace QT.Entities.CrawlerProduct
//{
//    public class PublisherAutoJobCrawler
//    {
//        public delegate void EventWhenAddJob(object sender, string mss);
//        public EventWhenAddJob eventWhenAddJob;
//        public EventWhenAddJob eventSkipCrawlByLastTime;

//        private RabbitMQ.Client.ConnectionFactory connectionFactoryMQ;
//        private CompanyAdapter companyAdapter;
//        private int crawlTypeData;
//        private int MinLastUpdateRedisPush = 10;
//        private RedisCrawlerProduct redisDb;
//        public bool IsDispose;
//        private RabbitMQ.Client.IConnection connectionMQ;
//        private int timeInterval;
//        private string queueName;
//        private bool IsTest;
//        private SqlCrawlerProduct sqlCrawlerProductDb;
//        private bool bAllowSaveOld;
//        private bool bAllowAddNew;

//        public PublisherAutoJobCrawler(int typeCrawler, int timeInterval, string queueName, bool Istest, bool bAllowAddNew, bool bAllowSaveOld)
//        {
//            connectionFactoryMQ = RabbitMQCreator.GetFactory();
//            connectionMQ = connectionFactoryMQ.CreateConnection();
//            companyAdapter = new CompanyAdapter(new SqlDb(QT.Entities.Server.ConnectionStringCrawler));
//            crawlTypeData = typeCrawler;
//            sqlCrawlerProductDb = new SqlCrawlerProduct();

//            redisDb = new RedisCrawlerProduct(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port, 0);
//            this.timeInterval = timeInterval;
//            this.queueName = queueName;
//            this.IsTest = Istest;
//            this.bAllowAddNew = bAllowAddNew;
//            this.bAllowSaveOld = bAllowSaveOld;
//        }

//        public void Dispose()
//        {
//            this.IsDispose = true;
//            if (connectionMQ != null && connectionMQ.IsOpen) this.connectionMQ.Close();
//        }


//        public void StartPushJob()
//        {

//            System.Data.DataTable tblCanPush = companyAdapter.GetTblCanPushCrawler(this.crawlTypeData);
//            foreach (DataRow rowInfo in tblCanPush.Rows)
//            {
//                long iCompany = Convert.ToInt64(rowInfo["ID"]);
//                string website = Common.Obj2String(rowInfo["website"]);
//                DateTime dtLastUpdateCrawl = Convert.ToDateTime(redisDb.GetValueSession(iCompany, RedisCrawlerProduct.FieldSession_LastJobAt,
//                    SqlDb.MinDateDb.ToString(Common.Format_DateTime)));
//                int iMinHourDelayCrawl = Convert.ToInt32(rowInfo["iMinHourDelayCrawl"]);
//                int iFromLastJob = Convert.ToInt32((DateTime.Now - dtLastUpdateCrawl).TotalMinutes);
//                int iNumberWait = iFromLastJob - iMinHourDelayCrawl * 60;
//                if (iNumberWait > 0)
//                {
//                    PushJobCrawler(queueName, iCompany, connectionMQ);
//                    if (this.eventWhenAddJob != null)
//                        this.eventSkipCrawlByLastTime(this, string.Format("Push job: {0}:{1}",
//                            iCompany, website));

//                    //FullCrawler
//                    if (this.crawlTypeData == 0)
//                    {
//                        sqlCrawlerProductDb.UpdateLastFullCrawler(iCompany);
//                    }
//                    else if (this.crawlTypeData == 1)
//                    {
//                        //NewProductCrawler
//                        sqlCrawlerProductDb.UpdateLastCrawler(iCompany);
//                    }

//                }
//                else
//                {
//                    if (this.eventSkipCrawlByLastTime != null)
//                        this.eventSkipCrawlByLastTime(this, string.Format("Skip company {0}:{1}. Wait {2} minute",
//                            iCompany, website, Math.Abs(iNumberWait)));
//                }
//            }
//        }

//        private void PushJobCrawler(string queuName, long iCompany, IConnection connectionMQ)
//        {
//            //Xóa session cũ trong redis.
//            RedisCrawlerProduct redisCrawlerProduct = RedisCreator.CreateInstance();
//            redisCrawlerProduct.KeyDelete(RedisCrawlerProduct.Prefix_Set_VisitedLink + iCompany); //Set Visited.
//            redisCrawlerProduct.SetValueSession(this.crawlTypeData.ToString(), iCompany, RedisCrawlerProduct.FieldSession_NumberVisited, "0");
//            redisCrawlerProduct.SetValueSession(this.crawlTypeData.ToString(), iCompany, RedisCrawlerProduct.FieldSession_NumberProduct, "0");
            

//            var sql = new SqlDb(QT.Entities.Server.ConnectionString);
//            string strSql = string.Format("SELECT id from Configuration Where CompanyID = {0}", iCompany);
//            Configuration config = new Configuration(iCompany);
//            QT.Entities.Company company = new QT.Entities.Company(iCompany);
//            int session = Math.Abs(GABIZ.Base.Tools.getCRC32(Guid.NewGuid().ToString()));
//            redisCrawlerProduct.SetValueSession(this.crawlTypeData.ToString(), iCompany, RedisCrawlerProduct.FieldSession_SessionID, session.ToString());
//            QT.Entities.CrawlerProduct.TaskMQProduct task = new QT.Entities.CrawlerProduct.TaskMQProduct()
//            {
//                CompanyID = iCompany,
//                Deep = 0,
//                ImageUrl = "",
//                IsExtraction = true,
//                IsProduct = true,
//                Session = session,
//                TypeCrawler = this.crawlTypeData,
//                Url = company.Website,
//                IsTest=this.IsTest,
//                AllowSaveNewProduct=this.bAllowAddNew,
//                AllowSaveOldProduct=this.bAllowSaveOld
//            };
//            var channel = connectionMQ.CreateModel();
//            var a1 = Websosanh.Core.Common.BAL.ProtobufTool.Serialize(task);
//            channel.QueueDeclare(queuName, true, false, false, null);
//            channel.BasicPublish("", queuName, null, a1);

          
//        }
//    }
//}
