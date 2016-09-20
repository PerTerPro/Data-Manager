using QT.Entities.Data;
using QT.Moduls.LogCassandra;
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
    public partial class FrmViewDetailSessionRL : Form
    {
        LogCrawler logCrawler = LogCrawler.Instance;
        private string Session = "";
        public FrmViewDetailSessionRL()
        {
            InitializeComponent();
        }

        public FrmViewDetailSessionRL(string str)
        {
            InitializeComponent();
            this.Session = str;
        }


        private void FrmDetailSession_Load(object sender, EventArgs e)
        {
            RefreshData();

            this.gridView1.DoubleClick += new EventHandler(RowDoubleClick);
        }

        private void RowDoubleClick(object sender, EventArgs e)
        {
            if (this.gridView1.FocusedRowHandle >= 0)
            {
                FrmHistoryChangeProductCrawler frm = new FrmHistoryChangeProductCrawler(Convert.ToInt64(gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Product_Id")));
                frm.ShowDialog();
            }
        }

        private void RefreshData()
        {
            this.gridControl1.DataSource = logCrawler.GetDetailSession(this.Session);
        }

        private void btnHistoryProduct_Click(object sender, EventArgs e)
        {
            FrmHistoryChangeProductCrawler frm = new FrmHistoryChangeProductCrawler(Convert.ToInt64(gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Product_Id")));
            frm.ShowDialog();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

    }
}
