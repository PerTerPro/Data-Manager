using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace QT.Moduls.CrawlerProduct.Comment
{
    public class PublisherDownloadHtml : Producer
    {
        private ILog _log = log4net.LogManager.GetLogger(typeof(PublisherDownloadHtml));

        public PublisherDownloadHtml(RabbitMQServer rabbitmqServer, string exchangeName, string routingKey,
            string queueName) : base(rabbitmqServer, exchangeName, routingKey, queueName)
        {
            while (true)
            {
                try
                {
                    GetChannel().QueueDeclare(ConsumerDownlaodHtml.WSS_DOWNLOADHTML, true, false, false, null);
                    break;
                }
                catch (Exception ex)
                {
                    _log.Info(ex);
                    Thread.Sleep(1000);
                }
            }
            
        }

        public override bool Init()
        {
            return true;
        }

        protected override void MessageReturn(object sender, BasicReturnEventArgs args)
        {
            
        }
    }
}