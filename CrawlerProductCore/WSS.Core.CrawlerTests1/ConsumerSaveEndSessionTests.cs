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
    public class ConsumerSaveEndSessionTests
    {
        [Test()]
        public void ConsumerSaveEndSessionTest()
        {
            ConsumerSaveEndSession consumerSaveEndSession = new ConsumerSaveEndSession("CrawlerProduct.EndSession");
            consumerSaveEndSession.StartConsume();
        }

        [Test()]
        public void InitTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void ProcessMessageTest()
        {
            Assert.Fail();
        }
    }
}
