using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using log4net;
using QT.Entities;
using QT.Moduls.Maps.DBPManTableAdapters;
using Websosanh.Core.Drivers.Redis;
using Websosanh.Core.Product.BO;
using Websosanh.Core.Product.DAL;
//using Websosanh.Core.SearchEngines.BO;
//using Websosanh.Core.SearchEngines.BO.SolrDriverTypes;
//using Websosanh.Core.SearchEngines.DAL;
using SolrProductItem = Websosanh.Core.Product.BO.SolrProductItem;
using Websosanh.Core.Product.BAL;
using StackExchange.Redis;
using Websosanh.Core.ServiceStackUtilities;
using Websosanh.ProductSearchEnginesService.ServiceModel;

namespace QT.Moduls.Maps
{
    public partial class CtrProductIdentity : UserControl
    {
        private ProductIdentity _productIdentity;
        private long _productID;
        private bool isUpdate;
        public bool IsInited;
        private bool _listProductUpToDate;
        private List<long> listProductFound;
        private RedisServer _productMapRedisServer;
        private string _searchEnginesServiceUrl;
        private static readonly ILog Log = LogManager.GetLogger(typeof(CtrProductIdentity));
        public delegate void UpdateEventHandler(SaveStatus saveStatus);
        public event UpdateEventHandler UpdateProductIdentityClick;
        Random rando = new Random(2);
        public CtrProductIdentity()
        {
            InitializeComponent();


        }

        public void Init()
        {
            IsInited = true;
            var productMapRedisServerName = ConfigurationManager.AppSettings["redisProductMap"];
            _productMapRedisServer = RedisManager.GetRedisServer(productMapRedisServerName);
            _searchEnginesServiceUrl = ConfigurationManager.AppSettings["searchEnginesServiceUrl"];
        }

        public void LoadProductIdentity()
        {
            Log.Debug(string.Format("Loading Product Identity - Product ID: {0}", _productID));
            _productIdentity = ProductIdentityBAL.GetProductIdentity(_productID, Server.ConnectionString);
            if (_productIdentity == null)
            {
                isUpdate = false;
                textBoxLastUpdate.Text = "";
                _productIdentity = new ProductIdentity() { ProductID = _productID };
            }
            else
            {
                isUpdate = true;
            }

            textBoxProductID.Text = _productID.ToString();
            richTextBoxConfusedProductList.Text = _productIdentity.GetConfusedProductListString();
            richTextBoxAdditionProductIDs.Text = _productIdentity.GetAdditionProductIDsString();
            richTextBoxKeywords.Text = _productIdentity.GetKeywordSetsString();
            richTextBoxExcludeKeywords.Text = _productIdentity.GetExcludeKeywordsString();
            richTextBoxProductBlackList.Text = _productIdentity.GetProductBlackListString();
            richTextBoxCompanyBlackList.Text = _productIdentity.GetCompanyBlackListString();
            textBoxLastUpdate.Text = _productIdentity.LastUpdate.ToString("G");
            spintEditMinPrice.Value = _productIdentity.MinPrice;
            spinEditMaxPrice.Value = _productIdentity.MaxPrice;
            richTextBoxNote.Text = _productIdentity.Note;
        }

        public void ChangeProductID(long productID)
        {
            Log.InfoFormat("Change productID: {0}", productID);
            _productID = productID;
            LoadProductIdentity();
            listProductFound = new List<long>();
            textBoxNumFound.Text = "";
            spinEditMinPriceFound.Value = 0;
            spinEditMaxPriceFound.Value = 0;
            this.dBMap.ProductInfo.Clear();
        }

        private void UpdateObjectValue()
        {
            _productIdentity.GetConfusedProductListFromString(richTextBoxConfusedProductList.Text);
            _productIdentity.GetAdditionProductIDsFromString(richTextBoxAdditionProductIDs.Text);
            _productIdentity.GetKeywordSetsFromString(richTextBoxKeywords.Text);
            _productIdentity.GetExcludeKeywordsFromString(richTextBoxExcludeKeywords.Text);
            _productIdentity.GetProductBlackListFromString(richTextBoxProductBlackList.Text);
            _productIdentity.GetCompanyBlackListFromString(richTextBoxCompanyBlackList.Text);
            _productIdentity.MinPrice = (long)spintEditMinPrice.Value;
            _productIdentity.MaxPrice = (long)spinEditMaxPrice.Value;
            _productIdentity.Note = richTextBoxNote.Text;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateProductIdentityClick(SaveStatus.Complete);
        }


        public void SaveProductIdentity()
        {
            if (_productID == 0)
                return;
            UpdateObjectValue();
            if (isUpdate)
                ProductIdentityBAL.UpdateProductIdentity(_productIdentity, Server.ConnectionString);
            else
                ProductIdentityBAL.InsertProductIdentity(_productIdentity, Server.ConnectionString);
            LoadProductIdentity();
        }

