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

namespace WSS.ImageImbo.CheckErrorDownloadService
{
    public partial class CheckErrorDownloadService : ServiceBase
    {
        private Worker[] _workers;
        private static readonly ILog Log = LogManager.GetLogger(typeof(CheckErrorDownloadService));
        private bool _isRunning = true;
        RabbitMQServer _rabbitMqServer;
        private int _workerCount;
        public CheckErrorDownloadService()
        {
            InitializeComponent();
            LoadAppConfig();
            //OnStart(new string[] {});
        }
        private void LoadAppConfig()
        {
            _workerCount = Common.Obj2Int(ConfigurationSettings.AppSettings["workerCount"]);
        }
        protected override void OnStart(string[] args)
        {
            try
            {
                _workers = new Worker[_workerCount];
                _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
                for (var i = 0; i < _workerCount; i++)
                {
                    var worker = new Worker(ConfigImages.ImboQueueCheckErrorDownload, false, _rabbitMqServer);
                    _workers[i] = worker;
                    var workerTask = new Task(() =>
                    {
                        //Jobclient resend message to service download image
                        var downloadImageProductJobClient = new JobClient(ConfigImages.ImboExchangeImages, GroupType.Topic, ConfigImages.ImboRoutingKeyDownloadImageProduct, true, _rabbitMqServer);
                        //Jobclient send message to service insert log download image (check image fail 5 rep -> insert to History_DownloadImageProduct)
                        var historyJobClient = new JobClient(ConfigImages.ImboExchangeImages, GroupType.Topic, ConfigImages.ImboRoutingKeyHistoryDownloadImage, true, _rabbitMqServer);
                        worker.JobHandler = (downloadImageJob) =>
                        {
                            try
                            {
                                CheckErrorDownloadImageProduct(ImageProductInfo.GetDataFromMessage(downloadImageJob.Data), downloadImageProductJobClient, historyJobClient);
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

        private void CheckErrorDownloadImageProduct(ImageProductInfo imageProductInfo, JobClient downloadImageProductJobClient, JobClient historyJobClient)
        {
            //Check số lần download error trên Redis
            var errordownload = RedisErrorDownloadImageProductAdapter.GetErrorDownloadImage(imageProductInfo.Id);
            //errordownload < 5  resend message to service downloadimageproduct
            if (errordownload <= 5)
            {
                errordownload++;
                RedisErrorDownloadImageProductAdapter.SetErrorDownloadImage(imageProductInfo.Id, errordownload);
                ResendToServiceDownloadImageProduct(imageProductInfo, downloadImageProductJobClient);
            }
            else // send to service insert log history download image
                SendMessageToServiceInsertHistoryDownload(imageProductInfo, historyJobClient);
        }

        private void SendMessageToServiceInsertHistoryDownload(ImageProductInfo imageProductInfo, JobClient historyJobClient)
        {
            var job = new Job
            {
                Data = LogHistoryImageProduct.GetMessage(new LogHistoryImageProduct()
                {
                    ProductId = imageProductInfo.Id,
                    DateLog = DateTime.Now,
                    ErrorName = imageProductInfo.ErrorMessage,
                    IsDownloaded = false,
                    NewsToValid = false
                })
            };
            while (_isRunning)
            {
                try
                {
                    historyJobClient.PublishJob(job);
                    Log.Info(string.Format("Push message to services insert history download image productid = {0}",
                        imageProductInfo.Id));
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("ProductId = {0} Push message to services insert history download image.", imageProductInfo.Id), ex);
                    Thread.Sleep(60000);
                }
            }
        }

        private void ResendToServiceDownloadImageProduct(ImageProductInfo imageProductInfo, JobClient downloadImageProductJobClient)
        {
            var job = new Job { Data = ImageProductInfo.GetMessage(imageProductInfo) };
            while (_isRunning)
            {
                try
                {
                    downloadImageProductJobClient.PublishJob(job);
                    Log.Info(string.Format("Resend to services download image productid {0}",imageProductInfo.Id));
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("ProductId = {0} resend message to service downloadimageproduct.", imageProductInfo.Id), ex);
                    Thread.Sleep(120000);
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
