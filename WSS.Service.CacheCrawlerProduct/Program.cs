using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.Crawler.Cache.Product
{
    class Program
    {
        static void Main(string[] args)
        {
        
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new ServiceCacheProduct() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
