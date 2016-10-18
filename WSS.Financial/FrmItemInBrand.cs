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
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.itemTableAdapter.Update(this.dBFinancial.Item);

        }

        private void FrmItemInBrand_Load(object sender, EventArgs e)
        {
            brandTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            categoryTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            itemTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            try
            {
                this.brandTableAdapter.Fill(this.dBFinancial.Brand);
                this.categoryTableAdapter.Fill(this.dBFinancial.Category);
                if (_brandId == 0)
                {
                    this.itemTableAdapter.Fill(this.dBFinancial.Item);
                }
                else
                {
                    this.itemTableAdapter.FillBy_BrandId(this.dBFinancial.Item, _brandId);
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            

        }
    }
}
