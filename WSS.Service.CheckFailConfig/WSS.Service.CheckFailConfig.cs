using log4net;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace WSS.Service.CheckFailConfig
{
    public partial class ServiceCheckFailConfig : ServiceBase
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ServiceCheckFailConfig));
        CancellationTokenSource cancelTokenSource = new CancellationTokenSource();

        public ServiceCheckFailConfig()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            var token = cancelTokenSource.Token;
            Task.Factory.StartNew(() =>
                {
                    try
                    {
                        Runner runner = new Runner();
                        runner.Start(token);
                    }
                    catch (Exception ex01)
                    {
                        log.Error(ex01);
                    }
                }, token);
        }

        protected override void OnStop()
        {
            if (this.cancelTokenSource != null
                && !this.cancelTokenSource.IsCancellationRequested)
            {
                this.cancelTokenSource.Cancel();
                log.Info("Cancellation all thread");
            }
        }
    }
}
