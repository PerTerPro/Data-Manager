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
    public partial class FrmCheckCrawler : Form
    {
        public FrmCheckCrawler()
        {
            InitializeComponent();
        }


        private void FrmCheckCrawler_Load(object sender, EventArgs e)
        {

            this.companyTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.companyTableAdapter.CheckCrawler(this.dBCom.Company);
        }

        private void companyBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBCom);

        }
    }
}
