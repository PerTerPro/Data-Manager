using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WSS.Core.Crawler;
using NUnit.Framework;
using QT.Entities;

namespace WSS.Core.Crawler.Tests
{
    [TestFixture()]
    public class WorkerReloadTests{
        [Test]
        public void WorkerReload_CrawlerTest()
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.LogConnectionString = ConfigCrawler.ConnectLog;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;
            var companyId = 7627466712688617332;
            var token = new CancellationToken();
            var wokerFn = new WorkerReload(companyId, token,"");
            wokerFn.StartCrawler();
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void WorkerFindNew_CrawlerTest()
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.LogConnectionString = ConfigCrawler.ConnectLog;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;
            var companyId = 7627466712688617332;
            companyId = 1030904211013055886;
            var token = new CancellationToken();
            var wokerFn = new WorkerFindNew(companyId, token,"");
            wokerFn.StartCrawler();
            Assert.AreEqual(1, 1);
        }
    }
}
