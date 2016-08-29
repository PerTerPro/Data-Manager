using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.Drivers.Solr;
using Websosanh.Core.JobServer;
using Websosanh.Core.Product.BAL;
using Websosanh.Core.Product.DAL;
using WebsosanhCacheTool.CompanyDataSetTableAdapters;

namespace WSS.UpdateAllProductsOfAllMerchantProducer
{
    internal class Program
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof (Program));

        private static void Main(string[] args)
        {
            string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
            string updateAllProductsOfMerchantGroupName =
                ConfigurationManager.AppSettings["updateAllProductsOfMerchantGroupName"];
            string updateAllProductsOfMerchantJobName =
                ConfigurationManager.AppSettings["updateAllProductsOfMerchantJobName"];
            int updateAllProductsOfMerchantJobExpirationMS =
                CommonUtilities.Object2Int(
                    ConfigurationManager.AppSettings["updateAllProductsOfMerchantJobExpirationMS"], 0);
            string productConnectionString =
                ConfigurationManager.ConnectionStrings["productConnectionString"].ToString();
            try
            {
                var rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                JobClient jobClient = new JobClient(updateAllProductsOfMerchantGroupName, GroupType.Topic,
                    updateAllProductsOfMerchantJobName, true, rabbitMQServer);
                //Get List Company
                var companyTableAdapter = new CompanyTableAdapter
                {
                    Connection = {ConnectionString = productConnectionString}
                };
                var companyDataTable = companyTableAdapter.GetAllCompanies();
                Logger.InfoFormat("Selected {0} merchantIDs from db.",companyDataTable.Rows.Count);
                var solrClient = SolrProductClient.GetClient(SolrClientManager.GetSolrClient(SolrProductConstants.SOLR_NODE_PRODUCTS));
                var currentCompanyList = solrClient.GetAllCompany().Where(x => x.Value > 0).Select(x => x.Key).Select(long.Parse).ToArray();
                Logger.InfoFormat("Got {0} merchantIDs from solr.", currentCompanyList.Length);
                var remainCompanySet = new HashSet<long>();
                foreach (var companyID in currentCompanyList)
                {
                    remainCompanySet.Add(companyID);
                }
                var numPushed = 0;
                for (var rowIndex = 0; rowIndex < companyDataTable.Rows.Count; rowIndex++)
                {
                    var companyRow = companyDataTable[rowIndex];
                    var companyID = companyRow.ID;
                    string companyDomain = "";
                    if (companyRow["Domain"] != DBNull.Value)
                        companyDomain = companyRow.Domain;
                    try
                    {
                        var job = new Job {Data = BitConverter.GetBytes(companyID)};
                        jobClient.PublishJob(job,updateAllProductsOfMerchantJobExpirationMS);
                        if (remainCompanySet.Contains(companyID))
                            remainCompanySet.Remove(companyID);
                        numPushed ++;
                    }
                    catch (Exception ex)
                    {
                        Logger.Error(string.Format("Publish error! Company: {0} - Domain: {1}", companyID, companyDomain),
                            ex);
                    }
                }
                foreach (var companyID in remainCompanySet)
                {
                    try
                    {
                        var job = new Job {Data = BitConverter.GetBytes(companyID)};
                        jobClient.PublishJob(job,updateAllProductsOfMerchantJobExpirationMS);
                        numPushed ++;
                    }
                    catch (Exception ex)
                    {
                        Logger.Error(string.Format("Publish error! Company: {0}", companyID),
                            ex);
                    }
                }
                Logger.InfoFormat("Schedule success! Published [{0}/{1}] Companies", numPushed,
                    companyDataTable.Rows.Count);
                Thread.Sleep(100);
                rabbitMQServer.Stop();
            }
            catch (Exception ex)
            {
                Logger.Error("Schedule Error!", ex);
            }
        }
    }
}
