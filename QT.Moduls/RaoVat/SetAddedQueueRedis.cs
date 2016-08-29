using QT.Moduls.Crawler;
using QT.Moduls.CrawlProd;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlSale
{
    public class SetAddedQueueRedis : ISetAddedVisited
    {
        private IDatabase redisDb;
        private string nameSet;
        public SetAddedQueueRedis(string setName)
        {
            var redisMultiplexer = ConnectionMultiplexer.Connect(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port);
            this.redisDb = redisMultiplexer.GetDatabase(4);
            this.nameSet = setName;
        }

        public SetAddedQueueRedis(long company, int typeCrawler)
        {
            var redisMultiplexer = ConnectionMultiplexer.Connect(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port);
            this.redisDb = redisMultiplexer.GetDatabase(4);
            this.nameSet = "crl_sale:set_visited_url:" + typeCrawler + ":" + company;
        }

        public bool Exists(int crcLink)
        {
            int iCount = 0;
            try
            {
                return this.redisDb.SetContains(nameSet, crcLink.ToString());
            }
            catch (Exception ex)
            {
                iCount++;
                if (iCount > 3) throw ex;
            }
            return false;
        }

        public void Add(int crcLink, string a)
        {
            int iCount = 0;
            try
            {
                this.redisDb.SetAdd(this.nameSet, crcLink.ToString());
            }
            catch (Exception ex)
            {
                iCount++;
                if (iCount > 3) throw ex;
            }
        }

        public void Clean()
        {
            this.redisDb.KeyDelete(this.nameSet);
        }



    }
}
