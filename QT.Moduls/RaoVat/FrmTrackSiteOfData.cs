using MongoDB.Bson;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlSale
{
    public partial class FrmTrackSiteOfData : Form
    {
        SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmTrackSiteOfData));
        MongoDbRaoVat mongoDb = new MongoDbRaoVat();
        DataTable tbl = null;
        private Thread thread;

        public FrmTrackSiteOfData()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
      
        }

        private void RunTrack(int iInverval)
        {
            while (true)
            {
                try
                {
                    DataTable tbl = this.sqlDb.GetTblData(@"SELECT b.id, GETDATE() AS updated_at, '' as id_last, b.domain FROM WebSite b"
                        , CommandType.Text, new SqlParameter[] { });
                    foreach (DataRow row in tbl.Rows)
                    {
                        BsonDocument a = this.mongoDb.GetLastData(Convert.ToInt32(row["id"])).Result;
                        DateTime dtLastProductAt = (a.Contains("updated_at")) ? a["updated_at"].ToUniversalTime().AddHours(7) : SqlDb.MinDateDb;
                        string idLast  = (a.Contains("_id")) ? a["_id"].AsObjectId.ToString() : "";;
                        row["updated_at"] = dtLastProductAt;
                        row["id_last"] = idLast; ;
                    }

                    this.Invoke(new Action(() =>
                    {
                        this.dataGridView1.DataSource = tbl;
                        this.dataGridView1.Sort(this.dataGridView1.Columns["updated_at"], ListSortDirection.Descending);
                    }));
                }
                catch (ThreadAbortException threadException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    Thread.Sleep(10000);
                }
                Thread.Sleep(1000);

            }
        }

        private void FrmTrackSiteOfData_Load(object sender, EventArgs e)
        {
       
            thread = new Thread(() => RunTrack(0));
            thread.Start();
        }

        private void FrmTrackSiteOfData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null &&
                thread.IsAlive == true)
                thread.Abort();
        }
    }
}
