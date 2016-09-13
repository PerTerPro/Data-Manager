using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolrNet;
using SolrNet.Commands.Parameters;
using Websosanh.Core.Drivers.Solr;

namespace WSS.IndividualCategoryWebsites.SolrRootProduct
{
    public class SolrRootProductClient : SolrClient<SolrRootProductItem>
    {
        public bool Insert(SolrRootProductItem newsRootProduct)
        {
            var solr = GetSolrOperations();
            var response = solr.Add(newsRootProduct);
            return response.Status == 0;

        }

        public bool InsertListRootProduct(List<SolrRootProductItem> newsRootProducts)
        {
            var solr = GetSolrOperations();
            var response = solr.AddRange(newsRootProducts);
            return response.Status == 0;
        }
        public List<SolrRootProductItem> GetListRootProductsByTag(string tag,int websiteId, int offset, int numRows)
        {
            var solr = GetSolrOperations();
            var queryString = "name:*" + tag + "*";
            var queryString2 = "website_id:" + websiteId;
            var queryResult = solr.Query(new SolrQuery(queryString) && new SolrQuery(queryString2), new QueryOptions
            {
                Start = offset,
                Rows = numRows
            });
            var result = queryResult.ToList();
            return result;
        }

        public static SolrRootProductClient GetClient(SolrClientBase solrClient)
        {
            return new SolrRootProductClient()
            {
                Container = solrClient.Container,
                AutoPhraseDictionary = solrClient.AutoPhraseDictionary
            };
        }

    }
}
