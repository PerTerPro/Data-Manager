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

namespace WSS.Crawler.Product.Report
{
    public partial class FrmViewProductInDb : Form
    {
        SqlDb sqlD = new SqlDb(QT.Entities.Server.ConnectionString);
        private long company_id;

        public FrmViewProductInDb()
        {
            InitializeComponent();
        }
        public FrmViewProductInDb(long CompanyID)
        {
            InitializeComponent();
            this.company_id = CompanyID;
        }


        private void FrmViewProductInDb_Load(object sender, EventArgs e)
        {
            this.menuCompanyPlus1.eventGetProductID += new MenuCompanyPlus.DelegateGetProductID(() =>
             {
                 return Convert.ToInt64(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "ID"));
             });
            this.menuCompanyPlus1.eventGetProductIDs += new MenuCompanyPlus.DelegateGetProductss(GetProductIds);
            this.menuCompanyPlus1.Init();


            this.RefreshData();
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(EventGroup);
        }

        private Dictionary<long, List<long>> GetProductIds()
        {
            Dictionary<long, List<long>> dic = new Dictionary<long, List<long>>();
            List<long> lstSelectedID = new List<long>();
            foreach(int iRow in this.gridView1.GetSelectedRows())
            {
                lstSelectedID.Add(Convert.ToInt64(this.gridView1.GetRowCellValue(iRow, "ID")));
            }
            dic.Add(this.company_id, lstSelectedID);
            return dic;}
        private void EventGroup(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            string caption = info.Column.Caption;
            if (info.Column.Caption == string.Empty)
                caption = info.Column.ToString();
            info.GroupText = string.Format("{0} : {1} (count= {2})", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle));
        }
        private void RefreshData()
        {
            string sql = @"select a.ID, a.Name, a.Price, a.ImageUrls, a.ImagePath, a.IsNews
, a.Valid, a.DetailUrl, a.LastUpdate, a.OriginPrice, a.HashName
, a.VATStatus
, a.ImageId
from Product a 
where a.Company = @company_id";
            this.gridControl1.DataSource = this.sqlD.GetTblData(sql, CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
               SqlDb.CreateParamteterSQL("company_id",company_id,SqlDbType.BigInt)
            });}

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                this.menuCompanyPlus1.Show(this.gridControl1, new Point(e.X, e.Y));
        }
    }
}
