using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls;
using QT.Moduls.CrawlerAlexa;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.UpdateAlexaData
{
    public class Runner
    {
        private ILog _log = LogManager.GetLogger(typeof (Runner));
        private static Runner _instance;

        public static Runner Instance()
        {
            return (_instance) ?? (_instance = new Runner());
        }

        private Runner()
        {

        }

        internal  void PushQueueUpdateAlexaSeoSystem()
        {
            SqlDb _sqlDb =
                new SqlDb("Data Source=192.168.100.178;Initial Catalog=QA_System;User ID=sa;Password=123456a@");
            string queryCompany = @"
select ID, Name as Domain
From Web
where LastUpdateAlexa is null 
--where IsCrawler = 1
";
            ProducerBasic producerBasic =
                new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct),
                    "UpdateAlexaCompanySeo");
            DataTable tblCompanyTable = _sqlDb.GetTblData(queryCompany, CommandType.Text, null);
            foreach (DataRow variable in tblCompanyTable.Rows)
            {
                producerBasic.PublishString(
                    Newtonsoft.Json.JsonConvert.SerializeObject(new MssUpdateAlexaCompany()
                    {
                        CompanyId = Convert.ToInt64(variable["ID"]),
                        Domain = Convert.ToString(variable["Domain"])
                    }));
            }
            _log.Info("Pushed all job");
        }
    }
}
