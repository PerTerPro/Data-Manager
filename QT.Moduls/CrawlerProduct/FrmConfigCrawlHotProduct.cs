using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities.Data;
using QT.Moduls.DBTableAdapters;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmConfigCrawlHotProduct : Form
    {
        private long companyId = 0;
        private ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));

        public FrmConfigCrawlHotProduct()
        {
            InitializeComponent();
        }

        public FrmConfigCrawlHotProduct(long companyId)
        {
            InitializeComponent();
            this.companyId = companyId;
        }

        private void configurationHotProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.configurationHotProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB);
            MessageBox.Show("Saved");
        }

        private void FrmConfigCrawlHotProduct_Load(object sender, EventArgs e)
        {
            this.RefreshData();

        }

        private void RefreshData()
        {
            // TODO: This line of code loads data into the 'dB.ConfigurationHotProduct' table. You can move, or remove it, as needed.
            this.configurationHotProductTableAdapter.FillByCompanyID(this.dB.ConfigurationHotProduct, this.companyId);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.btnSave.PerformClick();
            Task.Factory.StartNew(() =>
            {
                WorkerCrawlerHotProduct w = new WorkerCrawlerHotProduct(new Entities.Company(this.companyId), new Configuration(companyId), this.productAdapter.GetConfigurationHotProductBy(this.companyId));
                w.eventLogRun += new WorkerCrawlerHotProduct.EventLogRun((mss) =>
                {
                    this.Invoke(new Action(() =>
                    {
                        this.richTextBox1.AppendText("\n\r" + mss);
                    }));
                });
                w.StartRun();
            });
           
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            FrmHotProduct frm = new FrmHotProduct(this.companyId);
            frm.Show();
        }
    }
}
