using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Core.Crawler;
using NUnit.Framework;
using Websosanh.Core.Drivers.RabbitMQ;
using QT.Entities;
namespace WSS.Core.Crawler.Tests
{
    [TestFixture()]
    public class ConsumerProductChangeToCacheTests
    {
        [Test()]
        public void ConsumerProductChangeToCacheTest()
        {
            ConsumerProductChangeToCache consumerTest = new ConsumerProductChangeToCache(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), ConfigCrawler.QueueProductChangeToCache);
            consumerTest.StartConsume();
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
