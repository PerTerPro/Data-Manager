using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleConsoleApplication
{
    internal class Program
    {
        protected static readonly ILog log = LogManager.GetLogger(typeof (Program));

        private static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            Console.WriteLine("Write a sentence, q to quit");
            var text = Console.ReadLine();
            for (int i = 0; i < 1000000; i++)
            {
                log.Debug(String.Format("hahaha: {0}", i));
                Console.WriteLine("Sent {0}", text);
                Thread.Sleep(500);
            }
        }
    }
}
