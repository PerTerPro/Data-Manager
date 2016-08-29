using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSS.Core.Crawler;

namespace  WSS.Crawler.Product.Report
{
    class Program
    {
      
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
        [STAThread]
        static void Main()
        {
            QT.Entities.Server.ConnectionString = ConfigCrawler.ConnectProduct;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
        
    }
}
