using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WSS.GoogleCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> keywords = new List<string>()
            {
                "kế toán"
            };

            HandlerData h = new HandlerData();
            var hs = h.GetListSite(keywords);

            Console.Write(hs.Count);
        }
    }
}
