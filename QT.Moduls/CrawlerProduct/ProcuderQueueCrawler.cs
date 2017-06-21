using System.Text;
using Websosanh.Core.Drivers.RabbitMQ;

namespace QT.Moduls.CrawlerProduct
{
    public class ProcuderQueueCrawler:Producer
    {
        public override bool Init()
        {
            return true;
        }

        protected override void MessageReturn(object sender, global::RabbitMQ.Client.Events.BasicReturnEventArgs args)
        {
            
        }

        public ProcuderQueueCrawler(RabbitMQServer rabbitmqServer, string exchangeName, string routingKey, string queueName) : base(rabbitmqServer, "", queueName)
        {
        }


        public void PushStringMss(string queue, string mss)
        {
            base.Publish(GetChannel(), true, null, Encoding.UTF8.GetBytes(mss));
        }
     
    }
}
