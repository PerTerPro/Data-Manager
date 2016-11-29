using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using log4net.Filter;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.ImageServer
{
    public class HandlerDelImgImbo
    {


        ProducerBasic pb = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo),ConfigImbo.QueueDelImgImbo);
        public void ProcessJob(string imageId)
        {
            bool deleteFile = ImboImageService.DelteImage(ConfigImbo.PublicKey, ConfigImbo.PrivateKey, imageId, ConfigImbo.User, ConfigImbo.Host);
        }

        public void PushBack(string imgId)
        {
            pb.PublishString(new JobDelImgImbo()
            {
                ImageId = imgId
            }.ToJson());
        }
    }

    public class HandlerDelFileLocal
    {
        private ILog log = LogManager.GetLogger(typeof (HandlerDelFileLocal));
        ProducerBasic pb = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), ConfigImbo.QueueDelImgImbo);
        private string p;

        public HandlerDelFileLocal(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
        public void ProcessJob(string job)
        {
            log.Info(string.Format("Delete {0}", job));
            while (true)
            {
                try
                {
                    string file = (!job.Contains(":")) ? (this.p + @"\" + job) : job;
                    if (File.Exists(file)) File.Delete(file);
                    break;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    log.Error(job);
                    Thread.Sleep(10000);
                }
            }
          
            
        }

     
    }
}
