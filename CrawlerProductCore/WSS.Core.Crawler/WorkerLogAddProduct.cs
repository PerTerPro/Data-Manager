using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Core.Crawler
{
    public class WorkerLogAddProduct : QueueingConsumer
    {
        private ILog log = LogManager.GetLogger(typeof (WorkerLogAddProduct));
        private SqlDb sqlDb = new SqlDb(ConfigCrawler.ConnectLog);

        public WorkerLogAddProduct() : base(
            RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), 
            ConfigCrawler.QueueLogAddProduct, false)
        {
        }

        public override void Init()
        {
           
        }

        public override void ProcessMessage(BasicDeliverEventArgs message)
        {
            bool bOk = false;
            string mss = UTF8Encoding.UTF8.GetString(message.Body);
           
            JobRabbitAddProduct job = Newtonsoft.Json.JsonConvert.DeserializeObject<JobRabbitAddProduct>(mss);
            if (job != null)
            {
                  bOk = sqlDb.RunQuery("insert into Product_LogsAddProduct (IDCompany, IDProduct, Name, Url) values (@IDCompany, @IDProduct, @Name, @Url)", CommandType.Text, new[]
                {
                    SqlDb.CreateParamteterSQL("IDCompany",job.IDCompnay,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("IDProduct",job.ProductID,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("Name",job.Name,SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("Url",job.DetailUrl,SqlDbType.NVarChar),
                });
            }
            this.GetChannel().BasicAck(message.DeliveryTag, true);
            this.log.Info(string.Format("Process job: {0} {1}", mss, bOk));
        }
    }
}
