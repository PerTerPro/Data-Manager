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
    public partial class FrmProperty : Form
    {
        private int _propertyGroupId;
        public FrmProperty()
        {
            InitializeComponent();
        }
        public FrmProperty(int groupId)
        {
            InitializeComponent();
            _propertyGroupId = groupId;
        }
        private void propertyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.propertyBindingSource.EndEdit();
            this.propertyTableAdapter.Update(this.dBFinancial.Property);

        }

        private void FrmProperty_Load(object sender, EventArgs e)
        {
            this.propertyGroupTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            propertyTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            try
            {
                this.propertyGroupTableAdapter.Fill(this.dBFinancial.PropertyGroup);
                if (_propertyGroupId > 0)
                {
                    this.propertyTableAdapter.FillBy_PropertyGroupId(this.dBFinancial.Property,_propertyGroupId);
                    this.dBFinancial.Property.Columns["PropertyGroupId"].DefaultValue = _propertyGroupId;
                    propertyGroupIdLookUpEdit.EditValue = _propertyGroupId;}
                else
                {
                    this.propertyTableAdapter.Fill(this.dBFinancial.Property);}
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
