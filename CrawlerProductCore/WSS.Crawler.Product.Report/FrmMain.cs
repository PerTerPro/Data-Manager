using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Moduls.CrawlSale;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            
            InitializeComponent();
        }

        private void btnHistoryCrawler_Click(object sender, EventArgs e)
        {
            FrmTrackCrawlerAllCompany frm = new FrmTrackCrawlerAllCompany(); frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.MdiParent = this;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmWaitNextCrawler frm = new FrmWaitNextCrawler(); frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.MdiParent = this;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmHistoryCrawlerByCompany frm = new FrmHistoryCrawlerByCompany();
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
            frm.MdiParent = this;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmHistoryChangeProductCrawler frm = new FrmHistoryChangeProductCrawler();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.MdiParent = this;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmCompanyRunning frm = new FrmCompanyRunning();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.MdiParent = this;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmWaitNextCrawler frm = new FrmWaitNextCrawler(); frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.MdiParent = this;
        }
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void cacheCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewCacheCompany frm = new FrmViewCacheCompany();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.MdiParent = this;
        }

        private void FrmTrack_Load(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void FrmTrack_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            FrmViewCacheCompany frm = new FrmViewCacheCompany();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.MdiParent = this;
        }

        private void cacheWaitCrawlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPushCacheWaitCrawler frm = new FrmPushCacheWaitCrawler();
            frm.WindowState = FormWindowState.Normal;
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            FrmCompany frm = new FrmCompany();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            FrmCompany frm = new FrmCompany();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            FrmFindLinkProduct frm = new FrmFindLinkProduct();frm.MdiParent = this;
            frm.Show();
        }

        private void exportTrackViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExportCrawlerField frm = new FrmExportCrawlerField();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            FrmTrackRunning frm = new FrmTrackRunning();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ShowP_Click(object sender, EventArgs e)
        {
            FrmHistoryProduct f = new FrmHistoryProduct();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            FrmPushProduct frmPushProduct = new FrmPushProduct();
            frmPushProduct.Show();
        }

        private void toolStripButton3_Click_2(object sender, EventArgs e)
        {
            FrmFailConfig frm = new FrmFailConfig();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            FrmVCompanyConfigCrawler frm = new FrmVCompanyConfigCrawler();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
