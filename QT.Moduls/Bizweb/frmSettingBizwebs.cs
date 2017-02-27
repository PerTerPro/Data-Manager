using BizwebAPIAdapterLibrary;
using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Moduls.Company;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.Bizweb
{
    public partial class frmSettingBizwebs : frmBase
    {
        #region Private
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmSettingBizwebs));
        #endregion

        #region Constructor
        public frmSettingBizwebs()
        {
            InitializeComponent();
        }
        private void frmSettingBizwebs_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.companySearchTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.company_StatusTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.companyTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.company_BizwebTableAdapter.Connection.ConnectionString = Server.ConnectionString;

            this.company_StatusTableAdapter.Fill(this.dBBizweb.Company_Status);
            this.company_BizwebTableAdapter.FillBy_IsActive(this.dBBizweb.Company_Bizweb,true);
        }
        #endregion

        #region Method
        public static List<QT.Entities.Product> GetProductFromBizweb(string shopname, string accesstoken, QT.Entities.Company company)
        {
            List<QT.Entities.Product> ListProducts = new List<QT.Entities.Product>();
            var authorizeState = new BizwebAuthorizationState() { ShopName = shopname, AccessToken = accesstoken };
            var client = new BizwebAPIClient(authorizeState);
            ProductBizwebInfo listproductBizweb = new ProductBizwebInfo() { products = new List<Product>()};
            bool check = true;
            int page = 1;
            while (check)
            {
                Object obj = null;
                try
                {
                    //Mỗi lần lấy về 50 product của bizweb
                    string querry = "admin/products.json?page=" + page.ToString()+"&limit=250";
                    //string querry = "/admin/products.json";
                    obj = client.Get(querry);
                    //Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    check = false;
                    Log.ErrorFormat("BIZWEB : Get/admin/products.json FAILS. ERROR : {0}", ex);
                }
                if (obj != null)
                {
                    ProductBizwebInfo listproduct = JsonConvert.DeserializeObject<ProductBizwebInfo>(obj.ToString());
                    if (listproduct.products.Count > 0)
                    {
                        listproductBizweb.products.AddRange(listproduct.products);
                        page++;
                    }
                    else
                        check = false;
                }
                else
                    check = false;
            }
            if (listproductBizweb.products.Count>0)
            {
                #region Chuyển từ ListProducts of Bizweb sang ListProductWebsosanh
                for (int i = 0; i < listproductBizweb.products.Count; i++)
                {
                    //Check số lượng phiên bản variant
                    int variant = listproductBizweb.products[i].variants.Count;
                    //TH variant = 1 (1 phiên bản)
                    if (variant == 1)
                    {
                        #region Product
                        var tmpProduct = new QT.Entities.Product();
                        tmpProduct.Domain = company.Domain;
                        string parameter = "?";
                        if (!string.IsNullOrEmpty(listproductBizweb.products[i].alias) && listproductBizweb.products[i].alias.Contains("?"))
                        {
                            parameter = "&";
                        }
                        tmpProduct.DetailUrl = company.Website + "products/" + listproductBizweb.products[i].alias + parameter + "utm=websosanh";

                        tmpProduct.ID = Common.GetIDProduct(tmpProduct.DetailUrl);

                        if (listproductBizweb.products[i].variants[0].sku != null)
                        {
                            tmpProduct.MerchantSku = listproductBizweb.products[i].variants[0].sku.ToString();
                        }

                        if (listproductBizweb.products[i].variants[0].inventory_policy == "continue" || listproductBizweb.products[i].variants[0].inventory_management == "")
                        {
                            tmpProduct.Status = Common.ProductStatus.Available;
                        }
                        else if (listproductBizweb.products[i].variants[0].inventory_policy == "deny")
                        {
                            var inventory_quantity = Common.Obj2Int(listproductBizweb.products[i].variants[0].inventory_quantity);
                            if (inventory_quantity > 0)
                                tmpProduct.Status = Common.ProductStatus.Available;
                            else
                                tmpProduct.Status = Common.ProductStatus.Clear;
                        }
                        else
                            tmpProduct.Status = Common.ProductStatus.LienHe;
                        tmpProduct.Instock = QT.Entities.Common.GetProductInstockFormStatus(tmpProduct.Status);
                        tmpProduct.Manufacture = listproductBizweb.products[i].vendor;

                        tmpProduct.Name = listproductBizweb.products[i].name;
                        tmpProduct.HashName = Common.GetHashNameProduct(company.Domain, tmpProduct.Name.Trim());

                        tmpProduct.ProductContent = listproductBizweb.products[i].meta_description;

                        CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                        int originPrice = 0;
                        int price = 0;
                        string compare_at_price;
                        string price_temp;
                        if ((listproductBizweb.products[i].variants[0].compare_at_price == null || listproductBizweb.products[i].variants[0].compare_at_price == 0) && listproductBizweb.products[i].variants[0].price == 0)
                        {
                            Log.Error("BIZWEB : Product price equal = 0" + "Product: ID " + tmpProduct.ID + " - " + tmpProduct.Name);
                            continue;
                        }
                        else
                        {
                            compare_at_price = listproductBizweb.products[i].variants[0].compare_at_price.ToString();
                            compare_at_price = (compare_at_price.Contains('.')) ? compare_at_price.Remove(compare_at_price.IndexOf('.')) : compare_at_price;
                            price_temp = listproductBizweb.products[i].variants[0].price.ToString();
                            price_temp = (price_temp.Contains('.')) ? price_temp.Remove(price_temp.IndexOf('.')) : price_temp;
                        }
                        try
                        {
                            originPrice = (int)Decimal.Parse(compare_at_price, cultureInfo);
                        }
                        catch (FormatException)
                        {
                        }
                        catch (Exception exception)
                        {
                            Log.Error(string.Format("BIZWEB : Parse discounted_price Error. {0}",tmpProduct.DetailUrl), exception);
                        }
                        try
                        {
                            price = (int)Decimal.Parse(price_temp, cultureInfo);
                        }
                        catch (FormatException ex)
                        {
                            Log.Error("BIZWEB : Parse discounted_price Error. " + listproductBizweb.products[i].variants[0].price + "\r\n" + ex);
                        }
                        catch (Exception exception)
                        {
                            Log.Error(string.Format("BIZWEB : Parse discounted_price Error. {0}", tmpProduct.DetailUrl), exception);
                        }

                        if (price <= 0)
                        {
                            Log.Error("BIZWEB : Product price equal = 0" + "Product: ID " + tmpProduct.ID + " - " + tmpProduct.Name);
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
                        tmpProduct.Categories.Add(listproductBizweb.products[i].product_type);
                        tmpProduct.IDCategories = Common.GetIDClassification(Common.ConvertToString(tmpProduct.Categories, " -> "));

                        // list Url Images
                        if (listproductBizweb.products[i].images != null && listproductBizweb.products[i].images.Count != 0)
                        {
                            tmpProduct.ImageUrls = new List<string>() { listproductBizweb.products[i].images[0].src };
                        }
                        else
                            tmpProduct.ImageUrls = new List<string>();
                        if (listproductBizweb.products[i].variants[0] != null)
                        {
                            tmpProduct.VATStatus = listproductBizweb.products[i].variants[0].taxable == false ? Common.VATStatus.NotVAT : Common.VATStatus.HaveVAT;
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
                        if (listproductBizweb.products[i].images != null && listproductBizweb.products[i].images.Count != 0)
                        {
                            checkImage = true;
                            for (int k = 0; k < listproductBizweb.products[i].images.Count; k++)
                            {
                                dicImage.Add(listproductBizweb.products[i].images[k].id, listproductBizweb.products[i].images[k].src);
                            }
                        }
                        else
                            checkImage = false;

                        for (int j = 0; j < variant; j++)
                        {
                            #region Product
                            var tmpProduct = new QT.Entities.Product();
                            tmpProduct.Domain = company.Domain;
                            string parameter = "?";
                            if (!string.IsNullOrEmpty(listproductBizweb.products[i].alias) && listproductBizweb.products[i].alias.Contains("?"))
                            {
                                parameter = "&";
                            }
                            tmpProduct.DetailUrl = company.Website + "products/" + listproductBizweb.products[i].alias + "#" + (j + 1).ToString() + parameter + "utm=websosanh";
                            tmpProduct.ID = Common.GetIDProduct(tmpProduct.DetailUrl);

                            if (listproductBizweb.products[i].variants[j].sku != null)
                            {
                                tmpProduct.MerchantSku = listproductBizweb.products[i].variants[j].sku.ToString();
                            }

                            if (listproductBizweb.products[i].variants[j].inventory_policy == "continue" || listproductBizweb.products[i].variants[j].inventory_management == "")
                            {
                                tmpProduct.Status = Common.ProductStatus.Available;
                            }
                            else if (listproductBizweb.products[i].variants[j].inventory_policy == "deny")
                            {
                                int inventory_quantity = Common.Obj2Int(listproductBizweb.products[i].variants[j].inventory_quantity);
                                if (inventory_quantity > 0)
                                    tmpProduct.Status = Common.ProductStatus.Available;
                                else
                                    tmpProduct.Status = Common.ProductStatus.Clear;
                            }
                            else
                                tmpProduct.Status = Common.ProductStatus.LienHe;
                            tmpProduct.Instock = QT.Entities.Common.GetProductInstockFormStatus(tmpProduct.Status);
                            tmpProduct.Manufacture = listproductBizweb.products[i].vendor;
                            string nameproduct = listproductBizweb.products[i].name;
                            if (listproductBizweb.products[i].variants[j].option1 != null)
                            {
                                nameproduct = nameproduct + " " + listproductBizweb.products[i].options[0].name + " " + listproductBizweb.products[i].variants[j].option1;
                            }
                            if (listproductBizweb.products[i].variants[j].option2 != null)
                            {
                                nameproduct = nameproduct + " " + listproductBizweb.products[i].variants[j].option2;
                            }
                            if (listproductBizweb.products[i].variants[j].option3 != null)
                            {
                                nameproduct = nameproduct + " " + listproductBizweb.products[i].variants[j].option3;
                            }
                            tmpProduct.Name = nameproduct;
                            tmpProduct.HashName = Common.GetHashNameProduct(company.Domain, tmpProduct.Name.Trim());

                            tmpProduct.ProductContent = listproductBizweb.products[i].meta_description;

                            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                            int originPrice = 0;
                            int price = 0;
                            try
                            {
                                originPrice = (int)Decimal.Parse(listproductBizweb.products[i].variants[0].compare_at_price.ToString(), cultureInfo);
                            }
                            catch (FormatException)
                            {
                            }
                            try
                            {
                                price = (int)Decimal.Parse(listproductBizweb.products[i].variants[0].price.ToString(), cultureInfo);
                            }
                            catch (FormatException ex)
                            {
                                Log.Error("BIZWEB : Parse discounted_price Error. " + listproductBizweb.products[i].variants[0].price + "\r\n" + ex);
                                continue;
                            }
                            if (price <= 0)
                            {
                                Log.Error("BIZWEB : Product price equal = 0" + "Product: ID " + tmpProduct.ID + " - " + tmpProduct.Name);
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
                            tmpProduct.Categories.Add(listproductBizweb.products[i].product_type);
                            tmpProduct.IDCategories = Common.GetIDClassification(Common.ConvertToString(tmpProduct.Categories, " -> "));

                            // list Url Images
                            if (checkImage)
                            {
                                int image_id = Common.Obj2Int(listproductBizweb.products[i].variants[j].image_id);
                                //nếu != 0 thì tìm values trong dicImage tương ứng
                                if (image_id != 0)
                                {
                                    string imageurl = dicImage.Where(kvp => kvp.Key == image_id).Select(kvp => kvp.Value).FirstOrDefault();
                                    if (!string.IsNullOrEmpty(imageurl))
                                        tmpProduct.ImageUrls = new List<string>() { imageurl };
                                    else
                                        tmpProduct.ImageUrls = new List<string>() { listproductBizweb.products[i].images[0].src };
                                }
                                // nếu = 0 (null) thì lấy ảnh mặc định images[0].src
                                else
                                    tmpProduct.ImageUrls = new List<string>() { listproductBizweb.products[i].images[0].src };
                            }
                            else
                                tmpProduct.ImageUrls = new List<string>();
                            if (listproductBizweb.products[i].variants[j] != null)
                            {
                                tmpProduct.VATStatus = listproductBizweb.products[i].variants[j].taxable == false ? Common.VATStatus.NotVAT : Common.VATStatus.HaveVAT;
                            }
                            else
                                tmpProduct.VATStatus = Common.VATStatus.UndefinedVAT;
                            ListProducts.Add(tmpProduct);
                            #endregion
                        }
                    }
                    else if (variant < 1)
                    {
                        Log.ErrorFormat("Error : Variant of {0}  = 0", listproductBizweb.products[i].name);
                    }
                #endregion
            }
                
            }
            return ListProducts;
        }
        #endregion

        #region Event Button
        private void simpleButtonTestProduct_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang tải dữ liệu...");
            long idcompany = Common.Obj2Int64(companyIdWSSTextEdit.Text);
            QT.Entities.Company company = new QT.Entities.Company(idcompany);
            if (company.Name.ToLower() == "not in database")
                MessageBox.Show("ERROR! Không tồn tại công ty này trong database!");
            else
            {
                string shopname = shopNameTextEdit.Text;
                string accesstoken = accessTokenTextEdit.Text;
                gridControlProduct.DataSource = GetProductFromBizweb(shopname, accesstoken, company);
            }
            Wait.Close();
        }
        private void simpleButtonUpdateProduct_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang cập nhật dữ liệu " + shopNameTextEdit.Text);
            try
            {
                long idcompany = Common.Obj2Int64(companyIdWSSTextEdit.Text);
                QT.Entities.Company company = new QT.Entities.Company(idcompany);
                string shopname = shopNameTextEdit.Text;
                string accesstoken = accessTokenTextEdit.Text;
                List<QT.Entities.Product> ListProducts = GetProductFromBizweb(shopname, accesstoken, company);
                CompanyFunctions companyFunctions = new CompanyFunctions();
                var cancelUpdateDataFeedTokenSource = new CancellationTokenSource();
                companyFunctions.UpdateProductsToSql(company, ListProducts, cancelUpdateDataFeedTokenSource);

                #region Public Cửa hàng
                long idbizweb = Common.Obj2Int64(companyIdBizwebTextEdit.Text);
                company_BizwebTableAdapter.UpdateIsPublic(true, idbizweb);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
            Wait.Close();
        }

        private void simpleButtonLoadProductInSql_Click(object sender, EventArgs e)
        {
            Wait.Show("Load all product in database!");
            try
            {
                DBBizwebTableAdapters.ProductTableAdapter productAdapter = new DBBizwebTableAdapters.ProductTableAdapter();
                productAdapter.Connection.ConnectionString = Server.ConnectionString;
                long idwss = Common.Obj2Int64(companyIdWSSTextEdit.Text);
                productAdapter.FillBy_CompanyId(dBBizweb.Product, idwss);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR! Load Product from Database fails!");
            }
            Wait.Close();
        }
        private void ButtonCheckCompanyByDomain_Click(object sender, EventArgs e)
        {
            string domain = "%" + textEditDomainCheck.Text + "%";
            try
            {
                this.companySearchTableAdapter.FillBy_LikeDomain(dBBizweb.CompanySearch, domain);
                if (dBBizweb.CompanySearch.Rows.Count <= 0)
                {
                    labelControlCheckDomain.Text = "Domain này chưa tồn tại trong Database!";
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region Event EditValueChanged
        private void companyIdBizwebTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            long companyid = Common.Obj2Int64(companyIdWSSTextEdit.Text);
            try
            {
                this.companyTableAdapter.FillBy_ID(dBBizweb.Company, companyid);
            }
            catch (Exception)
            {
            }
        }

        #endregion

        private void textEditDomainCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonCheckCompanyByDomain_Click(null, null);
            }
        }

        private void toolStripMenuItemUpdateDomain_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageUpdateDomain;
        }

        private void simpleButtonSaveCompany_Click(object sender, EventArgs e)
        {
            Save();
        }
        public override bool Save()
        {
            try
            {
                this.companyBindingSource.EndEdit();
                this.companyTableAdapter.Update(dBBizweb.Company);
                this.dBBizweb.Company.AcceptChanges();
                //Update domain chính xác vào bảng Company_Haravan
                this.company_BizwebTableAdapter.UpdateDomainChinhXac(Common.Obj2Int64(iDCompanyTextEdit.Text), domainCompanyTextEdit.Text, Common.Obj2Int64(companyIdBizwebTextEdit.Text));
                //MessageBox.Show("Cập nhật thành công Domain! Sang Tab Sản phẩm --> Click vào  UpdateProduct để cập nhật lại sản phẩm!");
                //gán lại dữ liệu vào companyidwss trong bảng company_haravan để đỡ phải load lại dữ liệu
                companyIdWSSTextEdit.Text = iDCompanyTextEdit.Text;
                MessageBox.Show("OK! Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
                return false;
            }
            return true;
        }

        private void company_BizwebGridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(company_BizwebGridControl, e.Location);
            }
        }

        private void gridControlCompany_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip2.Show(gridControlCompany, e.Location);
            }
        }

        private void domainCompanyTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(domainCompanyTextEdit.Text))
            {
                iDCompanyTextEdit.Text = Common.GetIDCompany(domainCompanyTextEdit.Text).ToString();
                websiteCompanyTextEdit.Text = "http://" + domainCompanyTextEdit.Text + "/";
            }
        }

        private void toolStripButtonRefreshData_Click(object sender, EventArgs e)
        {
            this.company_BizwebTableAdapter.FillBy_IsActive(dBBizweb.Company_Bizweb, true);
        }

        private void toolStripMenuItemUpdateByCurrentDomain_Click(object sender, EventArgs e)
        {
            //id có từ domain demo.bizwebvietnam.net(idcompany hiện tại)
            long idbizold = 0;
            //id check được trong hệ thống VD: demo.com (idcompany sẽ được chuyển)
            long idwebsosanh = 0;

            long.TryParse(iDCompanyTextEdit.Text, out idbizold);
            long.TryParse(iDCompanySearchTextEdit.Text, out idwebsosanh);

            if (idbizold != idwebsosanh)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật theo domain này không? Thao tác này sẽ không thể hoàn tác lại dữ liệu như trước!", "Thay đổi Domain", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        //Xóa công ty mà id lấy từ demo.bizwebvietnam.net
                        //this.companyTableAdapter.DeleteById(idbizold);
                        //Cập nhật Domain và ID mới vào bảng Company_Bizweb
                        this.company_BizwebTableAdapter.UpdateDomainChinhXac(idwebsosanh, domainCompanySearchTextEdit.Text, Common.Obj2Int64(companyIdBizwebTextEdit.Text));
                        //Cập nhật lại thông tin mới vào company (status)
                        this.companySearchTableAdapter.UpdateStatusByID(QT.Entities.Common.CompanyStatus.WEB_BIZWEB, idwebsosanh);
                        companyIdWSSTextEdit.Text = idwebsosanh.ToString();
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

        private void toolStripMenuItemUnPublicStore_Click(object sender, EventArgs e)
        {
            Wait.Show("Ngừng public cửa hàng" + shopNameTextEdit.Text);
            #region Cập nhật Toàn bộ sản phẩm Valid = 0
            try
            {
                long idcompanywss = Common.Obj2Int64(companyIdWSSTextEdit.Text);
                DBBizwebTableAdapters.ProductTableAdapter productAdapter = new DBBizwebTableAdapters.ProductTableAdapter();
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
                long idcompanybizweb = Common.Obj2Int64(companyIdBizwebTextEdit.Text);
                DBBizwebTableAdapters.Company_BizwebTableAdapter bizwebAdapter = new DBBizwebTableAdapters.Company_BizwebTableAdapter();
                bizwebAdapter.Connection.ConnectionString = Server.ConnectionString;
                bizwebAdapter.UpdateIsPublic(false, idcompanybizweb);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật IsPublic = 0 lỗi!" + ex.Message);
            }
            #endregion
            Wait.Close();
        }



    }
}
