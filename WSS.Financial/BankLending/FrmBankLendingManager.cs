using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Financial.BankLending
{
    public partial class FrmBankLendingManager : Form
    {
        private int _bankId;
        public FrmBankLendingManager()
        {
            InitializeComponent();
        }
        public FrmBankLendingManager(int bankId)
        {
            InitializeComponent();
        }
        private void bankLendingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bankLendingBindingSource.EndEdit();
            this.bankLendingTableAdapter.Update(this.dBFinancial.BankLending);

        }

        private void FrmBankBlendingManager_Load(object sender, EventArgs e)
        {
            this.bankTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.paymentMethodTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.bankLendingTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            InitData();
        }

        private void InitData()
        {
            try
            {
                this.bankTableAdapter.Fill(this.dBFinancial.Bank);
                this.paymentMethodTableAdapter.Fill(this.dBFinancial.PaymentMethod);
                if (_bankId == 0)
                {
                    this.bankLendingTableAdapter.Fill(this.dBFinancial.BankLending);
                }
                else
                {
                    this.bankLendingTableAdapter.FillBy_BankId(this.dBFinancial.BankLending,_bankId);
                    this.dBFinancial.BankLending.BankIdColumn.DefaultValue = _bankId;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
