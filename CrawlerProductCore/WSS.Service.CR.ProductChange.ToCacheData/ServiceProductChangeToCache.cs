using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler;

namespace WSS.Service.CR.ProductChange.ToCacheData
{
    public partial class ServiceProductChangeToCache : ServiceBase
    {

        private ILog _log = LogManager.GetLogger(typeof (ServiceProductChangeToCache));
        private ConsumerProductChangeToCache consumer = null;

        public ServiceProductChangeToCache()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    consumer = new ConsumerProductChangeToCache();
                    consumer.StartConsume();
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                }
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
