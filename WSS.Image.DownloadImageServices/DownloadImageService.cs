using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using QT.Entities;
using QT.Entities.Images;
using QT.Moduls;

namespace WSS.Image.DownloadImageServices
{
    public partial class DownloadImageService : ServiceBase
    {
        private Worker[] _workers;
        private static readonly ILog Log = LogManager.GetLogger(typeof(DownloadImageService));
        private string _pathImageProduct = "D:\\Image\\";
        private string _pathImageRootProduct = "D:\\Image\\images\\";
        private bool _isRunning = true;
        RabbitMQServer _rabbitMqServer;
        private int _workerCount;
        private JobClient _checkErrorJobClient;
        private List<WidthHeightImage> widthHeightImages; 
        public DownloadImageService()
        {
            InitializeComponent();
            LoadAppConfig();
            //OnStart(new string[] { });
        }

        private void LoadAppConfig()
        {
            _pathImageProduct = ConfigurationSettings.AppSettings["FolderImageProdut"];
            _pathImageRootProduct = ConfigurationSettings.AppSettings["FolderImageRootProduct"];
            _workerCount = Common.Obj2Int(ConfigurationSettings.AppSettings["workerCount"]);
            widthHeightImages = new List<WidthHeightImage>();
            var widthHeightImagesConfig = ConfigurationSettings.AppSettings["WithHeightImagesConfig"];
            var arrWidthHeightImages = widthHeightImagesConfig.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in arrWidthHeightImages)
            {
                var wh = item.Split('x');
                var whImage = new WidthHeightImage() {Width = Common.Obj2Int(wh[0]), Height = Common.Obj2Int(wh[1])};
                widthHeightImages.Add(whImage);
            }
        }
        protected sealed override void OnStart(string[] args)
        {
            try
            {
                _workers = new Worker[_workerCount + 1];
                _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
                _checkErrorJobClient = new JobClient(ConfigImages.ExchangeImages, GroupType.Topic, ConfigImages.RoutingKeyCheckErrorDownload, true, _rabbitMqServer);
                for (var i = 0; i < _workerCount; i++)
                {
                    var worker = new Worker(ConfigImages.QueueChangeImageProduct, false, _rabbitMqServer);
                    _workers[i] = worker;
                    var workerTask = new Task(() =>
                    {
                        //JobClient send message to service thumbimage (viết kiểu ProducerBasic để gửi cho a quang)
                        var thumbImageJobClient = new ProducerBasic(_rabbitMqServer,ConfigImages.ExchangeImages,ConfigImages.RoutingKeyThumbImage);
                        //Jobclient send message to service update imagepath to sql
                        var updateImagePathProductJobClient = new JobClient(ConfigImages.ExchangeImages, GroupType.Topic,
                            ConfigImages.RoutingKeyUpdateImagePath, true, _rabbitMqServer);
                        worker.JobHandler = (downloadImageJob) =>
                        {
                            try
                            {
                                DownloadImageProduct(ImageProductInfo.GetDataFromMessage(downloadImageJob.Data), updateImagePathProductJobClient, thumbImageJobClient);
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
                #region Tách 1 consumer ra để download ảnh sp gốc
                var workerSpGoc = new Worker(ConfigImages.QueueChangeImageRootProduct, false, _rabbitMqServer);
                _workers[_workerCount] = workerSpGoc;
                var workerSpGocTask = new Task(() =>
                {
                    //JobClient send message to service thumbimage (viết kiểu ProducerBasic để gửi cho a quang)
                    var thumbImageJobClient = new ProducerBasic(_rabbitMqServer, ConfigImages.ExchangeImages, ConfigImages.RoutingKeyThumbImage);
                    //Jobclient send message to service update imagepath to sql
                    var updateImagePathProductJobClient = new JobClient(ConfigImages.ExchangeImages, GroupType.Topic, ConfigImages.RoutingKeyUpdateImagePath, true, _rabbitMqServer);
                    workerSpGoc.JobHandler = (downloadImageJob) =>
                    {
                        try
                        {
                            DownloadImageRootProduct(ImageProductInfo.GetDataFromMessage(downloadImageJob.Data), updateImagePathProductJobClient, thumbImageJobClient);
                        }
                        catch (Exception exception)
                        {
                            Log.Error("Execute Job Error.", exception);
                        }
                        return true;
                    };
                    workerSpGoc.Start();
                });
                workerSpGocTask.Start();
                Log.InfoFormat("Worker(SpGoc) {0} started", _workerCount);
                #endregion
            }
            catch (Exception exception)
            {
                Log.Error("Start error", exception);
                throw;
            }
        }

        private void DownloadImageProduct(ImageProductInfo imageProductInfo, JobClient updateImagePathProductJobClient, ProducerBasic thumbImageJobClient)
        {
            var fileName = Common.UnicodeToKoDauAndGach(imageProductInfo.Name);
            if (fileName.Length > 100) fileName = fileName.Substring(0, 99);
            fileName += "_" + imageProductInfo.Id + ".jpg";
            try
            {
                var folder = Common.GetFolderSaveImageProduct(fileName, imageProductInfo.DetailUrl);
                Common.SaveImageProduct(imageProductInfo.ImageUrls, _pathImageProduct + folder, fileName);
                imageProductInfo.ImagePath = Common.GetImagePathProduct(folder, fileName);
                imageProductInfo.DownloadedTime = DateTime.Now;
                SendMessageToServiceUpdateImagePath(imageProductInfo, updateImagePathProductJobClient);
                var fulldirectory =_pathImageProduct.Replace("\\",@"\")+folder.Replace("\\",@"\")+@"\"+fileName;
                var thumbImageInfo = new ThumbImageProductInfo()
                {
                    ProductId = imageProductInfo.Id,
                    FileNameImage = fileName,
                    FolderImage = folder.Replace("\\",@"\"),
                    FullDirectoryImage = fulldirectory,
                    SizeImage = widthHeightImages,
                    TypeProduct = 1
                };
                SendMessageToServiceThumbImage(thumbImageInfo, thumbImageJobClient);
                Log.Info(string.Format("Product: ID = {0} download image success!", imageProductInfo.Id));
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Product: ID = {0}. ImageUrl: {1} . DetailUrl: {2}", imageProductInfo.Id, imageProductInfo.ImageUrls, imageProductInfo.DetailUrl), exception);
                imageProductInfo.ErrorMessage = exception.ToString();
                SendErrorDownloadImageToService(imageProductInfo);
            }
        }
        private void DownloadImageRootProduct(ImageProductInfo imageProductInfo, JobClient updateImagePathProductJobClient, ProducerBasic thumbImageJobClient)
        {
            var fileName = Common.UnicodeToKoDauAndGach(imageProductInfo.Name);
            if (fileName.Length > 100)
                fileName = fileName.Substring(0, 99);
            fileName += ".jpg";
            try
            {
                var folder = Common.GetFolderSaveImageRootProduct(fileName);
                Common.SaveImageProduct(imageProductInfo.ImageUrls, _pathImageRootProduct + folder, fileName);
                imageProductInfo.ImagePath = Common.GetImagePathRootProduct(folder, fileName);
                imageProductInfo.DownloadedTime = DateTime.Now;
                SendMessageToServiceUpdateImagePath(imageProductInfo, updateImagePathProductJobClient);
                var fulldirectory = _pathImageProduct.Replace("\\", @"\") + folder.Replace("\\", @"\") + fileName;
                var thumbImageInfo = new ThumbImageProductInfo()
                {
                    ProductId = imageProductInfo.Id,
                    FileNameImage = fileName,
                    FolderImage = folder.Replace("\\", @"\"),
                    FullDirectoryImage = fulldirectory,
                    SizeImage = widthHeightImages,
                    TypeProduct = 2
                };
                SendMessageToServiceThumbImage(thumbImageInfo, thumbImageJobClient);
                Log.Info(string.Format("RootProduct: ID = {0} download image success!", imageProductInfo.Id));
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("RootProduct: ID = {0}. ImageUrl: {1} . DetailUrl: {2}", imageProductInfo.Id, imageProductInfo.ImageUrls, imageProductInfo.DetailUrl), exception);
                imageProductInfo.ErrorMessage = exception.ToString();
                SendErrorDownloadImageToService(imageProductInfo);
            }
        }

        private void SendMessageToServiceUpdateImagePath(ImageProductInfo imageProductInfo, JobClient updateImagePathProductJobClient)
        {
            var job = new Job { Data = ImageProductInfo.GetMessage(imageProductInfo) };
            while (_isRunning)
            {
                try
                {
                    updateImagePathProductJobClient.PublishJob(job);
                    //Log.Info(string.Format("Push message to services update imagepath = {0}", imageProductInfo.Id));
                    break;
                }
                catch (Exception exception)
                {
                    Thread.Sleep(60000);
                    Log.Error(
                        string.Format("Product: ID = {0} Send message to service update imagepath error.",
                            imageProductInfo.Id), exception);
                }
            }
        }
        private void SendMessageToServiceThumbImage(ThumbImageProductInfo thumbImageInfo, ProducerBasic thumbImageJobClient)
        {
            while (_isRunning)
            {
                try
                {
                    thumbImageJobClient.Publish(ThumbImageProductInfo.GetMessage(thumbImageInfo));
                    //Log.Info(string.Format("Push message to services thumb image = {0}", thumbImageInfo.ProductId));
                    break;
                }
                catch (Exception exception)
                {
                    Log.Error(string.Format("Push message to services thumb image = {0} error.", thumbImageInfo.ProductId), exception);
                    Thread.Sleep(60000);
                }
            }
        }
        private readonly object _keyLock = new object();
        public void SendErrorDownloadImageToService(ImageProductInfo imageProductInfo)
        {
            lock (_keyLock){
                var job = new Job { Data = ImageProductInfo.GetMessage(imageProductInfo) };
                while (_isRunning){
                    try
                    {
                        _checkErrorJobClient.PublishJob(job);
                        //Log.Info(string.Format("Push message to services checkerror = {0}", imageProductInfo.Id));
                        break;
                    }
                    catch (Exception exception)
                    {
                        Thread.Sleep(60000);
                        Log.Error(
                            string.Format("Product: ID = {0} Send message to service check error download image.",
                                imageProductInfo.Id), exception);
                    }
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
