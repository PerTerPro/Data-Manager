using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolrNet.Attributes;

namespace Websosanh.SearchEngines
{
    public class SolrProductItem
    {
        [SolrUniqueKey("id")]
        public Int64 Id { get; set; }

        [SolrField("price")]
        public Int32 Price { get; set; }

        [SolrField("warranty")]
        public Int32 Warranty { get; set; }

        [SolrField("status")]
        public Int32 Status { get; set; }

        [SolrField("company")]
        public Int64 Company { get; set; }

        [SolrField("company_provins")]
        public List<int> CompanyProvins { get; set; }

        [SolrField("company_districts")]
        public List<int> CompanyDistricts { get; set; }

        [SolrField("lastupdate")]
        public DateTime LastUpdate { get; set; }

        [SolrField("summary")]
        public String Summary { get; set; }

        [SolrField("description")]
        public String Description { get; set; }

        [SolrField("productid")]
        public Int32 ProductId { get; set; }

        [SolrField("product_type")]
        public Int32 ProductType { get; set; }

        [SolrField("name")]
        public String Name { get; set; }

        [SolrField("nameft")]
        public String NameFT { get; set; }

        [SolrField("detailurl")]
        public String DetailUrl { get; set; }

        [SolrField("imagepath")]
        public String ImagePath { get; set; }

        [SolrField("categoryid")]
        public Int32 CategoryId { get; set; }

        [SolrField("contentft")]
        public String ContentFT { get; set; }

        [SolrField("viewcount")]
        public Int32 ViewCount { get; set; }

        [SolrField("viewcount_lastweek")]
        public Int32 ViewCountLastWeek { get; set; }

        [SolrField("num_products")]
        public Int32 NumProducts { get; set; }

        [SolrField("price_min")]
        public Int32 PriceMin { get; set; }

        [SolrUniqueKey("addposition")]
        public Int32 AddPosition { get; set; }

        [SolrField(SolrDriverConstants.PREFIX_DOUBLE_FILTER_FIELD)]
        public Dictionary<string, object> DoubleFilterFields { get; set; }

        [SolrField(SolrDriverConstants.PREFIX_DATETIME_FILTER_FIELD)]
        public Dictionary<string, object> DateTimeFilterFields { get; set; }

        [SolrField(SolrDriverConstants.PREFIX_STRING_FILTER_FIELD)]
        public Dictionary<string, object> StringFilterFields { get; set; }

        [SolrField(SolrDriverConstants.PREFIX_INT_FILTER_FIELD)]
        public Dictionary<string, object> IntFilterFields { get; set; }
        
        public String Url { get; set; }

        public String Source { get; set; }

        public List<string> NameHighLight { get; set; }
    }
}
