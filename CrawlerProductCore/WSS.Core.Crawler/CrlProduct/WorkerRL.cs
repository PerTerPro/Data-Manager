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
        private ILog _log = LogManager.GetLogger(typeof(WorkerMqRl));

        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            DateTime dtFrom = DateTime.Now;
            string mss = Encoding.UTF8.GetString(message.Body);
            try
            {
                JobCompanyCrawler jobCompanyCrawler = JobCompanyCrawler.ParseFromJson(mss);
                if (jobCompanyCrawler != null)
                {
                    var fn = new WorkerReload(jobCompanyCrawler.CompanyId, "");
                    fn.StartCrawler();
                }
                
             
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
            int minuteRun = (int)(DateTime.Now - dtFrom).TotalMinutes;
            _log.Info(string.Format("Process {0} in {1}", mss, minuteRun));
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }

        public override void Init()
        {

        }

        public WorkerMqRl(RabbitMQServer rabbitmqServer, string queueName, bool bAckIm = false)
            : base(rabbitmqServer, queueName, false)
        {
       
        }
    }
}
