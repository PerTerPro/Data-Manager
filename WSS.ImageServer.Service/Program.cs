﻿using System;
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
                pt=Parameter.FromStr(string.Join(" ", args));
            }

            if (pt.Cmd == "PushImgLocalToImbo")
            {
                HandlerTransferFolder h = new HandlerTransferFolder();
                h.TransferData(pt.Directory);
            }
            else if (pt.Cmd == "DelImgPushedImbo")
            {
                WorkerDelFileLocal w = new WorkerDelFileLocal(pt.Directory);
                w.StartConsume();

            }
            else if(pt.Cmd=="DelImgImbo")
            {
                WorkerDelImgImbo w = new WorkerDelImgImbo();
                w.StartConsume();
            }
            else if (pt.Cmd=="ProductImgIdToSql")
            {
                WorkerImgIdToSql w = new WorkerImgIdToSql();
                w.StartConsume();
            }

            else i
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
