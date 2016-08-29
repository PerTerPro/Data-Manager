using Newtonsoft.Json;
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
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmReportLogCrawlerMQ : Form
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmReportLogCrawlerMQ));
        private Worker worker;
        SqlDb sqldb = new SqlDb("Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200");
        public FrmReportLogCrawlerMQ()
        {
            InitializeComponent();
            richTextBoxReport.AppendText("Machine\tWorker\tMss\t\tVisitedLink\t\tProduct\t\tQueueLink\t\tDatePush\t\tDomain\n");
        }

        private void FrmReportLogCrawlerMQ_Load(object sender, EventArgs e)
        {
            Thread Run = new Thread(() => Start());
            Run.Start();
        }
        public void Start()
        {
            log.Info("Start LogCrawlerMQtoSql");
            var rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            worker = new Worker("CrawlerProductReload", false, rabbitMQServer);
            log.Info("Start consumer!");
            worker.JobHandler = (downloadImageJob) =>
            {
                log.Info("Get job from MQ");
                try
                {
                    Encoding enc = new UTF8Encoding(true, true);
                    string strData = enc.GetString(downloadImageJob.Data);
                    LogCrawlerMQ job = JsonConvert.DeserializeObject<LogCrawlerMQ>(strData);
                    SaveToSql(job.Machine, job.Worker, job.Mss, job.VisitedLink, job.Product, job.QueueLink, job.DatePush, job.ProductData, job.Domain);
                    log.Info(string.Format("Log for {0}", strData));
                    this.Invoke(new Action(() =>
                    {
                        richTextBoxReport.AppendText("\n" + job.Machine + "\t" + job.Worker + "\t" + job.Mss + "\t\t" + job.VisitedLink + "\t\t" + job.VisitedLink + "\t\t" + job.QueueLink + "\t\t" + job.DatePush + "\t\t" + job.Domain);
                    }));
                    return true;
                }
                catch (Exception ex01)
                {
                    log.Error("Exception:", ex01);
                    return true;
                }
            };
            worker.Start();
        }

        public void SaveToSql(string Machine, string Worker, string Mss, int VisitedLink, long Product, int QueueLink, DateTime DatePush, string ProductData, string Domain)
        {
            sqldb.RunQuery("INSERT INTO LogCrawlerMQ (Machine, Worker, Mss, VisitedLink, Product, QueueLink, DatePush,ProductData,Domain) VALUES (@Machine,@Worker,@Mss,@VisitedLink,@Product,@QueueLink,@DatePush,@ProductData,@Domain)", CommandType.Text, new SqlParameter[] { 
                sqldb.CreateParamteter("@Machine",Machine,SqlDbType.NVarChar),
                sqldb.CreateParamteter("@Worker",Worker,SqlDbType.NVarChar),
                sqldb.CreateParamteter("@Mss",Mss,SqlDbType.NVarChar),
                sqldb.CreateParamteter("@VisitedLink",VisitedLink,SqlDbType.Int),
                sqldb.CreateParamteter("@Product",Product,SqlDbType.BigInt),
                sqldb.CreateParamteter("@QueueLink",QueueLink,SqlDbType.Int),
                sqldb.CreateParamteter("@DatePush",DatePush,SqlDbType.DateTime),
                sqldb.CreateParamteter("@ProductData",ProductData,SqlDbType.NVarChar),
                sqldb.CreateParamteter("@Domain",Domain,SqlDbType.NVarChar)
            });
        }
    }
}
