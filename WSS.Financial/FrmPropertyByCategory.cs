using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Financial.Backend
{
    public partial class FrmPropertyByCategory : Form
    {
        public FrmPropertyByCategory()
        {
            InitializeComponent();
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

        private void FrmProperty_Load(object sender, EventArgs e)
        {
            propertyValueTypeTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            categoryTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            propertyGroupTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            propertyTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            propertyValueTypeTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            ctrCategory1.InitControl();try
            {
                propertyValueTypeTableAdapter.Fill(dBFinancial.PropertyValueType);
                categoryTableAdapter.Fill(dBFinancial.Category);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void InitData(int categoryId)
        {
            try
            {
                propertyGroupTableAdapter.FillBy_CategoryId(dBFinancial.PropertyGroup,categoryId);
                propertyTableAdapter.FillBy_CategoryId(dBFinancial.Property, categoryId);
                dBFinancial.Property.Columns["CategoryId"].DefaultValue = categoryId;
                //dBFinancial.Property.Columns["GroupId"].DefaultValue = 0;
                dBFinancial.Property.Columns["ViewOrder"].DefaultValue = 0;
                dBFinancial.Property.Columns["Unit"].DefaultValue = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ctrCategory1_IdCategoryChanged(EventArgs e)
        {
            var categoryId = ctrCategory1.GetIdCategoryCurrent();
            InitData(categoryId);
        }
    }
}
