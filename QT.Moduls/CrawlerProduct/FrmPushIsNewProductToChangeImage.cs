using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Moduls.RabbitMQ;
using Websosanh.Core.Drivers.RabbitMQ;
using QT.Entities;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmPushIsNewProductToChangeImage : Form
    {
        public FrmPushIsNewProductToChangeImage()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            MQPushDownloadImage rabbitMqPushDownloadImage = new MQPushDownloadImage(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct));
            string strCompanyID = txtCompany.Text;
            Task.Factory.StartNew(new Action(() =>
                {
                    this.Invoke(new Action(() =>
                        {
                            this.btnRun.Visible = false;
                        }));
                    ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                    DataTable tblCompany = productAdapter.GetCompanyCrawler(strCompanyID);
                    for (int iRowCompany = 0; iRowCompany < tblCompany.Rows.Count; iRowCompany++)
                    {
                        DataRow rowCompany = tblCompany.Rows[iRowCompany];
                        long CompanyID = QT.Entities.Common.Obj2Int64(rowCompany["ID"]);
                        string Domain = QT.Entities.Common.Obj2String(rowCompany["Domain"]);
                        DataTable tblProduct = productAdapter.GetProductIsNew(CompanyID);
                        foreach(DataRow rowInfo in tblProduct.Rows)
                        {
                            long ProductID = QT.Entities.Common.Obj2Int64(rowInfo["ID"]);
                            //rabbitMqPushDownloadImage.PushQueueChangeChangeImage(new Entities.MqChangeImage()
                            //    {
                            //        ProductID = ProductID,
                            //        Type = 2
                            //    });
                        }
                        this.Invoke(new Action(() =>
                            {
                                this.richTextBox1.AppendText(string.Format("\r\n Push {0} Product for Company {1} - {2}/{3}", tblProduct.Rows.Count, CompanyID
                                    , iRowCompany, tblCompany.Rows.Count));
                            }));
                    }

                    this.Invoke(new Action(() =>
                    {
                        this.btnRun.Visible = true;
                    }));

                }));
        }

        internal void LoadDomain(string p)
        {
            this.txtCompany.Text = p;
        }

        private void btnFixImageLInk_Click(object sender, EventArgs e)
        {
            MQPushDownloadImage rabbitMqPushDownloadImage = new MQPushDownloadImage(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct));
            string strCompanyID = txtCompany.Text;
            Task.Factory.StartNew(new Action(() =>
            {
                this.Invoke(new Action(() =>
                {
                    this.btnFixImageLInk.Visible = false;
                }));

                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                DataTable tblCompany = productAdapter.GetCompanyCrawler(strCompanyID);
                for (int iRowCompany = 0; iRowCompany < tblCompany.Rows.Count; iRowCompany++)
                {
                    DataRow rowCompany = tblCompany.Rows[iRowCompany];
                    long CompanyID = QT.Entities.Common.Obj2Int64(rowCompany["ID"]);
                    string Domain = QT.Entities.Common.Obj2String(rowCompany["Domain"]);
                    DataTable tblProduct = productAdapter.GetProductFixImage(CompanyID);
                    foreach (DataRow rowInfo in tblProduct.Rows)
                    {
                        long ProductID = QT.Entities.Common.Obj2Int64(rowInfo["ID"]);
                        string newImage = QT.Entities.Common.FixParalinkImage(rowInfo["ImageUrls"].ToString());
                        productAdapter.UpdateImageForProduct(ProductID, newImage);
                        //rabbitMqPushDownloadImage.PushQueueChangeChangeImage(new Entities.MqChangeImage()
                        //{
                        //    ProductID = ProductID,
                        //    Type = 2
                        //});
                    }
                    this.Invoke(new Action(() =>
                    {
                        this.richTextBox1.AppendText(string.Format("\r\n Push {0} Product for Company {1} - {2}/{3}", tblProduct.Rows.Count, CompanyID
                            , iRowCompany, tblCompany.Rows.Count));
                    }));
                }

                this.Invoke(new Action(() =>
                {
                    this.btnFixImageLInk.Visible = true;
                }));
            }));
        }

        private void btnPushIsNewAllCompany_Click(object sender, EventArgs e)
        {
            MQPushDownloadImage rabbitMqPushDownloadImage = new MQPushDownloadImage(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct));
            string strCompanyID = txtCompany.Text;
            Task.Factory.StartNew(new Action(() =>
            {
                this.Invoke(new Action(() =>
                {
                    this.btnRun.Visible = false;
                }));
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                DataTable tblCompany = productAdapter.GetCompanyCrawler(strCompanyID);
                for (int iRowCompany = 0; iRowCompany < tblCompany.Rows.Count; iRowCompany++)
                {
                    DataRow rowCompany = tblCompany.Rows[iRowCompany];
                    long CompanyID = QT.Entities.Common.Obj2Int64(rowCompany["ID"]);
                    string Domain = QT.Entities.Common.Obj2String(rowCompany["Domain"]);
                    DataTable tblProduct = productAdapter.GetProductNotImageLInk(CompanyID);
                    foreach (DataRow rowInfo in tblProduct.Rows)
                    {
                        long ProductID = QT.Entities.Common.Obj2Int64(rowInfo["ID"]);
                        //rabbitMqPushDownloadImage.PushQueueChangeChangeImage(new Entities.MqChangeImage()
                        //{
                        //    ProductID = ProductID,
                        //    Type = 2
                        //});
                    }
                    this.Invoke(new Action(() =>
                    {
                        this.richTextBox1.AppendText(string.Format("\r\n Push {0} Product for Company {1} - {2}/{3}", tblProduct.Rows.Count, CompanyID
                            , iRowCompany, tblCompany.Rows.Count));
                    }));
                }

                this.Invoke(new Action(() =>
                {
                    this.btnRun.Visible = true;
                }));

            }));
        }

      
    }
}
