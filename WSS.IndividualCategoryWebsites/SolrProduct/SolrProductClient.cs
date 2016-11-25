using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;
using SolrNet;
using SolrNet.Commands.Parameters;
using Websosanh.Core.Drivers.Solr;
using WSS.IndividualCategoryWebsites.DataTeam;

namespace WSS.IndividualCategoryWebsites.SolrProduct
{
    public class SolrProductClient : SolrClient<SolrProductItem>
    {
        public List<FacetCategoryLv2Info> GetListCategoryProductByKeyword(List<string> keywords, List<string> keywordsBlock, List<string> listIdBlock,
            long minPrice, long maxPrice, int offset, int numRows, out int numFound)
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

            var normalizedKeywordsBlock = keywordsBlock.Select(SolrUtils.NormalizeToExactQuery).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string queryString2 = string.Empty;
            if (normalizedKeywordsBlock.Length > 0)
                queryString2 = "-name:((*" + string.Join("*)*OR*(*", normalizedKeywordsBlock) + "*))";
            string queryString3 = string.Empty;
            if (minPrice > 0 && maxPrice > 0)
            {
                queryString3 = "price:[" + minPrice + " TO " + maxPrice + "]";
            }
            else if (minPrice > 0 && maxPrice == 0)
            {
                queryString3 = "price:[" + minPrice + " TO *]";
            }
            else if (minPrice > 0 && maxPrice == 0)
            {
                queryString3 = "price:[* TO " + maxPrice + "]";
            }


            SolrQueryResults<SolrProductItem> queryResult;

