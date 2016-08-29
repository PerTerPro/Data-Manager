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
    public partial class frmThongSoKyThuat : QT.Entities.frmBase
    {
        public frmThongSoKyThuat()
        {
            InitializeComponent();
        }

        private void frmThongSoKyThuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBProperties.ListClassification' table. You can move, or remove it, as needed.
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesValueTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesGroupTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesGroupTableAdapter.Fill(this.dBProperties.PropertiesGroup);
            this.listClassificationTableAdapter.Fill(this.dBProperties.ListClassification);
            this.treeListColumn1.TreeList.ExpandAll();
        }
        public override bool Save()
        {
            try
            {
                this.propertiesBindingSource.EndEdit();
                this.propertiesTableAdapter.Update(this.dBProperties.Properties);
                this.propertiesGroupBindingSource.EndEdit();
                this.propertiesGroupTableAdapter.Update(this.dBProperties.PropertiesGroup);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {

            //group change
            this.propertiesTableAdapter.FillByGroup(this.dBProperties.Properties, Common.Obj2Int(iDTextBox.Text));

        }

        private void iDTextBox1_TextChanged(object sender, EventArgs e)
        {
            // properties changes
            this.propertiesValueTableAdapter.FillBy_Properties(this.dBProperties.PropertiesValue, Common.Obj2Int(iDTextBox1.Text));
        }

        private void btLoadByCat_Click(object sender, EventArgs e)
        {
            this.propertiesTableAdapter.FillBy_CategoryID(this.dBProperties.Properties, Common.Obj2Int(iDCategoryTextBox.Text));

        }
    }
}
