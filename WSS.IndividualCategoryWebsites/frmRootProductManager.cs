using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using QT.Entities;
using Websosanh.Core.Drivers.Solr;
using WSS.IndividualCategoryWebsites.SolrRootProduct;

namespace WSS.IndividualCategoryWebsites
{
    public partial class frmRootProductManager : Form
    {
        private int _websiteId;
        private string _domain;
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmAddTagsWebsites));
        private SolrRootProductClient _solrRootProductClient;
        public frmRootProductManager()
        {
            InitializeComponent();
        }
        public frmRootProductManager(int websiteId, string domain)
        {
            InitializeComponent();
            _websiteId = websiteId;
            _domain = domain;
        }

        private void InitSolr()
        {
            _solrRootProductClient =
                SolrRootProductClient.GetClient(SolrClientManager.GetSolrClient("solrRootProducts"));
        }
        private void frmRootProductManager_Load(object sender, EventArgs e)
        {
            InitSolr();
            rootProductsTableAdapter.Connection.ConnectionString = WssConnection.ConnectionIndividual;
            try
            {
                rootProductsTableAdapter.FillByWebsiteId(dBIndi.RootProducts, _websiteId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Load RootProduct Error: " + ex.Message);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                _solrRootProductClient.DeleteByWebsiteId(_websiteId);
                rootProductsTableAdapter.DeleteByWebsiteId(_websiteId);
                //_solrRootProductClient.DeleteAll();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnReplaceName_Click(object sender, EventArgs e)
        {
            if (this.txtNoiDungMuonThay.Text.Trim().Length <= 0)
            {
                Wait.Show("Phải nhập nội dung");
                Wait.Close();
                this.txtNoiDungMuonThay.Focus();
            }
            else if (this.txtNoiDungThayBang.Text.Trim().Length <= 0)
            {
                Wait.Show("Phải nhập nội dung");
                Wait.Close();
                this.txtNoiDungThayBang.Focus();
            }
            else
            {
                this.rootProductsBindingSource.MoveFirst();
                for (int i = 0; i < this.rootProductsBindingSource.Count; i++)
                {
                    this.nameTextEdit.Text = this.nameTextEdit.Text.Replace('\"', ' ').Trim();
                    var textmuonthay = txtNoiDungMuonThay.Text.Trim();
                    Wait.Show(string.Format("{0}/{1}", i, rootProductsBindingSource.Count));
                    if (nameTextEdit.Text.Trim().Length > textmuonthay.Length)
                    {
                        if (nameTextEdit.Text.Trim().Substring(0, textmuonthay.Length) == textmuonthay)
                        {
                            this.nameTextEdit.Text = this.nameTextEdit.Text.Trim().Replace(textmuonthay, txtNoiDungThayBang.Text.Trim());
                        }
                    }
                    
                    this.rootProductsBindingSource.MoveNext();
                }
                Wait.Close();
            }
        }

        private void bthUpdateCategory_Click(object sender, EventArgs e)
        {
            int categoryOld = Common.Obj2Int(txtCategoryOld.Text);
            int categoryNew = Common.Obj2Int(txtCategoryNew.Text);
            if (categoryOld == 0)
            {
                Wait.Show("Phải nhập category muốn thay đổi!");
                Wait.Close();
                this.txtCategoryOld.Focus();
            }
            else if (categoryNew == 0)
            {
                Wait.Show("Phải nhập category mới");
                Wait.Close();
                this.txtCategoryNew.Focus();
            }
            else
            {
                this.rootProductsBindingSource.MoveFirst();
                for (int i = 0; i < this.rootProductsBindingSource.Count; i++)
                {
                    if (Common.Obj2Int(categoryIdTextEdit.Text) == categoryOld)
                    {
                        categoryIdTextEdit.Text = categoryNew.ToString();
                    }
                    this.rootProductsBindingSource.MoveNext();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.rootProductsBindingSource.EndEdit();
                this.rootProductsTableAdapter.Update(this.dBIndi.RootProducts);
                foreach (var item in dBIndi.RootProducts)
                {
                    if (item.IsActive)
                    {
                        var rootProduct = new SolrRootProductItem
                        {
                            Id = item.Id,
                            Name = item.Name,
                            Image = item.Image,
                            LocalPath = item.LocalPath,
                            MinPrice = item.MinPrice,
                            NumMerchant = item.NumMerchant,
                            WebsiteId = item.WebsiteId,
                            CategoryId = item.CategoryId
                        };
                        try
                        {
                            _solrRootProductClient.Insert(rootProduct);
                        }
                        catch (Exception exException)
                        {
                            Log.Error(exException);
                            //throw;
                        }
                    }
                    else
                    {
                        try
                        {
                            _solrRootProductClient.Delete(item.Id);
                        }
                        catch (Exception exException)
                        {
                            Log.Error(exException);
                            //throw;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Lưu lỗi r !! " + exception.Message);
            }
        }

        private void btnActiveAll_Click(object sender, EventArgs e)
        {
            Wait.Show("...");
            try
            {
                foreach (var item in dBIndi.RootProducts)
                {
                    item.IsActive = true;
                }
                this.rootProductsBindingSource.EndEdit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            Wait.Close();
        }

        private void btnUnActiveAll_Click(object sender, EventArgs e)
        {
            Wait.Show("...");
            try
            {
                foreach (var item in dBIndi.RootProducts)
                {
                    item.IsActive = false;
                }
                this.rootProductsBindingSource.EndEdit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            Wait.Close();
        }
        
    }
}
