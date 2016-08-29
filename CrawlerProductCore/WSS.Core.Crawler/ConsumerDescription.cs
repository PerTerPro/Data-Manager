using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cassandra;
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
    public class ConsumerDescription : QueueingConsumer
    {
        private ILog _log = LogManager.GetLogger(typeof (ConsumerHistoryProductToSolr));
        private ISolrOperations<HistoryProductSorl> _solr;
        private int iCount = 0;
        private readonly List<HistoryProductSorl> _lstCacheList = new List<HistoryProductSorl>();

        public ConsumerDescription(RabbitMQServer rabbitMqServer, string queueCheckDescription) : base(rabbitMqServer, queueCheckDescription, false)
        {

        }



        public ConsumerDescription(string queueName)
            : base(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), queueName, false)
        {
            
        }

        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            try
            {
                QT.Entities.ProductEntity productEntity = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductEntity>(UTF8Encoding.UTF8.GetString(message.Body));
                long hashDesciption = productEntity.GetHashDesc();
            }
            catch (Exception ex)
            {
                _log.Error(ex + Encoding.UTF8.GetString(message.Body));
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
