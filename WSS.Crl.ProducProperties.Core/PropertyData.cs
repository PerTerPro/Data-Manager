using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using QT.Entities;

namespace WSS.Crl.ProducProperties.Core
{
    public class PropertyData
    {

       
        public PropertyData()
        {
            Properties=new Dictionary<string, string>();
            this.ProductId = 0;
            this.Category = "";
        }

        [BsonElement("_id")]
        public ObjectId _id { get; set; }


        [BsonElement("product_id")]
        public long ProductId { get; set; }


        [BsonElement("category")]
        public string Category { get; set; }


        [BsonElement("category_id")]
        public long CategoryId { get; set; }


        [BsonElement("domain")]
        public string Domain { get; set; }


        [BsonElement("properties")]
        public Dictionary<string, string> Properties { get; set; }

         [BsonElement("url")]
         public string Url { get; set; }

         [BsonElement("company_id")]
         public long CompanyID { get; set; }

        [BsonElement("lastModified")]
         public DateTime LastModified { get; set; }

        public string GetJSon()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PropertyData FromJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PropertyData>(str);
        }

        public string GetJSonDisplay()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

       
    }
}
