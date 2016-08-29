using QT.Entities;
using ServiceStack.Logging;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.Redis;

namespace QT.Moduls.CrawlerProduct.Cache
{
    public class RedisCacheCompanyCrawler
    {
        readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(RedisCacheCompanyCrawler));
        IDatabase _database = null;
        static RedisCacheCompanyCrawler objIns;
        private Entities.Data.SqlDb sqlDb;
        private string p;
        private RedisServer _redisServer;

        public RedisCacheCompanyCrawler()
        {
            Init();
        }

        public static RedisCacheCompanyCrawler Instance()
        {
            return objIns ?? (objIns = new RedisCacheCompanyCrawler());
        }

        public void Init()
        {
            while (_database == null)
            {
                try
                {
                    _redisServer = RedisManager.GetRedisServer(ConfigRun.KeyRedisCrawlerProduct);
                    _database = _redisServer.GetDatabase(8);
                    return;
                }
                catch (Exception ex01)
                {
                    _log.Error(ex01);
                    Thread.Sleep(new Random().Next(0, 10000));
                }
            }
        }

        public void SetCompanyInfo(long CompanyID, string Domain, int MinHourReload, int MinHourFindNew)
        {
            while (true)
            {
                try
                {
                    _database.HashSet("cmp:" + CompanyID, new HashEntry[]{
                 new HashEntry("MinHourReload",MinHourReload),
                 new HashEntry("MinHourFindNew",MinHourFindNew),
                 new HashEntry("Domain",Domain)
            });
                    break;
                }
                catch (Exception ex01)
                {
                    _log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public int GetMinHourReload(long CompanyID)
        {
            try
            {
                return Convert.ToInt32(_database.HashGet("cmp:" + CompanyID, "MinHourReload"));
            }
            catch (Exception ex01)
            {
                return 24;
            }
        }

        internal void SetCurrentRunning(long CompanyID, int TypeCrawler, DateTime startCrawler, int countVisited, int countQUeue, int countProduct, string session)
        {
            try
            {
                _database.HashSet("cmp:" + CompanyID, new HashEntry[]{
                 new HashEntry("TypeCrawler",TypeCrawler.ToString()),
                 new HashEntry("Start",startCrawler.ToString("yyyy-MM-dd HH:mm:ss")),
                 new HashEntry("CountVisited",countVisited.ToString()),
                 new HashEntry("CountQueue",countQUeue.ToString()),
                 new HashEntry("CountProduct",countProduct.ToString()),
                 new HashEntry("LastJobCrawler",DateTime.Now.ToString("yyyy-MM-dd HH:mm")),
                 new HashEntry("Session",session)
                });
            }
            catch (Exception ex01)
            {
                _log.Error(ex01);
                Thread.Sleep(10000);
            }
        }

        public string GetSessionCrawlerRunning(long companyID)
        {
            try
            {
                RedisValue redisValueLastJobCrawler = _database.HashGet("cmp:" + companyID, "LastJobCrawler", CommandFlags.HighPriority);
                RedisValue redisValueSession = _database.HashGet("cmp:" + companyID, "Session", CommandFlags.HighPriority);
                if (redisValueLastJobCrawler.HasValue && redisValueSession.HasValue && (DateTime.Now - (Convert.ToDateTime(redisValueLastJobCrawler))).TotalMinutes < 15)
                {
                    return redisValueSession.ToString();
                }
                else return "";
            }
            catch (Exception ex01)
            {
                return "";
            }
        }

        internal DateTime GetLastCrawler(long CompanyID)
        {
            return Convert.ToDateTime(_database.HashGet("cmp:" + CompanyID, "Start"));
        }

        internal string GetDomain(long CompanyID)
        {
            return Convert.ToString(_database.HashGet("cmp:" + CompanyID, "Domain"));
        }

        internal int GetInfoCrawler_CountVisited(long CompanyID)
        {
            return Convert.ToInt32(_database.HashGet("cmp:" + CompanyID, "CountVisited"));
        }

        internal int GetInfoCrawler_CountQueue(long CompanyID)
        {
            return Convert.ToInt32(_database.HashGet("cmp:" + CompanyID, "CountQueue"));
        }

        internal int GetInfoCrawler_CountProduct(long CompanyID)
        {
            try
            {
                return Convert.ToInt32(_database.HashGet("cmp:" + CompanyID, "CountProduct"));
            }
            catch (Exception ex01)
            {
                return -1;
            }
        }

        public DateTime GetLastCache()
        {
            throw new NotImplementedException();
        }

        public void GetAllCompany()
        {
            
        }

        public DateTime GetLastClearQueueCrawler(long companyID)
        {
            try
            {
                return Convert.ToDateTime(_database.HashGet("cmp:" + companyID, "CountProduct"));
            }
            catch (Exception ex01)
            {
                return DateTime.Now;
            }
        }

        public void SetLastClear(long companyID)
        {
            try
            {
                _database.HashSet("cmp:" + companyID, "lst_clr_q", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
            }
            catch (Exception ex01)
            {
            }
        }
    }
}
