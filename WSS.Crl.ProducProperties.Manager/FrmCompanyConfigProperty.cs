using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities;
using QT.Entities.Data;
using WSS.Crl.ProducProperties.Core;

namespace WSS.Crl.ProducProperties.Manager
{
    public partial class FrmCompanyConfigProperty : Form
    {

        private SqlDb _sqlDb = new SqlDb(Server.ConnectionString);
        private long companyId;

        public FrmCompanyConfigProperty()
        {
            InitializeComponent();
        }

        public FrmCompanyConfigProperty(long companyId)
        {
            // TODO: Complete member initialization
            this.companyId = companyId;
            InitializeComponent();
        }

        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productQT);

        }



        private void FrmCompanyConfigProperty_Load(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void RefreshData()
        {
            // TODO: This line of code loads data into the 'productQT.Configuration_Property' table. You can move, or remove it, as needed.
            this.configuration_PropertyTableAdapter.FillBy(this.productQT.Configuration_Property, this.companyId);
            // TODO: This line of code loads data into the 'productQT.Configuration' table. You can move, or remove it, as needed.
            this.configurationTableAdapter.FillByCompanyID(this.productQT.Configuration, this.companyId);
            // TODO: This line of code loads data into the 'productQT.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.FillByID(this.productQT.Company, this.companyId);
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }

        private ConfigPropertySql GetConfig()
        {
            return new ConfigPropertySql()
            {
                CompanyId = this.companyId,
                TypeLayout = this.typeLayoutComboBox.SelectedIndex,
                XPath = this.xPathTextBox.Text,
                JSonOtherConfig = this.jSonOtherConfigMemoEdit.Text,
                CategoryXPath = this.categoryXPathTextBox.Text,
                UrlTest = this.urlTestTextBox.Text
            };
        }

        private void SaveData()
        {

            ConfigPropertySql conf = this.GetConfig();
            var bOk = this._sqlDb.RunQuery(@"

Update Configuration 
set CategoryXPath = @CategoryXPath
Where CompanyID = @CompanyId

IF Not Exists (Select Id From Configuration_Property cp Where CompanyId = @CompanyId)
Begin
    Insert Into Configuration_Property  (CompanyId, TypeLayout, XPath, JSonOtherConfig, UrlTest)
    Values (@CompanyId, @TypeLayout, @XPath, @JSonOtherConfig, @UrlTest)
End
Else 
Begin
    Update Configuration_Property Set TypeLayout=@TypeLayout, XPath=@XPath, JSonOtherConfig=@JSonOtherConfig, UrlTest = @UrlTest
    WHere CompanyId = @CompanyId
End
", CommandType.Text, new SqlParameter[]
            {
                SqlDb.CreateParamteterSQL("CompanyId", conf.CompanyId, SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("TypeLayout", conf.TypeLayout, SqlDbType.Int),
                SqlDb.CreateParamteterSQL("XPath", conf.XPath, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("JSonOtherConfig", conf.JSonOtherConfig, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("CategoryXPath", conf.CategoryXPath, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("UrlTest", conf.UrlTest, SqlDbType.NVarChar),
            });

            this.RefreshData();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
