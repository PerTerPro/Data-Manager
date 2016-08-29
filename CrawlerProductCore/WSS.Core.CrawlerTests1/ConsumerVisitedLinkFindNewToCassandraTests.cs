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
    public class ConsumerVisitedLinkFindNewToCassandraTests
    {
        [Test()]
        public void ConsumerVisitedLinkFindNewToCassandraTest()
        {
           
        }

        [Test()]
        public void ConsumerVisitedLinkFindNewToCassandraTest1()
        {
            
        }

        [Test()]
        public void InitTest()
        {
           
        }

        [Test()]
        public void ProcessMessageTest()
        {
            var consumer = new ConsumerVisitedLinkFindNewToCassandra(ConfigCrawler.QueueVisitedLinkFindNewToCassandra);
            consumer.StartConsume();
        }
    }
}
