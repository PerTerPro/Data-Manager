using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmPushProduct : Form
    {public FrmPushProduct()
        {
            InitializeComponent();
        }
        private void btnPushDownloadImage_Click(object sender, EventArgs e)
        {
            List<long> lstProductId =
                richTextBox1.Text.Split(new char[] {'\n', ',', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(Int64.Parse).ToList();
            var pa = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
          
            MessageBox.Show(string.Format("Pushed {0} mss", lstProductId.Count));
        }
    }
}
