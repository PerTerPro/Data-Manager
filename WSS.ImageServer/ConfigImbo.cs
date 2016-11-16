using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImboForm
{
     public static class ConfigImbo
     {
         public static string QueueJobProductWaitUpImg = "Img.Product.WaitUpImg";
         public static string QueueCompanyWaitPushProductTransferImage = "Img.Company.WaitPushTransfer";
         public static string QueueUploadImgIdToSql = "Img.Product.ImgIdToSql";
         public static string QueueDelImgImbo = "Img.Product.DelImgImbo";

         public static string KeyRabbitMqTransferImbo = "RabbitMqTransferImage";
         public static string ConnectionProduct = @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
        
     }
}
