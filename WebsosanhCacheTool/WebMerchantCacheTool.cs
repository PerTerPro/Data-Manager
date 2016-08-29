using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Merchant.BAL;
using Websosanh.Core.Merchant.BO;

namespace WebsosanhCacheTool
{
    public class WebMerchantCacheTool
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WebMerchantCacheTool));
        private static Dictionary<int, int> _regionParentDictionary;
        public static void InsertAllBranchesAndRegionsOfAllMerchant(string productConnectionString)
        {
                var startTime = DateTime.Now;
                var allMerchantBranches = MerchantBranchBAL.GetAllBranchesOfAllMerchants(productConnectionString);
                var getSqlDuration = DateTime.Now - startTime;
                startTime = DateTime.Now;
                MerchantBranchBAL.InsertAllBranchesOfAllMerchantsToCache(allMerchantBranches);
                MerchantBranchBAL.InsertAllBranchShortInfoOfAllMerchantsToCache(allMerchantBranches);
                if(_regionParentDictionary == null)
                    _regionParentDictionary = RegionBAL.GetRegionParentDictionary(productConnectionString);
                var provinViewOrders = RegionBAL.GetAllRegionOrder(productConnectionString);
                MerchantRegionBAL.InsertMerchantRegionsOfAllMerchant(allMerchantBranches, provinViewOrders, _regionParentDictionary);
                var insertDuration = DateTime.Now - startTime;
                Logger.InfoFormat("InsertAllBranchesAndRegionsOfAllMerchant: {0} merchantBranches, GetSQLTime: {1} second, InsertTime: {2} second", allMerchantBranches.Count, getSqlDuration.TotalSeconds, insertDuration.TotalSeconds);
        }

        public static int InsertAllBranchesAndRegionsOfMerchant(long merchantID, string productConnectionString)
        {
            var merchantBranches = MerchantBranchBAL.GetAllBranchesOfMerchant(merchantID, productConnectionString);
            if (merchantBranches != null && merchantBranches.Count!= 0)
            {
                MerchantBranchBAL.InsertAllBranchesOfMerchantToCache(merchantID,merchantBranches);
                MerchantBranchBAL.InsertAllBranchShortInfoOfMerchantToCache(merchantID, merchantBranches.Select(x => new MerchantBranchShortInfo(x)).ToList());
                if(_regionParentDictionary == null)
                    _regionParentDictionary = RegionBAL.GetRegionParentDictionary(productConnectionString);
                var merchantRegions = new MerchantRegions();
                merchantRegions.AllMerchantDistrict = merchantBranches.Select(x => x.RegionID).Distinct().ToList();
                merchantRegions.AllMerchantProvins = merchantRegions.AllMerchantDistrict.Select(x => _regionParentDictionary[x]).Distinct().ToList();
                MerchantRegionBAL.InsertMerchantRegions(merchantID,merchantRegions);
                return merchantBranches.Count;
            }
            return 0;
        }

        public static void InsertAllMerchantShortInfoToCache(string productConnectionString, string userConnectionString)
        {
            var startTime = DateTime.Now;
            var allMerchantShortInfo = MerchantBAL.GetAllMerchantShortInfo(productConnectionString, userConnectionString);
            var getSqlDuration = DateTime.Now - startTime;
            startTime = DateTime.Now;
            foreach (var merchantShortInfo in allMerchantShortInfo)
            {
                MerchantBAL.InsertMerchantShortInfoToCache(merchantShortInfo);
            }
            var insertDuration = DateTime.Now - startTime;
            Logger.InfoFormat("Insert {0} merchants, GetSQLTime: {1} second, InsertTime: {2} second", allMerchantShortInfo.Count, getSqlDuration.TotalSeconds, insertDuration.TotalSeconds);
        }

        public static bool InsertMerchantShortInfoToCache(long merchantID, string productConnectionString, string userConnectionString)
        {
            var merchantShortInfo = MerchantBAL.GetMerchantShortInfo(merchantID, productConnectionString, userConnectionString);
            if (merchantShortInfo != null)
            {
                MerchantBAL.InsertMerchantShortInfoToCache(merchantShortInfo);
                return true;
            }
            return false;
        }
    }
}
