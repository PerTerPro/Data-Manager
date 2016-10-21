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
    public partial class FrmItemProperties : Form
    {
        private int _itemId;
        private int _categoryId;
        public FrmItemProperties()
        {
            InitializeComponent();
        }
        public FrmItemProperties(int item, int categoryId)
        {
            InitializeComponent();
            _itemId = item;
            _categoryId = categoryId;
        }

        private void itemPropertiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.itemPropertiesBindingSource.EndEdit();
                this.itemPropertiesTableAdapter.Update(this.dBFinancial.ItemProperties);

                MessageBox.Show(@"Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmItemProperties_Load(object sender, EventArgs e)
        {
            this.propertyValueTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.propertyTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.itemPropertiesTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;

            try
            {
                this.propertyValueTableAdapter.Fill(this.dBFinancial.PropertyValue);
                this.propertyTableAdapter.FillBy_CategoryId(this.dBFinancial.Property, _categoryId);
                this.itemPropertiesTableAdapter.FillBy_Item(this.dBFinancial.ItemProperties, _itemId);
                this.itemTableAdapter.FillBy_Id(this.dBFinancial.Item, _itemId);
                this.dBFinancial.ItemProperties.Columns["ItemId"].DefaultValue = _itemId;
                //this.dBFinancial.ItemProperties.Columns["PropertyValueId"].DefaultValue = 0;
                itemIdTextEdit.Text = _itemId.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }



        }
    }
}
