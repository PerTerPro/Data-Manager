using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WSS.UpdateDataFeedService
{
    static class Program
    {
        static void Main()
        {
            ServiceBase[] servicesToRun;
            servicesToRun = new ServiceBase[]
            {
                new UpdateDatafeed()
            };
            ServiceBase.Run(servicesToRun);
        }
    }
}
