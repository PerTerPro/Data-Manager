using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SolrNet.Attributes;

namespace WSS.IndividualCategoryWebsites.SolrProduct
{
    public class SolrProductItem
    {
        [SolrUniqueKey(SolrProductConstants.SOLR_FIELD_ID)]
        public long Id { get; set; }
        [SolrField(SolrProductConstants.SOLR_FIELD_NAME)]
        public string Name { get; set; }
        [SolrField(SolrProductConstants.SOLR_FIELD_PRICE)]
        public long Price { get; set; }
        [SolrField(SolrProductConstants.SOLR_FIELD_MERCHANT_SCORE)]
        public int MerchantScore { get; set; }
        [SolrField(SolrProductConstants.SOLR_FIELD_CATEGORY_LEVEL2)]
        public int CategoryId { get; set; }
        public long WebsiteId { set; get; }

        public static byte[] GetMessage(SolrProductItem productItem)
        {
            var msgOut = UTF8Encoding.UTF8.GetBytes(SolrUtils.ConvertToJson(productItem));
            return msgOut;
        }
        public static SolrProductItem GetDataFromMessage(byte[] message)
        {
            SolrProductItem result;
            var productJson = UTF8Encoding.UTF8.GetString(message);
            result = JsonConvert.DeserializeObject<SolrProductItem>(productJson);
            return result;
        }
        public SolrProductItem()
        {
        }
    }
}
