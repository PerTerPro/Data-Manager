using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using QT.Entities.Data;
using QT.Moduls;
using QT.Moduls.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Crl.ProducProperties.Core;

namespace WSS.Crl.ProducProperties.Service
{
    public static class ServiceCrl
    {
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

