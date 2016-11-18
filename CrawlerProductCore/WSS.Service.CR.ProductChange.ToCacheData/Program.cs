using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WSS.Core.Crawler;

namespace WSS.Service.CR.ProductChange.ToCacheData
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            QT.Entities.Server.ConnectionString = ConfigCrawler.ConnectProduct;
            var servicesToRun = new ServiceBase[] 
            { 
                new ServiceProductChangeToCache() 
            };
            ServiceBase.Run(servicesToRun);
        }
    }
}
