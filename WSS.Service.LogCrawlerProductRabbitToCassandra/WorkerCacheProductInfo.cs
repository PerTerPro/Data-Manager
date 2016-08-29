using QT.Entities.CrawlerProduct;
using QT.Entities.CrawlerProduct.RabbitMQ;
using QT.Entities.Data;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Service.LogCrawlerProductRabbitToCassandra
{
    public class WorkerCacheProductInfo : Websosanh.Core.Drivers.RabbitMQ.BasicGetConsumer
    {
        private CancellationToken tokenStop;
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(WorkerCacheProductInfo));

        public WorkerCacheProductInfo(RabbitMQServer rabbitmqServer, string queueName, bool autoAck, CancellationToken tokenStop1)
            : base(rabbitmqServer, queueName, autoAck)
        {
            this.tokenStop = tokenStop1;
        }

        public void Run()
        {
            
        }

        public void Stop()
        {
            
        }

        public override void Init()
        {
            
        }
    }
}