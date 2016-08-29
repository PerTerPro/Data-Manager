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
    public partial class frmEditeProperties : QT.Entities.frmBase
    {
        public frmEditeProperties()
        {
            InitializeComponent();
        }

        private void propertiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.propertiesBindingSource.EndEdit();
            this.propertiesTableAdapter.Update(this.dBProperties.Properties);

        }
        public override bool Save()
        {
            this.Validate();
            this.propertiesBindingSource.EndEdit();
            this.propertiesTableAdapter.Update(this.dBProperties.Properties);
            this.propertiesValueBindingSource.EndEdit();
            this.propertiesValueTableAdapter.Update(this.dBProperties.PropertiesValue);
            return true;
        }
        public override bool RefreshData()
        {
            try
            {
                this.propertiesGroupTableAdapter.Fill(this.dBProperties.PropertiesGroup);
                this.propertiesTableAdapter.Fill(this.dBProperties.Properties);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        private void frmEditeProperties_Load(object sender, EventArgs e)
        {
            this.propertiesGroupTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.propertiesTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.propertiesValueTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.propertiesGroupTableAdapter.Fill(this.dBProperties.PropertiesGroup);
            this.propertiesTableAdapter.Fill(this.dBProperties.Properties);
        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {
            int id = Common.Obj2Int(this.iDTextBox.Text);
            if (id > 0)
                this.propertiesValueTableAdapter.FillBy_Properties(dBProperties.PropertiesValue, id);
        }

        private void btDeleteValue_Click(object sender, EventArgs e)
        {
            DBPropertiesTableAdapters.PropertiesValueTableAdapter adt = new DBPropertiesTableAdapters.PropertiesValueTableAdapter();
            adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            DBPropertiesTableAdapters.Product_PropertiesTableAdapter adtPro = new DBPropertiesTableAdapters.Product_PropertiesTableAdapter();
            adtPro.Connection.ConnectionString = QT.Entities.Server.ConnectionString;

            DBProperties.PropertiesValueDataTable dtvalue = new DBProperties.PropertiesValueDataTable();
            adt.Fill(dtvalue);
            int i = 0, dem = 0;
            foreach (DBProperties.PropertiesValueRow dr in dtvalue)
            {
                int count = Common.Obj2Int(adtPro.ScalarQuery_CountByValue(dr.ID));
                if (count == 0)
                {
                    dem++;
                    adt.DeleteQuery(dr.ID);
                }
                i++;
                this.laMess.Text = string.Format("{0}/{1}--{2}", i, dtvalue.Count, dem);
                Application.DoEvents();
            }
        }
    }
}
