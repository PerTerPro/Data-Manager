using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.SaleNew.Manager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WSS.CrawlerProduct.ManagerConnectStatic.ManagerConnect.Instance().LoadConfigFromConfigFile();
            Application.Run(new QT.Moduls.CrawlSale.FrmMainSale());
        }
    }
}
