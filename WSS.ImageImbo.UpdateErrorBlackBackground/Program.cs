using log4net;
using QT.Entities;
using QT.Entities.Data;
using QT.Entities.Images;
using QT.Moduls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.ImageServer;

namespace WSS.ImageImbo.UpdateErrorBlackBackground
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));
        private static bool _isRunning = true;
        private static RabbitMQServer _rabbitMqServer;
        static SqlDb sqldb = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            //Program p = new Program();
            //p.UpdateError();
            Program.UpdateError();
        }


        public static void UpdateError()
        {
            _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
            var producerUpdateImageIdSql = new ProducerBasic(_rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyUploadImageIdSql);
            long CompanyID = 7501950358591465227;
            var tblProduct = sqldb.GetTblData(string.Format("Select ID,ImageUrls from Product where Company = {0} and Valid = 1 and ImageUrls like '%.png' order by ID", CompanyID));
            foreach (DataRow row in tblProduct.Rows)
            {
                try
                {
                    long ProductID = Common.Obj2Int64(row["ID"]);
                    string ImageUrls = row["ImageUrls"].ToString().Trim();
                    DownloadImageProduct(ImageUrls, ProductID, producerUpdateImageIdSql);
                    Log.InfoFormat("Update image error product: {0}", ProductID);
                }
                catch (Exception)
                {

                }

            }
            //var tblCompany = sqldb.GetTblData("select ID from Company where status = 1 or Status = 18 or Status = 19");
            //foreach (DataRow rowCompany in tblCompany.Rows)
            //{
            //    int iCount = 1;
            //    long CompanyID = Common.Obj2Int64(rowCompany["ID"]);
            //    var tblProduct = sqldb.GetTblData(string.Format("Select ID,ImageUrls from Product where Company = {0} and Valid = 1 and ImageUrls like '%.png' order by ID", CompanyID));
            //    foreach (DataRow row in tblProduct.Rows)
            //    {
            //        try
            //        {
            //            long ProductID = Common.Obj2Int64(row["ID"]);
            //            string ImageUrls = row["ImageUrls"].ToString().Trim();
            //            DownloadImageProduct(ImageUrls, ProductID, producerUpdateImageIdSql);
            //            Log.InfoFormat("Update image error product: {0}", ProductID);
            //        }
            //        catch (Exception)
            //        {

            //        }
                    
            //    }
            //    Log.InfoFormat("{0} Company Success:{1}", iCount, CompanyID);
            //    iCount++;
            //}
            Log.InfoFormat("Download all image Compant: {0}", CompanyID);
        }
        private static bool DownloadImageProduct(string ImageUrls, long ProductId, ProducerBasic producerUpdateImageIdSql)
        {
            bool result = false;
            try
            {
                var idImbo = Common.DownloadImageProductWithImboServer(ImageUrls, ConfigImbo.PublicKey, ConfigImbo.PrivateKey, "wss", ConfigImbo.Host, ConfigImbo.Port);
                if (!string.IsNullOrEmpty(idImbo))
                {
                    UpdateImageIdSqlService(ProductId, idImbo, producerUpdateImageIdSql);
                    //ThumbImageService(imageProductInfo.Id, idImbo, producerThumbImage);
                    Log.Info(string.Format("Product: ID = {0} download image success!", ProductId));
                    //InsertLogDownloadImageProduct(imageProductInfo.Id);
                    result = true;
                }
                else
                {
                    //imageProductInfo.ErrorMessage = "IDImbo = null";
                    //SendErrorDownloadImageToService(imageProductInfo);
                }
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Product: ID = {0}. ImageUrl: {1} . DetailUrl: {2}", ProductId, ImageUrls), exception);
                Thread.Sleep(10000);
                //imageProductInfo.ErrorMessage = exception.ToString();
                //SendErrorDownloadImageToService(imageProductInfo);
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
                    Log.Error(string.Format("Product: ID = {0} Send message to service check error download image. Thread Sleep 10p", productId), exception);
                    if (index == 5)
                        break;
                    else
                        index++;
                }
            }
        }
        public static bool ContainsTransparent(Bitmap image)
        {
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    if (image.GetPixel(x, y).A != 255)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
