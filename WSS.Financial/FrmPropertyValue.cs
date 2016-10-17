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
    public partial class FrmPropertyValue : Form
    {
        public FrmPropertyValue()
        {
            InitializeComponent();
        }

        private void propertyValueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.propertyValueBindingSource.EndEdit();
            this.propertyValueTableAdapter.Update(this.dBFinancial.PropertyValue);

        }

        private void FrmPropertyValue_Load(object sender, EventArgs e)
        {
            this.propertyValueTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.propertyValueTableAdapter.Fill(this.dBFinancial.PropertyValue);
        }
    }
}
