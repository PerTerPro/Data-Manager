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
    internal static class Program
    {
        private static ILog log = LogManager.GetLogger(typeof(Program));
        private static void Main(){
            log.Info("Start app");
            while (true)
            {
                log.Info("Start push company");
                ControlCmpCrlw.PushCmp();
                log.Debug("Wait 10' to next");
                Thread.Sleep(60000 * 5);
            }

            return; ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
