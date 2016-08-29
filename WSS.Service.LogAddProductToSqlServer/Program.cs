using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
//using Websosanh.Core.Drivers.Redis;
using Websosanh.Core.JobServer;
using System.Configuration;
using QT.Entities.Data;
using System.ServiceProcess;
using log4net;


namespace WSS.Service.LogProduct
{
    public class Program
    {
        public static void Main()
        {


            bool LogAddProduct = QT.Entities.Common.Obj2Bool(ConfigurationManager.AppSettings["LogAddProduct"]);
            bool LogChangePriceProductSQL = QT.Entities.Common.Obj2Bool(ConfigurationManager.AppSettings["LogChangePriceProductSQL"]);
            bool LogChangePriceToRedis = QT.Entities.Common.Obj2Bool(ConfigurationManager.AppSettings["LogChangePriceToRedis"]);
       

            if (LogAddProduct)
            {
                Task.Factory.StartNew(() =>
                    {
                        LogAddProductToSqlServercs log1 = new LogAddProductToSqlServercs();
                        log1.Start();
                    });
            }

            if (LogChangePriceToRedis)
            {
                Task.Factory.StartNew(() =>
                {
                    LogChangePriceToRedis log1 = new LogChangePriceToRedis();
                    log1.Start();
                });
            }

            if (LogChangePriceProductSQL)
            {
                Task.Factory.StartNew(() =>
                {
                    LogChangePriceToSqlServer log1 = new LogChangePriceToSqlServer();
                    log1.Start();
                });
            }

            Console.ReadLine();
        }
    }
}
