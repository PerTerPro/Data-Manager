using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using QT.Moduls.CrawlerProduct.Service;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Service.Log.LogChangePriceToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new ServiceLogChangePriceToSql() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
