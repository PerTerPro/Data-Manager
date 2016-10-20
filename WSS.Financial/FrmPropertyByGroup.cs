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
    public partial class FrmPropertyByGroup : Form
    {
        private int _groupid;
        private int _categoryId;
        public FrmPropertyByGroup()
        {
            InitializeComponent();
        }
        public FrmPropertyByGroup(int groupId, int categoryId)
        {
            InitializeComponent();
            _groupid = groupId;
            _categoryId = categoryId;
        }

        private void propertyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.propertyBindingSource.EndEdit();
                this.propertyTableAdapter.Update(this.dBFinancial.Property); 
                MessageBox.Show(@"Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmPropertyByGroup_Load(object sender, EventArgs e)
        {
            try
            {
                this.propertyValueTypeTableAdapter.Fill(this.dBFinancial.PropertyValueType);
                this.propertyGroupTableAdapter.FillBy_Id(this.dBFinancial.PropertyGroup,_groupid);
                groupIdTreeListLookUpEdit.EditValue = _groupid;
                this.categoryTableAdapter.FillBy_Id(this.dBFinancial.Category,_categoryId);
                categoryIdLookUpEdit.EditValue = _categoryId;
                this.propertyTableAdapter.FillBy_GroupId(this.dBFinancial.Property,_groupid);
                dBFinancial.Property.Columns["GroupId"].DefaultValue = _groupid;
                dBFinancial.Property.Columns["CategoryId"].DefaultValue = _categoryId;
                dBFinancial.Property.Columns["ViewOrder"].DefaultValue = 0;
                dBFinancial.Property.Columns["Unit"].DefaultValue = "";

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            

        }
    }
}
