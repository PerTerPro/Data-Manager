using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolrNet;
using SolrNet.Commands.Parameters;
using QT.Entities.Model.SaleNews;
using QT.Entities.AnaylysicData;
using QT.Entities.RaoVat;
using Websosanh.Core.Drivers.Solr;

namespace QT.Entities.Data.SolrDb.SaleNews
{

    public class SolrRaoVatDriver : SolrClient<ProductSaleNew>
    {
        private const string nodeSolrRaoVat = "solrRaoVatProduct";

        public bool Delete(List<String> productIds)
        {
            var solr = GetSolrOperations();
            var response = solr.Delete(productIds);
            return response.Status == 0;
        }

        public bool RunQuery(string query)
        {
            var solr = GetSolrOperations();
            var response = solr.Delete(new SolrQuery(query));
            return response.Status == 0;
        }


        public bool DeleteByCompanyId(Int64 companyId)
        {
            var solr = GetSolrOperations();
            var response = solr.Delete(new SolrQuery("company:" + companyId));
            return response.Status == 0;
        }

        public void DelProductById(List<string> lstId)
        {
            var solr = GetSolrOperations();
            foreach (var a in lstId)
            {
                string query = string.Format("_id:{0}", a);
                var response = solr.Delete(new SolrQuery(query));
            }
            solr.Commit();
        }


        public bool SaveToSolr(ProductSaleNew item)
        {
            var solr = GetSolrOperations();
            var response = solr.Add(item);
            this.Commit();
            return response.Status == 0;
        }

        public static SolrRaoVatDriver SolrRaoVatStandardProduct(SolrClient<ProductStandard> solrDriver)
        {
            return new SolrRaoVatDriver()
            {
                Container = solrDriver.Container,
                AutoPhraseDictionary = solrDriver.AutoPhraseDictionary
            };
        }

        public static void UpdateProductStandard()
        {

        }

        public static SolrRaoVatDriver GetDriver(SolrClient<ProductSaleNew> solrDriver)
        {
            return new SolrRaoVatDriver()
            {
                Container = solrDriver.Container,
                AutoPhraseDictionary = solrDriver.AutoPhraseDictionary
            };
        }



        public bool InsertData(List<ProductSaleNew> item)
        {


            var solr = GetSolrOperations();
            var response = solr.Add(item);
            this.Commit();
            return response.Status == 0;
        }

        public int CountOfKeyWord(string keyWord)
        {
            var solr = GetSolrOperations();
            var response = solr.Query(string.Format("tags:{0} title:*{0}* title:*{0}* excerpt:*{0}*", keyWord));
            return response.Count;
        }

        public static SolrRaoVatDriver GetInstance()
        {
            var solrClient = SolrClientManager.GetSolrClient(nodeSolrRaoVat);
            return new SolrRaoVatDriver
            {
                AutoPhraseDictionary = solrClient.AutoPhraseDictionary,
                Container = solrClient.Container

            };
        }




        public List<ProductSaleNew> GetListProduct(string query, int numberReturn)
        {
            var solr = GetSolrOperations();
            var response = solr.Query(query, new QueryOptions() { Rows = numberReturn });
            return response.ToList();
        }

 

        public List<ProductSaleNew> GetListProductLast(int numberReturn)
        {
            var solr = GetSolrOperations();
            var response = solr.Query("*:*", new QueryOptions()
            {
                Rows =  numberReturn,
                OrderBy =
                    new SortOrder[] { new SortOrder("updated_at", Order.DESC) }
            });
            return response.ToList();
        }

        public bool UpdateData(ProductSaleNew product)
        {
            try
            {
                var solr = GetSolrOperations();
                if (product.status == 1)
                {
                    //int iCountRun = solr.Delete(product._id).Status;
                    //solr.Commit(new CommitOptions() { SoftCommit = true });
                    //iCountRun = iCountRun + 1;
                    var response = solr.Add(product);
                }
                else
                {
                    ISolrQuery query = new SolrQuery(string.Format("_id:{0}", product._id));
                    var respose = solr.Delete(query);
                }
                return true;
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                return false;
            }
        }


        public int DeleteByQuery(string query)
        {
            var solr = GetSolrOperations();
            ISolrQuery query1 = new SolrQuery(query);
            return solr.Delete(query1).Status;
        }
    }



    public class SolrRaoVatKeywordDriver : SolrClient<KeywordSaleNew>
    {
        private static string nodeSolrRaoVat = "solrRaovatKeyWord";
        public bool Delete(List<String> productIds)
        {
            var solr = GetSolrOperations();
            var response = solr.Delete(productIds);
            return response.Status == 0;

        }

    


   

      


        public bool SaveToSolr(KeywordSaleNew item)
        {
            var solr = GetSolrOperations();
            var response = solr.Add(item);
            this.Commit();
            return response.Status == 0;
        }

        public static SolrRaoVatDriver SolrRaoVatStandardProduct(SolrClient<KeywordSaleNew> solrDriver)
        {
            return new SolrRaoVatDriver()
            {
                Container = solrDriver.Container,
        
                AutoPhraseDictionary = solrDriver.AutoPhraseDictionary
            };
        }

        public static void UpdateProductStandard()
        {

        }

        public static SolrRaoVatKeywordDriver GetDriver(SolrClient<KeywordSaleNew> solrDriver)
        {
            return new SolrRaoVatKeywordDriver()
            {
                Container = solrDriver.Container,
          
                AutoPhraseDictionary = solrDriver.AutoPhraseDictionary
            };
        }



        public bool UpdateData(KeywordSaleNew keyword)
        {
            return false;
            //try
            //{
       
            //    if (keyword.status == 1)
            //    {
            //        var response = solr.Add(keyword);
            //        int i = response.Status;

            //    }
            //    else
            //    {
            //        ISolrQuery query = new SolrQuery(string.Format("_id:{0}", keyword._id));
            //        var respose = solr.Delete(query);
            //    }
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    string str = ex.Message;
            //    return false;
            //}
        }



        public static SolrRaoVatKeywordDriver GetInstance()
        {
            var solrClient = SolrClientManager.GetSolrClient(nodeSolrRaoVat);
            return new SolrRaoVatKeywordDriver
            {
                AutoPhraseDictionary = solrClient.AutoPhraseDictionary,
                Container = solrClient.Container

            };
        }






      
    }
}
