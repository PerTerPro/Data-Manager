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
    public class ConsumerTest
    {
       

        [Test()]
        public void WorkerFindNewTest()
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.LogConnectionString = ConfigCrawler.ConnectLog;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;
            long companyId = 7627466712688617332;
            var token = new CancellationToken();
            var wokerFn = new WorkerFindNew(companyId, token, "");
            wokerFn.StartCrawler();
            Assert.AreEqual(1,1);
        }

        private ConsumerFindNew consumerFindNew = null;
        [Test()]
        public void ConsumerWorkerFindNewTest()
        {
            var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler);
            var cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;
            Task.Factory.StartNew(() =>
            {
                consumerFindNew = new ConsumerFindNew(rabbitMqServer, "CompanyWaitCrawlerFindNew", token);
                consumerFindNew.Start();
            }, token);

            var countNumber = 0;
            while (true)
            {
                Thread.Sleep(60000);
                countNumber++;
                if (countNumber > 5)
                {
                    consumerFindNew.Stop();
                }
            }
        }

        [Test()]
        public void ConsumerWorkerReloadTest()
        {
            var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler);
            var cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;
            Task.Factory.StartNew(() =>
            {
                consumerFindNew = new ConsumerFindNew(rabbitMqServer, "CompanyWaitCrawlerReload", token);
                consumerFindNew.Start();
            }, token);

            var countNumber = 0;
            while (true)
            {
                Thread.Sleep(60000);
                countNumber++;
                if (countNumber > 5)
                {
                    consumerFindNew.Stop();
                }
            }
        }

        [Test()]
        public void TestReload()
        {
            QT.Entities.Server.ConnectionString = ConfigCrawler.ConnectProduct;
            var cancellationTokenSource = new CancellationTokenSource();
            long companyId = 1793534743671200240;
            var worker = new WorkerReload(companyId,cancellationTokenSource.Token,"");
            worker.StartCrawler();
            Assert.AreEqual(1, 1);

        }
    }
}
