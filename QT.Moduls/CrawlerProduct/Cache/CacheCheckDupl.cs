using log4net;
using QT.Entities;
using QT.Entities.CrawlerProduct.Cache;
using QT.Entities.Data;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QT.Entities.CrawlerProduct;
using Websosanh.Core.Drivers.Redis;

namespace QT.Moduls.CrawlerProduct.Cache
{
    public class CacheTrackDeleteProduct
    {
        static CacheTrackDeleteProduct obj;
        RedisServer redisServer = null;
        ILog log = log4net.LogManager.GetLogger(typeof(CacheTrackDeleteProduct));
        IDatabase database = null;
        private CacheTrackDeleteProduct()
        {
            redisServer = RedisManager.GetRedisServer("cacheTrackValidProduct");
            database = redisServer.GetDatabase(1);
        }

        public static CacheTrackDeleteProduct Instance()
        {
            return obj == null ? obj = new CacheTrackDeleteProduct() : obj;
        }

        public Dictionary<long, int> GetDicTrackOfCompany(long companyID)
        {
            try
            {
                Dictionary<long, int> dicTrack = new Dictionary<long, int>();
                IEnumerable<SortedSetEntry> result = this.database.SortedSetScan("cp:" + companyID.ToString(), "*", 10000);
                if (result != null)
                    foreach (var sortedSet in result)
                    {
                        dicTrack.Add(Convert.ToInt64(sortedSet.Element), Convert.ToInt32(sortedSet.Score));
                    }

                return dicTrack;
            }
            catch (Exception ex)
            {
                return new Dictionary<long, int>();
            }
        }

        public void IncreatementDieProduct(long company, long product)
        {
            while (true)
            {
                try
                {
                    database.SortedSetIncrement("cp:" + company.ToString(), product.ToString(), 1);
                    break;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    Thread.Sleep(1000);
                }
            }
        }

