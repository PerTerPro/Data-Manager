using QT.Entities.CrawlerProduct;
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

namespace QT.Moduls.Crawler
{
    public partial class FrmPushJobCrawler : Form
    {
        ProductAdapter productAdapter = null;
       
        QT.Entities.CrawlerProduct.CrawlerProductAdapter crawlerAdapter = null;

        public FrmPushJobCrawler()
        {
            InitializeComponent();

            this.productAdapter  = new ProductAdapter(new Entities.Data.SqlDb(QT.Entities.Server.ConnectionString));
       
            this.crawlerAdapter = new CrawlerProductAdapter(new SqlDb(QT.Entities.Server.ConnectionStringCrawler));
        }

        public FrmPushJobCrawler(string textQuery,string queueName, int typeCrawler)
        {
            InitializeComponent();

            this.productAdapter = new ProductAdapter(new Entities.Data.SqlDb(QT.Entities.Server.ConnectionString));
         
            this.crawlerAdapter = new CrawlerProductAdapter(new SqlDb(QT.Entities.Server.ConnectionStringCrawler));

            this.txtQueueName.Text = queueName;
            this.txtQuery.Text = textQuery;
            this.spinTypeCrawler.Value = typeCrawler;
     
        }

     

        private void btnStart_Click(object sender, EventArgs e)
        {
            string query = txtQuery.Text;
            string queueName = txtQueueName.Text;
            int typecrawler = Convert.ToInt32(spinTypeCrawler.Value);
            threadStart = new Thread(() => StartRun(query, queueName, typecrawler));
            threadStart.Start();
            this.btnStart.Visible = false;
        }

        private void StartRun(string query, string queueName, int typecrawler, bool OneTime = false, DataTable tblPush = null)
        {
            while (true)
            {
                try
                {
                    DateTime dtCurrent = this.productAdapter.GetSqlDb().GetCurrent();
                }
                catch (ThreadAbortException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    WriteLog("Exception run:" + ex.Message);
                    Thread.Sleep(10000);
                }
            }
        }

        private void WriteLog(string data)
        {
            this.Invoke(new Action(() =>
                {
                    this.txtReportPush.AppendText(string.Format("\nAt {0}: {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), data));
                }));
        }

        private void FrmPushJobCrawler_FormClosing(object sender, FormClosingEventArgs e)
        {
         

            if (this.threadStart!=null && this.threadStart.IsAlive)
            {
                this.threadStart.Abort();
            }
        }

        public Thread threadStart { get; set; }

        private void FrmPushJobCrawler_Load(object sender, EventArgs e)
        {

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            
       
            DataTable tbl = productAdapter.GetListCompanyNeedRecrawler(txtQuery.Text);
            this.gridControl1.DataSource = tbl;
            this.gridView1.RefreshData();
        }

        public void LoadOutData(DataTable tbl)
        {
            this.gridControl1.DataSource = tbl;
            this.gridView1.RefreshData();
            this.txtQueueName.Text = "TaskCrawler_FindNewProduct";
            this.txtQuery.Text = "";
            this.txtQuery.Visible = false;
            this.btnStart.Visible = false;
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPushCurrent_Click(object sender, EventArgs e)
        {
            if (this.gridControl1.DataSource == null)
            {
                MessageBox.Show("Source empty!");
            }
            else
            {
                string query = txtQuery.Text;
                string queueName = txtQueueName.Text;
                int typecrawler = Convert.ToInt32(spinTypeCrawler.Value);
                StartRun(query, queueName, typecrawler, true, this.gridControl1.DataSource as DataTable);
                MessageBox.Show("Sucess");
            }
        }
    }
}
