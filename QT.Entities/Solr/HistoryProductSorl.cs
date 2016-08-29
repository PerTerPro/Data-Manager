using SolrNet.Attributes;

namespace QT.Entities.Solr
{
    public class HistoryProductSorl
    {
        [SolrField("session")]
        public string Session { get; set; }

        [SolrUniqueKey("id")]
        public string Id { get; set; }

        [SolrField("company_id")]
        public long CompanyId { get; set; }

        [SolrField("product_id")]
        public long ProductId { get; set; }

        [SolrField("date_update")]
        public int DateUpdate { get; set; }

        [SolrField("last_update")]
        public long LastUpdate { get; set; }

        [SolrField("url")]
        public string DetailUrl { get; set; }

        [SolrField("type_run")]
        public int TypeRun { get; set; }

    }

    public class VisitedLinkFindNewSolr
    {
        [SolrField("session")]
        public string Session { get; set; }

        [SolrUniqueKey("id")]
        public string Id { get; set; }

        [SolrField("company_id")]
        public long CompanyId { get; set; }

        [SolrField("product_id")]
        public long ProductId { get; set; }

        [SolrField("date_update")]
        public int DateUpdate { get; set; }

        [SolrField("last_update")]
        public long LastUpdate { get; set; }

        [SolrField("url")]
        public string DetailUrl { get; set; }

        [SolrField("type_run")]
        public int TypeRun { get; set; }

    }
}
