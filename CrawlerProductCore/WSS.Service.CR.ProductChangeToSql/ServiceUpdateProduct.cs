using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler;

namespace WSS.Service.CR.ProductChangeToSql
{
    partial class ServiceProductChangeToSql : ServiceBase
    {
        ConsumerProductChangeToSql consumer = null;
        private ILog _log = LogManager.GetLogger(typeof(ServiceProductChangeToSql));

        public ServiceProductChangeToSql()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                consumer = new ConsumerProductChangeToSql(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.QueueProductChangeToSql);
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
