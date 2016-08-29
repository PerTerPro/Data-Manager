//using QT.Entities;
//using QT.Entities.CrawlerProduct;
//using QT.Entities.Data;
//using QT.Moduls.Crawler;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace QT.Moduls.CrawlProd
//{
//    public class SimpleCrawlerProduct:AbstractionCrawler
//    {
//        private QT.Entities.Data.ProductLogAddAdapter productLogAddAdapter = null;
//        Configuration config;
//        public QT.Entities.Company company;
//        public int typeCrawer;
//        public bool bIsTest = true;
//        public ProductAdapter productAdapter = null;
//        public EventReportRun eventWhenHadProduct;
//        SqlDb sqlDb = null;
//        public DateTime dtStartCrawler;
//        HashSetProduct hashProduct;
//        RedisSession redisSession;
//        bool bIsReloadData = false;
//        public EventReportRun eventWhenFailReload;

//        public SimpleCrawlerProduct(long iCompany, IQueueWait queueRun, ISetAddedVisited setAddedQueue
//            , int TypeCrawler, DateTime dtPushJob, bool IsTest)
//        {
//            List<string> lst = new List<string>();
//            this.queueWaitRun = queueRun;
//            this.setAddedQueue = new SetAddedQueueRedis(iCompany, TypeCrawler);
//            this.config = new Configuration(iCompany);
         
//            this.sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
//            this.productAdapter = new ProductAdapter(this.sqlDb);
//            this.productLogAddAdapter = new ProductLogAddAdapter(this.sqlDb);

//            this.typeCrawer = TypeCrawler;
//            this.company = new Entities.Company(iCompany);
//            this.dtStartCrawler = dtPushJob;
//            this.setAddedQueue = setAddedQueue;
//            this.ExtractionLink = typeCrawer != 1;
//            this.bIsTest = IsTest;
//            this.redisSession = new RedisSession();
//            this.hashProduct = new HashSetProduct();
//            if (typeCrawer == 1) this.bIsReloadData = true;
//        }

//        public override void UpdateProcessedJob(Job task)
//        {
//            if (this.bIsReloadData)
//            {
//                long idProduct = (task.product_id > 0) ? task.product_id : Common.GetIDProduct(task.url);
//                this.sqlDb.RunQuery("update product set lastupdate = getdate() where id=@id", CommandType.Text,
//                new SqlParameter[] { sqlDb.CreateParamteter("id", task.product_id, SqlDbType.BigInt) });
//                this.redisSession.SetLastJob(this.company.ID, this.typeCrawer, this.sqlDb.GetCurrent());
//            }
//        }

//        public override bool CheckRegexVisit(string url)
//        {
//            return QT.Entities.Common.CheckRegex(url, config.VisitUrlsRegex, config.NoVisitUrlRegex, false);
//        }

//        public override bool CheckRegexProduct(string url)
//        {
//            return QT.Entities.Common.CheckRegex(url, config.ProductUrlsRegex, null, false);
//        }

//        public override bool CheckStopCrawler(Job job)
//        {
//            return IsStoped;
//        }

//        public override string GetHtmlOfWeb(string url)
//        {
//            if (config.TimeDelay > 0) Thread.Sleep(config.TimeDelay);
//            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2);
//            html = html.Replace("<form", "<div");
//            html = html.Replace("</form", "</div");
//            return html;
//        }

//        public override void ProcessProductData(Job job, GABIZ.Base.HtmlAgilityPack.HtmlDocument doc)
//        {
//            try
//            {
//                long idProduct = (job.product_id > 0) ? job.product_id : Common.GetIDProduct(job.url);
//                QT.Entities.Product p = new Product();
//                //bool bSuccessData = ();
//                if (p != null) p.IDCongTy = this.company.ID;
//                p.Analytics(doc, job.url, config, false, this.company.Domain);

