using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using QT.Entities;
using QT.Entities.Images;
using QT.Moduls;
using WSS.ImageImbo.DownloadImageService.DBImageTableAdapters;
using WSS.ImageServer;

namespace WSS.ImageImbo.DownloadImageService
{
    public partial class DownloadImageService : ServiceBase
    {
        private Worker[] _workers;
        private static readonly ILog Log = LogManager.GetLogger(typeof(DownloadImageService));

        private string _connectionString =
            "Data Source = 172.22.1.82; Initial Catalog = QT_2; Persist Security Info=True;User ID = wss_price; Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout = 200";
        private bool _isRunning = true;
        RabbitMQServer _rabbitMqServer;
        private int _workerProduct;
        private int _workerCompany;
        private JobClient _checkErrorJobClient;
        private List<Tuple<int, int>> _widthHeightImages;
        //Imbo
        private string _publicKeyImbo = "wss";
        private string _privateKeyImbo = "123websosanh@195";
        private string _userNameImbo = "wss";
        private string _hostImbo = "https://172.22.1.226";
        private int _portImbo = 443;

        //log product
        private History_DownloadImageProductTableAdapter _historyProductAdapter = new History_DownloadImageProductTableAdapter();
        public DownloadImageService()
        {
            InitializeComponent();
            LoadAppConfig();
            //OnStart(new string[] { });
        }

