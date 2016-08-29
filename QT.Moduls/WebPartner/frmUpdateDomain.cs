using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.WebPartner
{
    public partial class frmUpdateDomain : Form
    {
        private long _idCompany = 0;
        public frmUpdateDomain(long idcompany)
        {
            InitializeComponent();
            _idCompany = idcompany;
        }

        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBWebPartner);

        }

        private void frmUpdateDomain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBWebPartner.Company_Status' table. You can move, or remove it, as needed.
            this.company_StatusTableAdapter.Fill(this.dBWebPartner.Company_Status);
            // TODO: This line of code loads data into the 'dBWebPartner.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.dBWebPartner.Company);

        }

    }
}
