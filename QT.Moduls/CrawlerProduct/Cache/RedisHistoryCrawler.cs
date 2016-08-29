using ServiceStack.Logging;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.Redis;

namespace QT.Moduls.CrawlerProduct.Cache
{
    public class HistoryCrawler
    {
        public string Start { get; set; }

        public string Session { get; set; }
    }

    class RedisHistoryCrawler
    {



        RedisServer redisServer = null;
        IDatabase database = null;

        public RedisHistoryCrawler()
        {
     
            redisServer = RedisManager.GetRedisServer("redisCacheCrawlerDuplicate");
            database = redisServer.GetDatabase(10);
            
        }


        public List<HistoryCrawler> GetHistoryCompany(string CompanyID)
        {
            List<HistoryCrawler> lstHistory = new List<HistoryCrawler>();
            HashEntry[] arHistory = database.HashGetAll("hcrl:" + CompanyID.ToString());
            foreach (var item in arHistory)
            {
            }
            return null;
        }
    }
}
