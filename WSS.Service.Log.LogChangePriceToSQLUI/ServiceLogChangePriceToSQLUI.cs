using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
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
using QT.Moduls.CrawlerProduct.Service;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;


namespace WSS.Service.Log.LogChangePriceToSQLUI
{
    public partial class ServiceLogChangePriceToSqlui : ServiceBase
    {
        readonly ILog _log = log4net.LogManager.GetLogger(typeof(ServiceLogChangePriceToSqlui));
        CancellationTokenSource _cancelTokenSource = null;
        WorkerChangePriceToHistoryPriceSqlUi[] _workers = null;

        public ServiceLogChangePriceToSqlui()
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
                var rabbitMqServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
                _cancelTokenSource = new CancellationTokenSource();
                _workers = new WorkerChangePriceToHistoryPriceSqlUi[workerCount];
                for (var i = 0; i < workerCount; i++)
                {
                    var j = i;
                    Task.Factory.StartNew(() =>
                    {
                        _log.InfoFormat("Start worker {0}", j);
                        _workers[j] = new WorkerChangePriceToHistoryPriceSqlUi(_cancelTokenSource.Token);
                        _workers[j].Start();
                    });
                }
            }
            catch (Exception exx)
            {
                _log.Error(exx);
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
