using log4net;
using QT.Entities;
using QT.Entities.RaoVat;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.CrawlerProduct.ManagerConnectStatic
{
    public class ManagerConnect
    {
        ILog log = LogManager.GetLogger(typeof(ManagerConnect));

        static ManagerConnect staticInstance;
        public static ManagerConnect Instance ()
        {
            return (staticInstance == null) ? (staticInstance = new ManagerConnect()) : staticInstance;
        }

        public void ShowConnect()
        {
            Console.WriteLine("RabbitMQ: {0} : {1} : {2}"
               , QT.Entities.Server.RabbitMQ_Host
               , QT.Entities.Server.RabbitMQ_Pass
               , QT.Entities.Server.RabbitMQ_User);

            Console.WriteLine("RedisDB: {0} : {1}"
                , QT.Entities.Server.RedisDB_Host
                , QT.Entities.Server.RedisDB_Port);

            Console.WriteLine("SqlDb: {0}",
                QT.Entities.Server.ConnectionStringCrawler);

            Console.WriteLine("NodeID: {0}", QT.Entities.Server.NodeID);
        }

        public  ManagerConnect()
        {
        }

   

        public void LoadConfigFromConfigFile()
        {
            try
            {
                QT.Entities.Server.ConnectionStringCrawler = Convert.ToString(ConfigurationSettings.AppSettings["ConnectionStringCrawler"]);
                QT.Entities.Server.ConnectionString = Convert.ToString(ConfigurationSettings.AppSettings["ConnectionString"]);
                QT.Entities.Server.LogConnectionString = Convert.ToString(ConfigurationSettings.AppSettings["LogConnectionString"]);
            }
            catch (Exception ex)
            {
                log.ErrorFormat(ex.Message);
            }

            //try
            //{
            //    QT.Entities.Common.ReloadRegexKeyWord();
            //}
            //catch (Exception ex)
            //{
            //    log.ErrorFormat(ex.Message);
            //}
        }

        
    }
}
