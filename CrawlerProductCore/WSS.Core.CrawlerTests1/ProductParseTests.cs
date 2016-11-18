using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using WSS.Core.Crawler;
using NUnit.Framework;
using QT.Entities;
using QT.Moduls.CrawlerProduct;

namespace WSS.Core.Crawler.Tests
{
    [TestFixture()]
    public class ProductParseTests
    {
        [Test()]
        public void AnalyticsTest()
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.LogConnectionString = ConfigCrawler.ConnectLog;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;

            string url = @"http://giadungchinhhang.vn/san-pham-chi-tiet/am-sieu-toc-philips-hd-4646--15-l-15.aspx";
            ProductParse productParse = new ProductParse(); 
            ProductEntity productEntity =new ProductEntity();
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            var config = new Configuration(1793534743671200240);
            productParse.Analytics(productEntity, doc, url, config, "giadungchinhhang.vn");
            bool bok = productEntity.IsSuccessData(false);
            Assert.AreEqual(productEntity.Price, 10590000);
            Assert.AreEqual(bok, true);
        }

        [Test()]
        public void AnalyticsTHEGIOICAYXANHTest()
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.LogConnectionString = ConfigCrawler.ConnectLog;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;

            string url = @"http://thegioicayxanh.vn/cay-van-phong/cay-chan-ret.html";
            ProductParse productParse = new ProductParse();
            ProductEntity productEntity = new ProductEntity();
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            var config = new Configuration(8153388634833285394);
            productParse.Analytics(productEntity, doc, url, config, "thegioicayxanh.vn");
            bool bok = productEntity.IsSuccessData(false);
            Assert.AreEqual(productEntity.Price, 10590000);
            Assert.AreEqual(bok, true);
        }


        [Test()]
        public void AnalyticsDienmayTantienTest()
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.LogConnectionString = ConfigCrawler.ConnectLog;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;

            string url = @"http://dienmaytantien.vn/detail.asp?parent_id=336&id=2204";
            long companyId = 8223820966383374348;

            ProductParse productParse = new ProductParse();
            ProductEntity productEntity = new ProductEntity();
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2);
            html = System.Web.HttpUtility.HtmlDecode(html);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            var config = new Configuration(companyId);
            var company = new Company(companyId);
            productParse.Analytics(productEntity, doc, url, config, company.Domain);
            bool bok = productEntity.IsSuccessData(false);
            Assert.AreEqual(productEntity.Price, 10590000);
            Assert.AreEqual(bok, true);
        }

        [Test()]
        public void AnalyticsDongho12hTest()
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.LogConnectionString = ConfigCrawler.ConnectLog;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;
            string url = @"http://dongho12h.vn/product/fune2006w0.html";
            long companyId = 297705792783058114;
            ProductParse productParse = new ProductParse();
            ProductEntity productEntity = new ProductEntity();
            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2);
            html = System.Web.HttpUtility.HtmlDecode(html);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            var config = new Configuration(companyId);
            var company = new Company(companyId);
            productParse.Analytics(productEntity, doc, url, config, company.Domain);
            bool bok = productEntity.IsSuccessData(false);
            Assert.AreEqual(productEntity.Price, 10590000);
            Assert.AreEqual(bok, true);
        }
    }
}