        public void SetBathScore(long companyID, List<long> lstProductIDUpdate, int score)
        {
            while (true)
            {
                try
                {
                    if (lstProductIDUpdate.Count > 0)
                    {
                        foreach (var lstProductBath in QT.Entities.Common.SplitArray<long>(lstProductIDUpdate.ToArray(), 100))
                        {
                            SortedSetEntry[] arSortedSetEntry = new SortedSetEntry[lstProductBath.Count];
                            for (int i = 0; i < lstProductBath.Count; i++) arSortedSetEntry[i] = new SortedSetEntry(lstProductBath[i], score);
                            database.SortedSetAdd("cp:" + companyID, arSortedSetEntry);
                        }
                        break;
                    }
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void RemoveBathScore(long companyID, List<long> productIdWaitDeleteGroup)
        {
            while (true)
            {
                try
                {
                    if (productIdWaitDeleteGroup.Count > 0)
                    {
                        foreach (var lstProductBath in QT.Entities.Common.SplitArray<long>(productIdWaitDeleteGroup.ToArray(), 100))
                        {
                            RedisValue[] arSortedSetEntry = new RedisValue[lstProductBath.Count];
                            for (int i = 0; i < lstProductBath.Count; i++) arSortedSetEntry[i] = productIdWaitDeleteGroup[i];
                            database.SortedSetRemove("cp:" + companyID, arSortedSetEntry);
                        }
                    }
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }
    }

    public class CacheDuplicateProduct
    {
        private static CacheDuplicateProduct _obj;
        private readonly RedisServer _redisServer = null;
        private readonly ILog _log = LogManager.GetLogger(typeof(CacheProductDesciptioHash));
        private readonly IDatabase _database = null;

        private CacheDuplicateProduct()
        {
            while (true)
            {
                try
                {
                    _redisServer = RedisManager.GetRedisServer(ConfigRun.KeyRedisCrawlerProduct);
                    _database = _redisServer.GetDatabase(4);
                    break;
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                    Thread.Sleep(10000);
                }
            }
        }

        public static CacheDuplicateProduct Instance()
        {
            return _obj ?? (_obj = new CacheDuplicateProduct());
        }

        public HashSet<long> GetHashDuplicate(long companyId )
        {
            try
            {
                HashSet<long> hs = new HashSet<long>();
                HashEntry[] ar = _database.HashGetAll("cdup:" + companyId);
                if (ar != null)
                {
                    foreach (var VARIABLE in ar)
                    {
                        hs.Add(Convert.ToInt64(VARIABLE.Name));
                    }
                }
                return hs;
            }
            catch (Exception ex)
            {
                return  new HashSet<long>();
            }
        }

        public void DeleteProductDuplicated(long companyId, List<long> productId)
        {
            while (true)
            {
                RedisValue[] arRedisValue = new RedisValue[productId.Count];
                for (int i = 0; i < productId.Count; i++) arRedisValue[i] = productId[i];
                _database.HashDelete("cdup:" + companyId, arRedisValue);
                return;
            }
        }

        public Dictionary<long, long> GetDicDuplicateProduct(long companyId)
        {
            var dicResult = new Dictionary<long, long>();
           var dataRedis =  _database.HashGetAll("cdup:" + companyId);
            foreach (var variable in dataRedis)
            {
                dicResult.Add(Convert.ToInt64(variable.Key), Convert.ToInt64(variable.Value));
            }
            return dicResult;
        }

        public void SetDuplicate (ProductDuplicate pd)
        {
            while (true)
            {
                try
                {
                    _database.HashSet("cdup:" + pd.CId, pd.Id,
                        Newtonsoft.Json.JsonConvert.SerializeObject(pd));
                    return;
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                    Thread.Sleep(10000);
                }
            }
        }


        public List<ProductDuplicate> GetAllDuplicateOfCompany(long company)
        {
            List<ProductDuplicate> lst = new List<ProductDuplicate>();
            var arEntry =  _database.HashGetAll("cdup:" + company);
            if (arEntry != null)
            {
                foreach (var entry in arEntry)
                {
                    lst.Add(Newtonsoft.Json.JsonConvert.DeserializeObject<ProductDuplicate>(entry.Value.ToString()));
                }
            }
            return lst;
        }
    }


    public class CacheProductDesciptioHash 
    {
        static CacheProductDesciptioHash obj;
        RedisServer redisServer = null;
        ILog log = log4net.LogManager.GetLogger(typeof(CacheProductDesciptioHash));
        IDatabase database = null;

        public static CacheProductDesciptioHash Instance()
        {
            return obj ?? (obj = new CacheProductDesciptioHash());
        }


        private CacheProductDesciptioHash()
        {
            while (true)
            {
                try
                {
                    redisServer = RedisManager.GetRedisServer("redisCacheCrawlerDuplicate");database = redisServer.GetDatabase(3);
                    break;}
                catch (Exception ex)
                {
                    log.Error(ex);
                    Thread.Sleep(10000);
                }
            }

        }

        public void SetHashDesc(long companyId, List<Tuple<long, long>> products)
        {
            var arEntry = new HashEntry[products.Count];
            for (var i = 0; i < products.Count; i++) arEntry[i] = new HashEntry(products[i].Item1, products[i].Item2);
            while (true)
            {
                try
                {
                    this.database.HashSet("c_d:" + companyId, arEntry);
                    return;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    Thread.Sleep(1000);
                }
            }
        }

        public void SetHashDesc(long companyId, Tuple<long, long> products)
        {
            while (true)
            {
                try
                {
                    this.database.HashSet("c_d:" + companyId, new HashEntry[]
                    {
                        new HashEntry(products.Item1, products.Item2)
                    });
                    return;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    Thread.Sleep(1000);
                }
            }
        }

        public IEnumerable<KeyValuePair<long, long>> GetAllProductHash(long companyId, List<long> productIds)
        {
            while (true)
            {
                try
                {
                    RedisValue[] arKey = new RedisValue[productIds.Count];
                    for (int i = 0; i < productIds.Count; i++) arKey[i] = productIds[i];
                    Dictionary<long, long> lst = new Dictionary<long, long>();
                    RedisValue[] redisValues = database.HashGet("c_d:" + companyId, arKey);
                    for (int i = 0; i < redisValues.Length; i++)
                    {
                        if (redisValues[i].HasValue)
                        {
                            if (!lst.ContainsKey(productIds[i]))
                            {
                                lst.Add(productIds[i], Convert.ToInt64(redisValues[i]));
                            }
                        }
                    }
                    return lst;
                }
                catch (Exception ex01)
                {

                }
            }
        }
    }


    public class CacheProductHash
    {
        static CacheProductHash obj;
        RedisServer redisServer = null;
        ILog _log = log4net.LogManager.GetLogger(typeof(CacheProductHash));
        IDatabase _database = null;

        private CacheProductHash()
        {
            while (true)
            {
                try
                {
                    redisServer = RedisManager.GetRedisServer("redisCacheCrawlerDuplicate");
                    _database = redisServer.GetDatabase(15);
                    break;
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                    Thread.Sleep(10000);
                }
            }

        }

        public void SetCacheProductHash(long companyId, List<ProductHash> products)
        {
            var arEntry = new HashEntry[products.Count];
            for (int i = 0; i < products.Count; i++) arEntry[i] = new HashEntry(products[i].Id, products[i].getJSON());
            while (true)
            {
                try
                {
                    this._database.HashSet("c:" + companyId, arEntry);
                    return;
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                    Thread.Sleep(1000);
                }
            }
        }

        public void SetCacheProductHash(long companyId, ProductHash product)
        {
            while (true)
            {
                try
                {
                    _database.HashSet("c:" + companyId, new HashEntry[] {new HashEntry(product.Id, product.getJSON())});
                    return;
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                    Thread.Sleep(1000);
                }
            }
        }

        public void SetCacheProductHash(long companyId, List<ProductHash> lstProduct, int itemPerLoop)
        {
            foreach (var arProductHash in lstProduct.ToArray().SplitArray<ProductHash>(itemPerLoop))
                SetCacheProductHash(companyId, arProductHash);
        }

        public static CacheProductHash Instance()
        {
            return obj ?? (obj = new CacheProductHash());
        }

        public List<ProductHash> GetAllProductHash(long companyId)
        {
            RedisValue[] arKey = _database.HashKeys("c:" + companyId.ToString());
            List<ProductHash> lst = new List<ProductHash>();
            var lstArray = Common.SplitArray<RedisValue>(arKey, 100);
            foreach (var arrayKey in lstArray)
            {
                try
                {
                    foreach (var item in this._database.HashGet("c:" + companyId, arrayKey.ToArray()))
                    {
                        var product = ProductHash.FromJSON(item.ToString());
                        lst.Add(product);
                    }
                }
                catch (Exception ex01)
                {
                    _log.Error(ex01);
                }
            }
            return lst;
        }

        public List<ProductHash> GetAllProductHash(long companyId, List<long> productIds)
        {
            int iTry = 0;
            while (true)
            {
                try
                {
                    iTry++;
                    var lst = new List<ProductHash>();
                    foreach (var listSub in Common.SplitArray(productIds.ToArray(), 100))
                    {
                        var arKey = new RedisValue[listSub.Count];
                        for (int i = 0; i < listSub.Count; i++) arKey[i] = listSub[i];
                        foreach (var item in this._database.HashGet("c:" + companyId, arKey))
                        {
                            if (item.HasValue)
                            {
                                lst.Add(ProductHash.FromJSON(item.ToString()));
                            }
                        }
                    }
                    return lst;
                }
                catch (Exception ex)
                {
                    _log.Error(string.Format("Try {0} {1} company {2} {3}", iTry, ex.Message, companyId, ex.StackTrace));
                    Thread.Sleep(1000);
                }
            }
        }

        public void RemoveBathProduct(long companyId, List<long> productIds)
        {
            if (productIds != null && productIds.Count > 0)
            {
                var arProductRedisValue = new RedisValue[productIds.Count];
                for (int i = 0; i < productIds.Count; i++)
                    arProductRedisValue[i] = productIds[i].ToString();
                _database.HashDelete("c:" + companyId, arProductRedisValue);
            }
        }

        public void RemoveProduct(long companyId, long productId)
        {
            while (true)
            {
                try
                {
                    _database.HashDelete("c:" + companyId, productId);
                    break;
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                    Thread.Sleep(2000);
                }
            }
        }
    }
    public class CacheCheckDuplicatepProduct
    {
        private SqlDb db;
        RedisCheckDuplicateAdapter redisCache;

        public CacheCheckDuplicatepProduct(SqlDb db, string server)
        {
            redisCache = QT.Moduls.CrawlerProduct.Cache.RedisCheckDuplicateAdapter.Instace();
            this.db = db;
        }

        public int RefreshCache(long CompanyID, string Domain)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(CacheCheckDuplicatepProduct));
            SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
            DataTable proTable = new DataTable();
            proTable = sqldb.GetTblData(@"SELECT 200000 InStock,  ID, ClassificationID, Status, Valid, Price, Name, ImageUrls, IsDeal, IsNews
                                            FROM            Product
                                            WHERE        (Company = @CompanyID) AND Valid = 1
                                            ORDER BY ID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                SqlDb.CreateParamteterSQL("CompanyID",CompanyID,SqlDbType.BigInt)});

            for (int j = 0; j < proTable.Rows.Count; j++)
            {
                try
                {
                    long ProductID = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["ID"].ToString());
                    int InStock = QT.Entities.Common.Obj2Int(proTable.Rows[j]["InStock"].ToString());
                    bool Valid = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["Valid"].ToString());
                    long Price = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["Price"].ToString());
                    string Name = QT.Entities.Common.Obj2String(proTable.Rows[j]["Name"].ToString());
                    bool IsNew = QT.Entities.Common.Obj2Bool(proTable.Rows[j]["IsNews"]);
                    string ImageUrl = proTable.Rows[j]["ImageUrls"].ToString();
                    long CategoryID = QT.Entities.Common.Obj2Int64(proTable.Rows[j]["ClassificationID"].ToString());

                    redisCache.SetCheckDuplicate(CompanyID, ProductID, Domain, Price, Name, ImageUrl, Valid);
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                }
            }
            return proTable.Rows.Count;
        }
    }
}
