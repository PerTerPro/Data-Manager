using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Websosanh.Core.Product.BAL;
using Websosanh.Core.Product.BO;
using Websosanh.Core.Product.DAL;
using Websosanh.Core.SearchEngines.BO;
using Websosanh.Core.SearchEngines.BO.SolrDriverTypes;
using Websosanh.Core.SearchEngines.DAL;
using Websosanh.Core.ServiceStackUtilities;
using Websosanh.ProductSearchEnginesService.ServiceModel;
using WSS.Product.Utilities;

namespace WebsosanhCacheTool
{
    public class RootProductMappingCacheTool
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (RootProductMappingCacheTool));

        public static int InsertAllRootProductMappingIntoCache(string connProductString, string solrProductNodeID, TimeSpan? expiry = null)
        {
            var startTime = DateTime.Now;
            //Select List ProductIdentity
            var listProductIdentities = ProductIdentityBAL.GetListCompletedProductIdentity(connProductString);
            Log.InfoFormat("InsertAllRootProductMappingIntoCache: Get {0} productIdentities", listProductIdentities.Count);
            ProductIdentityCacheTool.InsertProductIdentities(listProductIdentities);
            var insertProductIdentitiesDuration = (DateTime.Now - startTime).TotalSeconds;
            Log.InfoFormat("InsertAllRootProductMappingIntoCache: Insert {0} productIdentities. Duration: {1} s", listProductIdentities.Count, insertProductIdentitiesDuration);
            startTime = DateTime.Now;
            var insertedCount = 0;
            foreach (var productIdentity in listProductIdentities)
            {
                try
                {
                    InsertRootProductMappingCache(productIdentity.ProductID, solrProductNodeID, expiry);
                    insertedCount++;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("Insert RootProductMapping Error - ID {0}", productIdentity.ProductID), ex);
                }
            }
            var totalTime = (DateTime.Now - startTime).TotalSeconds;
            Log.InfoFormat("Insert RootProductMapping Completed. Inserted {0}/{1} products. Time: {2} s", insertedCount,
                listProductIdentities.Count,totalTime);
            return insertedCount;
        }

        public static bool InsertRootProductMappingCache(long productID, string searchEnginesServiceUrl, TimeSpan? expiry = null)
        {
            var client = new ProtoBufServiceStackClient(searchEnginesServiceUrl);
            var response = client.Send<GetRootProductMappingResponse>(new GetRootProductMappingRequest { ProductID = productID, RegionID = 0, IncludeBlackList = false, GetFacet = true,SortType = RootProductMappingSortType.PriceWithVAT});
            if (response.RootProductMapping != null)
            {
                if (response.RootProductMapping.NumMerchant > 0)
                   RedisPriceLogAdapter.PushRootProductPrice(productID, response.RootProductMapping.MinPrice, response.RootProductMapping.MaxPrice, response.RootProductMapping.MeanPrice, DateTime.Now.Date);
                RootProductMappingBAL.InsertRootProductMappingIntoCache(response.RootProductMapping, 0, RootProductMappingSortType.PriceWithVAT,false, expiry);
                return true;
            }
            else
            {
                Log.ErrorFormat("InsertRootProductMappingIntoCache failed - ProductID {0}", productID);
                return false;
            }
        }

        public static bool InsertRootProductMappingCacheWithBlackList(long productID, string searchEnginesServiceUrl, TimeSpan? expiry = null)
        {
            var client = new ProtoBufServiceStackClient(searchEnginesServiceUrl);
            var response = client.Send<GetRootProductMappingResponse>(new GetRootProductMappingRequest { ProductID = productID, RegionID = 0, IncludeBlackList = true, GetFacet = false, SortType = RootProductMappingSortType.PriceWithVAT });
            if (response.RootProductMapping != null)
            {
                RootProductMappingBAL.InsertRootProductMappingIntoCache(response.RootProductMapping, 0, RootProductMappingSortType.PriceWithVAT, true, expiry);
                return true;
            }
            else
            {
                Log.ErrorFormat("InsertRootProductMappingWithBlackListIntoCache failed - ProductID {0}", productID);
                return false;
            }
        }

    }
}
