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
    public partial class FrmConfigDescXPath : Form
    {
        public FrmConfigDescXPath()
        {
            InitializeComponent();
        }

        private void configurationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.configurationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB);

        }

        private void FrmConfigDescXPath_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.Configuration' table. You can move, or remove it, as needed.
            this.configurationTableAdapter.Fill(this.dB.Configuration);

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
