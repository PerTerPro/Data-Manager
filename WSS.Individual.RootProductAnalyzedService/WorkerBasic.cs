using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Individual.RootProductAnalyzedService
{
    public class WorkerBasic : Websosanh.Core.Drivers.RabbitMQ.QueueingConsumer
    {
        public delegate void ProcessJob(byte[] arBytes);

        public ProcessJob JobHandler;

        public WorkerBasic(Websosanh.Core.Drivers.RabbitMQ.RabbitMQServer rabbitmqServer, string queueName) : base
            (rabbitmqServer, queueName, false) { }

        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            JobHandler(message.Body);
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }

        public override void Init()
        {
            
        }

        internal void Start()
        {
            this.StartConsume();
        }
    }
}
