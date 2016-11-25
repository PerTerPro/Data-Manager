using log4net;
using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QT.Entities.Datafeed;
using QT.Entities.Images;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.Products.UpdateSingleProductServices
{
    public partial class UpdateSingleProductService : ServiceBase
    {
        private Worker[] _workers;
        private string _connectionString = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
        private string _logConnectionString = "Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
        private static readonly ILog Log = LogManager.GetLogger(typeof(UpdateSingleProductService));
        RabbitMQServer _rabbitMqServer;
        string _rabbitMqServerName = "";
        private int _isPromotion;
        private bool _isPriceBySku;
        private bool _isRunning = true;
        int _workerCount;
        private Dictionary<string, int> _priceWithSku;
        private Dictionary<string, string> _promotionLazadaWithCategory;
        private Dictionary<string, string> _promotionLazadaWithSku;
        public UpdateSingleProductService()
        {
            InitializeComponent();
            LoadConfig();
            LoadPriceWithSkuLazada();
            LoadPromotionLazada();
            //OnStart(new string[] { });
        }

        private void LoadConfig()
        {
            _connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
            _logConnectionString = ConfigurationSettings.AppSettings["LogConnectionString"];
            _rabbitMqServerName = ConfigurationSettings.AppSettings["rabbitMQServerName"];
            _workerCount = Common.Obj2Int(ConfigurationSettings.AppSettings["workerCount"]);
            _isPromotion = Common.Obj2Int(ConfigurationSettings.AppSettings["IsPromotion"]);
            _isPriceBySku = Common.Obj2Bool(ConfigurationSettings.AppSettings["isPriceBySku"]);
        }
        private void LoadPromotionLazada()
        {
            _promotionLazadaWithCategory = new Dictionary<string, string>();
            _promotionLazadaWithSku = new Dictionary<string, string>();
            string line;
            try
            {
                string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string txtLocation = "";
                switch (_isPromotion)
                {
                    //Promotion theo Category
                    case 1:
                        txtLocation = Path.Combine(executableLocation, "PromotionLazadaByCat.txt");
                        break;
                    //Promotion theo Sku
                    case 2:
                        txtLocation = Path.Combine(executableLocation, "PromotionLazadaBySku.txt");
                        break;
                }
                System.IO.StreamReader file =
                    new System.IO.StreamReader(txtLocation);
                while ((line = file.ReadLine()) != null)
                {
                    var promotion = line.Split('|');
                    try
                    {
                        switch (_isPromotion)
                        {
                            //Promotion theo Category
                            case 1:
                                _promotionLazadaWithCategory.Add(promotion[0], promotion[1]);
                                break;
                            //Promotion theo Sku
                            case 2:
                                _promotionLazadaWithSku.Add(promotion[0], promotion[1]);
                                break;
                        }

                    }
                    catch (Exception exception)
                    {
                        Log.Error("Promotion Error add to dict: " + exception.Message);
                    }
                }
                file.Close();
            }
            catch (Exception exception)
            {
                Log.Error("Error read file: " + exception.Message);
            }
        }
        private void LoadPriceWithSkuLazada()
        {
            _priceWithSku = new Dictionary<string, int>();
            try
            {
                var executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var txtLocation = Path.Combine(executableLocation, "ListPriceWithSkuLazada.txt");
                var file = new StreamReader(txtLocation);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var price = line.Split('|');
                    try
                    {
                        _priceWithSku.Add(price[0], Common.Obj2Int(price[1]));
                    }
                    catch (Exception exception)
                    {
                        Log.Error("Error add price with sku to dict: " + exception.Message);
                    }
                }
                file.Close();
            }
            catch (Exception exception)
            {
                Log.Error(exception.Message);
            }

        }
        protected override void OnStart(string[] args)
        {
            _workers = new Worker[_workerCount];
            _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(_rabbitMqServerName);

            for (var i = 0; i < _workerCount; i++)
            {
                var worker = new Worker(ConfigRabbitMqDatafeed.QueueUpdateSingleProduct, false, _rabbitMqServer);
                _workers[i] = worker;
                var workerTask = new Task(() =>
                {
                    //Jobclient update redis & solr
                    var updateProductJobClient = new JobClient(ConfigRabbitMqCacheSolrAndRedis.ExchangeProduct, GroupType.Topic, ConfigRabbitMqCacheSolrAndRedis.RoutingKeyUpdateSolrAndRedis, true, _rabbitMqServer);
                    //JobClient download image
                    var downloadImageProductJobClient = new JobClient(ConfigImages.ExchangeImages, GroupType.Topic, ConfigImages.RoutingKeyChangeImageProduct, true, _rabbitMqServer);
                    worker.JobHandler = (updateProductJob) =>
                    {
                        try
                        {
                            var product = Product.GetDataFromMessage(updateProductJob.Data);
                            if (product.ID != 0)
                                UpdateSingleProduct(product, updateProductJobClient, downloadImageProductJobClient);
                            else
                                Log.Error("Get ID from Message fails. ProductID = 0");
                        }
                        catch (Exception ex)
                        {
                            Log.Error("Execute Job Error.", ex);
                        }
                        return true;
                    };
                    worker.Start();
                });
                workerTask.Start();
                Log.InfoFormat("Worker {0} started", i);
            }
        }

        private void UpdateSingleProduct(Product product, JobClient updateProductJobClient, JobClient downloadImageProductJobClient)
        {
            #region Check Price

            if (_isPriceBySku)
            {
                if (_priceWithSku.ContainsKey(product.MerchantSku))
                {
                    product.Price = _priceWithSku[product.MerchantSku];
                }
            }
            #endregion
            #region Check Promotion
            switch (_isPromotion)
            {
                //Không có Promotion
                case 0:
                    product.PromotionInfo = "";
                    break;
                //Promotion theo Category
                case 1:
                    try
                    {
                        product.PromotionInfo = _promotionLazadaWithCategory.ContainsKey(product.Categories[1]) ? _promotionLazadaWithCategory[product.Categories[1]] : _promotionLazadaWithCategory["Default"];
                    }
                    catch (Exception exception)
                    {
                        Log.Error("Error check contain key " + exception.Message);
                    }
                    break;
                //Promotion theo SKU
                case 2:
                    try
                    {
                        if (_promotionLazadaWithSku.ContainsKey(product.MerchantSku))
                        {
                            product.PromotionInfo = _promotionLazadaWithSku[product.MerchantSku];
                            Log.Info("Promotion: " + product.ID + " --- " + _promotionLazadaWithSku[product.MerchantSku]);
                        }
                        else
                            product.PromotionInfo = "";
                    }
                    catch (Exception exception)
                    {
                        Log.Error("Error check contain key " + exception.Message);
                    }
                    break;
            }
            #endregion
            var productAdapter = new DBProductsTableAdapters.ProductTableAdapter();
            productAdapter.Connection.ConnectionString = _connectionString;
            var productTable = new DBProducts.ProductDataTable();
            while (_isRunning)
            {
                try
                {
                    productAdapter.FillBy_ID(productTable, product.ID);
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("ProductId {0} : Fill by ID error.", product.ID), ex);
                    Thread.Sleep(60000);
                }
            }
            //InsertProduct
            if (productTable.Rows.Count == 0)
            {
                CheckClassificationInSql(product);
                InsertProductToSql(product, productAdapter);

                //Insert Price Log
                InsertPriceLog(product.ID, DateTime.Now, product.Price, 0);
                //Insert LogAddsProduct
                InsertLogAddProduct(product.IDCongTy, product.ID, product.Name, product.DetailUrl);

                SendMessageDownloadImageProduct(product, downloadImageProductJobClient, true);
                Log.Info(string.Format("CompanyId = {0} :Insert ProductId = {1} . Name = {2} . DetailUrl = {3}", product.IDCongTy, product.ID, product.Name, product.DetailUrl));
            }
            else //UpdateProduct
            {
                var oldPrice = Common.Obj2Int(productTable.Rows[0]["Price"].ToString());
                if (product.Price != oldPrice)
                {
                    UpdateProductPriceChangeAndValid(product, productAdapter, oldPrice);
                    //Insert Price Log
                    InsertPriceLog(product.ID, DateTime.Now, product.Price, oldPrice);
                }
                else
                    UpdateProductLastUpdateAndValid(product, productAdapter);
                if (productTable.Rows[0]["ImagePath"] == DBNull.Value || string.IsNullOrEmpty(productTable.Rows[0]["ImagePath"].ToString()))
                    SendMessageDownloadImageProduct(product, downloadImageProductJobClient, false);
                Log.Info(string.Format("CompanyId = {0} :Update ProductId = {1} . Name = {2} . DetailUrl = {3}", product.IDCongTy, product.ID, product.Name, product.DetailUrl));

            }
            productAdapter.Connection.Close();
            var hashProductInfo = ProductEntity.GetHashChangeInfo((int)product.Instock, true, product.Price, product.Name, product.ImageUrl,
                product.IDCategories, product.ShortDescription, product.OriginPrice);
            if (RedisCacheProductDatafeed.CheckChangeInfoProduct(product.ID, hashProductInfo))
                SendMessageUpdateProductSolrAndRedisService(product, updateProductJobClient);
        }

        private void SendMessageDownloadImageProduct(Product product, JobClient downloadImageProductJobClient, bool isNews)
        {
            var imageProductInfo = new ImageProductInfo(product.ID, product.Name, product.DetailUrl, product.ImageUrl, isNews);
            var job = new Job { Data = ImageProductInfo.GetMessage(imageProductInfo) };
            while (_isRunning)
            {
                try
                {
                    downloadImageProductJobClient.PublishJob(job);
                    Log.Info(string.Format("Resend to services download image productid {0}", imageProductInfo.Id));
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("ProductId = {0} resend message to service downloadimageproduct.", imageProductInfo.Id), ex);
                    Thread.Sleep(120000);
                }
            }
        }

        private void SendMessageUpdateProductSolrAndRedisService(Product product, JobClient updateProductJobClient)
        {
            var job = new Job { Data = BitConverter.GetBytes(product.ID), Type = 2 };
            while (_isRunning)
            {
                try
                {
                    updateProductJobClient.PublishJob(job);
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("Publish Message update solr and redis product error. ProductId: {0}", product.ID), ex);
                    Thread.Sleep(10000);
                }
            }
        }

        private void InsertProductToSql(Product product, DBProductsTableAdapters.ProductTableAdapter productAdapter)
        {
            while (_isRunning)
            {
                try
                {
                    productAdapter.InsertProduct(
                    product.ID,
                    product.Name,
                    product.IDCategories,
                    product.Price,
                    product.Warranty,
                    (short)product.Status,
                    product.ImageUrl,
                    product.IDCongTy,
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
                    product.AddPosition,
                    product.VATInfo,
                    product.PromotionInfo,
                    product.DeliveryInfo,
                    product.OriginPrice,
                    product.ShortDescription,
                    product.IsDeal,
                    (int)product.Instock);
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("ProductId {0} : Insert error.", product.ID), ex);
                    Thread.Sleep(60000);
                }
            }
        }

        private void UpdateProductLastUpdateAndValid(Product product, DBProductsTableAdapters.ProductTableAdapter productAdapter)
        {
            while (_isRunning)
            {
                try
                {
                    if (productAdapter.Connection.State == ConnectionState.Closed) productAdapter.Connection.Open();
                    productAdapter.UpdateLastUpdateAndValid(
                        product.Name,
                        product.IDCategories,
                        product.Price,
                        product.Warranty,
                        product.ImageUrl,
                        product.IDCongTy,
                        DateTime.Now,
                        product.DetailUrl,
                        product.Promotion,
                        product.Summary,
                        product.ProductContent,
                        Common.UnicodeToKoDauFulltext(product.Name + " " + product.Domain),
                        true,
                        false, product.ShortDescription, product.IsDeal, product.OriginPrice, (int)product.Instock, (short)product.Status, product.PromotionInfo,
                        product.ID);
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("ProductId {0} : Update LastUpdate And Valid error.", product.ID), ex);
                    Thread.Sleep(60000);
                }
            }
        }

        private void UpdateProductPriceChangeAndValid(Product product, DBProductsTableAdapters.ProductTableAdapter productAdapter, int oldPrice)
        {
            while (_isRunning)
            {
                try
                {
                    if (productAdapter.Connection.State == ConnectionState.Closed) productAdapter.Connection.Open();
                    productAdapter.UpdatePriceChangeAndValid(
                        product.Name,
                        product.IDCategories,
                        product.Price,
                        product.Warranty,
                        product.ImageUrl,
                        product.IDCongTy,
                        DateTime.Now,
                        product.DetailUrl,
                        product.Promotion,
                        product.Summary,
                        product.ProductContent,
                        Common.UnicodeToKoDauFulltext(product.Name + " " + product.Domain),
                        true,
                        DateTime.Now,
                        false,
                        oldPrice, product.ShortDescription, product.IsDeal, product.OriginPrice, (int)product.Instock, (short)product.Status, product.PromotionInfo,
                        product.ID);
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("ProductId {0} : Insert error.", product.ID), ex);
                    Thread.Sleep(60000);
                }
            }
        }

        private void InsertLogAddProduct(long companyId, long productId, string productName, string productDetailUrl)
        {
            var logAddProductAdapter = new DBLogProductTableAdapters.Product_LogsAddProductTableAdapter();
            logAddProductAdapter.Connection.ConnectionString = _logConnectionString;
            while (_isRunning)
            {
                try
                {
                    logAddProductAdapter.Insert(companyId, productId, productName, productDetailUrl, DateTime.Now);
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("ProductId {0} : Insert price log error.", productId), ex);
                    Thread.Sleep(60000);
                }
            }
            logAddProductAdapter.Connection.Close();
        }

        private void InsertPriceLog(long productId, DateTime datePublic, int newsPrice, int oldPrice)
        {
            //RedisPriceLogAdapter.PushMerchantProductPrice(productID, newsPrice, datePublic);
            var priceLogAdapter = new DBLogProductTableAdapters.Price_LogsTableAdapter();
            priceLogAdapter.Connection.ConnectionString = _logConnectionString;
            while (_isRunning)
            {
                try
                {
                    if (priceLogAdapter.Connection.State == ConnectionState.Closed) priceLogAdapter.Connection.Open();
                    priceLogAdapter.Insert(
                        productId,
                        datePublic,
                        newsPrice,
                        oldPrice);
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("ProductId {0} : Insert price log error.", productId), ex);
                    Thread.Sleep(60000);
                }
            }
            priceLogAdapter.Connection.Close();
        }

        private void CheckClassificationInSql(Product product)
        {
            var classAdapter = new DBProductsTableAdapters.ClassificationTableAdapter();
            classAdapter.Connection.ConnectionString = _connectionString;
            var classTable = new DBProducts.ClassificationDataTable();
            while (_isRunning)
            {
                try
                {
                    if (classAdapter.Connection.State == ConnectionState.Closed) classAdapter.Connection.Open();
                    classAdapter.FillBy_ID(classTable, product.IDCategories);
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("ProductId {0} : Classification Fill by ID error.", product.ID), ex);
                    Thread.Sleep(60000);
                }
            }
            if (classTable.Rows.Count == 0)
            {
                //insert Classification
                while (_isRunning)
                {
                    try
                    {
                        if (classAdapter.Connection.State == ConnectionState.Closed) classAdapter.Connection.Open();
                        classAdapter.Insert(product.IDCategories, Common.ConvertToString(product.Categories, " -> "), null, product.IDCongTy, false);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Log.Error(string.Format("ProductId {0} : Insert ClassificationID error.", product.ID), ex);
                        Thread.Sleep(60000);
                    }
                }
            }
            classAdapter.Connection.Close();
        }

        protected override void OnStop()
        {
            foreach (var worker in _workers)
                worker.Stop();
            _rabbitMqServer.Stop();
            _isRunning = false;
        }
    }
}
