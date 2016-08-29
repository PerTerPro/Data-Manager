using Cassandra;
using log4net;
using QT.Moduls.LogCassandra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmWSS_LogManager : Form
    {
        string querySelect = "select data_id,data_second_id,date_log,date_search,log,log_code,type from crawler_product_log.wss_log where ;";
        private PreparedStatement pre_query_log;
        private static readonly ILog log = LogManager.GetLogger(typeof(LogCrawler));
        private static LogCrawler instance;
        private static object syncRoot = new Object();
        private const String HOST1 = "172.22.0.19";
        private const String CRAWLER_KEYSPACE = "crawler_product_log";
        public Cluster _Cluster { get; private set; }
        public ISession _session { get; private set; }
        public FrmWSS_LogManager()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("data_id", typeof(long));
            DataColumn dc2 = new DataColumn("data_second_id", typeof(long));
            DataColumn dc3 = new DataColumn("date_log", typeof(DateTime));
            DataColumn dc4 = new DataColumn("date_search", typeof(long));
            DataColumn dc5 = new DataColumn("log", typeof(string));
            DataColumn dc6 = new DataColumn("log_code", typeof(int));
            DataColumn dc7 = new DataColumn("type", typeof(int));

            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dt.Columns.Add(dc7);

            Connect();
            RowSet rs = _session.Execute(querySelect);
            List<Cassandra.Row> lstData = rs.ToList();
            for (int i = 0; i < lstData.Count; i++)
            {
                long data_id = QT.Entities.Common.Obj2Int64(lstData[i]["data_id"]);
                long data_second_id = QT.Entities.Common.Obj2Int64(lstData[i]["data_second_id"]);
                DateTime date_log = QT.Entities.Common.ObjectToDataTime(lstData[i]["date_log"]);
                long date_search = QT.Entities.Common.Obj2Int64(lstData[i]["date_search"]);
                string log = QT.Entities.Common.Obj2String(lstData[i]["log"]);
                int log_code = QT.Entities.Common.Obj2Int(lstData[i]["log_code"]);
                int type = QT.Entities.Common.Obj2Int(lstData[i]["type"]);

                DataRow dr = dt.NewRow();
                dr["data_id"] = data_id;
                dr["data_second_id"] = data_second_id;
                dr["date_log"] = date_log;
                dr["date_search"] = date_search;
                dr["log"] = log;
                dr["log_code"] = log_code;
                dr["type"] = type;

                dt.Rows.Add(dr);
            }
            gridControl1.DataSource = dt;
        }

        private void DatavaEent(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
        }





        private void Connect()
        {
            _Cluster = Cluster.Builder()
                 .AddContactPoint(HOST1)
                 .WithCompression(CompressionType.NoCompression)
                 .Build();
            log.Info("Connected to cluster: " + _Cluster.Metadata.ClusterName.ToString());

            while (true)
            {
                try
                {
                    _session = _Cluster.Connect();
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(1000);
                }
            }
        }

        private void Close()
        {
            _Cluster.Shutdown();
        }

    }
}
