using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GABIZ.Base.HtmlAgilityPack;
using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.Crawler;
using QT.Moduls.CrawlerProduct;using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler;
using WSS.Core.Crawler.CrlProduct;
using WorkerFindNew = WSS.Core.Crawler.WorkerFindNew;

namespace WSS.CrawlerProduct.Run
{
    public class Program
    {
        public static CancellationTokenSource Source = new CancellationTokenSource();
        private static ILog log = log4net.LogManager.GetLogger(typeof (Program));

        private static void Main(string[] args)
        {

            try
            {
                Server.ConnectionString = ConfigCrawler.ConnectProduct;
                Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;
                Server.LogConnectionString = ConfigCrawler.ConnectLog;
                InitQueue isq = new InitQueue();
                isq.Start();

                if (args == null || args.Length == 0)
                {
                    Console.WriteLine(@"Input para:");
                    var readLine = Console.ReadLine();
                    if (readLine != null)
                        args = readLine.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                }
                else
                {
                    Console.WriteLine(string.Join(" ", args));
                }

                var strPara = string.Join(" ", args);
                var pr = new Parameter();
                pr.ParseData(strPara);
                Console.Title = strPara;

                Console.CancelKeyPress += EndApp;
                if (pr.TypeRun == 1)
                {
                    if (string.IsNullOrEmpty(pr.Domain))
                    {
                        for (var i = 0; i < pr.NumberThread; i++)
                        {
                            Task.Factory.StartNew(() =>
                            {
                                var w = new WorkerMqRl(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), pr.QueueMQ, pr.AckIm);
                                w.StartConsume();
                            });
                            Thread.Sleep(2000);
                        }
                    }
                    else
                    {
                        var pt = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                        var token = new CancellationToken();
                        var wokerFn = new WSS.Core.Crawler.WorkerReload(pt.GetCompanyIDFromDomain(pr.Domain), "");
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
                            var j = i;
                            Task.Factory.StartNew(() =>
                            {
                                var w = new WorkerMqFn(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), pr.QueueMQ);
                                w.StartConsume();
                            }, token);
                            Thread.Sleep(2000);
                        }
                    }
                    else
                    {
                        var pt = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                        var token = new CancellationToken();
                        var wokerFn = new WorkerFindNew(pt.GetCompanyIDFromDomain(pr.Domain), "");
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
            catch (Exception ex0)
            {
                log.Error(ex0);
                Console.ReadLine();
            }


        }


        private static void EndApp(object sender, ConsoleCancelEventArgs e)
        {
            Source.Cancel();
            Thread.Sleep(100000);
        }
    }
}
  