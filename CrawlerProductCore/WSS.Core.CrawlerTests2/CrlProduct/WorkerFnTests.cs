using System.Data;
using NUnit.Framework;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler;
using WSS.Core.Crawler.CrlProduct;

namespace WSS.Core.CrawlerTests2.CrlProduct
{
    [TestFixture()]
    public class WorkerFnTests
    {
        [Test()]
        public void ProcessMessageTest()
        {
            var workerFn = new WorkerMqFn(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.QueueVipCompanyFindNew);
            workerFn.StartConsume();
        }

        [Test()]
        public void PushJobToTest()
        {
            var producerBasic = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.QueueVipCompanyFindNew);
            producerBasic.PublishString(new JobCompanyCrawler()
            {
                CheckRunning = true,
                CompanyId = 2102811518945449457
            }.GetJSon());
        }

        [Test()]
        public void PushCmpToFn()
        {
             
        }

        [Test()]
        public void WorkerFnTest()
        {
          
        }
    }
}
