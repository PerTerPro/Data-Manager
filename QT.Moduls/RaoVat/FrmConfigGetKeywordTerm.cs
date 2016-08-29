using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlSale
{
    public partial class FrmConfigGetKeywordTerm : Form
    {
        public FrmConfigGetKeywordTerm()
        {
            InitializeComponent();
        }

        private void configGetKeywordTermBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.configGetKeywordTermBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.saleNewsDataSet);

        }

        private void FrmConfigGetKeywordTerm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleNewsDataSet.ConfigGetKeywordTerm' table. You can move, or remove it, as needed.
            this.configGetKeywordTermTableAdapter.Fill(this.saleNewsDataSet.ConfigGetKeywordTerm);

        }
    }
}
