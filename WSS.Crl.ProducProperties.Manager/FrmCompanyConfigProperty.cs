using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Crl.ProducProperties.Manager
{
    public partial class FrmCompanyConfigProperty : Form
    {
        public FrmCompanyConfigProperty()
        {
            InitializeComponent();
        }

        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productQT);

        }

        private void FrmCompanyConfigProperty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productQT.Configuration_Property' table. You can move, or remove it, as needed.
            this.configuration_PropertyTableAdapter.Fill(this.productQT.Configuration_Property);
            // TODO: This line of code loads data into the 'productQT.Configuration' table. You can move, or remove it, as needed.
            this.configurationTableAdapter.Fill(this.productQT.Configuration);
            // TODO: This line of code loads data into the 'productQT.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.productQT.Company);

        }
    }
}
