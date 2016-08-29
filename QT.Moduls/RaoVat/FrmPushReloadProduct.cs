using MongoDB.Bson;
using QT.Entities.Data;
using QT.Entities.RaoVat;
using QT.Moduls.CrawlSale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.RaoVat
{
    public partial class FrmPushReloadProduct : Form
    {
        RaoVatSQLAdapter adapterRaoVat = new RaoVatSQLAdapter(new SqlDb(QT.Entities.Server.ConnectionStringCrawler));
        private Thread thread;

        public FrmPushReloadProduct()
        {
            InitializeComponent();
        }

        private void btnPushImediate_Click(object sender, EventArgs e)
        {
            string query = txtQuery.Text;
            int limit  =1000;
            thread = new Thread(() => RunPush(query, limit));
            thread.Start();
        }

        private void RunPush(string query,int limit)
        {
            while (true)
            {
                try
                {
                    MongoDbRaoVat mongoDbAdapter = new MongoDbRaoVat();
                    List<BsonDocument> lst = mongoDbAdapter.GetLstProductReload(query,limit );
                    foreach (BsonDocument itemNeedReload in lst)
                    {
                        try
                        {
                            adapterRaoVat.PushJobReload(Convert.ToInt64(itemNeedReload["id"])
                                , Convert.ToString(itemNeedReload["url"])
                                , 10
                                , Convert.ToInt32(itemNeedReload["source_id"]));
                        }
                        catch (Exception ex)
                        {
                            WriteLog(ex.Message);
                            Thread.Sleep(1000);
                        }
                    }
                }
                catch (ThreadAbortException exThread)
                {
                    break;
                }
                catch (Exception ex)
                {
                    Thread.Sleep(10000);
                }
            }
        }

        private void WriteLog(string p)
        {
            this.Invoke(new Action(() =>
                {
                    txtReport.AppendText(string.Format("\n At: {0} {1", DateTime.Now.ToString("yyyy-MM-dd HH:ss"), p));
                }));
        }

        private void FrmPushReloadProduct_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
