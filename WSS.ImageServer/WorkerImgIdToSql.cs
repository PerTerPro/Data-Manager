﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.ImageServer
{
    public class WorkerImgIdToSql:QueueingConsumer
        
    {
        readonly HandlerImgIdToSql _h = new HandlerImgIdToSql();
        private readonly ILog _log = LogManager.GetLogger(typeof (WorkerImgIdToSql));

        public WorkerImgIdToSql()
            : base(RabbitMQManager.GetRabbitMQServer(QT.Entities.Images.ConfigImages.RabbitMqServerName), QT.Entities.Images.ConfigImages.ImboQueueUploadImageIdSql, false)
        {
        }
        //public WorkerImgIdToSql()
        //    : base(RabbitMQManager.GetRabbitMQServer(QT.Entities.Images.ConfigImages.RabbitMqServerName), "ImboImage.UpdateImageIdSql.Temp", false)
        //{
        //}
        public override void Init()
        {
            
        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            var strMss = Encoding.UTF8.GetString(message.Body);
            _log.Info(string.Format("Process mss: {0}", strMss));
            _h.ProcessJob(strMss);
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
