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
    public partial class FrmHistoryCrawlerForCompany : Form
    {
        public FrmHistoryCrawlerForCompany()
        {
            InitializeComponent();
        }
        public FrmHistoryCrawlerForCompany(long Company)
        {
            InitializeComponent();

            ReloadData(Company);
        }

        private void FrmHistoryCrawlerForCompany_Load(object sender, EventArgs e)
        {

        }

        public void ReloadData (long CompanyID )
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            this.gridControl1.DataSource = productAdapter.GetReportCrawlerHistory(CompanyID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
