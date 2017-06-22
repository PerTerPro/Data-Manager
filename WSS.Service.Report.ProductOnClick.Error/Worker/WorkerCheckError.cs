using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Service.Report.ProductOnClick.Error.Worker
{
    public class WorkerCheckError : QueueingConsumer
    {
       
        public WorkerCheckError()
            : base(RabbitMQManager.GetRabbitMQServer("rabbitMqCrlProperties"), "Product.OnClick", false)
        {

        }
        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
           
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }
       
        public override void Init()
        {

        }
    }
}
