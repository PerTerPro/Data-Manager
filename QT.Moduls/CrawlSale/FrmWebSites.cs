using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlSale
{
    public partial class FrmWebSites : Form
    {
        QT.Entities.RaoVat.RaoVatSQLAdapter raovatAdapter = new Entities.RaoVat.RaoVatSQLAdapter(
            new SqlDb(QT.Entities.Server.ConnectionStringCrawler));

        public FrmWebSites()
        {
            InitializeComponent();
        }

        private void webSiteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.webSiteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.crawlerSaleNew);

        }

        private void FrmWebSite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crawlerSaleNew.WebSite' table. You can move, or remove it, as needed.
            this.webSiteTableAdapter.Fill(this.crawlerSaleNew.WebSite);

            this.repositoryItemGridLookUpEdit1.DataSource = this.raovatAdapter.GetTblConfig();

        }

        private void mapClassificationCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iWebSite = Convert.ToInt32(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "id"));
            RaoVat.FrmMapClassficationAndCategory frm = new RaoVat.FrmMapClassficationAndCategory(iWebSite);
            frm.Show();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iWebSite = Convert.ToInt32(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "id"));
            RaoVat.FrmMapClassificationAndCities frm = new RaoVat.FrmMapClassificationAndCities(iWebSite);
            frm.Show();
        }

        private void FrmWebSites_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void webSiteGridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.webSiteGridControl, new Point(e.X, e.Y));
            }
        }
    }
}
