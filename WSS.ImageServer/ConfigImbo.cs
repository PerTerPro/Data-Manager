using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImboForm
{
     public static class ConfigImbo
     {
         public static string QueueJobProductWaitUpImg = "Img.Product.WaitUpdImgIdSql";
         public static string QueueCompanyWaitPushProductTransferImage = "Img.Company.WaitPushTransfer";
         public static string QueueUploadImgIdToSql = "Img.Product.ImgIdToSql";
         public static string QueueDelImgImbo = "Img.Imbo.Delete";
         public static string PrivateKey = "123websosanh@195";
         public static string PublicKey = "wss";
         public static string User = "wss";
         public static string KeyRabbitMqTransferImbo = "RabbitMqTransferImage";
         public static string ConnectionProduct = @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
         public static string Host = @"http://172.22.1.226";
         public static string ExchangeImage = "ImageImbo";
         public static string RoutingKeyUploadImb = "Img.Product.UploadedImg";
         public static string QueueWaitDelFile = "Img.Product.WaitDelFile";
         public static string QueueErrorUpImbo = "Img.Product.ErrorPushImbo";
         public static string QueueNoProduct = "Img.Product.NoProduct";
         public static string QueueWaitThumb = "Img.Product.Thumb";

         public static List<Tuple<int, int>> ListThumb = new List<Tuple<int, int>>()
         {
             new Tuple<int, int>(200, 200),
             new Tuple<int, int>(78, 78),
             new Tuple<int, int>(50, 50),
             new Tuple<int, int>(45, 45),
         };

     }
}
