using log4net;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using Websosanh.Core.Product.BAL;
using Websosanh.Core.Product.BO;

namespace WSS.UpdateRootProductMappingProducer
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
            string updateRootProductMappingGroupName = ConfigurationManager.AppSettings["updateRootProductMappingGroupName"];
            string updateRootProductMappingJobName = ConfigurationManager.AppSettings["updateRootProductMappingJobName"];
            int updateRootProductMappingJobExpirationMS = CommonUtilities.Object2Int(ConfigurationManager.AppSettings["updateRootProductMappingJobExpirationMS"], 0);
            string connectionstring = ConfigurationManager.AppSettings["ConnectionString"];
            if (connectionstring != null)
            {
                var rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                JobClient jobClient = new JobClient(updateRootProductMappingGroupName, GroupType.Direct, updateRootProductMappingJobName, true, rabbitMQServer);
                Log.InfoFormat("ConnectionString = {0}", connectionstring);
                var listProductIdentities = ProductIdentityBAL.GetListCompletedProductIdentity(connectionstring);
                Log.InfoFormat("Got {0} products.", listProductIdentities.Count);

                foreach(var productIdentity in listProductIdentities)
                {
                    var job = new Job {Data = BitConverter.GetBytes(productIdentity.ProductID)};
                    try
                    {
                        ProductIdentityBAL.InsertProductIdentityIntoCache(productIdentity);
                        jobClient.PublishJob(job, updateRootProductMappingJobExpirationMS);
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Publish updateRootProductMapping job error. ProductID:" + productIdentity.ProductID, ex);
                    }
                }
                // Push special ID -> Trigger Update Redis and IndexSolr
                long specialID = -1;
                var specialJob = new Job { Data = BitConverter.GetBytes(specialID) };
                jobClient.PublishJob(specialJob, updateRootProductMappingJobExpirationMS);
                Log.InfoFormat("Published specialID!");
                Thread.Sleep(100);
                rabbitMQServer.Stop();
            }
            else
                Log.Error("ConnectionString Null");
        }
    }
}
