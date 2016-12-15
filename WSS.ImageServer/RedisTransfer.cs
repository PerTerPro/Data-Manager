using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;
using Websosanh.Core.Drivers.Redis;

namespace WSS.ImageServer
{
    public class RedisTransfer
    {
        private readonly IDatabase _database;
        private const string KeyData = "landing_page";


        public RedisTransfer()
        {
            this._database = RedisManager.GetRedisServer("RedisImbo").GetDatabase(0);
            //fghfghfg
        }

        public bool CheckExit(long advId )
        {
            return this._database.SetContains(KeyData, advId);
        }

        public void SetTrans(long advId)
        {
             this._database.SetAdd(KeyData, advId);
        }
    }
}
