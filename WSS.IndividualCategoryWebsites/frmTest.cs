using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.IndividualCategoryWebsites
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBIndi);

        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBIndi.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.dBIndi.Categories);

        }
    }
}
