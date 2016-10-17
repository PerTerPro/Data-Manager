using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ImboForm
{
    public class Tester
    {
        private int icount = 0 ;
        private ILog log = log4net.LogManager.GetLogger(typeof (Tester));
        public void Test1()
        {
            for (int i = 0; i < 1
                ; i++)
            {
                Task.Factory.StartNew(() =>
                {
                    DateTime dtStart = DateTime.Now;
                     icount = 0;
                    while (true)
                    {
                        if (icount % 100 == 0)
                            log.Info(string.Format("=================> {0} {1}", icount,
                                (DateTime.Now - dtStart).TotalMilliseconds));
                        icount++;
                        HandlerJob h = new HandlerJob();
                        var x = new MssReport()
                        {
                            PathImage = "0/0919888989_com/bas/baseus-micro-otg-adapter_8512320182528052693.jpg",
                        };
                        h.ProcessJob(ref x);
                    }
                });
            }
        }
    }
}
