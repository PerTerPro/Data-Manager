using QT.Entities.CrawlerProduct;
using QT.Entities.CrawlerProduct.RabbitMQ;
using QT.Entities.Data;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Service.CacheCrawlerProduct
{
    public class WorkerCacheProductInfo : Websosanh.Core.Drivers.RabbitMQ.BasicGetConsumer
    {
        private CancellationToken tokenStop;
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(WorkerCacheProductInfo));

        public WorkerCacheProductInfo(RabbitMQServer rabbitmqServer, string queueName, bool autoAck, CancellationToken tokenStop1)
            : base(rabbitmqServer, queueName, autoAck)
        {
            this.tokenStop = tokenStop1;
        }

        public void Run()
        {
            Task.Factory.StartNew(() =>
                {
                    SqlDb sqlDb = new QT.Entities.Data.SqlDb(@"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
                    QT.Moduls.CrawlerProduct.Cache.CacheProductInfo cacheProductInfo = new QT.Moduls.CrawlerProduct.Cache.CacheProductInfo(sqlDb);

                    while (true)
                    {
                        BasicGetResult result = this.GetMessage();
                        if (result != null)
                        {
                            string str = System.Text.Encoding.UTF8.GetString(result.Body);
                            if (str != "")
                            {
                                MssRefreshCacheProductInfo job = MssRefreshCacheProductInfo.FromJSON(str);
                                log.Info(string.Format("Get Message For Company:{0} {1}", job.CompanyID, job.Domain));
                                int ProductCache = cacheProductInfo.ReloadCacheForCompany(job.CompanyID, job.Domain);
                                log.Info(string.Format("Company:{0} NumberProductCache:{1}", job.CompanyID, job.Domain));
                            }
                        }
                        this.tokenStop.WaitHandle.WaitOne(10000);
                    }
                });
        }

        public void Stop()
        {
            
        }

        public override void Init()
        {
            
        }
    }
}