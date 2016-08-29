using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.Service.CheckFailConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            QT.Entities.Server.ConnectionString = @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
            QT.Entities.Server.LogConnectionString = @"Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
            QT.Entities.Server.ConnectionStringCrawler = @"Data Source=172.22.30.82,1452;Initial Catalog=QTCrawler;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new ServiceCheckFailConfig() 
            };
            ServiceBase.Run(ServicesToRun);
        }


    }
}
