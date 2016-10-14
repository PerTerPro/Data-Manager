using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Financial.Bank
{
    public partial class FrmBankManager : Form
    {
        public FrmBankManager()
        {
            InitializeComponent();
        }

        private void FrmBankManager_Load(object sender, EventArgs e)
        {
            this.bankTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            try
            {
                this.bankTableAdapter.Fill(this.dBFinancial.Bank);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void bankBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bankBindingSource.EndEdit();
            this.bankTableAdapter.Update(this.dBFinancial.Bank);}
    }
}
