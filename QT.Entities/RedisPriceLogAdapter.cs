using log4net;
using QT.Entities.Data;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QT.Entities.Images;
using Websosanh.Core.Drivers.Redis;

namespace QT.Entities
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

    public class RedisCompanyInfoAdapter
    {
        private static RedisCompanyInfoAdapter _obj;
        public static RedisCompanyInfoAdapter Instance()
        {
            return (_obj==null)?_obj=new RedisCompanyInfoAdapter():_obj;
        }
        public RedisCompanyInfoAdapter()
        {
            Init();
        }


        static ILog log = log4net.LogManager.GetLogger(typeof(RedisCompanyInfoAdapter));
        static IDatabase database = null;

        public void Init()
        {
            while (database == null)
            {
                try
                {
                    database = RedisManager.GetRedisServer("redisCacheCrawlerProduct").GetDatabase(5);
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public  void SetLastClear(long IdCompany)
        {
            Init();
            while (true)
            {
                try
                {
                    database.HashSet("cmp_clr_queue:" + IdCompany, "last_clear", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public  DateTime GetLastClearQueueCrawler(long CompanyID)
        {
            Init();
            try
            {
                RedisValue value = database.HashGet("cmp_clr_queue:" + CompanyID, "last_clear");
                if (!value.HasValue)
                {
                    database.HashSet("cmp_clr_queue:" + CompanyID, "last_clear", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    value = database.HashGet("cmp_clr_queue:" + CompanyID, "last_clear");
                }
                return Convert.ToDateTime(value.ToString());
            }
            catch
            {
                return DateTime.Now;
            }
        }
    }

    public class RedisCacheLastUpdateProduct
    {
        static RedisCacheLastUpdateProduct _instance = null;
        public static RedisCacheLastUpdateProduct Instance ()
        {
            if (_instance == null) _instance = new RedisCacheLastUpdateProduct();
            return _instance;
        }

        ILog _log = log4net.LogManager.GetLogger(typeof(RedisCacheLastUpdateProduct));
        readonly IDatabase database = RedisManager.GetRedisServer("redis_cache_product_last_update").GetDatabase(13);
        public void SetLastUpdateProduct (long ProductID,long CompanyID, long HashChange)
        {
            while (true)
            {
                database.SortedSetAdd("prd_s_lsu:" + CompanyID.ToString() + ":" + ProductID.ToString(), HashChange.ToString(), QT.Entities.Common.DateToInt(DateTime.Now));
                return;
            }
        }

       
    }

    public class RedisCacheCurrentCrawlerCompany
    {

        public RedisCacheCurrentCrawlerCompany()
        {
            Init();
        }

        static   RedisCacheCurrentCrawlerCompany _instance = null;
        public static RedisCacheCurrentCrawlerCompany Instance()
        {
            return _instance ?? (_instance = new RedisCacheCurrentCrawlerCompany());
        }

        readonly ILog log = log4net.LogManager.GetLogger(typeof(RedisCacheCurrentCrawlerCompany));
        IDatabase _database = null;

        public void Init ()
        {
            while (true)
            {
                try
                {
                    _database = RedisManager.GetRedisServer("redisCacheCrawlerProduct").GetDatabase(0);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01.Message);
                    Thread.Sleep(10000);
                }
            }
        }

        public void PushMssForCompany(long CompanyID, string Domain,DateTime StartRun, int TypeCrawler)
        {
            while (true)
            {
                try
                {

                    HashEntry[] hashEntry = new HashEntry[] { 
                                                                new HashEntry("TypeCrawler",TypeCrawler),
                                                                new HashEntry("Domain",Domain),
                                                                new HashEntry("ID",CompanyID.ToString()),
                                                                new HashEntry("StartRun",StartRun.ToString("yyyy-MM-dd HH:mm:ss")),
                                                                new HashEntry("Machine",QT.Entities.Server.GetMachineCode())
                                                             };

                    _database.HashSet("cmp_crawler_running:" + CompanyID.ToString() + ":" + TypeCrawler, hashEntry);
                    _database.KeyExpire("cmp_crawler_running:" + CompanyID.ToString(), new TimeSpan(0, 1, 0));
                    return;
                }
                catch (Exception ex001)
                {
                    log.Error(ex001.Message);
                    Thread.Sleep(10000);
                }
            }
        }

        public List<ClassCompanyRunning> GetAllCurrentRunning()
        {
            try
            {
                List<ClassCompanyRunning> lst = new List<ClassCompanyRunning>();
                foreach (var key in RedisManager.GetRedisServer("redisCacheCrawlerProduct").GetServer("192.168.100.185", 11311).Keys(pattern: "cmp_crawler_running:*"))
                {
                    try
                    {
                        string Domain = this._database.HashGet(key, "Domain").ToString();
                        long ID = QT.Entities.Common.Obj2Int64(this._database.HashGet(key, "ID"));
                        string StartRun = QT.Entities.Common.Obj2String(this._database.HashGet(key, "StartRun"));
                        string Machine = this._database.HashGet(key, "Machine").ToString();
                        int TypeCrawler = QT.Entities.Common.Obj2Int(this._database.HashGet(key, "TypeCrawler"),-1);
                        lst.Add(new ClassCompanyRunning()
                        {
                            Domain = Domain,
                            ID = ID,
                            StartRun = StartRun,
                            Machine = Machine,
                            TimeRun = Convert.ToInt32((DateTime.Now - Convert.ToDateTime(StartRun)).TotalMinutes),
                            TypeCrawler = TypeCrawler,
                            Key=key.ToString()
                        });
                    }
                    catch (Exception ex)
                    {

                    }
                }
                return lst;
            }
            catch (Exception ex01)
            {
                return null;
            }
        }


        public class ClassCompanyRunning
        {
            public int TimeRun { get; set; }
            public long ID { get; set; }
            public string Domain { get; set; }
            public string StartRun { get; set; }

            public string Machine { get; set; }

            public int TypeCrawler { get; set; }

            public string Key { get; set; }
        }
    }
}
