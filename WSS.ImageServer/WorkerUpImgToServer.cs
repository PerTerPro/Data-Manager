using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities.Data;
using QT.Moduls;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.ImageServer
{
    public class WorkerUpImgToServer : QueueingConsumer
    {
        private int iCount = 0;
        private readonly ILog _log = LogManager.GetLogger(typeof (WorkerUpImgToServer));
        private readonly HandlerProductWaitUpImg _handler = new HandlerProductWaitUpImg();

   
        public WorkerUpImgToServer() : base(
            RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), ConfigImbo.QueueJobProductWaitUpImg, false)
        {
        }

        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            iCount ++;
            var mss1 = Encoding.UTF8.GetString(message.Body);
            var mss = Newtonsoft.Json.JsonConvert.DeserializeObject<JobProductWaitUpImg>(mss1);
            if (mss != null)
            {
                _handler.ProcessJob(mss);
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}