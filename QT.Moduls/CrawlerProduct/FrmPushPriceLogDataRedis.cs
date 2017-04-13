using QT.Entities;
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
using Websosanh.Core.Drivers.Redis;
using WSS.Product.Utilities;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmPushPriceLogDataRedis : Form
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmPushPriceLogDataRedis));

        public FrmPushPriceLogDataRedis()
        {
            InitializeComponent();
        }

        private void ctrTreeCompany1_Load(object sender, EventArgs e)
        {
        }


        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private void btnPushData_Click(object sender, EventArgs e)
        {
            this.btnPushData.Visible = false;
            var token = this.cancellationTokenSource.Token;

            Task.Factory.StartNew(() =>
            {
                int ibegin = 0;
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                DataTable tblData = new DataTable();
                int MaxRow = productAdapter.GetTblPriceLogCount();
                do
                {
                    tblData = productAdapter.GetTblPriceLog(ibegin, ibegin + 50000);
                    token.ThrowIfCancellationRequested();
                    ibegin = ibegin + 50000 + 1;
                    for (int iRow = 0; iRow < tblData.Rows.Count; iRow++)
                    {
                        DataRow rowPrice = tblData.Rows[iRow];
                        long ProductID = Convert.ToInt64(rowPrice["ProductID"]);
                        int Price = Convert.ToInt32(rowPrice["NewPrice"]);
                        DateTime TimeUpdate = Convert.ToDateTime(rowPrice["DateUpdate"]);
                        RedisPriceLogAdapter.PushMerchantProductPrice(ProductID, Price, TimeUpdate);
                        log.Info("Item to:" + (ibegin + iRow).ToString());
                    }
                    tblData = productAdapter.GetTblPriceLog(ibegin, ibegin + 50000);
                    this.Invoke(new Action(() =>
                    {
                        richTextBox2.AppendText(string.Format("\r\n{0}", ibegin));
                    }));

                }
                while (tblData.Rows.Count > 0 || ibegin < MaxRow + 100000);

            }, token);
        }

        private void RunSync(int iFrom, int iTo)
        {

        }

        private void FrmPushPriceLogDataRedis_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private void btnPushPriceCurrent_Click(object sender, EventArgs e)
        {
            this.btnPushPriceCurrent.Visible = false;
            var token = this.cancellationTokenSource.Token;
            Task.Factory.StartNew(() =>
            {
                int iPageCurrent = 1;
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                DataTable tblData = productAdapter.GetProductByPage(iPageCurrent++);
                while (tblData.Rows.Count > 0)
                {
                    token.ThrowIfCancellationRequested();
                    for (int iRow = 0; iRow < tblData.Rows.Count; iRow++)
                    {
                        DataRow rowPrice = tblData.Rows[iRow];
                        long ProductID = Convert.ToInt64(rowPrice["ID"]);
                        int Price = Convert.ToInt32(rowPrice["Price"]);
                        DateTime TimeUpdate = DateTime.Now;
                        RedisPriceLogAdapter.PushMerchantProductPrice(ProductID, Price, TimeUpdate);
                        log.Info("Item to:" + ProductID.ToString());
                    }
                    this.Invoke(new Action(() =>
                    {
                        richTextBox2.AppendText(string.Format("\r\n{0}", (iPageCurrent * 10000).ToString()));
                    }));

                    tblData = productAdapter.GetProductByPage(iPageCurrent++);
                }
                this.Invoke(new Action(() =>
                {
                    richTextBox2.AppendText(string.Format("\r\nSuccess!"));
                }));
            }, token);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.btnPushPriceLogOld.Visible = false;
            var token = this.cancellationTokenSource.Token;
            Task.Factory.StartNew(() =>
            {
                int ibegin = 0;
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.LogConnectionString));
                DataTable tblData = new DataTable();
                int MaxRow = productAdapter.GetTblPriceLogCount();
                do
                {
                    tblData = productAdapter.GetTblPriceLog(ibegin, ibegin + 50000);
                    token.ThrowIfCancellationRequested();
                    ibegin = ibegin + 50000 + 1;
                    for (int iRow = 0; iRow < tblData.Rows.Count; iRow++)
                    {
                        DataRow rowPrice = tblData.Rows[iRow];
                        long ProductID = Convert.ToInt64(rowPrice["ProductID"]);
                        int Price = Convert.ToInt32(rowPrice["NewPrice"]);
                        DateTime TimeUpdate = Convert.ToDateTime(rowPrice["DateUpdate"]);
                        RedisPriceLogAdapter.PushMerchantProductPrice(ProductID, Price, TimeUpdate);
                        log.Info("Item to:" + (ibegin + iRow).ToString());
                    }
                    tblData = productAdapter.GetTblPriceLog(ibegin, ibegin + 50000);
                    this.Invoke(new Action(() =>
                    {
                        richTextBox2.AppendText(string.Format("\r\n{0}", ibegin));
                    }));

                }
                while (tblData.Rows.Count > 0 || ibegin < MaxRow + 100000);

            }, token);
        }
    }
}
