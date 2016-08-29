using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.FindProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            FindProxycs findProxycs = new FindProxycs();
            List<string> lstProxy = findProxycs.GetProxy();
            string proxy = QT.Entities.Common.ConvertToString(lstProxy);
            Console.WriteLine(proxy);

            

            Console.ReadLine();
        }
    }
}
