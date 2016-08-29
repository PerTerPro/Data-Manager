using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WSS.Service.LogCrawlerProductRabbitToCassandra;

namespace WSS.Service.LogCrawlerProductRabbitToCassandra
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new ServiceLogProductToCassandra() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