        private void EventDrawPoint(object sender, DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs e)
        {
            e.SecondLabelText = "OK";
            e.LegendText = "NO";
            e.SeriesPoint.ToolTipHint = "HEHE";

        }




        public void RefreshDataChart(DataTable lstData)
        {
            DevExpress.XtraCharts.XYDiagram diagram = (DevExpress.XtraCharts.XYDiagram)this.chartControl.Diagram;
            diagram.EnableAxisXScrolling = true;
            diagram.EnableAxisXZooming = true;
            diagram.EnableAxisYScrolling = true;
            diagram.EnableAxisYZooming = true;

            this.chartControl.DataSource = lstData;
            this.chartControl.Series.Clear();
            DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("DistributionPrice", DevExpress.XtraCharts.ViewType.Point);
            this.chartControl.Series.Add(series);
            series.ArgumentDataMember = "Price";
            series.ValueDataMembers.AddRange(new string[] { "Price" });

            series.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            series.ToolTipSeriesPattern = "{HINT}";
            series.ToolTipHintDataMember = "URL";
            series.ToolTipPointPattern = "{HINT}";
        }

        public void UpdateRootID()
        {
            if (!_listProductUpToDate)
                IdentifyProducts();
            var keyValueMap =
                listProductFound.Select(
                    x =>
                        new KeyValuePair<RedisKey, RedisValue>(ProductConstants.REDIS_PREFIX_PRODUCT_MAP_REVERSE + x,
                            _productID)).ToArray();
            _productMapRedisServer.MSet(keyValueMap);
        }

        public void IdentifyProducts()
        {
            if (_productID == 0)
            {
                MakeListProductUpToDate();
                return;
            }

            UpdateObjectValue();
            this.dBMap.ProductInfo.Rows.Clear();
            int numProductFound = 0;
            long minPriceFound = 0;
            long maxPriceFound = 0;
            var client = new ProtoBufServiceStackClient(_searchEnginesServiceUrl);
            try
            {
                var response = client.Send<GetRootProductMappingResponse>(new GetRootProductMappingByProductIdentityRequest { ProductIdentity = _productIdentity, RegionID = 0, IncludeBlackList = false, GetFacet = true });
                if (response.RootProductMapping != null)
                {
                    listProductFound = new List<long>();
                    foreach (var merchantProductIDs in response.RootProductMapping.ListMerchantProducts)
                    {
                        listProductFound.AddRange(merchantProductIDs.Value);
                    }
                    this.dBMap.ProductInfo.Clear();
                    var productIDMap = new Dictionary<RedisKey, RedisValue>();
                    var listProductMapReverseKey =
                        listProductFound.Select(x => (RedisKey)(ProductConstants.REDIS_PREFIX_PRODUCT_MAP_REVERSE + x)).ToArray();
                    if (listProductMapReverseKey.Length > 0)
                    {
                        //try
                        //{
                        //    foreach (var item in listProductMapReverseKey)
                        //    {
                        //        bool bOK = _productMapRedisServer.Exist(item);
                        //        if (bOK == false)
                        //        {
                        //            MessageBox.Show("dfSD");
                        //        }
                        //    }
                        productIDMap = _productMapRedisServer.MGet(listProductMapReverseKey);
                        //    }
                        //    catch(Exception ex)
                        //    {
                        //        MessageBox.Show(ex.Message);
                        //    }
                    }
                    var merchantProducts = WebMerchantProductBAL.GetWebMerchantProductsFromCache(listProductFound);
                    foreach (var item in merchantProducts.Values)
                    {
                        var row = this.dBMap.ProductInfo.NewRow();//.NewRow();
                        row["Name"] = item.Name;
                        row["Price"] = item.Price;
                        row["ID"] = item.ID;
                        row["Url"] = item.DetailUrl;
                        row["Company"] = item.CompanyID;
                        var redisProductMapReverseKey = ProductConstants.REDIS_PREFIX_PRODUCT_MAP_REVERSE + item.ID;
                        if (productIDMap.ContainsKey(redisProductMapReverseKey))
                            row["RootID"] = productIDMap[redisProductMapReverseKey];
                        this.dBMap.ProductInfo.Rows.Add(row);
                    }
                    this.dBMap.ProductInfo.AcceptChanges();
                    //
                    numProductFound = response.RootProductMapping.ListMerchantProducts.Sum(x => x.Value.Count);
                    minPriceFound = response.RootProductMapping.MinPrice;
                    maxPriceFound = response.RootProductMapping.MaxPrice;
                }
                else
                {
                    numProductFound = 0;
                    minPriceFound = 0;
                    maxPriceFound = 0;
                }
            }
            catch (Exception ex)
            {
                Log.Error("ERROR client.Send<GetRootProductMappingResponse>", ex);
            }
                
            

            //XT-2015_08_07
            //this.RefreshDataChart(dBMap.ProductInfo);
            //Comment vì ko dùng đến nữa 19.11.2015

            textBoxNumFound.Text = numProductFound.ToString();
            spinEditMinPriceFound.Value = minPriceFound;
            spinEditMaxPriceFound.Value = maxPriceFound;
            MakeListProductUpToDate();

            var adtJob = new QT.Moduls.Company.DBComTableAdapters.Job_WebsiteConfigLogTableAdapter();
            adtJob.Connection.ConnectionString = Server.ConnectionString;
            try
            {
                adtJob.Insert(QT.Users.User.UserID, _productID, richTextBoxNote.Text, textBoxNumFound.Text, QT.Users.JobNhapLieuStatus.NhanDienSanPham, DateTime.Now);
            }
            catch (Exception)
            {
            }            
        }



