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
using QT.Moduls.CrawlerProduct.Cache;
using RabbitMQ.Client;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Core.Crawler.CrlProduct
{
    public static class ControlCmpCrlw
    {
        public static ILog Log = log4net.LogManager.GetLogger(typeof (ControlCmpCrlw));
        private static readonly RedisCompanyWaitCrawler RedisCompanyWaitCrawler = RedisCompanyWaitCrawler.Instance();

        public static void PushCmp()
        {
            var server = RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler);
            var sqldb = new SqlDb(ConfigCrawler.ConnectProduct);
            var tupleSetup = new List<Tuple<string, string>>()
            {
                new Tuple<string, string>("00", "Vip.Cmp.Crl.Fn"),
                new Tuple<string, string>("10", "Vip.Cmp.Crl.Rl"),
                new Tuple<string, string>("01", "Normal.Cmp.Crl.Fn"),
                new Tuple<string, string>("11", "Normal.Cmp.Crl.Rl"),
            };
            foreach (var tuple in tupleSetup)
            {
                Log.Info(string.Format("Push to {0} {1}", tuple.Item1, tuple.Item2));
                var producer = new ProducerBasic(server, tuple.Item2);
                var chanl = server.CreateChannel();
                QueueDeclareOk dcl = chanl.QueueDeclare(tuple.Item2, true, false, false, null);
                if (dcl.MessageCount < 1)
                {var tblCmpFn = sqldb.GetTblData("[prc_Company_GetCmpToPushCrl]", CommandType.StoredProcedure, new[]
                    {
                        SqlDb.CreateParamteterSQL("@TypeCrl", tuple.Item1, SqlDbType.VarChar)
                    });
                    foreach (DataRow variable in tblCmpFn.Rows)
                    {
                        long companyId = Common.Obj2Int64(variable["ID"]);
                        if (!RedisCompanyWaitCrawler.CheckRunningCrawler(companyId))
                        {
                            producer.PublishString(new JobCompanyCrawler()
                            {
                                CheckRunning = true,
                                CompanyId = companyId
                            }.GetJSon());
                            Log.Info(string.Format("Pushed for cmp: {0}", companyId));
                        }
                    }
                }
            }
            return;}
    }
}