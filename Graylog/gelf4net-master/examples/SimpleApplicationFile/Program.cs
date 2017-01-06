using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;

namespace SimpleApplicationFile
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                ILog log = LogManager.GetLogger(typeof (Program));
                log.Info("hehe");
                Thread.Sleep(1000);
            }
        }
    }
}
