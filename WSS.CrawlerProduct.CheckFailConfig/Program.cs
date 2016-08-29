using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.CrawlerProduct.CheckFailConfig
{
    class Program
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        string ConnectionString = @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
            Console.ReadLine();
        }

        private void Run()
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    try
                    {
                        QT.Moduls.CrawlerProduct.TaskRefreshCheckConfig task = new QT.Moduls.CrawlerProduct.TaskRefreshCheckConfig()
                        {
                            connectionString = this.ConnectionString
                        };
                        task.Start();
                        Thread.Sleep(100000);
                        log.Info("Wait to 100 s to run next!");
                    }
                    catch (Exception ex01)
                    {
                        log.Error(ex01);
                        Thread.Sleep(100000);
                    }
                }
            });
        }
    }
}
