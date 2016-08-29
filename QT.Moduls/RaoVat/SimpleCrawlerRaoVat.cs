using QT.Entities;
using QT.Entities.RaoVat;
using QT.Entities.Data;
using QT.Entities.Model.SaleNews;
using QT.Moduls.Crawler;
using QT.Moduls.CrawlSale;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace QT.Moduls.RaoVat
{
    public class SimpleCrawlerRaoVat : AbstractionCrawler
    {
        Dictionary<long, RaoVatClassification> dicClassification = new Dictionary<long, RaoVatClassification>();
        Dictionary<long, int[]> dicMapClassificationAndCategories = new Dictionary<long, int[]>();
        Dictionary<int, string[]> dicCityAndRegex = new Dictionary<int, string[]>();
        MongoDbRaoVat mongoDbAdapter = null;
        SqlDb sqlDb = null;
        RaoVatSQLAdapter sqlRaoVatAdapter = null;
        ConfigXPaths configXPath = null;
        ETypeCrawlRaoVat iTypeCrawler = ETypeCrawlRaoVat.None;

        /// <summary>
        /// 0-Full.
        /// 1-RealTime.
        /// </summary>
        /// <param name="iType"></param>
        public SimpleCrawlerRaoVat(int ConfigID, ETypeCrawlRaoVat TypeCrawler)
        {
            this.sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);
            this.iTypeCrawler = TypeCrawler;
            this.setAddedQueue = new SetCrawlerRaoVat(this.sqlDb, ConfigID, Convert.ToInt32(this.iTypeCrawler));
            this.queueWaitRun = new QueueCrawlerRaoVat(this.sqlDb, ConfigID, Convert.ToInt32(this.iTypeCrawler));
            this.sqlRaoVatAdapter = new RaoVatSQLAdapter(this.sqlDb);
            this.configXPath = sqlRaoVatAdapter.GetConfigByID(ConfigID);
            this.Domain = this.configXPath.domain;
            this.mongoDbAdapter = new MongoDbRaoVat();
            this.dicMapClassificationAndCategories = this.sqlRaoVatAdapter.GetDicMapClassificationAndCategories(this.configXPath.website_id);
            this.dicCityAndRegex = this.sqlRaoVatAdapter.GetDicCityAndRegex();
        }

        public override bool CheckExtractionLink(Job task)
        {
            if (this.iTypeCrawler == ETypeCrawlRaoVat.FullCrawler)
            {
                if (task.deep >= configXPath.wss_deep_full_crawler) return false;
                return Common.CheckRegex(task.url, this.configXPath.VisitUrlsRegex, this.configXPath.NoVisitUrlRegex, false);
            }
            else if (this.iTypeCrawler == ETypeCrawlRaoVat.CrawlerRealTime)
            {
                if (task.deep >= configXPath.wss_deep_reload_crawler) return false;
                else return Common.CheckRegex(task.url, this.configXPath.ReloadVisitUrlsRegex, this.configXPath.ReloadNoVisitUrlsRegex, false);
            }
            else if (this.iTypeCrawler==ETypeCrawlRaoVat.CrawlerKeyWord)
            {
                return Common.CheckRegex(task.url, this.configXPath.VisitUrlsRegex, this.configXPath.NoVisitUrlRegex, false);
            }
            return false;
        }

        public override void CleanDataAfterCrawler()
        {
        }

        public override void UpdateWhenEnd()
        {

        }

        public override bool AddJobToQueue()
        {
            return false;
        }

        public override void ProcessProductData(Job job, GABIZ.Base.HtmlAgilityPack.HtmlDocument document)
        {
            bool bSkip = false;

            //long a = QT.Entities.Common.PhanTichGiaTuNoiDung(document.ToString(), 0, 10000000);
            //if (iTypeCrawler==ETypeCrawlRaoVat.CrawlerKeyWord)
            //{
            //    bSkip = false;
            //}
            //else if (configXPath.is_find_new && configXPath.is_reload)
            //{
            //    bSkip = false;
            //}
            //else if (!configXPath.is_find_new && !CheckProductExists(Common.CrcProductID(job.url)))
            //{
            //    bSkip = true;
            //}
            //else if (!configXPath.is_reload && CheckProductExists(Common.CrcProductID(job.url)))
            //{
            //    bSkip = true;
            //}


            if (!bSkip)
            {
                ProductSaleNew product = new ProductSaleNew();
                int iError = (new HandlerContentOfHtml()).AnalyticsProductSaleNew(configXPath.domain, job.url, configXPath, product
                    , this.dicMapClassificationAndCategories, dicCityAndRegex);

                if (iTypeCrawler == ETypeCrawlRaoVat.CrawlerKeyWord && product.tags != null && product.tags.Count > 0)
                {
                    foreach(var keyword in product.tags)
                    {
                        long crcKeyword = Math.Abs(GABIZ.Base.Tools.getCRC64(keyword));
                        int statusInsert =  sqlRaoVatAdapter.UpdateKeyword(crcKeyword, keyword);
                        if (statusInsert == 1 && eventWhenSuccessProduct != null)
                            this.eventWhenSuccessProduct(this, string.Format("Insert keyword {0}", keyword));
                    }
                }
                else if (product.IsDetailSucess)
                {
                    if (product.classification_id > 0 && !dicClassification.ContainsKey(product.classification_id))
                    {
                        dicClassification.Add(product.classification_id, new RaoVatClassification()
                            {
                                id = product.classification_id,
                                category_ids = new int[] { },
                                name = product.web_category,
                                website_id = configXPath.website_id
                            });

                        bool bInsert = sqlRaoVatAdapter.InserClassification(new RaoVatClassification()
                            {
                                id = product.classification_id,
                                name = product.web_category,
                                website_id = configXPath.website_id
                            });
                    }

                    //Phân tích category.
                    if (product.category_ids == null || product.category_ids.Count() == 0)
                    {
                        product.category_ids = new List<int> { 31 };
                        sqlRaoVatAdapter.InsertToNeedAdapter(product.id, product.url, product.web_category);
                    }

                    if (this.eventWhenSuccessProduct != null)
                    {
                        this.eventWhenSuccessProduct(this, product.ToString());
                    }

                    string _id = this.mongoDbAdapter.GetProductbyID(product.id).Result;
                    bool bExits = _id != "";
                    if (bExits)
                    {
                        mongoDbAdapter.UpdateProduct(product);
                    }
                    else
                    {
                        mongoDbAdapter.InsertProduct(product);
                    }

                }
            }
        }

        private bool CheckProductExists(long p)
        {
            return this.mongoDbAdapter.CheckExistsProductSalenew(p);
        }

        public override void UpdateProcessedJob(Job task)
        {
            return;
        }

        public override bool CheckRegexVisit(string url)
        {
            if (iTypeCrawler == ETypeCrawlRaoVat.CrawlerRealTime)
            {
                return
                   Common.CheckRegex(QT.Entities.Common.CompactUrl(url), this.configXPath.ReloadVisitUrlsRegex, this.configXPath.ReloadNoVisitUrlsRegex, false) ||
                   Common.CheckRegex(QT.Entities.Common.CompactUrl(url), this.configXPath.ProductUrlsRegex, this.configXPath.NoProductUrlRegex, false);
            }
            else if (iTypeCrawler == ETypeCrawlRaoVat.FullCrawler)
            {
                return Common.CheckRegex(QT.Entities.Common.CompactUrl(url), this.configXPath.VisitUrlsRegex, this.configXPath.NoVisitUrlRegex, false) ||
                    Common.CheckRegex(QT.Entities.Common.CompactUrl(url), this.configXPath.ProductUrlsRegex, this.configXPath.NoProductUrlRegex, false);
            }
            else if (iTypeCrawler==ETypeCrawlRaoVat.CrawlerKeyWord)
            {
                return
                    Common.CheckRegex(QT.Entities.Common.CompactUrl(url), this.configXPath.VisitUrlsRegex, this.configXPath.NoVisitUrlRegex, false);
            }
            return false;
        }

        public override bool CheckRegexProduct(string url)
        {
            return Common.CheckRegex(QT.Entities.Common.CompactUrl(url), this.configXPath.ProductUrlsRegex, this.configXPath.NoProductUrlRegex, false);
        }

        public override bool CheckStopCrawler(Job job)
        {
            return false;
        }

        public override string GetHtmlOfWeb(string url)
        {
            Thread.Sleep(configXPath.TimeDelay);
            return GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2);
        }
    }
}
