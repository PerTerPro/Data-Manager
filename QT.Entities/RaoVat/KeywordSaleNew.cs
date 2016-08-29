using QT.Entities.Data.SolrDb.SaleNews;
using SolrNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.RaoVat
{
    public class KeywordSaleNew
    {
        public KeywordSaleNew()
        {
            priority = 0;
            crc = 0;
            status = 1;
            slug = "";
            name = "";
            score_gram = 1;
            is_blocked = false;
        }

        [SolrUniqueKey(SolrSaleNewProperties.SOLR_FIELD_KEYWORD_ID)]
        public string _id { get; set; }



        public string Regex_Novalid { get; set; }


        [SolrUniqueKey(SolrSaleNewProperties.SOLR_FIELD_KEYWORD_CRC)]
        public long crc { get; set; }

        [SolrUniqueKey(SolrSaleNewProperties.SOLR_FIELD_KEYWORD_NAME)]
        public string name { get; set; }

        public string name_suggest { get; set; }

        [SolrUniqueKey(SolrSaleNewProperties.SOLR_FIELD_KEYWORD_PRIORITY)]
        public int priority { get; set; }


        [SolrUniqueKey(SolrSaleNewProperties.SOLR_FIELD_KEYWORD_WORD_NUMBER)]
        public int word_number
        {
            get
            {
                return name.Split(' ').Length;
            }
        }


        [SolrUniqueKey(SolrSaleNewProperties.SOLR_FIELD_KEYWORD_UPDATED_AT)]
        public DateTime updated_at { get; set; }


        [SolrUniqueKey(SolrSaleNewProperties.SOLR_FIELD_KEYWORD_VIEW_COUNT)]
        public int view_count { get; set; }


        [SolrUniqueKey(SolrSaleNewProperties.SOLR_FIELD_KEYWORD_CATEGORIES_ID)]
        public List<int> category_ids { get; set; }

        public bool is_selected { get; set; }

        //[SolrUniqueKey(SolrSaleNewProperties.SOLR_FIELD_KEYWORD_SLUG)]
        public string slug { get; set; }

        public int status { get; set; }

        public int score_gram { get; set; }

        public string crc_text { get; set; }

        [SolrUniqueKey(SolrSaleNewProperties.SOLR_FIELD_KEYWORD_TERM_ID)]
        public List<int> term_ids { get; set; }

        public DateTime solr_updated_at { get; set; }

        public bool is_blocked { get; set; }
    }
}
