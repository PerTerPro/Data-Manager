using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using log4net;
using QT.Entities;
using QT.Moduls.Crawler.DBCrawlerTableAdapters;
using Newtonsoft.Json;
using System.IO.Compression;
using QT.Entities.Data;
using System.Configuration;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace QT.Moduls.Company
{
    public class CompanyFunctions
    {
        private Price_LogsTableAdapter _adtPriceLog;
        private DBTableAdapters.ClassificationTableAdapter _adtClass;
        private DBComTableAdapters.DatafeedConfigTableAdapter _datafeedConfig;
        private DBTableAdapters.ProductTableAdapter _adtProduct;
        private DBTableAdapters.CompanyTableAdapter _adtCompany;
        private static readonly ILog Log = LogManager.GetLogger(typeof(CompanyFunctions));
        public List<Product> ListProducts;
        private readonly DateTime _lastUpdateProduct;
        private const int DatafeedExpiryMs = 300000; // 300.000 ms = 5 minute
        private DBLogTableAdapters.Product_LogsAddProductTableAdapter _adtLogsAddProduct;

        private JobClient _jobClientUpdateProductToWeb;
        private JobClient _jobClientDownloadImage;
        private string _rabbitMqServerName = string.Empty;
        private int _updateProductToWebJobExpirationMs = 0;
        public CompanyFunctions()
        {
            _lastUpdateProduct = new DateTime(2000, 1, 1);
            ListProducts = new List<Product>();
            //Init RabbitMQ
            Init();
        }
        public void Init()
        {
            try
            {
                #region RabbitMQ
                _rabbitMqServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
                //Jobclient send message to service update solr and redis
                string updateProductGroupName = ConfigurationManager.AppSettings["updateProductGroupName"];
                string updateProductToWebJobName = ConfigurationManager.AppSettings["updateProductToWebJobName"];
                _updateProductToWebJobExpirationMs = Common.Obj2Int(ConfigurationManager.AppSettings["updateProductToWebJobExpirationMS"].ToString());
                //jobclient send message to service download image
                string updateProductImageGroupName = ConfigurationManager.AppSettings["updateProductImageGroupName"];
                string updateProductImageJobName = ConfigurationManager.AppSettings["updateProductImageCompanyJobName"];
                #endregion
                var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(_rabbitMqServerName);
                _jobClientUpdateProductToWeb = new JobClient(updateProductGroupName, GroupType.Topic, updateProductToWebJobName, true, rabbitMqServer);
                _jobClientDownloadImage = new JobClient(updateProductImageGroupName, GroupType.Topic, updateProductImageJobName, true, rabbitMqServer);
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("Error Init RabbitMQDriver: {0}", ex);
            }

        }
        public List<Product> ReturnListProduct(QT.Entities.Company company)
        {
            //Log.Info("Vào đây r");
            List<Product> listProducts = new List<Product>();
            if (company.CompanyDataFeedType == Entities.Company.DataFeedType.AllProductsFromFile ||
                company.CompanyDataFeedType == Entities.Company.DataFeedType.SpecialProductsFromFile)
            {
                var datafeedFileNames = company.DataFeedPath.Split(";".ToCharArray(),
                            StringSplitOptions.RemoveEmptyEntries);
                Log.InfoFormat("Reading new products from file ... Company: {0}", company.Domain);
                foreach (var datafeedFileName in datafeedFileNames)
                {
                    var temp = datafeedFileName.Split('.');
                    string filetype = temp[temp.Length - 1];
                    switch (filetype)
                    {
                        case "csv":
                            listProducts.AddRange(ReadDataFeedProductsFromCsvFile(datafeedFileName, company));
                            break;
                        case "xml":
                            listProducts.AddRange(ReadDataFeedProductsFromXmlFile(datafeedFileName, company));
                            break;
                        case "json":
                            listProducts.AddRange(ReadDataFeedProductsFromJSONFile(datafeedFileName, company));
                            break;
                        default:
                            Log.ErrorFormat("File " + filetype + " get data fails");
                            break;
                    }
                    //ListProducts.AddRange(ReadDataFeedProductsFromXmlFile(datafeedFileName, company));
                }
            }
            else if (company.CompanyDataFeedType == Entities.Company.DataFeedType.AllProductsFromURL || company.CompanyDataFeedType == Entities.Company.DataFeedType.SpecialProductsFromUrl)
            {
                var keyPage = "paging=true";
                if (company.DataFeedPath.Contains(keyPage))
                {
                    using (var wc = new WebClient())
                    {
                        wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36");
                        var json = wc.DownloadString(company.DataFeedPath);
                        //fix riêng cho adayroi.com
                        if (company.ID == 3433481253691794480)
                        {
                            var parameterAdayroi = JsonConvert.DeserializeObject<ParameterDatafeedAdayroi>(json);
                            if (parameterAdayroi.Files.Count > 0)
                            {
                                foreach (var file in parameterAdayroi.Files)
                                {
                                    var urldatafeedpage = company.DataFeedPath.Replace("map.json?paging=true", "") + file;
                                    listProducts.AddRange(ReadDataFeedProductsFromUrl(urldatafeedpage, company, null));
                                }
                            }
                        }
                        else
                        {
                            var parameterDatafeed = JsonConvert.DeserializeObject<ParameterDatafeed>(json);
                            //Phân trang kiểu list các chuyên mục chia nhỏ ra từng link
                            if (parameterDatafeed.Files != null && parameterDatafeed.Files.Count > 0)
                            {
                                foreach (var file in parameterDatafeed.Files)
                                {
                                    var urldatafeedpage = parameterDatafeed.DatafeedUrl + file;
                                    listProducts.AddRange(ReadDataFeedProductsFromUrl(urldatafeedpage, company, null));
                                }
                            }

                            //Phân trang kiểu từng page
                            else if (parameterDatafeed.total_page > 0)
                            {
                                var parameter = "?";
                                if (parameterDatafeed.feed_url.Contains("?"))
                                {
                                    parameter = "&";
                                }
                                for (int i = 0; i < parameterDatafeed.total_page; i++)
                                {
                                    var urldatafeedpage = parameterDatafeed.feed_url + parameter + parameterDatafeed.page_param + "=" + (i + 1).ToString();
                                    var listproducttemp = new List<Product>();
                                    try
                                    {
                                        listproducttemp = ReadDataFeedProductsFromUrl(urldatafeedpage, company, null);
                                    }
                                    catch (Exception ex)
                                    {
                                        Log.Error("ERROR page = " + i + "\r\n" + ex);
                                    }
                                    listProducts.AddRange(listproducttemp);
                                }
                            }
                        }
                    }
                }
                else
                    listProducts = ReadDataFeedProductsFromUrl(company.DataFeedPath, company);
            }
            else if (company.CompanyDataFeedType == Entities.Company.DataFeedType.MasOfferDatafeed)
            {
                listProducts.AddRange(ReadDatafeedProductsFromJsonOfMasOffer(company.DataFeedPath, company));
            }
            else// other type => return
            {
                listProducts = null;
                Log.InfoFormat("DatafeedType Null - Company = {0} / {1}", company.ID, company.Domain);
            }
            return listProducts;
        }
        public void UpdateDataFeedProducts(QT.Entities.Company company, CancellationTokenSource cancelUpdateDataFeedTokenSource)
        {
            Log.InfoFormat("Start Update Company : {0}", company.Domain);
            #region Get Products from DataFeed

            //Get List Product if Expired
            if ((DateTime.Now - _lastUpdateProduct).TotalMilliseconds > DatafeedExpiryMs)
            {
                try
                {
                    ListProducts = ReturnListProduct(company);
                }
                catch (Exception ex)
                {
                    Log.ErrorFormat("Update failed IDCompany = {0}\r\nERROR: {1}", company.ID, ex);
                    HistoryDatafeedAdapter.InsertHistory(company.ID, company.DataFeedPath, 0, 0, 0, ex.Message + "\n" + ex.ToString());
                    return;
                }
            }
            //Read error => return;
            if (ListProducts == null || ListProducts.Count == 0)
            {
                Log.WarnFormat("Reed datafeed return 0 products. Company: {0}", company.Domain);
                return;
            }
            else
                Log.WarnFormat("Reed datafeed return {0} products. Company: {1}", ListProducts.Count, company.Domain);
            #endregion

            if (company.ID == 3502170206813664485)
            {
                Log.Info("Start send message to UpdateSingleProductServices");
                var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(_rabbitMqServerName);
                JobClient jobclient = new JobClient("UpdateProductBatch", GroupType.Topic,
                    "UpdateProduct.UpdateSingleProduct", true, rabbitMqServer);
                foreach (var item in ListProducts)
                { 
                    SendMessageToUpdateSingleProductServices(item, jobclient);
                }
                jobclient.Dispose();
                Log.Info(
                    string.Format("Finished send message to UpdateSingleProductServices. {0} product of Company {1}",
                        ListProducts.Count, company.ID));
            }
            else
            {
                //Check số lượng sản phẩm
                //Nếu thay đổi hoặc giảm sản phẩm thì dừng update và ghi log
                //Dung TotalVaid để so sánh nhưng để đỡ phải sửa code thì dùng totalproduct luôn nên k check đc lazada =))
                //Comment bá đạo
                if ((int)(ListProducts.Count*100/company.TotalProduct) < 50 || (company.TotalProduct - ListProducts.Count)>10000)
                    HistoryDatafeedAdapter.InsertHistory(company.ID, company.DataFeedPath, ListProducts.Count, 0, 0, string.Format("Dừng update do số product ({0}) lấy trong datafeed chênh lệch với totalproduct {1}",ListProducts.Count,company.TotalProduct));
                else
                    UpdateProductsToSql(company, ListProducts, cancelUpdateDataFeedTokenSource);
            }


        }

        /// <summary>
        /// 15.10.2015
        /// Tách phần Update product ra để dùng vào update từ haravan và bizweb
        /// Input là List Product
        /// </summary>
        /// <param name="company"></param>
        /// <param name="listProducts"></param>
        /// <param name="cancelUpdateDataFeedTokenSource"></param>
        public void UpdateProductsToSql(QT.Entities.Company company, List<Product> listProducts, CancellationTokenSource cancelUpdateDataFeedTokenSource = null)
        {
            try
            {
                var categoriesSet = new HashSet<long>();

                var newProductsDict = new Dictionary<long, Product>();
                #region Init Connections

                _adtClass = new DBTableAdapters.ClassificationTableAdapter
                {
                    Connection = new SqlConnection(Server.ConnectionString)
                };
                _adtClass.Connection.Open();

                _adtProduct = new DBTableAdapters.ProductTableAdapter()
                {
                    Connection = new SqlConnection(Server.ConnectionString)
                };
                _adtProduct.Connection.Open();

                _adtPriceLog = new Price_LogsTableAdapter()
                {
                    Connection = new SqlConnection(Server.LogConnectionString)
                };
                _adtPriceLog.Connection.Open();

                _adtCompany = new DBTableAdapters.CompanyTableAdapter()
                {
                    Connection = new SqlConnection(Server.ConnectionString)
                };
                _adtCompany.Connection.Open();

                _adtLogsAddProduct = new DBLogTableAdapters.Product_LogsAddProductTableAdapter()
                {
                    Connection = new SqlConnection(Server.LogConnectionString)
                };

                #endregion

                #region Get All Categories

                Log.Info("Getting list categories...");
                var dtClass = new DB.ClassificationDataTable();
                _adtClass.FillBy_CompanyID(dtClass, company.ID);

                foreach (var dr in dtClass)
                {
                    if (!categoriesSet.Contains(dr.ID))
                    {
                        categoriesSet.Add(dr.ID);

                    }
                }

                #endregion

                #region Nạp dữ liệu toàn bộ sản phẩm đã crawler vào Dictionary

                var productDataTable = new DB.ProductDataTable();
                Log.InfoFormat("Getting list products... Company: {0}", company.Domain);
                _adtProduct.FillBy_ID_Price_HashName_By_Company(productDataTable, company.ID);
                var oldProducts = productDataTable.ToDictionary(dr => dr.ID, dr => new Product()
                {
                    ID = dr.ID,
                    Price = dr.Price
                });
                var namePriceSet = new HashSet<KeyValuePair<long, long>>();
                productDataTable.Clear();
                productDataTable.Dispose();

                #endregion

                foreach (var product in listProducts)
                {
                    if (newProductsDict.ContainsKey(product.ID))
                        continue;
                    else
                        newProductsDict.Add(product.ID, product);
                }
                Log.InfoFormat("Updating products. Company: {0}", company.Domain);

                //var productIndex = 0;
                var updatedProductCount = 0;
                var productCount = newProductsDict.Count;

                var cancelToken = cancelUpdateDataFeedTokenSource.Token;
                //bool writelog = company.ID == 3502170206813664485;
                //int countwritelog = 1;
                foreach (var product in newProductsDict.Values)
                {
                    if (cancelToken.IsCancellationRequested)
                    {
                        Log.Info("Task canceled");
                        return;
                    }

                    if (UpdateCompanyDataFeedProduct(product, company, ref categoriesSet, ref oldProducts,
                        ref namePriceSet))
                        updatedProductCount++;
                    //Log.InfoFormat("Update {0}/{1} CompanyID = {2}", updatedProductCount, listProducts.Count, company.ID);
                }

                int totaldeleteProduct = 0;
                #region Delete Product UnValid - 17-03-2016
                if (company.CompanyDataFeedType == Entities.Company.DataFeedType.AllProductsFromFile ||
                    company.CompanyDataFeedType == Entities.Company.DataFeedType.AllProductsFromURL || company.Status == Common.CompanyStatus.WEB_BIZWEB || company.Status == Common.CompanyStatus.WEB_HARAVAN)
                {
                    //Riêng lazada.vn không xóa sản phẩm
                    if (company.ID != 3502170206813664485)
                    {
                        foreach (var product in oldProducts.Values)
                        {
                            if (!newProductsDict.ContainsKey(product.ID))
                                DeleteProductUnvalid(product.ID, ref totaldeleteProduct);
                        }
                        Log.InfoFormat("Delete {0} product of company {1}", totaldeleteProduct, company.ID);
                    }
                    else
                    {
                        foreach (var product in oldProducts.Values)
                        {
                            if (!newProductsDict.ContainsKey(product.ID))
                                MakeProductInvalid(product.ID, ref totaldeleteProduct);
                        }
                        Log.InfoFormat("Unvalid {0} product of company {1}", totaldeleteProduct, company.ID);
                    }
                }
                #endregion

                #region Ghi lại lịch sử updateDatafeed
                Log.Info(string.Format("Updated {0}/{1} products. Company:{2}", updatedProductCount, productCount,
                    company.Domain));
                HistoryDatafeedAdapter.InsertHistory(company.ID, company.DataFeedPath, listProducts.Count, updatedProductCount, totaldeleteProduct, "");
                #endregion

                #region Cập nhật thời gian UpdateDatafeed và TotalProduct
                try
                {
                    _adtCompany.UpdateLastUpdateDataFeedAndTotalValidAndTotalProduct(DateTime.Now, company.ID);
                    Log.Info(string.Format("Updated LastUpdate Company:{0}", company.Domain));
                }
                catch (Exception exx)
                {
                    Log.Error("UpdateLastUpdateDataFeed ERROR " + company.ID + "\r\n" + exx);
                }
                #endregion

                #region Cập nhật CategoryID Product
                // cập nhật CategoryID theo IDCategory trong bảng Classification
                try
                {
                    _adtProduct.UpdateCategoryIDProduct(company.ID);
                    Log.Info(string.Format("Updated CategoryID Company:{0}", company.Domain));
                }
                catch (Exception ex)
                {
                    Log.Error("Cập nhật categoryID Product Error \r\n" + ex);
                }
                #endregion

                SendMessageUpdateSolrRedis(company.ID);

                #region Send Message to RabbitMQ download Image
                SendMessageDownloadImage(company.ID);
                #endregion

                _adtProduct.Connection.Close();
                _adtClass.Connection.Close();
                _adtPriceLog.Connection.Close();
                _adtCompany.Connection.Close();
                _adtLogsAddProduct.Connection.Close();
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("Update failed IDCompany = {0}\r\nERROR: {1}", company.ID, ex);
                HistoryDatafeedAdapter.InsertHistory(company.ID, company.DataFeedPath, listProducts.Count, 0, 0, ex.Message + "\n" + ex.ToString());
            }
        }
        public bool SendMessageDownloadImage(long companyID, bool reloadall = false)
        {
            var job = new Job { Data = BitConverter.GetBytes(companyID), Type = (int)TypeJobWithRabbitMQ.Company };
            if (reloadall)
                job.Type = (int)TypeJobWithRabbitMQ.ReloadAll;
            if (_jobClientDownloadImage != null)
            {
                try
                {
                    _jobClientDownloadImage.PublishJob(job, _updateProductToWebJobExpirationMs);
                    Log.InfoFormat("Published Message Company DownloadImage: {0} to RabbitMQServer {1}", companyID, _rabbitMqServerName);
                    return true;
                }
                catch (Exception ex)
                {
                    Log.Error("Publish Message Company DownloadImage job error. Company:" + companyID, ex);
                    return false;
                }
            }
            else
            {
                Log.ErrorFormat("JobClientDownloadImage is null : {0}", companyID);
                return false;
            }
        }

        public bool SendMessageUpdateSolrRedis(long companyId)
        {
            var result = true;
            var job = new Job { Data = BitConverter.GetBytes(companyId) };
            if (_jobClientUpdateProductToWeb != null)
            {
                try
                {
                    _jobClientUpdateProductToWeb.PublishJob(job, _updateProductToWebJobExpirationMs);
                    Log.InfoFormat("Published Update Solr and Redis job for Company: {0} to RabbitMQServer {1}",
                        companyId, _rabbitMqServerName);
                }
                catch (Exception ex)
                {
                    Log.Error("Publish Update Solr and Redis job error. Company:" + companyId, ex);
                    result = false;
                }
            }
            else
            {
                Log.ErrorFormat("JobClientUpdateRedis is null : {0}", companyId);
                result = false;
            }
            return result;
        }
        public void SendMessageToUpdateSingleProductServices(Product product, JobClient updateSingleProductJobClient)
        {
            Job job = new Job();
            job.Data = Product.GetMessage(product);
            while (true)
            {
                try
                {
                    updateSingleProductJobClient.PublishJob(job);
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error("Publish Message update single product error. ProductId: " + product.ID, ex);
                    Thread.Sleep(10000);
                }
            }
        }
        /// <summary>
        /// Update Product
        /// </summary>
        /// <param name="product"></param>
        /// <param name="company"></param>
        /// <param name="categorySet"></param>
        /// <param name="oldProducts"></param>
        /// <param name="namePriceSet"></param>
        /// <returns>True if product is inserted or updated </returns>
        private bool UpdateCompanyDataFeedProduct(Product product, QT.Entities.Company company, ref HashSet<long> categorySet, ref Dictionary<long, Product> oldProducts, ref HashSet<KeyValuePair<long, long>> namePriceSet)
        {
            // check sản phẩm đã có chưa để update
            try
            {
                //Insert category if not exist
                if (!categorySet.Contains(product.IDCategories))
                {
                    categorySet.Add(product.IDCategories);
                    try
                    {
                        _adtClass.Insert(product.IDCategories, Common.ConvertToString(product.Categories, " -> "), company.ID, null, false);
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Insert category error.", ex);
                    }

                }
                var image = product.ImageUrls.Count > 0 ? product.ImageUrls[0] : "";

                if (oldProducts.ContainsKey(product.ID))          // Product exist => Update
                {//update
                    var oldProduct = oldProducts[product.ID];
                    if (product.Price != oldProduct.Price)
                    {
                        // update ngày thay đổi giá và giá tiền
                        if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();
                        _adtProduct.Update_PriceChangeAndValid(
                            product.Name,
                            product.IDCategories,
                            product.Price,
                            product.Warranty,
                            image,
                            company.ID,
                            DateTime.Now,
                            product.DetailUrl,
                            product.Promotion,
                            product.Summary,
                            product.ProductContent,
                            Common.UnicodeToKoDauFulltext(product.Name + " " + product.Domain),
                            true,
                            DateTime.Now,
                            false,
                            oldProduct.Price, product.ShortDescription, product.IsDeal, product.OriginPrice, (int)product.Instock, (short)product.Status, product.VATStatus,
                            product.ID);
                        //Insert Price Log
                        InsertPriceLog(product.ID, DateTime.Now, product.Price, oldProduct.Price);

                    }
                    else
                    {
                        //update ngày cập nhật
                        if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();
                        _adtProduct.Update_LastUpdateAndValid(
                            product.Name,
                            product.IDCategories,
                            product.Price,
                            product.Warranty,
                            image,
                            company.ID,
                            DateTime.Now,
                            product.DetailUrl,
                            product.Promotion,
                            product.Summary,
                            product.ProductContent,
                            Common.UnicodeToKoDauFulltext(product.Name + " " + product.Domain),
                            true,
                            false, product.ShortDescription, product.IsDeal, product.OriginPrice, (int)product.Instock, (short)product.Status, product.VATStatus,
                            product.ID);
                    }
                    return true;
                }

                // Not exist => Insert
                var namePricePair = new KeyValuePair<long, long>(product.HashName, product.Price);
                if (!namePriceSet.Contains(namePricePair))
                {
                    if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();
                    _adtProduct.InsertQuery(
                        product.ID,
                        product.Name,
                        product.IDCategories,
                        product.Price,
                        product.Warranty,
                        (short)product.Status,
                        image,
                        company.ID,
                        DateTime.Now,
                        product.DetailUrl,
                        0,
                        product.Promotion,
                        product.Summary,
                        product.ProductContent,
                        Common.UnicodeToKoDauFulltext(product.Name + " " + product.Domain),
                        true,
                        DateTime.Now,
                        true,
                        product.HashName,
                        0,
                        product.AddPosition, product.VATInfo, product.PromotionInfo
                        , product.DeliveryInfo,
                        product.OriginPrice, product.ShortDescription, product.IsDeal, (int)product.Instock, product.VATStatus
                        );
                    namePriceSet.Add(namePricePair);

                    //Insert Price Log
                    InsertPriceLog(product.ID, DateTime.Now, product.Price, 0);
                    //Insert LogAddsProduct
                    InsertLogAddProduct(company.ID, product.ID, product.Name, product.DetailUrl);
                }
                else //Trùng tên
                {
                    Log.Warn(string.Format("[Trùng tên và giá]: Company: {0} -  Product: {1} - Price: {2}", company.Domain, product.Name, product.Price));
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Error("Company: " + company.Domain + "ProductID = " + product.ID, ex);
                return false;
            }
            return true;
        }

        void InsertPriceLog(long productID, DateTime datePublic, int newsPrice, int oldPrice)
        {
            RedisPriceLogAdapter.PushMerchantProductPrice(productID, newsPrice, datePublic);
            if (_adtPriceLog.Connection.State == ConnectionState.Closed) _adtPriceLog.Connection.Open();
            _adtPriceLog.Insert(
                productID,
                datePublic,
                newsPrice,
                oldPrice);
        }
        void InsertLogAddProduct(long companyID, long productID, string productName, string productDetailUrl)
        {
            if (_adtLogsAddProduct.Connection.State == ConnectionState.Closed) _adtLogsAddProduct.Connection.Open();
            _adtLogsAddProduct.Insert(companyID, productID, productName, productDetailUrl, DateTime.Now);
        }


        void DeleteProductUnvalid(long productId, ref int biendemunvalid)
        {
            if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();
            try
            {
                _adtProduct.DeleteQuery(productId);
                biendemunvalid++;
            }
            catch (Exception ex)
            {
                Log.Error("Delete ERROR with ID = " + productId + "\r\n" + ex);
            }
        }
        void MakeProductInvalid(long productID, ref int biendemunvalid)
        {
            if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();
            try
            {
                _adtProduct.UpdateValidStatus(false, productID);
                biendemunvalid++;
            }
            catch (Exception ex)
            {
                Log.Error("MakeProductInvalid ERROR with ID = " + productID + "\r\n" + ex);
            }
        }
        private DatafeedConfig GetDatafeedConfig(long companyID)
        {
            DatafeedConfig defaultConfig = DatafeedConfig.GetDefaultXMLDatafeedConfig();
            try
            {
                _datafeedConfig = new DBComTableAdapters.DatafeedConfigTableAdapter()
                {
                    Connection = new SqlConnection(Server.ConnectionString)
                };
                _datafeedConfig.Connection.Open();
                var dtDatafeedConfig = new DBCom.DatafeedConfigDataTable();
                _datafeedConfig.FillByCompanyID(dtDatafeedConfig, companyID);

                if (dtDatafeedConfig.Rows.Count > 0)
                {
                    var datafeedConfig = new DatafeedConfig();
                    #region Gán dữ liệu
                    string productlistnode = dtDatafeedConfig.Rows[0]["ProductListNode"].ToString();
                    if (!string.IsNullOrEmpty(productlistnode))
                        datafeedConfig.ProductListNode = productlistnode;
                    else
                        datafeedConfig.ProductListNode = defaultConfig.ProductListNode;

                    string productitemnode = dtDatafeedConfig.Rows[0]["ProductItemNode"].ToString();
                    if (!string.IsNullOrEmpty(productitemnode))
                        datafeedConfig.ProductItemNode = productitemnode;
                    else
                        datafeedConfig.ProductItemNode = defaultConfig.ProductItemNode;

                    string skunode = dtDatafeedConfig.Rows[0]["SkuNode"].ToString();
                    if (!string.IsNullOrEmpty(skunode))
                        datafeedConfig.SkuNode = skunode;
                    else
                        datafeedConfig.SkuNode = defaultConfig.SkuNode;

                    string instockNode = dtDatafeedConfig.Rows[0]["InStockNode"].ToString();
                    if (!string.IsNullOrEmpty(instockNode))
                        datafeedConfig.InstockNode = instockNode;
                    else
                        datafeedConfig.InstockNode = defaultConfig.InstockNode;

                    string brandNode = dtDatafeedConfig.Rows[0]["BrandNode"].ToString();
                    if (!string.IsNullOrEmpty(brandNode))
                        datafeedConfig.BrandNode = brandNode;
                    //else
                    //    datafeedConfig.BrandNode = defaultConfig.BrandNode;

                    string productNameNode = dtDatafeedConfig.Rows[0]["ProductNameNode"].ToString();
                    if (!string.IsNullOrEmpty(productNameNode))
                        datafeedConfig.ProductNameNode = productNameNode;
                    else
                        datafeedConfig.ProductNameNode = defaultConfig.ProductNameNode;

                    string descriptionNode = dtDatafeedConfig.Rows[0]["DescriptionNode"].ToString();
                    if (!string.IsNullOrEmpty(descriptionNode))
                        datafeedConfig.DescriptionNode = descriptionNode;
                    else
                        datafeedConfig.DescriptionNode = defaultConfig.DescriptionNode;

                    string shortdescriptionNode = dtDatafeedConfig.Rows[0]["ShortDescriptionNode"].ToString();
                    if (!string.IsNullOrEmpty(shortdescriptionNode))
                        datafeedConfig.ShortDescriptionNode = shortdescriptionNode;
                    //else
                    //    datafeedConfig.ShortDescriptionNode = defaultConfig.ShortDescriptionNode;

                    string currencyNode = dtDatafeedConfig.Rows[0]["CurrencyNode"].ToString();
                    if (!string.IsNullOrEmpty(currencyNode))
                        datafeedConfig.CurrencyNode = currencyNode;
                    //else
                    //    datafeedConfig.CurrencyNode = defaultConfig.CurrencyNode;

                    string priceNode = dtDatafeedConfig.Rows[0]["PriceNode"].ToString();
                    if (!string.IsNullOrEmpty(priceNode))
                        datafeedConfig.PriceNode = priceNode;
                    else
                        datafeedConfig.PriceNode = defaultConfig.PriceNode;

                    string discountedpriceNode = dtDatafeedConfig.Rows[0]["DiscountedPriceNode"].ToString();
                    if (!string.IsNullOrEmpty(discountedpriceNode))
                        datafeedConfig.DiscountedPriceNode = discountedpriceNode;
                    else
                        datafeedConfig.DiscountedPriceNode = defaultConfig.DiscountedPriceNode;

                    string discountNode = dtDatafeedConfig.Rows[0]["DiscountNode"].ToString();
                    if (!string.IsNullOrEmpty(discountNode))
                        datafeedConfig.DiscountNode = discountNode;
                    else
                        datafeedConfig.DiscountNode = defaultConfig.DiscountNode;

                    int currencyfomat = 0;
                    int.TryParse(dtDatafeedConfig.Rows[0]["CurrencyFormat"].ToString(), out currencyfomat);
                    if (currencyfomat == 0 || currencyfomat > 2)
                    {
                        datafeedConfig.CurrencyFormat = defaultConfig.CurrencyFormat;
                    }
                    else
                        datafeedConfig.CurrencyFormat = (CurrencyFormat)currencyfomat;

                    string category1Node = dtDatafeedConfig.Rows[0]["Category1Node"].ToString();
                    if (!string.IsNullOrEmpty(category1Node))
                        datafeedConfig.Category1Node = category1Node;
                    else
                        datafeedConfig.Category1Node = defaultConfig.Category1Node;

                    string category2Node = dtDatafeedConfig.Rows[0]["Category2Node"].ToString();
                    if (!string.IsNullOrEmpty(category2Node))
                        datafeedConfig.Category2Node = category2Node;
                    else
                        datafeedConfig.Category2Node = defaultConfig.Category2Node;

                    string parentOfCategory1Node = dtDatafeedConfig.Rows[0]["ParentOfCategory1Node"].ToString();
                    if (!string.IsNullOrEmpty(parentOfCategory1Node))
                        datafeedConfig.ParentOfCategory1Node = parentOfCategory1Node;
                    else
                        datafeedConfig.ParentOfCategory1Node = defaultConfig.ParentOfCategory1Node;

                    string parentOfCategory2Node = dtDatafeedConfig.Rows[0]["ParentOfCategory2Node"].ToString();
                    if (!string.IsNullOrEmpty(parentOfCategory2Node))
                        datafeedConfig.ParentOfCategory2Node = parentOfCategory2Node;
                    else
                        datafeedConfig.ParentOfCategory2Node = defaultConfig.ParentOfCategory2Node;

                    string parentOfParentOfCategory1Node = dtDatafeedConfig.Rows[0]["ParentOfParentOfCategory1Node"].ToString();
                    if (!string.IsNullOrEmpty(parentOfParentOfCategory1Node))
                        datafeedConfig.ParentOfParentOfCategory1Node = parentOfParentOfCategory1Node;
                    else
                        datafeedConfig.ParentOfParentOfCategory1Node = defaultConfig.ParentOfParentOfCategory1Node;

                    string parentOfParentOfCategory2Node = dtDatafeedConfig.Rows[0]["ParentOfParentOfCategory2Node"].ToString();
                    if (!string.IsNullOrEmpty(parentOfParentOfCategory2Node))
                        datafeedConfig.ParentOfParentOfCategory2Node = parentOfParentOfCategory2Node;
                    else
                        datafeedConfig.ParentOfParentOfCategory2Node = defaultConfig.ParentOfParentOfCategory2Node;

                    string pictureUrl1Node = dtDatafeedConfig.Rows[0]["PictureUrl1Node"].ToString();
                    if (!string.IsNullOrEmpty(pictureUrl1Node))
                        datafeedConfig.PictureUrl1Node = pictureUrl1Node;
                    else
                        datafeedConfig.PictureUrl1Node = defaultConfig.PictureUrl1Node;

                    string pictureUrl2Node = dtDatafeedConfig.Rows[0]["PictureUrl2Node"].ToString();
                    if (!string.IsNullOrEmpty(pictureUrl2Node))
                        datafeedConfig.PictureUrl2Node = pictureUrl2Node;
                    else
                        datafeedConfig.PictureUrl2Node = defaultConfig.PictureUrl2Node;

                    string pictureUrl3Node = dtDatafeedConfig.Rows[0]["PictureUrl3Node"].ToString();
                    if (!string.IsNullOrEmpty(pictureUrl3Node))
                        datafeedConfig.PictureUrl3Node = pictureUrl3Node;
                    else
                        datafeedConfig.PictureUrl3Node = defaultConfig.PictureUrl3Node;

                    string pictureUrl4Node = dtDatafeedConfig.Rows[0]["PictureUrl4Node"].ToString();
                    if (!string.IsNullOrEmpty(pictureUrl4Node))
                        datafeedConfig.PictureUrl4Node = pictureUrl4Node;
                    else
                        datafeedConfig.PictureUrl4Node = defaultConfig.PictureUrl4Node;

                    string pictureUrl5Node = dtDatafeedConfig.Rows[0]["PictureUrl5Node"].ToString();
                    if (!string.IsNullOrEmpty(pictureUrl5Node))
                        datafeedConfig.PictureUrl5Node = pictureUrl5Node;
                    else
                        datafeedConfig.PictureUrl5Node = defaultConfig.PictureUrl5Node;

                    string urlNode = dtDatafeedConfig.Rows[0]["UrlNode"].ToString();
                    if (!string.IsNullOrEmpty(urlNode))
                        datafeedConfig.UrlNode = urlNode;
                    else
                        datafeedConfig.UrlNode = defaultConfig.UrlNode;

                    string warrantyNode = dtDatafeedConfig.Rows[0]["WarrantyNode"].ToString();
                    if (!string.IsNullOrEmpty(warrantyNode))
                        datafeedConfig.WarrantyNode = warrantyNode;
                    else
                        datafeedConfig.WarrantyNode = defaultConfig.WarrantyNode;
                    string xnamespace = dtDatafeedConfig.Rows[0]["XNameSpace"].ToString();
                    if (!string.IsNullOrEmpty(xnamespace))
                        datafeedConfig.XNameSpace = xnamespace;
                    //else
                    //    datafeedConfig.XNameSpace = string.Empty;

                    string regexConfigUrl = dtDatafeedConfig.Rows[0]["RegexConfigUrl"].ToString();
                    if (!string.IsNullOrEmpty(regexConfigUrl))
                        datafeedConfig.RegexConfigUrl = regexConfigUrl;
                    //else
                    //    datafeedConfig.RegexConfigUrl = string.Empty;
                    string vatstatus = dtDatafeedConfig.Rows[0]["VATStatusNode"].ToString();
                    if (!string.IsNullOrEmpty(vatstatus))
                        datafeedConfig.VATStatus = vatstatus;
                    #endregion
                    _datafeedConfig.Connection.Close();
                    return datafeedConfig;
                }
                else
                {
                    _datafeedConfig.Connection.Close();
                    return defaultConfig;
                }
            }
            catch (Exception)
            {
                return defaultConfig;
            }
        }

        //Read Product List From DataFeed
        public List<Product> ReadDataFeedProductsFromXmlFile(string xmlPath, QT.Entities.Company company, DatafeedConfig datafeedConfig = null)
        {
            var fileStream = new FileStream(xmlPath, FileMode.Open, FileAccess.Read);
            return ExtractDataFeedProducts(fileStream, company, datafeedConfig);
        }

        public List<Product> ReadDataFeedProductsFromUrl(string xmlUrl, QT.Entities.Company company, DatafeedConfig datafeedConfig = null)
        {
            //Log.Info("ReadDataFeedProductsFromUrl");
            using (var webClient = new WebClient())
            {
                if (!string.IsNullOrEmpty(company.UserDatafeed) && !string.IsNullOrEmpty(company.PasswordDatafeed))
                {
                    NetworkCredential myCreds = new NetworkCredential(company.UserDatafeed, company.PasswordDatafeed);
                    webClient.Credentials = myCreds;
                }

                webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36");
                using (var webStream = webClient.OpenRead(new Uri(xmlUrl)))
                {
                    webStream.ReadTimeout = Timeout.Infinite;
                    return ExtractDataFeedProducts(webStream, company, datafeedConfig);
                }
            }
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(xmlUrl);
            //request.MaximumAutomaticRedirections = 4;
            //request.MaximumResponseHeadersLength = 4;
            ////request.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36");
            //request.KeepAlive = true;
            //// Set credentials to use for this request.
            //request.Credentials = CredentialCache.DefaultCredentials;
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //return ExtractDataFeedProducts(response.GetResponseStream(), company, datafeedConfig);
        }

        public List<Product> ExtractDataFeedProducts(Stream xmlStream, QT.Entities.Company company, DatafeedConfig datafeedConfig)
        {
            var result = new List<Product>();
            if (datafeedConfig == null)
                datafeedConfig = GetDatafeedConfig(company.ID);
            var dicProduct = new Dictionary<long, long>();
            var xmlDocument = XDocument.Load(xmlStream);
            try
            {
                var productNodes = xmlDocument.Descendants(datafeedConfig.ProductListNode).Descendants(datafeedConfig.ProductItemNode);
                //int index = 0;
                foreach (var productNode in productNodes)
                {
                    var tmpProduct = new Product { Domain = company.Domain, IDCongTy = company.ID };
                    XNamespace g = "";
                    if (!string.IsNullOrEmpty(datafeedConfig.XNameSpace))
                    {
                        g = datafeedConfig.XNameSpace;
                    }
                    if (!string.IsNullOrEmpty(datafeedConfig.UrlNode))
                    {
                        var urlXElement = productNode.Element(g + datafeedConfig.UrlNode);
                        if (urlXElement == null)
                        {
                            Log.Info(string.Format("Product url Null. Product: {0}", tmpProduct.Name));
                            continue;
                        }
                        else if (!string.IsNullOrEmpty(urlXElement.Value))
                        {
                            tmpProduct.DetailUrl = urlXElement.Value;
                        }
                        else
                            continue;
                    }
                    var decodedUrl = HttpUtility.UrlDecode(tmpProduct.DetailUrl);
                    string originalUrl = string.Empty;
                    if (!string.IsNullOrEmpty(datafeedConfig.RegexConfigUrl))
                    {
                        var originalUrlRegexPattern = new Regex(datafeedConfig.RegexConfigUrl);
                        originalUrl = originalUrlRegexPattern.Match(decodedUrl).Value;
                    }
                    tmpProduct.OriginalUrl = new List<string>();
                    if (!string.IsNullOrEmpty(originalUrl))
                    {
                        tmpProduct.OriginalUrl.Add(originalUrl);
                        tmpProduct.ID = Common.GetIDProduct(originalUrl);
                    }
                    else
                        tmpProduct.ID = Common.GetIDProduct(tmpProduct.DetailUrl);
                    if (!string.IsNullOrEmpty(datafeedConfig.SkuNode))
                    {
                        var skuXElement = productNode.Element(g + datafeedConfig.SkuNode);
                        if (skuXElement != null)
                            tmpProduct.MerchantSku = skuXElement.Value;
                    }
                    if (!string.IsNullOrEmpty(datafeedConfig.InstockNode))
                    {
                        var instockXElement = productNode.Element(g + datafeedConfig.InstockNode);
                        if (instockXElement != null && (instockXElement.Value.ToLower().Trim() == "true" || instockXElement.Value.Trim() == "1" || instockXElement.Value.ToLower().Trim() == "in stock" || instockXElement.Value.ToLower().Trim() == "còn hàng"))
                            tmpProduct.Status = Common.ProductStatus.Available;
                        else if ((instockXElement != null && (instockXElement.Value.Trim() == "2" || instockXElement.Value.ToLower().Trim() == "liên hệ")) || instockXElement == null)//TH không có instock trong datafeed thì để là liên hệ 13.10.2015
                            tmpProduct.Status = Common.ProductStatus.LienHe;
                        else if (instockXElement != null && (instockXElement.Value.ToLower().Trim() == "3" || instockXElement.Value.ToLower().Trim() == "đặt hàng"))
                            tmpProduct.Status = Common.ProductStatus.Order;
                        else
                            tmpProduct.Status = Common.ProductStatus.Clear;
                    }
                    tmpProduct.Instock = Common.GetProductInstockFormStatus(tmpProduct.Status);
                    if (!string.IsNullOrEmpty(datafeedConfig.BrandNode))
                    {
                        var brandXElement = productNode.Element(g + datafeedConfig.BrandNode);
                        if (brandXElement != null)
                            tmpProduct.Manufacture = brandXElement.Value;
                    }

                    if (!string.IsNullOrEmpty(datafeedConfig.ProductNameNode))
                    {
                        var productNameXElement = productNode.Element(g + datafeedConfig.ProductNameNode);
                        if (productNameXElement != null)
                            tmpProduct.Name = productNameXElement.Value;
                    }
                    tmpProduct.HashName = Common.GetHashNameProduct(company.Domain, tmpProduct.Name.Trim());
                    //
                    if (!string.IsNullOrEmpty(datafeedConfig.DescriptionNode))
                    {
                        var descriptionXElement = productNode.Element(g + datafeedConfig.DescriptionNode);
                        if (descriptionXElement != null)
                        {
                            tmpProduct.ProductContent = descriptionXElement.Value;
                        }
                    }

                    if (!string.IsNullOrEmpty(datafeedConfig.ShortDescriptionNode))
                    {
                        var shortdescriptionXElement = productNode.Element(g + datafeedConfig.ShortDescriptionNode);
                        if (shortdescriptionXElement != null)
                        {
                            tmpProduct.ShortDescription = shortdescriptionXElement.Value;
                        }
                    }
                    CultureInfo cultureInfo;
                    if (datafeedConfig.CurrencyFormat == CurrencyFormat.Vietnamese)
                        cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                    else
                        cultureInfo = CultureInfo.GetCultureInfo("en-US");

                    var discountedPriceXElement = productNode.Element(g + datafeedConfig.DiscountedPriceNode);
                    var priceXElement = productNode.Element(g + datafeedConfig.PriceNode);
                    var discountXElement = productNode.Element(g + datafeedConfig.DiscountNode);
                    int discountedPrice = 0;
                    int originPrice = 0;

                    //DiscountedPrice (giá bán)
                    if (discountedPriceXElement != null && !string.IsNullOrEmpty(discountedPriceXElement.Value))
                    {
                        try
                        {
                            discountedPrice = (int)Decimal.Parse(Regex.Replace(discountedPriceXElement.Value.ToLower().Trim(), @"\s*vnd|\s*vnđ|\s*đ", ""), cultureInfo);
                        }
                        catch (Exception)
                        {
                        }
                    }
                    //OriginPrice (giá trước khi giảm)
                    if (priceXElement != null && !string.IsNullOrEmpty(priceXElement.Value))
                    {
                        try
                        {
                            originPrice = (int)Decimal.Parse(Regex.Replace(priceXElement.Value.ToLower().Trim(), @"\s*vnd|\s*vnđ|\s*đ", ""), cultureInfo);
                        }
                        catch (Exception)
                        {
                        }
                    }
                    //
                    if (discountedPrice > 0)
                    {
                        if (originPrice > discountedPrice)
                        {
                            tmpProduct.Price = discountedPrice;
                            tmpProduct.OriginPrice = originPrice;
                            //tmpProduct.IsDeal = true;
                        }
                        else
                        {
                            tmpProduct.Price = tmpProduct.OriginPrice = discountedPrice;
                            //tmpProduct.IsDeal = false;
                        }
                    }
                    //
                    else if (originPrice > 0)
                    {
                        int discountPrice = 0;
                        //DiscountPrice (số tiền giảm)
                        if (discountXElement != null && !string.IsNullOrEmpty(discountXElement.Value))
                        {
                            try
                            {
                                discountPrice = (int)Decimal.Parse(Regex.Replace(discountXElement.Value.ToLower().Trim(), @"\s*vnd|\s*vnđ|\s*đ", ""), cultureInfo);
                            }
                            catch (Exception)
                            {
                            }
                        }
                        if (discountPrice > 0)
                        {
                            tmpProduct.Price = originPrice - discountPrice;
                            tmpProduct.OriginPrice = originPrice;
                            //tmpProduct.IsDeal = true;
                        }
                        else
                        {
                            tmpProduct.Price = tmpProduct.OriginPrice = originPrice;
                            //tmpProduct.IsDeal = false;
                        }
                    }
                    if (tmpProduct.Price <= 0)
                    {
                        Log.Warn(string.Format("Product price equal {0}. Product: ID {1} - {2} - {3}", tmpProduct.Price, tmpProduct.ID, tmpProduct.Name, tmpProduct.DetailUrl));
                        continue;
                    }

                    //Categories 
                    tmpProduct.Categories = new List<string>();
                    tmpProduct.Categories.Add(company.Domain);
                    var parentCategoryXElement = productNode.Element(g + datafeedConfig.ParentOfCategory1Node);
                    if (parentCategoryXElement != null)
                        tmpProduct.Categories.Add(parentCategoryXElement.Value);
                    var categoryXElement = productNode.Element(g + datafeedConfig.Category1Node);
                    if (categoryXElement != null)
                        tmpProduct.Categories.Add(categoryXElement.Value);
                    tmpProduct.IDCategories =
                        Common.GetIDClassification(Common.ConvertToString(tmpProduct.Categories, " -> "));
                    if (!string.IsNullOrEmpty(datafeedConfig.PictureUrl1Node))
                    {
                        var pictureXElement = productNode.Element(g + datafeedConfig.PictureUrl1Node);
                        if (pictureXElement != null)
                            tmpProduct.ImageUrls = new List<string>() { pictureXElement.Value };
                        else
                            tmpProduct.ImageUrls = new List<string>();
                    }
                    if (!string.IsNullOrEmpty(datafeedConfig.WarrantyNode))
                    {
                        var warrantyXElement = productNode.Element(g + datafeedConfig.WarrantyNode);
                        if (warrantyXElement != null)
                        {
                            tmpProduct.Warranty = Common.Obj2Int(warrantyXElement.Value);
                        }
                    }

                    if (!string.IsNullOrEmpty(datafeedConfig.VATStatus))
                    {
                        var vatstatusElement = productNode.Element(g + datafeedConfig.VATStatus);
                        if (vatstatusElement != null)
                        {
                            if (vatstatusElement.Value.ToLower().Trim() == "true" ||
                                vatstatusElement.Value.Trim() == "1" ||
                                vatstatusElement.Value.ToLower().Trim() == "đã có vat")
                                tmpProduct.VATStatus = Common.VATStatus.HaveVAT;
                            else if (vatstatusElement.Value.ToLower().Trim() == "false" ||
                                     vatstatusElement.Value.Trim() == "0" ||
                                     vatstatusElement.Value.ToLower().Trim() == "không có vat" ||
                                     vatstatusElement.Value.ToLower().Trim() == "chưa có vat")
                            {
                                tmpProduct.VATStatus = Common.VATStatus.NotVAT;
                            }
                            else
                                tmpProduct.VATStatus = Common.VATStatus.UndefinedVAT;
                        }
                        else
                            tmpProduct.VATStatus = Common.VATStatus.UndefinedVAT;
                    }
                    else
                        tmpProduct.VATStatus = Common.VATStatus.UndefinedVAT;

                    //Check Trùng sản phẩm
                    long hashchecktrung = 0;
                    if (tmpProduct.ImageUrls.Count > 0)
                        hashchecktrung = Product.GetHashDuplicate(company.Domain, tmpProduct.Price, tmpProduct.Name, tmpProduct.ImageUrls[0]);
                    else
                        hashchecktrung = Product.GetHashDuplicate(company.Domain, tmpProduct.Price, tmpProduct.Name, "");
                    if (dicProduct.ContainsKey(hashchecktrung))
                    {
                        Log.Info(string.Format("Trung SP. Product: {0}", tmpProduct.Name)); continue;
                    }
                    else
                    {
                        try
                        {
                            dicProduct.Add(hashchecktrung, tmpProduct.ID);
                            result.Add(tmpProduct);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("Error Company : {0}", company.Domain), ex);
                throw;
            }
        }

        public List<Product> ReadDataFeedProductsFromCsvFile(string csvPath, QT.Entities.Company company, DatafeedConfig datafeedConfig = null)
        {
            //string line = string.Empty;
            //char[] charSeparators = new char[] { ',','"' };
            if (datafeedConfig == null)
                datafeedConfig = GetDatafeedConfig(company.ID);
            var result = new List<Product>();
            var dtProduct = Common.GetDataTableFromCSVFileUsingOLEDB(csvPath, "YES");
            for (int i = 0; i < dtProduct.Rows.Count; i++)
            {
                try
                {
                    var tmpProduct = new Product { Domain = company.Domain, IDCongTy = company.ID };

                    #region Name
                    if (!string.IsNullOrEmpty(datafeedConfig.ProductNameNode))
                    {
                        try
                        {
                            var productName = dtProduct.Rows[i][datafeedConfig.ProductNameNode].ToString();
                            if (!string.IsNullOrEmpty(productName))
                                tmpProduct.Name = productName;
                            else
                            {
                                Log.Warn(string.Format("ProductName is Null. Rows i = {0}", i));
                                continue;
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        Log.Warn(string.Format("DatafeedConfig null. ProductNameNode = {0}", datafeedConfig.ProductNameNode));
                        continue;
                    }
                    #endregion

                    #region Url
                    if (!string.IsNullOrEmpty(datafeedConfig.UrlNode))
                    {
                        try
                        {
                            var url = dtProduct.Rows[i][datafeedConfig.UrlNode].ToString();
                            if (!string.IsNullOrEmpty(url))
                                tmpProduct.DetailUrl = url;
                            else
                            {
                                Log.Warn(string.Format("Url is Null. ProductName = {0}", tmpProduct.Name));
                                continue;
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        Log.Warn(string.Format("DatafeedConfig null. UrlNode = {0}", datafeedConfig.UrlNode));
                        continue;
                    }
                    #endregion

                    #region ID
                    var decodedUrl = HttpUtility.UrlDecode(tmpProduct.DetailUrl);
                    if (company.ID == 3502170206813664485)
                    {
                        decodedUrl = HttpUtility.UrlDecode(decodedUrl);
                    }
                    
                    string originalUrl = string.Empty;
                    if (!string.IsNullOrEmpty(datafeedConfig.RegexConfigUrl))
                    {
                        var originalUrlRegexPattern = new Regex(datafeedConfig.RegexConfigUrl);
                        originalUrl = originalUrlRegexPattern.Match(decodedUrl).Value;
                    }
                    tmpProduct.OriginalUrl = new List<string>();
                    if (!string.IsNullOrEmpty(originalUrl))
                    {
                        tmpProduct.OriginalUrl.Add(originalUrl);
                    }
                    tmpProduct.ID = Common.GetIDProduct(string.IsNullOrEmpty(originalUrl) ? tmpProduct.DetailUrl : originalUrl);
                    #endregion

                    #region Sku
                    if (!string.IsNullOrEmpty(datafeedConfig.SkuNode))
                    {
                        try
                        {
                            var sku = dtProduct.Rows[i][datafeedConfig.SkuNode].ToString();
                            if (!string.IsNullOrEmpty(sku))
                                tmpProduct.MerchantSku = sku;
                        }
                        catch (Exception)
                        {
                        }
                    }
                    else
                        Log.Warn(string.Format("DatafeedConfig null. SkuNode = {0}. Product: {1} : ID = {2}", datafeedConfig.SkuNode, tmpProduct.Name, tmpProduct.ID));
                    #endregion
                    //Mặc định trạng thái sản phẩm là Available
                    tmpProduct.Status = Common.ProductStatus.Available;
                    tmpProduct.Instock = Common.GetProductInstockFormStatus(tmpProduct.Status);
                    #region Brand
                    if (!string.IsNullOrEmpty(datafeedConfig.BrandNode))
                    {
                        try
                        {
                            var brand = dtProduct.Rows[i][datafeedConfig.BrandNode].ToString();
                            if (!string.IsNullOrEmpty(brand))
                                tmpProduct.Manufacture = brand;
                        }
                        catch (Exception)
                        {
                        }
                    }
                    //else
                    //    Log.Warn(string.Format("DatafeedConfig null. BrandNode = {0}. Product: {1} : ID = {2}", datafeedConfig.BrandNode, tmpProduct.Name, tmpProduct.ID));
                    #endregion
                    tmpProduct.HashName = Common.GetHashNameProduct(company.Domain, tmpProduct.Name.Trim());

                    #region Description
                    if (!string.IsNullOrEmpty(datafeedConfig.DescriptionNode))
                    {
                        try
                        {
                            var description = dtProduct.Rows[i][datafeedConfig.DescriptionNode].ToString();
                            if (!string.IsNullOrEmpty(description))
                                tmpProduct.ProductContent = description;
                        }
                        catch (Exception)
                        { }
                    }
                    else
                        Log.Warn(string.Format("DatafeedConfig null. DescriptionNode = {0} Product = {1}. ID: {2}", datafeedConfig.DescriptionNode, tmpProduct.Name, tmpProduct.ID));
                    #endregion

                    #region Price
                    CultureInfo cultureInfo;
                    if (datafeedConfig.CurrencyFormat == CurrencyFormat.Vietnamese)
                        cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                    else
                        cultureInfo = CultureInfo.GetCultureInfo("en-US");

                    int discountedPrice = 0;
                    int originPrice = 0;

                    //DiscountedPrice (giá bán)
                    try
                    {
                        discountedPrice = (int)Decimal.Parse(Regex.Replace(dtProduct.Rows[i][datafeedConfig.DiscountedPriceNode].ToString().ToLower().Trim(), @"\s*vnd|\s*vnđ|\s*đ", ""), cultureInfo);
                    }
                    catch (Exception)
                    {
                    }

                    try
                    {
                        originPrice = (int)Decimal.Parse(Regex.Replace(dtProduct.Rows[i][datafeedConfig.PriceNode].ToString().ToLower().Trim(), @"\s*vnd|\s*vnđ|\s*đ", ""), cultureInfo);
                    }
                    catch (Exception)
                    {
                    }
                    //
                    if (discountedPrice > 0)
                    {
                        if (originPrice > discountedPrice)
                        {
                            tmpProduct.Price = discountedPrice;
                            tmpProduct.OriginPrice = originPrice;
                            //tmpProduct.IsDeal = true;
                        }
                        else
                        {
                            tmpProduct.Price = tmpProduct.OriginPrice = discountedPrice;
                            //tmpProduct.IsDeal = false;
                        }
                    }
                    //
                    else if (originPrice > 0)
                    {
                        int discountPrice = 0;
                        //DiscountPrice (số tiền giảm)
                        try
                        {
                            discountPrice = (int)Decimal.Parse(Regex.Replace(dtProduct.Rows[i][datafeedConfig.DiscountNode].ToString().ToLower().Trim(), @"\s*vnd|\s*vnđ|\s*đ", ""), cultureInfo);
                        }
                        catch (Exception)
                        {
                        }
                        if (discountPrice > 0)
                        {
                            tmpProduct.Price = originPrice - discountPrice;
                            tmpProduct.OriginPrice = originPrice;
                            //tmpProduct.IsDeal = true;
                        }
                        else
                        {
                            tmpProduct.Price = tmpProduct.OriginPrice = originPrice;
                            //tmpProduct.IsDeal = false;
                        }
                    }
                    #endregion
                    if (tmpProduct.Price <= 0)
                    {
                        Log.Warn(string.Format("Product price equal {0}. Product: ID {1} - {2}", tmpProduct.Price, tmpProduct.ID, tmpProduct.Name));
                        continue;
                    }

                    #region Categories

                    tmpProduct.Categories = new List<string> { company.Domain };
                    if (!string.IsNullOrEmpty(datafeedConfig.Category1Node))
                    {
                        try
                        {
                            var category = dtProduct.Rows[i][datafeedConfig.Category1Node].ToString();
                            if (!string.IsNullOrEmpty(category))
                                tmpProduct.Categories.Add(category);
                        }
                        catch (Exception)
                        {
                        }
                    }
                    else
                        Log.Warn(string.Format("DatafeedConfig null. Category1Node = {0} . Product: {1}  ID = {2}", datafeedConfig.Category1Node, tmpProduct.Name, tmpProduct.ID));
                    if (!string.IsNullOrEmpty(datafeedConfig.ParentOfCategory1Node))
                    {
                        try
                        {
                            var parentCategory = dtProduct.Rows[i][datafeedConfig.ParentOfCategory1Node].ToString();
                            if (!string.IsNullOrEmpty(parentCategory))
                                tmpProduct.Categories.Add(parentCategory);
                        }
                        catch (Exception)
                        {
                        }
                    }
                    //else
                    //    Log.Warn(string.Format("DatafeedConfig null. ParentCategory1Node = {0} . Product: {1}  ID = {2}", datafeedConfig.Category1Node, tmpProduct.Name, tmpProduct.ID));
                    tmpProduct.IDCategories = Common.GetIDClassification(Common.ConvertToString(tmpProduct.Categories, " -> "));
                    #endregion

                    #region Picture
                    if (!string.IsNullOrEmpty(datafeedConfig.PictureUrl1Node))
                    {
                        try
                        {
                            var picture = dtProduct.Rows[i][datafeedConfig.PictureUrl1Node].ToString();
                            if (!string.IsNullOrEmpty(picture))
                                tmpProduct.ImageUrls = new List<string>() { picture };
                        }
                        catch (Exception)
                        {
                        }
                    }
                    else
                        Log.Warn(string.Format("DatafeedConfig null. PictureUrl1Node = {0}. Product: {1}  ID = {2}", datafeedConfig.PictureUrl1Node, tmpProduct.Name, tmpProduct.ID));
                    #endregion

                    tmpProduct.VATStatus = 1;
                    result.Add(tmpProduct);
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("Error i = {0}", i), ex);
                }
            }
            return result;
        }

        public List<Product> ReadDatafeedProductsFromJsonOfMasOffer(string datafeedUrl, Entities.Company company)
        {
            var datafeedConfig = GetDatafeedConfig(company.ID);
            var result = new List<Product>();
            var jsonMassOfferInfo = string.Empty;
            try
            {
                using (var wc = new WebClient())
                {
                    wc.Headers.Add("user-agent",
                        "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36");
                    jsonMassOfferInfo = wc.DownloadString(datafeedUrl);
                }
            }
            catch (Exception exception)
            {
                Log.Error(exception);
            }
            if (!string.IsNullOrEmpty(jsonMassOfferInfo))
            {
                var masOfferInfo = JsonConvert.DeserializeObject<MasOfferInfo>(jsonMassOfferInfo);
                var totalPage = masOfferInfo.totalPage;
                var jsonDataProduct = masOfferInfo.data;
                if (!string.IsNullOrEmpty(jsonDataProduct))
                {
                    var listProductMasOffers = JsonConvert.DeserializeObject<List<ProductMasOffer>>(jsonDataProduct);
                    result.AddRange(ConvertProductMasOfferToProductWebsosanh(listProductMasOffers, company, datafeedConfig));
                    #region Load next page
                    // bỏ qua trang 1 vì trang 1 đã load ở trên rồi
                    for (int i = 2; i <= totalPage; i++)
                    {
                        var datafeedUrlnextpage = datafeedUrl + "&page=" + i;
                        var jsonMassOfferInfoPage = string.Empty;
                        try
                        {
                            using (var wc = new WebClient())
                            {
                                wc.Headers.Add("user-agent",
                                    "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36");
                                jsonMassOfferInfoPage = wc.DownloadString(datafeedUrlnextpage);
                            }
                        }
                        catch (Exception exception)
                        {
                            Log.Error(exception);
                        }
                        if (!string.IsNullOrEmpty(jsonMassOfferInfoPage))
                        {
                            var masOfferInfoNextPage = JsonConvert.DeserializeObject<MasOfferInfo>(jsonMassOfferInfoPage);
                            var jsonDataProductNextPage = masOfferInfoNextPage.data;
                            if (!string.IsNullOrEmpty(jsonDataProductNextPage))
                            {
                                var listProductMasOffersNextPage =
                                    JsonConvert.DeserializeObject<List<ProductMasOffer>>(jsonDataProductNextPage);
                                result.AddRange(ConvertProductMasOfferToProductWebsosanh(listProductMasOffersNextPage,
                                    company, datafeedConfig));
                            }
                        }
                        else
                            Log.Error(string.Format("Page {2} data empty!!! Company: {0} . DataFeedUrl: {1}", company.ID,
                                datafeedUrl, i));
                    }
                    #endregion
                }
            }
            else
                Log.Error(string.Format("Page 1 data empty!!! Company: {0} . DataFeedUrl: {1} ", company.ID, datafeedUrl));
            return result;
        }

        public List<Product> ConvertProductMasOfferToProductWebsosanh(List<ProductMasOffer> listProductMasOffers, Entities.Company company, DatafeedConfig datafeedConfig = null)
        {
            var result = new List<Product>();
            foreach (var item in listProductMasOffers)
            {
                var originalUrl = item.product_url;
                var tmpProduct = new Product
                {
                    Domain = company.Domain,
                    IDCongTy = company.ID,
                    DetailUrl = item.affiliate_url,
                    MerchantSku = item.product_sku,
                    Name = item.product_name,
                    OriginPrice = (int)item.product_price,
                    Price = (int)item.product_sale_price,
                    ImageUrls = item.product_image_urls,
                    Categories = new List<string>() { company.Domain },
                    OriginalUrl = new List<string> { originalUrl }
                };
                tmpProduct.ID = Common.GetIDProduct(string.IsNullOrEmpty(originalUrl) ? tmpProduct.DetailUrl : originalUrl);
                tmpProduct.Status = item.product_inventory_quantity > 0 ? Common.ProductStatus.Available : Common.ProductStatus.Clear;
                tmpProduct.Instock = Common.GetProductInstockFormStatus(tmpProduct.Status);
                tmpProduct.HashName = Common.GetHashNameProduct(company.Domain, tmpProduct.Name.Trim());
                tmpProduct.Categories.Add(item.product_category);
                tmpProduct.IDCategories = Common.GetIDClassification(Common.ConvertToString(tmpProduct.Categories, " -> "));
                tmpProduct.VATStatus = 1;
                result.Add(tmpProduct);
            }
            return result;
        }

        public List<Product> ReadDataFeedProductsFromJSONFile(string jsonPath, QT.Entities.Company company, DatafeedConfig datafeedConfig = null)
        {
            if (datafeedConfig == null)
            {
                datafeedConfig = GetDatafeedConfig(company.ID);
            }
            //list Product websosanh
            var result = new List<Product>();
            //list Product Concung
            var listProductConCung = new List<ProductConCung>();
            //using (var decompress = new GZipStream(File.OpenRead(gzPath), CompressionMode.Decompress))
            Stream stream = File.OpenRead(jsonPath);
            using (var sr = new StreamReader(stream))
            {
                string res = sr.ReadToEnd();
                listProductConCung = JsonConvert.DeserializeObject<List<ProductConCung>>(res);
            }
            #region Chuyển từ ListProductConCung sang ListProduct websosanh
            for (int i = 0; i < listProductConCung.Count; i++)
            {
                var tmpProduct = new Product
                {
                    Domain = company.Domain,
                    IDCongTy = company.ID,
                    DetailUrl = listProductConCung[i].ProductUrl,
                    MerchantSku = listProductConCung[i].reference,
                    Manufacture = listProductConCung[i].ThuongHieu,
                    Name = listProductConCung[i].TenSanPham,
                    ProductContent = listProductConCung[i].Mota
                };
                tmpProduct.ID = Common.GetIDProduct(tmpProduct.DetailUrl);
                // [CuaHang]: mảng string (gồm danh sách các [name] - Tên địa chỉ các siêu thị concung.com đang có hàng)
                // Check nếu Cuahang.Count > 0  là còn hàng
                // Cuahang.Count <= 0 là hết hàng
                if (listProductConCung[i].CuaHang.Count > 0)
                    tmpProduct.Status = Common.ProductStatus.Available;
                else tmpProduct.Status = Common.ProductStatus.Clear;
                tmpProduct.Instock = Common.GetProductInstockFormStatus(tmpProduct.Status);

                tmpProduct.HashName = Common.GetHashNameProduct(company.Domain, tmpProduct.Name.Trim());

                CultureInfo cultureInfo;
                if (datafeedConfig.CurrencyFormat == CurrencyFormat.Vietnamese)
                    cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                else
                    cultureInfo = CultureInfo.GetCultureInfo("en-US");
                int gianiemyet = 0;
                int giaban = 0;
                try
                {
                    gianiemyet = (int)Decimal.Parse(listProductConCung[i].GiaNiemYet, cultureInfo);
                    giaban = (int)Decimal.Parse(listProductConCung[i].GiaBan, cultureInfo);
                }
                catch (Exception)
                {
                }
                if (giaban > 0)
                {
                    if (gianiemyet > giaban)
                    {
                        tmpProduct.Price = giaban;
                        tmpProduct.OriginPrice = gianiemyet;
                    }
                    else
                    {
                        tmpProduct.Price = tmpProduct.OriginPrice = giaban;
                    }
                }
                if (tmpProduct.Price <= 0)
                {
                    Log.Warn(string.Format("Product price equal {0}. Product: ID {1} - {2}", tmpProduct.Price, tmpProduct.ID, tmpProduct.Name));
                    continue;
                }
                //Categories 
                tmpProduct.Categories = new List<string>();
                tmpProduct.Categories.Add(company.Domain);
                if (listProductConCung[i].Category != null)
                {
                    tmpProduct.Categories.Add(listProductConCung[i].Category[0]);
                }
                //tmpProduct.Categories.AddRange(listProductConCung[i].Category);

                tmpProduct.IDCategories = Common.GetIDClassification(Common.ConvertToString(tmpProduct.Categories, " -> "));

                tmpProduct.ImageUrls = string.IsNullOrEmpty(listProductConCung[i].image_default) ? new List<string>() : new List<string>() { listProductConCung[i].image_default };
                tmpProduct.VATStatus = 1;
                result.Add(tmpProduct);
            }
            #endregion
            return result;
        }



    }
}
