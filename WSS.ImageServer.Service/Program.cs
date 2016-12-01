using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ImboForm;

namespace WSS.ImageServer.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            //args = new[] {"-cmd UdpImgIdToSql"};
            //args = new[] {"-cmd DelImgImbo"};\
            //args = new[] {"-cmd PushImgCompany"};
            //args = new[] {"-cmd ImgCallThumb"};
             args = new[] { "-cmd PushRootProductWaitTrans" };
            //args = new[] { "-cmd UdpImgIdToSql" };
            
            string strDeirectory = "";
            Parameter pt = null;
            
            if (args.Length == 0)
            {
                Console.WriteLine(@"Input location directory: ");
                strDeirectory = Console.ReadLine();
                pt=Parameter.FromStr(strDeirectory);
            }
            else
            {
                pt = Parameter.FromStr(string.Join(" ", args));

            }

            if (pt.Cmd == "PushImgLocalToImbo")
            {
                HandlerTransferFolder h = new HandlerTransferFolder();
                h.TransferData(pt.Directory);
            }
            else if (pt.Cmd == "PushRootProductWaitTrans")
            {
                HandlerTransRootProduct h = new HandlerTransRootProduct();
                h.PushRootProduct();
            }
            else if (pt.Cmd == "DownloadRootProduct")
            {
                WorkerDownloadRootProduct w = new WorkerDownloadRootProduct();
                w.StartConsume();
            }
            else if (pt.Cmd == "PushImgCompany")
            {
                HandlerTransferLogoCompany f = new HandlerTransferLogoCompany();
                f.Start();
            }
            else if (pt.Cmd == "RePushThumb")
            {
                HandlerTransferFolder.RePushThumb();
            }
            else if (pt.Cmd == "DelImgLocalPushedImbo")
            {
                WorkerDelFileLocal w = new WorkerDelFileLocal(pt.Directory);
                w.StartConsume();

            }
            else if (pt.Cmd == "DelImgImbo")
            {
                WorkerDelImgImbo w = new WorkerDelImgImbo();
                w.StartConsume();
            }
            else if (pt.Cmd == "UdpImgIdToSql")
            {
                WorkerImgIdToSql w = new WorkerImgIdToSql();
                w.StartConsume();
            }
            else if (pt.Cmd == "PushProductIdCurrentToRedis")
            {
                ImageAdapterSql img = new ImageAdapterSql();
                img.ProcessAddProduct();
            }
            else if (pt.Cmd == "ImgCallThumb")
            {
                WorkerThumbImg w = new WorkerThumbImg();
                w.StartConsume();
            }

            return;


            //switch (pt.Cmd)
            //{
            //    case "p_cpn_transf":
            //    {
                    
            //    } break;
            //    case "w_phc_tranf":
            //    {
                    
            //    }
            //        break;
            //    case "upbylocal":
            //    {
                    
            //    }
            //        break;
            //}

        }
    }
}
