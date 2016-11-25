using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.Crl.ProducProperties.Service
{
    class Program
    {
        private static void Main(string[] args)
        {
           

            //-c crl_html -t 1
            Console.WriteLine(@"
-c psdl -dm adayroi.com #Push Link To Download Html AS
-c wprpd -dm adayroi.com #Worker parse product properties 
-c wdl   -dm adayroi.com #Worker donwload html for adayroi.com
");
            string str = string.Join(" ", args);

           // str = "-c wprpd -dm adayroi.com";
            if (string.IsNullOrEmpty(str)) str = Console.ReadLine();
            Parameter pt = new Parameter(str);
            if (pt.cmd == "psdl")
            {
                ServiceCrl.PushDownloadHtml(pt.domains);
            }
            else if (pt.cmd == "wprpd")
            {
                ServiceCrl.RunWorkerParse(pt.domains);
            }
            else if (pt.cmd == "wdl")
            {
                ServiceCrl.RunDownloadHtml(pt.domains);
            }

          Thread.Sleep(1000000);


         
            
        }
    }
}
