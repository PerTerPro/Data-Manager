using Newtonsoft.Json;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.Service.LogProduct
{
    class LogAddProductToSqlServercs
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(LogChangePriceToSqlServer));
        private Worker worker;
        public void Stop()
        {
        }

        public void Start()
        {
            log.Info("Start LogAddProductToSqlServercs");
            var rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            worker = new Worker("AddProductQueue.Product", false, rabbitMQServer);
            string connectToSQL = @"Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
            string connectToConnection = @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
            CrawlerProductAdapter crawlerProductAdapter = new CrawlerProductAdapter(new SqlDb(connectToSQL));
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(connectToConnection));

            log.Info("Start consumer!");
            worker.JobHandler = (downloadImageJob) =>
           {
               log.Info("Get job from MQ");
               try
               {
                   Encoding enc = new UTF8Encoding(true, true);
                   string strData = enc.GetString(downloadImageJob.Data);
                   JobRabbitAddProduct job = JsonConvert.DeserializeObject<JobRabbitAddProduct>(strData);
                   if (job.DateAdd == DateTime.MinValue)
                   {
                       job.DateAdd = productAdapter.GetLastChangeOfProduct(job.ProductID);
                   }
                   crawlerProductAdapter.SaveLogAddProduct(job.ProductID, job.DetailUrl, job.IDCompnay, job.Name, job.DateAdd);
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

        ~LogAddProductToSqlServercs()
        {
            worker.Stop();
        }
    }
}
