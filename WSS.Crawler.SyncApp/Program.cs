using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Crawler.SyncApp
{
    static class Program
    {
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo("log4net.config")); 
            var w = new Worker();
            w.Start();
        }
    }
}
