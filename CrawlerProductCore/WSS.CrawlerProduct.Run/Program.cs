using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler;
using WorkerFindNew = WSS.Core.Crawler.WorkerFindNew;

namespace WSS.CrawlerProduct.Run
{
    public class Program
    {
        public static CancellationTokenSource Source = new CancellationTokenSource();
        static void Main(string[] args)
        {
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;
            Server.LogConnectionString = ConfigCrawler.ConnectLog;



            //ProductAdapter productAdapter = new ProductAdapter(new SqlDb(ConfigCrawler.ConnectProduct));
            //long companyId = productAdapter.GetCompanyIDFromDomain("hc.com.vn");
            //WorkerFindNew w = new WorkerFindNew(companyId, new CancellationToken(false), "Test");
            //w.StartCrawler();
            //return;

            if (args == null || args.Length == 0)
            {
                Console.WriteLine(@"Input para:");
                var readLine = Console.ReadLine();
                if (readLine != null)
                    args = readLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                Console.WriteLine(string.Join(";", args));
            } var pr = new Parameter();
            pr.ParseData(args);

            Console.CancelKeyPress += EndApp;


            if (pr.TypeRun == 1)
            {
                if (string.IsNullOrEmpty(pr.Domain))
                {
                    for (var i = 0; i < pr.NumberThread; i++)
                    {
                        var token = Source.Token;
                        var j = i;
                        Task.Factory.StartNew(() =>
                        {
                            var consumer = new ConsumerReload(token, j.ToString());
                            consumer.Start();
                        }, token);
                        Thread.Sleep(10000);
                    }}
                else
                {
                    var pt = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                    var token = new CancellationToken();
                    var wokerFn = new WSS.Core.Crawler.WorkerReload(pt.GetCompanyIDFromDomain(pr.Domain), token, "");
                    wokerFn.StartCrawler();
                }
            }
            else if (pr.TypeRun == 0)
            {
                if (string.IsNullOrEmpty(pr.Domain))
                {
                    for (var i = 0; i < pr.NumberThread; i++)
                    {
                        var token = Source.Token;
                        var j = i; Task.Factory.StartNew(() =>
                         {
                             var consumer = new ConsumerFindNew(token, j.ToString());
                             consumer.Start();
                         }, token);
                        Thread.Sleep(10000);
                    }
                }
                else
                {
                    var pt = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                    var token = new CancellationToken();
                    var wokerFn = new WorkerFindNew(pt.GetCompanyIDFromDomain(pr.Domain), token, "");
                    wokerFn.StartCrawler();
                }
            }

            while (true)
            {
                if (Source.IsCancellationRequested)
                {
                    Thread.Sleep(10000);
                    return;
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }

        }

        
        private static void EndApp(object sender, ConsoleCancelEventArgs e)
        {
            Source.Cancel();
            Thread.Sleep(100000);
        }
    }
}
  