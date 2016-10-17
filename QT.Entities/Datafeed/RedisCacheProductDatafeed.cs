using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using StackExchange.Redis;
using Websosanh.Core.Drivers.Redis;

namespace QT.Entities.Datafeed
{
    public class RedisCacheProductDatafeed
    {
        static ILog Log = LogManager.GetLogger(typeof(RedisCacheProductDatafeed));
        static IDatabase _database = RedisManager.GetRedisServer(ConfigRabbitMqDatafeed.KeyRedisCacheProductDatafeed).GetDatabase(1);

        public static void SetHashProductInfo(long productId, long hashChangeInfo)
        {
            var rep = 0;
            while (true)
            {
                try
                {
                    _database.HashSet("prdid:" + productId, "hash_prdinfo", hashChangeInfo);
                    break;
                }
                catch (Exception exception)
                {
                    Log.Error(string.Format("ProductID = {0} Set hash product info from Redis fails", productId), exception);
                    Thread.Sleep(10000);
                    if (rep == 5) break;
                    else rep++;
                }
            }
        }
        public static long GetHashProductInfo(long productId)
        {
            long result = 0;
            var rep = 0;
            while (true)
            {
                try
                {
                    if (_database.HashGet("prdid:" + productId, "hash_prdinfo").HasValue)
                        result = Convert.ToInt64(_database.HashGet("prdid:" + productId, "hash_productinfo"));
                    break;
                }
                catch (Exception exception)
                {
                    Log.Error(string.Format("ProductID = {0} Get hash product info from Redis fails.", productId), exception);
                    Thread.Sleep(10000);
                    if (rep == 5)
                        break;
                    else
                        rep++;
                }
            }
            return result;
        }

        public static bool CheckChangeInfoProduct(long productId, long hashproductcheck)
        {
            var result = true;
            var hashProductInRedis = GetHashProductInfo(productId);if (hashproductcheck == hashProductInRedis)
                result = false;
            else
                SetHashProductInfo(productId,hashproductcheck);
            return result;
        }
    }
}
