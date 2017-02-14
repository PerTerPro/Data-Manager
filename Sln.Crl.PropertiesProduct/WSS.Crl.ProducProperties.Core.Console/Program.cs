using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WSS.Crl.ProducProperties.Core;
using WSS.Crl.ProducProperties.Core.Service;

namespace WSS.Crl.ProducProperties.Service
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           

            //-c crl_html -t 1
            Console.WriteLine(@"


-c push_download_html -dm adayroi.com 
-c worker_parse_product -dm adayroi.com #Worker parse product properties 
-c worker_download_html   -dm adayroi.com #Worker donwload html for adayroi.com

-c updcatid 
-c FattenData
");
            string str = string.Join(" ", args);

            // str = "-c wprpd -dm adayroi.com";
            if (string.IsNullOrEmpty(str)) str = Console.ReadLine();

            Parameter pt = new Parameter(str);
            if (pt.cmd == "push_download_html")
            {
                ServiceRun.PushJobDownload(pt.domains);
            }
            else if (pt.cmd == "worker_parse_product"){
                ServiceRun.RunWorkerParse(pt.domains);
            }
            else if (pt.cmd == "worker_download_html")
            {
                ServiceRun.DownLoadHtml(pt.domains);
            }
            else if (pt.cmd == "re_push_parse_from_cas")
            {
                ServiceCrl.PushParseFromNoSql(pt.domains);
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
            else if (pt.cmd == "worker_map_product")
            {
                ServiceRun.MapProductToSql(pt.domains);
            }
            Thread.Sleep(1000000);
        }
    }
}
