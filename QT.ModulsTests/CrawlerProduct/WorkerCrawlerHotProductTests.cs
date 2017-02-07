using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Moduls.CrawlerProduct;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using QT.Entities;
using QT.Entities.Data;

namespace QT.Moduls.CrawlerProduct.Tests
{
    [TestFixture()]
    public class WorkerCrawlerHotProductTests
    {
        [Test()]
        public void StartRunTest()
        {
            QT.Entities.Server.ConnectionString = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
            long companyId = 8220568010056870095;
            ProductAdapter pa = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            var conf = pa.GetConfigurationHotProductBy(8220568010056870095);
            WorkerCrawlerHotProduct worker = new WorkerCrawlerHotProduct(new Entities.Company(companyId), new Configuration(companyId), conf);
            //w.StartRun();
            IWebDriver websDriver = new ChromeDriver();
            websDriver.Url = @"https://shoptretho.com.vn/";
            string str = websDriver.PageSource;
            websDriver.Close();
            Assert.IsNotNull(conf);
        }
    }
}
