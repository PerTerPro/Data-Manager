using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Core.Crawler;
using NUnit.Framework;
using QT.Entities;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Core.Crawler.Tests
{
    [TestFixture()]
    public class ConsumerProductChangeToSqlTests
    {
        [Test()]
        public void ConsumerProductChangeToSqlTest()
        {
            ConsumerProductChangeToSql c = new ConsumerProductChangeToSql(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), ConfigCrawler.QueueProductChangeToSql);
            c.StartConsume();
        }

        [Test()]
        public void ConsumerProductChangeToSqlTest1()
        {ConsumerProductChangeToSql c = new ConsumerProductChangeToSql();
            c.StartConsume();
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

        [Test()]
        public void ConsumerProductChangeToSqlTest2()
        {
           
        }

        [Test()]
        public void ConsumerProductChangeToSqlTest3()
        {
            Assert.Fail();
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
