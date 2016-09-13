using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.Images;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.Drivers.Solr;
using Websosanh.Core.JobServer;
using WSS.Individual.RootProductAnalyzedService.DBIndiTableAdapters;
using WSS.Individual.RootProductAnalyzedService.DBProductTableAdapters;
using WSS.IndividualCategoryWebsites;
using WSS.IndividualCategoryWebsites.SolrRootProduct;

namespace WSS.Individual.RootProductAnalyzedService
{
    public partial class RootProductAnalyzedService : ServiceBase
    {
        private WorkerBasic[] _workers;
        private string _connectionStringIndi = "";
        private string _connectionProduct = "";
        private static readonly ILog Log = LogManager.GetLogger(typeof(RootProductAnalyzedService));
        private bool _isRunning = true;
        RabbitMQServer _rabbitMqServer;
        private int _workerCount;
        public RootProductAnalyzedService()
        {
            InitializeComponent();
            LoadAppConfig();
            OnStart(new string[] { });
        }
        private void LoadAppConfig()
        {
            _workerCount = Common.Obj2Int(ConfigurationSettings.AppSettings["workerCount"]);
            _connectionStringIndi = ConfigurationSettings.AppSettings["ConnectionIndividual"];
            _connectionProduct = ConfigurationSettings.AppSettings["ConnectionProduct"];
        }
        protected override void OnStart(string[] args)
        {
            try
            {
                _workers = new WorkerBasic[_workerCount]; _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigRabbitMqIndividualCategoryWebsites.RabbitMqServerName);
                for (var i = 0; i < _workerCount; i++)
                {
                    var worker = new WorkerBasic(_rabbitMqServer, ConfigRabbitMqIndividualCategoryWebsites.QueueRootProductAnalyzed);
                    _workers[i] = worker;
                    var workerTask = new Task(() =>
                    {
                        worker.JobHandler = (rootProductJob) =>
                        {
                            try
                            {
                                RootProductAnalyzed(rootProductJob);
                            }
                            catch (Exception exception)
                            {
                                Log.Error("Execute Job Error.", exception);
                            }
                        };
                        worker.Start();
                    });
                    workerTask.Start();
                    Log.InfoFormat("Worker {0} started", i);
                }
            }
            catch (Exception exception)
            {
                Log.Error("Start error", exception);
                throw;
            }
        }

        private void RootProductAnalyzed(byte[] rootProductByte)
        {
            var jsonListProduct = UtilZipFile.Unzip(rootProductByte);
            var result = JsonConvert.DeserializeObject<List<RootProductAnalyzedObject>>(jsonListProduct);
            var dataNameCode = new Dictionary<long, List<RootProductAnalyzedObject>>();
            foreach (var rootItem in result)
            {
                if (dataNameCode.ContainsKey(rootItem.RootProductId))
                {
                    dataNameCode[rootItem.RootProductId].Add(rootItem);
                }
                else
                    dataNameCode.Add(rootItem.RootProductId, new List<RootProductAnalyzedObject>() { rootItem });
            }
            var rootAdapter = new RootProductsTableAdapter();
            rootAdapter.Connection.ConnectionString = _connectionStringIndi;

            var solrRootProductClient =
                SolrRootProductClient.GetClient(SolrClientManager.GetSolrClient("solrRootProducts"));
            DBProductTableAdapters.ProductTableAdapter productAdapter = new ProductTableAdapter();
            productAdapter.Connection.ConnectionString = _connectionProduct;
            foreach (var rootItem in dataNameCode)
            {
                try
                {
                    var rootProductSql = new RootProductSQL
                    {
                        RootId = rootItem.Key,
                        Name = rootItem.Value[0].Name,
                        WebsiteId = rootItem.Value[0].WebsiteId,
                        NumMerchant = rootItem.Value.Count,
                        CategoryId = rootItem.Value[0].CategoryId
                    };
                    rootProductSql.LocalPath =
                        Websosanh.Core.Common.BAL.UrlUtilities.GetRootProductLocalPath(rootProductSql.RootId,
                            rootProductSql.Name);
                    long minprice = 0;
                    rootProductSql.ProductIdList = new List<long>();
                    var imagePath = "";
                    foreach (var item in rootItem.Value)
                    {
                        rootProductSql.ProductIdList.Add(item.Id);
                        if (!(minprice > 0 && minprice < item.Price))
                            minprice = item.Price;
                        if (string.IsNullOrEmpty(imagePath))
                        {
                            imagePath = GetImagePath(item.Id, productAdapter);
                        }
                    }
                    rootProductSql.MinPrice = minprice;
                    rootProductSql.Image = imagePath;

                    rootProductSql.ProductIdListString = rootProductSql.GetProductIdListString();
                    InsertSQlRootProduct(rootProductSql, rootAdapter);
                    InsertSolrRootProduct(rootProductSql, solrRootProductClient);
                }
                catch (Exception exception)
                {
                    Log.Error(exception);
                }
            }
        }

        private string GetImagePath(long id, ProductTableAdapter productAdapter)
        {
            var imagePath = "";
            var productTable = new DBProduct.ProductDataTable();
            try
            {
                productAdapter.FillById(productTable, id);
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
        private void InsertSolrRootProduct(RootProductSQL rootProductSql, SolrRootProductClient solrRootProductClient)
        {
            var item = new SolrRootProductItem
            {
                Id = rootProductSql.RootId,
                Name = rootProductSql.Name,
                Image = rootProductSql.Image,
                LocalPath = rootProductSql.LocalPath,
                MinPrice = rootProductSql.MinPrice,
                NumMerchant = rootProductSql.NumMerchant,
                WebsiteId = rootProductSql.WebsiteId
            };
            try
            {
                solrRootProductClient.Insert(item);
            }
            catch (Exception exException)
            {
                Log.Error(exException);
                //throw;
            }
        }

        private void InsertSQlRootProduct(RootProductSQL rootProductSql, RootProductsTableAdapter rootAdapter)
        {
            while (_isRunning)
            {
                try
                {
                    rootAdapter.Insert(rootProductSql.RootId, rootProductSql.Name, rootProductSql.WebsiteId,
                        rootProductSql.MinPrice, rootProductSql.NumMerchant, rootProductSql.LocalPath,
                        rootProductSql.ProductIdListString, rootProductSql.Image, rootProductSql.CategoryId,rootProductSql.Image);
                    Log.Info("insert success" + rootProductSql.RootId);
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("Insert SQL error with Id ={0} , Name = {1} {2}", rootProductSql.RootId,
                        rootProductSql.Name, ex.Message + ex.StackTrace));
                    break;
                }
            }
        }

        protected override void OnStop()
        {
            foreach (var worker in _workers)
                worker.Stop();
            _rabbitMqServer.Stop();
            _isRunning = false;
        }
    }

    public class RootProductSQL
    {
        public long RootId { set; get; }
        public string Name { set; get; }
        public int WebsiteId { set; get; }
        public long MinPrice { set; get; }
        public int NumMerchant { set; get; }
        public List<long> ProductIdList { set; get; }
        public string ProductIdListString { set; get; }
        public string GetProductIdListString()
        {
            return string.Join(",", ProductIdList);
        }
        public string LocalPath { set; get; }
        public string Image { set; get; }
        public int CategoryId { set; get; }
    }
}
