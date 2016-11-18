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
    public class ConsumerLinkFindNewToSolrTests
    {
        [Test()]
        public void ConsumerLinkFindNewToSolrTest()
        {
            ConsumerLinkFindNewToSolr consumer = new ConsumerLinkFindNewToSolr();
            consumer.StartConsume();
        }

        [Test()]
        public void ConsumerLinkFindNewToSolrTest1()
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
    }
}
