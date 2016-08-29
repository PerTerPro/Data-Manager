using Bussiness;
using QT.Entities.Data;
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

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmAutoPushCrawl : Form
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

        public void WriteLog (string mss)
        {
            this.Invoke(new Action(() =>
            {
                if (txtLogRun.TextLength > 100000) txtLogRun.Clear();
                txtLogRun.AppendText(string.Format("\nTime:{0} Mss:{1}", DateTime.Now.ToString("dd/MM/yyyy hh:ss"), mss));
            }));
        }

        public FrmAutoPushCrawl()
        {
            InitializeComponent();
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
            bool bistestk = ckIsTest.Checked;
            int typeCrawler = cboTypeCrawl.SelectedIndex;
            int numberJob = Convert.ToInt32(spinMaxJob.Value);

            this.IsStop = false;
            Thread thread = new Thread(() => RunPushAuto(intervalRun, queryRun, allowSaveOld, allowSaveNew, bistestk,typeCrawler, numberJob));
            thread.Start();
        }

        public void RunPushAuto(int iTimeInterval, string query, bool allowSaveOld
            , bool allowSaveNew, bool bIsTest, int typeCrawler
            , int numberJob)
        {
            while (!this.IsStop)
            {
                PushJob(query, allowSaveOld, allowSaveNew, bIsTest,typeCrawler,numberJob);
                Thread.Sleep(iTimeInterval * 1000);
            }
        }

        public void PushJob(string sql, bool allowSaveOld, bool allowSaveNew
            , bool bIsTest, int typeCrawler, int numberJob)
        {
            try
            {

                var connectionMQ = RabbitMQCreator.CreateConnection();
                var channel = connectionMQ.CreateModel();
                var a2 = channel.QueueDeclare(this.queueNameTextBox.Text, true, false, false, null);
                if (a2.MessageCount > numberJob)
                {
                    WriteLog("Overload message RabbitMQ. Wait next!");
                }
                else
                {
                    DataTable tbl = SqlDb.Instance.GetTblData(sql, CommandType.Text, null);

                    foreach (DataRow row in tbl.Rows)
                    {
                        long company = Convert.ToInt64(row["Company"]);
                        string url = QT.Entities.Common.Obj2String(row["Detailurl"]);
                        QT.Entities.CrawlerProduct.TaskMQProduct task = new QT.Entities.CrawlerProduct.TaskMQProduct()
                        {
                            CompanyID = company,
                            Deep = 0,
                            ImageUrl = "",
                            IsExtraction = false,
                            IsProduct = true,
                            Session = 0,
                            TypeCrawler = typeCrawler,
                            Url = url,
                            IsTest = bIsTest,
                            AllowSaveNewProduct = allowSaveNew,
                            AllowSaveOldProduct = allowSaveOld
                        };

                        var a1 = Websosanh.Core.Common.BAL.ProtobufTool.Serialize(task);
                        channel.BasicPublish("", this.queueNameTextBox.Text, null, a1);

                        WriteLog(string.Format
                            ("Pushed job: config:{0} allowSaveOld:{1} allowSaveNew:{2} url:{3} test:{4} session:{5} typeCrawle:{6}",
                           company, allowSaveOld, allowSaveNew, url, bIsTest, "0", typeCrawler));
                    }
                }
                connectionMQ.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.IsStop = true;
        }

        private void cboTypeCrawl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlExampleFullCrawler = @"SELECT TOP 100 ID AS Company, Website AS DetailUrl, 0 AS ID
FROM Company
WHERE LastFullCrawler IS NULL 
AND Status = 1
AND UseDataFeed = 0";

            string sqlExampleNewCrawler = @"SELECT TOP 100 ID AS Company, Website AS DetailUrl, 0 AS ID
FROM Company
WHERE UseDataFeed = 0
AND status = 1
ORDER BY LastCrawler DESC ";

            string sqlExampleReloadData = @"Select TOP 100  Company, DetailUrl, a.ID, LastUpdate, Valid, c.Status AS company_status
from Product a
INNER JOIN Company c ON a.Company = c.ID
where Company != 6619858476258121218
AND c.Status = 1
and Valid=1
order by LastUpdate";

            var iTypeCrawler = cboTypeCrawl.SelectedIndex;
            switch (iTypeCrawler)
            {
                case (int)QT.Entities.CrawlerProduct.ETypeCrawler.FullCrawler:
                    {
                        txtQuery.Text = sqlExampleFullCrawler;
                        ckIsTest.Checked = true;
                        ckAllowSaveNewProduct.Checked = true;
                        ckAllowSaveOldProduct.Checked = true;
                    }break;
                case (int)QT.Entities.CrawlerProduct.ETypeCrawler.ReloadData:
                    {
                        txtQuery.Text = sqlExampleReloadData;
                        ckIsTest.Checked = true;
                        ckAllowSaveNewProduct.Checked = false;
                        ckAllowSaveOldProduct.Checked = true;
                    } break;
                case (int)QT.Entities.CrawlerProduct.ETypeCrawler.FindNewCrawler:
                    {
                        txtQuery.Text = sqlExampleNewCrawler;
                        ckIsTest.Checked = true;
                        ckAllowSaveNewProduct.Checked = true;
                        ckAllowSaveOldProduct.Checked = false;
                    } break;
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
    }
}
