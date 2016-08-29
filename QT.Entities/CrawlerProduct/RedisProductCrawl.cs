using QT.Entities.Data;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QT.Entities.Model.SaleNews
{
    public class RedisDb
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(RedisDb));
        ConnectionMultiplexer connectionMutilexer;

        private RedisDb()
        {
            this.connectionMutilexer = ConnectionMultiplexer.Connect(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port);
            this.redisDB = this.connectionMutilexer.GetDatabase();
        }
        public void Dispose()
        {
            try
            {
                connectionMutilexer.Close();
                connectionMutilexer.Dispose();
            }
            catch (Exception ex)
            {
                log.ErrorFormat("{0}", ex.Message);
            }
        }

        public RedisDb(IDatabase redisDb)
        {
            this.redisDB = redisDb;

        }

        public static string SortedSetProduct = "raovat.product";
        public static string FieldProduct_Id = "title";
        public static string FieldProduct_ViewCount = "view_count";

        public static string FieldSession_LastUpdateToSql = "last_update_to_sql";
        public static string Prefix_Set_VisitedLink = "sale.CrcVisited:";
        public static string FieldSession_NumberProduct = "number_product";
        public static string FieldSession_VisitedLink = "visited_index";
        public static string Format_DateTime = Common.Format_DateTime;

        /// <summary>
        /// A Session - ComapanyRunning.
        /// </summary>
        public static string PrefixSessionCrawl = "sale.wss:session:";
        public static string PrefixSessionReloadData = "sale.wss.reload.session:";
        public static string RedisField_LastJobAt = "last_job_at";
        private IDatabase redisDB;
        public static string FieldSession_SessionID = "session_id";
        private string p1;
        private int p2;



        public void SetValueSession(string Prefix, long companyID, string field, string value)
        {
            this.redisDB.HashSet(Prefix + companyID.ToString(), field, value);
        }

        public void SetAdd(string key, string value)
        {
            this.redisDB.SetAdd(key, value);
        }

        public bool SetContains(string p, long s_crc)
        {
            int i = 0;
            while (i++ < 100)
            {
                try
                {
                    return this.redisDB.SetContains(p, s_crc);

                }
                catch (Exception ex)
                {
                    this.log.InfoFormat(ex.Message);
                    Thread.Sleep(1000);
                }
            }
            return false;
        }

        public bool KeyDelete(string key)
        {
            return this.redisDB.KeyDelete(key);
        }

        public void HashIncrement(string key, string field)
        {
            this.redisDB.HashIncrement(key, field);
        }

        public string HashGet(string p, string field)
        {
            return this.redisDB.HashGet(p, field);
        }

        public RedisValue[] GetTopViewCount(int numberItem)
        {
            return this.redisDB.SortedSetRangeByRank("raovat.product", 0, numberItem, Order.Descending);
        }

        public bool SortedSetAdd(long product_id, double score)
        {
            return this.redisDB.SortedSetAdd(SortedSetProduct, product_id.ToString(), score);
        }

        public bool HashSet(string key, string field, string value)
        {
            return this.redisDB.HashSet(key, field, value);
        }

       

        public string GetValueSession(string prefix, long companyID, string field, string defaultResult = "")
        {
            string str = this.redisDB.HashGet(RedisDb.PrefixSessionCrawl + companyID, field);
            return string.IsNullOrEmpty(str) ? defaultResult : str;
        }

        private RedisDb(string connect, int database)
        {
            this.connectionMutilexer = ConnectionMultiplexer.Connect(connect);
            this.redisDB = this.connectionMutilexer.GetDatabase(database);
        }

        public static RedisDb CreateInstance(string p1, int p2)
        {
            return new RedisDb(p1, p2);
        }

        public static RedisDb CreateInstance()
        {
            return new RedisDb(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port, 0);
        }

        public double GetStore(string sortedSet, long product_id)
        {
            double? score = this.redisDB.SortedSetScore(sortedSet, product_id.ToString());
            return (score == null) ? 0 : Convert.ToDouble(score);
        }
    }
}