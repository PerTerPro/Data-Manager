using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.ImageServer
{
    public class WorkerDelFileLocal : QueueingConsumer
    {
        private HandlerDelFileLocal h = null;
        private string p;
        //xuantrag
        public WorkerDelFileLocal(string p)
            : base(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), ConfigImbo.QueueWaitDelFile, false)
        {
            h = new HandlerDelFileLocal(p);
        }


        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
           
            h.ProcessJob(Encoding.UTF8.GetString(message.Body));
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
