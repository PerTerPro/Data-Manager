using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;

namespace ImboForm
{
    public class HandlerImgIdToSql
    {
        ImageAdapterSql imgAdapterSql = new ImageAdapterSql();
        ProducerBasic _producerDelImbo = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo),ConfigImbo.QueueDelImgImbo);
        private ILog log = LogManager.GetLogger(typeof (HandlerImgIdToSql));

        public void ProcessJob(string str)
        {
            JobUploadedImg job = JobUploadedImg.FromJson(str);
            string imageIdOld = imgAdapterSql.GetImageId(job.ProductId);
            if (!string.IsNullOrEmpty(imageIdOld))
            {
                _producerDelImbo.PublishString(new JobDelImgImbo()
                {
                    ImageId = imageIdOld
                }.ToJson()); 
            }
            imgAdapterSql.UpdateImboProcess(job.ProductId, job.ImageId);
        }
    }
}
