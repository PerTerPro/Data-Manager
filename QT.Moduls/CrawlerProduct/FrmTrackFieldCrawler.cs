using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities;
using QT.Entities.Data;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmTrackFieldCrawler : Form
    {
        public FrmTrackFieldCrawler()
        {
            InitializeComponent();
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang xử lí dữ liệu");
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            this.gridControl1.DataSource=  productAdapter.GetReportTrackCrawlerProperties();
            Wait.Close();
        }
    }
}
