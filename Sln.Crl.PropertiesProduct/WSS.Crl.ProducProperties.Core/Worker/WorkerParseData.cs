using System.Text;
using Ninject;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Crl.ProducProperties.Core.DI;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Handler;
using WSS.Crl.ProducProperties.Core.Parser;

namespace WSS.Crl.ProducProperties.Core.Worker
{
    public class WorkerParseData : QueueingConsumer
    {

        private readonly IHandlerParserProperties _handlerParserProperties = null;
        
        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            JobDownloadHtml jobDownloadHtml = JobDownloadHtml.FromJson(UTF8Encoding.UTF8.GetString(message.Body));
            _handlerParserProperties.ProcessJob(jobDownloadHtml.ProductId);
            this.GetChannel().BasicAck(message.DeliveryTag, true);
            Logger.InfoFormat("Processed {0}", jobDownloadHtml.ProductId);
        }
        public override void Init()
        {
          
        }

        public WorkerParseData(string domain) : base(RabbitMQManager.GetRabbitMQServer(ConfigStatic.KeyRabbitMqCrlProductProperties), 
            ConfigStatic.GetQueueParse(domain), false)
        {
            var domainModule = new DomainModule();
            var kernel = new StandardKernel(domainModule);
            _handlerParserProperties = kernel.Get<IHandlerParserProperties>();
            _handlerParserProperties.Init(domain);
        }
    }
}
