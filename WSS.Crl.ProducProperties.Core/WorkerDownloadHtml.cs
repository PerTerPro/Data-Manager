using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using QT.Entities;
using QT.Moduls;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Crl.ProducProperties.Core
{
    public class WorkerDownloadHtml : QueueingConsumer
    {
        private int _iCount = 0;
        private readonly string _domain = "";
        private readonly ProducerBasic _producerBasicWaitPs = null;
        private HanderDownloadHtml h1 = null;

        public WorkerDownloadHtml(string domain) : base(
            RabbitMQManager.GetRabbitMQServer(ConfigStatic.KeyRabbitMqCrlProductProperties),
            ConfigStatic.GetQueueWaitDownloadHtml(domain), false)
        {
            _domain = domain;
            h1 = new HanderDownloadHtml(domain);
        }

        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            _iCount++;
            Thread.Sleep(1000);
            JobDownloadHtml jobDownloadHtml = JobDownloadHtml.FromJson(Encoding.UTF8.GetString(message.Body));
            if (jobDownloadHtml != null )
            {
                h1.ProcessJob(jobDownloadHtml);
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }


    }
}