//                //Reload dữ liệu && Không load dược sản phẩm => Ghi nhận hoặc update valid.
//                if (bIsReloadData)
//                {
//                    hashProduct.SetLastReload(idProduct);
//                    if ((p != null) && (p.Price > 0) && (!string.IsNullOrEmpty(p.Name)))
//                    {
//                        hashProduct.ResetFailProduct(idProduct);
//                    }
//                    else
//                    {
//                        int numberFailCurrent = hashProduct.GetFailProduct(idProduct, 0);
//                        if (numberFailCurrent < 10)
//                        {
//                            //Tăng lần đếm số lượng Fail.
//                            hashProduct.IncreateFailProduct(idProduct);
//                        }
//                        else
//                        {
//                            this.sqlDb.RunQuery("update product set valid = 0 where id = @id", CommandType.Text, new SqlParameter[]{
//                                sqlDb.CreateParamteter("id",idProduct,SqlDbType.BigInt)
//                            });
//                        }
//                        if (this.eventWhenFailReload != null) 
//                            this.eventWhenFailReload(this, string.Format("Url:{0}. ProductID:{1}. NumberFail:{2} ",job.url, job.product_id, numberFailCurrent++));
//                    }
//                }

                
//                if (p != null)
//                {
//                    bool bExitsInDb = this.productAdapter.CheckExistInDb(p.ID);
//                    if ((p.Price > 0) && (p.Name.Trim().Length > 0))
//                    {
//                        bool bSave = false;
//                        if (typeCrawer == 2 && !bExitsInDb)
//                        {
//                            //Tim SP moi va SP chua co tren DB
//                            bSave = true;
//                        }
//                        else if (typeCrawer == 0 || typeCrawer == 1 || typeCrawer == 3)
//                        {
//                            //Crawl ALL du lieu.
//                            //OR. Reload Data.
//                            bSave = true;
//                        }

//                        if (bSave && this.eventWhenHadProduct != null)
//                        {
//                            this.eventWhenHadProduct(this, "\n----------------------->\n" + p.ToString());
//                            this.redisSession.IncrFieldNumberProduct(company.ID, typeCrawer);
//                        }

//                        if (bSave && this.bIsTest == false)
//                        {
//                            this.UpdateProduct(p, bExitsInDb);
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//            }
//        }

//        private void UpdateProduct(Product p, bool bExitsInDb)
//        {
//            this.productAdapter.UpdateProduct(p);
//            if (!bExitsInDb) this.productLogAddAdapter.InsertLogAddProduct(p.IDCongTy, p.ID, p.Name, p.DetailUrl);
//        }

      

//        public override bool AddJobToQueue()
//        {
//            //Reload dữ liệu. Add thêm 200 sản phẩm từ công ty này
//            if (typeCrawer == 1)
//            {
//                DataTable tblPush = this.sqlDb.GetTblData("SELECT TOP 5000 ID, DetailUrl FROM Product WHERE Company=@CompanyID AND LastUpdate<@StartCrawler",
//                    CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
//                    sqlDb.CreateParamteter("CompanyID",this.company.ID,SqlDbType.BigInt),
//                    sqlDb.CreateParamteter("StartCrawler",dtStartCrawler,SqlDbType.DateTime)
//                });

//                if (tblPush != null && tblPush.Rows.Count > 0)
//                {
//                    foreach (DataRow row in tblPush.Rows)
//                    {
//                        this.PushQueue(new Job()
//                            {
//                                deep = 0,
//                                url = Convert.ToString(row["DetailUrl"]),
//                                product_id = Convert.ToInt64(row["id"])
//                            });
//                    }
//                    return true;
//                }
//            }
//            return false;
//        }

//        public override void UpdateWhenEnd()
//        {
//            this.redisSession.CleanSession(company.ID, typeCrawer);
//            if (typeCrawer == 0 || typeCrawer == 2)
//            {
//                this.sqlDb.RunQuery("update company set  LastFullCrawler = getdate() from Company where id = @id"
//                    , CommandType.Text, new SqlParameter[]{sqlDb.CreateParamteter("id",company.ID,SqlDbType.BigInt)
//                });
//            }
//            else if (typeCrawer == 1)
//            {
//                this.sqlDb.RunQuery("update company set  LastCrawler = getdate() from Company where id = @id"
//                    , CommandType.Text, new SqlParameter[]{sqlDb.CreateParamteter("id",company.ID,SqlDbType.BigInt)
//                });
//            }
//        }

//        public override void CleanDataAfterCrawler()
//        {
             
//        }


//        public override bool CheckExtractionLink(Job task)
//        {
//            if (this.typeCrawer == 3 && task.deep > 5) return false;
//            else return this.ExtractionLink;
//        }
//    }
//}
