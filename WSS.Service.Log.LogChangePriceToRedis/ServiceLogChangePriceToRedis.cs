using System;
using System.Configuration;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Moduls.CrawlerProduct.Service;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Service.Log.LogChangePriceToRedis
{
    public partial class ServiceLogChangePriceToRedis : ServiceBase
    {
        readonly ILog _log = LogManager.GetLogger(typeof(ServiceLogChangePriceToRedis));
        CancellationTokenSource _cancelTokenSource;
        WorkerChangePriceToHistoryPrice[] _workers;

        public ServiceLogChangePriceToRedis()
        {
            InitializeComponent();
           
        }

        protected override void OnStart(string[] args)
        {
            InitializeComponent();

            try
            {
                _log.Info("Start service");

                var workerCount = Common.Obj2Int(ConfigurationManager.AppSettings["WorkCount"], 1);
                var queue = ConfigurationManager.AppSettings["QueueRun"];
                var rabbitMqServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");

                _cancelTokenSource = new CancellationTokenSource();
                _workers = new WorkerChangePriceToHistoryPrice[workerCount];

                for (var i = 0; i < workerCount; i++)
                {
                    var j = i;
                    Task.Factory.StartNew(() =>
                    {
                        _log.InfoFormat("Start worker {0} queue: {1}", j, queue);
                        var worker = new WorkerChangePriceToHistoryPrice(queue, false, rabbitMqServer,
                            _cancelTokenSource.Token);
                        _workers[j] = worker;
                        worker.Start();
                    });
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }

        protected override void OnStop()
        {
            if (_cancelTokenSource == null || _cancelTokenSource.IsCancellationRequested) return;
            _log.Info("Cancellation all thread");
            _cancelTokenSource.Cancel();
        }
    }
}
