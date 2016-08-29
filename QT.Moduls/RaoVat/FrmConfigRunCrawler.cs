using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.RaoVat
{
    public partial class FrmConfigRunCrawler : Form
    {
        public FrmConfigRunCrawler()
        {
            InitializeComponent();
            this.config_run_crawlerTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;
        }

        private void config_run_crawlerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.config_run_crawlerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.crawlerSaleNew);

        }

        private void FrmConfigRunCrawler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crawlerSaleNew.config_run_crawler' table. You can move, or remove it, as needed.
            this.config_run_crawlerTableAdapter.Fill(this.crawlerSaleNew.config_run_crawler);


        }

        private void config_run_crawlerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.config_run_crawlerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.crawlerSaleNew);

        }


    }
}
