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
using System.Web;
using System.Data;

namespace WSS.Crl.ProducProperties.Core.Service
{
    public static class ServiceRun
    {
        private static ILog log = LogManager.GetLogger(typeof(ServiceRun));
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
            string DetailUrl = "";

            storageProduct.ProcessProduct(domain, (sender, product) =>
            {
                if (domain == "lazada.vn")
                {
                    string urlencode = product.DetailUrl;
                    string urldecode = HttpUtility.UrlDecode(product.DetailUrl);
                    char charRange = '?';
                    int startIndex = urldecode.IndexOf(charRange) + 1;
                    int endIndex = urldecode.LastIndexOf(charRange) - 1;
                    int length = endIndex - startIndex + 1;
                    DetailUrl = urldecode.Substring(startIndex, length).Replace("url=", "");
                }
                else
                {
                    DetailUrl = product.DetailUrl;
                }
                producer.PublishString(new JobCrlProperties()
                {
                    ProductId = product.Id,
                    DetailUrl = UtilCrl.GetUrl(DetailUrl, domain),
                    Domain = domain,
                    ClassificationId = product.ClassificationId,
                    Classification = product.Classification
                }.GetJson());
                i++;
                //log.Info(string.Format("{0} {1}", i, product.Id));
                log.InfoFormat("{0}: {1}", i, product.Id);
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
        public static void MapProductToSql(IEnumerable<string> domains)
        {
            foreach (var domain in domains)
            {
                WorkerMapProduct w = new WorkerMapProduct();
                w.MapData(domain);
            }
        }
    }
}
