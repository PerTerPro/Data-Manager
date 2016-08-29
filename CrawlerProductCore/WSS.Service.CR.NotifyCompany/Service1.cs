﻿using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler;

namespace WSS.Service.CR.NotifyCompany
{
    public partial class Service1 : ServiceBase
    {
        private ILog _log = LogManager.GetLogger(typeof(Service1));
        ConsumerPushNotifyCompany consumer = null;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                consumer = new ConsumerPushNotifyCompany(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.QueueWaitCheckNotify);
                consumer.StartConsume();
            });
        }

        protected override void OnStop()
        {
            try
            {
                consumer.Stop();
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }
    }
}
