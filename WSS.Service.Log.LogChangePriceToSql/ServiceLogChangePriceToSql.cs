using System;
using System.Configuration;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct.Service;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.Service.Log.LogChangePriceToSql
{
    public partial class ServiceLogChangePriceToSql : ServiceBase
    {
        ILog _log = LogManager.GetLogger(typeof(ServiceLogChangePriceToSql));
        CancellationTokenSource _cancelTokenSource;
        WorkerChangePriceToSqlHistoryPrice[] _workers;

        public ServiceLogChangePriceToSql()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            try
            {
                _log.Info("Start service");
                var workerCount = 1;                                // Common.Obj2Int(ConfigurationManager.AppSettings["WorkCount"], 1);
                var queue = "UpdatedProduct.ChangePrice.ToSQLLog";  // ConfigurationManager.AppSettings["QueueRun"];
                var rabbitMqServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
                _cancelTokenSource = new CancellationTokenSource();
                _workers = new WorkerChangePriceToSqlHistoryPrice[workerCount];
                for (var i = 0; i < workerCount; i++)
                {
                    var j = i;
                    Task.Factory.StartNew(() =>
                    {
                        _log.InfoFormat("Start worker {0} queue: {1}", j, queue);
                        var worker = new WorkerChangePriceToSqlHistoryPrice(queue, false, rabbitMqServer,
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
            if (_cancelTokenSource != null
                && !_cancelTokenSource.IsCancellationRequested)
            {
                _log.Info("Cancellation all thread");
                _cancelTokenSource.Cancel();
            }
        }
    }
}
