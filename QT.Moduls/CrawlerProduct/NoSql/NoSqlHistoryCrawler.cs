using System;
using System.Linq;
using System.Threading;
using Cassandra;
using log4net;
using QT.Entities;
using QT.Entities.CrawlerProduct;

namespace QT.Moduls.CrawlerProduct.NoSql
{
    public class NoSqlHistoryCrawler
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(NoSqlHistoryCrawler));

        private readonly string _strQueryInsert = @"insert into crawler_product.history_product 
                                                    (session, product_id, company_id, last_update, date_update, product_entity)
                                                    values (:session, :product_id, :company_id, :last_update, :date_update, :product_entity)";

        private readonly string _strQueryInsertFindNew = @"insert into crawler_product.links_find_new 
                                                            (session, product_id, company_id, last_update, date_update, url)
                                                            values (:session, :product_id, :company_id, :last_update, :date_update, :url)";

        private readonly string _strQuerySelectProductEntity =
            @"select product_entity from crawler_product.history_product where session = :session and product_id = :product_id and company_id = :company_id";

        private readonly ISession _session = null;

        public static NoSqlHistoryCrawler _objInstance;

        public static NoSqlHistoryCrawler Instance()
        {
            return _objInstance ?? (_objInstance = new NoSqlHistoryCrawler());
        }

        private NoSqlHistoryCrawler()
        {

            var countTry = 0;
            while (true)
            {
                try
                {
                    var HOST1 = "192.168.100.188";
                    countTry++;
                    var cluster = Cluster.Builder()
                        .AddContactPoint(HOST1)
                        .WithReconnectionPolicy(new ConstantReconnectionPolicy(1000L))
                        .Build();
                    _log.Info("Connected to cluster: " + cluster.Metadata.ClusterName);
                    foreach (var host in cluster.Metadata.AllHosts())
                    {
                        _log.Info("Data Center: " + host.Datacenter + ", " +
                                  "Host: " + host.Address + ", " +
                                  "Rack: " + host.Rack);
                    }
                    _session = cluster.Connect();
                    _session.ChangeKeyspace("crawler_product");
                    return;
                }
                catch (Exception ex)
                {
                    _log.Error(string.Format("Try again {0} {1}", countTry, ex.Message));
                    Thread.Sleep(1000);
                }
            }

        }
        public void InsertProduct(ProductEntity pt)
        {
            var statement2 = _session.Prepare(_strQueryInsert);
            var results2 = _session.Execute(statement2.Bind(new
            {
                session = Guid.Parse(pt.Session),
                product_id = pt.ID,
                company_id = pt.CompanyId,
                last_update = DateTime.Now.Ticks,
                date_update = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")),
                product_entity = pt.GetJSON()
            }));
        }

        public void InsertFindNew(VisitedLinkFindNew pt)
        {
            var statement2 = _session.Prepare(_strQueryInsertFindNew);
            var results2 = _session.Execute(statement2.Bind(new
            {
                session = Guid.Parse(pt.Session),
                product_id = pt.ProductId,
                company_id = pt.CompanyId,
                last_update = DateTime.Now.Ticks,
                date_update = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")),
                url = pt.Url
            }));
        }

        public ProductEntity GetProduct(string session, long productId, long companyId)
        {
            try
            {
                var statement2 = _session.Prepare(_strQuerySelectProductEntity);
            var results2 = _session.Execute(statement2.Bind(new
            {
                session = Guid.Parse(session),
                product_id = productId,
                company_id = companyId
            }));
            return
                Newtonsoft.Json.JsonConvert.DeserializeObject<ProductEntity>(
                    results2.First()["product_entity"].ToString());
            }
            catch (Exception)
            {
                return new ProductEntity()
                {
                    ID = productId,
                    Name = "Not in cassandra"
                };
            }
            
        }
    }
}
