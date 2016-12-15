using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;
using System.Diagnostics;
using System.Threading;
using Websosanh.Core.Common.BAL;
using System.IO;
using QT.Entities.Data;
using Websosanh.Core.JobServer;
using Websosanh.Core.Drivers.RabbitMQ;
using DevExpress.XtraGrid;
using QT.Entities.Images;

namespace QT.Moduls.Maps
{
    public partial class frmManagerProduct : QT.Entities.frmBase
    {
        long idQuangTrung = Common.GetIDCompany("quangtrung.vn");
        private Thread updateFulltextThread;

        public frmManagerProduct()
        {
            InitializeComponent();
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.product_KeyComparisonTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productStatusTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productValueTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
        }

        public override bool RefreshData()
        {

            //this.ctrProducAnanytic2.Ananytic();
            this.ctrProductIdentity1.LoadProductIdentity();
            return true;
        }

        public override bool Save()
        {
            try
            {
                this.lastUpdateDateTimePicker.Value = DateTime.Now;
                this.productTableAdapter.CMS_Product_SaveEditeProductSPGoc(
                     (short)cboStatus.SelectedValue,
                    lastUpdateDateTimePicker.Value,
                    nameTextBox.Text.Trim(),
                    Common.UnicodeToKoDauFulltext(nameTextBox.Text),
                    this.validCheckBox.Checked,
                    Common.Obj2Int64(iDTextBox.Text), imageUrlsTextEdit.Text);
                this.ctrProductIdentity1.SaveProductIdentity();
                LogJobAdapter.SaveLog(JobName.FrmManagerProduct_Luu_Product, "Lưu thông tin sản phẩm ở form nhận diện", Common.Obj2Int64(iDTextBox.Text), (int)JobTypeData.Product);
                //ctrProducAnanytic2.SaveAnanytic();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        private void frmManagerProduct_Load(object sender, EventArgs e)
        {
            this.ctrListSPGoc1.InitForm();
            this.productStatusTableAdapter.FillByMapID(this.dBPMan.ProductStatus);
            this.listClassificationTableAdapter.FillBy_DaMap(dBPMan.ListClassification);
            this.treeList1.ExpandAll();
        }

        private int GetCategoryID()
        {
            return Common.Obj2Int(this.iDCategoryTextBox.Text.Trim());
        }
        private void iDCategoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public override bool Analytics()
        {
            //this.ctrProducAnanytic2.MapAllAndUpdate();
            this.ctrProductIdentity1.IdentifyProducts();
            return true;
        }
        private void nameTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void productContentTextBox_TextChanged(object sender, EventArgs e)
        {
            this.webContent.DocumentText = productContentTextBox.Text;
        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {
            //this.ctrProducAnanytic2.SetProductID(Common.Obj2Int(iDTextBox.Text));
            if (!ctrProductIdentity1.IsInited)
                ctrProductIdentity1.Init();
            this.ctrProductIdentity1.ChangeProductID(CommonUtilities.Object2Long(iDTextBox.Text, 0));
        }

        private void btUpdatekey_Click(object sender, EventArgs e)
        {
            this.productKeyComparisonBindingSource.EndEdit();
            this.product_KeyComparisonTableAdapter.Update(this.dBPMan.Product_KeyComparison);
        }

        private void gridControl2_Leave(object sender, EventArgs e)
        {
            this.productKeyComparisonBindingSource.EndEdit();
            this.product_KeyComparisonTableAdapter.Update(this.dBPMan.Product_KeyComparison);
        }

        private void gridControl2_Enter(object sender, EventArgs e)
        {
            this.dBPMan.Product_KeyComparison.IDProductColumn.DefaultValue = Common.GetID_ProductID(nameTextBox.Text, GetCategoryID());
        }

        private void btOpenWeb_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(this.detailUrlTextBox1.Text);
            Process.Start(sInfo);
        }


        private void bttest_Click(object sender, EventArgs e)
        {
            List<PropertyEntyties> ls = ContentAnalytic.GetListProperties(this.productContentTextBox.Text, this.detailUrlTextBox1.Text);
        }


        private void ctrProducAnanytic2_UpdateMapIDClick(int status)
        {
            if (status == 0)
            {
                // ananytic
                Save();
            }
            if (status == 1)
            {
                //config thành công
                this.cboStatus.SelectedValue = (byte)QT.Entities.Common.ProductStatus.SPGocConfig;
                Save();
            }
        }

        /// <summary>
        /// Update lại thời gian cập nhật sản phẩm trên vật giá + giá thấp nhất so sánh trên vật giá
        /// thông tin id sản phẩm từ vật giá được lưu vào trường ClassificationID
        /// Update lại giá nhỏ nhất, tổng số sản phẩm tìm thấy trong dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUpdateGiaSPGoc_Click(object sender, EventArgs e)
        {
            DBPMan.ProductDataTable dt = new DBPMan.ProductDataTable();
            DBPMan.ProductDataTable dtvatgia = new DBPMan.ProductDataTable();
            this.productTableAdapter.FillBy_CompanyID(dt, Common.GetIDCompany("quangtrung.vn"));
            #region Update lại thông tin trên vật giá
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                long productid = 0;
                productid = Common.Obj2Int64(dt.Rows[i]["ClassificationID"].ToString());
                if (productid == 0)
                {
                    productid = Common.GetIDProduct(dt.Rows[i]["DetailUrl"].ToString());
                }

                try
                {
                    this.productTableAdapter.FillBy_Price_LastUpdateByID(dtvatgia, productid);
                    int price = 0;
                    DateTime dtpro = DateTime.Now;
                    if (dtvatgia.Rows.Count > 0)
                    {
                        price = Common.Obj2Int(dtvatgia.Rows[0]["Price"].ToString());
                        dtpro = Common.ObjectToDataTime(dtvatgia.Rows[0]["LastUpdate"]);
                    }
                    this.productTableAdapter.UpdateQuery_SPGoc(dtpro, price, productid, Common.Obj2Int64(dt.Rows[i]["ID"].ToString()));
                    this.laMess1.Text = String.Format("{0}/{1}", i, dt.Rows.Count);
                }
                catch (Exception ex)
                {
                    this.laMess1.Text = String.Format("Error {0}/{1}{2}", i, dt.Rows.Count, ex);
                }
                Application.DoEvents();
            }
            #endregion



        }

        private void ctrListSPGoc1_ProductIDChange(long IDProduct)
        {
            this.productTableAdapter.FillBy_SelectOne(this.dBPMan.Product, IDProduct);
            UploadImageButton.Visible = true;
        }

        private void btBuildContent_Click(object sender, EventArgs e)
        {
            try
            {
                this.productValueTableAdapter.FillByProductID(dBMap.ProductValue, Common.Obj2Int64(iDTextBox.Text));
                string sv = ContentAnalytic.BuildContentProduct((DataTable)dBMap.ProductValue);
                this.webBuildContent.DocumentText = sv;
            }
            catch (Exception)
            {
            }

        }

        private void btUpdateGiaSPGocSauPhanTich_Click(object sender, EventArgs e)
        {
            this.laMess1.Text = "Đang tải dữ liệu";
            updateFulltextThread = new Thread(new ThreadStart(doUpdateGiaSPGoc));
            updateFulltextThread.Start();
        }
        void doUpdateGiaSPGoc()
        {

            QT.Entities.Product_KeyComparison obj = new Product_KeyComparison();
            DBPMan.ProductDataTable dt = new DBPMan.ProductDataTable();
            while (true)
            {
                if (chkAll.Checked == true)
                {
                    this.productTableAdapter.FillBy_AllSPGocValid_orderByLastUpdate(dt, Common.GetIDCompany("quangtrung.vn"), DateTime.Now.AddDays(-1));
                }
                else
                {
                    this.productTableAdapter.FillBy_CompanyID_Valid_Category(dt, Common.GetIDCompany("quangtrung.vn"), true, Common.Obj2Int(this.iDListClassificationTextBox.Text));
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        int productid = 0;

                        productid = Common.Obj2Int(dt.Rows[i]["ID"].ToString());
                        long idSPChuyenSPGoc = Common.Obj2Int64(dt.Rows[i]["ClassificationID"].ToString());
                        /// Update ProductID của những sản phẩm được chuyển sang làm sản phẩm gốc, ProductID=ClassificationID
                        this.productTableAdapter.UpdateQuery_ProductID(productid, idSPChuyenSPGoc);
                        Product_KeyComparisonEntyties oe = obj.UpdatePriceAndTongSP_ProductAndKeyComparision(productid);
                        int delay = 1000;
                        this.Invoke(
                           (MethodInvoker)delegate
                           {
                               this.laMess1.Text = String.Format("Update thông tin so sánh giá {0}/{1} sản phẩm: {2}\n Tổng: {3}\n PriceMin: {4}\n PriceMax: {5}", i, dt.Rows.Count, dt.Rows[i]["Name"].ToString(),
                                oe.TongSanPham, oe.PriceMin, oe.PriceMax);
                               delay = Common.Obj2Int(txtDelay.Text.Trim());
                           });
                        Thread.Sleep(delay);
                    }
                    catch (Exception)
                    {
                    }

                }
                if (updateFulltextThread != null)
                {
                    if (updateFulltextThread.IsAlive)
                    {
                        updateFulltextThread.Abort();
                        updateFulltextThread.Join();
                        updateFulltextThread = null;
                    }
                }
            }

        }


