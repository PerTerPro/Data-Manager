using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
using RabbitMQ.Client.Framing.Impl;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Core.Crawler
{
    public class ConsumerResetDuplicate : QueueingConsumer
    {
        private readonly ILog _log = LogManager.GetLogger(typeof (ConsumerResetDuplicate));
        private readonly ProductAdapter _productAdapter = new ProductAdapter(new SqlDb(ConfigCrawler.ConnectProduct));
        private readonly CacheDuplicateProduct _cacheCheckDuplicateProduct = CacheDuplicateProduct.Instance();


        public ConsumerResetDuplicate(RabbitMQServer rabbitmqServer, string queueName)
            : base(rabbitmqServer, queueName, false)
        {
            
        }

        private void ResetForCompany(long companyId)
        {
            List<long> lstDeleteProduct = new List<long>();
            var lstCacheDuplicate = _cacheCheckDuplicateProduct.GetAllDuplicateOfCompany(companyId);
            var lstProductIds = _productAdapter.GetAllProductIDsByCompany(companyId);
            foreach (var productDuplicate in lstCacheDuplicate)
            {
                if (!lstProductIds.Contains(productDuplicate.IdDup))
                {
                    lstDeleteProduct.Add(productDuplicate.Id);
                }
            }
            _cacheCheckDuplicateProduct.DeleteProductDuplicated(companyId, lstDeleteProduct);

            _log.Info(string.Format("Reset for company {0} number product {1} number duplicate item {2} deleted product duplicate {3}", companyId, lstCacheDuplicate.Count, lstProductIds.Count,
                lstDeleteProduct.Count));
        }

        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            long companyId = Convert.ToInt64(UTF8Encoding.UTF8.GetString(message.Body));
            ResetForCompany(companyId);
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }

        public override void Init()
        {
            
        }
    }
}
