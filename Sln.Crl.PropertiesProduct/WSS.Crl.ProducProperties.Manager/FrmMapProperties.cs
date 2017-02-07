using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSS.Crl.ProducProperties.Core;

namespace WSS.Crl.ProducProperties.Manager
{
    public partial class FrmMapProperties : Form
    {

        private long companyId = 0;
        private ProductPropertiesAdapter productPropertiesAdapter = new ProductPropertiesAdapter();

        public FrmMapProperties()
        {
            InitializeComponent();
        }

        public FrmMapProperties(long companyId)
        {
            // TODO: Complete member initialization
            this.companyId = companyId;
            InitializeComponent();
        }

        private void FrmMapProperties_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productQT.PropertiesWss' table. You can move, or remove it, as needed.
            this.propertiesWssTableAdapter.Fill(this.productQT.PropertiesWss);
          
            RefrehData();
        }

        private void RefrehData()
        {
            // TODO: This line of code loads data into the 'productQT.Product_PropertyCategory' table. You can move, or remove it, as needed.
            this.product_PropertyCategoryTableAdapter.FillByCompanyId(this.productQT.Product_PropertyCategory, this.companyId);
        }

        private void product_PropertyCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.product_PropertyCategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productQT);
        }
    }
}
