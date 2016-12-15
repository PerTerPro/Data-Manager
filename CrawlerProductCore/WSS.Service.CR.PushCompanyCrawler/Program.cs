using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using WSS.Core.Crawler.CrlProduct;

namespace WSS.Service.CR.PushCompanyCrawler
{
    static class Program
    {
        private static ILog log = LogManager.GetLogger(typeof (Program));
        static void Main()
        {
            while (true)
            {
                log.Info(string.Format("Start push at {0}",DateTime.Now.ToString("yyyy-MM-dd")));
                ControlCmpCrlw.PushCmp();
                log.Info("Wait 10' to next");
                Thread.Sleep(60000*5);
            }

            return;
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new Service1() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
