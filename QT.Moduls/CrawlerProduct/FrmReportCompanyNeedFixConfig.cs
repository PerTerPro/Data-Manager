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
    public partial class FrmReportCompanyNeedFixConfig : Form
    {
        public FrmReportCompanyNeedFixConfig()
        {
            InitializeComponent();
        }

        private void FrmReportCompanyNeedFixConfig_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void RefreshData()
        {
            SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
            this.gridControl1.DataSource = sqldb.GetTblData("prc_Report_ReloadCrawlerNeedFix", CommandType.StoredProcedure, null, null, false);
            this.gridView1.RefreshData();
        }
    }
}
