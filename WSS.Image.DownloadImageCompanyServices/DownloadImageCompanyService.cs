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

namespace WSS.Image.DownloadImageCompanyServices
{
    public partial class DownloadImageCompanyService : ServiceBase
    {
        private Worker[] _workers;
        private static readonly ILog Log = LogManager.GetLogger(typeof(DownloadImageCompanyService));
        private string _pathImageProduct = "D:\\Image\\";
        private string _pathImageRootProduct = "D:\\Image\\images\\";
        private bool _checkStop;
        RabbitMQServer _rabbitMqServer;
        private int _workerCount;
        private JobClient _checkErrorJobClient;
        private JobClient _sendHistoryDownloadClient;
        public DownloadImageCompanyService()
        {
            InitializeComponent();
            LoadAppConfig();
            //OnStart(new string[] {});
        }
        private void LoadAppConfig()
        {
            _pathImageProduct = ConfigurationSettings.AppSettings["FolderImageProdut"];
            _pathImageRootProduct = ConfigurationSettings.AppSettings["FolderImageRootProduct"];
            _workerCount = Common.Obj2Int(ConfigurationSettings.AppSettings["workerCount"]);
        }
        protected override void OnStart(string[] args)
        {
            try
            {
                _workers = new Worker[_workerCount + 1];
                _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);

                _sendHistoryDownloadClient = new JobClient(ConfigImages.ExchangeImages, GroupType.Topic, ConfigImages.RoutingKeyHistoryImage, true, _rabbitMqServer);
                for (var i = 0; i < _workerCount; i++)
                {
                    var worker = new Worker(ConfigImages.QueueChangeImageCompany, false, _rabbitMqServer);
                    _workers[i] = worker;
                    var workerTask = new Task(() =>
                    {
                        //Jobclient send message to service update imagepath to sql
                        var updateImagePathProductJobClient = new JobClient(ConfigImages.ExchangeImages, GroupType.Topic, ConfigImages.RoutingKeyUpdateImagePath, true, _rabbitMqServer);
                        //Jobclient send message to service log history download Image Company
                        _checkErrorJobClient = new JobClient(ConfigImages.ExchangeImages, GroupType.Topic, ConfigImages.RoutingKeyCheckErrorDownload, true, _rabbitMqServer);
                        long idCompany;
                        worker.JobHandler = (downloadImageJob) =>
                        {
                            try
                            {
                                idCompany = BitConverter.ToInt64(downloadImageJob.Data, 0);
                                if (idCompany == 6619858476258121218)
                                    DownloadImageRootCompany(idCompany, updateImagePathProductJobClient, _checkErrorJobClient);
                                else
                                    DownloadImageNormalCompany(idCompany, updateImagePathProductJobClient, _checkErrorJobClient);
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

        private void DownloadImageNormalCompany(long idCompany, JobClient updateImagePathProductJobClient, JobClient checkErrorJobClient)
        {
            var startDownload = DateTime.Now;
            var countSuccess = 0;
            var countFail = 0;
            var listIdFail = string.Empty;
            var listProduct = GetProductOfNormalCompany(idCompany);
            foreach (var item in listProduct)
            {
                if (DownloadImageProduct(item, updateImagePathProductJobClient, checkErrorJobClient))
                    countSuccess++;
                else
                {
                    countFail++;
                    listIdFail += item.ID + ",";
                }
            }
            SendHistoryDownloadImageToService(new LogHistoryImageCompany()
            {
                CompanyId = idCompany,
                StartedTime = startDownload,
                NumberDownload = listProduct.Count,
                Success = countSuccess,
                Fail = countFail,
                FinishedTime = DateTime.Now,
                MoreInformation = listIdFail
            });
        }
        private void DownloadImageRootCompany(long idCompany, JobClient updateImagePathProductJobClient, JobClient checkErrorJobClient)
        {
            var startDownload = DateTime.Now;
            var countSuccess = 0;
            var countFail = 0;
            var listIdFail = string.Empty;
            var listProduct = GetProductOfRootCompany(idCompany);
            foreach (var item in listProduct)
            {
                if (DownloadImageRootProduct(item, updateImagePathProductJobClient, checkErrorJobClient))
                    countSuccess++;
                else
                {
                    countFail++;
                    listIdFail += item.ID + ",";
                }
            }
            SendHistoryDownloadImageToService(new LogHistoryImageCompany()
            {
                CompanyId = idCompany,
                StartedTime = startDownload,
                NumberDownload = listProduct.Count,
                Success = countSuccess,
                Fail = countFail,
                FinishedTime = DateTime.Now,
                MoreInformation = listIdFail
            });
        }
        private bool DownloadImageProduct(Product productInfo, JobClient updateImagePathProductJobClient, JobClient checkErrorJobClient)
        {
            var result = false;
            var fileName = productInfo.Name;
            if (fileName.Length > 100) fileName = fileName.Substring(0, 99);
            fileName += "_" + productInfo.ID;
            try
            {
                var folder = Common.GetFolderSaveImageProduct(fileName, productInfo.DetailUrl);
                Common.SaveImageProduct(productInfo.ImageUrls, _pathImageProduct + folder, fileName + ".jpg");
                var job = new Job
                {
                    Data = ImageProductInfo.GetMessage(new ImageProductInfo()
                    {
                        Id = productInfo.ID,
                        ImagePath = Common.GetImagePath(folder, fileName)
                    })
                };
                updateImagePathProductJobClient.PublishJob(job);
                result = true;
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Product: ID = {0}. ImageUrl: {1} . DetailUrl: {2}", productInfo.ID, productInfo.ImageUrls, productInfo.DetailUrl), exception);
                SendErrorDownloadImageToService(
                    new ImageProductInfo()
                    {
                        Id = productInfo.ID,
                        DetailUrl = productInfo.DetailUrl,
                        ImageUrls = productInfo.ImageUrls,
                        Name = productInfo.Name,
                        ErrorMessage = exception.ToString(),
                        Type = 2
                    }, checkErrorJobClient);
            }
            return result;
        }
        private bool DownloadImageRootProduct(Product productInfo, JobClient updateImagePathProductJobClient, JobClient checkErrorJobClient)
        {
            var result = false;
            var fileName = Common.UnicodeToKoDauAndGach(productInfo.Name);
            if (fileName.Length > 100)
                fileName = fileName.Substring(0, 99);
            try
            {
                var folder = Common.GetFolderSaveImageRootProduct(fileName);
                Common.SaveImageProduct(productInfo.ImageUrls, _pathImageRootProduct + folder, fileName + ".jpg");
                var job = new Job
                {
                    Data = ImageProductInfo.GetMessage(new ImageProductInfo()
                    {
                        Id = productInfo.ID,
                        ImagePath = Common.GetImagePath(folder, fileName)
                    })
                };
                updateImagePathProductJobClient.PublishJob(job);
                result = true;
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Product: ID = {0}. ImageUrl: {1} . DetailUrl: {2}", productInfo.ID, productInfo.ImageUrls, productInfo.DetailUrl), exception);
                SendErrorDownloadImageToService(
                    new ImageProductInfo()
                    {
                        Id = productInfo.ID,
                        DetailUrl = productInfo.DetailUrl,
                        ImageUrls = productInfo.ImageUrls,
                        Name = productInfo.Name,
                        ErrorMessage = exception.ToString(),
                        Type = 3
                    }, checkErrorJobClient);
            }
            return result;
        }
        private List<Product> GetProductOfNormalCompany(long idCompany)
        {
            var dBEntities = new WebsosanhEntities();
            var listProduct = new List<Product>();
            while (!_checkStop)
            {
                try
                {
                    listProduct = (from s in dBEntities.Products
                                   where (s.Company == idCompany && s.Valid == true && string.IsNullOrEmpty(s.ImagePath))
                                   select new Product
                                   {
                                       ID = s.ID,
                                       Name = s.Name,
                                       DetailUrl = s.DetailUrl,
                                       ImageUrls = s.ImageUrls
                                   }).ToList();
                }
                catch (Exception exception)
                {
                    Thread.Sleep(600000);
                    Log.Error(string.Format("Get product of Company {0} error.", idCompany), exception);
                }
            }
            return listProduct;
        }
        private List<Product> GetProductOfRootCompany(long idCompany)
        {
            var dBEntities = new WebsosanhEntities();
            var listProduct = new List<Product>();
            while (!_checkStop)
            {
                try
                {
                    listProduct = (from s in dBEntities.Products
                                   where (s.Company == idCompany && s.Valid == true && string.IsNullOrEmpty(s.ImagePath))
                                       || (s.Company == idCompany && s.Valid == false && s.Status == 11)
                                   select new Product
                                   {
                                       ID = s.ID,
                                       Name = s.Name,
                                       DetailUrl = s.DetailUrl,
                                       ImageUrls = s.ImageUrls
                                   }).ToList();
                }
                catch (Exception exception)
                {
                    Thread.Sleep(600000);
                    Log.Error(string.Format("Get product of Company {0} error.", idCompany), exception);
                }
            }
            return listProduct;
        }
        public void SendErrorDownloadImageToService(ImageProductInfo imageProductInfo, JobClient errorJobClient)
        {
            var job = new Job { Data = ImageProductInfo.GetMessage(imageProductInfo) };
            while (!_checkStop)
            {
                try
                {
                    errorJobClient.PublishJob(job);
                    break;
                }
                catch (Exception ex)
                {
                    Thread.Sleep(30000);
                    Log.Error(string.Format("ProductId = {0} Send message check error download image fail.",
                            imageProductInfo.Id), ex);
                }
            }
        }
        private readonly object _keyLockHistory = new object();
        public void SendHistoryDownloadImageToService(LogHistoryImageCompany logHistory)
        {
            lock (_keyLockHistory)
            {
                var job = new Job { Data = LogHistoryImageCompany.GetMessage(logHistory) };
                while (!_checkStop)
                {
                    try
                    {
                        _sendHistoryDownloadClient.PublishJob(job);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Thread.Sleep(30000);
                        Log.Error(string.Format("CompanyId = {0} Send message history download image fail.",
                              logHistory.CompanyId), ex);
                    }
                }
            }
        }
        protected override void OnStop()
        {
            foreach (var worker in _workers)
                worker.Stop();
            _rabbitMqServer.Stop();
            _checkStop = true;
        }
    }
}
