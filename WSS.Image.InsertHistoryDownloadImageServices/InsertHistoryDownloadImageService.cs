using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Entities.Images;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using WSS.Image.InsertHistoryDownloadImageServices.DBHistoryTableAdapters;

namespace WSS.Image.InsertHistoryDownloadImageServices
{
    public partial class InsertHistoryDownloadImageService : ServiceBase
    {
        private Worker[] _workers;
        private static readonly ILog Log = LogManager.GetLogger(typeof(InsertHistoryDownloadImageService));
        private bool _isRunning = true;
        RabbitMQServer _rabbitMqServer;
        private int _workerCount;
        private string _connectionString = "";
        public InsertHistoryDownloadImageService()
        {
            InitializeComponent();
            LoadAppConfig();
            //OnStart(new string[] {});
        }

        private void LoadAppConfig()
        {
            _connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
            _workerCount = Common.Obj2Int(ConfigurationSettings.AppSettings["workerCount"]);
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                _workers = new Worker[_workerCount + 1];
                _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
                for (var i = 0; i < _workerCount; i++)
                {
                    var worker = new Worker(ConfigImages.QueueHistoryDownloadImage, false, _rabbitMqServer);
                    _workers[i] = worker;
                    var historyAdapter = new History_DownloadImageProductTableAdapter();
                    historyAdapter.Connection.ConnectionString = _connectionString;
                    var workerTask = new Task(() =>
                    {
                        worker.JobHandler = (downloadImageJob) =>
                        {
                            try
                            {
                                InsertHistoryDownloadImage(
                                    LogHistoryImageProduct.GetDataFromMessage(downloadImageJob.Data), historyAdapter);
                            }
                            catch (Exception exception)
                            {
                                Log.Error("Execute Job Error.", exception);
                            }
                            return true;
                        };
                        worker.Start();
                    });
                    workerTask.Start();
                    Log.InfoFormat("Worker {0} started", i);
                }
            }
            catch (Exception exception)
            {
                Log.Error("Start error", exception);
                throw;
            }
        }

        private void InsertHistoryDownloadImage(LogHistoryImageProduct logHistoryImageProduct,History_DownloadImageProductTableAdapter historyAdapter )
        {
            while (_isRunning)
            {
                try
                {
                    if (historyAdapter.Connection.State == ConnectionState.Closed) historyAdapter.Connection.Open();
                    if (logHistoryImageProduct.ErrorName.Length > 4000)
                    {
                        logHistoryImageProduct.ErrorName = logHistoryImageProduct.ErrorName.Substring(0, 3999);
                    }
                    historyAdapter.Insert(logHistoryImageProduct.ProductId, logHistoryImageProduct.DateLog,
                        logHistoryImageProduct.IsDownloaded, logHistoryImageProduct.ErrorName,
                        logHistoryImageProduct.NewsToValid);
                    Log.Info(string.Format("ProductId {0} : Insert history success.", logHistoryImageProduct.ProductId));
                    break;
                }
                catch (Exception exception)
                {
                    Log.Error(string.Format("ProductId {0} : Insert history error.", logHistoryImageProduct.ProductId), exception);
                    Thread.Sleep(60000);
                }
            }
        }

        protected override void OnStop()
        {
            foreach (var worker in _workers)
                worker.Stop();
            _rabbitMqServer.Stop();
            _isRunning = false;
        }
    }
}
