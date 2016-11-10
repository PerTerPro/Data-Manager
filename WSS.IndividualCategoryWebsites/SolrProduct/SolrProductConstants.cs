using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.IndividualCategoryWebsites.SolrProduct
{
    public class SolrProductConstants
    {
        public const string SOLR_NODE_PRODUCT = "solrReview";

        public const string IGNORE_CHARS = "/()^!?:~[]{}\\=©®°™ - |`<>\"";
        public const string SOLR_FIELD_ID = "id";
        public const string SOLR_FIELD_PRICE = "price";
        public const string SOLR_FIELD_MERCHANT_ID = "merchant_id";
        public const string SOLR_FIELD_PRODUCT_TYPE = "product_type";
        public const string SOLR_FIELD_NAME = "name";
        public const string SOLR_FIELD_NAME_LENGTH = "name_length";
        public const string SOLR_FIELD_CATEGORY_LEVEL2 = "category_level_2_id";
        public const string SOLR_FIELD_MERCHANT_SCORE = "merchant_score";
        public const string SOLR_FIELD_VIEW_COUNT = "view_count";
        public const string SOLR_FIELD_VERSION = "_version_";
    }
}
