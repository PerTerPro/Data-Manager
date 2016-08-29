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
    public partial class frmMapClassificationProperties : QT.Entities.frmBase
    {
        public frmMapClassificationProperties()
        {
            InitializeComponent();
        }

        public override bool RefreshData()
        {
            this.listClassificationTableAdapter.Fill(this.dBProperties.ListClassification);
            //
            this.propertiesTableAdapter.FillBy_PType(this.dBProperties.Properties, 1);
            this.gridView2.ExpandAllGroups();
            return true;
        }
        public override bool Save()
        {
            this.listClassification_PropertiesBindingSource.EndEdit();
            this.listClassification_PropertiesTableAdapter.Update(dBProperties.ListClassification_Properties);
            return true;
        }
        private void frmMapClassificationProperties_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBProperties.Properties' table. You can move, or remove it, as needed.
            this.propertiesTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.listClassification_PropertiesTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.listClassificationTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.listClassificationTableAdapter.Fill(this.dBProperties.ListClassification);
            this.propertiesTableAdapter.FillBy_PType(this.dBProperties.Properties, 1);
            this.gridView2.ExpandAllGroups();
        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.listClassification_PropertiesTableAdapter.FillBy_IDListClassification(this.dBProperties.ListClassification_Properties, Common.Obj2Int(this.iDTextBox.Text));
            this.gridView1.ExpandAllGroups();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            this.listClassification_PropertiesBindingSource.EndEdit();
            if (this.listClassification_PropertiesBindingSource.Count > 0)
            {
                this.listClassification_PropertiesBindingSource.RemoveCurrent();
            }
            this.listClassification_PropertiesBindingSource.EndEdit();
            this.listClassification_PropertiesTableAdapter.Update(dBProperties.ListClassification_Properties);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            this.listClassification_PropertiesTableAdapter.Insert(Common.Obj2Int(this.iDTextBox.Text), Common.Obj2Int(this.iDClassRProTextBox1.Text),
                1, true);
            this.listClassification_PropertiesTableAdapter.FillBy_IDListClassification(this.dBProperties.ListClassification_Properties, Common.Obj2Int(this.iDTextBox.Text));
        }
    }
}