        private void MakeListProductOutOfDate()
        {
            _listProductUpToDate = false;
        }

        private void MakeListProductUpToDate()
        {
            _listProductUpToDate = true;
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            IdentifyProducts();
            if (_productID !=0)
                LogJobAdapter.SaveLog(JobName.FrmManagerProduct_Nhan_dien_san_pham, "Phân tích sản phẩm " + richTextBoxKeywords.Text + " - " + richTextBoxExcludeKeywords.Text
                    + " - Max " + spinEditMaxPrice.Text + " - Min " + spintEditMinPrice.Text + " - " + richTextBoxConfusedProductList.Text + " - " + richTextBoxProductBlackList.Text
                    + " - " + richTextBoxCompanyBlackList.Text + " - " + richTextBoxAdditionProductIDs.Text + " - " + richTextBoxNote.Text+" - NumFound: "+textBoxNumFound.Text , _productID, (int)JobTypeData.Product);
        }

        private void CtrProductIdentity_Load(object sender, EventArgs e)
        {

        }

        private void gridControlListProduct_DoubleClick(object sender, EventArgs e)
        {

        }
        private void toolStripButtonMarkConfused_Click(object sender, EventArgs e)
        {
            if (!richTextBoxConfusedProductList.Text.Contains(textBoxSelectedProductID.Text))
            {
                richTextBoxConfusedProductList.AppendText(this.textBoxSelectedProductID.Text + "\n");
            }
        }
        private void AddIDLoai(object sender, EventArgs e)
        {
            if (!richTextBoxProductBlackList.Text.Contains(textBoxSelectedProductID.Text))
            {
                richTextBoxProductBlackList.AppendText(this.textBoxSelectedProductID.Text + "\n");
            }
        }

        private void tsmLoaiCongTy_Click(object sender, EventArgs e)
        {
            if (!richTextBoxCompanyBlackList.Text.Contains(this.textBoxSelectedProductCompany.Text))
            {
                richTextBoxCompanyBlackList.AppendText(this.textBoxSelectedProductCompany.Text + "\n");
            }
        }

        private void toolStripButtonAddProductID_Click(object sender, EventArgs e)
        {
            if (!richTextBoxAdditionProductIDs.Text.Contains(textBoxSelectedProductID.Text))
            {
                richTextBoxAdditionProductIDs.AppendText(this.textBoxSelectedProductID.Text + "\n");
            }
        }

        private void gridControlListProduct_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxAdditionProductIDs_TextChanged(object sender, EventArgs e)
        {
            MakeListProductOutOfDate();
        }

        private void richTextBoxConfusedProductList_TextChanged(object sender, EventArgs e)
        {
            MakeListProductOutOfDate();
        }
        private void richTextBoxProductIDBlackList_TextChanged(object sender, EventArgs e)
        {
            MakeListProductOutOfDate();

        }

        private void richTextBoxCompanyBlackList_TextChanged(object sender, EventArgs e)
        {
            MakeListProductOutOfDate();
        }

        private void richTextBoxKeywords_TextChanged(object sender, EventArgs e)
        {
            MakeListProductOutOfDate();
        }

        private void richTextBoxExcludeKeywords_TextChanged(object sender, EventArgs e)
        {
            MakeListProductOutOfDate();
        }

        private void spintEditMinPrice_EditValueChanged(object sender, EventArgs e)
        {
            MakeListProductOutOfDate();
        }

        private void spinEditMaxPrice_EditValueChanged(object sender, EventArgs e)
        {
            MakeListProductOutOfDate();
        }

        private void gridViewListProduct_RowStyle(object sender, RowStyleEventArgs e)
        {
            var listProductGridView = sender as GridView;
            if (e.RowHandle < 0) return;
            var rootID = listProductGridView.GetRowCellDisplayText(e.RowHandle, listProductGridView.Columns["RootID"]);
            if (string.IsNullOrEmpty(rootID) || rootID.Equals(_productID.ToString()))
                return;
            e.Appearance.BackColor = Color.OrangeRed;
        }

        private void CheckStringInRichTextBox(string input)
        {

        }

        private void buttonSaveTemporary_Click(object sender, EventArgs e)
        {
            UpdateProductIdentityClick(SaveStatus.Temporary);
        }


        private DevExpress.Utils.ToolTipController toolTipController1;

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }

    public enum SaveStatus
    {
        Complete = 0,
        Temporary = 1,
    }
}
