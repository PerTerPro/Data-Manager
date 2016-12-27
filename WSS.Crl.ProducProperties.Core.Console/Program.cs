using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WSS.Crl.ProducProperties.Core;

namespace WSS.Crl.ProducProperties.Service
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            QT.Entities.Server.ConnectionString = ConfigurationManager.AppSettings["ConnectionProduct"];

            //-c crl_html -t 1
            Console.WriteLine(@"

-c psdl -dm adayroi.com #Push Link To Download Html AS
-c wprpd -dm adayroi.com #Worker parse product properties 
-c wdl   -dm adayroi.com #Worker donwload html for adayroi.com
-c updcatid 
-c FattenData
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
            else if (pt.cmd == "updcatid")
            {
                MongoAdapter m = MongoAdapter.Instance();
                m.UpdateCategoryId();
            }
            else if (pt.cmd == "FattenData")
            {
                MongoAdapter m = MongoAdapter.Instance();
                m.FattenData();
            }
            Thread.Sleep(1000000);




        }
    }
}
