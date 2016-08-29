using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using UpdateSolrTools;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.Drivers.Solr;
using Websosanh.Core.JobServer;
using Websosanh.Core.Merchant.BAL;
using Websosanh.Core.Product.BAL;
using Websosanh.Core.Product.DAL;

namespace WSS.IndexMerchantProductToSolrService
{
    public partial class IndexProductToSolrService : ServiceBase
    {
        DateTime LastUpdateDataTime;
        DateTime LastUpdateListMerchantTime;
        DateTime LastUpdatePropertiesTime;
        private string _productConnectionString;
        private string _userConnectionString;
        private string _searchEnginesServiceUrl;
        private SolrIndexer solrIndexer;
        private bool _isRunning;
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private Worker[] indexAllProductOfMerchantWorkers;
        private BatchWorker[] indexProductWorkers;
        RabbitMQServer rabbitMQServer;
        private void UpdateListMerchant()
        {
            while (_isRunning)
            {
                if ((DateTime.Now - LastUpdateListMerchantTime) > TimeSpan.FromMinutes(3))
                {
                    try
                    {
                        var listMerchantUseDatafeedID = IndexProductTools.GetListMerchantUseDatafeedID(_productConnectionString); ;
                        var listSpecialMerchantID = IndexProductTools.GetListSpecialMerchantID(_productConnectionString);
                        var listPriorMerchants = IndexProductTools.GetAllPriorMerchants(_productConnectionString);
                        var listBadMerchant = IndexProductTools.GetAllBadMerchantId(_productConnectionString, 45);
                            solrIndexer.ListMerchantUseDatafeedID = listMerchantUseDatafeedID;
                            solrIndexer.ListSpecialMerchantID = listSpecialMerchantID;
                            solrIndexer.ListPriorMerchants = listPriorMerchants;
                            solrIndexer.ListBadMerchantID = listBadMerchant;
                        LastUpdateListMerchantTime = DateTime.Now;
                        Logger.Info("Update ListMerchant Success!");
                    }
                    catch (Exception exception)
                    {
                        Logger.Error("Update ListMerchant Error.", exception);
                        Thread.Sleep(10000);
                    }
                }
                else
                    Thread.Sleep(10000);
            }
        }

        private void UpdateData()
        {
            while (_isRunning)
            {
                if ((DateTime.Now - LastUpdateDataTime) > TimeSpan.FromMinutes(600))
                {
                    try
                    {
                        var regionTree = RegionBAL.GetRegionTree(_productConnectionString);
                        var categoryTree = ProductCategoryBAL.GetProductCategoryTree(_productConnectionString);
                        var categoryTags = IndexProductTools.GetAllCategoryTags(_productConnectionString);
                        var listPrefixCategory = IndexProductTools.GetAllPrefixCategory(_productConnectionString);
                            solrIndexer.RegionTree = regionTree;
                            solrIndexer.CategoryTree = categoryTree;
                            solrIndexer.CategoryTags = categoryTags;
                         solrIndexer.ListPrefixCategory = listPrefixCategory;
                        LastUpdateDataTime = DateTime.Now;
                        Logger.Info("Update Data Success!");
                    }
                    catch (Exception exception)
                    {
                        Logger.Error("Update Data Error.", exception);
                        Thread.Sleep(30000);
                    }
                }
                else
                    Thread.Sleep(10000);
            }
        }

        private void UpdateProperties()
        {
            while (_isRunning)
            {
                if ((DateTime.Now - LastUpdatePropertiesTime) > TimeSpan.FromHours(12))
                {
                    try
                    {
                        var propertyValueDictionary =
                            WebProductPropertyBAL.GetAllPropertyValues(_productConnectionString);
                        var propertyUnitDictionary =
                            WebProductPropertyBAL.GetPropertyUnitDictionary(_productConnectionString);
                        solrIndexer.PropertyUnitDictionary = propertyUnitDictionary;
                        solrIndexer.PropertyValueDictionary = propertyValueDictionary;
                        LastUpdatePropertiesTime = DateTime.Now;
                        Logger.Info("Update Properties Success!");
                    }
                    catch (Exception exception)
                    {
                        Logger.Error("Update Properties Error.", exception);
                        Thread.Sleep(30000);
                    }
                }
                else
                    Thread.Sleep(10000);
            }
        }

