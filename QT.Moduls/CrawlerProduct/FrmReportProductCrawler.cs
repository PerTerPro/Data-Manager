using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmReportProductCrawler : Form
    {
        SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);

        public FrmReportProductCrawler()
        {
            InitializeComponent();
        }

        private void btnFN_Click(object sender, EventArgs e)
        {
            
        }
    }
}
