using HaravanAPIAdapterLibrary;
using log4net;
using Newtonsoft.Json;
using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Moduls.Crawler.DBCrawlerTableAdapters;
using System.IO;
using QT.Moduls.Company;
using System.Threading;

namespace QT.Moduls.WebPartner
{
    public partial class frmSettingHaravan : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmSettingHaravan));
        public frmSettingHaravan()
        {
            InitializeComponent();
        }

        private void frmSettingHaravan_Load(object sender, EventArgs e)
        {
            this.companySearchTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.company_StatusTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.companyTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.productTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.company_HaravanTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;

            this.company_HaravanTableAdapter.FillBy_IsActive(this.dBWebPartner.Company_Haravan, true);
            this.company_StatusTableAdapter.Fill(this.dBWebPartner.Company_Status);
        }

        private void TestProductButton_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang tải sản phẩm từ Haravan");
            long idcompany = Common.Obj2Int64(companyIdWSSSpinEdit.Text);
            QT.Entities.Company company = new QT.Entities.Company(idcompany);
            if (company.Name.ToLower() == "not in database")
            {
                MessageBox.Show("Không tồn tại công ty này trong database! Ấn Check Company để kiểm tra");
            }
            else
            {
                string shopname = shopNameTextEdit.Text;
                string accesstoken = accessTokenTextEdit.Text;
                gridControlProduct.DataSource = GetProductFromHaravan(shopname, accesstoken, company);
            }
            Wait.Close();
        }

        public static List<QT.Entities.Product> GetProductFromHaravan(string shopname, string accesstoken, QT.Entities.Company company)
        {
            List<QT.Entities.Product> ListProducts = new List<QT.Entities.Product>();
            var authorizeState = new HaravanAuthorizationState() { ShopName = shopname, AccessToken = accesstoken };
            var client = new HaravanAPIClient(authorizeState);

            ProductHaravanInfo listproductHaravan = new ProductHaravanInfo() { products = new List<Product>() };
            bool check = true;
            int page = 1;
            while (check)
            {
                Object obj = null;
                try
                {
                    //Mỗi lần lấy về 50 product của haravan
                    string querry = "/admin/products.json?page=" + page.ToString();
                    obj = client.Get(querry);
                }
                catch (Exception ex)
                {
                    check = false;
                    Log.ErrorFormat("HARAVAN : Get/admin/products.json FAILS. ERROR : {0}", ex);
                }
                if (obj != null)
                {
                    ProductHaravanInfo listproduct = JsonConvert.DeserializeObject<ProductHaravanInfo>(obj.ToString());
                    if (listproduct.products.Count > 0)
                    {
                        listproductHaravan.products.AddRange(listproduct.products);
                        page++;
                    }
                    else
                        check = false;
                }
                else
                    check = false;
            }


            if (listproductHaravan.products.Count > 0)
            {
                #region Chuyển từ ListProducts of Haravan sang ListProductWebsosanh
                for (int i = 0; i < listproductHaravan.products.Count; i++)
                {
                    if (string.IsNullOrEmpty(listproductHaravan.products[i].published_at) || Common.ObjectToDataTime(listproductHaravan.products[i].published_at) > DateTime.Now)
                    {
                        continue;
                    }
                    //Check số lượng phiên bản variant
                    int variant = listproductHaravan.products[i].variants.Count;
                    //TH variant = 1 (1 phiên bản)
                    if (variant == 1)
                    {
                        #region Product
                        var tmpProduct = new QT.Entities.Product();
                        tmpProduct.Domain = company.Domain;
                        var originalurl = string.Empty;
                        originalurl = company.Website + "products/" + listproductHaravan.products[i].handle;
                        if (company.ID == 7605281528637856297)
                        {
                            tmpProduct.DetailUrl = originalurl + "?ref=10066";
                        }
                        else
                            tmpProduct.DetailUrl = originalurl +"?utm=websosanh";

                        tmpProduct.ID = Common.GetIDProduct(originalurl);

                        if (listproductHaravan.products[i].variants[0].sku != null)
                        {
                            tmpProduct.MerchantSku = listproductHaravan.products[i].variants[0].sku;
                        }

                        if (listproductHaravan.products[i].variants[0].inventory_policy == "deny")
                        {
                            //check số lượng hàng còn trong kho
                            if (listproductHaravan.products[i].variants[0].inventory_quantity <= 0)
                            {
                                //17.09.2015 trạng thái là deny thì để là liên hệ
                                tmpProduct.Status = Common.ProductStatus.LienHe;
                                //tmpProduct.Status = Common.ProductStatus.Clear;
                            }
                            else
                                tmpProduct.Status = Common.ProductStatus.Available;
                        }
                        else if (listproductHaravan.products[i].variants[0].inventory_policy == "continue")
                        {
                            int inventory_quantity = Common.Obj2Int(listproductHaravan.products[i].variants[0].inventory_quantity);
                            if (inventory_quantity > 0)
                                tmpProduct.Status = Common.ProductStatus.Available;
                            else
                                tmpProduct.Status = Common.ProductStatus.Clear;
                        }
                        else
                            tmpProduct.Status = Common.ProductStatus.LienHe;
                        tmpProduct.Instock = QT.Entities.Common.GetProductInstockFormStatus(tmpProduct.Status);
                        tmpProduct.Manufacture = listproductHaravan.products[i].vendor;

                        tmpProduct.Name = listproductHaravan.products[i].title;
                        tmpProduct.HashName = Common.GetHashNameProduct(company.Domain, tmpProduct.Name.Trim());

                        tmpProduct.ProductContent = listproductHaravan.products[i].body_html;

                        CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                        int originPrice = 0;
                        int price = 0;
                        try
                        {
                            originPrice = (int)Decimal.Parse(listproductHaravan.products[i].variants[0].compare_at_price.ToString(), cultureInfo);
                        }
                        catch (FormatException)
                        {
                        }
                        try
                        {
                            price = (int)Decimal.Parse(listproductHaravan.products[i].variants[0].price.ToString(), cultureInfo);
                        }
                        catch (FormatException ex)
                        {
                            Log.Error("HARAVAN : Parse discounted_price Error. "+listproductHaravan.products[i].variants[0].price+"/r/n"+ex);
                            continue;
                        }
                        if (price <= 0)
                        {
                            Log.Error("HARAVAN : Product price equal = 0" + "Product: ID" + tmpProduct.ID + " - " + tmpProduct.Name);
                            continue;
                        }
                        if (originPrice>price)
                        {
                            tmpProduct.OriginPrice = originPrice;
                            tmpProduct.Price = price;
                        }
                        else
                        {
                            tmpProduct.OriginPrice = tmpProduct.Price = price;
                        }
                        //Categories 
                        tmpProduct.Categories = new List<string>();
                        tmpProduct.Categories.Add(company.Domain);
                        tmpProduct.Categories.Add(listproductHaravan.products[i].product_type);
                        tmpProduct.IDCategories = Common.GetIDClassification(Common.ConvertToString(tmpProduct.Categories, " -> "));

                        // list Url Images
                        if (listproductHaravan.products[i].images != null && listproductHaravan.products[i].images.Count != 0)
                        {
                            tmpProduct.ImageUrls = new List<string>() { listproductHaravan.products[i].images[0].src };
                        }
                        else
                            tmpProduct.ImageUrls = new List<string>();
                        if (listproductHaravan.products[i].variants[0] != null)
                        {
                            tmpProduct.VATStatus = listproductHaravan.products[i].variants[0].taxable == false ? Common.VATStatus.NotVAT : Common.VATStatus.HaveVAT;
                        }
                        else
                            tmpProduct.VATStatus = Common.VATStatus.UndefinedVAT;
                        ListProducts.Add(tmpProduct);
                        #endregion
                    }
                    // TH có nhiều phiên bản
                    else if (variant > 1)
                    {
                        //check image nếu có ảnh thì = true, ko có = false
                        bool checkImage = false;
                        Dictionary<int, string> dicImage = new Dictionary<int, string>();
                        if (listproductHaravan.products[i].images != null && listproductHaravan.products[i].images.Count != 0)
                        {
                            checkImage = true;
                            for (int k = 0; k < listproductHaravan.products[i].images.Count; k++)
                            {
                                dicImage.Add(listproductHaravan.products[i].images[k].id, listproductHaravan.products[i].images[k].src);
                            }
                        }
                        else
                            checkImage = false;
                        for (int j = 0; j < variant; j++)
                        {
                            #region Product
                            var tmpProduct = new QT.Entities.Product();
                            tmpProduct.Domain = company.Domain;
                            string originalurl = string.Empty;
                            originalurl = company.Website + "products/" + listproductHaravan.products[i].handle + "?index=" + (j + 1).ToString();
                            //guphukien.com
                            if (company.ID == 7605281528637856297)
                            {
                                tmpProduct.DetailUrl = originalurl + "&ref=10066";
                            }
                            else
                            {
                                tmpProduct.DetailUrl = originalurl + "&utm=websosanh";
                            }
                            tmpProduct.ID = Common.GetIDProduct(originalurl);
                            if (listproductHaravan.products[i].variants[j].sku != null)
                            {
                                tmpProduct.MerchantSku = listproductHaravan.products[i].variants[0].sku;
                            }
                            //check status inventory_policy
                            if (listproductHaravan.products[i].variants[j].inventory_policy == "deny")
                            {
                                //check số lượng hàng còn trong kho
                                if (listproductHaravan.products[i].variants[j].inventory_quantity <= 0)
                                {
                                    //17.09.2015 trạng thái là deny thì để là liên hệ
                                    tmpProduct.Status = Common.ProductStatus.LienHe;
                                    //tmpProduct.Status = Common.ProductStatus.Clear;
                                }
                                else
                                    tmpProduct.Status = Common.ProductStatus.Available;
                                
                            }
                            else if (listproductHaravan.products[i].variants[j].inventory_policy == "continue")
                            {
                                if (listproductHaravan.products[i].variants[j].inventory_quantity <= 0)
                                {
                                    tmpProduct.Status = Common.ProductStatus.Clear;
                                }
                                else
                                    tmpProduct.Status = Common.ProductStatus.Available;
                            }
                            else
                                tmpProduct.Status = Common.ProductStatus.LienHe;
                            tmpProduct.Instock = QT.Entities.Common.GetProductInstockFormStatus(tmpProduct.Status);
                            tmpProduct.Manufacture = listproductHaravan.products[i].vendor;
                            string nameproduct = listproductHaravan.products[i].title;
                            if (listproductHaravan.products[i].variants[j].option1 != null)
                            {
                                nameproduct += " "+ listproductHaravan.products[i].options[0].name+ " " + listproductHaravan.products[i].variants[j].option1;
                            }
                            if (listproductHaravan.products[i].variants[j].option2 != null)
                            {
                                nameproduct += " " + listproductHaravan.products[i].options[1].name + " " +listproductHaravan.products[i].variants[j].option2;
                            }
                            if (listproductHaravan.products[i].variants[j].option3 != null)
                            {
                                nameproduct += " " + listproductHaravan.products[i].options[2].name + " " +listproductHaravan.products[i].variants[j].option3;
                            }
                            tmpProduct.Name = nameproduct;
                            tmpProduct.HashName = Common.GetHashNameProduct(company.Domain, tmpProduct.Name.Trim());

                            tmpProduct.ProductContent = listproductHaravan.products[i].body_html;

                            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                            int originPrice = 0;
                            int price = 0;
                            try
                            {
                                originPrice = (int)Decimal.Parse(listproductHaravan.products[i].variants[j].compare_at_price.ToString(), cultureInfo);
                            }
                            catch (FormatException)
                            {
                            }
                            try
                            {
                                price = (int)Decimal.Parse(listproductHaravan.products[i].variants[j].price.ToString(), cultureInfo);
                            }
                            catch (FormatException ex)
                            {
                                Log.Error("HARAVAN : Parse discounted_price Error. " + listproductHaravan.products[i].variants[0].price + "/r/n" + ex);
                                continue;
                            }
                            if (price <= 0)
                            {
                                Log.Error("HARAVAN : Product price equal = 0" + "Product: ID " + tmpProduct.ID + " - " + tmpProduct.Name);
                                continue;
                            }
                            if (originPrice > price)
                            {
                                tmpProduct.OriginPrice = originPrice;
                                tmpProduct.Price = price;
                            }
                            else
                            {
                                tmpProduct.OriginPrice = tmpProduct.Price = price;
                            }

                            //Categories 
                            tmpProduct.Categories = new List<string>();
                            tmpProduct.Categories.Add(company.Domain);
                            tmpProduct.Categories.Add(listproductHaravan.products[i].product_type);
                            tmpProduct.IDCategories = Common.GetIDClassification(Common.ConvertToString(tmpProduct.Categories, " -> "));

                            // list Url Images
                            if (checkImage)
                            {
                                //check image_id của variant
                                
                                int image_id = Common.Obj2Int(listproductHaravan.products[i].variants[j].image_id);
                                //nếu != 0 thì tìm values trong dicImage tương ứng
                                if (image_id != 0)
                                {
                                    string imageurl = dicImage.Where(kvp => kvp.Key == image_id).Select(kvp => kvp.Value).FirstOrDefault();
                                    if (!string.IsNullOrEmpty(imageurl))
                                        tmpProduct.ImageUrls = new List<string>() { imageurl };
                                    else
                                        tmpProduct.ImageUrls = new List<string>() { listproductHaravan.products[i].images[0].src };
                                }
                                // nếu = 0 (null) thì lấy ảnh mặc định images[0].src
                                else
                                    tmpProduct.ImageUrls = new List<string>() { listproductHaravan.products[i].images[0].src };
                            }
                            else
                                tmpProduct.ImageUrls = new List<string>();
                            if (listproductHaravan.products[i].variants[0] != null)
                            {
                                tmpProduct.VATStatus = listproductHaravan.products[i].variants[0].taxable == false
                                    ? Common.VATStatus.NotVAT
                                    : Common.VATStatus.HaveVAT;
                            }
                            else
                                tmpProduct.VATStatus = Common.VATStatus.UndefinedVAT;

                            ListProducts.Add(tmpProduct);
                            #endregion
                        }
                    }
                    else if (variant < 1)
                    {
                        Log.ErrorFormat("HARAVAN : Error : Variant of {0}  = 0", listproductHaravan.products[i].title);
                    }

                }
                #endregion
            }
            return ListProducts;
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang cập nhật dữ liệu " + shopNameTextEdit.Text);
            try
            {
                long idcompany = Common.Obj2Int64(companyIdWSSSpinEdit.Text);
                QT.Entities.Company company = new QT.Entities.Company(idcompany);
                string shopname = shopNameTextEdit.Text;
                string accesstoken = accessTokenTextEdit.Text;
                List<QT.Entities.Product> ListProducts = GetProductFromHaravan(shopname, accesstoken, company);
                labelControlMessage.Text = string.Format("Get {0} product!", ListProducts.Count);
                CompanyFunctions companyFunctions = new CompanyFunctions();
                var cancelUpdateDataFeedTokenSource = new CancellationTokenSource();
                companyFunctions.UpdateProductsToSql(company, ListProducts, cancelUpdateDataFeedTokenSource);

                #region Public Cửa hàng
                long idharavan = Common.Obj2Int64(companyIdHaravanSpinEdit.Text);
                company_HaravanTableAdapter.UpdateIsPublic(true, idharavan);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
            Wait.Close();
        }

        private void CheckCompanyButton_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang kiểm tra công ty!");
            //idcomnay này có thể là idharavan hoặc id mới đc sinh ra theo domain chính xác
            long idcompany = Common.Obj2Int64(companyIdWSSSpinEdit.Text);

            //QT.Entities.Company company = new QT.Entities.Company(idcompany);
            #region CheckCompany
            try
            {
                DBWebPartnerTableAdapters.CompanyTableAdapter companyAdapter = new DBWebPartnerTableAdapters.CompanyTableAdapter();
                companyAdapter.Connection.ConnectionString = Server.ConnectionString;
                DBWebPartner.CompanyDataTable _companyTable = new DBWebPartner.CompanyDataTable();
                companyAdapter.FillBy_ID(_companyTable, idcompany);
                //Trường hợp cài app thành công nhưng lúc tạo ra company xảy ra lỗi (api.websosanh.vn).
                // Lấy dữ liệu company từ haravan và thêm mới vào database.
                if (_companyTable.Rows.Count == 0)
                {
                    string shopname = shopNameTextEdit.Text;
                    string accesstoken = accessTokenTextEdit.Text;
                    HaravanAuthorizationState authorizeState = new HaravanAuthorizationState();
                    authorizeState.ShopName = shopname;
                    authorizeState.AccessToken = accesstoken;
                    var client = new HaravanAPIClient(authorizeState);
                    object obj = client.Get("/admin/shop.json");
                    if (obj != null)
                    {
                        ShopHaravanInfo shopharavanInfo = JsonConvert.DeserializeObject<ShopHaravanInfo>(obj.ToString());
                        //domain và website lấy theo domain chính xác được config (hoặc mặc định là shopname.myharavan.com)
                        string website = string.Format("http://{0}/", domainChinhXacTextEdit.Text);
                        Uri uri = new Uri(website);
                        String domain = uri.Host.ToLower();
                        domain = domain.Replace("www.", "");
                        TimeSpan timestartup = new TimeSpan(0, 1, 1, 0);
                        TimeSpan timeSleep = new TimeSpan(0, 1, 1, 0);
                        Alexa a = new Alexa();
                        a = Common.GetRankAlexa(uri.Host);
                        #region Insert
                        try
                        {
                            companyAdapter.Insert(
                                 Common.GetIDCompany(domain),
                                 authorizeState.ShopName,
                                 "Shop in Haravan install App",
                                 website,
                                 domain,
                                 DateTime.Now,
                                 shopharavanInfo.shop.phone,
                                 shopharavanInfo.shop.email,
                                 shopharavanInfo.shop.customer_email,
                                 shopharavanInfo.shop.address1,
                                 Common.CompanyStatus.WEB_HARAVAN,
                                 "",
                                 a.AlexaRankContries,
                                 a.AlexaRank,
                                 timestartup,
                                 timeSleep,
                                 0,
                                 0,
                                 DateTime.Now,
                                 DateTime.Now,
                                 30,
                                 0,
                                 0,
                                 0,
                                 "",
                                 DateTime.Now,
                                 0);
                            Log.InfoFormat("HARAVAN : Insert Company Success With ShopName = {0}", authorizeState.ShopName);
                            MessageBox.Show("Thêm mới công ty thành công!");
                        }
                        catch (Exception ex)
                        {
                            Log.ErrorFormat("HARAVAN : Error Insert Company {0}", ex);
                        }
                        #endregion
                    }
                }
                else
                {
                    MessageBox.Show("Có công ty này!");
                }
            }
            catch (Exception exx)
            {
                Log.ErrorFormat("HARAVAN : CheckCompany {0}", exx);
            }
            #endregion
            Wait.Close();
        }

        private void DownloadAllImageButton_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang download ảnh");
            try
            {
                long idcompany = Common.Obj2Int64(companyIdWSSSpinEdit.Text);
                string _domain = domainChinhXacTextEdit.Text;
                DBWebPartnerTableAdapters.ProductTableAdapter productAdapter = new DBWebPartnerTableAdapters.ProductTableAdapter();
                productAdapter.Connection.ConnectionString = Server.ConnectionString;
                DBWebPartner.ProductDataTable productTable = new DBWebPartner.ProductDataTable();
                productAdapter.FillBy_CompanyAndValid1(productTable, idcompany);
                if (productTable.Rows.Count == 0)
                {
                    MessageBox.Show("Shop không có sản phẩm! Vui lòng kiểm tra lại!");
                }
                else
                {
                    int count = productTable.Rows.Count;
                    int countproduct = 0;
                    int countproductimagesuccess = 0;
                    for (int i = 0; i < count; i++)
                    {
                        Wait.Show(string.Format("Download ảnh {0}/{1}", i.ToString(), count.ToString()));
                        long idProduct = long.Parse(productTable.Rows[i]["ID"].ToString());
                        string imageurls = productTable.Rows[i]["ImageUrls"].ToString();
                        string nameproduct = productTable.Rows[i]["Name"].ToString();
                        if (!string.IsNullOrEmpty(imageurls))
                        {
                            countproduct++;
                            string imagepath = string.Empty;
                            imagepath = Common.UploadImageProductStore(nameproduct, _domain, imageurls);
                            if (imagepath != "")
                            {
                                countproductimagesuccess++;
                                try
                                {
                                    productTableAdapter.UpdateImagePath(imagepath, idProduct);
                                }
                                catch (Exception ex)
                                {
                                    richTextBoxMessage.Text += ex.Message;
                                }
                            }
                            else
                                richTextBoxMessage.Text += idProduct.ToString() + "Upload fails\r\n";
                        }
                        else
                            richTextBoxMessage.Text += idProduct.ToString() + "Url null or Empty\r\n";
                    }
                    labelControlMessageImage.Text = string.Format("Upload ảnh {0} sản phẩm. Thành công {1}/{2}", count, countproductimagesuccess, countproduct);
                }
            }
            catch (Exception ex)
            {
                richTextBoxMessage.Text += ex.Message;
            }
            Wait.Close();
        }

        private void UnPublicShopButton_Click(object sender, EventArgs e)
        {
            Wait.Show("Ngừng public cửa hàng" + shopNameTextEdit.Text);
            #region Cập nhật Toàn bộ sản phẩm Valid = 0
            try
            {
                long idcompanywss = Common.Obj2Int64(companyIdWSSSpinEdit.Text);
                DBWebPartnerTableAdapters.ProductTableAdapter productAdapter = new DBWebPartnerTableAdapters.ProductTableAdapter();
                productAdapter.Connection.ConnectionString = Server.ConnectionString;
                productAdapter.UpdateValidProductByCompanyId(false, idcompanywss);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật Valid = 0 lỗi!" + ex.Message);
                return;
            }
            #endregion
            #region Cập nhật IsPublic = 0 trong Company_Haravan
            try
            {
                long idcompanyharavan = Common.Obj2Int64(companyIdHaravanSpinEdit.Text);
                DBWebPartnerTableAdapters.Company_HaravanTableAdapter haravanAdapter = new DBWebPartnerTableAdapters.Company_HaravanTableAdapter();
                haravanAdapter.Connection.ConnectionString = Server.ConnectionString;
                haravanAdapter.UpdateIsPublic(false, idcompanyharavan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật IsPublic = 0 lỗi!" + ex.Message);
            }
            #endregion
            Wait.Close();
        }

        private void ReloadCompanyHaravanButton_Click(object sender, EventArgs e)
        {
            this.company_HaravanTableAdapter.FillBy_IsActive(this.dBWebPartner.Company_Haravan, true);
        }

        private void DownloadImageThieuButton_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang download ảnh");
            long idcompany = Common.Obj2Int64(companyIdWSSSpinEdit.Text);
            string _domain = domainChinhXacTextEdit.Text;
            DBWebPartnerTableAdapters.ProductTableAdapter productAdapter = new DBWebPartnerTableAdapters.ProductTableAdapter();
            productAdapter.Connection.ConnectionString = Server.ConnectionString;
            DBWebPartner.ProductDataTable productTable = new DBWebPartner.ProductDataTable();
            productAdapter.FillBy_CompanyAndImagePathNullAndValid1(productTable, idcompany);
            if (productTable.Rows.Count == 0)
            {
                MessageBox.Show("Shop không có sản phẩm! Vui lòng kiểm tra lại!");
            }
            else
            {
                int count = productTable.Rows.Count;
                int countproduct = 0;
                int countproductimagesuccess = 0;
                for (int i = 0; i < count; i++)
                {
                    Wait.Show(string.Format("Download ảnh {0}/{1}", i.ToString(), count.ToString()));
                    long idProduct = long.Parse(productTable.Rows[i]["ID"].ToString());
                    string imageurls = productTable.Rows[i]["ImageUrls"].ToString();
                    string nameproduct = productTable.Rows[i]["Name"].ToString();
                    if (!string.IsNullOrEmpty(imageurls))
                    {
                        countproduct++;
                        string imagepath = string.Empty;
                        imagepath = Common.UploadImageProductStore(nameproduct, _domain, imageurls);
                        if (imagepath != "")
                        {
                            countproductimagesuccess++;
                            productTableAdapter.UpdateImagePath(imagepath, idProduct);
                        }
                        else
                            richTextBoxMessage.Text += idProduct.ToString() + "Upload fails\r\n";
                    }
                    else
                        richTextBoxMessage.Text += idProduct.ToString() + "Url null or Empty\r\n";

                }
                labelControlMessageImage.Text = string.Format("Upload ảnh {0} sản phẩm. Thành công {1}/{2}", count, countproductimagesuccess, countproduct);
            }
            Wait.Close();
        }

        private void LoadProductDatabaseButton_Click(object sender, EventArgs e)
        {
            Wait.Show("Load all product in database!");
            try
            {
                DBWebPartnerTableAdapters.ProductTableAdapter productAdapter = new DBWebPartnerTableAdapters.ProductTableAdapter();
                productAdapter.Connection.ConnectionString = Server.ConnectionString;
                long idwss = Common.Obj2Int64(companyIdWSSSpinEdit.Text);
                productAdapter.FillBy_CompanyId(dBWebPartner.Product, idwss);
            }
            catch (Exception)
            {
                //MessageBox.Show("Lỗi!");
            }
            Wait.Close();
        }

        private void toolStripMenuItemUpdateDomain_Click(object sender, EventArgs e)
        {
            this.xtraTabControl1.SelectedTabPage = xtraTabPage4;
        }

        private void toolStripMenuItemUnPublic_Click(object sender, EventArgs e)
        {
            UnPublicShopButton_Click(null, null);
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.gridControl1,new Point(e.X,e.Y));
            }
        }

        private void ButtonCheckCompanyByDomain_Click(object sender, EventArgs e)
        {
            string domain = "%" + textEditDomain.Text + "%";
            try
            {
                this.companySearchTableAdapter.FillBy_LikeDomain(dBWebPartner.CompanySearch, domain);
                if (dBWebPartner.CompanySearch.Rows.Count <= 0)
                {
                    labelControlCheckDomain.Text = "Domain này chưa tồn tại trong Database!";
                }
            }
            catch (Exception)
            {
            }
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Update valid = 0 sản phẩm theo domain cũ
                long idharavanold = 0;
                long.TryParse(iDTextEdit.Text, out idharavanold);
                this.productTableAdapter.UpdateValidProductByCompanyId(false, idharavanold);

                this.companyBindingSource.EndEdit();
                //Update thông tin Công ty
                this.companyTableAdapter.Update(dBWebPartner.Company);
                this.dBWebPartner.Company.AcceptChanges();
                //Update domain chính xác vào bảng Company_Haravan
                this.company_HaravanTableAdapter.UpdateDomainChinhXac(Common.Obj2Int64(iDTextEdit.Text), domainTextEdit.Text, Common.Obj2Int64(companyIdHaravanSpinEdit.Text));
                MessageBox.Show("Cập nhật thành công Domain! Sang Tab Sản phẩm --> Click vào  UpdateProduct để cập nhật lại sản phẩm!");
                //gán lại dữ liệu vào companyidwss trong bảng company_haravan để đỡ phải load lại dữ liệu
                companyIdWSSSpinEdit.Text = iDTextEdit.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
        }

        private void domainTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(domainTextEdit.Text))
            {
                iDTextEdit.Text = Common.GetIDCompany(domainTextEdit.Text).ToString();
                websiteTextEdit.Text = "http://" + domainTextEdit.Text + "/";
            }
        }

        private void gridViewCompany_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip2.Show(this.gridControlCompany, new Point(e.X, e.Y));
            }
        }

        private void UpdateByDomainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //id có từ domain demo.myharavan.com (idcompany hiện tại)
            long idharavanold = 0;
            //id check được trong hệ thống VD: demo.com (idcompany sẽ được chuyển)
            long idwebsosanh = 0;

            long.TryParse(iDTextEdit.Text, out idharavanold);
            long.TryParse(iDTextEditCompanySearch.Text, out idwebsosanh);

            if (idharavanold != idwebsosanh)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật theo domain này không? Thao tác này sẽ không thể hoàn tác lại dữ liệu như trước!", "Thay đổi Domain", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        //Xóa công ty mà id lấy từ demo.myharavan.com
                        //this.companyTableAdapter.DeleteById(idharavanold);
                        //Cập nhật Domain và ID mới vào bảng Company_Haravan
                        this.company_HaravanTableAdapter.UpdateDomainChinhXac(idwebsosanh, domainTextEditSearch.Text, Common.Obj2Int64(companyIdHaravanSpinEdit.Text));
                        //Cập nhật lại thông tin mới vào company (status)
                        this.companySearchTableAdapter.UpdateStatusByID(QT.Entities.Common.CompanyStatus.WEB_HARAVAN, idwebsosanh);
                        //Update valid = 0 sản phẩm theo domain cũ
                        this.productTableAdapter.UpdateValidProductByCompanyId(false, idharavanold);
                        companyIdWSSSpinEdit.Text = idwebsosanh.ToString();
                        MessageBox.Show("Update success!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR " + ex.Message);
                    }
                }
            }
            else
                MessageBox.Show("Domain muốn thay đổi giống Domain hiện tại!");
        }

        private void textEditDomain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonCheckCompanyByDomain_Click(null, null);
            }
        }

        private void companyIdHaravanSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            long companyid = Common.Obj2Int64(companyIdWSSSpinEdit.Text);
            try
            {
                this.companyTableAdapter.FillBy_ID(dBWebPartner.Company, companyid);
            }
            catch (Exception)
            {
            }
        }
    }
}
