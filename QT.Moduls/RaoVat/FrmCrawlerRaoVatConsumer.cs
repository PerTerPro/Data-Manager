using QT.Entities.RaoVat;
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

namespace QT.Moduls.RaoVat
{
    public partial class FrmCrawlerRaoVatConsumer : Form
    {
        bool bStart = true;
        bool bPause = true;
        private Thread thread;
        private log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmCrawlerRaoVatConsumer));

        public FrmCrawlerRaoVatConsumer() 
        {
            InitializeComponent();
        }

        public FrmCrawlerRaoVatConsumer(int ConfigID, ETypeCrawlRaoVat typeCrawler)
        {
            InitializeComponent();

            this.ConfigID = ConfigID;
            this.typeCrawler = typeCrawler;
        }

        public void doCrawl(int configID, ETypeCrawlRaoVat typeCrawler)
        {
            SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
            RaoVatSQLAdapter adapter = new Entities.RaoVat.RaoVatSQLAdapter(sqlDb);
            ConfigXPaths configuration = adapter.GetConfigByID(this.ConfigID);
            while (!this.bPause)
            {
                try
                {
                    SimpleCrawlerRaoVat crawler = new SimpleCrawlerRaoVat(configID, typeCrawler);

                    crawler.eventWhenStart += new Crawler.AbstractionCrawler.EventReportRun(delegate(object sender, string mss)
                        {
                            WriteLog("eventWhenStart", mss);
                        });

                    crawler.eventWhenGetJob += new Crawler.AbstractionCrawler.EventReportRun(delegate(object sender, string mss)
                        {
                            WriteLog("eventWhenGetJob", mss);
                            
                            this.Invoke(new Action(() =>
                            {
                                this.spinnumberVisitedLink.Value = Convert.ToInt32(spinnumberVisitedLink.Value) + 1;
                            }));
                        });

                    crawler.eventWhenPushJob += new Crawler.AbstractionCrawler.EventReportRun(delegate(object sender, string mss)
                        {
                            WriteLog("eventWhenPushJob", mss);
                        });

                    crawler.eventWhenEnd += new Crawler.AbstractionCrawler.EventReportRun(delegate(object sender, string mss)
                    {
                        WriteLog("eventWhenEnd", mss);
                    });

                    crawler.eventWhenSuccessProduct += new Crawler.AbstractionCrawler.EventReportRun(delegate(object sender, string mss)
                        {
                            WriteLog("eventWhenSuccessProduct", mss);
                            this.Invoke(new Action(() =>
                                {
                                    this.spinNumberProduct.Value = Convert.ToInt32(spinNumberProduct.Value) + 1;
                                }));
                        });
                    
                    crawler.StartCrawler();
                    Thread.Sleep(20000);
                }
                catch (ThreadAbortException ex1)
                {
                    break;
                }
                catch (Exception ex)
                {
                    log.ErrorFormat(ex.Message);
                    WriteLog("Exception", string.Format("Exception:{0}", ex.Message));
                    Thread.Sleep(20000);
                }
            }
        }

        private void WriteLog(string eventcall, string mss)
        {
            this.Invoke(new Action(() =>
            {
                if (!tabControl1.TabPages.ContainsKey(eventcall))
                {
                    tabControl1.TabPages.Add(eventcall, eventcall);
                    RichTextBox richTextBox = new RichTextBox();
                    richTextBox.Dock = DockStyle.Fill;
                    tabControl1.TabPages[eventcall].Controls.Add(richTextBox);
                }

                RichTextBox txtLog = tabControl1.TabPages[eventcall].Controls[0] as RichTextBox;
                if (txtLog.TextLength > 1000000) txtLog.Clear();
                txtLog.AppendText(string.Format("\n\n At:{0} :{1}"
                    , DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    , mss));
            }));
        }

        Dictionary<string, TabControl> dicTabReport = new Dictionary<string, TabControl>();


        public int ConfigID { get; set; }

        public ETypeCrawlRaoVat typeCrawler { get; set; }

        private void FrmCrawlBySql_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartCrawler();
        }

        private void SetState()
        {
            this.Invoke(new Action(() =>
                {

                }));
        }

        private void FrmCrawlBySql_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.thread!=null && this.thread.IsAlive)
            {
                this.thread.Abort();
            }
        }

        public void StartCrawler()
        {
            if (this.bStart)
            {
                this.btnStart.Visible = false;
                this.btnStart.Text = "Pause";
                this.bPause = false;
                this.bStart = false;
                this.thread = new Thread(() => doCrawl(this.ConfigID, this.typeCrawler));
                this.thread.Start();
            }
            else
            {
                this.bPause = !this.bPause;
            }
            btnStart.Text = (this.bPause) ? "Run" : "Pause";
        }
    }
}
