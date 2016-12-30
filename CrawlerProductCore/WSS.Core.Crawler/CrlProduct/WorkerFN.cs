﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Core.Crawler.CrlProduct
{
    public class WorkerMqFn : QueueingConsumer
    {
        private readonly ILog _log = LogManager.GetLogger(typeof (WorkerMqFn));
        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            DateTime dtFrom = DateTime.Now;

            string mss = Encoding.UTF8.GetString(message.Body);
            _log.Info(string.Format("Get mss : {0}", mss));
            JobCompanyCrawler jobCompanyCrawler = JobCompanyCrawler.ParseFromJson(mss);
            if (jobCompanyCrawler != null)
            {
                WorkerFindNew fn = new WorkerFindNew(jobCompanyCrawler.CompanyId, "");
                fn.StartCrawler();
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);

            int minuteRun = (int)(DateTime.Now - dtFrom).TotalMinutes;
            _log.Info(string.Format("Processed {0} in {1}", mss, minuteRun));
        
        }

        public override void Init()
        {
           
        }

        public WorkerMqFn(RabbitMQServer rabbitmqServer, string queueName) : base(rabbitmqServer, queueName, false)
        {
        }
    }
}
