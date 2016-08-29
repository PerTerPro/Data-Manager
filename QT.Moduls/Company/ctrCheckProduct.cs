using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using QT.Entities;
using System.Net;

namespace QT.Moduls.Company
{
    public partial class ctrCheckProduct : UserControl
    {
        long _companyID = 0;
        byte[] imageBytes404 = null;
        public ctrCheckProduct()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            webContent.ScriptErrorsSuppressed = true;
            webSumary.ScriptErrorsSuppressed = true;
            var webClient = new WebClient();
            string s = "http://websosanh.vn/Images/NoImages/404.jpg";
            try
            {
                imageBytes404 = webClient.DownloadData(s);
            }
            catch (Exception)
            {
            }
            webClient.Dispose();
            txtCount.Text = QT.Entities.Server.totalViewProductImage.ToString();

        }
        public long CompanyID
        {
            set { 
                _companyID = value;
                this.ctrLogMananger1.loadCompany(_companyID);
                DBCom.ManagerTypeRCompanyDataTable dt = new DBCom.ManagerTypeRCompanyDataTable();
                DBComTableAdapters.ManagerTypeRCompanyTableAdapter adt = new DBComTableAdapters.ManagerTypeRCompanyTableAdapter();
                adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
                adt.FillBy_IDCompany(dt, _companyID);
                if (dt.Rows.Count > 0)
                {
                    this.laMapCrawler.Text = dt.Rows[0]["Name"].ToString();
                }
                dt.Dispose();
                adt.Dispose();
            }
            get
            {
                return _companyID;
            }
        }
        private Thread tDownload;
        bool finish = true;
        private String _connection = "";

        void download()
        {

            finish = false;
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
                this.viewProductTableAdapter.Connection.ConnectionString = _connection;
            }
            DBCom.ProductDataTable dt = new DBCom.ProductDataTable();
            if (chkViewAllWeb.Checked)
            {
                this.productTableAdapter.Product_SelectByCompanyID_Valid(dt, 0, this.chkValid.Checked, Common.Obj2Int(this.txtPage.Text), Common.Obj2Int(this.txtCount.Text));
            }
            else
            {
                this.productTableAdapter.Product_SelectByCompanyID_Valid(dt, _companyID, this.chkValid.Checked, Common.Obj2Int(this.txtPage.Text), Common.Obj2Int(this.txtCount.Text));
            }
            //String f = "", fcontent = "";

            //f = " <div style='float: left;'>"
            //    + "      <img width='50px' height='50px' src='{0}'></img>"
            //    + "</div>";

            //fcontent = "<div style='float: left;'>"
            //    + "  <p style='padding:0px; margin:0px;'>{0}</p>"
            //    + "  <p style='padding:0px; margin:0px;'>Giá {1}</p>"
            //    + "</div>";
            String image = "";
            int ImageWidth = 140;
            string ImagePath = "";
            var webClient = new WebClient();
            byte[] imageBytes = null;
            int i=0;
            foreach (DBCom.ProductRow dr in dt)
            {
                if (chkImage.Checked)
                {
                    image = "";
                    ImagePath = dt.Rows[i]["ImagePath"].ToString();
                    image = Common.GetImage(ImagePath, ImageWidth);
                    if (string.IsNullOrEmpty(image))
                    {
                        i++;
                        dr.Valid = false;
                        continue;
                    } 
                    try
                    {
                        imageBytes = webClient.DownloadData(image);
                        dr.ImageBit = imageBytes;
                        dr.DisplayImage = "1";
                        dr.Valid = true;
                        if(CompanyID!=Common.GetIDCompany("quangtrung.vn"))
                        {
                            if ((dr.Price < 1000) || (dr.Price > 800000000))
                            {
                                dr.Valid = false;
                            }
                            
                        }
                        else
                        {
                            if (dr.Status != 11)
                            {
                                dr.Valid = false;
                            }
                        }
                          
                    }
                    catch (Exception)
                    {
                        dr.ImageBit = imageBytes404;
                        dr.DisplayImage = "0";
                        dr.Valid = false;
                    }
                   
                }
                else
                {
                    if(Common.Obj2Int(dt.Rows[i]["ImageWidth"].ToString())>100)
                        dr.Valid = true;
                    else
                        dr.Valid = false;
                }
                //if (dr.Status > 11)
                //{
                //    dr.Valid = false;
                //}
                //dr.DisplayImage = string.Format(f, image);
                //dr.DisplayContent = string.Format(fcontent, dr.Name, String.Format("{0:N0}", dr.Price));
                i++;
            }
            webClient.Dispose();

