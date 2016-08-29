using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Websosanh.Core.Product.BAL;
using Websosanh.Core.Product.BO;

namespace WebsosanhCacheTool
{
    public class ProductIdentityCacheTool
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(ProductIdentityCacheTool));
        public static int InsertProductIdentities(string connProductString, TimeSpan? expiry = null)
        {
            var startTime = DateTime.Now;
            var listProductIdentities = ProductIdentityBAL.GetListCompletedProductIdentity(connProductString);            
            var indexedCount = 0;
            foreach (var productIdentityID in listProductIdentities)
            {
                try
                {
                    if (ProductIdentityBAL.InsertProductIdentityIntoCache(productIdentityID, expiry))
                        indexedCount++;
                }
                catch(Exception ex)
                {
                    Log.Error("Insert ProductIdentity Error", ex);
                }
            }
            var totalTime = (DateTime.Now - startTime).TotalSeconds;
            Log.InfoFormat("Insert ProductIdentities Completed. Inserted {0}/{1} products", indexedCount, listProductIdentities.Count);
            Log.InfoFormat("Total Time: {0} s", totalTime);
            return indexedCount;
        }

        public static int InsertProductIdentities(IEnumerable<ProductIdentity> productIdentities, TimeSpan? expiry = null)
        {
            var startTime = DateTime.Now;
            var indexedCount = 0;
            foreach (var productIdentity in productIdentities)
            {
                try
                {
                    if (ProductIdentityBAL.InsertProductIdentityIntoCache(productIdentity, expiry))
                        indexedCount++;
                }
                catch (Exception ex)
                {
                    Log.Error("Insert ProductIdentity Error", ex);
                }
            }
            var totalTime = (DateTime.Now - startTime).TotalSeconds;
            Log.InfoFormat("Insert ProductIdentities Completed. Inserted {0}/{1} products", indexedCount, productIdentities.Count());
            Log.InfoFormat("Total Time: {0} s", totalTime);
            return indexedCount;
        }
        public static bool InsertProductIdentity(long productID,string connProductString, TimeSpan? expiry = null)
        {
            try
            {
                var productIdentity = ProductIdentityBAL.GetProductIdentity(productID, connProductString);
                if (productIdentity == null)
                {
                    Log.WarnFormat("Cannot get productIdentity - ID {0}",productID);
                    return false;
                }
                if (ProductIdentityBAL.InsertProductIdentityIntoCache(productIdentity,expiry))
                        return true;
                Log.ErrorFormat("Insert fail ProductIdentity {0}", productID);
                return false;
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("Insert ProductIdentity Error - iD {0}",productID), ex);
                return false;
            }
        }
    }
}
