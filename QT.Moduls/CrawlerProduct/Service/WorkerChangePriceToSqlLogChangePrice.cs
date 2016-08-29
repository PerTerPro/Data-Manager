using System;
using System.Configuration;
using System.Data;
using System.Text;
using System.Threading;
using MongoDB.Bson;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace QT.Moduls.CrawlerProduct.Service
{
    public class WorkerChangePriceToSqlHistoryPrice : Worker
    {
        private readonly CrawlerProductAdapter _crawlerProductAdapter =
            new CrawlerProductAdapter(new SqlDb(ConfigurationManager.AppSettings["LogConnectionString"]));
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(WorkerChangePriceToSqlHistoryPrice));

        private CancellationToken _token;
        private Encoding _enc = new UTF8Encoding(true, true);

        public WorkerChangePriceToSqlHistoryPrice(string jobName, bool autoAck, RabbitMQServer rabbitMqServer,
            CancellationToken token)
            : base(jobName, autoAck, rabbitMqServer)
        {
            _token = token;
            Init();
        }

        private void Init()
        {
            base.JobHandler = (downloadImageJob) =>
            {
                try
                {
                    if (_token.IsCancellationRequested) return false;
                    var job = JsonConvert.DeserializeObject<JobRabbitChangePrice>(_enc.GetString(downloadImageJob.Data));
                    _crawlerProductAdapter.SaveLog(job.ProductID, job.NewPrice, job.OldPrice);
                    _log.Info(string.Format("Saved job: {0}", _enc.GetString(downloadImageJob.Data)));
                    return true;
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                    Thread.Sleep(1000);
                    return false;
                }
            };
        }
    }
}
