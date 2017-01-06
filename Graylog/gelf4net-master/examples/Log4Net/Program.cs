using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;

namespace Log4Net
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog log = LogManager.GetLogger(typeof (Program));
            for (int i = 0; i < 10000; i++)
            {
                log.Info(string.Format("Log data {0}", i));
                Thread.Sleep(200);
            }
        }
    }
}
