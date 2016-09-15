using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls;
using QT.Moduls.CrawlerAlexa;
using QT.Moduls.CrawlerCompanyInfo;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.UpdateAlexaData;
using ConsumerUpdateAlexaCompanySeo = WSS.UpdateAlexaData.ConsumerUpdateAlexaCompanySeo;

namespace WSS.ConsumerTool
{
    internal class Program
    {
        private static ILog Log = LogManager.GetLogger(typeof (Program));
        public static string ConnectionSeo = @"Data Source=192.168.100.178;Initial Catalog=QA_System;User ID=sa;Password=123456a@";
        public static string ConnectionProduct = @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;Connect Timeout=5000";

        private static void Main(string[] args)
        {
            string desp = string.Join(" ", args);
            Log.Info("-s {TypeSystemRun} -t {TypeRun} -nt {NumberThread}");
            Log.Info(string.Format("Param: {0}", desp));
            Thread.Sleep(1000);
            Parameter p1 = new Parameter(desp);
            if (p1.TypeSystem == 0)
            {
                if (p1.TypeRun == 0)
                {
                    Runner.Instance().PushQueueUpdateAlexaSeoSystem();
                }
                else if (p1.TypeRun == 1)
                {
                    for (int i = 0; i < p1.NumberThread; i++)
                    {Task.Factory.StartNew(() =>
                        {
                            ConsumerUpdateAlexaCompanySeo consumer = new ConsumerUpdateAlexaCompanySeo(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct), "UpdateAlexaCompanySeo", Program.ConnectionSeo);
                            consumer.StartConsume();
                        });
                    }
                }
            }
            else if (p1.TypeSystem == 1)
            {
            }
            while (true)
            {
                Thread.Sleep(10000);
            }
            return;

            //Program p1 = new Program();
            //p1.PushQueueAlexaFullInfo();

            //p.PushQueueAlexaQASystem();
            //return;

            //p.ConsumerAlexaSeo();
            //return;


            Task.Factory.StartNew(() =>
            {
                Program p = new Program();
                p.ConsumerAlexaSeo();
            });

            Task.Factory.StartNew(() =>
            {
                Program p = new Program();
                p.ConsumerAlexaProduct();
                return;
            });

            Task.Factory.StartNew(() =>
            {
                Program p = new Program();
                p.ConsumerAlexaFullProduct();
                return;
            });

            while (true)
            {
                Thread.Sleep(100);
            }





            //QT.Moduls.CrawlerCompanyInfo.ConsumerUpdateAlexaCompany consumer = new ConsumerUpdateAlexaCompany(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct), "UpdateCompanyAlexa");
            //consumer.StartConsume();
            //return;


        }

        private void ConsumerAlexaProduct()
        {
            QT.Moduls.CrawlerCompanyInfo.ConsumerUpdateAlexaCompany consumer = new ConsumerUpdateAlexaCompany(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct), "UpdateAlexaCompany", Program.ConnectionProduct);
            consumer.StartConsume();
        }

        private void ConsumerAlexaFullProduct()
        {
            ConsumerUpdateAlexaCompanyInfo consumer = new ConsumerUpdateAlexaCompanyInfo(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct), ConfigRun.QueueUpdateAlexaFullInfo, Program.ConnectionProduct);
            consumer.StartConsume();
        }

        private void ConsumerAlexaSeo()
        {
        
        }

        public void PushQueueAlexa()
        {
            SqlDb _sqlDb = new SqlDb(ConfigurationManager.AppSettings[ConfigRun.KeySqlProduct]);

            string queryCompany = @"
SELECT a.ID, a.Domain
FROM Company a
WHERE a.Status = 1
";
            ProducerBasic producerBasic = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct), ConfigRun.QueueUpdateAlexa);
            DataTable tblCompanyTable = _sqlDb.GetTblData(queryCompany, CommandType.Text, null);
            foreach (DataRow VARIABLE in tblCompanyTable.Rows)
            {
                producerBasic.PublishString(
                    Newtonsoft.Json.JsonConvert.SerializeObject(new MssUpdateAlexaCompany() { CompanyId = Convert.ToInt64(VARIABLE["ID"]), Domain = Convert.ToString(VARIABLE["Domain"]) }));
            }

            return;

        }

        public void PushQueueAlexaFullInfo()
        {
            SqlDb _sqlDb = new SqlDb(ConfigurationManager.AppSettings[ConfigRun.KeySqlProduct]);
            string queryCompany = @"
SELECT a.ID, a.Domain
FROM Company a
WHERE a.Status = 1
";
            ProducerBasic producerBasic = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct), ConfigRun.QueueUpdateAlexaFullInfo);
            DataTable tblCompanyTable = _sqlDb.GetTblData(queryCompany, CommandType.Text, null);
            foreach (DataRow VARIABLE in tblCompanyTable.Rows)
            {
                producerBasic.PublishString(
                    Newtonsoft.Json.JsonConvert.SerializeObject(new MssUpdateAlexaCompany() { CompanyId = Convert.ToInt64(VARIABLE["ID"]), Domain = Convert.ToString(VARIABLE["Domain"]) }));
            }

            return;
        }


       

    }


}
