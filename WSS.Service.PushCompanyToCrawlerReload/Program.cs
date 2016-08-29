using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.Drivers.Redis;
using Websosanh.Core.JobServer;

namespace WSS.Service.LogChangePriceToRedis
{
    public class Program
    {
        private JobClient jobClient_ProductChangeImage;
        private ILog log = log4net.LogManager.GetLogger(typeof(Program));
        public static void Main()
        {
            Program pg = new Program();
            pg.RunPush();
            Console.ReadLine();
        }

        private void RunPush()
        {
            string groupName = System.Configuration.ConfigurationManager.AppSettings["Exchange_CrawlerProduct"].ToString();
            string routingkey = System.Configuration.ConfigurationManager.AppSettings["RoutingKey_CrawlerProductReload"].ToString();
            string connectToDb =System.Configuration.ConfigurationManager.AppSettings["SqlConnectionToDb"].ToString();
            var rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            while (true)
            {
                jobClient_ProductChangeImage = new JobClient(groupName, GroupType.Topic, routingkey, true, rabbitMQServer);
                SqlDb sqlDb = new SqlDb(connectToDb);
                DataTable tblCompanyReload = sqlDb.GetTblData("[prc_GetAllCompanyCrawlerData]", CommandType.StoredProcedure, new System.Data.SqlClient.SqlParameter[]{
                });
                if (tblCompanyReload!=null)
                    foreach (DataRow rowInfo in tblCompanyReload.Rows)
                    {
                        PushCompanyToQueue(new TaskCrawlerCompany()
                        {
                            iType = 1,
                            IdCompany = Convert.ToInt64(rowInfo["ID"]),
                            Domain = Convert.ToString(rowInfo["Domain"]),
                            DatePushJob = Convert.ToDateTime(rowInfo["CurrentDate"])
                        });
                    }
                Thread.Sleep(10000);
            }
        }

        public void PushCompanyToQueue (TaskCrawlerCompany taskCrawlerCompany)
        {
            while (true)
            {
                try
                {
                    var jobMQ = new Websosanh.Core.JobServer.Job();
                    jobMQ.Data = System.Text.Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(taskCrawlerCompany));
                    jobMQ.Type = (int)TypeJobWithRabbitMQ.Product;
                    jobClient_ProductChangeImage.PublishJob(jobMQ, 100000000);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(string.Format("Error push job ChangeMainInfo to MQ:{0}.{1}", ex01.Message, ex01.StackTrace));
                    Thread.Sleep(10000);
                }
            }
        }
    }
}
