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
          
        }

        [Test()]
        public void StartCrawlerTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void StartCrawlerTest1()
        {
            Assert.Fail();
        }

        [Test()]
        public void InitTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void LogImportantInfoTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void EndTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void StopTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void DisposeTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void WorkerFindNewTest1()
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler; Server.LogConnectionString = ConfigCrawler.ConnectLog;
            WorkerFindNew w = new WorkerFindNew(6173371936664403895, "");
            w.StartCrawler();
        }


        [Test()]
        public void WorkerReloadTest1()
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler; Server.LogConnectionString = ConfigCrawler.ConnectLog;
            WorkerReload w = new WorkerReload(2365377961928198678, "");
            w.StartCrawler();
        }


        [Test()]
        public void StartCrawlerTest2()
        {
          
        }

        [Test()]
        public void StartCrawlerTest3()
        {
           
        }

        [Test()]
        public void InitTest1()
        {
          
        }

        [Test()]
        public void LogImportantInfoTest1()
        {
           
        }

        [Test()]
        public void EndTest1()
        {
           
        }

        [Test()]
        public void StopTest1()
        {
           
        }

        [Test()]
        public void DisposeTest1()
        {
           
        }
    }
}
