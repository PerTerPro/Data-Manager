using System;
using System.Configuration;
using System.Threading.Tasks;
using MongoDB.Driver;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.LibExtra;

namespace WSS.Crl.ProducProperties.Core.Storage
{
    public class StorageHtmlMongo : IStorageHtml
    {
        private const string NameCollection = "html_product";
        private const string NameDatabase = "property_data";
        private const string KeyMongo = "MongoDbProductProperty";

        private readonly IMongoDatabase _database = null;
        private readonly IMongoCollection<HtmlProduct> _collection;
        private IProducerBasic producerBasic = null;
        public  StorageHtmlMongo ()
        {
            //IMongoDatabase database;
            //MongoDB.Driver.IMongoClient mongoClient = new MongoClient(ConfigurationManager.AppSettings[KeyMongo]);
            //this._database = mongoClient.GetDatabase(NameDatabase);
            //this._collection = this._database.GetCollection<HtmlProduct>(NameCollection);
        }

        public void SaveHtml(HtmlProduct htmlProduct){
            string queryDelete = "{product_id:NumberLong(" + htmlProduct.ProductId + ")}";
            //htmlProduct.HtmlZip = (new WSS.LibExtra.UtilZipFile()).ZipOfEncode(htmlProduct.Html);
            //htmlProduct.HtmlZip = (new WSS.LibExtra.UtilZipFile()).UnzipOfEncode(htmlProduct.Html);
            //this._collection.DeleteMany(queryDelete);
            //this._collection.InsertOne(htmlProduct);

            if (producerBasic != null)
            {
               
            }
        }

        public void DeleteHtml(long productId)
        {
            var result = this._collection.DeleteMany("{product_id:NumberLong(" + productId + ")}");
            var x = result.DeletedCount;
        }

        public  HtmlProduct GetHtml(long productId)
        {
            try
            {
                var x = this._collection.FindAsync("{product_id:NumberLong(" + productId + ")}");
                return x.Result.Single();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