            this.Invoke((MethodInvoker)delegate
            {
                lamess.Text = "Đã tải xong dữ liệu";
                this.dBCom.Product.Clear();
                this.dBCom.Product.Merge(dt);
                this.dataNavigator1.Visible = true;
                this.lamess.Visible = false;
                this.gridControl1.Focus();
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

        public void LoadData()
        {
            this.dBCom.Product.Rows.Clear();
            if (finish)
            {
                tDownload = new Thread(new ThreadStart(download));
                tDownload.Start();
            }
        }

        public void DisposeTheart()
        {
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
        private void btSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btweb_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new System.Uri(this.detailUrlTextBox.Text, System.UriKind.Absolute);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void UpdateLog(string log)
        {
            DBComTableAdapters.Job_WebsiteConfigLogTableAdapter adtJob = new DBComTableAdapters.Job_WebsiteConfigLogTableAdapter();
            adtJob.Connection.ConnectionString = Server.ConnectionString;
            adtJob.Insert(QT.Users.User.UserID, _companyID, "Duyệt Ảnh", log, QT.Users.JobNhapLieuStatus.DuyetAnh, DateTime.Now);
        }
        public void Save()
        {
            this.productBindingSource.EndEdit();
            int count = 0;
            if (chkValid.Checked)
            {
                foreach (DBCom.ProductRow dr in dBCom.Product)
                {
                    if (dr.Valid==false)
                    {
                        this.productTableAdapter.UpdateValid(dr.Valid, dr.ID);
                    }
                }
            }
            else
            {
                foreach (DBCom.ProductRow dr in dBCom.Product)
                {
                    if (dr.Valid == true)
                    {
                        this.productTableAdapter.UpdateValid(dr.Valid, dr.ID);
                        count++;
                    }
                }
            }
            UpdateSauKhiCheckProduct(count);
        }
        private void UpdateSauKhiCheckProduct(int count)
        {
            try
            {
                DBCom.ProductDataTable dt = new DBCom.ProductDataTable();
                this.productTableAdapter.FillBy_TongValidCompany(dt, CompanyID);

                DBComTableAdapters.CompanyTableAdapter adt = new DBComTableAdapters.CompanyTableAdapter();
                adt.Connection.ConnectionString = Server.ConnectionString;
                adt.UpdateQuery_LastCheckValid(DateTime.Now, dt.Rows.Count, CompanyID);
                UpdateLog(string.Format("{0}", count));
            }
            catch (Exception)
            {
                
                throw;
            }
        }



        private void btUncheck_Click(object sender, EventArgs e)
        {
            foreach (DBCom.ProductRow dr in dBCom.Product)
            {
                dr.Valid = false;
            }
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            foreach (DBCom.ProductRow dr in dBCom.Product)
            {
                dr.Valid = true;
            }
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            if (Common.Obj2Int(txtPage.Text) == 1)
                return;
            this.txtPage.Text = (Common.Obj2Int(txtPage.Text) - 1).ToString();
            LoadData();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            this.txtPage.Text = (Common.Obj2Int(txtPage.Text) + 1).ToString();
            LoadData();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void txtCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData();
            }
        }

        private void summaryTextBox_TextChanged(object sender, EventArgs e)
        {
            this.webSumary.DocumentText = summaryTextBox.Text;
        }

        private void productContentTextBox_TextChanged(object sender, EventArgs e)
        {
            this.webContent.DocumentText = productContentTextBox.Text;
        }

        private void btViewContent_Click(object sender, EventArgs e)
        {
        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.viewProductTableAdapter.FillBy_ComID(dBCom.ViewProduct, Common.Obj2Int64(this.iDTextBox.Text.Trim()));
        }

        private void btTestProperties_Click(object sender, EventArgs e)
        {
            List<PropertyEntyties> l = ContentAnalytic.GetListProperties(productContentTextBox.Text, this.detailUrlTextBox.Text);
            ContentAnalytic.UpdateContent(0, l);
        }

        private void btMap_Click(object sender, EventArgs e)
        {
            DBComTableAdapters.ManagerTypeRCompanyTableAdapter adtMTRC = new DBComTableAdapters.ManagerTypeRCompanyTableAdapter();
            adtMTRC.Connection.ConnectionString = Server.ConnectionString;

            frmChonNhomQuanLy frm = new frmChonNhomQuanLy();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // delete cong ty ở tất cả các nhóm
                // insert vào nhóm mới

                adtMTRC.DeleteQuery_IDCompany(_companyID);
                adtMTRC.Insert(frm.IDManager, _companyID);
            }
            frm.Dispose();
            adtMTRC.Dispose();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
        
    }
}
