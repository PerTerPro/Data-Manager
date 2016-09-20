using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QT.Entities;
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

namespace WSS.Crawler.Product.Report
{
    public partial class FrmTrackCrawlerAllCompany : Form
    {
        SqlDb sqlDb = new SqlDb(Server.ConnectionString);

        public FrmTrackCrawlerAllCompany()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void FrmTrackCrawlerAllCompany_Load(object sender, EventArgs e)
        {
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(EventGroup);
            this.RefreshData();

            this.menuCompanyPlus1.eventGetCompanyHandle += new MenuCompanyPlus.DelegateGetCompanyID(GetCompanyHandle);
            this.menuCompanyPlus1.eventGetCompanys += new MenuCompanyPlus.DelegateGetCompanys(GetCompanySelected);
            this.menuCompanyPlus1.eventGetSession += new MenuCompanyPlus.DelegateGetSession(GetSession);
            this.menuCompanyPlus1.Init();
        }

        private string GetSession()
        {
            return this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Session").ToString();
        }

        private List<long> GetCompanySelected()
        {
            List<long> lst = new List<long>();
            foreach (int iRow in this.gridView1.GetSelectedRows())
            {
                lst.Add(Convert.ToInt64(this.gridView1.GetRowCellValue(iRow, "CompanyID")));
            }
            return lst;
        }

        private long GetCompanyHandle()
        {
            return Convert.ToInt64(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "CompanyID"));
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void RefreshData()
        {
            this.gridControl1.DataSource = sqlDb.GetTblData(@"
       
       SELECT 
       TOP (@NumberItem)
       [ID]
      ,[CompanyID]
      ,[TypeCrawler]
      ,[StartAt]
      ,[EndAt]
      ,[CountLink]
      ,[CountVisited]
      ,[CountProduct]
      ,[CountChange]
      ,[Session]
      ,[TotalProduct]
	  , CONVERT(nvarchar(50), EndAt, 102) AS DateCrawler
      , DateDiff(minute,StartAt, a.EndAt) as TimeRun
      , IP
      , Domain
      , a.TypeEnd
      , a.NumberDuplicates
  FROM [QT_2].[dbo].[Company_TrackCrawler] a
  WHERE a.TotalProduct>0
  ORDER BY EndAt DESC
", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { 
 SqlDb.CreateParamteterSQL("@NumberItem",(ckAll.Checked==true)?100000:50000,SqlDbType.Int)
 });
        }

        private void btnViewSession_Click(object sender, EventArgs e)
        {
            int iRowHandle = this.gridView1.FocusedRowHandle;
            if (iRowHandle >= 0)
            {
                string Session = Common.Obj2String(this.gridView1.GetRowCellValue(iRowHandle, "Session"));
                FrmViewDetailSessionRL frm = new FrmViewDetailSessionRL(Session);
                frm.ShowDialog();
            }
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                menuCompanyPlus1.Show(this.gridControl1, new Point(e.X, e.Y));
            }
        }

        private void btnViewSessionFN_Click(object sender, EventArgs e)
        {
            int iRowHandle = this.gridView1.FocusedRowHandle;
            if (iRowHandle >= 0)
            {
                string Session = Common.Obj2String(this.gridView1.GetRowCellValue(iRowHandle, "Session"));
                FrmViewDetailSessionFN frm = new FrmViewDetailSessionFN(Session);
                frm.ShowDialog();
            }
        }

        private void viewProductInDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iRowHandle = this.gridView1.FocusedRowHandle;
            if (iRowHandle >= 0)
            {
                long CompanyID = Convert.ToInt64(this.gridView1.GetRowCellValue(iRowHandle, "CompanyID"));
                FrmViewProductInDb frm = new FrmViewProductInDb(CompanyID);
                frm.ShowDialog();
            }
        }

        private void viewProductInCacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iRowHandle = this.gridView1.FocusedRowHandle;
            if (iRowHandle >= 0)
            {
                long CompanyID = Convert.ToInt64(this.gridView1.GetRowCellValue(iRowHandle, "CompanyID"));
                FrmViewProductInCache frm = new FrmViewProductInCache(CompanyID);
                frm.ShowDialog();
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
        private void btnLastCrawler_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = sqlDb.GetTblData("prc_Company_TrackCrawler_LastRun",
                CommandType.StoredProcedure, null);}
    }
}
