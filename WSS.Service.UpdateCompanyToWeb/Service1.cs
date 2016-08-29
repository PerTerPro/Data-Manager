using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;
using WSS.Core.Crawler;
using log4net;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Service.UpdateCompanyToWeb
{
    public partial class Service1 : ServiceBase
    {
        private ILog _log = LogManager.GetLogger(typeof (Service1));
        private ConsumerUpdateCompanyToWeb consumer = null;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _log.Info("Start service");
            Task.Factory.StartNew(() =>
            {
                consumer = new ConsumerUpdateCompanyToWeb(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct), ConfigRun.QueueUpdateCompanyInfoToWeb);
                consumer.StartConsume();
            });
        }

        protected override void OnStop()
        {
            _log.Info("Stop service");
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
