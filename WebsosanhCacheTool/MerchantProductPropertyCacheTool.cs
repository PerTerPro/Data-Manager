using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.Caching;

namespace WebsosanhCacheTool
{
    public class MerchantProductPropertyCacheTool
    {
        public static List<KeyValuePair<string,string>> GetProductPropertyFromCache(long productId)
        {
            var cacheServer = CacheManager.GetCacheServer("MerchantProductProperty");
            var cacheKey = "prs:" + productId;
            return cacheServer.Get<List<KeyValuePair<string, string>>>(cacheKey, true);
        }
    }
}
