using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using RabbitMQ.Client;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Core.Crawler.CrlProduct
{
    public class WorkerMqRl : QueueingConsumer
    {
        private ILog _log = LogManager.GetLogger(typeof (WorkerMqRl));
        private bool bAckIm = true;

        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            if (bAckIm)
            {
                this.GetChannel().BasicAck(message.DeliveryTag, true);
            }
            string mss = Encoding.UTF8.GetString(message.Body);
            _log.Info(string.Format("Get mss : {0}", mss));
            JobCompanyCrawler jobCompanyCrawler = JobCompanyCrawler.ParseFromJson(mss);
            if (jobCompanyCrawler != null)
            {
                var fn = new WorkerReload(jobCompanyCrawler.CompanyId, "");
                fn.StartCrawler();
            }
            if (!bAckIm)
            {
                this.GetChannel().BasicAck(message.DeliveryTag, true);
            }
        }

        public override void Init()
        {
           
        }

        public WorkerMqRl(RabbitMQServer rabbitmqServer, string queueName,bool bAckIm =false)
            : base(rabbitmqServer, queueName, false)
        {
            this.bAckIm = bAckIm;
        }
    }
}
