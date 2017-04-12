using log4net;
using QT.Entities;
using QT.Entities.Images;
using QT.Moduls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using WSS.ImageServer;

namespace WSS.Image.Download.All.Rabbit
{
    class Program
    {
        private static Worker[] _workers;
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        private string _connectionString =
            "Data Source = 172.22.1.82; Initial Catalog = QT_2; Persist Security Info=True;User ID = wss_price; Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout = 200";
        private static bool _isRunning = true;
        static RabbitMQServer _rabbitMqServer;
        private static int _workerProduct;
        private static int _workerCompany;
        private static JobClient _checkErrorJobClient;
        //private List<Tuple<int, int>> _widthHeightImages;
        //Imbo
        private static string _publicKeyImbo = "wss";
        private string _privateKeyImbo = "123websosanh@195";
        private string _userNameImbo = "wss";
        private string _hostImbo = "https://172.22.1.226";
        private static int _portImbo = 443;
        public Program()
        {
            _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            //imbo
            _publicKeyImbo = ConfigurationManager.AppSettings["PublicKeyImboImageProduct"];
            _privateKeyImbo = ConfigurationManager.AppSettings["PrivateKeyImboImageProduct"];
            _userNameImbo = ConfigurationManager.AppSettings["UserNameImboImageProduct"];
            _hostImbo = ConfigurationManager.AppSettings["HostImboImageProduct"];

            _portImbo = 443;
            _workerProduct = 6;

            _workerCompany = 4;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Download();
        }

        public void Download()
        {
            _workers = new Worker[_workerProduct + _workerCompany + 1];
            _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
            _checkErrorJobClient = new JobClient(ConfigImages.ImboExchangeImages, GroupType.Topic, ConfigImages.ImboRoutingKeyCheckErrorDownload, true, _rabbitMqServer);
            for (var i = 0; i < _workerProduct; i++)
            {
                var worker = new Worker(ConfigImages.ImboQueueDownloadImageProduct, false, _rabbitMqServer);
                _workers[i] = worker;
                var workerTask = new Task(() =>
                {
                    //JobClient send message to service upload sql & thumb của tráng
                    var producerUpdateImageIdSql = new ProducerBasic(_rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyUploadImageIdSql);
                    //var producerDelImage = new ProducerBasic(_rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyThumbImage);
                    worker.JobHandler = (downloadImageJob) =>
                    {
                        try
                        {
                            DownloadImageProduct(ImageProductInfo.GetDataFromMessage(downloadImageJob.Data), producerUpdateImageIdSql);
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
        private static bool DownloadImageProduct(ImageProductInfo imageProductInfo, ProducerBasic producerUpdateImageIdSql)
        {
            bool result = false;
            try
            {
                var idImbo = Common.DownloadImageProductWithImboServer(imageProductInfo.ImageUrls, ConfigImbo.PublicKey, ConfigImbo.PrivateKey, "wss", ConfigImbo.Host, ConfigImbo.Port);
                if (!string.IsNullOrEmpty(idImbo))
                {
                    UpdateImageIdSqlService(imageProductInfo.Id, idImbo, producerUpdateImageIdSql);
                    //ThumbImageService(imageProductInfo.Id, idImbo, producerThumbImage);
                    Log.Info(string.Format("Product: ID = {0} download image success!", imageProductInfo.Id));
                    //InsertLogDownloadImageProduct(imageProductInfo.Id);
                    result = true;
                }
                else
                {
                    imageProductInfo.ErrorMessage = "IDImbo = null";
                    SendErrorDownloadImageToService(imageProductInfo);
                }
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Product: ID = {0}. ImageUrl: {1} . DetailUrl: {2}", imageProductInfo.Id, imageProductInfo.ImageUrls, imageProductInfo.DetailUrl), exception);
                imageProductInfo.ErrorMessage = exception.ToString();
                SendErrorDownloadImageToService(imageProductInfo);
            }
            return result;
        }
        public static void UpdateImageIdSqlService(long productId, string idImageImbo, ProducerBasic producerUpdateImageIdSql)
        {
            int index = 0;
            while (_isRunning)
            {
                try
                {
                    producerUpdateImageIdSql.PublishString(new JobUploadedImg()
                    {
                        ImageId = idImageImbo,
                        ProductId = productId
                    }.ToJson());
                    break;
                }
                catch (Exception exception)
                {
                    Thread.Sleep(600000);
                    Log.Error(
                        string.Format("Product: ID = {0} Send message to service check error download image. Thread Sleep 10p",
                            productId), exception);
                    if (index == 5)
                        break;
                    else
                        index++;
                }
            }
        }
        private static readonly object _keyLock = new object();
        public static void SendErrorDownloadImageToService(ImageProductInfo imageProductInfo)
        {
            lock (_keyLock)
            {
                int index = 0;
                var job = new Job { Data = ImageProductInfo.GetMessage(imageProductInfo) };
                while (_isRunning)
                {
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
                        if (index == 5)
                            break;
                        else
                            index++;
                    }
                }
            }
        }
    }
}