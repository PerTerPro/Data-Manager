using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QT.Entities.CrawlerProduct;
using QT.Entities.CrawlerProduct.Cache;
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

namespace WSS.Crawler.Product.Report
{
    public partial class FrmViewProductInCache : Form
    {
        private long companyID;
        QT.Moduls.CrawlerProduct.Cache.RedisProductIDOfCompany redisProductIdOfCompany = QT.Moduls.CrawlerProduct.Cache.RedisProductIDOfCompany.Instance();
        QT.Moduls.CrawlerProduct.Cache.RedisLastUpdateProduct redisLastUpdate = QT.Moduls.CrawlerProduct.Cache.RedisLastUpdateProduct.Instance();
        RedisCacheProductInfo redisProductInfo = RedisCacheProductInfo.Instance();

        public FrmViewProductInCache()
        {
            InitializeComponent();
        }
        public FrmViewProductInCache(long CompanyID)
        {
            InitializeComponent();

            this.companyID = CompanyID;
        }


        private void FrmViewProductInCache_Load(object sender, EventArgs e)
        {


            this.RefreshData();
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(EventDraw);

            this.menuCompanyPlus1.eventGetProductID += new MenuCompanyPlus.DelegateGetProductID(() =>
            {
                return Convert.ToInt64(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "ID"));
            });
            this.menuCompanyPlus1.Init();
        }

        private void EventDraw(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
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
            Dictionary<long, long> lstProductId = redisLastUpdate.GetAllData(this.companyID);
            List<ProductCache> lstProductCache = new List<ProductCache>();
            CacheProductHash cacheProductHash = CacheProductHash.Instance();
            var lsthash = cacheProductHash.GetAllProductHash(this.companyID, lstProductId.Keys.ToList());
            this.gridControl1.DataSource = lsthash;
        }

        private void viewHistoryChangeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gridView1.FocusedRowHandle >= 0)
            {
                FrmHistoryChangeProductCrawler frm = new FrmHistoryChangeProductCrawler
                    (Convert.ToInt64(gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "id")));
                frm.ShowDialog();
            }
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                this.menuCompanyPlus1.Show(this.gridControl1, new Point(e.X, e.Y));

        }

        private void viewScoreLastUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewScoreProductLastCrawler frm =
                new FrmViewScoreProductLastCrawler(Convert.ToInt64(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "ProductID")));
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
