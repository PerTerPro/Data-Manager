using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.RabbitMQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.RabbitMQ;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmReportMinLastUpdateProductCrawler : Form
    {
        private SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
        private DataTable tblReprot = null;
        public FrmReportMinLastUpdateProductCrawler()
        {
            InitializeComponent();
        }

        private void FrmReportMinLastUpdateProductCrawler_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            ReloadData();

        }

        private void ReloadData()
        {
            
            int typeReload = 0;
            if (ckVip.Checked) typeReload = 1;
            else typeReload = 2;

            tblReprot = sqldb.GetTblData("prc_Report_MinLastUpdateProductCrawler", CommandType.StoredProcedure, new System.Data.SqlClient.SqlParameter[] { 
                SqlDb.CreateParamteterSQL("@TypeReport",typeReload,SqlDbType.Int)});

            gridControl1.DataSource = tblReprot;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReloadData_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            ReloadData();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnPushIsNew_Click(object sender, EventArgs e)
        {
            MQPushDownloadImage rabbitMqPushDownloadImage = new MQPushDownloadImage(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct));
            List<string> lstDomain = new List<string>();

            foreach (var iRow in  this.gridView1.GetSelectedRows())
            {
                lstDomain.Add((this.gridView1.GetRow(iRow) as DataRowView)["Domain"].ToString());
            }

            foreach(string strCompanyID in lstDomain)
            {
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                DataTable tblCompany = productAdapter.GetCompanyCrawler(strCompanyID);
                for (int iRowCompany = 0; iRowCompany < tblCompany.Rows.Count; iRowCompany++)
                {
                    DataRow rowCompany = tblCompany.Rows[iRowCompany];
                    long CompanyID = QT.Entities.Common.Obj2Int64(rowCompany["ID"]);
                    string Domain = QT.Entities.Common.Obj2String(rowCompany["Domain"]);
                    DataTable tblProduct = productAdapter.GetProductIsNew(CompanyID);
                    foreach (DataRow rowInfo in tblProduct.Rows)
                    {
                        long ProductID = QT.Entities.Common.Obj2Int64(rowInfo["ID"]);
                        //rabbitMqPushDownloadImage.PushQueueChangeChangeImage(new Entities.MqChangeImage()
                        //{
                        //    ProductID = ProductID,
                        //    Type = 2
                        //});
                    }

                }

            }

            MessageBox.Show("Success!");

        }

        private void btncheckErrorDownloadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gridView1.FocusedRowHandle >= 0)
            {
                long CompanyID =
                    QT.Entities.Common.Obj2Int64((this.gridView1.GetRow(this.gridView1.FocusedRowHandle) as DataRowView)["ID"].ToString());
                FrmViewErrorIsNewDownloadImage frm = new FrmViewErrorIsNewDownloadImage(CompanyID);
                frm.Show();
            }
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==System.Windows.Forms.MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.gridControl1, new Point(e.X, e.Y));
            }
        }
    }
}
