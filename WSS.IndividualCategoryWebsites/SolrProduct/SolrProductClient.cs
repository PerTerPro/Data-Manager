using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolrNet;
using SolrNet.Commands.Parameters;
using Websosanh.Core.Drivers.Solr;

namespace WSS.IndividualCategoryWebsites.SolrProduct
{
    public class SolrProductClient : SolrClient<SolrProductItem>
    {
        public List<SolrProductItem> GetListProducts(List<string> keywords, int offset, int numRows, out int numFound)
        {
            var solr = GetSolrOperations();
            var normalizedKeyword =
                keywords.Select(SolrUtils.NormalizeToExactQuery).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            if (normalizedKeyword.Length == 0)
            {
                numFound = 0;
                return new List<SolrProductItem>();
            }
            var queryString = "name:(" + string.Join(") OR (", normalizedKeyword) + ")";
            var queryResult = solr.Query(new SolrQuery(queryString), new QueryOptions
            {
                Start = offset,
                Rows = numRows,
                Fields = new List<string> { SolrProductConstants.SOLR_FIELD_ID,SolrProductConstants.SOLR_FIELD_NAME,SolrProductConstants.SOLR_FIELD_PRICE }
            });
            numFound = queryResult.NumFound;
            var result = queryResult.ToList();
            return result;
        }

        public static SolrProductClient GetClient(SolrClientBase solrClient)
        {
            return new SolrProductClient()
            {
                Container = solrClient.Container,
                AutoPhraseDictionary = solrClient.AutoPhraseDictionary
            };
        }

    }
}
