using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.Components.DictionaryAdapter;
using DevExpress.XtraGrid.Views.Grid;
using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.Images;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.Drivers.Solr;
using WSS.IndividualCategoryWebsites.SolrProduct;
using WSS.IndividualCategoryWebsites.DBIndiTableAdapters;
using WSS.IndividualCategoryWebsites.DBPrdTableAdapters;

namespace WSS.IndividualCategoryWebsites
{
    public partial class frmGetProductFromSolr : Form
    {
        #region Private
        private SolrProductClient solrProductClient;
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmGetProductFromSolr));
        private int _websiteId = 1;
        public const string IGNORE_CHARS = "/()^!?:~[]{}\\=©®°™ - |`<>\"";
        private string _domain;
        private List<SolrProductItem> _listSolrProductItemsTemp = new List<SolrProductItem>();
        private Dictionary<long, SolrProductItem> _dictionarySolrProductItemsSelected = new Dictionary<long,SolrProductItem>();
        private DBPrdTableAdapters.ProductTableAdapter _productTableAdapter = new ProductTableAdapter();
        #endregion
        #region Constructor
        public frmGetProductFromSolr()
        {
            InitializeComponent();

        }
        public frmGetProductFromSolr(int idwebsite, string domain)
        {
            InitializeComponent();
            _websiteId = idwebsite;
            txtWebsiteId.Text = _websiteId.ToString();
            _domain = domain;
            txtDomain.Text = domain;

        }
        #endregion
        #region Load Data
        private void frmGetProductFromSolr_Load(object sender, EventArgs e)
        {
            this.logKeywordsWebsiteTableAdapter.Connection.ConnectionString = WssConnection.ConnectionIndividual;
            _productTableAdapter.Connection.ConnectionString = WssConnection.ConnectionProduct;
            solrProductClient = SolrProductClient.GetClient(SolrClientManager.GetSolrClient("solrProducts"));
            LoadLogKeywordsWebsite();
        }

        private void LoadLogKeywordsWebsite()
        {
            try
            {
                logKeywordsWebsiteTableAdapter.FillBy_WebsiteId(dBIndi.LogKeywordsWebsite, _websiteId);
                this.dBIndi.LogKeywordsWebsite.Columns["WebsiteId"].DefaultValue = _websiteId;
                this.dBIndi.LogKeywordsWebsite.Columns["MinPrice"].DefaultValue = 0;
                this.dBIndi.LogKeywordsWebsite.Columns["MaxPrice"].DefaultValue = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        #endregion
        private void btnGetListProductFromSolr_Click(object sender, EventArgs e)
        {
            _listSolrProductItemsTemp.Clear();
            if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                MessageBox.Show(@"Nhập từ khóa!");
                txtKeyword.Focus();
            }
            else
            {
                Wait.Show("Loading...");
                var listkeywords = txtKeyword.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var listKeywordsBlock = rbKeywordBlock.Text.Replace('\n', ',').Trim().Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries).ToList();
                var listIdBlock = rbListIdBlock.Text.Replace('\n', ',').Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                long minPrice = Common.Obj2Int64(spinEditMinPrice.EditValue);
                long maxPrice = Common.Obj2Int64(spinEditMaxPrice.EditValue);
                int numberFound;
                int categoryId = Common.Obj2Int(txtCategoryId.Text);
                if (categoryId > 0)
                {
                    grdCategory.DataSource = null;
                    _listSolrProductItemsTemp = solrProductClient.GetProductByProductIdentityRequestAndCategory(listkeywords,
                        listKeywordsBlock,
                        listIdBlock,categoryId, minPrice, maxPrice, 0, 1000000, out numberFound);
                    foreach (var product in _listSolrProductItemsTemp)
                    {
                        product.WebsiteId = _websiteId;
                    }
                    grdProduct.DataSource = _listSolrProductItemsTemp;
                    txtNumberFound.Text = numberFound.ToString();
                }
                else

                {
                    var resultCategory = solrProductClient.GetListCategoryProductByKeyword(listkeywords,
                        listKeywordsBlock,
                        listIdBlock, minPrice, maxPrice, 0, 1, out numberFound);
                    grdCategory.DataSource = resultCategory;
                    _listSolrProductItemsTemp = solrProductClient.GetProductByProductIdentityRequest(listkeywords,
                        listKeywordsBlock,
                        listIdBlock, minPrice, maxPrice, 0, numberFound, out numberFound);
                    foreach (var product in _listSolrProductItemsTemp)
                    {
                        product.WebsiteId = _websiteId;
                    }
                    grdProduct.DataSource = _listSolrProductItemsTemp;
                    txtNumberFound.Text = numberFound.ToString();
                }
                Wait.Close();
            }
        }

        private void btnPushAllProductToServiceRootProduct_Click(object sender, EventArgs e)
        {
            var listSolrProductItemsSelected = new List<SolrProductItem>();
            foreach (var item in _dictionarySolrProductItemsSelected)
            {
                listSolrProductItemsSelected.Add(item.Value);
            }
            var jsonobject = JsonConvert.SerializeObject(listSolrProductItemsSelected);
            SendMessageToServiceRootProduct(jsonobject);
        }

        #region Method
        private void SendMessageToServiceRootProduct(string jsonObject)
        {
            var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigRabbitMqIndividualCategoryWebsites.RabbitMqServerName);
            var individualJobClient = new ProducerBasic(rabbitMqServer, ConfigRabbitMqIndividualCategoryWebsites.ExchangeIndividual, ConfigRabbitMqIndividualCategoryWebsites.RoutingKeyProduct);
            while (true)
            {
                try
                {
                    individualJobClient.Publish(UtilZipFile.Zip(jsonObject));
                    Log.Info(string.Format("Push message to services success."));
                    break;
                }
                catch (Exception exception)
                {
                    Log.Error(string.Format("Push message error."), exception);
                    Thread.Sleep(60000);
                }
            }
        }
        public void GetRowAt(GridView view, int x, int y)
        {
            if (view == gvCategory)
            {
                txtCategoryId.Text = gvCategory.GetRowCellValue(view.CalcHitInfo(new Point(x, y)).RowHandle, "CategoryId").ToString();
                txtCategoryName.Text =
                    gvCategory.GetRowCellValue(view.CalcHitInfo(new Point(x, y)).RowHandle, "CategoryName").ToString();
            }
        }
        #endregion
        #region Event Gridcontrol
        private void gvCategory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripCategory.Show(this.grdCategory, new Point(e.X, e.Y));
                GetRowAt(gvCategory, e.X, e.Y);
            }
        }
        private void gvProduct_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripProduct.Show(this.grdProduct, new Point(e.X, e.Y));
            }
        }
        private void gvCategory_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                txtCategoryId.Text = gvCategory.GetRowCellValue(e.RowHandle, "CategoryId").ToString();
                txtCategoryName.Text = gvCategory.GetRowCellValue(e.RowHandle, "CategoryName").ToString();
            }
        }
        #endregion
        #region Event Button
        private void ViewDetailProductWithCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wait.Show("Loading...");
            _listSolrProductItemsTemp.Clear();
            var listkeywords = txtKeyword.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var listKeywordsBlock = rbKeywordBlock.Text.Replace('\n', ',').Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var listIdBlock = rbListIdBlock.Text.Replace('\n', ',').Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            long minPrice = Common.Obj2Int64(spinEditMinPrice.Value);
            long maxPrice = Common.Obj2Int64(spinEditMaxPrice.Value);
            int categoryId = Common.Obj2Int(txtCategoryId.Text);
            int numberFound;
            _listSolrProductItemsTemp = solrProductClient.GetProductByProductIdentityRequestAndCategory(listkeywords, listKeywordsBlock,
                listIdBlock, categoryId, minPrice, maxPrice, 0, Common.Obj2Int(txtNumberFound.Text), out numberFound);
            foreach (var product in _listSolrProductItemsTemp)
            {
                product.WebsiteId = _websiteId;
            }
            grdProduct.DataSource = _listSolrProductItemsTemp;
            Wait.Close();
        }
        private void ViewAllProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
            _listSolrProductItemsTemp.Clear();
            Wait.Show("Loading...");
            var listkeywords = txtKeyword.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var listKeywordsBlock = new List<string>();
            listKeywordsBlock = rbKeywordBlock.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var listIdBlock = new List<string>();
            listIdBlock = rbListIdBlock.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            long minPrice = Common.Obj2Int64(spinEditMinPrice.Text);
            long maxPrice = Common.Obj2Int64(spinEditMaxPrice.Text);
            int numberFound;
            _listSolrProductItemsTemp = solrProductClient.GetProductByProductIdentityRequest(listkeywords, listKeywordsBlock,
                listIdBlock, minPrice, maxPrice, 0, Common.Obj2Int(txtNumberFound.Text), out numberFound);
            foreach (var product in _listSolrProductItemsTemp)
            {
                product.WebsiteId = _websiteId;
            }
            grdProduct.DataSource = _listSolrProductItemsTemp;
            Wait.Close();
        }
        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGetListProductFromSolr_Click(sender, e);
            }
        }

        private void selectListProductToServiceRootProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var arrIndexRowSelected = gvProduct.GetSelectedRows();
            if (arrIndexRowSelected.Length > 0)
            {
                foreach (var rowHande in arrIndexRowSelected)
                {
                    long id = Common.Obj2Int64(gvProduct.GetRowCellValue(rowHande, "Id"));
                    if (!_dictionarySolrProductItemsSelected.ContainsKey(id))
                    {
                        var productItem = new SolrProductItem
                        {
                            Id = id,
                            Name = gvProduct.GetRowCellValue(rowHande, "Name").ToString(),
                            Price = Common.Obj2Int64(gvProduct.GetRowCellValue(rowHande, "Price")),
                            MerchantScore = Common.Obj2Int(gvProduct.GetRowCellValue(rowHande, "MerchantScore")),
                            CategoryId = Common.Obj2Int(gvProduct.GetRowCellValue(rowHande, "CategoryId")),
                            WebsiteId = _websiteId
                        };
                        _dictionarySolrProductItemsSelected.Add(id,productItem);
                    }
                }
                txtCountProductSelected.Text = _dictionarySolrProductItemsSelected.Count.ToString();
            }
            else
                MessageBox.Show(@"0 sản phẩm được chọn...");
        }
        private void btnLoadListKeywordsWebsite_Click(object sender, EventArgs e)
        {
            LoadLogKeywordsWebsite();
        }

        private void btnSaveLogKeywords_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.logKeywordsWebsiteBindingSource.EndEdit();
                this.logKeywordsWebsiteTableAdapter.Update(this.dBIndi.LogKeywordsWebsite);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        #endregion

        private void keywordTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            idKeywordTextEdit.Text = Common.GetID_Keywords(keywordTextEdit.Text).ToString();
        }

        private void btnSaveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                logKeywordsWebsiteTableAdapter.Insert(Common.GetID_Keywords(txtKeyword.Text), txtKeyword.Text,
                    rbKeywordBlock.Text,
                    _websiteId, true, Common.Obj2Int(txtCategoryId.Text),
                    rbListIdBlock.Text,
                    Common.Obj2Int64(spinEditMinPrice.EditValue), Common.Obj2Int64(spinEditMaxPrice.EditValue));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            LoadLogKeywordsWebsite();
        }

        private void previewDataWithLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtKeyword.Text = keywordTextEdit.Text;
            rbKeywordBlock.Text = richTextBoxKeywordBlock.Text;
            rbListIdBlock.Text = richTextBoxListIdBlock.Text;
            spinEditMinPrice.EditValue = spinEditMinpriceSql.EditValue;
            spinEditMaxPrice.EditValue = spinEditMaxpriceSql.EditValue;
            txtCategoryId.Text = categoryIdSelectedTextEdit.Text;
        }

        private void selectProductToRootProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var arrIndexRowSelected = gvProduct.GetSelectedRows();
            if (arrIndexRowSelected.Length > 0)
            {
                long minprice = 0;
                var rootProductSql = new RootProductSql()
                {
                    RootId = Common.Obj2Int64(gvProduct.GetRowCellValue(0, "Name")),
                    Name = gvProduct.GetRowCellValue(0, "Name").ToString(),
                    WebsiteId = _websiteId,
                    NumMerchant = arrIndexRowSelected.Length,
                    CategoryId = Common.Obj2Int(txtCategoryId.Text)
                };
                rootProductSql.LocalPath =
                    Websosanh.Core.Common.BAL.UrlUtilities.GetRootProductLocalPath(rootProductSql.RootId,
                        rootProductSql.Name);
                rootProductSql.ProductIdList = new List<long>();
                var imagePath = "";
                foreach (var rowHande in arrIndexRowSelected)
                {
                    long id = Common.Obj2Int64(gvProduct.GetRowCellValue(rowHande, "Id"));
                    rootProductSql.ProductIdList.Add(id);
                    long price = Common.Obj2Int64(gvProduct.GetRowCellValue(rowHande, "Price"));
                    if (!(minprice > 0 && minprice < price))
                        minprice = price;
                    if (string.IsNullOrEmpty(imagePath))
                    {
                        imagePath = GetImagePath(id);
                    }
                    RemoveToDictionarySelected(id);
                }
                rootProductSql.MinPrice = minprice;
                rootProductSql.Image = imagePath;

                rootProductSql.ProductIdListString = rootProductSql.GetProductIdListString();
                //comment tam.
                //InsertSQlRootProduct(rootProductSql);
            }
            else
                MessageBox.Show(@"0 sản phẩm được chọn...");
        }

        private void RemoveToDictionarySelected(long id)
        {
            _dictionarySolrProductItemsSelected.Remove(id);

        }

        private void btnViewListProduct_Click(object sender, EventArgs e)
        {
            var listSelected = _dictionarySolrProductItemsSelected.Select(item => item.Value).ToList();
            grdProduct.DataSource = listSelected;
        }
        //comment tam.
        //private bool InsertSQlRootProduct(RootProductSql rootProductSql)
        //{
        //    RootProductsTableAdapter rootAdapter = new RootProductsTableAdapter();
        //    bool isUpdateSolr = false;
        //    try
        //    {
        //        DBIndi.RootProductsDataTable rootTable = new DBIndi.RootProductsDataTable();
        //        rootAdapter.FillBy_Id(rootTable, rootProductSql.RootId);
        //        if (rootTable.Rows.Count > 0)
        //        {
        //            bool isActive = Common.Obj2Bool(rootTable.Rows[0]["IsActive"]);
        //            if (isActive)
        //            {
        //                var listProductIdOld =
        //                    rootTable.Rows[0]["LocalPath"].ToString()
        //                        .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
        //                        .ToList();
        //                foreach (var item in rootProductSql.ProductIdList)
        //                {
        //                    if (!listProductIdOld.Contains(item.ToString()))
        //                    {
        //                        listProductIdOld.Add(item.ToString());
        //                    }
        //                }
        //                rootProductSql.ProductIdListString = string.Join(",", listProductIdOld);
        //                rootProductSql.Name = rootTable.Rows[0]["Name"].ToString();
        //                rootProductSql.LocalPath = rootTable.Rows[0]["LocalPath"].ToString();
        //                rootProductSql.CategoryId = Common.Obj2Int(rootTable.Rows[0]["CategoryId"]);
        //                //Update SQL
        //                rootAdapter.UpdateIfIsActive(rootProductSql.MinPrice, rootProductSql.NumMerchant,
        //                    rootProductSql.ProductIdListString, rootProductSql.Image, rootProductSql.RootId);
        //                isUpdateSolr = true;
        //            }
        //            else
        //            {
        //                rootAdapter.UpdateQuery(rootProductSql.Name, rootProductSql.WebsiteId,
        //                rootProductSql.MinPrice, rootProductSql.NumMerchant, rootProductSql.LocalPath,
        //                rootProductSql.ProductIdListString, rootProductSql.Image, rootProductSql.CategoryId,
        //                rootProductSql.Image, false, rootProductSql.RootId);
        //            }
        //        }
        //        else
        //        {
        //            rootAdapter.Insert(rootProductSql.RootId, rootProductSql.Name, rootProductSql.WebsiteId,
        //                rootProductSql.MinPrice, rootProductSql.NumMerchant, rootProductSql.LocalPath,
        //                rootProductSql.ProductIdListString, rootProductSql.Image, rootProductSql.CategoryId,
        //                rootProductSql.Image, false);
        //            Log.Info("insert success" + rootProductSql.RootId);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Error(string.Format("Insert SQL error with Id ={0} , Name = {1} {2}", rootProductSql.RootId,
        //            rootProductSql.Name, ex.Message + ex.StackTrace));
        //    }
        //    return isUpdateSolr;
        //}
        private string GetImagePath(long id)
        {
            var imagePath = "";
            var productTable = new DBPrd.ProductDataTable();
            try
            {
                _productTableAdapter.FillById(productTable, id);
                if (productTable.Rows.Count > 0)
                {
                    imagePath = productTable.Rows[0]["ImagePath"].ToString();
                }
            }
            catch (Exception exception)
            {
                Log.Error(id + exception.ToString());
            }
            return imagePath;
        }

        private void gvlogKeywordsWebsite_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripLogKeywords.Show(this.logKeywordsWebsiteGridControl, new Point(e.X, e.Y));
            }
        }
    }
}
