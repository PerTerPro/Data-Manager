using log4net;
using QT.Entities;
using QT.Entities.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Wss.Lib.RabbitMq;
using WSS.ImageServer;

namespace WSS.ImageImbo.UploadImageToImboServer
{
    public static class CommonDownloadImage
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CommonDownloadImage));
        public static bool DownloadImageProduct(ImageProductInfo imageProductInfo, ProducerBasic producerUpdateImageIdSql, ref string messageError)
        {
            bool result = false;
            try
            {
                var idImbo = Common.DownloadImageProductWithImboServer(imageProductInfo.ImageUrls,ConfigImbo.PublicKey, ConfigImbo.PrivateKey, "wss", ConfigImbo.Host, ConfigImbo.Port);
                if (!string.IsNullOrEmpty(idImbo))
                {
                    UpdateImageIdSqlService(imageProductInfo.Id, idImbo, producerUpdateImageIdSql);
                    Log.Info(string.Format("Product: ID = {0} download image success!", imageProductInfo.Id));
                    messageError = "";
                    result = true;
                }
                else
                {
                    Log.Info(string.Format("Product: ID = {0} download image fails idImbo null!", imageProductInfo.Id));
                    messageError = "IDImbo null";
                    result = false;
                }
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Product: ID = {0}. ImageUrl: {1} . DetailUrl: {2}", imageProductInfo.Id, imageProductInfo.ImageUrls, imageProductInfo.DetailUrl), exception);
                messageError = exception.ToString();
            }
            return result;
        }
        public static bool DownloadImageRootProduct(ImageProductInfo imageProductInfo, ProducerBasic producerUpdateImageIdSql, ref string messageError)
        {
            bool result = false;
            try
            {
                var idImbo = Common.DownloadImageProductWithImboServer(imageProductInfo.ImageUrls, ConfigImbo.PublicKey, ConfigImbo.PrivateKey, "root_product", ConfigImbo.Host, ConfigImbo.Port);
                if (!string.IsNullOrEmpty(idImbo))
                {
                    UpdateImageIdSqlService(imageProductInfo.Id, idImbo, producerUpdateImageIdSql);
                    Log.Info(string.Format("Product: ID = {0} download image success!", imageProductInfo.Id));
                    messageError = "";
                    result = true;
                }
                else
                {
                    messageError = "IDImbo null";
                    result = false;
                }
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Product: ID = {0}. ImageUrl: {1} . DetailUrl: {2}", imageProductInfo.Id, imageProductInfo.ImageUrls, imageProductInfo.DetailUrl), exception);
                messageError = exception.ToString();
            }
            return result;
        }
        public static void UpdateImageIdSqlService(long productId, string idImageImbo, ProducerBasic producerUpdateImageIdSql)
        {
            int index = 0;
            while (true)
            {
                try
                {
                    producerUpdateImageIdSql.PublishString(new JobUploadedImg()
                    {
                        ImageId = idImageImbo,
                        ProductId = productId
                    }.ToJson());
                    Log.Info(string.Format("Send message update image id :prd {0} imboid {1}",productId,idImageImbo));
                    break;
                }
                catch (Exception exception)
                {
                    Thread.Sleep(10000);
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
        public static void SendImageIdToDelImageService(long productId, string idImageImbo, ProducerBasic producerDelByImageId)
        {
            int index = 0;
            while (true)
            {
                try
                {
                    producerDelByImageId.PublishString(idImageImbo);
                    break;
                }
                catch (Exception exception)
                {
                    Thread.Sleep(1000);
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
        public static bool UploadImageProductByHand(string path,ImageProductInfo imageProductInfo, ProducerBasic producerUpdateImageIdSql, ref string messageError)
        {
            bool result = false;
            try
            {
                var idImbo = Common.UploadImageProductWithImboServerByHand(path, ConfigImbo.PublicKey, ConfigImbo.PrivateKey, "wss", ConfigImbo.Host, ConfigImbo.Port);
                if (!string.IsNullOrEmpty(idImbo))
                {
                    UpdateImageIdSqlService(imageProductInfo.Id, idImbo, producerUpdateImageIdSql);
                    Log.Info(string.Format("Product: ID = {0} download image success!", imageProductInfo.Id));
                    messageError = "";
                    result = true;
                }
                else
                {
                    messageError = "IDImbo null";
                    result = false;
                }
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Product: ID = {0}. ImageUrl: {1} . DetailUrl: {2}", imageProductInfo.Id, imageProductInfo.ImageUrls, imageProductInfo.DetailUrl), exception);
                messageError = exception.ToString();
            }
            return result;
        }
    
    }
}
