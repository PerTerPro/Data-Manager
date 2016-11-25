using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using StackExchange.Redis;
using Websosanh.Core.Drivers.Redis;
using QT.Entities;

namespace WSS.IndividualCategoryWebsites.DataTeam
{
    public class BlackListProductDataAccess
    {
        static ILog Log = LogManager.GetLogger(typeof(BlackListProductDataAccess));
        static IDatabase _database = RedisManager.GetRedisServer("redisBlackListProduct").GetDatabase(2);
        public BlackListProductDataAccess()
        {
            
        }

        public List<long> GetBlackListProducts()
        {
            var result = _database.SetMembers("BlackListId").ToList();
            return result.Select(item => Common.Obj2Int64(item)).ToList();
        }

        public void SetProductToBlackList(long idProduct)
        {
            _database.SetAdd("BlackListId", new RedisValue[] {idProduct});
        }

        public void SetListProductToBlackList(List<long> listProducts)
        {
            _database.SetAdd("BlackListId", listProducts.Select(item => (RedisValue) item).ToArray());
        }
    }
}
