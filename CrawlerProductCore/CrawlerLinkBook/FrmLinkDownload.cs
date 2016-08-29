using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace CrawlerLinkBook
{
    public partial class FrmLinkDownload : Form
    {
        public FrmLinkDownload()
        {
            InitializeComponent();

            this.gridView1.RowCellClick+=new RowCellClickEventHandler(GridView1CellClick);
            this.gridView1.MouseDown += new MouseEventHandler(GridViewMouseDouwn);
        }
        private void GridViewMouseDouwn(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right){
                contextMenuStrip1.Show(this.linkItbookGridControl,new Point(e.X,e.Y));
            }
        }

        private void GridView1CellClick(object sender, RowCellClickEventArgs e)
        {
           if (e.Column.FieldName=="Link")
           {
               string link = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Link").ToString();
               //IWebDriver driverOne = new FirefoxDriver();
               //driverOne.Url = link;
               string url = e.CellValue.ToString();
               Process.Start(@"chrome.exe", url);
           }
        }

        private void FrmLinkDownload_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDownloadBook.LinkItbook' table. You can move, or remove it, as needed.
            this.linkItbookTableAdapter.Fill(this.dsDownloadBook.LinkItbook);
            // TODO: This line of code loads data into the 'dsDownloadBook.V_LinkDownload' table. You can move, or remove it, as needed.
        }


        private void RefreshData()
        {
            // TODO: This line of code loads data into the 'dsDownloadBook.LinkItbook' table. You can move, or remove it, as needed.
            this.linkItbookTableAdapter.Fill(this.dsDownloadBook.LinkItbook);
            // TODO: This line of code loads data into the 'dsDownloadBook.V_LinkDownload' table. You can move, or remove it, as needed.
        }
        private void v_LinkDownloadGridControl_Click(object sender, EventArgs e)
        {
        }

        private void downloadedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = new DsDownloadBookTableAdapters.LinkItbookTableAdapter();
            db.UpdateDowloaded(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "LinkDownload").ToString());
            RefreshData();
            MessageBox.Show("Success");
        }

        private void linkItbookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.linkItbookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsDownloadBook);

        }

        private void linkItbookGridControl_Click(object sender, EventArgs e)
        {

        }

       
    }
}
