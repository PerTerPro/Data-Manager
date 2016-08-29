using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmViewErrorIsNewDownloadImage : Form
    {
        private long CompanyID = 0;

        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));

        public void LoadData ()
        {
            this.gridControl1.DataSource = productAdapter.GetListErrorImageIsNew(this.CompanyID);
        }

        public FrmViewErrorIsNewDownloadImage()
        {
            InitializeComponent();
        }
        public FrmViewErrorIsNewDownloadImage(long CompanyID)
        {
            InitializeComponent();
            this.CompanyID = CompanyID;
        }

      

        private void btnReloadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {

        }

        private void FrmViewErrorIsNewDownloadImage_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
