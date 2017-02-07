using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace WSS.Crl.ProducProperties.Core.Entity
{

    [ProtoContract]
    public class HtmlProduct
    {
        [ProtoMember(1)]
        [BsonElement("_id")]
        public ObjectId _id { get; set; }

        [ProtoMember(2)]
        [BsonElement("product_id")]
        public long ProductId {get; set; }

        [ProtoMember(3)]
        [BsonElement("html")]
        public string Html { get; set; }

        //[BsonElement("html_zip")]//public string HtmlZip { get; set; }

        [ProtoMember(4)]
        [BsonElement("domain")]
        public string Domain { get; set; }


        [ProtoMember(5)]
        public string Classification { get; set; }
    }


    public class PropertyProduct
    {
        public PropertyProduct()
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
