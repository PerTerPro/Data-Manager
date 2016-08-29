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
using WSS.Image.UpdateImagePathServices.DBProductTableAdapters;

namespace WSS.Image.UpdateImagePathServices
{
    public partial class UpdateImagePathService : ServiceBase
    {
        private Worker[] _workers;
        private static readonly ILog Log = LogManager.GetLogger(typeof(UpdateImagePathService));
        private string _connectionString = "";
        private bool _isRunning = true;
        RabbitMQServer _rabbitMqServer;
        private int _workerCount;
        private JobClient _updateSolrAndRedisJobClient;
        public UpdateImagePathService()
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
                _workers = new Worker[_workerCount];
                _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
                //JobClient send message to service update redis (a hoàng)
                _updateSolrAndRedisJobClient = new JobClient(ConfigRabbitMqCacheSolrAndRedis.ExchangeProduct, GroupType.Topic, ConfigRabbitMqCacheSolrAndRedis.RoutingKeyUpdateSolrAndRedis,
                    true, _rabbitMqServer);
                for (var i = 0; i < _workerCount; i++)
                {
                    var worker = new Worker(ConfigImages.QueueUpdateImagePath, false, _rabbitMqServer);
                    _workers[i] = worker;
                    
                    var workerTask = new Task(() =>
                    {
                        //JobClient send message to service update redis (a hoàng)
                        var updateRedisJobClient = new JobClient(ConfigRabbitMqCacheSolrAndRedis.ExchangeProductRedis, GroupType.Direct, ConfigRabbitMqCacheSolrAndRedis.RoutingKeyUpdateRedis,
                            true, _rabbitMqServer);
                        //Jobclient send message to service insert log download image
                        var historyJobClient = new JobClient(ConfigImages.ExchangeImages, GroupType.Topic, ConfigImages.RoutingKeyHistoryDownloadImage, true, _rabbitMqServer);
                        worker.JobHandler = (downloadImageJob) =>
                        {
                            try
                            {
                                var productAdapter = new DBProductTableAdapters.ProductTableAdapter();
                                productAdapter.Connection.ConnectionString = _connectionString;
                                UpdateImagePathProduct(ImageProductInfo.GetDataFromMessage(downloadImageJob.Data),productAdapter, historyJobClient, updateRedisJobClient);
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

        private void UpdateImagePathProduct(ImageProductInfo imageProductInfo,ProductTableAdapter productAdapter , JobClient historyJobClient, JobClient updateRedisJobClient)
        {
            
            while (_isRunning)
            {
                try
                {
                    if (productAdapter.Connection.State == ConnectionState.Closed) productAdapter.Connection.Open();
                    productAdapter.UpdateImagePathAndValidAndIsNews(imageProductInfo.ImagePath, imageProductInfo.Id);
                    Log.Info(string.Format("ProductId {0} : Update ImagePath And Valid success.", imageProductInfo.Id));
                    break;
                }
                catch (Exception exception)
                {
                    Log.Error(string.Format("ProductId {0} : Update ImagePath And Valid error.", imageProductInfo.Id), exception);
                    Thread.Sleep(60000);
                }
            }
            SendMessageToServiceInsertHistoryDownload(new LogHistoryImageProduct
            {
                DateLog = imageProductInfo.DownloadedTime,
                IsDownloaded = true,
                ErrorName = string.Empty,
                ProductId = imageProductInfo.Id,
                NewsToValid = imageProductInfo.IsNew
            }, historyJobClient);
            if (imageProductInfo.IsNew) SendMessageToServiceUpdateSolrAndRedis(imageProductInfo.Id);
            else SendMessageToServiceUpdateRedis(imageProductInfo.Id, updateRedisJobClient);
        }

        private void SendMessageToServiceUpdateRedis(long idProduct, JobClient updateRedisJobClient)
        {
            var job = new Job {Data = BitConverter.GetBytes(idProduct), Type = 2};
            while (_isRunning)
            {
                try
                {
                    updateRedisJobClient.PublishJob(job);
                    Log.Info(string.Format("Push message to services update redis: productid = {0}",idProduct));
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("ProductId = {0} Push message to services update redis: error.", idProduct), ex);
                    Thread.Sleep(60000);
                }
            }
        }
        private readonly object _keyLock = new object();
        public void SendMessageToServiceUpdateSolrAndRedis(long idProduct)
        {
            lock (_keyLock)
            {
                var job = new Job { Data = BitConverter.GetBytes(idProduct), Type = 2 };
                while (_isRunning)
                {
                    try
                    {
                        _updateSolrAndRedisJobClient.PublishJob(job);
                        Log.Info(string.Format("Push message to services update solr and redis = {0}", idProduct));
                        break;
                    }
                    catch (Exception exception)
                    {
                        Thread.Sleep(60000);
                        Log.Error(
                            string.Format("Product: ID = {0} Send message to service update solr and redis.",
                                idProduct), exception);
                    }
                }
            }
        }
        private void SendMessageToServiceInsertHistoryDownload(LogHistoryImageProduct historyImageProduct, JobClient historyJobClient)
        {
            var job = new Job
            {
                Data = LogHistoryImageProduct.GetMessage(historyImageProduct)
            };
            while (_isRunning)
            {
                try
                {
                    historyJobClient.PublishJob(job);
                    Log.Info(string.Format("Push message to services insert history download image productid = {0}",
                        historyImageProduct.ProductId));
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("ProductId = {0} Push message to services insert history download image error.", historyImageProduct.ProductId), ex);
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
