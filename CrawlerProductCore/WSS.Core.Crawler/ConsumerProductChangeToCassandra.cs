using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GABIZ.Base.Statistics.Kernels;
using log4net;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.CrawlerProduct.Cache;
using QT.Entities.Data;
using QT.Entities.Solr;
using QT.Moduls.CrawlerProduct;using QT.Moduls.CrawlerProduct.Cache;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;
using QT.Moduls;
using QT.Moduls.CrawlerProduct.NoSql;
using QT.Moduls.CrawlerProduct.RabbitMQ;
using RabbitMQ.Client;
using RabbitMQ.Client.Framing;
using Websosanh.Core.JobServer;

namespace WSS.Core.Crawler
{
    public class ConsumerProductChangeToCassandra : QueueingConsumer
    {
        private ILog _log = LogManager.GetLogger(typeof(ConsumerProductChangeToCassandra));
        private readonly NoSqlHistoryCrawler _noSqlHistoryCrawler = NoSqlHistoryCrawler.Instance();
        private ProducerBasic _producerHistoryProduct = null;

        public ConsumerProductChangeToCassandra()
            : base(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), ConfigCrawler.QueueProductChangetoCassandra, false)
        {
            InitData();
        }

        private void InitData()
        {
            _producerHistoryProduct = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.QueueHistoryToSolr);
        }

        public ConsumerProductChangeToCassandra(string queueName)
            : base(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), queueName, false)
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
                var pt = ProductEntity.GetFromJson(message.Body);
                if (!string.IsNullOrEmpty(pt.Session))
                {
                    _noSqlHistoryCrawler.InsertProduct(pt);
                    _producerHistoryProduct.PublishString(
                        Newtonsoft.Json.JsonConvert.SerializeObject(new HistoryProductSorl()
                        {
                            DateUpdate = Convert.ToInt32(pt.LastUpdate.ToString("yyyyMMdd")),
                            CompanyId = pt.CompanyId,
                            Id = pt.ID + ":" + pt.Session,
                            ProductId = pt.ID,
                            LastUpdate = pt.LastUpdate.Ticks,
                            Session = pt.Session,
                            DetailUrl = pt.DetailUrl,
                            TypeRun = 1,
                        }));
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
