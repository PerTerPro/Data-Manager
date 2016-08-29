using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls
{
    public class HashSetProduct
    {
        private IDatabase redisDb;
        private string nameQueue;
        public static string PrefixHash = "crl_prod:hash_product:";

        public HashSetProduct()
        {
            var redisMultiplexer = ConnectionMultiplexer.Connect(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port);
            this.redisDb = redisMultiplexer.GetDatabase(3);
        }

        public void IncreateFailProduct (long productID)
        {
            this.redisDb.HashIncrement(PrefixHash + productID.ToString(), "number_fail");
        }

        public void ResetFailProduct(long productID)
        {
            this.redisDb.HashSet(PrefixHash + productID.ToString(), "number_fail", "0");
        }

        public int GetFailProduct(long productID, int defaultReturn)
        {
            string key = PrefixHash+productID.ToString();
            if (!this.redisDb.KeyExists(key)) return defaultReturn;
            else
            {
                if (!this.redisDb.HashExists(key, "number_fail")) return defaultReturn;
                else return Convert.ToInt32(this.redisDb.HashGet(key, "number_fail"));
            }
        }

        public void SetLastReload(long productID)
        {
            string key = PrefixHash + productID.ToString();
            this.redisDb.HashSet(key, "last_reload", DateTime.Now.ToString(QT.Entities.Common.Format_DateTime));
        }
    }
}
