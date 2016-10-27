using System;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using WSS.Service.ResetColumnChangeAndDuplicate;

namespace WSS.Service.ResetCacheAllProduct
{
    public partial class ServiceResetColumnChangeAndDuplicate : ServiceBase
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ServiceResetColumnChangeAndDuplicate));
        readonly CancellationTokenSource _cancelTokenSource = new CancellationTokenSource();

        public ServiceResetColumnChangeAndDuplicate()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var token = _cancelTokenSource.Token;
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
            if (this._cancelTokenSource != null
                && !this._cancelTokenSource.IsCancellationRequested)
            {
                this._cancelTokenSource.Cancel();
                log.Info("Cancellation all thread");
            }
        }
    }
}
