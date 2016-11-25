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

namespace  WSS.Crawler.Product.Report
{
    public partial class FrmHistoryCrawlerByCompany : Form
    {
        SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);
        private long CompanyID = 0;

        public FrmHistoryCrawlerByCompany()
        {
            InitializeComponent();
        }

        public FrmHistoryCrawlerByCompany(long CompanyID)
        {
            InitializeComponent();
            this.CompanyID = CompanyID;
        }

        private void FrmHistoryCrawler_Load(object sender, EventArgs e)
        {
            this.menuCompanyPlus1.eventGetSession += new MenuCompanyPlus.DelegateGetSession(GetSessionCurrent);
            this.menuCompanyPlus1.Init();
            this.RefreshData();
            this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
        }

        private string GetSessionCurrent()
        {
            return this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Session").ToString();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int iRowHandle = this.gridView1.FocusedRowHandle;
            if (iRowHandle >= 0){
                string Session = QT.Entities.Common.Obj2String(this.gridView1.GetRowCellValue(iRowHandle, "Session"));
                FrmViewDetailSessionRL frm = new FrmViewDetailSessionRL(Session);
                frm.ShowDialog();
            }
        }

        private void ReloadCompany()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void RefreshData()
        {
            this.gridControl1.DataSource = this.sqlDb.GetTblData("prc_Company_HistoryCrawlerByCompany", CommandType.StoredProcedure, new System.Data.SqlClient.SqlParameter[]{
                SqlDb.CreateParamteterSQL("@CompanyID",Convert.ToInt64(this.CompanyID),SqlDbType.BigInt)
            });
            gridView1.Columns["EndAt"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void viewDetailSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iRowHandle = this.gridView1.FocusedRowHandle;
            if (iRowHandle >= 0)
            {
                string Session = QT.Entities.Common.Obj2String(this.gridView1.GetRowCellValue(iRowHandle, "Session"));
                FrmViewDetailSessionRL frm = new FrmViewDetailSessionRL(Session);
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

        private void gridControl1_Click(object sender, EventArgs e)
        {
        }

        private void btnViewSessionFindNew_Click(object sender, EventArgs e)
        {
            int iRowHandle = this.gridView1.FocusedRowHandle;
            if (iRowHandle >= 0)
            {
                string Session = QT.Entities.Common.Obj2String(this.gridView1.GetRowCellValue(iRowHandle, "Session"));
                FrmViewDetailSessionFN frm = new FrmViewDetailSessionFN(Session);
                frm.ShowDialog();
            }
        }
    }
}
