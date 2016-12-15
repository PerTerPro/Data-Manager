using NUnit.Framework;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler;
using WSS.Core.Crawler.CrlProduct;

namespace WSS.Core.CrawlerTests2.CrlProduct
{
    [TestFixture()]
    public class WorkerRlTests
    {
        [Test()]
        public void ProcessMessageTest()
        {
            var workerFn = new WorkerMqRl(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.QueueVipCompanyReload);
            workerFn.StartConsume();
        }

        [Test()]
        public void InitTest()
        {
          
        }

        [Test()]
        public void WorkerRlTest()
        {
            
        }
    }
}
