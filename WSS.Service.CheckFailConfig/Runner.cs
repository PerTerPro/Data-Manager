using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.Service.CheckFailConfig
{
    public class Runner
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Runner));
        Dictionary<long, QT.Entities.Company> dicCompany = new Dictionary<long, QT.Entities.Company>();

        public Runner ()
        {
        }


        internal void Start(System.Threading.CancellationToken token)
        {
            while (true)
            {
                try
                {
                    QT.Moduls.CrawlerProduct.TaskRefreshCheckConfig task = new QT.Moduls.CrawlerProduct.TaskRefreshCheckConfig();
                    task.Start();
                    Thread.Sleep(100000);
                    log.Info("Wait to 100 s to run next!");
                }
                catch (OperationCanceledException ex02)
                {
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }
    }
}
