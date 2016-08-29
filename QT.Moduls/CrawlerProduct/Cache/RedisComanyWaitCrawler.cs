using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.Redis;

namespace QT.Moduls.CrawlerProduct.Cache
{
    public class CompanyWait
    {
        public long CompanyID { get; set; }
        public DateTime DateRun { get; set; }

        public int Wait { get; set; }
    }



    public class RedisCompanyWaitCrawler
    {
        RedisCacheCompanyCrawler redisCacheCompanyCrawler = RedisCacheCompanyCrawler.Instance();
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(RedisCacheCompanyCrawler));
        IDatabase database = null;
        static RedisCompanyWaitCrawler objIns;
        private Entities.Data.SqlDb sqlDb;
        private RedisServer redisServer;
        private long MIN_TO_CHECK_RUNNING = 5;

        public RedisCompanyWaitCrawler()
        {
            Init();
        }


        public static RedisCompanyWaitCrawler Instance()
        {
            return objIns == null ? objIns = new RedisCompanyWaitCrawler() : objIns;
        }

        public void Init()
        {
            while (database == null)
            {
                try
                {
                    redisServer = RedisManager.GetRedisServer("redisCompanyWaitCrawler");
                    database = redisServer.GetDatabase(9);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public List<CompanyWait> GetWaitingCrawlerReload(bool onlyNeedRun=true, int maxItem = 100)
        {
            var current = Convert.ToInt64(DateTime.Now.ToString("yyMMddHHmm"));
            var companys = new List<CompanyWait>();
            var arCompany = database.SortedSetRangeByRankWithScores("cmp_w_rl", 0, maxItem, Order.Ascending);
            foreach (var item in arCompany)
            {
                var score = item.Score.ToString();
                var next = new DateTime(Convert.ToInt32("20" + score.Substring(0, 2)), Convert.ToInt32(score.Substring(2, 2)), Convert.ToInt32(score.Substring(4, 2)), Convert.ToInt32(score.Substring(6, 2)), 0, 0);
                if (!onlyNeedRun || item.Score < current) companys.Add(new CompanyWait()
                {
                    CompanyID = Convert.ToInt64(item.Element),
                    DateRun = next,
                    Wait=(int)(next-DateTime.Now).TotalMinutes
                });
            }
            return companys;
        }

        public List<CompanyWait> GetWaitingCrawlerFindNew(bool onlyNeedRun = true, int maxItem = 100)
        {
            var current = Convert.ToInt64(DateTime.Now.ToString("yyMMddHHmm"));
            var companys = new List<CompanyWait>();
            var arCompany = database.SortedSetRangeByRankWithScores("cmp_w_fn", 0, maxItem, Order.Ascending);
            foreach (var item in arCompany)
            {
                var score = item.Score.ToString(CultureInfo.InvariantCulture);
                var next = new DateTime(Convert.ToInt32("20" + score.Substring(0, 2)),
                    Convert.ToInt32(score.Substring(2, 2)), Convert.ToInt32(score.Substring(4, 2)),
                    Convert.ToInt32(score.Substring(6, 2)), 0, 0);
                if (!onlyNeedRun || item.Score < current)
                    companys.Add(new CompanyWait()
                    {
                        CompanyID = Convert.ToInt64(item.Element),
                        DateRun = next,
                        Wait = (int) (next - DateTime.Now).TotalMinutes
                    });
            }
            return companys;
        }


        public List<QT.Moduls.CrawlerProduct.Cache.CompanyRunning> GetRunningCompany()
        {
            long current = Convert.ToInt64(DateTime.Now.ToString("yyMMddHHmm"));
            List<QT.Moduls.CrawlerProduct.Cache.CompanyRunning> companys = new List<QT.Moduls.CrawlerProduct.Cache.CompanyRunning>();
            SortedSetEntry[] arCompany = database.SortedSetRangeByRankWithScores("cmp_running", 0, 1000, Order.Descending);
            foreach (var item in arCompany)
            {
                if (Math.Abs(item.Score - current) < MIN_TO_CHECK_RUNNING)
                {
                    long CompanyID = Convert.ToInt64(item.Element);
                    companys.Add(new CompanyRunning()
                    {
                        ID = Convert.ToInt64(item.Element),
                        LastJob = Math.Abs((int)item.Score - (int)current)
                    });
                }
            }
            return companys;
        }


        public Dictionary<long, long> GetCompanyRunningCrawler()
        {
            Dictionary<long, long> dic = new Dictionary<long, long>();
            long current = Convert.ToInt64(DateTime.Now.ToString("yyMMddHHmm"));
            SortedSetEntry[] arCompany = database.SortedSetRangeByRankWithScores("cmp_running", 0, 1000, Order.Descending);
            foreach (var item in arCompany)
            {
                if (Math.Abs(item.Score - current) < 5)
                {
                    long CompanyID = Convert.ToInt64(item.Element);
                    dic.Add(Convert.ToInt64(item.Element), Convert.ToInt64(item.Score));
                }
            }
            return dic;
        }

        public bool CheckRunningCrawler(long CompanyID)
        {
            while (true)
            {
                try
                {
                    double? lastJob = database.SortedSetScore("cmp_running", CompanyID);
                    if (lastJob == null) return false;
                    else
                    {
                        long current = Convert.ToInt64(DateTime.Now.ToString("yyMMddHHmm"));
                        if (Math.Abs(Convert.ToInt64(lastJob) - current) < MIN_TO_CHECK_RUNNING)
                        {
                            return true;
                        }
                        else return false;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    Thread.Sleep(1000);
                }
            }
        }

        public long GetCompanyCrawlerReload()
        {
            long current = Convert.ToInt64(DateTime.Now.ToString("yyMMddHHmm"));
            List<long> companys = new List<long>();
            SortedSetEntry[] arCompany = database.SortedSetRangeByRankWithScores("cmp_w_rl", 0, 1, Order.Ascending);
            if (arCompany != null && arCompany.Length > 0)
            {
                var item = arCompany[0];
                if (item.Score < current)
                {
                    long companyID = Convert.ToInt64(item.Element);
                    this.SetNexReload(companyID, 1);
                    return companyID;
                }
            }
            return 0;
        }

        public long GetCompanyCrawlerFindNew()
        {
            long current = Convert.ToInt64(DateTime.Now.ToString("yyMMddHHmm"));
            List<long> companys = new List<long>();
            SortedSetEntry[] arCompany = database.SortedSetRangeByRankWithScores("cmp_w_fn", 0, 1, Order.Ascending);
            if (arCompany != null && arCompany.Length > 0)
            {
                var item = arCompany[0];
                long companyID = Convert.ToInt64(item.Element);
                this.SetNexFindNew(companyID, 1);
                return companyID;
            }
            return 0;
        }

        public void SetTimeNextRunFindNew(long CompanyID)
        {
            while (true)
            {
                try
                {
                    DateTime dateNExt = DateTime.Now.AddHours(redisCacheCompanyCrawler.GetMinHourReload(CompanyID));
                    database.SortedSetAdd("cmp_w_fn", CompanyID, Convert.ToDouble(dateNExt.ToString("yyMMddHHmm")));
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void SetNexReload(long CompanyID)
        {
            while (true)
            {
                try
                {
                    DateTime dateNextReload = DateTime.Now.AddHours(redisCacheCompanyCrawler.GetMinHourReload(CompanyID));
                    database.SortedSetAdd("cmp_w_rl", CompanyID, Convert.ToDouble(dateNextReload.ToString("yyMMddHHmm")));
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }
        public void SetNexReload(long CompanyID, int hours)
        {
            while (true)
            {
                try
                {
                    DateTime dateNextReload = DateTime.Now.AddHours(hours);
                    database.SortedSetAdd("cmp_w_rl", CompanyID, Convert.ToDouble(dateNextReload.ToString("yyMMddHHmm")));
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }
        public void SetNexFindNew(long CompanyID, int hours)
        {
            while (true)
            {
                try
                {
                    DateTime dateNextReload = DateTime.Now.AddHours(hours);
                    database.SortedSetAdd("cmp_w_fn", CompanyID, Convert.ToDouble(dateNextReload.ToString("yyMMddHHmm")));
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }
        public void SetRunningCrawler(long CompanyID)
        {
            try
            {
                database.SortedSetAdd("cmp_running", CompanyID, Convert.ToDouble(DateTime.Now.ToString("yyMMddHHmm")));
            }
            catch (Exception ex01)
            {
                log.Error(ex01);
                Thread.Sleep(10000);
            }
        }

        public void SetRemoveRunningCrawler(long CompanyID)
        {
            try
            {
                DateTime dateNExt = DateTime.Now.AddHours(redisCacheCompanyCrawler.GetMinHourReload(CompanyID));
                database.SortedSetRemove("cmp_running", CompanyID);
            }
            catch (Exception ex01)
            {
                log.Error(ex01);
            }

        }

        public void SetCompanyRunningCrawler(long CompanyID, string domain, int Type, DateTime startCrawler, int countVisited, int countQUeue, int countProduct, string session)
        {
            redisCacheCompanyCrawler.SetCurrentRunning(CompanyID, Type, startCrawler, countVisited, countQUeue, countProduct, session);
            database.SortedSetAdd("cmp_running", CompanyID, Convert.ToDouble(DateTime.Now.ToString("yyMMddHHmm")));
        }

        public bool CheckHaveItemReload(long companyID)
        {
            while (true)
            {
                try
                {
                    long? value = database.SortedSetRank("cmp_w_rl", companyID);
                    if (value == null) return false;
                    else return true;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(1000);
                }
            }
        }

        public bool CheckHaveItemFindNew(long companyID)
        {
            long? value = database.SortedSetRank("cmp_w_fn", companyID);
            if (value == null) return false;
            else return true;
        }


        public void SyncCompanyFindNew(List<long> companyIds)
        {
            List<long> companyIdsCache = GetAllCompanysFN();
            List<long> lstAdd = new List<long>();
            List<long> lstDelete = new List<long>();
            foreach (var itemCompany in companyIds)
            {
                if (!companyIdsCache.Contains(itemCompany))
                {
                    lstAdd.Add(itemCompany);
                }
            }
            foreach (var itemCompany in companyIdsCache)
            {
                if (!companyIds.Contains(itemCompany))
                {
                    lstDelete.Add(itemCompany);
                }
            }
            this.SetNexFindNew(lstAdd, DateTime.Now.AddDays(-2));
            this.DeleteWaitFindNew(lstDelete);
            log.Info(string.Format("Sync FindNew: Add {0} Delete {1} TotalCompany: {2}", lstAdd.Count, lstDelete.Count, companyIds.Count));
        }

        public void SyncCompanyReload(List<long> companyIds)
        {
            List<long> companyIdsCache = GetAllCompanysRL();
            List<long> lstAdd = new List<long>();
            List<long> lstDelete = new List<long>();
            foreach (var itemCompany in companyIds)
            {
                if (!companyIdsCache.Contains(itemCompany))
                {
                    lstAdd.Add(itemCompany);
                }
            }
            foreach (var itemCompany in companyIdsCache)
            {
                if (!companyIds.Contains(itemCompany))
                {
                    lstDelete.Add(itemCompany);
                }
            }

            this.SetNexReload(lstAdd, DateTime.Now.AddDays(-2));
            this.DeleteWaitReload(lstDelete);

            log.Info(string.Format("Sync FindNew: Add {0} Delete {1} TotalCompany: {2}", lstAdd.Count, lstDelete.Count, companyIds.Count));
        }

        public void DeleteWaitFindNew(List<long> companyIds)
        {
            while (true)
            {
                try
                {
                    RedisValue[] redisValues = new RedisValue[companyIds.Count];
                    for (int i = 0; i < companyIds.Count; i++) redisValues[i] = companyIds[i].ToString();
                    database.SortedSetRemove("cmp_w_fn", redisValues);
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(100);
                }
            }
        }

        public void DeleteWaitReload(List<long> companyIds)
        {
            while (true)
            {
                try
                {
                    RedisValue[] redisValues = new RedisValue[companyIds.Count];
                    for (int i = 0; i < companyIds.Count; i++) redisValues[i] = companyIds[i].ToString();
                    database.SortedSetRemove("cmp_w_rl", redisValues);
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(100);
                }
            }
        }

        public List<long> GetAllCompany()
        {
            List<long> lstCompany = new List<long>();
            List<long> companys = new List<long>();
            SortedSetEntry[] arCompany = database.SortedSetRangeByRankWithScores("cmp_w_rl", 0, -1, Order.Ascending);
            foreach (var item in arCompany)
            {
                lstCompany.Add(Convert.ToInt64(item.Element));
            }
            return lstCompany;
        }

        public Dictionary<long, long> GetAllCompanyAndTimeRL()
        {
            Dictionary<long, long> lstCompany = new Dictionary<long, long>();
            List<long> companys = new List<long>();
            SortedSetEntry[] arCompany = database.SortedSetRangeByRankWithScores("cmp_w_rl", 0, -1, Order.Ascending);
            foreach (var item in arCompany)
            {
                lstCompany.Add(Convert.ToInt64(item.Element), Convert.ToInt64(item.Score));
            }
            return lstCompany;

        }

        public Dictionary<long, long> GetAllCompanyAndTimeFN()
        {
            Dictionary<long, long> lstCompany = new Dictionary<long, long>();
            List<long> companys = new List<long>();
            SortedSetEntry[] arCompany = database.SortedSetRangeByRankWithScores("cmp_w_fn", 0, -1, Order.Ascending);
            foreach (var item in arCompany)
            {
                lstCompany.Add(Convert.ToInt64(item.Element), Convert.ToInt64(item.Score));
            }
            return lstCompany;
        }

        public List<long> GetAllCompanysFN()
        {
            while (true)
            {
                try
                {
                    List<long> companys = new List<long>();
                    RedisValue[] arCompany = database.SortedSetRangeByRank("cmp_w_fn", 0, -1, Order.Ascending);
                    foreach (var item in arCompany)
                    {
                        companys.Add(Convert.ToInt64(item));
                    }
                    return companys;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    Thread.Sleep(10000);
                }
            }
        }

        public List<long> GetAllCompanysRL()
        {
            while (true)
            {
                try
                {
                    List<long> companys = new List<long>();
                    RedisValue[] arCompany = database.SortedSetRangeByRank("cmp_w_rl", 0, -1, Order.Ascending);
                    foreach (var item in arCompany)
                    {
                        companys.Add(Convert.ToInt64(item));
                    }
                    return companys;
                }

                catch (Exception ex)
                {
                    log.Error(ex);
                    Thread.Sleep(10000);
                }
            }
        }

        public static void CloseConnect()
        {

        }

        public void RemoveCompanyReload(long companyID)
        {
            database.SortedSetRemove("cmp_w_rl", companyID);
        }

        public void RemoveCompanyFindNew(long companyID)
        {
            database.SortedSetRemove("cmp_w_fn", companyID);
        }

        public void SetNexFindNew(long companyID)
        {
            while (true)
            {
                try
                {
                    DateTime dateNextReload = DateTime.Now.AddHours(redisCacheCompanyCrawler.GetMinHourReload(companyID));
                    database.SortedSetAdd("cmp_w_rl", companyID, Convert.ToDouble(dateNextReload.ToString("yyMMddHHmm")));
                    break;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void LoadDataWait(Entities.CrawlerProduct.Cache.CompanyCache item)
        {
            try
            {
                double? value = database.SortedSetScore("cmp_w_rl", item.Id);
                if (value!=null)
                {
                    item.InQueue_FindNew = true;
                    item.Time_NextFindNew = Convert.ToDouble(value);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void SetNexReload(List<long> companyIDS, DateTime dateTime)
        {
            foreach (var arSubCompany in QT.Entities.Common.SplitArray<long>(companyIDS.ToArray(), 100))
            {
                List<SortedSetEntry> lst = new List<SortedSetEntry>();
                foreach (var item in arSubCompany) lst.Add(new SortedSetEntry(item, Convert.ToInt64(dateTime.ToString("yyMMddHHmm"))));
                database.SortedSetAdd("cmp_w_rl", lst.ToArray());
            }
        }

        public void SetNexFindNew(List<long> companyIDS, DateTime dateTime)
        {
            foreach (var arSubCompany in QT.Entities.Common.SplitArray<long>(companyIDS.ToArray(), 100))
            {
                List<SortedSetEntry> lst = new List<SortedSetEntry>();
                foreach (var item in arSubCompany) lst.Add(new SortedSetEntry(item, Convert.ToInt64(dateTime.ToString("yyMMddHHmm"))));
                database.SortedSetAdd("cmp_w_fn", lst.ToArray());
            }
        }
    }
}
