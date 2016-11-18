using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GABIZ.Base.Statistics.Kernels;
using log4net;
using Microsoft.Practices.ServiceLocation;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.CrawlerProduct.Cache;
using QT.Entities.Data;
using QT.Entities.Solr;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;
using QT.Moduls;
using QT.Moduls.CrawlerProduct.NoSql;
using QT.Moduls.CrawlerProduct.RabbitMQ;
using RabbitMQ.Client;
using RabbitMQ.Client.Framing;
using SolrNet;
using Websosanh.Core.JobServer;

namespace WSS.Core.Crawler
{
    public class ConsumerDuplicateToCache : QueueingConsumer
    {
        private readonly CacheDuplicateProduct _cacheDuplicateProduct = CacheDuplicateProduct.Instance();
        private ILog _log = LogManager.GetLogger(typeof (ConsumerDuplicateToCache));
        private ISolrOperations<HistoryProductSorl> solr;
        private int iCount = 0;


        public ConsumerDuplicateToCache() : base(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), ConfigCrawler.QueueDuplicateToCache, false)
        {
            InitData();
        }

        private void InitData()
        {

        }

        public ConsumerDuplicateToCache(string queueName) : base(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), queueName, false)
        {
            InitData();
        }

        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            try
            {
                iCount++;
                var pt = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductDuplicate>(Encoding.UTF8.GetString(message.Body));
                if (pt != null)
                {
                    _cacheDuplicateProduct.SetDuplicate(pt);
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex + Encoding.UTF8.GetString(message.Body));
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
