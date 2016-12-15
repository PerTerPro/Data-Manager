using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImboForm;
using log4net;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;
namespace WSS.ImageServer
{
   public  class HandlerTransRootProduct
   {
       private ILog log = log4net.LogManager.GetLogger(typeof (HandlerTransRootProduct));
       private SqlDb sql = new SqlDb(ConfigImbo.ConnectionProduct);
       private ProducerBasic pbUpdateId = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqImageIdToSql), ConfigImbo.QueueRabbitMqImageIdToSql);

       public void PushRootProduct()
       {
           ProducerBasic pb = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo),ConfigImbo.QueueRootProductWaitTrans);


           sql.ProcessDataTableLarge(@"
  select  a.name, a.id, ImageId, ImagePath
  from product  a
  where a.Company = 6619858476258121218
  and a.Valid = 1
  and isnull(ImageId,'') = ''
order by a.id
", 50000, (row, iRow) =>
           {
               long id = Common.Obj2Int64(row["Id"]);
               string url = string.Format("http://img.websosanh.vn/{0}", Common.Obj2String(row["ImagePath"]));
               pb.PublishString(new JobRootProductWaitTrans()
               {
                   Id = id,
                   Url = url
               }.ToJson());
           });
       }

       public void StartDownload()
       {
          
       }

       public void ProcessJob(string mss1)
       {
           JobRootProductWaitTrans job = JobRootProductWaitTrans.FromJson(mss1);
           try
           {
               string url = job.Url.Replace(@"http://img.websosanh.vn/", "http://img.websosanh.net/ThumbImages/").Replace(".jpg", "_200.jpg");
               string imgId = Common.DownloadImageProductWithImboServer(url, ConfigImbo.PublicKey, ConfigImbo.PrivateKey, "root_product", ConfigImbo.Host, 443);
               if (!string.IsNullOrEmpty(imgId))
               {
                   this.pbUpdateId.PublishString(new JobUploadedImg()
                   {
                       ImageId = imgId,
                       ProductId = job.Id
                   }.ToJson());
                   this.log.Info(string.Format("Processed for {0} {1}", job.Id, imgId));
               }
           }
           catch (Exception ex)
           {
               log.Error(ex);
           }
          
       }
   }
}
