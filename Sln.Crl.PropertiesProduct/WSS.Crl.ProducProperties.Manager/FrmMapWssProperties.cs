using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSS.LibExtra;


namespace WSS.Crl.ProducProperties.Manager
{
    public partial class FrmMapWssProperties : Form
    {
        private long companyId = 0;
        public FrmMapWssProperties()
        {
            InitializeComponent();
            
        }
        public FrmMapWssProperties(long CompanyID)
        {
            this.companyId = CompanyID;
            
            InitializeComponent();
            repositoryItemSearchLookUpEdit1.EditValueChanged += repositoryItemSearchLookUpEdit1_EditValueChanged;
        }

        public void repositoryItemSearchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            long PropertyID = CommonConvert.Obj2Int64((this.gridView1.GetRow(this.gridView1.FocusedRowHandle) as DataRowView)["ID"]);
            var searchLookUpEdit = sender as SearchLookUpEdit;
            if (searchLookUpEdit == null)
                return;

            DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit riSearchLookUpEdit = searchLookUpEdit.Properties as DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit;
            var rowByKeyValue = riSearchLookUpEdit.View.GetFocusedRowCellValue("ID");
            long PropertyRootID = CommonConvert.Obj2Int64(rowByKeyValue);
            this.propertiesMerchantTableAdapter.Connection.ConnectionString = ConfigurationManager.AppSettings["MerchantProperties"];
            this.propertiesMerchantTableAdapter.Update_RootProperty(PropertyRootID, PropertyID);
        }

        private void FrmMapWssProperties_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'productQT.PropertiesWss' table. You can move, or remove it, as needed.
            this.propertiesWssTableAdapter.Fill(this.productQT.PropertiesWss);
            // TODO: This line of code loads data into the 'productQT.PropertiesMerchant' table. You can move, or remove it, as needed.
            this.propertiesMerchantTableAdapter.Connection.ConnectionString = ConfigurationManager.AppSettings["MerchantProperties"];
            this.propertiesMerchantTableAdapter.FillBy_ID(this.productQT.PropertiesMerchant, companyId);
            //this.propertiesMerchantTableAdapter.Fill(this.productQT.PropertiesMerchant);
            
        }

        private void propertiesMerchantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.propertiesMerchantBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.productQT);
        }
    }
}
