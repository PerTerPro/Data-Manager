using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Core.Crawler;
using NUnit.Framework;
namespace WSS.Core.Crawler.Tests
{
    [TestFixture()]
    public class ConsumerHistoryProductToSolrTests
    {
        [Test()]
        public void ConsumerHistoryProductToSolrTest()
        {
            ConsumerHistoryProductToSolr c = new ConsumerHistoryProductToSolr(ConfigCrawler.QueueHistoryToSolr);
            c.StartConsume();
        }

        [Test()]
        public void ConsumerHistoryProductToSolrTest1()
        {
           
        }

        [Test()]
        public void InitTest()
        {
            
        }

        [Test()]
        public void ProcessMessageTest()
        {
           
        }

        [Test()]
        public void ConsumerHistoryProductToSolrTest2()
        {
            Assert.Fail();
        }

        [Test()]
        public void ConsumerHistoryProductToSolrTest3()
        {
            var consumer = new ConsumerHistoryProductToSolr(ConfigCrawler.QueueVisitedLinkFindNewToCassandra);
            consumer.StartConsume();
        }

        [Test()]
        public void InitTest1()
        {
            Assert.Fail();
        }

        [Test()]
        public void ProcessMessageTest1()
        {
            Assert.Fail();
        }
    }
}
