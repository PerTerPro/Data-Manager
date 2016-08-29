using log4net;
using System;
using System.Threading;

namespace SimpleConsoleApplication
{
    class Program
    {
        protected static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
          

            log4net.Config.XmlConfigurator.Configure();
            Console.WriteLine("SqlDb Write a sentence, q to quit");

            TestStream();


            int countData = 0;
            while (true)
            {
                countData++;
                string text = "test";
                log.Debug(String.Format("Message: {0}. TimeRun: {1}", countData, DateTime.Now.ToString("yyy-MM-dd")));
                Thread.Sleep(100);
            }
        }

        public static void TestStream()
        {
            int iCOunt = 0;
            while (true)
            {
                iCOunt++;
                log.Error(string.Format("Exception at SqlDb excute command. Count:{0}", iCOunt));
                log.Debug(string.Format("Exception at SqlDb excute command. Count:{0}", iCOunt));
            }
        }
    }
}
