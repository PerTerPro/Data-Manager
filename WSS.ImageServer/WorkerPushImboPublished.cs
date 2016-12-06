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
    public class WorkerPushImboPublished : QueueingConsumer
    {


        private ILog log = LogManager.GetLogger(typeof(WorkerPushImboPublished));
        private  HandlerNewPublisher h = new HandlerNewPublisher();

        public WorkerPushImboPublished()
            : base(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), ConfigImbo.QueuePublishedWaitTrans, false)
        {

        }

        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            string mss = UTF8Encoding.UTF8.GetString(message.Body);
            log.Info(mss);
            if (!string.IsNullOrEmpty(mss))
            {
                h.PushImbo(mss);
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
