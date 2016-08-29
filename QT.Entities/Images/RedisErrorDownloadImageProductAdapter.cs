using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using StackExchange.Redis;
using Websosanh.Core.Drivers.Redis;

namespace QT.Entities.Images
{
    public class RedisErrorDownloadImageProductAdapter
    {
        static ILog Log = LogManager.GetLogger(typeof(RedisErrorDownloadImageProductAdapter));
        static IDatabase _database = RedisManager.GetRedisServer(ConfigImages.KeyRedisCheckErrorDownloadImageProduct).GetDatabase(0);
        //int numberError = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["numberError"].ToString());

        public static void SetErrorDownloadImage(long productId, int numberError)
        {
            var rep = 0;
            while (true)
            {
                try
                {
                    _database.HashSet("prd_errimg:" + productId, "number_err", numberError);
                    break;
                }
                catch (Exception exception)
                {
                    rep++;
                    Log.Error(string.Format("ProductID = {0} Set number err download image from Redis fails", productId), exception);
                    Thread.Sleep(10000);
                    if (rep == 5)
                        break;
                }
            }
        }
        public static int GetErrorDownloadImage(long productId)
        {
            var result = 0;
            var rep = 0;
            while (true)
            {
                try
                {
                    if (_database.HashGet("prd_errimg:" + productId, "number_err").HasValue)
                        result = Convert.ToInt32(_database.HashGet("prd_errimg:" + productId, "number_err"));
                    break;
                }
                catch (Exception exception)
                {

                    Log.Error(string.Format("ProductID = {0} Get number err download image from Redis fails.", productId), exception);
                    Thread.Sleep(10000);
                    if (rep == 5)
                        break;
                    else
                        rep++;
                }
            }
            return result;
        }
    }
}
