using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using WSS.Crl.ProducProperties.Core;
using WSS.Crl.ProducProperties.Core.DI;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Parser;
using WSS.Crl.ProducProperties.Core.Storage;
using WSS.LibExtra;
using HtmlDocument = GABIZ.Base.HtmlAgilityPack.HtmlDocument;

namespace WSS.Crl.ProducProperties.Manager
{
    public partial class FrmCompanyConfigProperty : Form
    {

       
        private long companyId;
        private IStorageConfigCrl _storageConfigCrl;

        public FrmCompanyConfigProperty()
        {
            InitializeComponent();

            Init();
        }

        public FrmCompanyConfigProperty(long companyId)
        {
            // TODO: Complete member initialization
            this.companyId = companyId;
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            var kernel = new StandardKernel(new DomainModule());
            _storageConfigCrl = kernel.Get<IStorageConfigCrl>();
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

        private void RefreshData(){
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

        private WSS.Crl.ProducProperties.Core.Entity.ConfigProperty GetConfig()
        {
            return new ConfigProperty()
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
           

            ConfigProperty conf = this.GetConfig();this._storageConfigCrl.Save(conf);
           
            this.RefreshData();

            MessageBox.Show("Saved");}
        private void btnTest_Click(object sender, EventArgs e)
        {
            string urlTest = linkTestTextBox.Text;
            IDownloadHtml dowloadHtml = new DownloadHtmlCrawler();
            WebExceptionStatus webExceptionStatus = WebExceptionStatus.Success;
            string html = System.Web.HttpUtility.HtmlDecode(dowloadHtml.GetHtml(urlTest, 45, 2, out webExceptionStatus));
            if (!string.IsNullOrEmpty(html))
            {
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);

              
                var kerner = new StandardKernel(new DomainModule());
                IParser parseNormal = kerner.Get<IParser>();
                parseNormal.Init(domainTextBox.Text);
                var propertiesData = parseNormal.ParseData(htmlDocument);
                if (propertiesData != null)
                {
                    txtProductTest.Text = propertiesData.GetJSonDisplay();
                }
            }
            else
            {
                MessageBox.Show("Can't download html");
            }
        }

        public string domain { get; set; }
    }
}
