using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cassandra;
using  System.Configuration;
using log4net;

namespace WSS.QAComment.Core
{
    public class NoSqlCommentSystem
    {

        private static readonly ILog _log = LogManager.GetLogger(typeof(NoSqlCommentSystem));

        //private const String HOST1 = "192.168.100.48";private static NoSqlHtml instance;
        private static object _syncRoot = new Object();
        private ISession _session;
        private Cluster _cluster;


        public static NoSqlCommentSystem Instance()
        {
            return new NoSqlCommentSystem();
        }

        private NoSqlCommentSystem()
        {
            var countTry = 0;
            while (true)
            {
                try
                {
                    var HOST1 = "192.168.100.188";countTry++;
                    _cluster = Cluster.Builder()
                        .AddContactPoint(HOST1)
                        .WithReconnectionPolicy(new ConstantReconnectionPolicy(1000L))
                        .Build();_log.Info("Connected to cluster: " + _cluster.Metadata.ClusterName);
                    foreach (var host in _cluster.Metadata.AllHosts())
                    {
                        _log.Info("Data Center: " + host.Datacenter + ", " +
                                  "Host: " + host.Address + ", " +
                                  "Rack: " + host.Rack);
                    }
                    _session = _cluster.Connect();
                    _session.ChangeKeyspace("wss_comment_product");
                    return;
                }
                catch (Exception ex)
                {
                    _log.Error(string.Format("Try again {0} {1}", countTry, ex.Message));
                    Thread.Sleep(1000);
                }
            }
        }

         public List<Tuple<long,string>> GetAllJobBySite (long webId)
         {
             List<Tuple<long,string>> lstResult =new List<Tuple<long,string>>();
             var status = _session.Prepare("select id, url from wss_comment_product.product_html");
             var results2 = _session.Execute(string.Format("select id, url from wss_comment_product.product_html where company_id = {0}",webId),100);foreach (var item in results2)
             {
                 lstResult.Add(new Tuple<long, string>(Convert.ToInt64(item["id"]),
                     Convert.ToString(item["url"])));
                                       
             }
             return
                 lstResult;
         }

     

        public string GetHtml(long id, long companyId){
            try
            {
                var statement2 =
                    _session.Prepare("select html from product_html where id = :i_id and company_id = :i_company_id");
                var results2 = _session.Execute(statement2.Bind(new {i_id = id, i_company_id = companyId}));
                return results2.First()["html"].ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public void SaveHtm(long id, long company_id, string html, string url)
        {
            while (true)
            {
                try
                {
                    var statement2 = _session.Prepare(
                        "insert into product_html (id, company_id, html, url) values (:i_id, :i_company_id, :i_html, :i_url)");
                    var results2 =
                        _session.Execute(
                            statement2.Bind(new {i_id = id, i_company_id = company_id, i_html = html, i_url = url}));
                    return;}
                catch (Exception ex)
                {
                    _log.Error("try again " + ex.Message);
                    Thread.Sleep(10000);
                }
            }
            
        }



        internal void SaveComment(long id, long companyId, List<Comment> lstComment)
        {
            string strComment = Newtonsoft.Json.JsonConvert.SerializeObject(lstComment);
            var statement = _session.Prepare(@"
            insert into comment (id, company_id, comment) values (:i_id, :i_company_id, :i_comment)");
            var results2 =
                _session.Execute(statement.Bind(new {i_id = id, i_company_id = companyId, i_comment = strComment}));

        }
    }
}
