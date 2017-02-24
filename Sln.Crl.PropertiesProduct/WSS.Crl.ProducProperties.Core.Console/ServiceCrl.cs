using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Crl.ProducProperties.Core;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Worker;
using WSS.LibExtra;

namespace WSS.Crl.ProducProperties.Service
{
    public static class ServiceCrl
    {
        private static ILog log = LogManager.GetLogger(typeof (ServiceCrl));
         

        public static void PushDownloadHtml(IEnumerable<string> domains)
        {

          

        }

        

        public static void PushParseFromNoSql(IEnumerable<string> domains)
        {
            NoSqlAdapter noSqlAdapter = NoSqlAdapter.GetInstance();
            foreach (var domain in domains)
            {
                Task.Factory.StartNew(() =>
                {
                    int iCount = 0;
                    var producerBasicWaitPs = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigStatic.KeyRabbitMqCrlProductProperties), ConfigStatic.GetQueueParse(domain));
                    noSqlAdapter.ProcessAllIdProductByCompany(domain, (obj, productId) =>
                    {
                        iCount++;
                        producerBasicWaitPs.PublishString(new JobParse()
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

