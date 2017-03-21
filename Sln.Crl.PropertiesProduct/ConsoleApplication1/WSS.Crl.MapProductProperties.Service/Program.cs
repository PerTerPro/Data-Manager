using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.MapProductProperties.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"


-c worker_map_product -dm adayroi.com 
-c worker_parse_product -dm adayroi.com #Worker parse product properties 
-c worker_download_html   -dm adayroi.com #Worker donwload html for adayroi.com

-c updcatid 
-c FattenData
");
        }
    }
}
