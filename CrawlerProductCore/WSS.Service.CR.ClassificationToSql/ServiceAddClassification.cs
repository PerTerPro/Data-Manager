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
using WSS.Core.Crawler;

namespace WSS.Service.CR.ClassificationToSql
{
    public partial class ServiceAddClassification : ServiceBase
    {
        private ILog _log = LogManager.GetLogger(typeof(ServiceAddClassification));
        private ConsumerAddClassification consumer;
        public ServiceAddClassification()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                consumer = new ConsumerAddClassification(ConfigCrawler.QueueAddClassification);
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
