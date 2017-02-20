using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Driver;
using StackExchange.Redis;
using Websosanh.Core.Drivers.Caching;
using Websosanh.Core.Drivers.Redis;
using WSS.Crl.ProducProperties.Core.Entity;

namespace WSS.Crl.ProducProperties.Core.Storage
{
    public class StoragePropertiesProductMongo : IStoragePropertiesProduct
    {
        private IDatabase database = null;
        private const string NameCollection = "product_property";
        private const string NameDatabase = "property_data";
        private const string KeyMongo = "MongoDbProductProperty";

        private readonly IMongoDatabase _database = null;
        private readonly IMongoCollection<PropertyProduct> _collection;
        private CacheServer _cacheMan;

        public StoragePropertiesProductMongo()
        {
            MongoDB.Driver.IMongoClient mongoClient = new MongoClient(ConfigurationManager.AppSettings[KeyMongo]);
            this._database = mongoClient.GetDatabase(NameDatabase);
            this._collection = this._database.GetCollection<PropertyProduct>(NameCollection);

            this.database = RedisManager.GetRedisServer("redisPropertiesProduct").GetDatabase(1);
            this._cacheMan = CacheManager.GetCacheServer("redisPropertiesProduct");
        }
        public void SaveProperiesProduct(PropertyProduct propertyData)
        {
            string queryDelete = "{product_id:NumberLong(" + propertyData.ProductId + ")}";
            this._collection.DeleteMany(queryDelete);
            this._collection.InsertOne(propertyData);

            //SaveToRedis
            var properties = propertyData.Properties.Select(variable => new KeyValuePair<string, string>(variable.Key, variable.Value)).ToList();
            _cacheMan.Set("prs:" + propertyData.ProductId, properties, true, new TimeSpan(20000, 0, 0, 0));
            //database.SetAdd(propertyData.ProductId.ToString(), x);
        }

        public async Task<PropertyProduct> GetProperiesProduct(long productId)
        {
            var x = await this._collection.FindAsync("{product_id:NumberLong(" + productId + ")}");
            return x.FirstOrDefault(new CancellationToken(true));
        }

        public void DelProperiesProduct(long productId)
        {
            string queryDelete = "{product_id:NumberLong(" + productId + ")}";
            this._collection.DeleteMany(queryDelete);
        }
    }
}