        /// <summary>
        ///  Update lại cột search fulltext  ContentFT
        ///  1. sản phẩm gốc:
        ///         Cộng thêm chu dau tên chuyên mục+catid
        ///         Cộng thêm bảng mã thuộc tính kỹ thuật
        ///  2. Sản phẩm crawler về đã được mapid
        ///         update vào chuyên mục sản phẩm gốc
        ///         Cộng thêm chu dau tên chuyên mục+catid
        ///         Cộng thêm bảng mã thuộc tính kỹ thuật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUpdateFulltext_catid_Click(object sender, EventArgs e)
        {
            this.laMess1.Text = "Đang tải dữ liệu";
            updateFulltextThread = new Thread(new ThreadStart(doUpdateFulltext));
            updateFulltextThread.Start();
        }
        //Không sử dụng nữa 02-12-2015
        void doUpdateFulltext()
        {
            DBPMan.ProductDataTable dt = new DBPMan.ProductDataTable();
            DBPMan.Product_PropertiesDataTable dtProperties = new DBPMan.Product_PropertiesDataTable();
            DBPManTableAdapters.Product_PropertiesTableAdapter adtProperties = new DBPManTableAdapters.Product_PropertiesTableAdapter();
            adtProperties.Connection.ConnectionString = Server.ConnectionString;
            if (chkAll.Checked == true)
            {
                this.productTableAdapter.FillBy_AllSPGocValid_orderByLastUpdate(dt, Common.GetIDCompany("quangtrung.vn"), DateTime.Now);
            }
            else
            {
                this.productTableAdapter.FillBy_CompanyID_Valid_Category(dt, Common.GetIDCompany("quangtrung.vn"), true, Common.Obj2Int(this.iDListClassificationTextBox.Text));
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    long id = 0;
                    int categoryID = 0;
                    string nameCat = "";
                    id = Common.Obj2Int64(dt.Rows[i]["ID"].ToString());
                    categoryID = Common.Obj2Int(dt.Rows[i]["CategoryID"].ToString());
                    var filter = GetFilterCategory(categoryID);
                    nameCat = dt.Rows[i]["CategoryName"].ToString();



                    //adtProperties.FillBy_FillterByProductID(dtProperties, id);

                    //foreach (DBPMan.Product_PropertiesRow dr in dtProperties)
                    //{
                    //    int proid = Common.Obj2Int(dr.PropertiesID);
                    //    int provalue = Common.Obj2Int(dr.PropertiesValueID);

                    //    filter += string.Format(" {0}_{1}", proid, provalue);
                    //}

                    //for (int ii = 0; ii < dtProperties.Rows.Count; ii++)
                    //{
                    //    int proid = Common.Obj2Int(dtProperties.Rows[ii]["PropertiesID"].ToString());
                    //    int provalue = Common.Obj2Int(dtProperties.Rows[ii]["PropertiesValueID"].ToString());

                    //    filter += string.Format(" {0}_{1}", proid, provalue);
                    //}
                    string nameFT = Common.UnicodeToKoDauFulltext(dt.Rows[i]["Name"].ToString() + " " + nameCat) + " " + nameCat;
                    var contentft = Common.UnicodeToKoDauFulltext(nameCat) + " " +
                                    filter;
                    if (contentft.Contains("c000"))
                    {
                        contentft = contentft;
                    }
                    this.productTableAdapter.UpdateQuery_ContentFT_NameFT_ByID(
                        contentft,
                        nameFT,
                        id);
                    int delay = 1000;
                    this.Invoke(
                    (MethodInvoker)delegate
                    {
                        this.laMess1.Text = String.Format("Update thông tin search {0}/{1} sản phẩm gốc: {2}\n ", i, dt.Rows.Count, dt.Rows[i]["Name"].ToString());
                        delay = Common.Obj2Int(txtDelay.Text.Trim());
                    });

                    contentft = nameFT + " " + filter;
                    if (contentft.Contains("c000"))
                    {
                        contentft = contentft;
                    }
                    this.productTableAdapter.UpdateQuery_ContentFT_CategoryID_ByProductID(
                        contentft,
                        Common.Obj2Int(dt.Rows[i]["CategoryID"]),
                        Common.Obj2Int(id));
                    Thread.Sleep(delay);
                }
                catch (Exception ex)
                {
                    var error = ex.Message;
                    error += "";
                }

            }
            dt.Dispose();

