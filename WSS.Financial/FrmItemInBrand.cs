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
    public partial class FrmItemInBrand : Form
    {
        private int _brandId;
        public FrmItemInBrand()
        {
            InitializeComponent();
        }
        public FrmItemInBrand(int brandId)
        {
            InitializeComponent();
            _brandId = brandId;
        }
        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.itemBindingSource.EndEdit();
                this.itemTableAdapter.Update(this.dBFinancial.Item);

                MessageBox.Show(@"Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmItemInBrand_Load(object sender, EventArgs e)
        {
            brandTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            categoryTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            itemTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            ctrCategory1.InitControl();
            try
            {
                this.brandTableAdapter.Fill(this.dBFinancial.Brand);
                this.categoryTableAdapter.Fill(this.dBFinancial.Category);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void InitData()
        {
            try
            {
                if (_brandId != 0)
                {
                    var categoryId = ctrCategory1.GetIdCategoryCurrent();
                    this.itemTableAdapter.FillBy_BrandAndCategory(this.dBFinancial.Item, _brandId, categoryId);
                    this.dBFinancial.Item.Columns["BrandId"].DefaultValue = _brandId;
                    this.dBFinancial.Item.Columns["CategoryId"].DefaultValue = categoryId;
                    brandIdLookUpEdit.EditValue = _brandId;
                    categoryIdLookUpEdit.EditValue = categoryId;
                }

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

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (_brandId == 0)
                {
                    this.itemTableAdapter.Fill(this.dBFinancial.Item);
                }
                else
                {
                    this.itemTableAdapter.FillBy_BrandId(this.dBFinancial.Item, _brandId);
                    this.dBFinancial.Item.Columns["BrandId"].DefaultValue = _brandId;
                    brandIdLookUpEdit.EditValue = _brandId;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnItemProperties_Click(object sender, EventArgs e)
        {
            var itemId = Convert.ToInt32(idTextEdit.Text);
            var categoryId = Convert.ToInt32(categoryIdLookUpEdit.EditValue);
            var frm = new FrmItemProperties(itemId, categoryId)
            {
                Text = @"Chọn thuộc tính cho Item: " + nameTextEdit.Text
            };
            frm.Show();
        }
    }
}
