using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;
using SolrNet;
using SolrNet.Commands.Parameters;
using Websosanh.Core.Drivers.Solr;

namespace WSS.IndividualCategoryWebsites.SolrProduct
{
    public class SolrProductClient : SolrClient<SolrProductItem>
    {
        public List<FacetCategoryLv2Info> GetListCategoryProductByKeyword(List<string> keywords, int offset, int numRows, out int numFound)
        {
            var solr = GetSolrOperations();
            var normalizedKeyword =
                keywords.Select(SolrUtils.NormalizeToExactQuery).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            if (normalizedKeyword.Length == 0)
            {
                numFound = 0;
                return new List<FacetCategoryLv2Info>();
            }
            var queryString = "name:(" + string.Join(") OR (", normalizedKeyword) + ")";
            var queryResult = solr.Query(new SolrQuery(queryString) && new SolrQuery("product_type:2"), new QueryOptions
            {
                Start = offset,
                Rows = numRows,
                Facet = new FacetParameters
                {
                    Queries = new[]
                    {
                        new SolrFacetFieldQuery("category_level_2_id")
                        {
                            Limit = 100,
                            MinCount = 1}
                    }
                }
            });
            numFound = queryResult.NumFound;
            var facetResult1 = new List<FacetCategoryLv2Info>();
            foreach (var facet in queryResult.FacetFields["category_level_2_id"])
            {
                if (facet.Key == "0")
                    continue;
                else
                {
                    facetResult1.Add(new FacetCategoryLv2Info()
                    {
                        CategoryId = Common.Obj2Int(facet.Key),
                        CategoryName = WssCommon.GetNameCategoryById(Common.Obj2Int(facet.Key)),
                        CountProductInCat = facet.Value
                    });
                }
            }
            return facetResult1;
        }
        public List<SolrProductItem> GetAllProductsByKeywords(List<string> keywords, int offset, int numRows, out int numFound)
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
            var queryResult = solr.Query(new SolrQuery(queryString) && new SolrQuery("product_type:2"), new QueryOptions
            {
                Start = offset,
                Rows = numRows
                //Fields = new List<string> { SolrProductConstants.SOLR_FIELD_ID,SolrProductConstants.SOLR_FIELD_NAME,SolrProductConstants.SOLR_FIELD_PRICE }
            });
            numFound = queryResult.NumFound;
            var result = queryResult.ToList();
            return result;
        }
        public List<SolrProductItem> GetProductsByKeywordsAndCategory(List<string> keywords,int category, int offset, int numRows)
        {
            var solr = GetSolrOperations();
            var normalizedKeyword =
                keywords.Select(SolrUtils.NormalizeToExactQuery).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            if (normalizedKeyword.Length == 0)
            {
                return new List<SolrProductItem>();
            }
            var queryString = "name:(" + string.Join(") OR (", normalizedKeyword) + ")";
            var queryString2 = "category_level_2_id:"+category;
            var queryResult = solr.Query(new SolrQuery(queryString) && new SolrQuery(queryString2) && new SolrQuery("product_type:2"), new QueryOptions
            {
                Start = offset,
                Rows = numRows
                //Fields = new List<string> { SolrProductConstants.SOLR_FIELD_ID,SolrProductConstants.SOLR_FIELD_NAME,SolrProductConstants.SOLR_FIELD_PRICE }
            });
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

    public class FacetCategoryLv2Info
    {
        public int CategoryId { set; get; }
        public string CategoryName { set; get; }
        public int CountProductInCat { set; get; }
    }

}
