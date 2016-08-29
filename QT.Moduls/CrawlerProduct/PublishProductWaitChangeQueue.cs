using QT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.JobServer;

namespace QT.Moduls.CrawlerProduct
{
     class PublishProductWaitChangeQueue
     {
         PublishProductWaitChangeQueue _obj;

         public PublishProductWaitChangeQueue Instance()
         {
             if (_obj == null) _obj = new PublishProductWaitChangeQueue();
             return _obj;
         }

         JobClient updateProductJobClient_ChangeImage = null;
         log4net.ILog log = log4net.LogManager.GetLogger(typeof(PublishProductWaitChangeQueue));

         public void PushProductToQueueWaitChange(Product _product)
         {
             while (true)
             {
                 try
                 {
                     var jobMQ = new Websosanh.Core.JobServer.Job();
                     jobMQ.Data = Product.GetMess(_product);
                     jobMQ.Type = (int)TypeJobWithRabbitMQ.Product;
                     updateProductJobClient_ChangeImage.PublishJob(jobMQ, 0);
                     return;
                 }
                 catch (Exception ex01)
                 {
                     log.Error(string.Format("Error push job ChangeMainInfo to MQ:{0}.{1}", ex01.Message, ex01.StackTrace));
                     Thread.Sleep(10000);
                 }
             }
         }
    }
}
