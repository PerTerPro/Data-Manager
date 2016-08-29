using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSS.CrawlerSale.Manager;

namespace WSS.SaleNew.Consumer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WSS.CrawlerProduct.ManagerConnectStatic.ManagerConnect.Instance().LoadConfigFromConfigFile();
            Application.Run(new FrmControlConsumer());
        }
    }
}
