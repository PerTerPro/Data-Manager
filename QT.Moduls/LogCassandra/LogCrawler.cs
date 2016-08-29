using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using System.Data;
using System.Data.Common;
using QT.Entities.Model.SaleNews;
using System.Text.RegularExpressions;
using QT.Entities.RaoVat;
using QT.Entities;
using System.Threading;
using Websosanh.Core.JobServer;
using Websosanh.Core.Drivers.RabbitMQ;
using QT.Entities.Data;
using log4net;

namespace QT.Moduls.LogCassandra
{
    public enum TypeLog
    {
        None,
        Info,
        Error
        //log daa
    }

    public enum LogCode
    {
        None = 0,
        ServiceCrawlerProduct_Worker_Start = 1,
        WSS_Service_CrawlerProduct_Reload_Runner = 2,
        WSS_Service_CrawlerProduct_Reload_Runner_Stop = 3,
        WSS_Service_CrawlerProduct_Reload_Runner_Start = 4,
        WSS_Service_CrawlerProduct_Reload_Worker = 5,
        WSS_Service_CrawlerProduct_Reload_Worker_BeginSession = 6,
        WSS_Service_CrawlerProduct_Reload_TrackCrawl = 7,
        WSS_Service_CrawlerProduct_Reload_Worker_UnValid = 8,
        WSS_Service_CrawlerProduct_Reload_Worker_Valid = 9,
        WSS_Service_CrawlerProduct_Reload_Worker_EndSession = 10,
        WSS_Service_CrawlerProduct_Reload_Worker_Sleep2Minute = 11,
        ServiceCrawlerProduct_Worker_Igone = 12,
        ServiceCrawlerProduct_Worker_Duplicate

    }

    public class LogCrawler
    {
        //Change code
        log4net.ILog logCrawler = log4net.LogManager.GetLogger(typeof(LogCrawler));

