using System.Text;
using System.Threading;
using Ninject;
using Ninject.Planning.Bindings;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Crl.ProducProperties.Core.DI;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Handler;
using WSS.LibExtra;

namespace WSS.Crl.ProducProperties.Core.Worker
{
    public class WorkerDownloadHtml : QueueingConsumer
    {
        private readonly HandlerDownloadHtml _h1 = null;

        public WorkerDownloadHtml(string domain) : base(
            RabbitMQManager.GetRabbitMQServer(ConfigStatic.KeyRabbitMqCrlProductProperties),
            ConfigStatic.GetQueueWaitDownloadHtml(domain), false)
        {
            var domainModule = new DomainModule();
            var kernel = new StandardKernel(domainModule);
            _h1 = kernel.Get<HandlerDownloadHtml>();
            _h1.Init(domain);
        }

        public override void Init()
        {
        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            try
            {
                JobCrlProperties jobDownloadHtml = JobCrlProperties.FromJson(Encoding.UTF8.GetString(message.Body));
                if (jobDownloadHtml != null)
                {
                    _h1.ProcessJob(jobDownloadHtml);
                }
                this.GetChannel().BasicAck(message.DeliveryTag, true);
            }
            catch (System.Exception ex1)
            {
                
                throw;
            }
            
        }
    }
}
