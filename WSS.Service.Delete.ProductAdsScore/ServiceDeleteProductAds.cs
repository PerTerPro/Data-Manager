using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using log4net;
using System.Configuration;
using System.Threading;

namespace WSS.Service.Delete.ProductAdsScore
{

    public partial class ServiceDeleteProductAds : ServiceBase
    {
        private static ILog log = LogManager.GetLogger(typeof(Program));

        CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
        Runner runner = new Runner();

        public ServiceDeleteProductAds()
        {
            InitializeComponent();
            //OnStart(new string[] { });
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
                catch (OperationCanceledException)
                {
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
