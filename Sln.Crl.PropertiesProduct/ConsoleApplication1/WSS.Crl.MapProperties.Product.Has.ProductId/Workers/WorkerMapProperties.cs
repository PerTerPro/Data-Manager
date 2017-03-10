using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Crl.MapProperties.Product.Has.ProductId.Entity;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using log4net;
using StackExchange.Redis;
using Websosanh.Core.Drivers.Caching;
using MongoDB.Driver;
using Websosanh.Core.Drivers.Redis;
using WSS.LibExtra;

namespace WSS.Crl.MapProperties.Product.Has.ProductId.Workers
{
    public class WorkerMapProperties : QueueingConsumer
    {
        private static ILog log = LogManager.GetLogger(typeof(WorkerMapProperties));
        private IDatabase database = null;
        private const string NameCollection = "product_property";
        private const string NameDatabase = "property_data";
        private const string KeyMongo = "MongoDbProductProperty";

        private readonly IMongoDatabase _database = null;
        private readonly IMongoCollection<PropertyProduct> _collection;
        private CacheServer _cacheMan;
        string _connectionString;
        string _connectionString178;
        public WorkerMapProperties()
            : base(RabbitMQManager.GetRabbitMQServer("rabbitMQ177"), "RootProduct.Has.Property", false)
        {
            MongoDB.Driver.IMongoClient mongoClient = new MongoClient("mongodb://192.168.100.34:27017");
            _database = mongoClient.GetDatabase(NameDatabase);
            _collection = this._database.GetCollection<PropertyProduct>(NameCollection);
            _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            _connectionString178 = ConfigurationManager.AppSettings["ConnectionString178"];
            this.database = RedisManager.GetRedisServer("redisPropertiesProduct").GetDatabase(1);
            this._cacheMan = CacheManager.GetCacheServer("redisPropertiesProduct");
        }
        public override void ProcessMessage(RabbitMQ.Client.Events.BasicDeliverEventArgs message)
        {

            var msRootProduct = MsRootProduct.FromJson(Encoding.UTF8.GetString(message.Body));
            var isSave = MapProperties(msRootProduct.RootID);
            this.GetChannel().BasicAck(message.DeliveryTag, true);
        }

        public override void Init()
        {

        }
        public bool MapProperties(int RootId)
        {
            var isDone = false;
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var lstRootProperties = db.Query<RootProperty>(@"select a.ProductID,
                                                                    a.PropertiesID,
                                                                    a.PropertiesGroupID,
                                                                    a.PropertiesValueID,
                                                                    b.Name,
                                                                    c.Value,
                                                                    b.Unit
                                                                     from Product_Properties a
                                                                     inner join Properties b 
                                                                     on a.PropertiesID = b.ID
                                                                     inner join PropertiesValue c 
                                                                     on a.PropertiesValueID = c.ID where a.ProductID = @ProductID order by a.STT",
                                                                     new { ProductID = RootId }).ToList();
                if (lstRootProperties != null && lstRootProperties.Count > 0)
                {
                    var lstProductByRoot = db.Query<Entity.Product>("select a.ID,a.Company,a.ProductID,b.Domain,a.DetailUrl,a.ImageUrls,a.ClassificationID,a.CategoryID from Product a inner join Company b on a.Company = b.ID where a.ProductID = @ProductID",
                    new { ProductID = RootId }).ToList();

                    foreach (var item in lstProductByRoot)
                    {
                        PropertyProduct productProperty = new PropertyProduct();
                        productProperty.ProductId = item.ID;
                        ////string ClassificationName = db.Query<string>("Select Name from Classification where ID = @ID", new { ID = item.ClassificationID }).FirstOrDefault();
                        foreach (var property in lstRootProperties)
                        {
                            //string PropertyName = ClassificationName + ":" + property.Name.ToString();
                            //string PropertyValue = property.Value.ToString();
                            //long PropertyID = CommonConvert.CrcProductID(PropertyName);
                            try
                            {
                                if (!string.IsNullOrEmpty(property.Unit))
                                {
                                    property.Value = property.Value + " " + property.Unit;
                                    property.Value += " " + property.Unit;
                                }
                                productProperty.Properties.Add(property.Name, property.Value);
                                SaveProperiesProduct(productProperty);

                                log.InfoFormat("Product: {0} Map Success!", productProperty.ProductId);
                                isDone = true;
                            }
                            catch (Exception ex01)
                            {
                                log.ErrorFormat("Product: {0} Map error {1}", productProperty.ProductId, ex01);
                                isDone = false;
                            }

                        }
                    }
                }
            }
            return isDone;

        }
        public List<Entity.Product> MapPropertiesPagging(int RootId)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<Entity.Product>("select a.ID,a.Company,a.ProductID,b.Domain,a.DetailUrl,a.ImageUrls,a.ClassificationID,a.CategoryID from Product a inner join Company b on a.Company = b.ID where a.ProductID = @ProductID",
                    new { ProductID = RootId }).ToList();
            }
        }
        public void SaveProperiesProduct(PropertyProduct propertyData)
        {
            //string queryDelete = "{product_id:NumberLong(" + propertyData.ProductId + ")}";
            //this._collection.DeleteMany(queryDelete);
            //try
            //{
            //    this._collection.InsertOne(propertyData);
            //}
            //catch (Exception ex)
            //{
            //    log.Info(ex);
            //}
            //SaveToRedis
            var properties = propertyData.Properties.Select(variable => new KeyValuePair<string, string>(variable.Key, variable.Value)).ToList();
            _cacheMan.Set("prs:" + propertyData.ProductId, properties, true, new TimeSpan(20000, 0, 0, 0));
            //database.SetAdd(propertyData.ProductId.ToString(), x);
        }
        public void SavePropertiesProductToSql()
        {

        }
    }
}
