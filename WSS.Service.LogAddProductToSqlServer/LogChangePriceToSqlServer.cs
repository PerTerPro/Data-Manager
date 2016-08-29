using Newtonsoft.Json;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.Service.LogProduct
{
    public class LogChangePriceToSqlServer
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(LogChangePriceToSqlServer));
        private Worker worker;
        public void Stop()
        {
        }

        public void Start()
        {
            log.Info("Start LogChangePriceToSqlServer");

            var rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            worker = new Worker("ChangePriceQueue.LogToSql", false, rabbitMQServer);
            string connectToSQL = @"Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
            CrawlerProductAdapter crawlerProductAdapter = new CrawlerProductAdapter(new SqlDb(connectToSQL));

            log.Info("Start consumer!");
            worker.JobHandler = (downloadImageJob) =>
            {
                log.Info("Get job from MQ");
                try
                {
                    Encoding enc = new UTF8Encoding(true, true);
                    string strData = enc.GetString(downloadImageJob.Data);
                    JobRabbitChangePrice job = JsonConvert.DeserializeObject<JobRabbitChangePrice>(strData);
                    crawlerProductAdapter.SaveLog(job.ProductID, job.NewPrice, job.OldPrice);
                    log.Info(string.Format("Log for {0}", strData));
                    return true;
                }
                catch (Exception ex01)
                {
                    log.Error("Exception:", ex01);
                    return true;
                }
            };
            worker.Start();
        }

        ~LogChangePriceToSqlServer()
        {
            worker.Stop();
        }
    }
}
