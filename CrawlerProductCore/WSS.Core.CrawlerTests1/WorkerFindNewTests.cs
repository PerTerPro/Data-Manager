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
    public class WorkerFindNewTests
    {
        [Test()]
        public void WorkerFindNewTest()
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.LogConnectionString = ConfigCrawler.ConnectLog;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;
            var companyId = 3253699259256465481;
            var token = new CancellationToken();
            var wokerFn = new WorkerFindNew(companyId, token, "");
            wokerFn.StartCrawler();
            Assert.AreEqual(1, 1);
        }

        [Test()]
        public void StartTest()
        {
         
        }

        [Test()]
        public void InitTest()
        {
           
        }

        [Test()]
        public void EndTest()
        {
            
        }

        [Test()]
        public void StopTest()
        {
           
        }
    }
}
