using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.ImageServer
{
    public class WorkerDelImgImbo : QueueingConsumer
    {
        private HandlerDelImgImbo h = new HandlerDelImgImbo();
        //xuantrag
        public WorkerDelImgImbo() : base(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), ConfigImbo.QueueDelImgImbo, false)
        {

        }

        public override void Init()
        {

        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            string strMss = Encoding.UTF8.GetString(message.Body);
            Logger.Info(string.Format("Get mss: {0}", strMss));
            h.ProcessJob(strMss);
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
