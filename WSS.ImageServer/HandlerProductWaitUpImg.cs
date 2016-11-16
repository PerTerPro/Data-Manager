using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.FtpClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.Statistics.Kernels;
using log4net;
using Newtonsoft.Json.Linq;
using QT.Entities.Data;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;

namespace ImboForm
{
    public class HandlerProductWaitUpImg
    {
        //private ProducerBasic producerWaitDownloadImage = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), "WSS.Img.WaitDownloadImage");
        private ILog log = LogManager.GetLogger(typeof (HandlerProductWaitUpImg));
        //private ProducerBasic producerWaitThumb = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), "WSS.Img.WaitThumb");
        //private ProducerBasic producerWaitUpdateImageIdToSql = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), "WSS.Img.WaitUpdateImgIdInfo");
        private readonly ProducerBasic _producerImageUploaed = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), "ImageImbo", "Img.Product.UploadedImg");

        public void ProcessJob(JobProductWaitUpImg jobProductWaitUpImg)
        {
            string newId = this.PostImageToImboServer(jobProductWaitUpImg);
            if (!string.IsNullOrEmpty(newId))
            {
                //PostWaitUpdateImageIdInfo(newId, jobProductWaitUpImg.ProductId);
                //PostWaitThumb(newId);
            }
        }

        //private void PostWaitThumb(string newId)
        //{
        //    this.producerWaitThumb.PublishString(new JobWaitThumb()
        //    {
        //        ImageId = newId
        //    }.ToJson());
        //}

        //private void PostWaitUpdateImageIdInfo(string newId, long productId)
        //{
        //    this.producerWaitUpdateImageIdToSql.PublishString(new JobWaitUpdateImageInfo()
        //    {
        //        ImageId = newId,
        //        ProductId = productId
        //    }.ToJson());
        //}

        private static string CreateToken(string message, string secret)
        {
            secret = secret ?? "";
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return ImboImage.ToHexString(hashmessage);
            }
        }

        public string PostImageToImboServer(JobProductWaitUpImg jobProductWaitUpImg)
        {
            string idImageNew = "";
            string urlQuery = "http://172.22.1.226/users/wss/images";
            string strDate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
            string str = "POST" + "|" + urlQuery + "|" + "wss" + "|" + strDate;
            var signleData = CreateToken(str, "123websosanh@195");
            try
            {
                int page = 1;
                long productId = jobProductWaitUpImg.ProductId;
                var path = jobProductWaitUpImg.ImgPathOld;
                string readyPath = path.Replace("Store/", "");
                using (FtpClient ftpClient = new FtpClient())
                {
                    ftpClient.Host = "183.91.14.84";
                    ftpClient.Credentials = new NetworkCredential("xuantrang_dev", "123456!@#$%^");
                    ftpClient.Connect();
                    if (ftpClient.FileExists(readyPath))
                        using (var ftpStream = ftpClient.OpenRead(readyPath))
                        {
                            var request = (HttpWebRequest) WebRequest.Create(urlQuery);
                            request.Headers.Add("X-Imbo-PublicKey", "wss");
                            request.Headers.Add("X-Imbo-Authenticate-Timestamp", strDate);
                            request.Headers.Add("X-Imbo-Authenticate-Signature", signleData);
                            request.ContentType = "application/json";
                            request.Method = "POST";
                            using (Stream stream = request.GetRequestStream())
                            {
                                ftpStream.CopyTo(stream);
                            }
                            using (WebResponse response = request.GetResponse())
                            {
                                using (Stream stream = response.GetResponseStream())
                                {
                                    using (StreamReader sr99 = new StreamReader(stream))
                                    {
                                        var responseContent = sr99.ReadToEnd();
                                        dynamic d = JObject.Parse(responseContent);
                                         idImageNew = d.imageIdentifier;
                                        this.log.Info(responseContent);
                                    }
                                }
                            }
                        }
                    ftpClient.Disconnect();
                }
            }
            catch (Exception ex)
            {
            }
            if (!string.IsNullOrEmpty(idImageNew))
            {
                this._producerImageUploaed.PublishString(new JobUploadedImg()
                {
                    ImageId = idImageNew,
                    ProductId = jobProductWaitUpImg.ProductId
                }.ToJson());
            }
            return "";
        }
    }
}