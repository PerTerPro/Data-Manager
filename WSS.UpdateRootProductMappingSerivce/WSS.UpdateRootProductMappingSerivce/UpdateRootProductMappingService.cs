using log4net;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using log4net.Repository.Hierarchy;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using WebsosanhCacheTool;

namespace WSS.UpdateRootProductMappingService
{
    public partial class UpdateRootProductMappingService : ServiceBase
    {

        private Worker[] updateRootProductMappingWorkers;
        RabbitMQServer rabbitMQServer;
        private static readonly ILog _logger = LogManager.GetLogger(typeof(UpdateRootProductMappingService));

        public UpdateRootProductMappingService()
        {
            InitializeComponent();
            OnStart(new string[] {});
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
                string updateRootProductMappingJobName = ConfigurationManager.AppSettings["updateRootProductMappingJobName"];
                int updateRootProductMappingWorkerCount = CommonUtilities.Object2Int(ConfigurationManager.AppSettings["updateRootProductMappingWorkerCount"], 1);
                string updateProductRootIDGroupName = ConfigurationManager.AppSettings["updateProductRootIDGroupName"];
                string updateProductRootIDJobName = ConfigurationManager.AppSettings["updateProductRootIDJobName"];
                int updateProductRootIDJobExpirationMS = CommonUtilities.Object2Int(ConfigurationManager.AppSettings["updateProductRootIDJobExpirationMS"], 0);
                string updateAllProductsOfMerchantGroupName = ConfigurationManager.AppSettings["updateAllProductsOfMerchantGroupName"];
                string updateAllProductsOfMerchantJobName = ConfigurationManager.AppSettings["updateAllProductsOfMerchantJobName"];
                int updateAllProductsOfMerchantJobExpirationMS = CommonUtilities.Object2Int(ConfigurationManager.AppSettings["updateAllProductsOfMerchantJobExpirationMS"], 0);
                var searchEnginesServiceUrl = ConfigurationManager.AppSettings["searchEnginesServiceUrl"];
                updateRootProductMappingWorkers = new Worker[updateRootProductMappingWorkerCount];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                for (int i = 0; i < updateRootProductMappingWorkerCount; i++)
                {
                    var worker = new Worker(updateRootProductMappingJobName, false, rabbitMQServer);
                    updateRootProductMappingWorkers[i] = worker;
                    Task workerTask = new Task(() =>
                    {
                        var updateProductRootIDJobClient = new JobClient(updateProductRootIDGroupName, GroupType.Direct, updateProductRootIDJobName, true, rabbitMQServer);
                        worker.JobHandler = (updateAllProductOfMerchantToRedisJob) =>
                        {
                            try
                            {
                                var productID = BitConverter.ToInt64(updateAllProductOfMerchantToRedisJob.Data, 0);
                                if (productID == -1) //Special ID => Update all rootProductID
                                {
                                    _logger.InfoFormat("Received special ID: {0}.",productID);
                                    Thread.Sleep(100000);
                                    var updateAllRootProductsClient = new JobClient(
                                        updateAllProductsOfMerchantGroupName, GroupType.Topic,
                                        updateAllProductsOfMerchantJobName, true, rabbitMQServer);
                                    var job = new Job { Data = BitConverter.GetBytes(6619858476258121218) };
                                    updateAllRootProductsClient.PublishJob(job, updateAllProductsOfMerchantJobExpirationMS);
                                    _logger.InfoFormat("Published job to update all rootProduts.");
                                    return true;
                                }
                                if (RootProductMappingCacheTool.InsertRootProductMappingCache(productID,searchEnginesServiceUrl))
                                {
                                    var job = new Job {Data = BitConverter.GetBytes(productID)};
                                    updateProductRootIDJobClient.PublishJob(job, updateProductRootIDJobExpirationMS);
                                }
                                return true;

                            }
                            catch (Exception ex)
                            {
                                _logger.Error("Update RootProductMapping failed!", ex);
                                return false;
                            }
                        };
                        worker.Start();
                    });
                    workerTask.Start();
                    _logger.InfoFormat("Worker {0} started", i);
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Service Start failed!", ex);
                throw;
            }
            
        }

        protected override void OnStop()
        {
            if(updateRootProductMappingWorkers != null)
                foreach (var worker in updateRootProductMappingWorkers)
                    worker.Stop();
        }
    }
}