        public LogCrawler()
        {
            Connect();
            Init();
        }
        SqlDb sqldb = new SqlDb("Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200");
        string querySelectBySessionFN = @"select * from log_crawler_product.log_find_new where session = {0}";
        string querySelectBySession = @"select * from log_crawler_product.product where session = {0}";
        string queryHistoryProduct = @"select id, name, price, note, product_id, date_search, classification, url, is_black_list, is_new from log_crawler_product.product where product_id = {0}";
        string queryUpdateProduct = @"insert into log_crawler_product.wss_log (id, data_id, data_second_id, log, type, date_log, log_code, date_search, session) values ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})";
        string queryUpdateLogProduct = @"insert into log_crawler_product.product 
                                            (id,
                                            classification, 
                                            date_search,
                                            date_update, 
                                            image_url, 
                                            is_black_list, 
                                            is_new, 
                                            name, 
                                            note, 
                                            price,
                                            product_id, 
                                            status, 
                                            summary, 
                                            valid,
                                            session,
                                            company_id,
                                            url
                                            ) values ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8},{9},{10},{11},{12},{13},{14},{15},'{16}')";
        string queryUpdateLogFindnewProduct = @"insert into log_crawler_product.log_find_new (id, crc, date_log, is_ok, product_id, session, url) values ({0}, {1}, {2}, {3}, {4}, {5}, '{6}')";
        private PreparedStatement pre_query_SelectBySessionFN;
        private PreparedStatement pre_query_log_wss_log;
        private PreparedStatement pre_query_log_product;
        private PreparedStatement pre_query_history_product;
        private PreparedStatement pre_query_SelectBySession;
        private PreparedStatement pre_query_log_find_new;

        private static readonly ILog log = LogManager.GetLogger(typeof(LogCrawler));
        private static LogCrawler instance;
        private static object syncRoot = new Object();
        private const String HOST1 = "192.168.100.179";
        private const String CRAWLER_KEYSPACE = "log_crawler_product";
        public Cluster _Cluster { get; private set; }
        public ISession _session { get; private set; }


        public static LogCrawler Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            log.Info("New cassandra instance");
                            instance = new LogCrawler();
                        }
                    }
                }
                return instance;
            }
        }

        private void Connect()
        {
         
            while (true)
            {
                try
                {
                    _Cluster = Cluster.Builder()
                  .AddContactPoint(HOST1)
                  .WithCompression(CompressionType.NoCompression)
                  .Build();
                    _session = _Cluster.Connect();
                    log.Info("Connected to cluster: " + _Cluster.Metadata.ClusterName.ToString());
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }

        }

        private void Close()
        {
            _Cluster.Shutdown();
        }
        void Init()
        {
            string queryLog = Regex.Replace(this.queryUpdateProduct, @"{\d*}", "?");
            this.pre_query_log_wss_log = _session.Prepare(queryLog);
            this.pre_query_history_product = _session.Prepare(Regex.Replace(queryHistoryProduct, @"{\d*}", "?"));
            this.pre_query_log_find_new = _session.Prepare(Regex.Replace(queryHistoryProduct, @"{\d*}", "?"));
            this.pre_query_SelectBySession = _session.Prepare(Regex.Replace(querySelectBySession, @"{\d*}", "?"));
            string queryLogProduct = Regex.Replace(this.queryUpdateLogProduct, @"{\d*}", "?");
            this.pre_query_log_product = _session.Prepare(queryLogProduct);
            this.pre_query_SelectBySessionFN = _session.Prepare(Regex.Replace(queryHistoryProduct, @"{\d*}", "?"));
        }




        public List<QT.Entities.CrawlerProduct.RabbitMQ.MsProduct> GetHistoryProduct(long productID)
        {
            List<QT.Entities.CrawlerProduct.RabbitMQ.MsProduct> lst = new List<Entities.CrawlerProduct.RabbitMQ.MsProduct>();
            string query = string.Format(this.queryHistoryProduct, productID);
            RowSet rowSet = _session.Execute(query);
            IEnumerable<Row> rows = rowSet.GetRows();
            foreach (Row row in rows)
            {
                QT.Entities.CrawlerProduct.RabbitMQ.MsProduct product = new Entities.CrawlerProduct.RabbitMQ.MsProduct();
                ParseProduct(ref product, row);
                lst.Add(product);
            }
            return lst;
        }
        public List<QT.Entities.CrawlerProduct.RabbitMQ.MsProduct> GetDetailSession(string session)
        {
            List<QT.Entities.CrawlerProduct.RabbitMQ.MsProduct> lst = new List<Entities.CrawlerProduct.RabbitMQ.MsProduct>();
            string query = string.Format(this.querySelectBySession, session);
            RowSet rowSet = _session.Execute(query);
            IEnumerable<Row> rows = rowSet.GetRows();
            foreach (Row row in rows)
            {
                QT.Entities.CrawlerProduct.RabbitMQ.MsProduct product = new Entities.CrawlerProduct.RabbitMQ.MsProduct();
                ParseProduct(ref product, row);
                lst.Add(product);
            }
            return lst;
        }
        public List<QT.Entities.CrawlerProduct.RabbitMQ.MssLogFindNewProduct> GetDetailSessionFN(string session)
        {
            List<QT.Entities.CrawlerProduct.RabbitMQ.MssLogFindNewProduct> lst = new List<Entities.CrawlerProduct.RabbitMQ.MssLogFindNewProduct>();
            string query = string.Format(this.querySelectBySessionFN, session);
            RowSet rowSet = _session.Execute(query);
            IEnumerable<Row> rows = rowSet.GetRows();
            foreach (Row row in rows)
            {
                QT.Entities.CrawlerProduct.RabbitMQ.MssLogFindNewProduct productFN = new Entities.CrawlerProduct.RabbitMQ.MssLogFindNewProduct();
                ParseProductFN(ref productFN, row);
                lst.Add(productFN);
            }
            return lst;
        }


        private void ParseProduct(ref Entities.CrawlerProduct.RabbitMQ.MsProduct product, Row row)
        {
            product.Product_Id = Convert.ToInt64(row.GetValue(typeof(object), "product_id"));
            product.Name = row.GetValue(typeof(object), "name").ToString();
            product.Note = row.GetValue(typeof(object), "note").ToString();
            product.Price = Convert.ToInt64(row.GetValue(typeof(object), "price"));
            product.DateSearch = Convert.ToInt64(row.GetValue(typeof(object), "date_search"));
            if (product.DateSearch > 0)
            {
                string str = product.DateSearch.ToString();
                string strYear = str.Substring(0, 2);
                string strMonth = str.Substring(2, 2);
                string strDay = str.Substring(4, 2);
                string strHour = str.Substring(6, 2);
                string strMinute = str.Substring(8, 2);
                str = strMonth + "/" + strDay + "/" + "20" + strYear + " " + strHour + ":" + strMinute;
                DateTime date = Convert.ToDateTime(str);
                product.Date = date;
            }
            else
            {
                product.Date = null;
            }
            product.Classification = row.GetValue(typeof(object), "classification").ToString();
            product.Url = QT.Entities.Common.Obj2String(row.GetValue(typeof(object), "url"));
            product.Is_Black_Link = QT.Entities.Common.Obj2Bool(row.GetValue(typeof(object), "is_black_list"));
        }
        private void ParseProductFN(ref Entities.CrawlerProduct.RabbitMQ.MssLogFindNewProduct productFN, Row row)
        {
            productFN.CRC = QT.Entities.Common.Obj2Int64(row.GetValue(typeof(object), "crc"));
            productFN.DateSearch =QT.Entities.Common.Obj2Int64(row.GetValue(typeof(object), "date_log"));
            productFN.is_OK = QT.Entities.Common.Obj2Bool(row.GetValue(typeof(object), "is_ok"));
            productFN.Product_ID = QT.Entities.Common.Obj2Int64(row.GetValue(typeof(object), "product_id"));
            productFN.Session = row.GetValue(typeof(object), "session").ToString();
            productFN.Detail_Url = row.GetValue(typeof(object), "url").ToString();
        }

        public int GetViewCount(long ProductID)
        {
            RowSet rs = this._session.Execute(string.Format("SELECT wss_view_count FROM sale.product where id = {0}", ProductID));
            if (rs.Count<Row>() == 0) return 0;
            try
            {
                return Common.Obj2Int(rs.First<Row>()["wss_view_count"]);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public void SaveLogToCassandra(string log, LogCode logCode, TypeLog typeLog, long data_id = 0, long data_second_id = 0, log4net.ILog iLogNet = null, string session = "")
        {
            if (iLogNet != null) iLogNet.Info(log);
            try
            {
                if (session == "") session = Guid.NewGuid().ToString();
                DateTime dateLog = DateTime.Now;
                string id = Guid.NewGuid().ToString();
                string str = string.Format(this.queryUpdateProduct,
                    Guid.NewGuid().ToString()
                    , data_id.ToString()
                    , data_second_id.ToString()
                    , "'" + log + "'"
                    , (int)typeLog
                    , string.Format("'{0}'"
                    , dateLog.ToString("yyyy-MM-dd HH:mm:ss"))
                    , (int)logCode
                    , QT.Entities.Common.Obj2Int64(dateLog.ToString("yyyyMMdd").ToString())
                    , session);
                this._session.Execute(str, ConsistencyLevel.Any);
                if ((int)logCode == 6)
                {
                    logCrawler.Info("Insert mss 6");
                    bool bOK = sqldb.RunQuery("INSERT INTO Company_LogCrawler (CompanyID, DateLog, session, logCode) VALUES (@CompanyID,@DateLog,@session,@logCode)", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { 
                        sqldb.CreateParamteter("@CompanyID",data_id,SqlDbType.BigInt),
                        sqldb.CreateParamteter("@DateLog",dateLog,SqlDbType.DateTime),
                        sqldb.CreateParamteter("@session",session,SqlDbType.VarChar),
                        sqldb.CreateParamteter("@logCode",(int)logCode,SqlDbType.Int)
                    });
                    logCrawler.InfoFormat("Insert mss ok :{0}", bOK.ToString());
                }
            }
            catch (Exception ex01)
            {
                iLogNet.Error(ex01);
            }
        }
        string str = "";
        public void LogProductToCassandra(string Classification, DateTime Date_Update, string Image_Url, bool Is_Black_Link, bool Is_New, string Name, string Note, long Price, long Product_ID, int Status, string Summary, bool Valid, string session, long CompanyID, string Url)
        {
            try
            {
                if (session == "") session = Guid.NewGuid().ToString();

                string id = Guid.NewGuid().ToString();
                str = string.Format(this.queryUpdateLogProduct,
                   Guid.NewGuid().ToString(),
                   string.Format("'{0}'", Classification),
                   QT.Entities.Common.Obj2Int64(Date_Update.ToString("yyMMddHHmm")),
                   string.Format("'{0}'", Date_Update.ToString("yyyy-MM-dd HH:mm:ss")),
                   string.Format("'{0}'", Image_Url),
                   Is_Black_Link.ToString(),
                   Is_New.ToString(),
                   string.Format("'{0}'", Name),
                   string.Format("'{0}'", Note),
                   Price.ToString(),
                   Product_ID.ToString(),
                   Status.ToString(),
                   string.Format("'{0}'", Summary),
                   Valid.ToString(),
                   session,
                   //session==""?"null":Guid.NewGuid().ToString(),
                   CompanyID.ToString(),
                   Url.ToString()
                   );
                this._session.Execute(str, ConsistencyLevel.Any);

                //log.InfoFormat("Log crawler company {0} : product {1}, {2},{3} ", CompanyID, Product_ID, Price, Date_Update, session);
            }
            catch (Exception ex01)
            {
                logCrawler.Info(str);
                logCrawler.Error(ex01);
            }
        }
        public void LogFindNewProduct(long crc, DateTime date_log, bool is_ok, long product_id, string session, string url)
        {
            try
            {
                if (session == "") session = Guid.NewGuid().ToString();
                str = string.Format(this.queryUpdateLogFindnewProduct,
                Guid.NewGuid().ToString(),
                crc.ToString(),
                string.Format("'{0}'", date_log.ToString("yyyy-MM-dd HH:mm:ss")),
                is_ok.ToString(),
                product_id.ToString(),
                session,
                url
                );
                this._session.Execute(str, ConsistencyLevel.Any);
                //log.Info(str);
                //log.InfoFormat("Log Find new product: {0}: {1}, {2}", product_id, url, is_ok.ToString());
            }
            catch (Exception ex02)
            {

                log.Info(str);
                log.Error(ex02);
            }
            
        }



        private bool CheckExistProductNewSale(long ID)
        {
            string query = string.Format("SELECT id FROM product WHERE id = {0}", ID);
            RowSet rowSet = this._session.Execute(query);
            int i = rowSet.Count<Row>();
            return i > 0;
        }

        public PreparedStatement PreparedInsertConfig = null;
        public PreparedStatement PreUpdateNewSale = null;
        private PreparedStatement PreUpdateReloadFailProduct;
        private PreparedStatement PreTotalProductByConfigID;




    }
}
