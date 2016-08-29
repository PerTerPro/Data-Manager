using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using log4net;
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

namespace QT.Moduls.LogCassandra
{
    public enum TypeLog
    {
        None,
        Info,
        Error

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

    public class Log
    {
        public Log()
        {
            this.jobClient = new JobClient("CrawlerProduct", GroupType.Topic, "CrawlerProduct.Log", true, rabbitMQServer);
            Connect();
            Init();
        }
        SqlDb sqldb = new SqlDb("Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200");
        RabbitMQServer rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
        JobClient jobClient = null;

        string queryUpdateProduct = @"insert into crawler_product_log.wss_log (id, data_id, data_second_id, log, type, date_log, log_code, date_search, session) values ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})";
        private PreparedStatement pre_query_log;
        private static readonly ILog log = LogManager.GetLogger(typeof(Log));
        private static Log instance;
        private static object syncRoot = new Object();
        private const String HOST1 = "172.22.0.19";
        private const String CRAWLER_KEYSPACE = "crawler_product_log";
        public Cluster _Cluster { get; private set; }
        public ISession _session { get; private set; }


        public static Log Instance
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
                            instance = new Log();
                        }
                    }
                }
                return instance;
            }
        }

        private void Connect()
        {
            _Cluster = Cluster.Builder()
                 .AddContactPoint(HOST1)
                 .WithCompression(CompressionType.NoCompression)
                 .Build();
            while (true)
            {
                try
                {
                    _session = _Cluster.Connect();
                    log.Info("Connected to cluster: " + _Cluster.Metadata.ClusterName.ToString());
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    break;
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
            this.pre_query_log = _session.Prepare(queryLog);
        }


        public ProductSaleNew GetProductById(long ProductID)
        {
            RowSet rowSet = this._session.Execute(string.Format("SELECT * FROM sale.product WHERE id = {0} ", ProductID));
            IEnumerable<Row> rows = rowSet.GetRows();
            ProductSaleNew product = new ProductSaleNew();
            foreach (Row row in rows)
            {
                ParseProduct(ref product, row);
                return product;
            }
            return product;
        }

        private void ParseProduct(ref ProductSaleNew product, Row row)
        {

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
                    sqldb.RunQuery("INSERT INTO Company_LogCrawler (CompanyID, DateLog, session, logCode) VALUES (@CompanyID,@DateLog,@session,@logCode)", CommandType.Text, new System.Data.SqlClient.SqlParameter[] { 
                        sqldb.CreateParamteter("@CompanyID",data_id,SqlDbType.BigInt),
                        sqldb.CreateParamteter("@DateLog",dateLog,SqlDbType.DateTime),
                        sqldb.CreateParamteter("@session",session,SqlDbType.VarChar),
                        sqldb.CreateParamteter("@logCode",(int)logCode,SqlDbType.Int)
                    });
                }
            }
            catch (Exception ex01)
            {
                iLogNet.Error(ex01);
            }
        }

        public void SaveLog(string log, LogCode logCode, TypeLog typeLog, long data_id = 0, long data_second_id = 0, log4net.ILog iLogNet = null, string session = "")
        {
            if (iLogNet != null) iLogNet.Info(log);
            Job job = new Job()
            {
                Data = new QT.Entities.CrawlerProduct.RabbitMQ.MssLogCassandra()
                  {
                      data_id = data_id,
                      data_second_id = data_second_id,
                      log = log,
                      logCode = (int)logCode,
                      session = session,
                      typeLog = (int)typeLog
                  }.ToMss(),
                Type = 0
            };
            int CountFail = 0;
            while (true)
            {
                try
                {
                    jobClient.PublishJob(job, 0);
                    CountFail++;
                    break;
                }
                catch (Exception ex01)
                {
                    iLogNet.Error(ex01);
                    if (CountFail > 5) break;
                }
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
