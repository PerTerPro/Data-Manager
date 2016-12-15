﻿using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.ImageServer
{
    public class HandlerImgIdToSql
    {
        readonly ImageAdapterSql _imgAdapterSql = new ImageAdapterSql();
        readonly ProducerBasic _producerDelImbo = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo),ConfigImbo.QueueDelImgImbo);
        private ILog log = LogManager.GetLogger(typeof (HandlerImgIdToSql));

        public void ProcessJob(string str)
        {
            try
            {

                JobUploadedImg job = JobUploadedImg.FromJson(str);
                string imageIdOld = _imgAdapterSql.GetImageId(job.ProductId);
                if (!string.IsNullOrEmpty(imageIdOld))
                {
                    _producerDelImbo.PublishString(imageIdOld);
                }
                _imgAdapterSql.UpdateImboProcess(job.ProductId, job.ImageId);

                //PushChangeMainInfo
                RabbitMQAdapter.Instance.PushProductToQueueChangeMainInfo(new List<long>() { job.ProductId });
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
    }
}
