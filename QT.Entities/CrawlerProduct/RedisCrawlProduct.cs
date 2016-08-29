using QT.Entities.Data;
using QT.Entities.Model.SaleNews;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    public class RedisCrawlerProduct
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(RedisDb));

        public RedisCrawlerProduct(IDatabase redisDb)
        {
            this.redisDB = redisDb;
        }
        
        public RedisCrawlerProduct(string connect, int database)
        {
            var connectionMutilexer = ConnectionMultiplexer.Connect(connect);
            this.redisDB = connectionMutilexer.GetDatabase(database);
        }

        public static string PrefixCrawler = "crawler_product:";
        public static string Prefix_ControlPause = PrefixCrawler + "unique_instance:";
        public static string Prefix_Set_VisitedLink = PrefixCrawler + "crc_visited:";
        public static string Prefix_SessionKey = PrefixCrawler + "session:";
        public static string FieldSession_LastJobAt = "last_job_at";
        public static string FieldSession_SessionID = "session_id";
        public static string FieldSession_LastVersionApp = "last_version_app";
        public static string FieldSession_LastUpdateToSql = "last_update_to_sql";
        public static string FieldSession_NumberProduct = "number_product";
        public static string FieldSession_NumberVisited = "number_visited";
        public static string FieldSession_NumberIgnored = "number_ignored";

        public static string Format_DateTime = Common.Format_DateTime;

        /// <summary>
        /// A Session - ComapanyRunning.
        /// </summary>
        private IDatabase redisDB;

        public void SetValueSession(string typeCrawler, long companyID, string field, string value)
        {
            string key = Prefix_SessionKey + typeCrawler + ":" + companyID.ToString();
            this.redisDB.HashSet(key, field, value);
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


        public string GetValueSession(long companyID, string field, string defaultResult = "", string typeCrawler = "")
        {
            string key = RedisCrawlerProduct.Prefix_SessionKey + typeCrawler + ":" + companyID;
            if (!this.redisDB.HashExists(key, field)) return defaultResult;
            else
            {
                string str = this.redisDB.HashGet(key, field);
                return string.IsNullOrEmpty(str) ? defaultResult : str;
            }
        }


        SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
        public bool ContainProduct(long product_id)
        {
            return this.sqlDb.GetTblData("SELECT ID From Product Where id = @id", System.Data.CommandType.Text,
                new System.Data.SqlClient.SqlParameter[]{
                    sqlDb.CreateParamteter("id",product_id,System.Data.SqlDbType.BigInt)
                }).Rows.Count > 0;
        }

     

        public int GetPriceProduct(long productId)
        {
            var a = Convert.ToInt64(
                this.sqlDb.GetTblData("SELECT ISNULL(price,0) From Product WHERE id = @id", System.Data.CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                    sqlDb.CreateParamteter("id",productId,System.Data.SqlDbType.BigInt)
                }).Rows[0][0]);
            return (int)a;
        }

        public void SetProduct(long p1, int p2)
        {
            throw new NotImplementedException();
        }



        public bool CheckVersion(string p)
        {
            throw new NotImplementedException();
        }


        public void SetPauseInstance(string UniqueInstance, bool IsRunning)
        {
            this.redisDB.HashSet(Prefix_ControlPause + UniqueInstance, "IsPause", IsRunning.ToString());
        }

        public bool CheckPauseInstance(string UniqueInstance)
        {
            string key = Prefix_ControlPause + UniqueInstance;
            if (this.redisDB.HashExists(key, "IsPause"))
            {
                string str = this.redisDB.HashGet(key, "IsPause").ToString().ToLower();
                return Convert.ToBoolean(str == "true");
            }
            else
            {
                SetPauseInstance(UniqueInstance, false);
                return false;
            }
        }
    }
}
