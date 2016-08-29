using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using QT.Moduls;
using QT.Moduls.CrawlerProduct;
using Newtonsoft.Json;
using QT.Entities.Data;
using System.Data;
using System.Data.SqlClient;

namespace LogCrawlerMQtoSql
{
    class Program
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        private Worker worker;
        SqlDb sqldb = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_User;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu");
        static void Main(string[] args)
        {
        }
        public void Start()
        {
            log.Info("Start LogCrawlerMQtoSql");

            var rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            worker = new Worker("@@@@@@@@@@@@@@@", false, rabbitMQServer);
            

            log.Info("Start consumer!");
            worker.JobHandler = (downloadImageJob) =>
            {
                log.Info("Get job from MQ");
                try
                {
                    Encoding enc = new UTF8Encoding(true, true);
                    string strData = enc.GetString(downloadImageJob.Data);
                    LogCrawlerMQ job = JsonConvert.DeserializeObject<LogCrawlerMQ>(strData);
                    SaveToSql(job.Machine, job.Worker, job.Mss, job.VisitedLink, job.Product, job.QueueLink, job.DatePush);
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

        public void SaveToSql(string Machine,string Worker,string Mss,int VisitedLink,long Product,int QueueLink,DateTime DatePush)
        {
            sqldb.RunQuery("INSERT INTO LogCrawlerMQ (Machine, Worker, Mss, VisitedLink, Product, QueueLink, DatePush) VALUES (@Machine,@Worker,@Mss,@VisitedLink,@Product,@QueueLink,@DatePush)", CommandType.Text, new SqlParameter[] { 
                sqldb.CreateParamteter("@Machine",Machine,SqlDbType.NVarChar),
                sqldb.CreateParamteter("@Worker",Worker,SqlDbType.NVarChar),
                sqldb.CreateParamteter("@Mss",Mss,SqlDbType.NVarChar),
                sqldb.CreateParamteter("@VisitedLink",VisitedLink,SqlDbType.Int),
                sqldb.CreateParamteter("@Product",Product,SqlDbType.BigInt),
                sqldb.CreateParamteter("@QueueLink",QueueLink,SqlDbType.Int),
                sqldb.CreateParamteter("@DatePush",DatePush,SqlDbType.DateTime)
            });
        }
    }
}
