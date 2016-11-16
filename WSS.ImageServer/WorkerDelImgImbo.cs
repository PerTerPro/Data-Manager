using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace ImboForm
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
            h.ProcessJob(Newtonsoft.Json.JsonConvert.DeserializeObject<JobWaitDelImg>(Encoding.UTF8.GetString(message.Body)));
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
    }
}
