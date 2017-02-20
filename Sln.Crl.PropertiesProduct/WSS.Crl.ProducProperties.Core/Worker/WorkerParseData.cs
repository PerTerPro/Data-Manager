using System.Text;
using Ninject;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Crl.ProducProperties.Core.DI;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Handler;
using WSS.Crl.ProducProperties.Core.Parser;
using System.IO;
using System.IO.Compression;

namespace WSS.Crl.ProducProperties.Core.Worker
{
    public class WorkerParseData : QueueingConsumer
    {

        private readonly IHandlerParserProperties _handlerParserProperties = null;
        
        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {
            JobCrlProperties jobDownloadHtml = JobCrlProperties.FromJson(UTF8Encoding.UTF8.GetString(Decompress(message.Body)));
            _handlerParserProperties.ProcessJob(jobDownloadHtml.ProductId, jobDownloadHtml.Html);
            this.GetChannel().BasicAck(message.DeliveryTag, true);
            Logger.InfoFormat("Processed {0}", jobDownloadHtml.ProductId);
        }
        public override void Init()
        {
          
        }
        //public static byte[] Decompress(byte[] raw)
        //{
        //    using (MemoryStream memory = new MemoryStream())
        //    {
        //        using (GZipStream gzip = new GZipStream(memory,
        //            CompressionMode.Decompress, true))
        //        {
        //            gzip.Write(raw, 0, raw.Length);
        //        }
        //        return memory.ToArray();
        //    }
        //}
        public static byte[] Decompress(byte[] gzip)
        {
            // Create a GZIP stream with decompression mode.
            // ... Then create a buffer and write into while reading from the GZIP stream.
            using (GZipStream stream = new GZipStream(new MemoryStream(gzip),
                CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    return memory.ToArray();
                }
            }
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
