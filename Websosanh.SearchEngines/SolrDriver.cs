using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Facilities.SolrNetIntegration;
using Castle.Windsor;
using SolrNet;
using SolrNet.Commands.Parameters;
using SolrNet.Impl;
using SolrNet.Utils;
using Websosanh.SearchEngines.SolrDriverTypes;

namespace Websosanh.SearchEngines
{
    public class SolrDriver
    {
        private WindsorContainer _container;
        public String ActiveNodeID;

        public bool Init(Dictionary<string, string> solrNodeUrls)
        {
            _container = new WindsorContainer();
            var solrFacility = new SolrNetFacility("http://localhost:8983/solr/");
            foreach (var solrNodeUrl in solrNodeUrls)
            {
                var nodeId = solrNodeUrl.Key;
                var url = solrNodeUrl.Value;
                solrFacility.AddCore(nodeId, typeof(SolrProductItem), url);
            }
            try
            {
                _container.AddFacility(solrFacility);
            }
            catch (Exception)
            {
                
                throw;
            }
            
            if (solrNodeUrls.Count > 0)
            {
                ActiveNodeID = solrNodeUrls.First().Key;
                return true;
            }
            return false;
        }

        public bool IndexProducts(ICollection<SolrProductItem> productItems)
        {
            var solr = _container.Resolve<ISolrOperations<SolrProductItem>>(ActiveNodeID);
            var response = solr.AddRange(productItems);
            return response.Status == 0;
        }

        public bool Commit()
        {
            var solr = _container.Resolve<ISolrOperations<SolrProductItem>>(ActiveNodeID);
            var response = solr.Commit();
            return response.Status == 0;
        }

        public bool Optimize()
        {
            var solr = _container.Resolve<ISolrOperations<SolrProductItem>>(ActiveNodeID);
            var response = solr.Optimize();
            return response.Status == 0;
        }

        public bool SoftCommit()
        {
            var solr = _container.Resolve<ISolrOperations<SolrProductItem>>(ActiveNodeID);
            var response = solr.Commit(new CommitOptions() {SoftCommit = true});
            return response.Status == 0;
        }
        public bool Delete(List<String> productIds)
        {
            var solr = _container.Resolve<ISolrOperations<SolrProductItem>>(ActiveNodeID);
            var response = solr.Delete(productIds);
            return response.Status == 0;
        }

        public bool DeleteByCompanyId(Int64 companyId)
        {
            var solr = _container.Resolve<ISolrOperations<SolrProductItem>>(ActiveNodeID);
            var response = solr.Delete(new SolrQuery("company:" + companyId));
            return response.Status == 0;
        }

        public bool DeleteByCompanyId(Int64 companyId, int categoryId)
        {
            var solr = _container.Resolve<ISolrOperations<SolrProductItem>>(ActiveNodeID);
            var response = solr.Delete(new SolrQuery("company:" + companyId) && new SolrQuery("contentft:c"+categoryId.ToString("000")));
            return response.Status == 0;
        }

        public List<KeyValuePair<string, int>> GetAllCompany()
        {
            var result = new List<KeyValuePair<string, int>>();
            var solr = _container.Resolve<ISolrOperations<SolrProductItem>>(ActiveNodeID);
            var query = new SolrQuery("*:*");
            var queryResult = solr.Query(query, new QueryOptions()
            {
                Rows = 0,
                Facet = new FacetParameters()
                {
                    Queries = new List<ISolrFacetQuery>() { new SolrFacetFieldQuery("company") },
                    Limit = 1000000
                }
            }
                );
            var rsFacetFields = queryResult.FacetFields;
            if (rsFacetFields != null)
                if (rsFacetFields.ContainsKey("company"))
                    result.AddRange(rsFacetFields["company"]);
            return result;
        }

        private static String NormalizeQuery(String queryString)
        {
            var tokens = queryString.Split(",./';()^#! -+".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            return String.Join("+", tokens);
        }

        private static String NormalizeToExactQuery(String queryString)
        {
            var tokens = queryString.Split(",./';()^#! -+".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            return String.Join(" ", tokens);
        }

        private static String ToAsciiString(String queryString)
        {
            return queryString;
        }

    }
}
