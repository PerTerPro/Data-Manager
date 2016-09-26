using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
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
    public partial class FrmViewCacheCompany : Form
    {
        QT.Moduls.CrawlerProduct.Cache.RedisCacheCompanyCrawler redisCacheCompany = QT.Moduls.CrawlerProduct.Cache.RedisCacheCompanyCrawler.Instance();
        QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler redisWaitCrawler = QT.Moduls.CrawlerProduct.Cache.RedisCompanyWaitCrawler.Instance();
        SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);

        public FrmViewCacheCompany()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void RefreshData()
        {
            this.gridControl1.DataSource = GetCompanyCache();
        }

        private List<QT.Entities.CrawlerProduct.Cache.CompanyCache> GetCompanyCache()
        {
            List<QT.Entities.CrawlerProduct.Cache.CompanyCache> lstCompanyCache = new List<QT.Entities.CrawlerProduct.Cache.CompanyCache>();
            DataTable tbl = this.sqlDb.GetTblData(@"select a.id, domain, LastUpdateRedisCrawler 
	, isnull(b.MinHourFindNew, 12) as MinHourFindNew
	, isnull(b.MinHourReload, 8) as MinHourFindNew
from Company a
inner join Configuration b on a.ID = b.CompanyID 
where 1=1 
and LastUpdateRedisCrawler is not null");

            foreach (DataRow rowInfo in tbl.Rows)
            {
                lstCompanyCache.Add(new QT.Entities.CrawlerProduct.Cache.CompanyCache()
                {
                    Id = Convert.ToInt64(rowInfo["Id"]),
                    Domain = Convert.ToString(rowInfo["Domain"]),
                    LastUpdateRedisCrawler = Convert.ToDateTime(rowInfo["LastUpdateRedisCrawler"])
                });
            }
            return lstCompanyCache;
        }

        private void ckInQueue_FindNew_CheckedChanged(object sender, EventArgs e)
        {
            if (ckInQueue_FindNew.Checked)
            {
                var dic = redisWaitCrawler.GetAllCompanyAndTimeRL();
                foreach (var item in (this.gridControl1.DataSource as List<QT.Entities.CrawlerProduct.Cache.CompanyCache>))
                {
                    if (dic.ContainsKey(item.Id))
                    {
                        item.InQueue_FindNew = true;
                        item.Time_NextFindNew = dic[item.Id];
                    }
                }
            }
        }


        private void ckInQueue_Reload_CheckedChanged(object sender, EventArgs e)
        {
            if (ckInQueue_FindNew.Checked)
            {
                var dic = redisWaitCrawler.GetAllCompanyAndTimeRL();
                foreach (var item in (this.gridControl1.DataSource as List<QT.Entities.CrawlerProduct.Cache.CompanyCache>))
                {
                    if (dic.ContainsKey(item.Id))
                    {
                        item.InQueue_FindNew = true;
                        item.Time_NextFindNew = dic[item.Id];
                    }
                }
            }
        }

        private void ckTime_NewFindNew_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckTime_NextReload_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckRunning_CheckedChanged(object sender, EventArgs e)
        {
            if (ckRunning.Checked)
            {
                var dic = redisWaitCrawler.GetCompanyRunningCrawler();
                foreach (var item in (this.gridControl1.DataSource as List<QT.Entities.CrawlerProduct.Cache.CompanyCache>))
                {
                    if (dic.ContainsKey(item.Id))
                    {
                        item.Running = true;
                        item.LastJobCrawler = dic[item.Id];
                    }
                }
            }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            FrmCacheCompany frm = new FrmCacheCompany();
            frm.Show();
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.menuCompanyPlus1.Show(this.gridControl1, new Point(e.X, e.Y));
            }
        }

        private void FrmViewCacheCompany_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.menuCompanyPlus1.Show(this.gridControl1, new Point(e.X, e.Y));
            }
        }

        private void FrmViewCacheCompany_Load(object sender, EventArgs e)
        {
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(EventDraw);
            this.gridView1.DoubleClick += new EventHandler(gridView1_DoubleClick);

            this.RefreshData();
            this.menuCompanyPlus1.eventGetCompanyHandle += new MenuCompanyPlus.DelegateGetCompanyID(() =>
            {
                return Convert.ToInt64(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Id"));
            });
            this.menuCompanyPlus1.Init();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int iRowHandle = this.gridView1.FocusedRowHandle;
            if (iRowHandle >= 0)
            {
                long CompanyID = Convert.ToInt64(this.gridView1.GetRowCellValue(iRowHandle, "Id"));
                FrmHistoryCrawlerByCompany frm = new FrmHistoryCrawlerByCompany(CompanyID);
                frm.ShowDialog();
            }
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int[] lstRowSelected = this.gridView1.GetSelectedRows();
            foreach (var rowIndex in lstRowSelected)
            {
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                QT.Entities.CrawlerProduct.Cache.CompanyCache companyCache = this.gridView1.GetRow(rowIndex) as QT.Entities.CrawlerProduct.Cache.CompanyCache;
                long CompanyID = Convert.ToInt64(companyCache.Id);
                string Domain = Convert.ToString(companyCache.Domain);
                productAdapter.PushQueueReloadCacheProductInfo(CompanyID, Domain);
            }
            MessageBox.Show(string.Format("Success pushed for {0} companys!", lstRowSelected.Length));
        }

        private void btnRefreshCacheProductInfo_Click(object sender, EventArgs e)
        {
            CacheProductInfo c = new CacheProductInfo(new SqlDb(QT.Entities.Server.ConnectionString));
            c.RefreshAllCacheAllProduct(5793170764020693231);
        }

        private void btnCacheDuplicate_Click(object sender, EventArgs e)
        {
            SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);
            QT.Moduls.CrawlerProduct.Cache.CacheCheckDuplicatepProduct blo = new QT.Moduls.CrawlerProduct.Cache.CacheCheckDuplicatepProduct(sqlDb, "redisCacheCrawler_Duplicate");
            blo.RefreshCache(5793170764020693231, "nhommua.com");
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewProductInCache_Click(object sender, EventArgs e)
        {
            int iRowHandle = this.gridView1.FocusedRowHandle;
            if (iRowHandle >= 0)
            {
                long CompanyID = Convert.ToInt64(this.gridView1.GetRowCellValue(iRowHandle, "Id"));
                FrmViewProductInCache frm = new FrmViewProductInCache(CompanyID);
                frm.ShowDialog();
            }
        }

        private void btnViewProductInDb_Click(object sender, EventArgs e)
        {
            int iRowHandle = this.gridView1.FocusedRowHandle;
            if (iRowHandle >= 0)
            {
                long CompanyID = Convert.ToInt64(this.gridView1.GetRowCellValue(iRowHandle, "Id"));
                FrmViewProductInDb frm = new FrmViewProductInDb(CompanyID);
                frm.ShowDialog();
            }
        }

        private void btnSycCacheCompany_Click(object sender, EventArgs e)
        {
            FrmCacheCompany frm = new FrmCacheCompany();
            frm.Show();
        }

        private void btnRemoveHashChange_Click(object sender, EventArgs e)
        {
            RedisLastUpdateProduct redisLastUpdateProduct = RedisLastUpdateProduct.Instance();
            RedisCacheProductInfo redisCacheProductInfo = RedisCacheProductInfo.Instance();

            int iRowHandle = this.gridView1.FocusedRowHandle;
            if (iRowHandle >= 0)
            {
                long CompanyID = Convert.ToInt64(this.gridView1.GetRowCellValue(iRowHandle, "Id"));
                List<long> lstProduct = redisLastUpdateProduct.GetAllProduct(CompanyID);
                foreach(long product in lstProduct)
                {
                    redisCacheProductInfo.ResetHashChange(CompanyID, product);   
                }
            }
        }
    }
}
