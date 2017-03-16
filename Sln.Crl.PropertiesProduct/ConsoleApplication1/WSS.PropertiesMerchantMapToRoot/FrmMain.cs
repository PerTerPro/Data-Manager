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
using WSS.LibExtra;

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
            var lstRootProduct = GetLstRootProduct(50, 1);
            gridControlRootProduct.DataSource = lstRootProduct;
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
            long RootId = Convert.ToInt64(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "ID").ToString());
            FrmProperties frm = new FrmProperties(RootId);
            frm.Text = RootId.ToString();
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
    }
}
