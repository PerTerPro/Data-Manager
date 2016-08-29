using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Docking2010.Base;
using Microsoft.Practices.ServiceLocation;
using QT.Entities;
using QT.Entities.Solr;
using Solr.Client;
using Solr.Client.WebService;
using SolrNet;

namespace QT.Moduls.CrawlerProduct
{
    public class SolrHistoryCrawlerProduct
    {
        private readonly ISolrOperations<HistoryProductSorl> _solrHistory = null;
        private static SolrHistoryCrawlerProduct _objInstance;

        public static SolrHistoryCrawlerProduct Instace()
        {
            return _objInstance ?? (_objInstance = new SolrHistoryCrawlerProduct());
        }

        private SolrHistoryCrawlerProduct()
        {
            Startup.Init<HistoryProductSorl>(ConfigRun.SolrHistoryCrwaler);
            _solrHistory = ServiceLocator.Current.GetInstance<ISolrOperations<HistoryProductSorl>>();
        }
        
        public void InsertProduct(HistoryProductSorl product)
        {
            _solrHistory.Add(product);
            //_solrHistory.Commit();
        }

        public SolrQueryResults<HistoryProductSorl> GetHistoryOfProduct(long ProductId)
        {
            string query = string.Format("product_id:{0}", ProductId);
            var pts = _solrHistory.Query(new SolrQuery(query));
            return pts;
        }

        public SolrQueryResults<HistoryProductSorl> GetHistoryOfSession(string session)
        {
            string query = string.Format("session:{0}", session);
            var pts = _solrHistory.Query(new SolrQuery(query));
            return pts;
        }
    }

    public class SolrFindNewCrawlerProduct
    {
        private readonly ISolrOperations<VisitedLinkFindNewSolr> _solrHistory = null;
        private static SolrFindNewCrawlerProduct _objInstance;

        public static SolrFindNewCrawlerProduct Instace()
        {
            return _objInstance ?? (_objInstance = new SolrFindNewCrawlerProduct());
        }

        private SolrFindNewCrawlerProduct()
        {
            Startup.Init<VisitedLinkFindNewSolr>(ConfigRun.SolrLinkFindNew);
            _solrHistory = ServiceLocator.Current.GetInstance<ISolrOperations<VisitedLinkFindNewSolr>>();
        }

        public void InsertProduct(VisitedLinkFindNewSolr product)
        {
            _solrHistory.Add(product);
            _solrHistory.Commit();
        }

        public SolrQueryResults<VisitedLinkFindNewSolr> GetHistoryOfProduct(long ProductId)
        {
            string query = string.Format("product_id:{0}", ProductId);
            var pts = _solrHistory.Query(new SolrQuery(query));
            return pts;
        }

        public SolrQueryResults<VisitedLinkFindNewSolr> GetHistoryOfSession(string session)
        {
            string query = string.Format("session:{0}", session);
            var pts = _solrHistory.Query(new SolrQuery(query));
            return pts;
        }
    }
}
