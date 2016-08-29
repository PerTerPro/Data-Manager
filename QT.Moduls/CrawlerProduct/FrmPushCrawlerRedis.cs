using Bussiness;
using QT.Entities.Data;
using QT.Moduls.Crawler;
using QT.Moduls.CrawlProd;
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

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmPushCrawlerRedis : Form
    {
        private bool isStop = true;
     
        private bool IsStop
        {
            get
            {
                return isStop;
            }
            set
            {
                this.isStop = value;
                this.Invoke(new Action(() =>
                {
                    btnStart.Visible = this.isStop;
                    btnStop.Visible = !this.isStop;
                }));
            }
        }

        public void WriteLog(string mss)
        {
            this.Invoke(new Action(() =>
            {
                if (txtLogRun.TextLength > 100000) txtLogRun.Clear();
                txtLogRun.AppendText(string.Format("\nTime:{0} Mss:{1}", DateTime.Now.ToString("dd/MM/yyyy hh:ss"), mss));
            }));
        }

        public FrmPushCrawlerRedis()
        {
            InitializeComponent();
            this.gridControl1.Visible = false;
        }

        private void FrmAutoPushCrawl_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.IsStop = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int intervalRun = Convert.ToInt32(spinInterval.Value);
            string queryRun = Convert.ToString(txtQuery.Text);
            bool allowSaveNew = ckAllowSaveNewProduct.Checked;
            bool allowSaveOld = ckAllowSaveOldProduct.Checked;
            string queueRun = queueNameTextBox.Text;
            bool bistestk = ckIsTest.Checked;
            int typeCrawler = cboTypeCrawl.SelectedIndex;
            int numberJob = Convert.ToInt32(spinMaxJob.Value);
            bool isExtraction = ckExtraction.Checked;
            DataTable tbl = (this.gridControl1.DataSource as DataTable);
            bool useQuery = ckUserCompany.Checked;
            int iTimeReset = Convert.ToInt32(spinWaitReset.Value);
            this.IsStop = false;

            Thread thread = new Thread(() => RunPushAuto(
                useQuery, intervalRun, queryRun
                , allowSaveOld, allowSaveNew, bistestk
                , typeCrawler, numberJob, tbl, queueRun, iTimeReset));

            thread.Start();
        }

        public void RunPushAuto(bool useQuery,int iTimeInterval, string query, bool allowSaveOld
            , bool allowSaveNew, bool bIsTest, int typeCrawler
            , int numberJob, DataTable tblOut, string queueName
            , int iTimeReset)
        {
            while (!this.IsStop)
            {
                PushJob( useQuery, query, allowSaveOld, allowSaveNew, bIsTest
                    , typeCrawler, numberJob,tblOut,queueName, iTimeReset);
                Thread.Sleep(iTimeInterval * 1000);
            }
        }

        public void PushJob(bool useQuery, string sql, bool allowSaveOld, bool allowSaveNew
            , bool bIsTest, int typeCrawler, int numberJob
            , DataTable tblOut = null, string queueName = "crawler_product_company_wait", int iTimeReset = 10)
        {
            try
            {
                RedisSession redisSession = new RedisSession();
            
              
                SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
                DataTable tbl = (!useQuery) ? sqlDb.GetTblData(sql, CommandType.Text, null) : tblOut;
                foreach (DataRow row in tbl.Rows)
                {
                    long companyID = Convert.ToInt64(row["ID"]);
                    int iWait = redisSession.CheckRunning(companyID, typeCrawler, sqlDb.GetCurrent(), iTimeReset);
                    if (iWait <= 0)
                    {
                        string url = QT.Entities.Common.Obj2String(row["Website"]);

                        //Xóa Cache dữ liệu liên quan session.
                        QueueWaitRedis queueWait = new QueueWaitRedis(companyID, typeCrawler);
                        queueWait.Clean();
                        SetAddedQueueRedis setAddedQueu = new SetAddedQueueRedis(companyID, typeCrawler);
                        setAddedQueu.Clean();

                        var a = Websosanh.Core.Common.BAL.ProtobufTool.Serialize(new QT.Entities.CrawlerProduct.MQCompanyWaitCrawler
                        {
                            CompanyID = companyID,
                            IsTest = bIsTest,
                            TypeCrawler = typeCrawler,
                            datePush = DateTime.Now,
                            ExtractionLink = (typeCrawler != 1)
                        });
                      
                        QueueWaitRedis queueWaitRedis = new QueueWaitRedis(companyID, typeCrawler);
                        queueWaitRedis.PushJob(new Job()
                            {
                                deep = 0,
                                url = url
                            });

                        redisSession.InitSession(companyID, typeCrawler);
                        this.WriteLog(string.Format("Pushed job Company:{0}. TypeCrawler:{1}", companyID, typeCrawler));
                    }
                    else
                    {
                        this.WriteLog(string.Format("Skip company running company:{0}. TypeCrawler:{1}. Wait: {2}", companyID, typeCrawler, iWait));
                    }
                }

            }
            catch (Exception ex)
            {
                this.WriteLog("EXCEPTION POST JOB:" + ex.Message);
            }
            finally
            {
                
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.IsStop = true;
        }

        private void cboTypeCrawl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryReload = @"  select TOP 10 id, Website, LastCrawler, LastFullCrawler
  from company 
  where status = 1 and LastFullCrawler is not null
   AND DataFeedType = 0
  order by LastCrawler";

            string queryFullCrawler = @"  select TOP 10 id, Website, LastCrawler, LastFullCrawler
  from company 
  where status = 1 and LastFullCrawler is  null 
  AND DataFeedType = 0";

            if (this.cboTypeCrawl.SelectedIndex==0)
            {
                txtQuery.Text = queryFullCrawler;
            }
            else if (this.cboTypeCrawl.SelectedIndex==1||this.cboTypeCrawl.SelectedIndex==2)
            {
                txtQuery.Text = queryReload;
            }
        }

        private void btnCheckData_Click(object sender, EventArgs e)
        {
            SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
            DataTable tbl = sqlDb.GetTblData(txtQuery.Text);
            FrmShowDataTable.ShowData(tbl);
        }

        private void FrmAutoPushCrawl_Load(object sender, EventArgs e)
        {
            cboTypeCrawl.SelectedIndex = 1;
          
        }

        public void LoadOutData(DataTable tbl)
        {
            this.gridControl1.Visible = true;
            this.gridControl1.DataSource = tbl;
            panelControl3.Visible = false;
            ckUserCompany.Checked = true;
        }

        private void ckUserCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (ckUserCompany.Checked)
            {
                txtQuery.Visible = false;
                gridControl1.Visible = true;
            }
            else
            {
                gridControl1.Visible = false;
                txtQuery.Visible = true;
            }
        }
    }
}
