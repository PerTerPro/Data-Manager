using QT.Entities.CrawlerProduct;
using QT.Entities.Model.SaleNews;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QT.Entities.Data
{
    public class RedisCreator
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(RedisCreator));
        ConnectionMultiplexer connectionMutilexer;

        private RedisCreator()
        {
            this.connectionMutilexer = ConnectionMultiplexer.Connect(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port);
            this.redisDB = this.connectionMutilexer.GetDatabase();
        }
    
        public RedisCreator(IDatabase redisDb)
        {
            this.redisDB = redisDb;

        }





      
        private IDatabase redisDB;
        private string p1;
        private int p2;



    
        private RedisCreator(string p1, int p2)
        {
            this.connectionMutilexer = ConnectionMultiplexer.Connect(p1);
            this.redisDB = this.connectionMutilexer.GetDatabase(p2);
        }

        public static RedisCreator CreateInstance(string p1, int p2)
        {
            return new RedisCreator(p1, p2);
        }

        public static RedisCrawlerProduct CreateInstance()
        {
            return new RedisCrawlerProduct(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port, 0);
        }

    }
}