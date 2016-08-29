using QT.Entities.CrawlerProduct;
using QT.Moduls.Crawler;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlProd
{
    public class QueueWaitRedis : IQueueWait
    {
        private IDatabase redisDb;
        private string nameQueue;
        private int typeCrawler;
        private long company;
        private RedisSession redisSession;

        public QueueWaitRedis(long company, int typeCrawler)
        {
            var redisMultiplexer = ConnectionMultiplexer.Connect(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port);
            this.redisDb = redisMultiplexer.GetDatabase(1);
            this.nameQueue = "crl_prod:queue_wait:" + typeCrawler + ":" + company;
            this.company = company;
            this.typeCrawler = typeCrawler;
            this.redisSession = new RedisSession();
        }

        public void PushJob(Job mss)
        {
            string a = Newtonsoft.Json.JsonConvert.SerializeObject(mss);
            this.redisDb.ListLeftPush(nameQueue, a);
            this.redisSession.IncrFieldLengthQueue(company, typeCrawler);
        }

        public Job GetJob()
        {
            try
            {
                RedisValue a = this.redisDb.ListRightPop(nameQueue);
                this.redisSession.Decrfield(company, typeCrawler);
                if (!a.HasValue) return null;
                else  return Newtonsoft.Json.JsonConvert.DeserializeObject<Job>(a.ToString());
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Clean()
        {
            this.redisDb.KeyDelete(this.nameQueue);
        }
    }
}
