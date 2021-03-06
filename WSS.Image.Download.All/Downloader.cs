﻿using log4net;
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

namespace WSS.Image.Download.All
{

    public class Downloader
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Downloader));

        private string _connectionString =
            "Data Source = 172.22.1.82; Initial Catalog = QT_2; Persist Security Info=True;User ID = wss_price; Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout = 200";
        private bool _isRunning = true;
        RabbitMQServer _rabbitMqServer;
        private int _workerProduct;
        private int _workerCompany;
        private JobClient _checkErrorJobClient;
        //private List<Tuple<int, int>> _widthHeightImages;
        //Imbo
        private string _publicKeyImbo = "wss";
        private string _privateKeyImbo = "123websosanh@195";
        private string _userNameImbo = "wss";
        private string _hostImbo = "https://172.22.1.226";
        private int _portImbo = 443;
        public Downloader()
        {
            LoadAppConfig();
            _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
            _checkErrorJobClient = new JobClient(ConfigImages.ImboExchangeImages, GroupType.Topic, ConfigImages.ImboRoutingKeyCheckErrorDownload, true, _rabbitMqServer);
            
        }
        private void LoadAppConfig()
        {
            _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            //imbo
            _publicKeyImbo = ConfigurationManager.AppSettings["PublicKeyImboImageProduct"];
            _privateKeyImbo = ConfigurationManager.AppSettings["PrivateKeyImboImageProduct"];
            _userNameImbo = ConfigurationManager.AppSettings["UserNameImboImageProduct"];
            _hostImbo = ConfigurationManager.AppSettings["HostImboImageProduct"];
            _portImbo = Common.Obj2Int(ConfigurationManager.AppSettings["PortImboImageProduct"]);

            _workerProduct = Common.Obj2Int(ConfigurationManager.AppSettings["workerProduct"]);
            _workerCompany = Common.Obj2Int(ConfigurationManager.AppSettings["workerCompany"]);
        }
        public bool DownloadImageProduct(ImageProductInfo imageProductInfo, ProducerBasic producerUpdateImageIdSql)
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
        public void UpdateImageIdSqlService(long productId, string idImageImbo, ProducerBasic producerUpdateImageIdSql)
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
        private readonly object _keyLock = new object();
        public void SendErrorDownloadImageToService(ImageProductInfo imageProductInfo)
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
