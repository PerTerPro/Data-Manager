using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisualStudioExpert
{
    class Program
    {
        static void Main(string[] args)
        {
           //Thread Test Visual

            Thread.CurrentThread.Name = "Main thread";

            Thread t1 = new Thread(new ThreadStart(Run));
            t1.Name = "Thread1";

            Thread t2 = new Thread(new ThreadStart(Run));
            t2.Name = "Thread2";

            Thread t3 = new Thread(new ThreadStart(Run));
            t3.Name = "Thread3";

            t1.Start();
            t2.Start();
            t3.Start();

            Run();
        }

        private static void Run()
        {
            Console.WriteLine("hello {0}", Thread.CurrentThread.Name);
            Thread.Sleep(10000);
        }
    }
}
