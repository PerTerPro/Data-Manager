using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;

namespace WSS.Crl.ProducProperties.Core
{
    public class MongoAdapter
    {
        private static MongoAdapter _ins;
        private IMongoCollection<BsonDocument> collection = null;
        private IMongoDatabase _database = null;
        private ILog _log = log4net.LogManager.GetLogger(typeof (MongoAdapter));

        private MongoAdapter()
        {
            MongoDB.Driver.IMongoClient mongoClient = new MongoClient("mongodb://192.168.100.34:27017");
            _database = mongoClient.GetDatabase("property_data");
            this.collection = _database.GetCollection<BsonDocument>("product_property");
        }

        public static MongoAdapter Instance()
        {
            return (_ins) ?? new MongoAdapter();
        }


        public async void UpdateCategoryId()
        {
            var filter = new BsonDocument();
            var count = 0;
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {var propertyData = BsonSerializer.Deserialize<PropertyData>(document);
                        if (propertyData != null)
                        {
                            if (propertyData.ProductId == 0)
                            {
                                this.collection.DeleteOne(document);
                                this._log.Info(string.Format("Delete item"));
                            }
                            else
                            {
                                propertyData.CategoryId = Common.CrcProductID(propertyData.Category);
                                var update = Builders<BsonDocument>.Update
                                    .Set("category_id", propertyData.CategoryId)
                                    .CurrentDate("lastModified");
                                this.collection.UpdateOne(document, update);
                                _log.Info(string.Format("Updated for item {0} {1}",propertyData._id, propertyData.ProductId));
                            }
                        }
                        else
                        {
                            _log.Info("ProductData null");
                        }

                        _log.Info(string.Format("Process {0} items ", count));
                        count++;
                    }
                }
            }
        }

        public async void FattenData ()
        {
           ProductPropertiesAdapter productPropertiesAdapter = new ProductPropertiesAdapter();
            var filter = new BsonDocument();
            var count = 0;
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        var propertyData = BsonSerializer.Deserialize<PropertyData>(document);
                        if (propertyData != null)
                        {
                            productPropertiesAdapter.FattanToSql(propertyData);
                        }
                        count++;
                        _log.Info(string.Format("Processed {0}", count));
                    }
                }
            }
        }

        public void SaveProperties(PropertyData propertyData)
        {
            BsonDocument bSon = propertyData.ToBsonDocument();
            this.collection.InsertOne(bSon);
        }

        public void DelPropertyData(long p)
        {
            string str = "{ product_id : "+p+ " }";
            this.collection.DeleteOne(str);
        }
    }
}
