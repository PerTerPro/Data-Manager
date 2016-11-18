using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Crawler.Product.Report
{
    public class ConsumerSessionRunning:QueueingConsumer
    {
        private SessionRunningTrack tracks = null;
        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            ReportSessionRunning report = ReportSessionRunning.GetFromJson(message.Body);
            tracks.AddItem(report);
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }

        public override void Init()
        {
           
        }

        public ConsumerSessionRunning(RabbitMQServer rabbitmqServer, string queueName, bool autoAck) 
            : base(rabbitmqServer, queueName, autoAck)
        {
           tracks=new SessionRunningTrack();
        }

        internal SessionRunningTrack GetSessionRunning()
        {
            return tracks;
            
        }
    }
}
