using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using QT.Entities.Data;
using QT.Moduls;
using QT.Moduls.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Crl.ProducProperties.Core;

namespace WSS.Crl.ProducProperties.Service
{
    public static class ServiceCrl
    {
        private static ILog log = LogManager.GetLogger(typeof (ServiceCrl));
         

        public static void PushDownloadHtml(IEnumerable<string> domains)
        {

            SqlDb sql = new SqlDb(ConfigStatic.ProductConnection);
            ProductAdapter productAdapter = new ProductAdapter(sql);
            foreach (var domain in domains)
            {
                ProducerBasic producerBasic = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigStatic.KeyRabbitMqCrlProductProperties),
                    ConfigStatic.GetQueueWaitDownloadHtml(domain));
                string queryData = string.Format(@"
                        Select Id, DetailUrl 
                        From Product 
                        Where Company = {0}
                        Order by Id
                        "
                    , productAdapter.GetCompanyIdByDomain(domain));
                sql.ProcessDataTableLarge(queryData,
                    10000, (Row, iRow) =>
                    {
                        producerBasic.PublishString(new JobDownloadHtml()
                        {
                            ProductId = Convert.ToInt64(Row["Id"]),
                            DetailUrl = Convert.ToString(Row["DetailUrl"]),
                            Domain = domain
                        }.GetJson());
                    });
            }


        }

        public static void RunWorkerParse(IEnumerable<string> domains)
        {
            foreach (var domain in domains)
            {
                Task.Factory.StartNew(() =>
                {
                    WorkerParseData w = new WorkerParseData(domain);
                    w.StartConsume();
                });
            }
        }

        public static void PushParseFromNoSql(IEnumerable<string> domains)
        {
            NoSqlAdapter noSqlAdapter = NoSqlAdapter.GetInstance();
            foreach (var domain in domains)
            {
                Task.Factory.StartNew(() =>
                {
                    int iCount = 0;
                    var _producerBasicWaitPs = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigStatic.KeyRabbitMqCrlProductProperties), ConfigStatic.GetQueueParse(domain));
                    noSqlAdapter.ProcessAllIdProductByCompany(domain, (obj, productId) =>
                    {
                        iCount++;
                        _producerBasicWaitPs.PublishString(new JobParse()
                        {
                            Id = productId
                        }.GetJson());

                        if (iCount % 10 == 0)
                        {
                            log.Info(string.Format("Pushed {0} mss of {1}", iCount, domain));
                        }
                    });
                    log.Info(string.Format("Pushed all data for company {0} {1}", domain, iCount));
                });
             
            }
            Thread.Sleep(10000000);
        }

        public static void RunDownloadHtml(IEnumerable<string> domains)
        {
            foreach (var domain in domains)
            {
                Task.Factory.StartNew(() =>
                {
                    WorkerDownloadHtml w = new WorkerDownloadHtml(domain);
                    w.StartConsume();
                });
            }

           
        }
    }
}

