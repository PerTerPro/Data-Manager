﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.FtpClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.Statistics.Kernels;
using ImboForm;
using log4net;
using Newtonsoft.Json.Linq;
using QT.Entities.Data;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;
using Wss.Lib.RabbitMq;

namespace WSS.ImageServer
{
    public class HandlerProductWaitUpImg
    {
        private ILog log = LogManager.GetLogger(typeof (HandlerProductWaitUpImg));
        private readonly ProducerBasic _producerImageUploaed = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), "ImageImbo", "Img.Product.UploadedImg");
        public void ProcessJob(JobProductWaitUpImg jobProductWaitUpImg)
        {
        

        }
    }
}