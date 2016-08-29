using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace QT.Moduls.Company
{
    public partial class frmProduct : QT.Entities.frmBase
    {
        private Thread tDownload;
        bool finish = true;
        private String _connection = "";

        public override bool Save()
        {
            this.ctrCheckProduct1.Save();
            return true;
        }
        public override bool RefreshData()
        {
            this.ctrCheckProduct1.LoadData();
            return true;    
        }
        void download()
        {
            finish = true;
            this.Invoke((MethodInvoker)delegate
            {
                this.dataNavigator1.Visible = false;
                this.lamess.Visible = true;
                lamess.Text = "Đang tải dữ liệu...";
            });
            if (_connection == "")
            {
                _connection = QT.Entities.Server.ConnectionString;
                this.productTableAdapter.Connection.ConnectionString = _connection;
            }
            DB.ProductDataTable dt = new DB.ProductDataTable();
            this.productTableAdapter.FillBy_ListByCompany(dt, _companyID);
            this.Invoke((MethodInvoker)delegate
            {
                lamess.Text = "Đã tải xong dữ liệu";
                this.dB.Product.Clear();
                this.dB.Product.Merge(dt);
                this.dataNavigator1.Visible = true;
                this.lamess.Visible = false;
            });
         
            finish = true;
            if (tDownload != null)
            {
                if (tDownload.IsAlive)
                {
                    tDownload.Abort();
                    tDownload.Join();
                    tDownload = null;
                }
            }
        }
        private void LoadData()
        {
            if (finish)
            {
                tDownload = new Thread(new ThreadStart(download));
                tDownload.Start();
            }
        }
        long _companyID = 0;
        public frmProduct(long CompanyID)
        {
            InitializeComponent();
            _companyID = CompanyID;
            this.Text = "listProduct-" + _companyID.ToString();
            this.ctrCheckProduct1.CompanyID = _companyID;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.Product' table. You can move, or remove it, as needed.
            //LoadData();
            //this.ctrCheckProduct1.LoadData();
            RefreshData();

        }

        private void frmProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ctrCheckProduct1.DisposeTheart();
            finish = true;
            if (tDownload != null)
            {
                if (tDownload.IsAlive)
                {
                    tDownload.Abort();
                    tDownload.Join();
                    tDownload = null;
                }
            }
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (this.iDLabel1.Text.Length > 0)
            {
                this.productTableAdapter.FillBy_SelectOne(db1.Product, Convert.ToInt32(this.iDLabel1.Text));
                this.webContent.DocumentText = this.productContentLabel1.Text;
                this.webSumary.DocumentText = this.summaryLabel1.Text;
                string f = "<img src='{0}' width='100%' height='100%' />";
                this.webImage.DocumentText = string.Format(f, this.imageUrlsLabel1.Text);
            }
        }
    }
}
