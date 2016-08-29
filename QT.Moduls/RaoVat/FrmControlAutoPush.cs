using QT.Entities;
using QT.Entities.RaoVat;
using QT.Entities.Data;
using QT.Entities.Model.SaleNews;
using RabbitMQ.Client;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlSale
{
    public partial class FrmControlAutoPush : Form
    {
        RaoVatSQLAdapter configXPathAdapter = new RaoVatSQLAdapter(new QT.Entities.Data.SqlDb(QT.Entities.Server.ConnectionStringCrawler));
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmControlAutoPush));
        private RedisDb redisDb;
        private RedisSession redisSession;
        private SqlDb sqlDb;

        public FrmControlAutoPush()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }


        private bool bStop = false;

        private void WriteToLogJob(string mss)
        {
            if (!this.bStop)
            {
                this.Invoke(new Action(() =>
                    {
                        this.logPushTextBox.AppendText("\n" + mss);
                    }));
            }
        }

        /// <summary>
        /// Đẩy việc Crawler.
        /// </summary>
        /// <param name="typeCrawler"></param>
        public void PushTask(int typeCrawler, DataTable tbl)
        {
          
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            this.timer1.Interval = (int)this.spinEdit1.Value * 1000;
            this.timer1.Enabled = true;
            this.timer1.Start();
            this.logPushTextBox.AppendText("\n Start wait.....................");
            this.SetRunningState(true);
        }

        private void SetRunningState(bool bRun)
        {
            this.btnStart.Enabled = !bRun;
            this.btnStop.Enabled = bRun;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.logPushTextBox.AppendText("\nStop wating.................!");
            SetRunningState(false);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var iTypeCrawler = Convert.ToInt32(textBox1.Text); 
            DataTable tbl = this.gridControl1.DataSource as DataTable;
            Thread thread = new Thread(() => PushTask(iTypeCrawler, tbl));
            thread.Start();
        }

        private void btnPushTask_Click(object sender, EventArgs e)
        {
            int iTypeCrawler = Convert.ToInt32(textBox1.Text);
            DataTable tbl = this.gridControl1.DataSource as DataTable;
            Thread thread = new Thread(() => PushTask(iTypeCrawler, tbl));
            thread.Start();
        }

        private void FrmControlAutoPush_Load(object sender, EventArgs e)
        {
            int iCOunt = 0;
            while (iCOunt < 10)
            {
                try
                {

                    var redisMultiplexer = ConnectionMultiplexer.Connect(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port);
                    //var redisMultiplexer = ConnectionMultiplexer.Connect(new ConfigurationOptions()
                    //    {
                    //        AbortOnConnectFail = true,
                    //        ConfigCheckSeconds = 30,
                    //        ConnectRetry = 3,
                    //        ConnectTimeout = 30,
                    //        DefaultDatabase = 0,
                    //        EndPoints =
                    //        {
                    //            { QT.Entities.Server.RedisDB_Host, QT.Entities.Server.RedisDB_Port }
                    //        }
                    //    });
                    this.redisDb = new RedisDb(redisMultiplexer.GetDatabase());
                    this.redisSession = new RedisSession();
                    this.sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
                    break;
                }
                catch (Exception ex)
                {
                    Thread.Sleep(1000);
                    iCOunt++;
                }
            }
        }

        private void FrmControlAutoPush_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.bStop = true;
            this.timer1.Dispose();
           
        }

        internal void LoadOutData(DataTable tbl)
        {
            this.gridControl1.DataSource = tbl;
          
        }
    }
}
