using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities.Data;
using Websosanh.Core.Drivers.RabbitMQ;

namespace QT.Moduls.CrawlerProduct.Comment
{
    public class ConsumerDownlaodHtml : Websosanh.Core.Drivers.RabbitMQ.QueueingConsumer
    {
        public const string WSS_DOWNLOADHTML = "Wss.Comment.DownloadHtml";


        public override void ProcessMessage(global::RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            var productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            var CompanyId = Convert.ToInt64(Encoding.UTF8.GetString(message.Body));
            var pageIndex = 1;
            var tblProduct = productAdapter.GetProductLinkPushDownloadHtml(CompanyId, pageIndex);
            while (tblProduct.Rows.Count > 0)
            {
                foreach (DataRow VARIABLE in tblProduct.Rows)
                {
                    DownlaodHtml(Convert.ToInt64(VARIABLE["ID"]), CompanyId, Convert.ToString(VARIABLE["DetailUrl"]));
                }
            }
            GetChannel().BasicAck(message.DeliveryTag, true);
        }

        private void DownlaodHtml(long toInt64, long companyId, string toString)
        {
            
        }

        public override void Init()
        {
            
        }

        public ConsumerDownlaodHtml(RabbitMQServer rabbitmqServer, string queueName, bool autoAck) : base(rabbitmqServer, queueName, autoAck)
        {

        }
    }
}