            if (listIdBlock.Count > 0)
            {
                queryResult = solr.Query(
                        new SolrQuery(queryString) && new SolrQuery("product_type:2") && new SolrQuery(queryString2) && new SolrQuery(queryString3)
                        && new SolrNotQuery(new SolrQueryInList("id", listIdBlock)), new QueryOptions
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
                                        MinCount = 1
                                    }
                                }
                            }
                        });
            }
            else
            {
                queryResult = solr.Query(
                        new SolrQuery(queryString) && new SolrQuery("product_type:2") && new SolrQuery(queryString2) && new SolrQuery(queryString3),
                        new QueryOptions
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
                                        MinCount = 1
                                    }
                                }
                            }
                        });
            }
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
        //Tool đội data
        public List<FacetCategoryLv2Info> GetListCategoryProductNotRootByCompanyAndKeyword(List<string> listIdCompany, string keyword, int offset, int numRows, out int numFound)
        {
            var solr = GetSolrOperations();
            if (listIdCompany.Count == 0)
            {
                numFound = 0;
                return new List<FacetCategoryLv2Info>();
            }
            //
            var blackListProductDataAccess = new BlackListProductDataAccess();
            var listIdBlock = blackListProductDataAccess.GetBlackListProducts();
            var listIdBlockString = listIdBlock.Select(id => id.ToString()).ToList();
            //
            SolrQueryResults<SolrProductItem> queryResult = new SolrQueryResults<SolrProductItem>();
            if (string.IsNullOrEmpty(keyword))
            {
                AbstractSolrQuery query = new SolrQuery("root_id:0") && new SolrQuery("product_type:2") && new SolrQueryInList("merchant_id", listIdCompany);
                if (listIdBlockString.Count > 0)
                {
                    query = query && new SolrNotQuery(new SolrQueryInList("id", listIdBlockString));
                }
                queryResult = solr.Query(query, new QueryOptions
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
                                        MinCount = 1
                                    }
                                }
                    },
                    OrderBy = new List<SortOrder>() { new SortOrder("view_count", Order.DESC) }
                });
            }
            else
            {
                var keywords = keyword.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var normalizedKeyword =
                keywords.Select(SolrUtils.NormalizeToExactQuery).Where(x => !string.IsNullOrEmpty(x)).ToArray();
                var queryString = "name:(" + string.Join(") OR (", normalizedKeyword) + ")";

                AbstractSolrQuery query = new SolrQuery("root_id:0") && new SolrQuery(queryString) && new SolrQuery("product_type:2") && new SolrQueryInList("merchant_id", listIdCompany);
                if (listIdBlockString.Count > 0)
                {
                    query = query && new SolrNotQuery(new SolrQueryInList("id", listIdBlockString));
                }
                queryResult = solr.Query(query, new QueryOptions
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
                                        MinCount = 1
                                    }
                                }
                    },
                    OrderBy = new List<SortOrder>() { new SortOrder("view_count", Order.DESC) }
                });
            }
            numFound = queryResult.NumFound;
            var facetResult1 = new List<FacetCategoryLv2Info>();
            foreach (var facet in queryResult.FacetFields["category_level_2_id"])
            {
                if (facet.Key == "0") continue;
                //facetResult1.Add(new FacetCategoryLv2Info()
                //{
                //    CategoryId = Common.Obj2Int(facet.Key),
                //    CategoryName = "Khác",
                //    CountProductInCat = facet.Value
                //});
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
        //Tool đội data
        public List<SolrProductItem> GetListProductNotRootByCompanyAndKeyword(List<string> listIdCompany, string keyword, int categoryId, int offset, int numRows, out int numFound)
        {
            var solr = GetSolrOperations();
            if (listIdCompany.Count == 0)
            {
                numFound = 0;
                return new List<SolrProductItem>();
            }
            //
            var blackListProductDataAccess = new BlackListProductDataAccess();
            var listIdBlock = blackListProductDataAccess.GetBlackListProducts();
            var listIdBlockString = listIdBlock.Select(id => id.ToString()).ToList();
            //
            SolrQueryResults<SolrProductItem> queryResult = new SolrQueryResults<SolrProductItem>();
            if (string.IsNullOrEmpty(keyword) && categoryId == 0)
            {
                AbstractSolrQuery query = new SolrQuery("root_id:0") && new SolrQuery("product_type:2") && new SolrQueryInList("merchant_id", listIdCompany);
                if (listIdBlockString.Count > 0)
                {
                    query = query && new SolrNotQuery(new SolrQueryInList("id", listIdBlockString));
                }
                queryResult = solr.Query(query, new QueryOptions
                {
                    Start = offset,
                    Rows = numRows,
                    OrderBy = new List<SortOrder>() { new SortOrder("view_count") }
                });
            }
            else if (!string.IsNullOrEmpty(keyword) && categoryId == 0)
            {
                var keywords = keyword.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var normalizedKeyword =
                keywords.Select(SolrUtils.NormalizeToExactQuery).Where(x => !string.IsNullOrEmpty(x)).ToArray();
                var queryString = "name:(" + string.Join(") OR (", normalizedKeyword) + ")";
                AbstractSolrQuery query = new SolrQuery("root_id:0") && new SolrQuery(queryString) && new SolrQuery("product_type:2") && new SolrQueryInList("merchant_id", listIdCompany);
                if (listIdBlockString.Count > 0)
                {
                    query = query && new SolrNotQuery(new SolrQueryInList("id", listIdBlockString));
                }
                queryResult = solr.Query(query, new QueryOptions
                {
                    Start = offset,
                    Rows = numRows,
                    OrderBy = new List<SortOrder>() { new SortOrder("view_count", Order.DESC) }
                });
            }
            else if (string.IsNullOrEmpty(keyword) && categoryId != 0)
            {
                AbstractSolrQuery query = new SolrQuery("root_id:0") && new SolrQuery("product_type:2") && new SolrQueryInList("merchant_id", listIdCompany) && new SolrQueryByField("category_level_2_id", categoryId.ToString());
                if (listIdBlockString.Count > 0)
                {
                    query = query && new SolrNotQuery(new SolrQueryInList("id", listIdBlockString));
                }
                queryResult = solr.Query(query, new QueryOptions
                {
                    Start = offset,
                    Rows = numRows,
                    OrderBy = new List<SortOrder>() { new SortOrder("view_count", Order.DESC) }
                });
            }
            else if (!string.IsNullOrEmpty(keyword) && categoryId != 0)
            {
                var keywords = keyword.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var normalizedKeyword =
                keywords.Select(SolrUtils.NormalizeToExactQuery).Where(x => !string.IsNullOrEmpty(x)).ToArray();
                var queryString = "name:(" + string.Join(") OR (", normalizedKeyword) + ")";
                AbstractSolrQuery query = new SolrQuery(queryString) && new SolrQuery("root_id:0") && new SolrQuery("product_type:2") && new SolrQueryInList("merchant_id", listIdCompany) && new SolrQueryByField("category_level_2_id", categoryId.ToString());
                if (listIdBlockString.Count > 0)
                {
                    query = query && new SolrNotQuery(new SolrQueryInList("id", listIdBlockString));
                }
                queryResult = solr.Query(query, new QueryOptions
                {
                    Start = offset,
                    Rows = numRows,
                    OrderBy = new List<SortOrder>() { new SortOrder("view_count", Order.DESC) }
                });
            }
            numFound = queryResult.NumFound;
            var result = queryResult.ToList();
            return result;
        }


        public List<SolrProductItem> GetProductByProductIdentityRequestAndCategory(List<string> keywords, List<string> keywordsBlock, List<string> listIdBlock,
            int categoryId, long minPrice, long maxPrice, int offset, int numRows, out int numFound)
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

            var normalizedKeywordsBlock = keywordsBlock.Select(SolrUtils.NormalizeToExactQuery).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string queryString2 = string.Empty;
            if (normalizedKeywordsBlock.Length > 0)
                queryString2 = "-name:((*" + string.Join("*)*OR*(*", normalizedKeywordsBlock) + "*))";
            string queryString3 = string.Empty;
            if (minPrice > 0 && maxPrice > 0)
            {
                queryString3 = "price:[" + minPrice + " TO " + maxPrice + "]";
            }
            else if (minPrice > 0 && maxPrice == 0)
            {
                queryString3 = "price:[" + minPrice + " TO *]";
            }
            else if (minPrice > 0 && maxPrice == 0)
            {
                queryString3 = "price:[* TO " + maxPrice + "]";
            }
            var queryString4 = "category_level_2_id:" + categoryId;
            var queryResult = new SolrQueryResults<SolrProductItem>();
            if (listIdBlock.Count > 0)
            {
                queryResult = solr.Query(
                        new SolrQuery(queryString) && new SolrQuery("product_type:2") && new SolrQuery(queryString2)
                        && new SolrQuery(queryString3) && new SolrQuery(queryString4)
                        && new SolrNotQuery(new SolrQueryInList("id", listIdBlock)), new QueryOptions
                        {
                            Start = offset,
                            Rows = numRows
                        });
            }
            else
            {
                queryResult = solr.Query(
                        new SolrQuery(queryString) && new SolrQuery("product_type:2") && new SolrQuery(queryString2)
                        && new SolrQuery(queryString3) && new SolrQuery(queryString4),
                        new QueryOptions
                        {
                            Start = offset,
                            Rows = numRows
                        });
            }
            numFound = queryResult.NumFound;
            var result = queryResult.ToList();
            return result;
        }
        public List<SolrProductItem> GetProductByProductIdentityRequest(List<string> keywords, List<string> keywordsBlock, List<string> listIdBlock,
            long minPrice, long maxPrice, int offset, int numRows, out int numFound)
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
            var normalizedKeywordsBlock = keywordsBlock.Select(SolrUtils.NormalizeToExactQuery).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string queryString2 = string.Empty;
            if (normalizedKeywordsBlock.Length > 0)
                queryString2 = "-name:((*" + string.Join("*)*OR*(*", normalizedKeywordsBlock) + "*))";
            var queryResult = new SolrQueryResults<SolrProductItem>();
            if (listIdBlock.Count > 0)
            {
                queryResult = solr.Query(
                        new SolrQuery(queryString) && new SolrQuery("product_type:2") && new SolrQuery(queryString2)
                        && new SolrNotQuery(new SolrQueryInList("id", listIdBlock)), new QueryOptions
                        {
                            Start = offset,
                            Rows = numRows
                        });
            }
            else
            {
                queryResult = solr.Query(
                        new SolrQuery(queryString) && new SolrQuery("product_type:2") && new SolrQuery(queryString2),
                        new QueryOptions
                        {
                            Start = offset,
                            Rows = numRows
                        });
            }
            numFound = queryResult.NumFound;
            var result = queryResult.ToList();
            return result;
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
            });
            numFound = queryResult.NumFound;
            var result = queryResult.ToList();
            return result;
        }
        public List<SolrProductItem> GetProductsByKeywordsAndCategory(List<string> keywords, int category, int offset, int numRows)
        {
            var solr = GetSolrOperations();
            var normalizedKeyword =
                keywords.Select(SolrUtils.NormalizeToExactQuery).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            if (normalizedKeyword.Length == 0)
            {
                return new List<SolrProductItem>();
            }
            var queryString = "name:(" + string.Join(") OR (", normalizedKeyword) + ")";
            var queryString2 = "category_level_2_id:" + category;
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
