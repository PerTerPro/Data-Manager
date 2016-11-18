using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QT.Entities;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler;

namespace WSS.CrawlerProduct
{
    class Program
    {

        private  static readonly CancellationTokenSource CancellationTokenSource=new CancellationTokenSource();
        static void Main(string[] args)
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.LogConnectionString = ConfigCrawler.ConnectLog;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;
            var companyId = 480254425312154563;
            CancellationToken token1 = new CancellationToken();
            WorkerFindNew wokerFn = new WorkerFindNew(companyId, token1,"");
            wokerFn.StartCrawler();
            return;

            Console.CancelKeyPress += EndApp;
            Parameter pt = new Parameter();
            QT.Entities.Server.ConnectionString =
               @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
            QT.Entities.Server.LogConnectionString =
                @"Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
            QT.Entities.Server.ConnectionStringCrawler =
                @"Data Source=172.22.30.82,1452;Initial Catalog=QTCrawler;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
            var rabbitMqServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            for (var i = 0; i < pt.NumberThread; i++)
            {
                var token = CancellationTokenSource.Token;
                var j = i;
                Task.Factory.StartNew(() =>
                {
                    var consumerFindNew = new ConsumerFindNew(rabbitMqServer, "CompanyWaitCrawlerFindNew", token);
                    consumerFindNew.Start();
                }, token);
            }
            while (true)
            {
                Console.Read();
            }
        }

        private static void EndApp(object sender, ConsoleCancelEventArgs e)
        {
            CancellationTokenSource.Cancel();
            Thread.Sleep(10000);
        }
    }
}
