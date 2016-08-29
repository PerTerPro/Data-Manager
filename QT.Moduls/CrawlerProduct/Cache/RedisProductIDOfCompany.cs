using QT.Entities.Data;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QT.Entities.CrawlerProduct;
using Websosanh.Core.Drivers.Redis;

namespace QT.Moduls.CrawlerProduct.Cache
{

    public class RedisLastUpdateProduct
    {
        private log4net.ILog log = log4net.LogManager.GetLogger(typeof(RedisLastUpdateProduct));
        private RedisServer redisServer;
        IDatabase database = null;
        static RedisLastUpdateProduct _objIns = null;
        private RedisLastUpdateProduct()
        {
            Init();
        }

        public void Init()
        {
            while (database == null)
            {
                try
                {
                    redisServer = RedisManager.GetRedisServer("redisLastUpdateProductInCompany");
                    database = redisServer.GetDatabase(13);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public static RedisLastUpdateProduct Instance()
        {
            return _objIns ?? (_objIns = new RedisLastUpdateProduct());
        }
        public void UpdateBathLastUpdateProduct(long CompanyID, List<long> ProductIDs, DateTime LastUpdate)
        {
            int numberItemPerLoop = 100;
            foreach (var productBath in QT.Entities.Common.SplitArray<long>(ProductIDs.ToArray(), numberItemPerLoop))
            {
                List<SortedSetEntry> arValue = new List<SortedSetEntry>();
                foreach(var productId in productBath)
                {
                        arValue.Add(new SortedSetEntry(productId, Convert.ToInt64(LastUpdate.ToString("yyyyMMddHHmm"))));
                }
                while (true)
                {
                    try
                    {
                        database.SortedSetAdd("cmp_prd_lst:" + CompanyID.ToString(), arValue.ToArray(), CommandFlags.HighPriority);
                        break;                  
                    }
                    catch (Exception ex)
                    {
                        log.Error(ex);
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void RemoveAllLstProduct(long companyID)
        {
            bool bOK = database.KeyDelete("cmp_prd_lst:" + companyID.ToString());
        }

        public List<long> GetTopLastUpdate(long CompanyID, DateTime dateLast, int topItem)
        {
            List<long> lstTop = new List<long>();
            var lastestItem = database.SortedSetRangeByRankWithScores("cmp_prd_lst:" + CompanyID.ToString(), 0, topItem - 1, Order.Ascending, CommandFlags.HighPriority);
            foreach (var item in lastestItem)
            {
                if (Convert.ToInt64(dateLast.ToString("yyyyMMddHHmm")) > Convert.ToInt64(item.Score))
                {
                    lstTop.Add(Convert.ToInt64(item.Element));
                }
            }
            return lstTop;
        }

       

        public List<long> GetAllProduct(long CompanyID)
        {
            int numberItemPerLoop = 500;
            int iCurrent = 0;
            List<long> lstTop = new List<long>();
            while (true)
            {
                try
                {
                    var lastestItem = database.SortedSetRangeByRankWithScores("cmp_prd_lst:" + CompanyID.ToString(), iCurrent, iCurrent + numberItemPerLoop, Order.Ascending, CommandFlags.HighPriority);
                    iCurrent = iCurrent + numberItemPerLoop;
                    foreach (var item in lastestItem)
                    {
                        lstTop.Add(Convert.ToInt64(item.Element));
                    }
                    if (lastestItem.Length==0) return lstTop;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(1000);
                }
            }
        }

        public Dictionary<long, long> GetAllData(long CompanyID)
        {
            Dictionary<long,long> lstTop = new Dictionary<long,long>();
            var lastestItem = database.SortedSetRangeByRankWithScores("cmp_prd_lst:" + CompanyID.ToString(), 0, -1, Order.Ascending, CommandFlags.HighPriority);
            foreach (var item in lastestItem)
            {
                lstTop.Add(Convert.ToInt64(item.Element), Convert.ToInt64(item.Score));
            }
            return lstTop;
        }

        public void RemoveProduct(long copmanyId, long proudctId)
        {
            while (true)
            {
                try
                {
                    database.SortedSetRemove("cmp_prd_lst:" + copmanyId, proudctId);
                    break;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    Thread.Sleep(2000);
                }
            }
        }

        public void RemoveBathProduct(long companyId, List<long> productIds)
        {
            if (productIds.Count == 0) return;
            while (true)
            {
                try
                {
                    database.SortedSetRemove("cmp_prd_lst:" + companyId, productIds.Select(item => (RedisValue) item).ToArray());
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }


        public void ResetForCompany(long CompanyID, Entities.Data.SqlDb sqlDb)
        {
            this.RemoveAllLstProduct(CompanyID);
            DataTable tbl = sqlDb.GetTblData("select id from product where company = @CompanyID", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                            SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
                            });
            List<long> productIDs = new List<long>();
            foreach (DataRow rowInfo in tbl.Rows) productIDs.Add(Convert.ToInt64(rowInfo["id"]));
            this.UpdateBathLastUpdateProduct(CompanyID, productIDs, new DateTime(1990, 1, 1, 0, 0, 0));
        }
    }

    public class RedisVersionAutoCrawler
    {
        public struct VersionAutoCrawler
        {
            public string Version { get; set; }
            public string Url { get; set; }
        }

        private log4net.ILog log = log4net.LogManager.GetLogger(typeof(RedisVersionAutoCrawler));
        private RedisServer redisServer;
        IDatabase database = null;
        static RedisVersionAutoCrawler _objIns = null;
        private RedisVersionAutoCrawler()
        {
            Init();
        }

        public VersionAutoCrawler GetCurrentVersion()
        {
            VersionAutoCrawler v = new VersionAutoCrawler()
            {
                Url=this.database.HashGet("vcr", "url").ToString(),
                Version  = this.database.HashGet("vcr", "version").ToString(),
            };
            return v;
        }

        public void SetCurrentVersion(string version, string url)
        {
            HashEntry[] hashEntry = new HashEntry[]{
                new HashEntry("version",version),
                new HashEntry("url",url)
            };
            database.HashSet("vcr:", hashEntry);
        }

        public void Init()
        {
            while (database == null)
            {
                try
                {
                    redisServer = RedisManager.GetRedisServer("redisVersionAutoCrawler");
                    database = redisServer.GetDatabase(2);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public static RedisVersionAutoCrawler Instance()
        {
            return _objIns == null ? _objIns = new RedisVersionAutoCrawler() : _objIns;
        }
    }

    public class RedisProductIDOfCompany
    {
        private log4net.ILog log = log4net.LogManager.GetLogger(typeof(RedisProductIDOfCompany));
        private RedisServer redisServer;
        IDatabase database = null;
        static RedisProductIDOfCompany _objIns = null;
        private RedisProductIDOfCompany()
        {
            Init();
        }

        public void Init()
        {
            while (database == null)
            {
                try
                {
                    redisServer = RedisManager.GetRedisServer("redisProductInCompany");
                    database = redisServer.GetDatabase(11);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public static RedisProductIDOfCompany Instance()
        {
            return _objIns == null ? _objIns = new RedisProductIDOfCompany() : _objIns;
        }
        public void SetForCompany(long CompanyID, List<long> ProductIDs)
        {
            int iStart = 0;
            while (iStart<ProductIDs.Count)
            {
                List<RedisValue> arValue = new List<RedisValue>();
                for (int i = iStart; i < iStart + 100; i++)
                {
                    if (i < ProductIDs.Count)
                        arValue.Add(ProductIDs[i]);
                }
                iStart = iStart + 100;
                while(true)
                {
                    try
                    {
                        database.SetAdd("cmp_prd:" + CompanyID.ToString(), arValue.ToArray(), CommandFlags.HighPriority);
                        log.Info(string.Format("Sync {0} products", arValue.Count.ToString()));
                        break;
                    }
                    catch (Exception ex)
                    {
                        log.Error(ex);
                        Thread.Sleep(100);
                    }
                }
            }
        }

        public IEnumerable<long> GetProductOfCompany(long CompanyID)
        {
            while (true)
            {
                try
                {
                    IEnumerable<RedisValue> arValue = database.SetScan("cmp_prd:" + CompanyID.ToString());
                    List<long> lst = new List<long>();
                    foreach (RedisValue value in arValue) lst.Add(Convert.ToInt64(value));
                    return lst; 
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(1000);
                }
            }
        }

        

        public List<long> GetListCrc(long CompanyID)
        {
            while (true)
            {
                try
                {
                    IEnumerable<RedisValue> arValue = database.SetScan("crc_visited:" + CompanyID.ToString());
                    List<long> lst = new List<long>();
                    foreach (RedisValue value in arValue) lst.Add(Convert.ToInt64(value));
                    return lst;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(1000);
                }
            }
        }

        public void AddCrcVisited(long companyID, long crcNewLink)
        {
            database.SetAdd("crc_visited:" + companyID.ToString(), crcNewLink);
        }

        public void RemoveCrcVited(long companyID)
        {
            database.KeyDelete("crc_visited:"+companyID.ToString());
        }

        internal void RemoveCompanyCache(long CompanyID)
        {
            database.KeyDelete("cmp_prd:" + CompanyID);
        }
    }

    public class RedisQueueFindNew
    {
        private log4net.ILog _log = log4net.LogManager.GetLogger(typeof(RedisQueueFindNew));
        private RedisServer _redisServer;
        IDatabase _database = null;
        private IDatabase _databaseNew = null;
        static RedisQueueFindNew _objIns = null;
        private RedisQueueFindNew()
        {
            Init();
        }

        public void Init()
        {
            while (_database == null)
            {
                try
                {
                    _redisServer = RedisManager.GetRedisServer("redisQueueFindNew");
                    _database = _redisServer.GetDatabase(14);
                    return;
                }
                catch (Exception ex01)
                {
                    _log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public static RedisQueueFindNew Instance()
        {
            return _objIns ?? (_objIns = new RedisQueueFindNew());
        }

        public void SaveQueue(long companyId, List<JobFindNew> jobs)
        {
            foreach (var lstSub in QT.Entities.Common.SplitArray<JobFindNew>(jobs, 100))
            {
                var arValue = new List<RedisValue>();
                foreach (var str in lstSub) arValue.Add(str.ToJSON());
                while (true)
                {
                    try
                    {
                        _database.SetAdd("fn_q:" + companyId, arValue.ToArray(), CommandFlags.HighPriority);
                        break;
                    }
                    catch (Exception ex)
                    {
                        _log.Error(ex);
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void SaveQueue(long companyId, string[] ProductIDs)
        {
            foreach (var lstSub in QT.Entities.Common.SplitArray<string>(ProductIDs, 100))
            {
                List<RedisValue> arValue = new List<RedisValue>();
                foreach (string str in lstSub) arValue.Add(str);
                while (true)
                {
                    try
                    {
                        _database.SetAdd("cmp_queue:" + companyId.ToString(), arValue.ToArray(), CommandFlags.HighPriority);
                        break;
                    }
                    catch (Exception ex)
                    {
                        _log.Error(ex);
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public IEnumerable<string> ProductOfCompany(long CompanyID)
        {
            while (true)
            {
                try
                {
                    IEnumerable<RedisValue> arValue = _database.SetScan("cmp_queue:" + CompanyID.ToString());
                    List<string> lst = new List<string>();
                    foreach (RedisValue value in arValue) lst.Add(Convert.ToString(value, CultureInfo.InvariantCulture));
                    return lst;
                }
                catch (Exception ex01)
                {
                    _log.Error(ex01);
                    Thread.Sleep(1000);
                }
            }
        }



        public List<string> GetListCrc(long CompanyID)
        {
            while (true)
            {
                try
                {
                    IEnumerable<RedisValue> arValue = _database.SetScan("cmp_queue:" + CompanyID.ToString());
                    List<string> lst = new List<string>();
                    foreach (RedisValue value in arValue) lst.Add(Convert.ToString(value));
                    return lst;
                }
                catch (Exception ex01)
                {
                    _log.Error(ex01);
                    Thread.Sleep(1000);
                }
            }
        }


        public void RemoveCompanyCache(long companyId)
        {
            _database.KeyDelete("cmp_queue:" + companyId.ToString());
        }

    }


    public class RedisDuplicateProduct
    {
        private log4net.ILog _log = log4net.LogManager.GetLogger(typeof(RedisCrcVisitedFindNew));
        private RedisServer _redisServer;
        IDatabase _database = null;
        static RedisDuplicateProduct _objIns = null;

        private RedisDuplicateProduct()
        {
            Init();
        }

        public void Init()
        {
            while (_database == null)
            {
                try
                {
                    _redisServer = RedisManager.GetRedisServer("redisDuplicateProduct");
                    _database = _redisServer.GetDatabase(12);
                    return;
                }
                catch (Exception ex01)
                {
                    _log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public static RedisDuplicateProduct Instance()
        {
            return _objIns == null ? _objIns = new RedisDuplicateProduct() : _objIns;
        }
    }


    public class RedisCrcVisitedFindNew
    {
        private log4net.ILog log = log4net.LogManager.GetLogger(typeof(RedisCrcVisitedFindNew));
        private RedisServer redisServer;
        IDatabase database = null;
        static RedisCrcVisitedFindNew _objIns = null;
        private RedisCrcVisitedFindNew()
        {
            Init();
        }

        public void Init()
        {
            while (database == null)
            {
                try
                {
                    redisServer = RedisManager.GetRedisServer("redisVisitedCrcFN");
                    database = redisServer.GetDatabase(12);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public static RedisCrcVisitedFindNew Instance()
        {
            return _objIns == null ? _objIns = new RedisCrcVisitedFindNew() : _objIns;
        }
       

        public List<long> GetListCrc(long CompanyID)
        {
            while (true)
            {
                try
                {
                    IEnumerable<RedisValue> arValue = database.SetScan("crc_visited:" + CompanyID.ToString());
                    List<long> lst = new List<long>();
                    foreach (RedisValue value in arValue) lst.Add(Convert.ToInt64(value));
                    return lst;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(1000);
                }
            }
        }

        public void SetForCompany(long companyID, long crcNewLink)
        {
            while (true)
            {
                try
                {
                    database.SetAdd("crc_visited:" + companyID.ToString(), crcNewLink);
                    break;
                }
                catch (Exception ex)
                {
                    log.Error("Sleep 5s. " + ex.Message + ex.StackTrace);
                    Thread.Sleep(5000);
                }
            }

        }

        public void SetForCompany(long companyID, List<long> crcNewLink)
        {
            var arListCrc = QT.Entities.Common.SplitArray<long>(crcNewLink.ToArray(), 100);
            foreach (var listCrc in arListCrc)
            {
                while (true)
                {
                    try
                    {
                        RedisValue[] arVlaue = new RedisValue[listCrc.Count];
                        for (int i=0;i<listCrc.Count;i++) arVlaue[i]=listCrc[i];
                        database.SetAdd("crc_visited:" + companyID.ToString(), arVlaue);
                        break;
                    }
                    catch (Exception ex)
                    {
                        log.Error("Sleep 5s. " + ex.Message + ex.StackTrace);
                        Thread.Sleep(5000);
                    }
                }
            }
        }

        public void RemoveCrcVited(long companyID)
        {
            while (true)
            {
                try
                {
                    database.KeyDelete("crc_visited:" + companyID.ToString());
                    break;
                }
                catch (Exception ex)
                {
                    log.Error("Sleep 5s. " + ex.Message + ex.StackTrace);
                    Thread.Sleep(5000);
                }
            }
        }
    }
}
