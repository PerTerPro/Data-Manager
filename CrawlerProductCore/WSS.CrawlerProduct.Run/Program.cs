using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.Crawler;
using QT.Moduls.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler;
using WorkerFindNew = WSS.Core.Crawler.WorkerFindNew;

namespace WSS.CrawlerProduct.Run
{
    public class Program
    {
        public static CancellationTokenSource Source = new CancellationTokenSource();
        static void Main(string[] args){
            Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Server.ConnectionStringCrawler = ConfigCrawler.ConnectionCrawler;Server.LogConnectionString = ConfigCrawler.ConnectLog;



            //ProductAdapter productAdapter = new ProductAdapter(new SqlDb(ConfigCrawler.ConnectProduct));
            //long companyId = productAdapter.GetCompanyIDFromDomain("hc.com.vn");

            //WSS.Core.Crawler.WorkerReload w1 = new WSS.Core.Crawler.WorkerReload(companyId, new CancellationToken(),
            //    "Test");
            //   w1.StartCrawler();

            //string url = @"https://www.trananh.vn/noi-com-dien/noi-com-dien-tu-shap-da-chuc-nang-ks-com19v-1-8l-pid24086cid1081";
            //ProductParse pp = new ProductParse();
            //ProductEntity pe = new ProductEntity();
            //IDownloadHtml idownloadHtm = new DownloadHtmlCrawler();
            //WebExceptionStatus ws = new WebExceptionStatus();
            //var html = idownloadHtm.GetHTML(url, 45, 2, out ws);
            //Uri uri = new Uri(url);HtmlDocument htmlDocument = new HtmlDocument();
            //htmlDocument.LoadHtml(html);
            //pp.Analytics(pe,htmlDocument,url, new Configuration(7627466712688617332,true),"trananh.vn"); 
            //return;

            //WorkerFindNew w = new WorkerFindNew(companyId, new CancellationToken(false), "Test");
            //w.StartCrawler();
            
            
            //return;

            if (args == null || args.Length == 0)
            {
                Console.WriteLine(@"Input para:");
                var readLine = Console.ReadLine();
                if (readLine != null)
                    args = readLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }else
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
  