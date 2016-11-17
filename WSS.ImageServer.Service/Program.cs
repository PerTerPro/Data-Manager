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

            //Parameter pt = Parameter.FromStr(string.Join(" ", args));
            Console.WriteLine(@"Input location directory: ");
            string strDeirectory = Console.ReadLine();
            HandlerTransferFolder h = new HandlerTransferFolder();
            h.TransferData(strDeirectory);
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
