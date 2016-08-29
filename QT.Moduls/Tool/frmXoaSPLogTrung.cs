using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using QT.Entities;

namespace QT.Moduls.Tool
{
    public partial class frmXoaSPLogTrung : QT.Entities.frmBase
    {
        private DBTool3TableAdapters.Product_LogsAddProductTableAdapter adt = new DBTool3TableAdapters.Product_LogsAddProductTableAdapter();
        private DBTool3.Product_LogsAddProductDataTable dtCompany = new DBTool3.Product_LogsAddProductDataTable();
        private DBTool3.Product_LogsAddProductDataTable dt = new DBTool3.Product_LogsAddProductDataTable();
        private DBTool3.Product_LogsAddProductDataTable dttem = new DBTool3.Product_LogsAddProductDataTable();
        
        public frmXoaSPLogTrung()
        {
            InitializeComponent();
        }
        Thread _tAlexa;
        private bool _finish = false;
        private int _position = 0;
        private void frmXoaSPLogTrung_FormClosing(object sender, FormClosingEventArgs e)
        {
            _finish = true;
            if (_tAlexa != null)
            {
                if (_tAlexa.IsAlive)
                {
                    _tAlexa.Abort();
                    _tAlexa.Join();
                    _tAlexa = null;
                }
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            _tAlexa = new Thread(new ThreadStart(doThreat));
            _tAlexa.Start();
        }
        void doThreat()
        {
            int type = 0;
            this.Invoke((MethodInvoker)delegate
            {
                laTong.Text = "Đang tải dữ liệu";
                type = Common.Obj2Int(this.iDTextBox.Text);
            });
            adt.FillBy_DistinctCompany_ManagerType(dtCompany, type);
            this.Invoke((MethodInvoker)delegate
            {
                laTong.Text = "Bắt đầu xóa";
            });
            int position = 0;
            foreach (DBTool3.Product_LogsAddProductRow dr in dtCompany)
            {
                position++;
                this.Invoke((MethodInvoker)delegate
                {
                    laTong.Text = string.Format("Bắt đầu xóa company {0} - {1}/{2}", dr.IDCompany.ToString(), position, dtCompany.Count);
                });
                adt.Fillby_CompanyIDCountMore1(dt, dr.IDCompany);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //Thread.Sleep(1500);
                    long ProductID = QT.Entities.Common.Obj2Int64(dt.Rows[i]["IDProduct"]);
                    dttem.Clear();
                    adt.FillBy_ProductID(dttem, ProductID);
                    if (dttem.Rows.Count > 0)
                    {
                        long ID = QT.Entities.Common.Obj2Int64(dttem.Rows[0]["ID"]);
                        adt.DeleteQuery_ByIDProduct_AndNotID(ID, ProductID);
                    }
                    this.Invoke((MethodInvoker)delegate
                    {
                        laTong.Text = string.Format("Bắt đầu xóa company {0} - {1}/{2}\nXóa productLog {3}/{4}", dr.IDCompany.ToString(), position, dtCompany.Count, i, dt.Rows.Count);
                    });
                }
            }




            
        }

        private void frmXoaSPLogTrung_Load(object sender, EventArgs e)
        {
            managerTypeTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.managerTypeTableAdapter.Fill(this.dBTool3.ManagerType);
            adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
        }

        private void btUpdateImageBTThu_Click(object sender, EventArgs e)
        {
            DBTool3.Product_ImageDataTable dtImage = new DBTool3.Product_ImageDataTable();
            DBTool3.ProductDataTable dtProduct = new DBTool3.ProductDataTable();
            DBTool3TableAdapters.Product_ImageTableAdapter adtImage = new DBTool3TableAdapters.Product_ImageTableAdapter();
            adtImage.Connection.ConnectionString = Server.ConnectionString;
            DBTool3TableAdapters.ProductTableAdapter adtProduct = new DBTool3TableAdapters.ProductTableAdapter();
            adtProduct.Connection.ConnectionString = Server.ConnectionString;

            adtProduct.FillBy_UrlImageNull_CategoryID(dtProduct, 1954);
            int i = 0;
            foreach (DBTool3.ProductRow dr in dtProduct)
            {
                adtImage.FillBy_IDObject(dtImage, dr.ID);
                if (dtImage.Rows.Count > 0)
                {
                    string image = string.Format("http://admin.websosanh.net{0}", dtImage.Rows[0]["ImageStore"].ToString());
                    adtProduct.UpdateQuery_UrlImage(image, dr.ID);
                    this.laTong.Text = string.Format("{0}/{1}", i++, dtProduct.Rows.Count);
                    Application.DoEvents();
                }
            }
        }

        private void btUpdateImageToProduct_Click(object sender, EventArgs e)
        {
            DBTool3.Product_ImageDataTable dtImageDistinct = new DBTool3.Product_ImageDataTable();
            DBTool3.Product_ImageDataTable dtImage = new DBTool3.Product_ImageDataTable();
            DBTool3.ProductDataTable dtProduct = new DBTool3.ProductDataTable();
            DBTool3TableAdapters.Product_ImageTableAdapter adtImage = new DBTool3TableAdapters.Product_ImageTableAdapter();
            adtImage.Connection.ConnectionString = Server.ConnectionString;
            DBTool3TableAdapters.ProductTableAdapter adtProduct = new DBTool3TableAdapters.ProductTableAdapter();
            adtProduct.Connection.ConnectionString = Server.ConnectionString;

            adtImage.FillBy_DistinctProductID(dtImageDistinct);
            int i = 0;
            foreach (DBTool3.Product_ImageRow row in dtImageDistinct)
            {
                adtImage.FillBy_IDObject(dtImage, row.IDObject);
                if (dtImage.Rows.Count > 0)
                {
                    if (dtImage.Rows.Count > 0)
                    {
                        string image = string.Format("http://admin.websosanh.net{0}", dtImage.Rows[0]["ImageStore"].ToString());
                        adtProduct.UpdateQuery_UrlImage(image, row.IDObject);
                        this.laTong.Text = string.Format("{0}/{1}", i++, dtImageDistinct.Rows.Count);
                        Application.DoEvents();
                    }
                }
            }
        }
    }
}