        public IndexProductToSolrService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                var productConnectionString = ConfigurationManager.ConnectionStrings["productConnectionString"].ConnectionString;
                var userConnectionString = ConfigurationManager.ConnectionStrings["userConnectionString"].ConnectionString;
                _productConnectionString = productConnectionString;
                _userConnectionString = userConnectionString;
                Server.ConnectionString = productConnectionString;
                Server.UserConnectionString = userConnectionString;
                string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                string indexAllProductOfMerchantJobName = ConfigurationManager.AppSettings["indexAllProductOfMerchantJobName"];
                int indexAllProductOfMerchantWorkerCount = CommonUtilities.Object2Int(ConfigurationManager.AppSettings["indexAllProductOfMerchantWorkerCount"], 1);
                indexAllProductOfMerchantWorkers = new Worker[indexAllProductOfMerchantWorkerCount];
                string indexProductJobName = ConfigurationManager.AppSettings["indexProductJobName"];
                int indexProductWorkerCount = CommonUtilities.Object2Int(ConfigurationManager.AppSettings["indexProductWorkerCount"], 1);
                _searchEnginesServiceUrl = ConfigurationManager.AppSettings["searchEnginesServiceUrl"];
                indexProductWorkers = new BatchWorker[indexProductWorkerCount]; 
                solrIndexer = new SolrIndexer();
                solrIndexer.ConnectionStringProducts = productConnectionString;
                solrIndexer.SolrClient = SolrProductClient.GetClient(SolrClientManager.GetSolrClient(SolrProductConstants.SOLR_NODE_PRODUCTS));
                _isRunning = true;
                var updateDataTask = new Task(UpdateData);
                updateDataTask.Start();
                var updateListMerchantTask = new Task(UpdateListMerchant);
                updateListMerchantTask.Start();
                var updatePropertyTask = new Task(UpdateProperties);
                updatePropertyTask.Start();
                for (int i = 0; i < indexAllProductOfMerchantWorkerCount; i++)
                {
                    var worker = new Worker(indexAllProductOfMerchantJobName, false, rabbitMQServer);
                    indexAllProductOfMerchantWorkers[i] = worker;
                    var workerTask = new Task(() =>
                    {
                        Thread.Sleep(60000); //Sleep 90 seconds to wait for get Data Tasks;
                        worker.JobHandler = (indexAllProductOfMerchantJob) =>
                        {
                            var companyID = BitConverter.ToInt64(indexAllProductOfMerchantJob.Data, 0);
                            if (companyID == SolrIndexer.IDWebsosanh)
                            {
                                string message;
                                var numProducts = solrIndexer.UpdateAllRootProducts(out message, productConnectionString, userConnectionString, _searchEnginesServiceUrl);
                                if (numProducts < 0)
                                    return false;
                                Logger.Debug("Update root products success!");
                                return true;
                            }
                            else
                            {
                                var merchantInfo = MerchantBAL.GetMerchantShortInfoFromCache(companyID);
                                if(merchantInfo == null)
                                {
                                    merchantInfo = MerchantBAL.GetMerchantShortInfo(companyID, _productConnectionString, _userConnectionString);
                                    if (merchantInfo == null)
                                        return true;
                                    MerchantBAL.InsertMerchantShortInfoToCache(merchantInfo);
                                }
                                var numProducts = solrIndexer.UpdateAllProductOfMerchant(companyID, merchantInfo.Domain);
                                if (numProducts < 0)
                                    return false;
                                Logger.DebugFormat("Update company {0} success!",merchantInfo.Domain);
                                return true;
                            }
                        };
                        worker.Start();
                    });
                    workerTask.Start();
                    Logger.InfoFormat("Update All products of Merchant Worker {0} started", i);
                }

                for (int i = 0; i < indexProductWorkerCount; i++)
                {
                    var worker = new BatchWorker(indexProductJobName, false, rabbitMQServer,100,300000);
                    indexProductWorkers[i] = worker;
                    var workerTask = new Task(() =>
                    {
                        Thread.Sleep(90000); //Sleep 90 seconds to wait for get Data Tasks;
                        worker.JobHandler = (indexProductJobs) =>
                        {
                            var merchantProductIds = new List<long>();
                            var rootProductIds = new List<long>();
                            foreach (var indexProductJob in indexProductJobs)
                            {
                                var productID = BitConverter.ToInt64(indexProductJob.Data, 0);
                                 if (indexProductJob.Type == 1)
                                     rootProductIds.Add(productID);
                                 else
                                    merchantProductIds.Add(productID);
                            }
                            if (rootProductIds.Count > 0)
                            {
                                var startTime = DateTime.Now;
                                solrIndexer.UpdateRootProducts(rootProductIds, productConnectionString, userConnectionString, _searchEnginesServiceUrl);
                                Logger.DebugFormat("Update time : {0} ms - {1} rootProducts", (DateTime.Now - startTime).TotalMilliseconds, rootProductIds.Count);
                            }
                            else
                            {
                                var startTime = DateTime.Now;
                                solrIndexer.UpdateMerchantProducts(merchantProductIds);
                                Logger.DebugFormat("Update time : {0} ms - {1} merchantProducts", (DateTime.Now - startTime).TotalMilliseconds, merchantProductIds.Count);
                            }
                            return true;
                        };
                        worker.Start();
                    });
                    workerTask.Start();
                    Logger.InfoFormat("Update Product Worker {0} started", i);
                }
            }
            catch (Exception excepion)
            {
                Logger.Error("Error on start", excepion);
                throw;
            }
        }

        protected override void OnStop()
        {
            foreach (var worker in indexAllProductOfMerchantWorkers)
                worker.Stop();
            foreach (var batchWorker in indexProductWorkers)
              batchWorker.Stop();  
            _isRunning = false;
        }
    }
}
