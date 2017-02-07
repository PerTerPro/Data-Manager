using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cassandra;
using log4net;
using RabbitMQ.Client.Impl;
using WSS.LibExtra;
using ISession = Cassandra.ISession;

namespace WSS.Crl.ProducProperties.Core
{
    public class NoSqlAdapter
    {
        private ISession _session = null;
        private Cluster _cluster = null;
        private ILog Log = LogManager.GetLogger(typeof (NoSqlAdapter));

        private NoSqlAdapter()
        {
            Connect();
            Init();
        }

        private void Init()
        {

        }

        private void Connect()
        {
            var countTry = 0;
            while (true)
            {
                try
                {
                    String[] HOST1 = ConfigurationManager.AppSettings[ConfigStatic.KeyNoSqlHtml].Split(new char[] {','});
                    countTry++;
                    _cluster =
                        Cluster.Builder()
                            .AddContactPoints(HOST1)
                            .WithReconnectionPolicy(new ConstantReconnectionPolicy(10000L))
                            .WithRetryPolicy(DowngradingConsistencyRetryPolicy.Instance)
                            .WithLoadBalancingPolicy(new DCAwareRoundRobinPolicy())
                            .Build();
                    Log.Info("Connected to cluster: " + _cluster.Metadata.ClusterName);
                    foreach (var host in _cluster.Metadata.AllHosts())
                    {
                        Log.Info("Data Center: " + host.Datacenter + ", " + "Host: " + host.Address + ", " + "Rack: " +
                                 host.Rack);
                    }
                    _session = _cluster.Connect();
                    _session.ChangeKeyspace("product_properties");
                    return;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("Try again {0} {1}", countTry, ex.Message));
                    Thread.Sleep(1000);
                }
            }
        }

        private static NoSqlAdapter _ins;

        public static NoSqlAdapter GetInstance()
        {
            return _ins ?? (_ins = new NoSqlAdapter());
        }

        public Tuple<string, string> GetHtml(long id)
        {
            try
            {
                RowSet r = _session.Execute(string.Format("select html, url from html where id = {0}", id));
                var row = r.GetRows().ElementAt(0);
                return new Tuple<string, string>(row.GetValue(typeof (string), "url").ToString(),
                    row.GetValue(typeof (string), "html").ToString());
            }
            catch (ArgumentOutOfRangeException ex01)
            {
                return null;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                return null;
            }
        }

        public void SaveHtml(long id, string html, string url, string domain)
        {
            PreparedStatement ps = _session.Prepare("insert into html (id, html, url, domain) values (?, ?, ?, ?)");
            var statement = ps.Bind(id, (new UtilZipFile()).ZipOfEncode(html), url, domain);
            _session.Execute(statement);
            PreparedStatement ps1 = _session.Prepare("insert into html_id (id, domain, url) values (?, ?, ?)");
            var statement1 = ps1.Bind(id, domain, url);
            _session.Execute(statement1);
        }


        public delegate void DelegateProcess(Tuple<long, string> data);

        internal void ProcessWithAllId(DelegateProcess delegateProcess)
        {
            var rowsSet = _session.Execute("select id, url from price_crl.html", 100);
            foreach (var VARIABLE in rowsSet)
            {
                long id = Convert.ToInt64(VARIABLE.GetValue(typeof (long), "id"));
                string url = Convert.ToString(VARIABLE.GetValue(typeof (string), "url"));
                delegateProcess(new Tuple<long, string>(id, url));
            }
        }

        public void ProcessAllIdProductByCompany(string domain, EventHandler<long> eventHandler)
        {
            string query = string.Format("select id from product_properties.html_id where domain = '{0}';", domain);
            foreach (var VARIABLE in _session.Execute(query, 1000))
            {
                long productIds = CommonConvert.Obj2Int64(VARIABLE.GetValue(typeof (long), "id"));
                if (productIds > 0)
                {
                    eventHandler(this, productIds);
                }
            }
            
        }
    }
}