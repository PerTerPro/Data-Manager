using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.MapProperties.Product.Has.ProductId.Entity
{
    public class PropertyProduct
    {
        public PropertyProduct()
        {
            Properties = new Dictionary<string, string>();
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

        public static PropertyProduct FromJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PropertyProduct>(str);
        }

        public string GetJSonDisplay()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
