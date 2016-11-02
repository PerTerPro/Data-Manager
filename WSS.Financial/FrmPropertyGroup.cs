using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSS.Financial.Backend.DBFinancialTableAdapters;

namespace WSS.Financial.Backend
{
    public partial class FrmPropertyGroup : Form
    {
        public FrmPropertyGroup()
        {
            InitializeComponent();

        }
        private void FrmPropertyGroup_Load(object sender, EventArgs e)
        {
            categoryTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.categoryTableAdapter.Fill(this.dBFinancial.Category);
            propertyGroupTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial; ctrCategory1.InitControl();
        }

        private void InitData()
        {
            var categoryId = ctrCategory1.GetIdCategoryCurrent();
            try
            {
                propertyGroupTableAdapter.FillBy_CategoryId(dBFinancial.PropertyGroup, categoryId);
                dBFinancial.PropertyGroup.Columns["CategoryId"].DefaultValue = categoryId;
                dBFinancial.PropertyGroup.Columns["ViewOrder"].DefaultValue = 0;
                categoryIdLookUpEdit.EditValue = categoryId;
                treeListPropertyGroup.ExpandAll();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void ctrCategory1_IdCategoryChanged(EventArgs e)
        {
            InitData();
        }

        private void propertyGroupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.propertyGroupBindingSource.EndEdit();
                this.propertyGroupTableAdapter.Update(this.dBFinancial.PropertyGroup);

                #region Update Category Property theo Category PropertyGroup
                var propertyTableAdapter = new PropertyTableAdapter();
                propertyTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
                propertyTableAdapter.UpdateCategoryIdOfAllPropertyByGroupId();
                #endregion

                MessageBox.Show(@"Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deleteParentId_Click(object sender, EventArgs e)
        {
            parentIdLookUpEdit.EditValue = 0;
        }

        private void AddNewPropertyGroupWithParentId_Click(object sender, EventArgs e)
        {
            var idParent = Convert.ToInt32(idTextEdit.Text);
            var idCategory = categoryIdLookUpEdit.EditValue != null ? Convert.ToInt32(categoryIdLookUpEdit.EditValue) : 0;
            var levelGroup = 1;
            if (!string.IsNullOrEmpty(groupLevelTextEdit.Text))
            {
                var levelGroupTemp = Convert.ToInt32(groupLevelTextEdit.Text);
                if (levelGroupTemp > 0)
                {
                    levelGroup = levelGroupTemp + 1;
                }
            }
            var frm = new FrmAddNewPropertyGroupByParentId(idParent, idCategory, levelGroup);
            frm.Text = "Thêm node con từ node cha : " + nameTextEdit.Text;
            frm.ShowDialog();
            InitData();
        }

        private void btnAddNodeCha_Click(object sender, EventArgs e)
        {
            var idCategory = categoryIdLookUpEdit.EditValue != null ? Convert.ToInt32(categoryIdLookUpEdit.EditValue) : 0;
            var frm = new FrmAddNewPropertyGroupByParentId(0, idCategory, 1);
            frm.Text = "Thêm node cha!!!"; frm.ShowDialog();
            InitData();
        }

        private bool _isExpand = false;
        private void btnExpandGroup_Click(object sender, EventArgs e)
        {
            if (_isExpand)
            {
                treeListPropertyGroup.ExpandAll();
                _isExpand = false;
            }
            else
            {
                treeListPropertyGroup.CollapseAll();
                _isExpand = true;
            }
        }
        private void btnAddPropertyInGroup_Click(object sender, EventArgs e)
        {
            var groupid = Convert.ToInt32(idTextEdit.Text);
            var categoryId = Convert.ToInt32(categoryIdLookUpEdit.EditValue);
            var frm = new FrmPropertyByGroup(groupid, categoryId)
            {
                Text = @"Thuộc tính(Property) trong Group: " + nameTextEdit.Text
            };
            frm.Show();
        }
    }
}
