using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;

namespace QT.Moduls.ProductID
{
    public partial class frmEditeGroupProperties : QT.Entities.frmBase
    {
        public frmEditeGroupProperties()
        {
            InitializeComponent();
        }

        private void propertiesGroupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.propertiesGroupBindingSource.EndEdit();
            this.propertiesGroupTableAdapter.Update(this.dBProperties.PropertiesGroup);

        }

        public override bool Save()
        {
            this.Validate();
            this.propertiesGroupBindingSource.EndEdit();
            this.propertiesGroupTableAdapter.Update(this.dBProperties.PropertiesGroup);
            return true;
        }
        public override bool RefreshData()
        {
            this.propertiesGroupTableAdapter.Fill(this.dBProperties.PropertiesGroup);
            return true;
        }



        private void frmEditeGroupProperties_Load(object sender, EventArgs e)
        {
            this.propertiesGroupTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.propertiesGroupTableAdapter.Fill(this.dBProperties.PropertiesGroup);
        }
    }
}
