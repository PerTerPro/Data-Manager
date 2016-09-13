using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolrNet.Attributes;

namespace WSS.IndividualCategoryWebsites.SolrRootProduct
{
    public class SolrRootProductItem
    {
        [SolrUniqueKey("id")]
        public long Id { get; set; }
        [SolrField("name")]
        public string Name { get; set; }
        [SolrField("image")]
        public string Image { get; set; }
        [SolrField("min_price")]
        public long MinPrice { get; set; }
        [SolrField("num_merchant")]
        public int NumMerchant { get; set; }
        [SolrField("local_path")]
        public string LocalPath { get; set; }

        [SolrField("website_id")]
        public int WebsiteId { get; set; }
    }
}
