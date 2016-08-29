using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Service.Crawler.Consumer.FindNew
{
    static class Program
    {

        static log4net.ILog log = null;
        static CancellationTokenSource cancell = new CancellationTokenSource();
        static void Main(string[] argument)
        {

            log4net.Config.XmlConfigurator.Configure(new FileInfo("log4net.config")); 
            log = log4net.LogManager.GetLogger(typeof(Program));

             log.Info(string.Format("IP:{0}", QT.Entities.Server.IPHost));
            QT.Entities.Server.ConnectionString = @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
            QT.Entities.Server.LogConnectionString = @"Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
            QT.Entities.Server.ConnectionStringCrawler = @"Data Source=172.22.30.82,1452;Initial Catalog=QTCrawler;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
            int typeRun = 0;
            int numberThread = 1;

            if (argument != null && argument.Length>0)
            {
                string strAllArgument = string.Join(" ", argument);
                log.Info("Argument:" + strAllArgument);
                string[] argumentData = strAllArgument.Split(new char[] { '\n', ';', ' ' });
                typeRun = Convert.ToInt32(argumentData[0]);
                numberThread = Convert.ToInt32(argumentData[1]);
            }
            else
            {
                log.Info("Not parameter");Console.Write("FindNew:0. Reload:1. TypeRun:");
                typeRun = Convert.ToInt32(Console.ReadLine());
                Console.Write("NumberThread:");
                numberThread = Convert.ToInt32(Console.ReadLine());
            }
            
            Runner runner = new Runner(numberThread, cancell, typeRun);
            runner.Start();

            Console.CancelKeyPress += new ConsoleCancelEventHandler(CancelEvent);
            Console.ReadLine();
        }

        private static void CancelEvent(object sender, ConsoleCancelEventArgs e)
        {
            cancell.Cancel();
            Thread.Sleep(10000);
        }
    }
}
