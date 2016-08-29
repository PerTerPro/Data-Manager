using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Core.Crawler;
using NUnit.Framework;
using Websosanh.Core.Drivers.RabbitMQ;
namespace WSS.Core.Crawler.Tests
{
    [TestFixture()]
    public class ConsumerPushNotifyCompanyTests
    {
        [Test()]
        public void ConsumerPushNotifyCompanyTest()
        {
            var consumer = new ConsumerPushNotifyCompany(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.QueueWaitCheckNotify);
            consumer.StartConsume();
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
