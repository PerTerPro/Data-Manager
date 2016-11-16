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

            for (int i = 0; i < 5; i++)
            {
                Task.Factory.StartNew(() =>
                {
                    WorkerUpImgToServer w = new WorkerUpImgToServer();
                    w.StartConsume();
                });
            }
            Thread.Sleep(100000);
            return;

            Parameter pt = null;
            switch (pt.Cmd)
            {
                case "p_cpn_transf":
                {
                    
                }
                    break;
                case "w_phc_tranf":
                {
                    
                }
                    break;

            }

        }
    }
}
