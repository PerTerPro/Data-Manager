using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.Crawler.Cache.Company
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new CacheCompanyService() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
