using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
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

namespace WSS.Service.Crawler.Consumer.FindNew
{
    public partial class FrmCrawlerData : Form
    {

        CancellationTokenSource tokenSource = new CancellationTokenSource();
        Queue<long> queueCompany = new Queue<long>();

        private int typeCrawler;
        public FrmCrawlerData()
        {
            InitializeComponent();
        }

        public FrmCrawlerData(Queue<long> queueCrawler, int typeCrawler)
        {
            InitializeComponent();
            this.queueCompany = queueCrawler;
            this.typeCrawler = typeCrawler;
            if (this.typeCrawler==0)
            {
                this.Text = "FindNew";
            }
            else
            {
                this.Text = "Reload";
            }
        }

        private void AddToQueue(long companyID)
        {
            this.queueCompany.Enqueue(companyID);
            this.Invoke(new Action(() =>
            {
                this.lblQueueCount.Text = string.Format("Q:{0}", queueCompany.Count);
            }));
        }

        private void FrmRun_Load(object sender, EventArgs e)
        {
            

        }

        private void ShowLogEvent(string log)
        {
            this.Invoke(new Action(() =>
            {
                this.richTextBox1.AppendText(string.Format("\r\n {0}", log));
            }));
        }

        private void Start()
        {
        }

        private void StartReload(int numberThread = 1, bool CheckOtherRunning = false)
        {
            for (int i = 0; i < numberThread; i++)
            {
                int iThread = i;
                Task.Factory.StartNew(() =>
                                    {
                                        WorkerReload worker = new WorkerReload(iThread, tokenSource.Token, Guid.NewGuid().ToString(), CheckOtherRunning);
                                        worker.EventShowLog += new DelegateShowLog(ShowLogEvent);
                                        worker.EventGetCompanyCrawler += new DelegateGetCompanyCrawler(GetCompanyCrawler);
                                        worker.Start();
                                    });
            }
        }

        private long GetCompanyCrawler()
        {
            long companyID = 0;
            if (this.queueCompany.Count > 0) companyID = this.queueCompany.Dequeue();
            this.Invoke(new Action(() =>
            {
                this.lblQueueCount.Text = string.Format("Q:{0}", queueCompany.Count);
            }));
            return companyID;
        }

        public void StartFindNew(int numberThread = 1, bool CheckRunning = false)
        {
            for (int i = 0; i < numberThread; i++)
            {
                int iThread = i;
                Task.Factory.StartNew(() =>
                {
                    WorkerFindNew worker = new WorkerFindNew(iThread, tokenSource.Token, Guid.NewGuid().ToString(), CheckRunning);
                    worker._eventShowLog += new DelegateShowLog(ShowLogEvent);
                    worker._eventGetCompanyCrawler += new DelegateGetCompanyCrawler(GetCompanyCrawler);
                    worker.Start();
                });
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool CheckOtherRunning = ckCheckOtherRunning.Checked;
            if (this.typeCrawler == 0)
            {
                StartFindNew(Convert.ToInt32(spinEdit1.Value), CheckOtherRunning);
            }
            else
            {
                StartReload(Convert.ToInt32(spinEdit1.Value), CheckOtherRunning);
            }
            btnStart.Visible = false;
        }

        private void FrmCrawlerData_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tokenSource.Cancel();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            ProductAdapter pt = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            string[] arData = txtCompanyDomain.Text.Split(new char[] { }, 500, StringSplitOptions.RemoveEmptyEntries);
            int countCompany = 0;
            foreach (var strCompany in arData)
            {
                long companyID = 0;
                if (long.TryParse(strCompany, out companyID))
                {
                    queueCompany.Enqueue(companyID);
                    countCompany++;
                }
                else
                {
                    companyID = pt.GetCompanyIDFromDomain(strCompany);
                    if (companyID > 0) queueCompany.Enqueue(companyID);
                    countCompany++;
                }
            }

            if (countCompany > 0)
            {
                this.txtCompanyDomain.Clear();
                this.lblQueueCount.Text = string.Format("Q:{0}", queueCompany.Count);
                MessageBox.Show(string.Format("Added {0} companys", countCompany));
            }
        }
    }
}
