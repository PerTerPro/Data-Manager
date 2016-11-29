using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.ImageServer
{
    public class WorkerThumbImg:QueueingConsumer
    {


        private ILog log = LogManager.GetLogger(typeof (WorkerThumbImg));
        public WorkerThumbImg()
            : base(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), ConfigImbo.QueueWaitThumb, false)
        {
          
        }

        public override void Init()
        {
           
        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            string mss = UTF8Encoding.UTF8.GetString(message.Body);
            log.Info(mss);
            JobUploadedImg job = JobUploadedImg.FromJson(mss);
            if (job != null)
            {
                ImboImageService.CallThumb(job.ImageId,ConfigImbo.ListThumb);
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
