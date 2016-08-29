using System;
using System.Data;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace QT.Moduls.CrawlerProduct.Service
{
    public class WorkerChangePriceToHistoryPriceSqlUi : Worker
    {
        private readonly SqlDb _sqlDbUi = new SqlDb("Data Source=42.112.28.93;Initial Catalog=ReviewsCMS;Persist Security Info=True;User ID=wss_news;Password=HzlRt4$$axzG-*UlpuL2gYDu");
        readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(WorkerChangePriceToHistoryPriceSqlUi));
        private CancellationToken _token;
        public WorkerChangePriceToHistoryPriceSqlUi(string jobName, bool autoAck, RabbitMQServer rabbitMqServer, CancellationToken token)
            : base(jobName, autoAck, rabbitMqServer)
        {
            _token = token;
            SetMethod();
        }

        private void SetMethod()
        {
            base.JobHandler = (downloadImageJob) =>
            {
                _token.ThrowIfCancellationRequested();
                Encoding enc = new UTF8Encoding(true, true);
                var job = JsonConvert.DeserializeObject<JobRabbitChangePrice>(enc.GetString(downloadImageJob.Data));
                var sql = GetCommandSql(job);
                if (_sqlDbUi.RunQuery(sql, CommandType.Text, null))
                {
                    _log.Info(string.Format("Saved for job:{0}", enc.GetString(downloadImageJob.Data)));
                    return true;
                }
                else
                {
                    Thread.Sleep(1000);
                    return false;
                }
            };
        }

        private string GetCommandSql(JobRabbitChangePrice job)
        {
            if (job.OldPrice > 0)
                return string.Format("Update AdvProductHotdeal Set Price = {0}, PriceOld = {1} Where ProductId = {2}",
                    job.NewPrice, job.OldPrice, job.ProductID);
            else
                return string.Format("Update AdvProductHotdeal Set Price = {0} Where ProductId = {1}",
                    job.NewPrice, job.ProductID);
        }
    }
}
