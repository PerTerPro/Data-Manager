using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.LogCrawlerProduct.LogProductToCassandra_FindNew
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new ServiceLogProductCassandraFindNew() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
