using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using WSS.Crl.ProducProperties.Core;
using NUnit.Framework;
using System.IO;
using log4net.Util;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WSS.Crl.ProducProperties.Core.Tests
{
    [TestFixture()]
    public class MongoDbTest
    {
     
        [Test()]
        public void MongoDbConnection()
        {
            var client = new MongoClient("mongodb://192.168.100.34:27017");
            var databases = client.GetDatabase("test_db");
            var collection = databases.GetCollection<BsonDocument>("col1");
            var bsonDocument = new BsonDocument()
            {
                {"name", "trang"}
            };
            collection.InsertOne(bsonDocument);
         
        }


    }
}