        private void LoadAppConfig()
        {
            _connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
            //imbo
            _publicKeyImbo = ConfigurationSettings.AppSettings["PublicKeyImboImageProduct"];
            _privateKeyImbo = ConfigurationSettings.AppSettings["PrivateKeyImboImageProduct"];
            _userNameImbo = ConfigurationSettings.AppSettings["UserNameImboImageProduct"];
            _hostImbo = ConfigurationSettings.AppSettings["HostImboImageProduct"];
            _portImbo = Common.Obj2Int(ConfigurationSettings.AppSettings["PortImboImageProduct"]);

            _workerProduct = Common.Obj2Int(ConfigurationSettings.AppSettings["workerProduct"]);
            _workerCompany = Common.Obj2Int(ConfigurationSettings.AppSettings["workerCompany"]);

            _widthHeightImages = new List<Tuple<int, int>>();
            var widthHeightImagesConfig = ConfigurationSettings.AppSettings["WithHeightImagesConfig"];
            var arrWidthHeightImages = widthHeightImagesConfig.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in arrWidthHeightImages)
            {
                var wh = item.Split('x');
                _widthHeightImages.Add(new Tuple<int, int>(Common.Obj2Int(wh[0]), Common.Obj2Int(wh[1])));
            }
        }
        protected sealed override void OnStart(string[] args)
        {
            try
            {
                _historyProductAdapter.Connection.ConnectionString = _connectionString;
                _workers = new Worker[_workerProduct + _workerCompany + 1];
                _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
                _checkErrorJobClient = new JobClient(ConfigImages.ImboExchangeImages, GroupType.Topic, ConfigImages.ImboRoutingKeyCheckErrorDownload, true, _rabbitMqServer);
                #region Worker Product
                for (var i = 0; i < _workerProduct; i++)
                {
                    var worker = new Worker(ConfigImages.ImboQueueDownloadImageProduct, false, _rabbitMqServer);
                    _workers[i] = worker;
                    var workerTask = new Task(() =>
                    {
                        //JobClient send message to service upload sql & thumb của tráng
                        var producerUpdateImageIdSql = new ProducerBasic(_rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyUploadImageIdSql);
                        var producerThumbImage = new ProducerBasic(_rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyThumbImage);
                        worker.JobHandler = (downloadImageJob) =>
                        {
                            try
                            {
                                DownloadImageProduct(ImageProductInfo.GetDataFromMessage(downloadImageJob.Data), producerUpdateImageIdSql, producerThumbImage);
                            }
                            catch (Exception exception)
                            {
                                Log.Error("Execute Job Error.", exception);
                            }
                            return true;
                        };
                        worker.Start();
                    });
                    workerTask.Start();
                    Log.InfoFormat("Worker {0} started", i);
                }
                #endregion

                #region Worker RootProduct
                var workerSpGoc = new Worker(ConfigImages.ImboQueueDownloadImageRootProduct, false, _rabbitMqServer);
                _workers[_workerProduct] = workerSpGoc;
                var workerSpGocTask = new Task(() =>
                {
                    //JobClient send message to service upload sql & thumb của tráng
                    var producerUpdateImageIdSql = new ProducerBasic(_rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyUploadImageIdSql);
                    var producerThumbImage = new ProducerBasic(_rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyThumbImage);
                    workerSpGoc.JobHandler = (downloadImageJob) =>
                    {
                        try
                        {
                            DownloadImageProduct(ImageProductInfo.GetDataFromMessage(downloadImageJob.Data), producerUpdateImageIdSql, producerThumbImage);
                        }
                        catch (Exception exception)
                        {
                            Log.Error("Execute Job Error.", exception);
                        }
                        return true;
                    };
                    workerSpGoc.Start();
                });
                workerSpGocTask.Start();
                Log.InfoFormat("Worker(SpGoc) {0} started", _workerProduct);
                #endregion

                #region Worker Company
                for (var i = _workerProduct + 1; i <= _workerProduct + _workerCompany; i++)
                {
                    var worker = new Worker(ConfigImages.ImboQueueDownloadImageCompany, false, _rabbitMqServer);
                    _workers[i] = worker;
                    var workerTask = new Task(() =>
                    {
                        //JobClient send message to service upload sql & thumb của tráng
                        var producerUpdateImageIdSql = new ProducerBasic(_rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyUploadImageIdSql);
                        var producerThumbImage = new ProducerBasic(_rabbitMqServer, ConfigImages.ImboExchangeImages, ConfigImages.ImboRoutingKeyThumbImage);
                        worker.JobHandler = (downloadImageJob) =>
                        {
                            long idCompany;
                            try
                            {
                                idCompany = BitConverter.ToInt64(downloadImageJob.Data, 0);
                                if (downloadImageJob.Type == (int)TypeJobWithRabbitMQ.ReloadAll)
                                    DownloadImageCompany(idCompany, producerUpdateImageIdSql, producerThumbImage, true);
                                else
                                    DownloadImageCompany(idCompany, producerUpdateImageIdSql, producerThumbImage, false);

                            }
                            catch (Exception exception)
                            {
                                Log.Error("Execute Job Error.", exception);
                            }
                            return true;
                        };
                        worker.Start();
                    });
                    workerTask.Start();
                    Log.InfoFormat("Worker(Company) {0} started", i);
                }
                #endregion
            }
            catch (Exception exception)
            {
                Log.Error("Start error", exception);
                throw;
            }
        }
        private void DownloadImageCompany(long idCompany, ProducerBasic producerUpdateImageIdSql, ProducerBasic producerThumbImage, bool redownloadAll)
        {
            try
            {
                var start = DateTime.Now;
                var productTableAdapter = new ProductTableAdapter();
                productTableAdapter.Connection.ConnectionString = _connectionString;
                var productTable = new DBImage.ProductDataTable();
                if (idCompany == 6619858476258121218)
                    productTableAdapter.FillBy_RootProduct(productTable);
                else if (idCompany == 1)
                    productTableAdapter.FillAllImageIdNull(productTable);
                else if (redownloadAll)
                    productTableAdapter.FillAllBy_Company(productTable, idCompany);
                else
                    productTableAdapter.FillBy_CompanyAndImageIdNull(productTable, idCompany);
                if (productTable.Rows.Count > 0)
                {
                    List<long> listIdFail = new List<long>();
                    int success = 0;
                    int fail = 0;
                    for (int i = 0; i < productTable.Rows.Count; i++)
                    {
                        ImageProductInfo product = new ImageProductInfo();
                        product.Id = Common.Obj2Int64(productTable.Rows[i]["ID"]);
                        product.ImageUrls = productTable.Rows[i]["ImageUrls"].ToString();
                        if (DownloadImageProduct(product, producerUpdateImageIdSql, producerThumbImage)) success++;
                        else
                        {
                            fail++;
                            listIdFail.Add(product.Id);
                        }
                    }
                    Log.Info(string.Format("CompanyId = {0} downloaded {1}/{2} image", idCompany, success, productTable.Count));
                    var end = DateTime.Now;
                    #region Insert History donwloadimage Company
                    try
                    {
                        History_DownloadImageCompanyTableAdapter historyCompanyAdapter = new History_DownloadImageCompanyTableAdapter();
                        historyCompanyAdapter.Connection.ConnectionString = _connectionString;
                        historyCompanyAdapter.Insert(idCompany, productTable.Count, success, fail, start, end, string.Join(",", listIdFail));
                    }
                    catch (Exception ex)
                    {
                        Log.Error(string.Format("Insert log error companyId = {1}", idCompany), ex);
                    }
                    #endregion
                }
                else
                    Log.Info(string.Format("CompanyId {0} 0 product download image", idCompany));

            }
            catch (Exception exception)
            {
                Log.Error(string.Format("CompanyId: ID = {0} ERROR: ", idCompany), exception);
            }
        }
        private bool DownloadImageProduct(ImageProductInfo imageProductInfo, ProducerBasic producerUpdateImageIdSql, ProducerBasic producerThumbImage)
        {
            bool result = false;
            try
            {
                var idImbo = Common.DownloadImageProductWithImboServer(imageProductInfo.ImageUrls, _publicKeyImbo, _privateKeyImbo, _userNameImbo, _hostImbo, _portImbo);
                if (!string.IsNullOrEmpty(idImbo))
                {
                    UpdateImageIdSqlService(imageProductInfo.Id, idImbo, producerUpdateImageIdSql);
                    ThumbImageService(imageProductInfo.Id, idImbo, producerThumbImage);
                    Log.Info(string.Format("Product: ID = {0} download image success!", imageProductInfo.Id));
                    //InsertLogDownloadImageProduct(imageProductInfo.Id);
                    result = true;
                }
                else
                {
                    imageProductInfo.ErrorMessage = "IDImbo = null";
                    SendErrorDownloadImageToService(imageProductInfo);
                }
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Product: ID = {0}. ImageUrl: {1} . DetailUrl: {2}", imageProductInfo.Id, imageProductInfo.ImageUrls, imageProductInfo.DetailUrl), exception);
                imageProductInfo.ErrorMessage = exception.ToString();
                SendErrorDownloadImageToService(imageProductInfo);
            }
            return result;
        }
        private void InsertLogDownloadImageProduct(long productId, History_DownloadImageProductTableAdapter historyProductAdapter)
        {
                while (_isRunning)
                {
                    try
                    {
                        if (historyProductAdapter.Connection.State == ConnectionState.Closed) historyProductAdapter.Connection.Open();
                        _historyProductAdapter.Insert(productId, DateTime.Now, true, false, "");
                        break;
                    }
                    catch (Exception exception)
                    {
                        Log.Error(string.Format("ProductId {0} : Insert log error.", productId), exception);
                        Thread.Sleep(60000);
                    }
                }
        }
        public void ThumbImageService(long productId, string idImbo, ProducerBasic producerThumbImage)
        {
            int index = 0;
            while (_isRunning)
            {
                try
                {
                    producerThumbImage.PublishString(new JobWaitThumb()
                    {
                        ImageId = idImbo,
                        Sizes = _widthHeightImages
                    }.ToJson());
                    break;
                }
                catch (Exception exception)
                {
                    Thread.Sleep(600000);
                    Log.Error(
                        string.Format("Product: ID = {0} Send message to service check error download image. Thread Sleep 10p",
                            productId), exception);
                    if (index == 5)
                        break;
                    else
                        index++;
                }
            }
        }
        public void UpdateImageIdSqlService(long productId, string idImageImbo, ProducerBasic producerUpdateImageIdSql)
        {
            int index = 0;
            while (_isRunning)
            {
                try
                {
                    producerUpdateImageIdSql.PublishString(new JobUploadedImg()
                    {
                        ImageId = idImageImbo,
                        ProductId = productId
                    }.ToJson());
                    break;
                }
                catch (Exception exception)
                {
                    Thread.Sleep(600000);
                    Log.Error(
                        string.Format("Product: ID = {0} Send message to service check error download image. Thread Sleep 10p",
                            productId), exception);
                    if (index == 5)
                        break;
                    else
                        index++;
                }
            }
        }
        private readonly object _keyLock = new object();
        public void SendErrorDownloadImageToService(ImageProductInfo imageProductInfo)
        {
            lock (_keyLock)
            {
                int index = 0;
                var job = new Job { Data = ImageProductInfo.GetMessage(imageProductInfo) };
                while (_isRunning)
                {
                    try
                    {
                        _checkErrorJobClient.PublishJob(job);
                        //Log.Info(string.Format("Push message to services checkerror = {0}", imageProductInfo.Id));
                        break;
                    }
                    catch (Exception exception)
                    {
                        Thread.Sleep(60000);
                        Log.Error(
                            string.Format("Product: ID = {0} Send message to service check error download image.",
                                imageProductInfo.Id), exception);
                        if (index == 5)
                            break;
                        else
                            index++;
                    }
                }
            }
        }

        protected override void OnStop()
        {
            Log.Info("Stop Service!");
            foreach (var worker in _workers)
                worker.Stop();
            _rabbitMqServer.Stop();
            _isRunning = false;
        }
    }
}
