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
    public partial class FrmConfigDescription : Form
    {
        public FrmConfigDescription()
        {
            InitializeComponent();
        }

        private void configurationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.configurationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsQT2);

        }

        private void FrmConfigDescription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQT2.Configuration' table. You can move, or remove it, as needed.
            this.configurationTableAdapter.Fill(this.dsQT2.Configuration);

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
