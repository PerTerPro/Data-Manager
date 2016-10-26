using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using QT.Entities.MasOffer;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using Websosanh.Core.Merchant.BAL;
using Websosanh.Core.Product.BAL;
using WebsosanhCacheTool;

namespace WSS.UpdateProductToRedisService
{
    public partial class UpdateProductToRedisService : ServiceBase
    {
        private readonly MasOfferAdapter massOffer = MasOfferAdapter.Instance();

        private Worker[] updateAllProductOfMerchantWorkers;
        private Worker[] updateProductWorkers;
        RabbitMQServer rabbitMQServer;
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public UpdateProductToRedisService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                var productConnectionString =
                    ConfigurationManager.ConnectionStrings["productConnectionString"].ConnectionString;
                MasOfferAdapter.SetConnection(productConnectionString);

                var userConnecionString = ConfigurationManager.ConnectionStrings["userConnecionString"].ConnectionString;
                string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
                string updateAllProductOfMerchantToRedisJobName =
                    ConfigurationManager.AppSettings["updateAllProductOfMerchantToRedisJobName"];
                int updateAllProductOfMerchantWorkerCount =
                    CommonUtilities.Object2Int(
                        ConfigurationManager.AppSettings["updateAllProductOfMerchantWorkerCount"], 1);
                updateAllProductOfMerchantWorkers = new Worker[updateAllProductOfMerchantWorkerCount];
                string updateProductToRedisJobName = ConfigurationManager.AppSettings["updateProductToRedisJobName"];
                int updateProductWorkerCount =
                    CommonUtilities.Object2Int(ConfigurationManager.AppSettings["updateProductWorkerCount"], 1);
                var searchEnginesServiceUrl = ConfigurationManager.AppSettings["searchEnginesServiceUrl"];
                updateProductWorkers = new Worker[updateProductWorkerCount];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                
                for (int i = 0; i < updateAllProductOfMerchantWorkerCount; i++)
                {
                    var worker = new Worker(updateAllProductOfMerchantToRedisJobName, false, rabbitMQServer);
                    updateAllProductOfMerchantWorkers[i] = worker;
                    Task workerTask = new Task(() =>
                    {
                        worker.JobHandler = (updateAllProductOfMerchantToRedisJob) =>
                        {
                            try
                            {
                                var companyID = BitConverter.ToInt64(updateAllProductOfMerchantToRedisJob.Data, 0);
                                if (companyID == -1) //UpdateAlL
                                    WebMerchantProductCacheTool.InsertAllWebMerchantProductToCache(
                                        productConnectionString);
                                else if (companyID == 6619858476258121218) // Websosanh
                                    WebRootProductCacheTool.InsertAllWebRootProductIntoCache(productConnectionString,
                                        userConnecionString, searchEnginesServiceUrl);
                                else
                                {
                                    var merchantShortInfo = MerchantBAL.GetMerchantShortInfoFromCache(companyID);
                                    if (merchantShortInfo == null)
                                    {
                                        merchantShortInfo = MerchantBAL.GetMerchantShortInfo(companyID,
                                            productConnectionString, userConnecionString);
                                        if (merchantShortInfo == null)
                                            return false;
                                        MerchantBAL.InsertMerchantShortInfoToCache(merchantShortInfo,
                                            new TimeSpan(10000, 0, 0, 0, 0));
                                    }
                                    WebMerchantProductCacheTool.InsertWebMerchantProductToCache(companyID,
                                        merchantShortInfo.Domain, productConnectionString);
                                }
                                return true;
                            }
                            catch (Exception ex)
                            {
                                Logger.Error("Update All Products Of Merchant To Redis", ex);
                                return false;
                            }
                        };
                        worker.Start();
                    });
                    workerTask.Start();
                    Logger.InfoFormat("Worker {0} started", i);
                }

                for (int i = 0; i < updateProductWorkerCount; i++)
                {
                    var worker = new Worker(updateProductToRedisJobName, false, rabbitMQServer);
                    updateProductWorkers[i] = worker;
                    Task workerTask = new Task(() =>
                    {

                        worker.JobHandler = (updateProductToRedisJob) =>
                        {
                            try
                            {
                                var productID = BitConverter.ToInt64(updateProductToRedisJob.Data, 0);
                                if (productID <= 0)
                                {
                                    Logger.WarnFormat("UpdateProductToRedis: Received productID {0}", productID);
                                    return false;
                                }
                                if (updateProductToRedisJob.Type == 1) //RootProduct
                                {
                                    WebRootProductCacheTool.InsertWebRootProductIntoCache(productID,
                                        productConnectionString, userConnecionString, searchEnginesServiceUrl);
                                }
                                else
                                {
                                    var webMerchantProduct = WebMerchantProductBAL.GetWebMerchantProduct(productID,
                                        productConnectionString);
                                    if (webMerchantProduct != null)
                                    {
                                        //XT: Change link if masOffer company
                                        MasOfferAdapter.SetConnection(productConnectionString);
                                        if (massOffer.CheckIsMasOffer(webMerchantProduct.CompanyID))
                                        {
                                            webMerchantProduct.DetailUrl =
                                                massOffer.GetFullUrl(webMerchantProduct.CompanyID,
                                                    webMerchantProduct.DetailUrl);
                                        }

                                        WebMerchantProductBAL.InsertWebMerchantProductsIntoCache(new[]
                                        {webMerchantProduct});
                                    }
                                }
                                return true;
                            }
                            catch (Exception ex)
                            {
                                Logger.Error("Update Product To Redis", ex);
                                return false;
                            }
                        };
                        worker.Start();
                    });
                    workerTask.Start();
                    Logger.InfoFormat("Worker {0} started", i);
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
            if (updateAllProductOfMerchantWorkers != null)
                foreach (var worker in updateAllProductOfMerchantWorkers)
                    worker.Stop();
        }
    }
}
