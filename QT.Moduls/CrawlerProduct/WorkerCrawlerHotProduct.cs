using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.Crawler;

namespace QT.Moduls.CrawlerProduct
{
    public interface IWorkerCrawlerHotProduct
    {
        void StartRun();
    }

    public class Downloader : IDownloadHtml
    {
       private DownloadHtmlCrawler downloadOld = new DownloadHtmlCrawler();
        public string GetHTML(string url, int secondsTimeOut, int numTry, out WebExceptionStatus status, bool bUseSelenium=false)
        {
            if (!bUseSelenium)
                return downloadOld.GetHTML(url, secondsTimeOut, numTry, out status);
            else
            {
                IWebDriver websDriver = new ChromeDriver();
                websDriver.Url = url;
                string str = websDriver.PageSource;
                websDriver.Close();
                status=WebExceptionStatus.UnknownError;
                return str;
            }
        }

        public string GetHTML(string url, int secondsTimeOut, int numTry, out WebExceptionStatus status)
        {
            return downloadOld.GetHTML(url, secondsTimeOut, numTry, out status);
        }
    }

    public class WorkerCrawlerHotProduct : IWorkerCrawlerHotProduct
    {
        private Downloader downloadHtml = new Downloader();
        private IProductParser producerParser = new ProductParse();
        private Entities.Configuration configuration;
        private  ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));

        private Entities.CrawlerProduct.ConfigurationHotProduct configurationHotProduct;
        private Entities.Company company = null;

        public delegate void EventLogRun(string log);
        public EventLogRun eventLogRun = null;

        public WorkerCrawlerHotProduct(Entities.Company company, Entities.Configuration configuration, Entities.CrawlerProduct.ConfigurationHotProduct configurationHotProduct)
        {
            // TODO: Complete member initialization
            this.configuration = configuration;
            this.configurationHotProduct = configurationHotProduct;
            this.company = company;
        }

        public void StartRun()
        {
            WebExceptionStatus outS = WebExceptionStatus.UnknownError;
            foreach (var linkExtraction in this.configurationHotProduct.HotProduct_Link.Split(new char[] {',', '\n', ';'}, StringSplitOptions.RemoveEmptyEntries))
            {
                this.LogData("Get html of cat page");
                string html = downloadHtml.GetHTML(linkExtraction, 45, 2, out outS, this.configurationHotProduct.HotProduct_UseSelenium);
                if (!string.IsNullOrEmpty(html))
                {
                    HtmlDocument htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(html);
                    var nodeLinks = htmlDocument.DocumentNode.SelectNodes(this.configurationHotProduct.HotProduct_Xpath);
                    if (nodeLinks != null)
                    {
                        foreach (var VARIABLE in nodeLinks)
                        {
                            try
                            {
                                string shortLink = VARIABLE.GetAttributeValue("href", "");

                                string fullLink = Common.GetAbsoluteUrl(shortLink, new Uri(this.company.Website));
                                this.LogData(string.Format("Process link product {0}", fullLink));
                                string htmlLinkProduct = this.downloadHtml.GetHTML(fullLink, 45, 2, out outS);

                                HtmlDocument h = new HtmlDocument();
                                h.LoadHtml(htmlLinkProduct);
                                if (!string.IsNullOrEmpty(htmlLinkProduct))
                                {
                                    ProductEntity productEntity = new ProductEntity();
                                    this.producerParser.Analytics(productEntity, h, fullLink, this.configuration, this.company.Domain);
                                    if (productEntity.IsSuccessData(true))
                                    {
                                        this.productAdapter.UpsertProductHot(productEntity);
                                        this.LogData(string.Format("Saved a product to database. {0} {1} {2}", productEntity.ID,
                                            productEntity.Name, productEntity.Price));
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                LogData(string.Format("Error: {0} {1}", ex.Message, ex.StackTrace));
                            }
                        }

                    }
                }
            }
        }

        private void LogData(string p)
        {
            if (eventLogRun != null)
                this.eventLogRun(p);
        }
    }
}
