using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;
using System.Data;
using System.Data.SqlClient;
using log4net.Util;
using QT.Moduls;

namespace WSS.Core.Crawler
{
  

    public class ConsumerSaveEndSession : QueueingConsumer
    {
        private ILog _log = LogManager.GetLogger(typeof(ConsumerProductChangeToSql));
        private readonly ProductAdapter _productAdapter = null;
        private readonly ProducerBasic _producerNoValidTotalProduct = null;

        public ConsumerSaveEndSession(string queueName)
            : base(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler), queueName, false)
        {
            _productAdapter = new ProductAdapter(new SqlDb(ConfigCrawler.ConnectProduct));
            _producerNoValidTotalProduct = new ProducerBasic(this._rabbitMQServer, ConfigCrawler.QueueWaitCheckNotify);
        }

        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            var crawlerSession = CrawlerSessionLog.GetFromJson(message.Body);
            bool bOk = _productAdapter.UpdateEndCrawl(crawlerSession);
            _log.InfoFormat("Company: {0} UpdateOK: {1} ", crawlerSession.CompanyId, bOk);
            NotifyValidatedProduct(crawlerSession.CompanyId);
            GetChannel().BasicAck(message.DeliveryTag, true);
        }

        private void NotifyValidatedProduct(long companyID)
        {
            _producerNoValidTotalProduct.PublishString(companyID.ToString());

        }
    }
}
