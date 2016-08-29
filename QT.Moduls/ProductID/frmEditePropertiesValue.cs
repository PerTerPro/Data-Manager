using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.ProductID
{
    public partial class frmEditePropertiesValue : QT.Entities.frmBase
    {
        public frmEditePropertiesValue()
        {
            InitializeComponent();
        }

        private void frmEditePropertiesValue_Load(object sender, EventArgs e)
        {
            this.propertiesValueTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            // TODO: This line of code loads data into the 'dBProperties.PropertiesValue' table. You can move, or remove it, as needed.
            this.propertiesValueTableAdapter.Fill(this.dBProperties.PropertiesValue);
        }
        public override bool Save()
        {
            this.propertiesValueBindingSource.EndEdit();
            this.propertiesValueTableAdapter.Update(dBProperties.PropertiesValue);
            return true;
        }
    }
}
