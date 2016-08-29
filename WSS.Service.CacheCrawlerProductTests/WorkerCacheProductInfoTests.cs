using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Service.CacheCrawlerProduct;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Websosanh.Core.Drivers.RabbitMQ;
using System.Threading;
namespace WSS.Service.CacheCrawlerProduct.Tests
{
    [TestClass()]
    public class WorkerCacheProductInfoTests
    {
        [TestMethod()]
        public void RunTest()
        {
            //CancellationTokenSource cancelSource = new CancellationTokenSource();
            //var Server =   RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            //WSS.Service.CacheCrawlerProduct.Worker worker = new Worker(Server, "CacheCrawlerProduct.Refresh.ProductInfo", true, cancelSource.Token);
            //worker.Run();
        }
    }
}
