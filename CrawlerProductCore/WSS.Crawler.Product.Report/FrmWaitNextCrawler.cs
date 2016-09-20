using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QT.Moduls.CrawlerProduct.Cache;
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

namespace  WSS.Crawler.Product.Report
{
    public partial class FrmWaitNextCrawler : Form
    {
        QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler redisCompanyWaitCrawler = QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.Instance();

        public FrmWaitNextCrawler()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshReloadData();
        }

        private void RefreshReloadData()
        {
            try
            {
                this.gridControl1.DataSource = redisCompanyWaitCrawler.GetWaitingCrawlerReload(ckOnlyWait.Checked,20000);
            }
            catch (Exception ex01)
            {
                MessageBox.Show(ex01.Message);}
        }

        private void RefreshFindNewData()
        {
            try
            {
                this.gridControl1.DataSource = redisCompanyWaitCrawler.GetWaitingCrawlerFindNew(ckOnlyWait.Checked,20000);
            }
            catch (Exception ex01)
            {
                MessageBox.Show(ex01.Message);
            }
        }


        private void FrmWaitNextCrawler_Load(object sender, EventArgs e)
        {
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(gridView1_CustomDrawCell);
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(EventGroup);

            this.menuCompanyPlus1.eventGetCompanyHandle += new MenuCompanyPlus.DelegateGetCompanyID(() =>
            {
                return Convert.ToInt64(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "CompanyID"));
            });

            this.menuCompanyPlus1.eventGetCompanys += new MenuCompanyPlus.DelegateGetCompanys(() =>
            {
                List<long> lstCompanyIds = new List<long>();
                foreach (var iRow in gridView1.GetSelectedRows())
                {
                    lstCompanyIds.Add(Convert.ToInt64(this.gridView1.GetRowCellValue(iRow, "CompanyID")));
                }
                return lstCompanyIds;
            });
            this.menuCompanyPlus1.Init();
        }

        private void EventGroup(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            string caption = info.Column.Caption;
            if (info.Column.Caption == string.Empty)
                caption = info.Column.ToString();
            info.GroupText = string.Format("{0} : {1} (count= {2})", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle));
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "Index")
            {
                e.DisplayText = e.RowHandle.ToString();
            }
        }

        private void btnHistoryCrawler_Click(object sender, EventArgs e)
        {
            int iRowHandle = this.gridView1.FocusedRowHandle;
            if (iRowHandle >= 0)
            {
                long CompanyID = Convert.ToInt64(this.gridView1.GetRowCellValue(iRowHandle, "CompanyID"));
                FrmHistoryCrawlerByCompany frm = new FrmHistoryCrawlerByCompany(CompanyID);
                frm.ShowDialog();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmSetNextCrawler frm = new FrmSetNextCrawler();
            frm.Show();
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==System.Windows.Forms.MouseButtons.Right){
                this.menuCompanyPlus1.Show(this.gridControl1, new Point(e.X, e.Y));
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshFindNewData();
        }

        private void updateAllowReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<CompanyWait> lst = this.gridControl1.DataSource as List<CompanyWait>;
            List<long> lstCompanyId = new List<long>();
            foreach (var VARIABLE in lst)
            {
                lstCompanyId.Add(VARIABLE.CompanyID);
            }
            string query = string.Format("update configuration set AllowReload = 1 where companyId in ({0})",
                string.Join(",", lstCompanyId));
            MessageBox.Show(query);
        }

        private void updateAllowFindNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<CompanyWait> lst = this.gridControl1.DataSource as List<CompanyWait>;
            List<long> lstCompanyId = new List<long>();
            foreach (var VARIABLE in lst)
            {
                lstCompanyId.Add(VARIABLE.CompanyID);
            }
            string query = string.Format("update configuration set AllowFindNew = 1 where companyId in ({0})",
                string.Join(",", lstCompanyId));
            MessageBox.Show(query);
        }

    }
}
