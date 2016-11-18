using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WSS.Core.Crawler;
using NUnit.Framework;
using QT.Entities;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Core.Crawler.Tests
{
    [TestFixture()]
    public class ConsumerReloadTests
    {
        [Test()]
        public void ConsumerReloadTest()
        {
           
        }

        [Test()]
        public void StartTest()
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;
            Server.LogConnectionString = ConfigCrawler.ConnectLog;
            ConsumerReload consumer = null;
            var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler);
            var cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;
            
            Task.Factory.StartNew(() =>
            {
                consumer = new ConsumerReload(rabbitMqServer, ConfigCrawler.QueueCompanyReload, token);
                consumer.Start();
            }, token);
            var countNumber = 0;
            while (true)
            {
                Thread.Sleep(60000);
                countNumber++;
                if (countNumber > 5)
                {
                    consumer.Stop();
                }
            }
        }

        [Test()]
        public void StopTest()
        {
            Assert.Fail();
        }
    }
}
