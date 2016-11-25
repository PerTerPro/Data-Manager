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
    public class ConsumerNotifyCompanyToSqlTests
    {
        [Test()]
        public void ConsumerNotifyCompanyToSqlTest()
        {
            ConsumerNotifyCompanyToSql consumer = new ConsumerNotifyCompanyToSql(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), "Notifycation.Warning.Company");
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
