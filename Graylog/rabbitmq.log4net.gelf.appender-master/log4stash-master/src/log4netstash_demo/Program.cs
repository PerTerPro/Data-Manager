using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;

namespace log4netstash_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog log = LogManager.GetLogger(typeof (Program));
            for (int i = 0; i < 1000; i++)
            {
                log.Info(string.Format("Mss {0}", i));
                Thread.Sleep(1000);
            }

        }
    }
}
