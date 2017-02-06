using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using MongoDB.Bson;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Storage;
using WSS.Crl.ProducProperties.Core.Worker;
using WSS.LibExtra;

namespace WSS.Crl.ProducProperties.Core.Service
{
    public static class ServiceRun
    {
        private static ILog log = LogManager.GetLogger(typeof (ServiceRun));
        public static void PushJobDownload(IEnumerable<string> domains)
        {
            foreach (var domain in domains)
            {
                PushJobDownload(domain);
            }
        }

        public static void DownLoadHtml(IEnumerable<string> domains)
        {
            foreach (var domain in domains)
            {
                WorkerDownloadHtml workerDownloadHtml = new WorkerDownloadHtml(domain);
                workerDownloadHtml.StartConsume();
            }
        }

        private static void PushJobDownload(string domain)
        {
            ProducerBasic producer = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigStatic.KeyRabbitMqCrlProductProperties),
                ConfigStatic.GetQueueWaitDownloadHtml(domain));
            IStorageProduct storageProduct = new StorageProduct();
            int i = 0;
            storageProduct.ProcessProduct(domain, (sender, product) =>
            {
                producer.PublishString(new JobCrlProperties()
                {
                    ProductId = product.Id,
                    DetailUrl = UtilCrl.GetUrl(product.DetailUrl,domain),
                    Domain = domain,
                    ClassificationId = product.ClassificationId,
                    Classification = product.Classification
                }.GetJson());
                i++;
                log.Info(string.Format("{0} {1}", i, product.Id));
            });
        }

        public static void RunWorkerParse(IEnumerable<string> domains)
        {
            foreach (var domain in domains)
            {
                Task.Factory.StartNew(() =>
                {
                    WorkerParseData w = new WorkerParseData(domain);
                    w.StartConsume();
                });
            }
        }

    }
}
