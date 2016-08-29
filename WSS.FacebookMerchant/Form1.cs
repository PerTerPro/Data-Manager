using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QT.Entities;

namespace WSS.FacebookMerchant
{
    public partial class Form1 : Form
    {
        private string _connectionString = "";
        public Form1()
        {
            InitializeComponent();
            _connectionString = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        }

        private void merchant_FacebookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.merchant_FacebookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBFacebook);
            MessageBox.Show("Save thành công!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBFacebook.Merchant_Facebook' table. You can move, or remove it, as needed.
            this.merchant_FacebookTableAdapter.Connection.ConnectionString = _connectionString;
            this.merchant_FacebookTableAdapter.Fill(this.dBFacebook.Merchant_Facebook);

            DataTable dtTypeTable = new DataTable();
            dtTypeTable.Columns.Add("Type", typeof (string));
            dtTypeTable.Columns.Add("Value", typeof(int));
            DataRow dr = dtTypeTable.NewRow();
            dr["Type"] = "Fanpage";
            dr["Value"] = 1;
            dtTypeTable.Rows.Add(dr);
            DataRow dr2 = dtTypeTable.NewRow();
            dr2["Type"] = "Cá nhân";
            dr2["Value"] = 2;
            dtTypeTable.Rows.Add(dr2);
            typeFanpageLookUpEdit.Properties.DataSource = dtTypeTable;

            DataTable dtStatus = new DataTable();
            dtStatus.Columns.Add("Status", typeof(string));
            dtStatus.Columns.Add("Value", typeof(int));
            DataRow drx = dtStatus.NewRow();
            drx["Status"] = "Done";
            drx["Value"] = 1;
            dtStatus.Rows.Add(drx);
            DataRow drx2 = dtStatus.NewRow();
            drx2["Status"] = "New";
            drx2["Value"] = 0;
            dtStatus.Rows.Add(drx2);
            statusLookUpEdit.Properties.DataSource = dtStatus;
        }

        private void domainTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            merchantIdTextEdit.Text = Common.GetIDCompany(domainTextEdit.Text).ToString();
        }

        private void domainTextEdit_TextChanged(object sender, EventArgs e)
        {
            merchantIdTextEdit.Text = Common.GetIDCompany(domainTextEdit.Text).ToString();
            statusLookUpEdit.EditValue = 1;
            typeFanpageLookUpEdit.EditValue = 1;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var xmlStream = new FileStream("DomainFacebookChat.xml", FileMode.Open, FileAccess.Read);
            //var xmlDocument = XDocument.Load(xmlStream);
            //var domainNodes = xmlDocument.Descendants("DomainFacebookChat");
            //foreach (var item in domainNodes)
            //{
            //    richTextBox1.AppendText(item.Value);
            //}

            //string filePath = Path.Combine(
            //                HostingEnvironment.ApplicationPhysicalPath,
            //                @"App_Data\DomainFacebookChat.xml"
            //            );

            //Load xml
            XDocument xdoc = XDocument.Load(xmlStream);

            //Run query
            var result = (from domain in xdoc.Descendants("domain")
                          select new
                          {
                              Domain = domain.Attribute("name").Value,
                              MerchantId = Common.Obj2Int64(domain.Attribute("data-id").Value),
                              UrlFanpageFacebook = domain.Attribute("data-url").Value
                          }).ToList();
            foreach (var item in result)
            {
                try
                {
                    merchant_FacebookTableAdapter.Insert(item.MerchantId, item.UrlFanpageFacebook, 1, 1, item.Domain);
                }
                catch (Exception)
                { 
                }
            }
        }
    }
}
