using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Financial
{
    public partial class FrmPaymentMethod : Form
    {
        public FrmPaymentMethod()
        {
            InitializeComponent();
        }

        private void paymentMethodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentMethodBindingSource.EndEdit();
            this.paymentMethodTableAdapter.Update(this.dBFinancial.PaymentMethod);

        }

        private void FrmPaymentMethod_Load(object sender, EventArgs e)
        {
            this.paymentMethodTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.paymentMethodTableAdapter.Fill(this.dBFinancial.PaymentMethod);

        }
    }
}