            if (updateFulltextThread != null)
            {
                if (updateFulltextThread.IsAlive)
                {
                    updateFulltextThread.Abort();
                    updateFulltextThread.Join();
                    updateFulltextThread = null;
                }
            }
        }

        /// <summary>
        /// Update lại tổng view trong tháng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUpadateTongView_Click(object sender, EventArgs e)
        {
            this.laMess1.Text = "Đang tải dữ liệu";
            updateFulltextThread = new Thread(new ThreadStart(doUpdateTongView));
            updateFulltextThread.Start();
        }
        void doUpdateTongView()
        {
            QT.Entities.Product_KeyComparison obj = new Product_KeyComparison();
            DBPMan.ProductDataTable dt = new DBPMan.ProductDataTable();
            if (chkAll.Checked == true)
            {
                this.productTableAdapter.FillBy_AllSPGocValid_orderByLastUpdate(dt, Common.GetIDCompany("quangtrung.vn"), DateTime.Now);
            }
            else
            {
                this.productTableAdapter.FillBy_CompanyID_Valid_Category(dt, Common.GetIDCompany("quangtrung.vn"), true, Common.Obj2Int(this.iDListClassificationTextBox.Text));
            }
            DBPManTableAdapters.Product_LogsTableAdapter adtLog = new DBPManTableAdapters.Product_LogsTableAdapter();
            adtLog.Connection.ConnectionString = QT.Entities.Server.ConnectionString;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    int productid = 0;

                    productid = Common.Obj2Int(dt.Rows[i]["ID"].ToString());
                    int viewCount = 0;
                    try
                    {
                        viewCount = Common.Obj2Int(adtLog.ScalarQuery_SumCountByProductID_FromDate(productid, DateTime.Now.AddDays(-30)));
                    }
                    catch (Exception)
                    {
                    }
                    int delay = 1000;
                    this.Invoke(
                        (MethodInvoker)delegate
                        {
                            this.laMess1.Text = String.Format("Update thông tin view {0}/{1} sản phẩm: {2}\n Tổng: {3}\n ", i, dt.Rows.Count, dt.Rows[i]["Name"].ToString(),
                                                    viewCount);
                            delay = Common.Obj2Int(txtDelay.Text.Trim());
                        });
                    this.productTableAdapter.UpdateQuery_ViewCount(viewCount, productid);
                    Thread.Sleep(delay);
                }
                catch (Exception)
                {
                }

            }
            adtLog.Dispose();
            if (updateFulltextThread != null)
            {
                if (updateFulltextThread.IsAlive)
                {
                    updateFulltextThread.Abort();
                    updateFulltextThread.Join();
                    updateFulltextThread = null;
                }
            }
        }



        Dictionary<int, String> dicCateFilter = new Dictionary<int, string>();
        private string GetFilterCategory(int categoryID)
        {
            if (dicCateFilter.ContainsKey(categoryID))
            {
                return dicCateFilter[categoryID];
            }
            else
            {
                //codeContains = String.Format(@"""c{0}""", objCat.ID.ToString("D3"));
                String r = String.Format("c{0}_", categoryID.ToString("D3"));
                DBPMan.ListClassificationDataTable dt = new DBPMan.ListClassificationDataTable();
                DBPManTableAdapters.ListClassificationTableAdapter adt = new DBPManTableAdapters.ListClassificationTableAdapter();
                adt.Connection.ConnectionString = Server.ConnectionString;
                adt.FillBy_SelectOne(dt, categoryID);
                if (dt.Rows.Count > 0)
                {
                    int idParent = Common.Obj2Int(dt.Rows[0]["ParentID"]);
                    if (idParent != 0)
                        r += " " + GetFilterCategory(idParent);
                }
                dt.Dispose();
                adt.Dispose();
                dicCateFilter[categoryID] = r;
                return r;
            }


        }




        private void btSiteMap_Click(object sender, EventArgs e)
        {

            DBPMan.ProductDataTable dt = new DBPMan.ProductDataTable();
            DBPMan.Product_PropertiesDataTable dtProperties = new DBPMan.Product_PropertiesDataTable();
            DBPManTableAdapters.Product_PropertiesTableAdapter adtProperties = new DBPManTableAdapters.Product_PropertiesTableAdapter();
            adtProperties.Connection.ConnectionString = Server.ConnectionString;
            this.productTableAdapter.FillBy_AllSPGocValid_orderByLastUpdate(dt, Common.GetIDCompany("quangtrung.vn"), DateTime.Now);
            String xml = "";
            xml += "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n";
            xml += "<urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">\n";
            xml += "    <url>\n";
            xml += "        <loc>http://websosanh.vn/home.htm</loc>\n";
            xml += "        <changefreq>daily</changefreq>\n";
            xml += "        <priority>0.8</priority>\n";
            xml += "    </url>\n";
            string f = "";
            f += "    <url>\n";
            f += "        <loc>{0}</loc>\n";
            f += "        <changefreq>daily</changefreq>\n";
            f += "        <priority>0.8</priority>\n";
            f += "    </url>\n";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                long id = 0;
                string name = "", url = "";
                id = Common.Obj2Int64(dt.Rows[i]["ID"].ToString());
                name = dt.Rows[i]["Summary"].ToString();
                url = Bussiness.UrlHelper.GetUrlOfProductIDSoSanh(id, name);
                xml += string.Format(f, url);
            }
            dt.Dispose();
            xml += "</urlset>\n";
            FileLog.WriteText(xml, "sitemap.xml");
        }


        private void btUpdateTinLienQuan_Click(object sender, EventArgs e)
        {
            #region update lại giá, tổng số sản phẩm tìm thấy trong dữ liệu
            QT.Entities.Product_KeyComparison obj = new Product_KeyComparison();
            DBPMan.ProductDataTable dt = new DBPMan.ProductDataTable();
            if (chkAll.Checked == true)
            {
                this.productTableAdapter.FillBy_AllSPGocValid_orderByLastUpdate(dt, Common.GetIDCompany("quangtrung.vn"), DateTime.Now);
            }
            else
            {
                this.productTableAdapter.FillBy_CompanyID_Valid_Category(dt, Common.GetIDCompany("quangtrung.vn"), true, Common.Obj2Int(this.iDListClassificationTextBox.Text));
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int productid = 0;
                productid = Common.Obj2Int(dt.Rows[i]["ID"].ToString());
                int tong = obj.UpdateProductIDTinLienQuan(productid);
                this.laMess1.Text = String.Format("Update tin liên quan {0}/{1} sản phẩm: {2}\n Tổng: {3}\n ", i, dt.Rows.Count, dt.Rows[i]["Name"].ToString(),
                    tong);
                Application.DoEvents();
            }
            #endregion
        }

        private void btUpdateTopGiamGiaTuan_Click(object sender, EventArgs e)
        {
            QT.Entities.Product_KeyComparison obj = new Product_KeyComparison();
            DBPMan.ProductDataTable dt = new DBPMan.ProductDataTable();
            if (chkAll.Checked == true)
            {
                this.productTableAdapter.FillBy_AllSPGocValid_orderByLastUpdate(dt, Common.GetIDCompany("quangtrung.vn"), DateTime.Now);
            }
            else
            {
                this.productTableAdapter.FillBy_CompanyID_Valid_Category(dt, Common.GetIDCompany("quangtrung.vn"), true, Common.Obj2Int(this.iDListClassificationTextBox.Text));
            }
            DBPManTableAdapters.Price_LogsTableAdapter adtLog = new DBPManTableAdapters.Price_LogsTableAdapter();
            DBPMan.Price_LogsDataTable dtLog = new DBPMan.Price_LogsDataTable();
            adtLog.Connection.ConnectionString = QT.Entities.Server.ConnectionString;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int productid = 0;

                productid = Common.Obj2Int(dt.Rows[i]["ID"].ToString());
                int PriceChange = 0;
                try
                {
                    adtLog.FillBy_ProductIDFromDate(dtLog, productid, DateTime.Now.AddDays(-7));
                    if (dtLog.Rows.Count > 0)
                    {
                        DateTime dateUpdate = Common.ObjectToDataTime(dtLog.Rows[0]["DateUpdate"]);
                        if (dateUpdate < DateTime.Now.AddDays(-6))
                        {

                            int price0 = Common.Obj2Int(dtLog.Rows[0]["NewPrice"].ToString());
                            int pricen = Common.Obj2Int(dtLog.Rows[dtLog.Rows.Count - 1]["NewPrice"].ToString());
                            PriceChange = pricen - price0;
                        }
                    }
                }
                catch (Exception)
                {
                }

                this.productTableAdapter.UpdateQuery_PriceChangeWeek(PriceChange, productid);
                this.laMess1.Text = String.Format("Update giá giảm trong tuần {0}/{1} sản phẩm: {2}\n Tổng: {3}\n ", i, dt.Rows.Count, dt.Rows[i]["Name"].ToString(),
                    PriceChange);
                Application.DoEvents();
            }
            adtLog.Dispose();
        }

        private void frmManagerProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (updateFulltextThread != null)
            {
                if (updateFulltextThread.IsAlive)
                {
                    updateFulltextThread.Abort();
                    updateFulltextThread.Join();
                    updateFulltextThread = null;
                }
            }
        }

        private void ctrProductIdentity1_UpdateProductIdentityClick(SaveStatus saveStatus)
        {
            string a = iDTextBox.Text;
            string b = a;
            string c = b;
            if (saveStatus == SaveStatus.Temporary)
            {
                Save();
                LogJobAdapter.SaveLog(JobName.FrmManagerProduct_LuuTam, "Ấn nút lưu tạm", Common.Obj2Int64(iDTextBox.Text), (int)JobTypeData.Product);
            }
            if (saveStatus == SaveStatus.Complete)
            {
                //config thành công
                this.cboStatus.SelectedValue = (byte)QT.Entities.Common.ProductStatus.SPGocConfig;
                if (!Save())
                {
                    MessageBox.Show("Xảy ra lỗi!");
                }
                else
                {
                    this.ctrProductIdentity1.UpdateRootID();
                    LogJobAdapter.SaveLog(JobName.FrmManagerProduct_Luu, "Ấn nút lưu phân tích dữ liệu", Common.Obj2Int64(iDTextBox.Text), (int)JobTypeData.Product);
                }
            }

        }

        //private string _rabbitMqServerName;
        //private string _updateProductImageGroupName;
        //private string _updateProductImageProductJobName;
        private RabbitMQServer _rabbitMqServer;
        private JobClient _downloadImageProductJobClient;
        private void UploadImageButton_Click(object sender, EventArgs e)
        {
            long productid = CommonUtilities.Object2Long(iDTextBox.Text, 0);
            if (productid != 0)
            {
                if (string.IsNullOrEmpty(imageUrlsTextEdit.Text))
                {
                    MessageBox.Show("Kiểm tra Image url!!!");
                }
                else
                {
                    if(_rabbitMqServer == null)
                        _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
                    if(_downloadImageProductJobClient == null)
                        _downloadImageProductJobClient = new JobClient(ConfigImages.ImboExchangeImages, GroupType.Topic,ConfigImages.ImboRoutingKeyDownloadImageRootProduct, true, _rabbitMqServer);
                    ImageProductInfo product = new ImageProductInfo();
                    product.Id = productid;
                    product.ImageUrls = imageUrlsTextEdit.Text;
                    try
                    {
                        _downloadImageProductJobClient.PublishJob(new Job() { Data = ImageProductInfo.GetMessage(product) });
                        UploadImageButton.Visible = false;
                        MessageBox.Show("Push message thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
                MessageBox.Show("ERROR : ID product = 0.");
        }

        private void UploadAllImageProductButton_Click(object sender, EventArgs e)
        {
            //Comment code 30.5.2016 -> Chuyển download từ fpt sang push message lên service download image company
            Company.CompanyFunctions companyFuction = new Company.CompanyFunctions();
            if (companyFuction.SendMessageDownloadImage(6619858476258121218, false))
            {
                MessageBox.Show("Send message to service thành công!");
                UploadAllImageProductButton.Visible = false;
            }
            else
                MessageBox.Show("Lỗi! Liên hệ Hải - Code =.='' ");
            //Wait.Show("Đang upload ảnh!");
            //#region Lấy danh sách sản phẩm gốc Status = Config và Valid = 0

            //SqlDb sqldb = new SqlDb(Server.ConnectionString);
            //DataTable _productTable = new DataTable();
            //try
            //{
            //    _productTable = sqldb.GetTblData(@"SELECT ID, ImageUrls,Name FROM Product WHERE (Company = 6619858476258121218) AND (Status = 11) AND (Valid = 0)", CommandType.Text, null);
            //}
            //catch (Exception ex)
            //{
            //    Wait.Close();
            //    MessageBox.Show("ERROR " + ex);
            //    return;
            //}
            //int countproduct = _productTable.Rows.Count;
            //if (countproduct > 0)
            //{
            //    int temp = 0;
            //    for (int i = 0; i < countproduct; i++)
            //    {
            //        long productid = Common.Obj2Int64(_productTable.Rows[i]["ID"].ToString());
            //        string nameproduct = _productTable.Rows[i]["Name"].ToString();
            //        string imageurls = _productTable.Rows[i]["ImageUrls"].ToString();
            //        if (!string.IsNullOrEmpty(imageurls))
            //        {
            //            if (Common.UploadImageSPGoc(productid,nameproduct,imageurls))
            //            {
            //                temp++;
            //                Wait.Show(string.Format("Upload {0}/{1} image product!",temp,countproduct));
            //            }
            //        }
            //    }
            //    LogJobAdapter.SaveLog(JobName.FrmManagerProduct_UploadAllImageSPGoc, "Upload ảnh toàn bộ sản phẩm gốc chưa có ảnh mà đã config xong. Chức năng viêt cho Hồng anh nên ko có IDProduct đi kèm", 0, (int)JobTypeData.Product);
            //    Wait.Close();
            //}

            //Wait.Close();
            //#endregion
        }

        private void btnGetProductImage_Click(object sender, EventArgs e)
        {
            Wait.Show("Get product from SQL...");
            string querry = @"SELECT ID,Name, DetailUrl,ImageUrls,ImageId,LastUpdate,Valid,Status FROM Product WHERE (Company = 6619858476258121218) AND (Valid = 1) AND (ImageId IS NULL OR ImageId = '') OR (Company = 6619858476258121218) AND (Valid = 0) AND (Status = 11)";
            SqlDb sqldb = new SqlDb(Server.ConnectionString);
            DataTable productTable = new DataTable();
            try
            {
                productTable = sqldb.GetTblData(querry, CommandType.Text, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
            grdProductImage.DataSource = productTable;
            Wait.Close();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportExcel(grdProductImage);
        }
        public void ExportExcel(GridControl gridcontrol, string namefile = null)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                saveDialog.InitialDirectory = @"C:\";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = "";
                    if (namefile != null)
                    {
                        exportFilePath = saveDialog.InitialDirectory + namefile + ".xls";
                    }
                    else exportFilePath = saveDialog.FileName;
                    var fileExtenstion = new FileInfo(exportFilePath).Extension;
                    //NImageExporter imageExporter = chartControl.ImageExporter;
                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridcontrol.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridcontrol.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridcontrol.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridcontrol.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridcontrol.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridcontrol.ExportToMht(exportFilePath);break;
                        default:
                            break;
                    }
                }
            }
            //MessageBox.Show("Export Excel to Documents");
        }
    }
}
