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
    public class KeywordSolrDriver : SolrClient<QT.Entities.RaoVat.KeywordSaleNew>
    {
        private static string nodeSolrRaoVat = "solrRaovatKeyWord";
        public KeywordSolrDriver ()
        {
        }

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

        public void DelKeywordById(List<string> lstId)
        {
            var solr = GetSolrOperations();
            foreach (var a in lstId)
            {
                string query = string.Format("_id:{0}", a);
                var response = solr.Delete(new SolrQuery(query));
            }
        }


        public bool SaveToSolr(KeywordSaleNew item)
        {
            var solr = GetSolrOperations();
            var response = solr.Add(item);
            this.Commit();
            return response.Status == 0;
        }

        public static SolrRaoVatDriver SolrRaoVatStandardProduct(SolrClient<ProductStandard> SorlClient)
        {
            return new SolrRaoVatDriver()
            {
                Container = SorlClient.Container,
             
                AutoPhraseDictionary = SorlClient.AutoPhraseDictionary
            };
        }

        public static void UpdateProductStandard()
        {

        }

       



        public bool InsertData(List<KeywordSaleNew> item)
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





        public List<KeywordSaleNew> GetListKeywordByQuery(string query, int numberReturn
            , int iStart, int No
            , out int numberFound, int numberWord
            , int priority=0
            , int priorityTo=0)
        {
            AbstractSolrQuery solrQuery = new SolrQuery(query);
            AbstractSolrQuery solrQueryNumberWord = new SolrQuery(string.Format("word_number:{0}", numberWord));
            AbstractSolrQuery solrQueryPriority = new SolrQuery(string.Format("priority:[{0} TO {1}]", priority, priorityTo));

            if (numberWord> 0) solrQuery = solrQuery & solrQueryNumberWord;
            if (priority > 0 || priorityTo > 0) solrQuery = solrQuery & solrQueryPriority;

            SolrMultipleCriteriaQuery arsolrQuery = new SolrMultipleCriteriaQuery(new ISolrQuery[]{
                solrQuery
            });
            var solr = GetSolrOperations();
            var response = solr.Query(arsolrQuery, new QueryOptions()
            {
                Rows = numberReturn,
                Start = iStart
            });
            numberFound = response.NumFound;
            return response.ToList();
        }

     

        public List<KeywordSaleNew> GetListProductLast(int numberReturn)
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





        public int DeleteByQuery(string query)
        {
            SolrQuery solrQuery = new SolrQuery(query);
            var solr = GetSolrOperations();
            var response = solr.Delete(solrQuery);
            solr.Commit();
            return response.Status;
        }




        public static KeywordSolrDriver GetInstance()
        {
            var solrClient = SolrClientManager.GetSolrClient(nodeSolrRaoVat);
            return new KeywordSolrDriver
            {
                AutoPhraseDictionary = solrClient.AutoPhraseDictionary,
                Container = solrClient.Container

            };
        }
    }
}
