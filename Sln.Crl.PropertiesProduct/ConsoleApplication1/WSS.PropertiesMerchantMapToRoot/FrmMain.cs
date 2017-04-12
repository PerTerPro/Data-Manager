using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using WSS.PropertiesMerchantMapToRoot.Entity;
using WSS.PropertiesMerchantMapToRoot.Common;


namespace WSS.PropertiesMerchantMapToRoot
{
    public partial class FrmMain : Form
    {
        private string _connectionString;
        public FrmMain()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.AppSettings["connectionString"];
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private List<RootProduct> GetLstRootProduct(int pageSize, int pageIndex)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<RootProduct>(@"SELECT ID, Name
                                        FROM Product where Company = 6619858476258121218 and Name <>''
                                        ORDER BY Name Desc
                                        OFFSET ((@PageIndex - 1) * @PageSize) ROWS
                                        FETCH NEXT @PageSize ROWS ONLY;", new { PageSize = pageSize, PageIndex = pageIndex }).ToList();
            }
        }

        private void viewPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            long RootId = CommonConvert.Obj2Int64(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "ID").ToString());
            FrmProperties frm = new FrmProperties(RootId);
            frm.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Name").ToString();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gridControlRootProduct_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.gridControlRootProduct, new Point(e.X, e.Y));
            }
        }

        private void barButtonItemTab_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
        }

        private void barButtonItemCascade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = null;
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void barButtonItemVertical_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = null;
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void barButtonItemHorizontal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = null;
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void RefreshData()
        {
            var lstRootProduct = GetLstRootProduct(1000, 1);
            gridControlRootProduct.DataSource = lstRootProduct;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập sản phẩm gốc cần tìm ... ")
            {
                txtSearch.Text = "";
            }
        }
        private List<RootProduct> SearchByName(string nameSearch)
        {

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<RootProduct>(@"Select Id, Name from Product where Company = 6619858476258121218 and contains(Name, @Name)", new { Name = nameSearch.Trim().Replace(" ", "*") }).ToList();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var lstSearch = SearchByName(txtSearch.Text.Trim());
                gridControlRootProduct.DataSource = lstSearch;
            }
        }
    }
}
