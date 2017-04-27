using log4net;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.Redis;

namespace WSS.Product.Utilities
{
    public class RedisPriceLogAdapter
    {
        static log4net.ILog logger = log4net.LogManager.GetLogger(typeof(RedisPriceLogAdapter));
        public static void PushMerchantProductPrice (long ProductID, long Price, DateTime timeUpdate)
        {
            while (true)
            {
                try
                {
                    var database = RedisManager.GetRedisServer("redisPriceLog").GetDatabase();
                    database.HashSet("price_log:" + ProductID, timeUpdate.ToString("yyMMddHH"), Price);
                    break;
                }
                catch (Exception ex)
                {
                    logger.Error("PushPrice Error", ex);
                    Thread.Sleep(100);
                }
            }
        }

        public static List<KeyValuePair<DateTime, long>> GetMerchantProductPriceLog(long ProductID)
        {
            List<KeyValuePair<DateTime, long>> lstResult = new List<KeyValuePair<DateTime, long>>();
            var database = RedisManager.GetRedisServer("redisPriceLog").GetDatabase();
            HashEntry[] arData = database.HashGetAll("price_log:" + ProductID);
            foreach(HashEntry hashEntry in arData)
            {
                string strTime = hashEntry.Name;
                DateTime timeUpdate = DateTime.ParseExact(strTime, "yyMMddHH",
                                       System.Globalization.CultureInfo.InvariantCulture);
                long price = Convert.ToInt64(hashEntry.Value);
                lstResult.Add(new KeyValuePair<DateTime, long>(timeUpdate,price));
            }
            return lstResult.OrderBy(x => x.Key).ToList();
        }

        public static void PushRootProductPrice(long ProductID, long minPrice, long maxPrice, long meanPrice, DateTime timeUpdate)
        {
            while (true)
            {
                try
                {
                    var database = RedisManager.GetRedisServer("redisPriceLog").GetDatabase(1);
                    byte[] data = new byte[24];
                    byte[] minPriceBytes = BitConverter.GetBytes(minPrice);
                    byte[] maxPriceBytes = BitConverter.GetBytes(maxPrice);
                    byte[] meanPriceBytes = BitConverter.GetBytes(meanPrice);
                    Buffer.BlockCopy(minPriceBytes, 0, data, 0, 8);
                    Buffer.BlockCopy(maxPriceBytes, 0, data, 8, 8);
                    Buffer.BlockCopy(meanPriceBytes, 0, data, 16, 8);
                    database.HashSet("price_log:" + ProductID, timeUpdate.ToString("yyMMddHH"), data);
                    break;
                }
                catch (Exception ex)
                {
                    logger.Error("PushPrice Error", ex);
                    Thread.Sleep(100);
                }
            }
        }

        public static List<KeyValuePair<DateTime, long[]>> GetRootProductPriceLog(long ProductID)
        {
            List<KeyValuePair<DateTime, long[]>> lstResult = new List<KeyValuePair<DateTime, long[]>>();
            var database = RedisManager.GetRedisServer("redisPriceLog").GetDatabase(1);
            HashEntry[] arData = database.HashGetAll("price_log:" + ProductID);
            foreach (HashEntry hashEntry in arData)
            {
                string strTime = hashEntry.Name;
                DateTime timeUpdate = DateTime.ParseExact(strTime, "yyMMddHH",
                                       System.Globalization.CultureInfo.InvariantCulture);
                long minPrice = BitConverter.ToInt64(hashEntry.Value,0);
                long maxPrice = BitConverter.ToInt64(hashEntry.Value,8);
                long meanPrice = BitConverter.ToInt64(hashEntry.Value, 16);
                lstResult.Add(new KeyValuePair<DateTime, long[]>(timeUpdate, new long[]{minPrice,maxPrice,meanPrice}));
            }
            return lstResult.OrderBy(x => x.Key).ToList();
        }
    }

}
