using System;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using WSS.Product.Utilities;

namespace QT.Moduls.CrawlerProduct.Service
{
    public class WorkerChangePriceToHistoryPrice : Worker
    {
        readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(WorkerChangePriceToHistoryPrice));
        private CancellationToken _token;
        public WorkerChangePriceToHistoryPrice(string jobName, bool autoAck, RabbitMQServer rabbitMqServer, CancellationToken token)
            : base(jobName, autoAck, rabbitMqServer)
        {
            _token = token;
            SetMethod();
        }

        private void SetMethod()
        {
            base.JobHandler = (downloadImageJob) =>
            {
                if (_token.IsCancellationRequested) return false;
                try
                {
                    Encoding enc = new UTF8Encoding(true, true);
                    var job = JsonConvert.DeserializeObject<JobRabbitChangePrice>(enc.GetString(downloadImageJob.Data));
                    RedisPriceLogAdapter.PushMerchantProductPrice(job.ProductID, job.NewPrice, DateTime.Now);
                    _log.Info(string.Format("Saved for job:{0}", enc.GetString(downloadImageJob.Data)));
                    return true;
                }
                catch( Exception ex)
                {
                    _log.Error(ex);
                    return false;
                }
            };
        }
    }
}
