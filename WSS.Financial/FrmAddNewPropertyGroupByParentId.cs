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
    public partial class FrmAddNewPropertyGroupByParentId : Form
    {
        private int _idParent;
        private int _idCategory;
        private int _levelGroup;
        public FrmAddNewPropertyGroupByParentId()
        {
            InitializeComponent();
        }
        public FrmAddNewPropertyGroupByParentId(int idParent, int idCategory, int levelGroup)
        {
            InitializeComponent();
            _idParent = idParent;
            _idCategory = idCategory;
            _levelGroup = levelGroup;
        }

        private void propertyGroupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.propertyGroupBindingSource.EndEdit();
                this.propertyGroupTableAdapter.Update(this.dBFinancial.PropertyGroup);

                MessageBox.Show(@"Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void FrmAddNewPropertyGroupByParentId_Load(object sender, EventArgs e)
        {
            this.categoryTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.categoryTableAdapter.Fill(this.dBFinancial.Category);
            propertyGroupTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            if (_idParent != 0)
            {
                this.propertyGroupTableAdapter.FillBy_ParentId(this.dBFinancial.PropertyGroup, _idParent);
            }
            this.dBFinancial.PropertyGroup.Columns["CategoryId"].DefaultValue = _idCategory;
            this.dBFinancial.PropertyGroup.Columns["ParentId"].DefaultValue = _idParent;
            this.dBFinancial.PropertyGroup.Columns["GroupLevel"].DefaultValue = _levelGroup;
            categoryIdLookUpEdit.EditValue = _idCategory;
            parentIdTextEdit.Text = _idParent.ToString();
            groupLevelTextEdit.Text = _levelGroup.ToString();
        }
    }
}
