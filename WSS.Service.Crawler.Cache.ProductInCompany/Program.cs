using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.Crawler.Cache.ProductInCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker();
            w.Run();
            Console.ReadLine();
        }
        public void Run()
        {
         
        }
    }
}
