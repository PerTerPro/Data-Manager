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

namespace WSS.Service.CR.EndSession.ToSql
{
    public partial class ServiceEndSessionToSql : ServiceBase
    {
        private ILog _log = LogManager.GetLogger(typeof(ServiceEndSessionToSql));
        private ConsumerSaveEndSession consumer;
        public ServiceEndSessionToSql()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                consumer = new ConsumerSaveEndSession(ConfigCrawler.QueueEndSessionToSql);
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
