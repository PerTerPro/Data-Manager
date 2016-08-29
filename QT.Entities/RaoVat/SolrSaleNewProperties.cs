using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QT.Entities.Data.SolrDb.SaleNews
{
    public static class SolrFieldSaleNew
    {
      
        public const string _id_product = "_id";
        public const string id_product = "id";
        public const string status_product = "status";
        public const string category_ids_product = "category_ids";
        public const string name_product = "name";
        public const string description_product = "description";
        public const string slug_product = "slug";
        public const string currency_product = "currency";
        public const string thumb_url_product = "thumb_url";
        public const string is_crawed_product = "is_crawled";
        public const string url_product = "url";
        public const string view_count_product = "view_count";
        public const string source_view_count_product = "source_view_count";
        public const string source_updated_at_product = "source_updated_at";
        public const string source_name_product = "source_name";
        public const string created_at_product = "created_at";
        public const string updated_at_product = "updated_at";
        public const string price_product = "price";
        public const string city_ids = "city_ids";

    }

    public class SolrSaleNewProperties
    {
        public const string IGNORE_CHARS = "/()^!?:~[]{}\\=©®°™ - |`<>\"";
        public const string SOLR_FIELD_CATEGORY = "category";
        public const string SOLR_FIELD_PUBLISHED_AT = "published_at";
        public const string SOLR_FIELD_INIT_CONTENT = "init_content";
        public const string SOLR_FIELD_IMAGE = "image";
        public const string SOLR_FIELD_IMAGE_NOTE = "image_note";
        public const string SOLR_FIELD_TAGS = "tags";
        public const string SOLR_FIELD_TAGS_STRING = "tags_string";
    
        public const string SOLR_FIELD_SCORE = "score";
       
        public const string SOLR_FIELD_PARENT = "parent";
        public const string SOLR_FIELD_DETAIL_TEXT = "text";
      

        public const string SOLR_FIELD_ORDER_INDEX = "order_index";
        public const string SOLR_FIELD_ORDER_IS_STANDARD = "is_standard";
        public const string SOLR_FIELD_DETAIL_VERSION = "_version_";
  
        public const string SOLR_FIELD_CONTACT_TEXT = "contact_text";
        public const string SOLR_FIELD_SITE_ID = "site_id";
     
        public const string SOLR_FIELD_LAST_COMMENT = "last_comment";
        public const string SOLR_FIELD_KEYWORD_ID = "_id";
        public const string SOLR_FIELD_KEYWORD_NAME = "name";
        public const string SOLR_FIELD_KEYWORD_CRC = "crc";
        public const string SOLR_FIELD_KEYWORD_PRIORITY = "priority";
    
        public const string SOLR_FIELD_KEYWORD_UPDATED_AT = "updated_at";
        public const string SOLR_FIELD_KEYWORD_WORD_NUMBER = "word_number";
        public const string SOLR_FIELD_KEYWORD_VIEW_COUNT = "view_count";
        public const string SOLR_FIELD_KEYWORD_CATEGORIES_ID = "category_ids";
        public const string SOLR_FIELD_KEYWORD_SLUG = "slug";
        public const string SOLR_FIELD_KEYWORD_TERM_ID = "term_ids";
    }
}
