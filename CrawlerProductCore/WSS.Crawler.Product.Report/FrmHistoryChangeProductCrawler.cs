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

namespace  WSS.Crawler.Product.Report
{
    public partial class FrmHistoryChangeProductCrawler : Form
    {
        LogCrawler logCrawler = LogCrawler.Instance;
        private long ProductId;

        public FrmHistoryChangeProductCrawler()
        {
            InitializeComponent();
        }

        public FrmHistoryChangeProductCrawler(long p)
        {
            this.ProductId = p;
            InitializeComponent();
        }

        private void FrmHistoryChangeProduct_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void RefreshData()
        {   
            long ProductID = QT.Entities.Common.Obj2Int64(this.ProductId);
            this.gridControl1.DataSource = logCrawler.GetHistoryProduct(ProductID);
            gridView1.Columns["Date"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
