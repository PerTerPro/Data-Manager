using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;
using Websosanh.Core.Drivers.Redis;

namespace CrawlerLinkBook
{
    public class HashVisited
    {
        IDatabase _database = RedisManager.GetRedisServer(ConfigDownloadBook.KeyRedisManager).GetDatabase(10);
        string keySet = "bookit.info";

        public bool CheckVisited (long crc)
        {
            return _database.SetContains(keySet, crc);
        }

        public void SetCrcVisited (long crc)
        {
             _database.SetAdd(keySet, crc);
        }


    }
}
