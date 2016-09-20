using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmCompanyRunning : Form
    {
        QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler redis = QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.Instance();
        public FrmCompanyRunning()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<QT.Moduls.CrawlerProduct.Cache.CompanyRunning> lstCompany = redis.GetRunningCompany();
            gridControl1.DataSource = lstCompany;
        }

        private void btnHistoryCrawler_Click(object sender, EventArgs e)
        {
            int iRowHandle = this.gridView1.FocusedRowHandle;
            if (iRowHandle >= 0)
            {
                long CompanyID = Convert.ToInt64(this.gridView1.GetRowCellValue(iRowHandle, "Id"));
                FrmHistoryCrawlerByCompany frm = new FrmHistoryCrawlerByCompany(CompanyID);
                frm.ShowDialog();
            }
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.menuCompanyPlus1.Show(this.gridControl1, new Point(e.X, e.Y));
            }
        }

        private void FrmCompanyRunning_Load(object sender, EventArgs e)
        {
            this.menuCompanyPlus1.eventGetCompanyHandle += new MenuCompanyPlus.DelegateGetCompanyID(() =>
            {
                return Convert.ToInt64(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "ID"));
            });
            this.menuCompanyPlus1.Init();
        }
    }
}
