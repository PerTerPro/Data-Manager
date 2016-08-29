using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.Service.AutoFindWebsiteFromGoogle
{
    public partial class AutoFindWebsiteFromGoogle : ServiceBase
    {
        CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(AutoFindWebsiteFromGoogle));
        Runner runner = new Runner();
        public AutoFindWebsiteFromGoogle()
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
