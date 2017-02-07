using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
using DevExpress.XtraGrid.Views.Base;
using QT.Moduls.CompanyXPath;
using QT.Moduls.CrawlerProduct;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmCompany : Form
    {
        SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        public FrmCompany()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void FrmCompany_KeyDown(object sender, KeyEventArgs e)
        {
            long companyId = Convert.ToInt64(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "id"));
            if (e.KeyCode == System.Windows.Forms.Keys.F6)
            {
                FrmShowDetailProduct.ShowProduct(companyId)
                ;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveData()
        {
            int countData = 0;
            DataTable tbl = this.gridControl1.DataSource as DataTable;
            DataTable companyChanged = tbl.GetChanges();
            if (companyChanged != null)
                foreach (DataRow rowInfo in companyChanged.Rows)
                {
                    this.sqldb.RunQuery(
                        @"update configuration 
set MinHourReload=@MinHourReload, MinHourFindNew=@MinHourFindNew, NumberThreadCrawler = @NumberThreadCrawler
, AllowFindNew = @AllowFindNew, AllowReload = @AllowReload 
, Website_SourceType = @Website_SourceType
, MaxHourFindNew = @MaxHourFindNew
, MaxLinksFindNew = @MaxLinksFindNew
, TimeDelay = @TimeDelay
, AllowAutoCheckPrice = @AllowAutoCheckPrice
, MaxProductToWarning = @MaxProductToWarning
, MinProductToWarning = @MinProductToWarning
, MaxDeep = @MaxDeep
, LimitProductValid = @LimitProductValid
                    where id = @configuration_id",
                        CommandType.Text, new System.Data.SqlClient.SqlParameter[]
                        {
                            SqlDb.CreateParamteterSQL("@MinHourReload", Convert.ToInt32(rowInfo["MinHourReload"]),
                                SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@MinHourFindNew", Convert.ToInt32(rowInfo["MinHourFindNew"]),
                                SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@configuration_id", Convert.ToInt32(rowInfo["configuration_id"]),
                                SqlDbType.BigInt),
                            SqlDb.CreateParamteterSQL("@NumberThreadCrawler",
                                Convert.ToInt32(rowInfo["NumberThreadCrawler"]), SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@AllowFindNew", Convert.ToInt32(rowInfo["AllowFindNew"]),
                                SqlDbType.BigInt),
                            SqlDb.CreateParamteterSQL("@AllowReload", Convert.ToInt32(rowInfo["AllowReload"]),
                                SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@Website_SourceType",
                                Convert.ToInt32(rowInfo["Website_SourceType"]), SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@MaxHourFindNew", Convert.ToInt32(rowInfo["MaxHourFindNew"]),
                                SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@MaxLinksFindNew", Convert.ToInt32(rowInfo["MaxLinksFindNew"]),
                                SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@TimeDelay", Convert.ToInt32(rowInfo["TimeDelay"]), SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@AllowAutoCheckPrice",
                                Convert.ToInt32(rowInfo["AllowAutoCheckPrice"]), SqlDbType.Bit),
                            SqlDb.CreateParamteterSQL("@MaxProductToWarning",
                                Convert.ToInt32(rowInfo["MaxProductToWarning"]), SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@MinProductToWarning",
                                Convert.ToInt32(rowInfo["MinProductToWarning"]), SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@MaxDeep", Convert.ToInt32(rowInfo["MaxDeep"]), SqlDbType.Int),
                            SqlDb.CreateParamteterSQL("@LimitProductValid", Convert.ToInt32(rowInfo["LimitProductValid"]), SqlDbType.Int)
                        });
                    countData++;
                }
            if (countData > 0)
            {
                MessageBox.Show(string.Format("Success {0} items", countData));
            }
            tbl.AcceptChanges();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }

        private void btnFindNew_Click(object sender, EventArgs e){

        }

        private void FrmCompany_Load(object sender, EventArgs e)
        {
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(EventGroup);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(CellValueChange);
            //this.gridView1.GroupRowExpanding += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(GroupRowExpanding);this.gridView1.RowStyle += (objectSender, eventData) =>
            //{
            //    var x = Convert.ToInt32(this.gridView1.GetRowCellValue(eventData.RowHandle, "ValidMinProduct"));
            //    if (x == 0)
            //    {
            //        eventData.Appearance.BackColor = Color.HotPink;eventData.Appearance.BackColor2 = Color.HotPink;
            //    }
            //};
        

            this.repositoryItemLookUpEdit_SourceWebsiteType.DataSource = this.sqldb.GetTblData("select ID, Name From Website_SourceType", CommandType.Text, null);
            this.repositoryItemLookUpEdit_SourceWebsiteType.DisplayMember = "Name";
            this.repositoryItemLookUpEdit_SourceWebsiteType.ValueMember = "ID";

            //this.gridView1.MouseDown += new MouseEventHandler(MouseDownEvent);
            RefreshData();
            this.menuCompanyPlus1.eventGetCompanys += new MenuCompanyPlus.DelegateGetCompanys(() =>
            {
                List<long> lstCompany = new List<long>();
                if (this.gridView1.SelectedRowsCount>0)
                {
                    foreach(int iRow in this.gridView1.GetSelectedRows())
                    {
                        lstCompany.Add(Convert.ToInt64(this.gridView1.GetRowCellValue(iRow, "id")));
                    }
                }
                return lstCompany;
            });

            this.menuCompanyPlus1.eventGetCompanyHandle += new MenuCompanyPlus.DelegateGetCompanyID(() =>
            {
                return Convert.ToInt64(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "id"));
            });
            this.menuCompanyPlus1.Init();
        }

        private void GroupRowExpanding(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
           
        }

        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            
        }

        private void CellValueChange(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle == gridView1.FocusedRowHandle)
            {
                object obj = e.Value;
                foreach (var iRow in this.gridView1.GetSelectedRows())
                {
                    if (iRow != e.RowHandle)
                    {
                        gridView1.SetRowCellValue(iRow, e.Column, obj);
                    }
                }
            }
        }

        private void RefreshData()
        {
            DataTable tbl = sqldb.GetTblData(
    @"
   select b.id, a.id as configuration_id, b.domain
    , ISNULL(a.MinHourReload, 0) AS MinHourReload
    , ISNULL(a.MinHourFindNew, 0) AS MinHourFindNew
    , ISNULL(a.NumberThreadCrawler, 0) AS  NumberThreadCrawler
	, d.Name as NameType
	, d.STT as STTType
	, b.LastCrawlerReload
	, b.LastCrawlerFindNew
	, isnull(a.AllowFindNew, 1) as AllowFindNew
	, isnull(a.AllowReload, 1) as AllowReload 
    , b.TotalProduct
    , ISNULL(e.ID, 0) as Website_SourceType
	, a.MaxHourFindNew
	, a.MaxLinksFindNew
    , ISNULL(a.CheckPrice, 1) AS CheckPrice
    , ISNULL(a.TimeDelay, 0) AS TimeDelay
    , ISNULL(a.AllowAutoCheckPrice, 0) AS AllowAutoCheckPrice

	, ISNULL(a.MaxProductToWarning, 0) AS MaxProductToWarning
	, ISNULL(a.MinProductToWarning, 0) AS MinProductToWarning
	
	, CASE WHEN (a.MinProductToWarning>0 AND  b.TotalProduct<a.MinProductToWarning) THEN 0 ELSE 1 END AS ValidMinProduct
	, CASE WHEN (a.MaxProductToWarning>0 AND  b.TotalProduct>a.MaxProductToWarning) THEN 0 ELSE 1 END AS ValidMaxProduct
    , a.MaxDeep
    , ISNULL(a.LimitProductValid, 0) AS LimitProductValid
--update a set MinHourReload = 8, MinHourFindNew = 8
from Configuration a
inner join Company b on a.companyid = b.id
inner join ManagerTypeRCompany c on c.IDCompany = b.ID
inner join ManagerType d on d.id = c.IDType
left join Website_SourceType e on a.Website_SourceType = e.ID
where  1= 1
and b.DataFeedType = 0
and b.Status = 1
order by b.LastEndCrawlerReload desc

", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { });

            tbl.Columns.Add("NextReload", typeof(long));
            tbl.Columns.Add("NextFindNew", typeof(long));
            this.gridControl1.DataSource = tbl;

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

        private void button2_Click(object sender, EventArgs e)
        {
            QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler redisCompanyWaitCrawler = QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.Instance();
            var dicNextRL = redisCompanyWaitCrawler.GetAllCompanyAndTimeRL();
            var dicNextFN = redisCompanyWaitCrawler.GetAllCompanyAndTimeFN();
            DataTable tbl = this.gridControl1.DataSource as DataTable;
            foreach(DataRow row in tbl.Rows)
            {
                long companyID = Convert.ToInt64(row["id"]);
                row["NextReload"] = dicNextRL.ContainsKey(companyID) ? dicNextRL[companyID] : 0;
                row["NextFindNew"] = dicNextFN.ContainsKey(companyID) ? dicNextFN[companyID] : 0;
            }
        }

        private void btnSelectGroup_Click(object sender, EventArgs e)
        {
          
        }

        private void FrmCompany_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.menuCompanyPlus1.Show(this.gridControl1, new Point(e.X, e.Y));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gridView1.BeginSelection();
            gridView1.ClearSelection();
            if (gridView1.IsDataRow(gridView1.FocusedRowHandle))
            {
                var parent = gridView1.GetParentRowHandle(gridView1.FocusedRowHandle);
                gridView1.SelectRows(gridView1.GetChildRowHandle(parent, 0),
                    gridView1.GetChildRowHandle(parent, gridView1.GetChildRowCount(parent) - 1));
            }
          
        }

        private void btnPushNextRl_Click(object sender, EventArgs e)
        {
            QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler redisCompanyWaitCrawler = QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.Instance();
            List<long> companyIDS = new List<long>();
            foreach (var rowSelected in this.gridView1.GetSelectedRows())
            {
                DataRowView row = gridView1.GetRow(rowSelected) as DataRowView;
                companyIDS.Add(Convert.ToInt64(row["id"]));

            }
            redisCompanyWaitCrawler.SetNexReload(companyIDS, this.dtpTimeRun.Value);
            MessageBox.Show("Success");
            this.btnLoadNext.PerformClick();
        }

        private void btnPushNextFN_Click(object sender, EventArgs e)
        {
            QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler redisCompanyWaitCrawler = QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.Instance();
            List<long> companyIDS = new List<long>();
            foreach (var rowSelected in this.gridView1.GetSelectedRows())
            {
                DataRowView row = gridView1.GetRow(rowSelected) as DataRowView;
                companyIDS.Add(Convert.ToInt64(row["id"]));
            }
            redisCompanyWaitCrawler.SetNexFindNew(companyIDS, this.dtpTimeRun.Value);
            MessageBox.Show("Success");
            this.btnLoadNext.PerformClick();
        }
    }
}
