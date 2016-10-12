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
    public partial class FrmBankInfo : Form
    {
        private int _bankId;
        public FrmBankInfo()
        {
            InitializeComponent();
        }
        public FrmBankInfo(int bankId)
        {
            InitializeComponent();
            _bankId = bankId;
        }
        private void FrmBankInfo_Load(object sender, EventArgs e)
        {
            this.bankTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.bankTableAdapter.FillBy_BankId(this.dBFinancial.Bank,_bankId);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bankBindingSource.EndEdit();
                this.bankTableAdapter.Update(this.dBFinancial.Bank);
                MessageBox.Show(@"Okie!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
    }
}
