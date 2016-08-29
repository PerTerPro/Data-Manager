using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using QT.Entities;
using QT.Moduls.CrawlerProduct;
using System.Data.SqlClient;
using QT.Entities.Data;
using QT.Moduls.Company;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid;
using Websosanh.Core.Drivers.RabbitMQ;

namespace QT.Moduls
{
    public partial class ctrListWebSite : UserControl
    {
        public delegate void ChangedEventHandler(QT.Entities.Common.ListWebCommand command, EventArgs e);
        public event ChangedEventHandler ExcuteCommand;

        private Common.ListWebCommand _command = Common.ListWebCommand.ViewProfile;
        private bool IsExcuteCommand = true;

        public ctrListWebSite()
        {
            InitializeComponent();
            repositoryItemHyperLinkFixed.Click += repositoryItemHyperLinkFixed_Click;
            DisnableAll();
        }



        private void DisnableAll()
        {
            this.luCompanyStatus.Visible = false;
            this.txtSearch.Visible = false;
            this.btRunAllQueue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btAllHistory.Visible = false;
            this.btAdd.Visible = true;
            this.btDelete.Visible = false;

            //this.cralwerSanPhamCuToolStripMenuItem.Visible = true;
            //this.crawlerAllQueueToolStripMenuItem.Visible = false;
            //this.crawlerAllSanPhamCuToolStripMenuItem.Visible = false;
            //this.crawlerAllToolStripMenuItem.Visible = true;
            //this.ReloadToolStripMenuItem.Visible = false;

            //this.loadAllImageToolStripMenuItem.Visible = false;
            //this.loadAllImageValidToolStripMenuItem.Visible = false;
            //this.loadImageĐãValidToolStripMenuItem.Visible = false;
            this.loadImageToolStripMenuItem.Visible = false;

            this.addNewWebToolStripMenuItem.Visible = true;
            this.notAvailableToolStripMenuItem.Visible = false;
            this.NewsToolStripMenuItem.Visible = false;
            this.NotProductToolStripMenuItem.Visible = false;
            this.AddNewProductMerchanttoolStripMenuItem.Visible = false;
        }
        private void DisnableAllTruNhapSPMerchant()
        {
            this.luCompanyStatus.Visible = true;
            this.btRunAllQueue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btAllHistory.Visible = false;
            this.btAdd.Visible = true;
            this.btDelete.Visible = false;

            //this.cralwerSanPhamCuToolStripMenuItem.Visible = true;
            //this.crawlerAllQueueToolStripMenuItem.Visible = true;
            //this.crawlerAllSanPhamCuToolStripMenuItem.Visible = true;
            //this.crawlerAllToolStripMenuItem.Visible = true;
            //this.ReloadToolStripMenuItem.Visible = true;
            this.viewWebToolStripMenuItem.Visible = false;
            //this.loadAllImageToolStripMenuItem.Visible = false;
            //this.loadAllImageValidToolStripMenuItem.Visible = false;
            //this.loadImageĐãValidToolStripMenuItem.Visible = false;
            this.loadImageToolStripMenuItem.Visible = false;
            this.viewProfileToolStripMenuItem.Visible = false;
            //this.toolStripMenuItem1.Visible = false;
            this.viewThongKeLuotClick.Visible = false;
            this.viewProductToolStripMenuItem.Visible = false;
            this.addNewWebToolStripMenuItem.Visible = false;
            this.notAvailableToolStripMenuItem.Visible = false;
            this.NewsToolStripMenuItem.Visible = false;
            this.NotProductToolStripMenuItem.Visible = false;
            this.viewQuangCaoToolStripMenuItem.Visible = false;
            this.menuItemExportExcel.Visible = false;
            //this.AddNewProductMerchanttoolStripMenuItem.Visible = false;
        }
        private void EnableAll()
        {
            this.luCompanyStatus.Visible = true;
            this.txtSearch.Visible = true;
            this.btRunAllQueue.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.btAllHistory.Visible = true;
            this.btAdd.Visible = true;
            this.btDelete.Visible = true;

            //this.cralwerSanPhamCuToolStripMenuItem.Visible = true;
            //this.crawlerAllQueueToolStripMenuItem.Visible = true;
            //this.crawlerAllSanPhamCuToolStripMenuItem.Visible = true;
            //this.crawlerAllToolStripMenuItem.Visible = true;
            //this.crawlerQueueToolStripMenuItem.Visible = true;
            //this.crawlerToolStripMenuItem.Visible = true;

            //this.loadAllImageToolStripMenuItem.Visible = true;
            //this.loadAllImageValidToolStripMenuItem.Visible = true;
            //this.loadImageĐãValidToolStripMenuItem.Visible = true;
            this.loadImageToolStripMenuItem.Visible = true;

            this.addNewWebToolStripMenuItem.Visible = true;
            this.notAvailableToolStripMenuItem.Visible = true;
            this.NewsToolStripMenuItem.Visible = true;
            this.NotProductToolStripMenuItem.Visible = true;
            this.AddNewProductMerchanttoolStripMenuItem.Visible = true;
        }
        public void InitControl()
        {
            this.btnNotShowProduct.Visible = QT.Entities.Server.ShowButtonNotVisibleProduct;

            this.companyTableAdapter1.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.company_StatusTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.managerTypeTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.viewManagerCrawlerTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;

            try
            {
                this.company_StatusTableAdapter.FillBySTT(dB.Company_Status);
                this.managerTypeTableAdapter.Fill(dBCom.ManagerType);
                EnableAll();
                if ((QT.Users.User.PermisionID.Contains(QT.Users.Permission.NhapSPMarketing)))
                {
                    DisnableAllTruNhapSPMerchant();
                }
                //else
                //{
                //    this.managerTypeTableAdapter.FillBy_UserID(dBCom.ManagerType, QT.Users.User.UserID);
                //    this.loadByType = true;
                //    this.lookUpEdit1.ItemIndex = 0;
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorr: " + ex.ToString());
            }

            //this.cboComStatus.EditValue = "Đã config";
            try
            {
                List<String> txt = FileLog.ReadAllLineText("pageIndex.log");
                this.txtPageCurrent.EditValue = (QT.Entities.Common.Obj2Int(txt[0])).ToString();
                this.cboCount.EditValue = txt[1];
            }
            catch (Exception)
            {
            }
        }

        public string GetUrlWebCurrent()
        {
            return this.websiteLabel1.Text;
        }
        public int GetIDManagerType()
        {
            int r = 1;
            try
            {
                r = QT.Entities.Common.Obj2Int(lookUpEdit1.EditValue.ToString());
            }
            catch (Exception)
            {
            }
            return r;
        }
        public String GetCommentCrawler()
        {
            int first = (_pageIndex - 1) * _pageCount + 1;
            int last = _pageIndex * _pageCount;
            return string.Format("{0:D4}-{1:D4}-p{2:D2}", first, last, _pageIndex);
        }
        public string GetDomain()
        {
            return this.domainLabel1.Text;
        }
        public long GetIDCompanyCurrent
        {
            set { this.iDLabel1.Text = value.ToString(); }
            get
            {
                return Common.Obj2Int64(this.iDLabel1.Text);
            }
        }

        public List<DataRowView> GetListSelectedRow()
        {
            var lst = new List<DataRowView>();
            foreach (int i in this.gridView1.GetSelectedRows())
            {
                DataRowView row = this.gridView1.GetRow(i) as DataRowView;
                lst.Add(row);
            }
            return lst;
        }
        public List<DataRowView> GetListSelectedRowInReport()
        {
            var lst = new List<DataRowView>();
            foreach (int i in this.gridView5.GetSelectedRows())
            {
                DataRowView row = this.gridView5.GetRow(i) as DataRowView;
                lst.Add(row);
            }
            return lst;
        }

        public List<long> GetListIDCompany()
        {
            List<long> r = new List<long>();
            this.companyBindingSource.MoveFirst();
            for (int i = 0; i < this.companyBindingSource.Count; i++)
            {
                if (checkCheckBox.Checked)
                {
                    r.Add(Common.Obj2Int64(this.iDLabel1.Text));
                }
                this.companyBindingSource.MoveNext();
            }
            FileLog.WriteText(_pageIndex.ToString() + "\r\n" + _pageCount.ToString(), "pageIndex.log");
            return r;
        }
        public List<String> GetListDomainCompany()
        {
            List<String> r = new List<String>();
            this.companyBindingSource.MoveFirst();
            for (int i = 0; i < this.companyBindingSource.Count; i++)
            {
                if (checkCheckBox.Checked)
                {
                    r.Add(this.domainLabel1.Text);
                }
                this.companyBindingSource.MoveNext();
            }
            return r;
        }
        private void ctrListWebSite_Resize(object sender, EventArgs e)
        {
        }

        private void ctrListWebSite_Load(object sender, EventArgs e)
        {
            this.luCompanyStatus.ItemIndex = 0;
        }

        private int _pageIndex = 1, _pageCount = 20;
        private byte _status = 1;
        private void LoadData()
        {
            Wait.CreateWaitDialog();
            try
            {
                if (loadByType)
                {
                    this.dB.Company.Rows.Clear();
                    Wait.Show("Đang tải dữ liệu");
                    this.companyTableAdapter1.FillBy_IDType(this.dBCom.Company, QT.Entities.Common.Obj2Int(lookUpEdit1.EditValue.ToString()));
                    foreach (Company.DBCom.CompanyRow dr in this.dBCom.Company)
                    {
                        dr.Check = true;
                    }
                    companyBindingSource.EndEdit();
                    Wait.Close();
                }
                else if (loadByStatus)
                {
                    _pageCount = Common.Obj2Int(this.cboCount.EditValue);
                    if (_pageCount <= 0) _pageCount = 20;
                    this.dB.Company.Rows.Clear();
                    Wait.Show("Đang tải dữ liệu");
                    this.companyTableAdapter1.FillBy_StatusPage(this.dBCom.Company, _status, _pageIndex, _pageCount);

                    foreach (Company.DBCom.CompanyRow dr in this.dBCom.Company)
                    {
                        dr.Check = true;
                    }
                    companyBindingSource.EndEdit();
                    //crawlerThread = new Thread(new ThreadStart(doCrawler));
                    //crawlerThread.Start();
                    Wait.Close();
                }
                else
                {
                    _pageCount = Common.Obj2Int(this.cboCount.EditValue);
                    if (_pageCount <= 0) _pageCount = 20;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorr: " + ex.ToString());
            }
            Wait.Close();
        }

        private void cboCount_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();

        }

        private void txtPageCurrent_EditValueChanged(object sender, EventArgs e)
        {
            _pageIndex = Common.Obj2Int(this.txtPageCurrent.EditValue);
            txtPageCurrent.EditValue = _pageIndex;
            LoadData();
        }

        private void btFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _pageIndex = 1;
            txtPageCurrent.EditValue = _pageIndex;
            LoadData();
        }

        private void btPrevious_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_pageIndex <= 1) _pageIndex = 1;
            else
            {
                _pageIndex--;
            }
            txtPageCurrent.EditValue = _pageIndex;
            LoadData();
        }

        private void btNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _pageIndex++;
            txtPageCurrent.EditValue = _pageIndex;
            LoadData();
        }

        private void btEnd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            long CompanyCount = long.Parse((companyTableAdapter1.CMS_Company_CountByStatus(_status)).ToString());
            int PageCount = (int)CompanyCount / int.Parse(cboCount.EditValue.ToString()) + 1;
            _pageIndex = PageCount;
            txtPageCurrent.EditValue = _pageIndex;
            LoadData();
        }

        private void checkedAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Company.DBCom.CompanyRow dr in this.dBCom.Company)
            {
                dr.Check = true;
            }
            companyBindingSource.EndEdit();
        }

        private void unCheckedAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Company.DBCom.CompanyRow dr in this.dBCom.Company)
            {
                dr.Check = false;
            }
            companyBindingSource.EndEdit();
        }

        private void UncheckMenu()
        {
            btnMapCategoryAndClassification.Checked = false;
            btnCrawlerInRedis.Checked = false;
            //ReloadToolStripMenuItem.Checked = false;
            //crawlerAllToolStripMenuItem.Checked = false;
            //cralwerSanPhamCuToolStripMenuItem.Checked = false;
            //crawlerAllSanPhamCuToolStripMenuItem.Checked = false;
            setStatusNormalToolStripMenuItem.Checked = false;
            viewProfileToolStripMenuItem.Checked = false;
            viewWebToolStripMenuItem.Checked = false;
            viewProductToolStripMenuItem.Checked = false;
            loadImageToolStripMenuItem.Checked = false;
            //loadAllImageToolStripMenuItem.Checked = false;
            //loadImageĐãValidToolStripMenuItem.Checked = false;
            //loadAllImageValidToolStripMenuItem.Checked = false;
            //crawlerAllQueueToolStripMenuItem.Checked = false;
            NewsToolStripMenuItem.Checked = false;
            notAvailableToolStripMenuItem.Checked = false;
            NotProductToolStripMenuItem.Checked = false;
            AddNewProductMerchanttoolStripMenuItem.Checked = false;
            btnCrawlerInRedis.Checked = false;
        }

        private void FindNewManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.FindNewManual;
            ExcuteCommand(_command, e);
        }
        private void ReLoadtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.ReloadManual;
            ExcuteCommand(_command, e);
        }

        //private void crawlerAllQueueToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    IsExcuteCommand = true;
        //    ToolStripMenuItem tm = (ToolStripMenuItem)sender;
        //    UncheckMenu();
        //    tm.Checked = true;
        //    _command = Common.ListWebCommand.CrawlerAllQueue;
        //    ExcuteCommand(_command, e);
        //    FileLog.WriteText(_pageIndex.ToString() + "\r\n" + _pageCount.ToString(), "pageIndex.log");
        //}
        private void ReLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.ReloadManual;
            ExcuteCommand(_command, e);
        }

        //private void crawlerAllToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    IsExcuteCommand = true;
        //    ToolStripMenuItem tm = (ToolStripMenuItem)sender;
        //    UncheckMenu();
        //    tm.Checked = true;
        //    _command = Common.ListWebCommand.CrawlerAll;
        //    ExcuteCommand(_command, e);
        //    FileLog.WriteText(_pageIndex.ToString() + "\r\n" + _pageCount.ToString(), "pageIndex.log");
        //}
        //private void crawlerAllSanPhamCuToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    IsExcuteCommand = true;
        //    ToolStripMenuItem tm = (ToolStripMenuItem)sender;
        //    UncheckMenu();
        //    tm.Checked = true;
        //    _command = Common.ListWebCommand.CrawlerAllSanPhamCu;
        //    ExcuteCommand(_command, e);
        //    FileLog.WriteText(_pageIndex.ToString() + "\r\n" + _pageCount.ToString(), "pageIndex.log");
        //}
        //private void cralwerSanPhamCuToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    IsExcuteCommand = true;
        //    ToolStripMenuItem tm = (ToolStripMenuItem)sender;
        //    UncheckMenu();
        //    tm.Checked = true;
        //    _command = Common.ListWebCommand.CrawlerSanPhamCu;
        //    ExcuteCommand(_command, e);
        //}

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.ViewProfile;
            ExcuteCommand(_command, e);
        }
        private void viewWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.ViewWeb;
            ExcuteCommand(_command, e);
        }
        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.ViewProduct;
            ExcuteCommand(_command, e);
        }
        private void exportProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.ExportProduct;
            ExcuteCommand(_command, e);
        }
        private void btnViewProduct1_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.ViewProduct1;
            ExcuteCommand(_command, e);
        }
        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (IsExcuteCommand)
            {
                ExcuteCommand(_command, e);
            }
            else
            {
                if (NewsToolStripMenuItem.Checked)
                {
                    this.companyTableAdapter1.UpdateQuery_Status(Common.CompanyStatus.TIN, GetIDCompanyCurrent);
                }
                if (notAvailableToolStripMenuItem.Checked)
                {
                    this.companyTableAdapter1.UpdateQuery_Status(Common.CompanyStatus.NOAVAILABLE, GetIDCompanyCurrent);
                }
                if (NotProductToolStripMenuItem.Checked)
                {
                    this.companyTableAdapter1.UpdateQuery_Status(Common.CompanyStatus.NOTPRODUCT, GetIDCompanyCurrent);
                }
                this.companyBindingSource.RemoveCurrent();
            }
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (IsExcuteCommand)
                {
                    ExcuteCommand(_command, e);
                }
                else
                {
                    if (NewsToolStripMenuItem.Checked)
                    {
                        this.companyTableAdapter1.UpdateQuery_Status(Common.CompanyStatus.TIN, GetIDCompanyCurrent);
                    }
                    if (notAvailableToolStripMenuItem.Checked)
                    {
                        this.companyTableAdapter1.UpdateQuery_Status(Common.CompanyStatus.NOAVAILABLE, GetIDCompanyCurrent);
                    }
                    if (NotProductToolStripMenuItem.Checked)
                    {
                        this.companyTableAdapter1.UpdateQuery_Status(Common.CompanyStatus.NOTPRODUCT, GetIDCompanyCurrent);
                    }
                    this.companyBindingSource.RemoveCurrent();

                }
            }
            if (e.KeyCode == Keys.F1)
            {
                this.txtSearch.Focus();
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            this.txtSearch.Text = "";
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            this.txtSearch.Text = "Nhập tên domain/mô tả để tìm (ấn F1)";
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Domain = QT.Entities.Common.GetDomainFromUrl(txtSearch.Text.Trim());
                if (string.IsNullOrEmpty(Domain)) Domain = txtSearch.Text.Trim();
                this.companyTableAdapter1.FillBy_Search(dBCom.Company, _status, "%" + Domain + "%", QT.Entities.Common.Obj2Int64(txtSearch.Text.Trim()));
                this.gridControl1.Focus();
            }
        }

        private void addNew(EventArgs e)
        {
            QT.Moduls.Company.DBComTableAdapters.Job_WebsiteConfigLogTableAdapter adtJob = new QT.Moduls.Company.DBComTableAdapters.Job_WebsiteConfigLogTableAdapter();
            adtJob.Connection.ConnectionString = Server.ConnectionString;
            Company.frmAddWeb frm = new Company.frmAddWeb();
            frm.Text = "Thêm mới website";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                TimeSpan timestartup = new TimeSpan(0, 1, 1, 0);
                TimeSpan timeSleep = new TimeSpan(0, 1, 1, 0);
                Uri uri = new Uri(frm.Website);
                String domain = uri.Host.ToLower();
                domain = domain.Replace("www.", "");
                Alexa a = new Alexa();
                a = Common.GetRankAlexa(uri.Host);
                try
                {
                    this.companyTableAdapter1.Insert(
                          Common.GetIDCompany(domain),
                          "",
                          "",
                          frm.Website,
                          domain,
                          DateTime.Now,
                          "",
                          "",
                          "",
                          "",
                          Common.CompanyStatus.NOTCONFIG,
                          "",
                          a.AlexaRankContries,
                          a.AlexaRank,
                          timestartup,
                          timeSleep,
                          0,
                          0,
                          DateTime.Now,
                          DateTime.Now,
                          30,
                          0,
                          0,
                          0,
                          "",
                          DateTime.Now,
                          0, 0, "", false, 0, DateTime.Now.AddYears(-1), DateTime.Now.AddYears(-1));
                    adtJob.Insert(QT.Users.User.UserID,Common.GetIDCompany(domain),"","",QT.Users.JobNhapLieuStatus.NhapMoi,DateTime.Now);
                    LogJobAdapter.SaveLog(JobName.FrmCompany_AddNew, "Thêm mới công ty "+domain, Convert.ToInt64(Common.GetIDCompany(domain)), (int)JobTypeData.Company);
                }
                catch (Exception)
                {
                    MessageBox.Show("Website này đã có trong hệ thống");
                }
                _command = Common.ListWebCommand.ViewProfile;
                GetIDCompanyCurrent = Common.GetIDCompany(domain);
                ExcuteCommand(_command, e);
            }
        }
        private void addNewWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            addNew(e);
        }

        public DevExpress.XtraGrid.Views.Grid.GridView GetGridView()
        {
            return this.gridView1;
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            addNew(e);
        }


        private void btReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void loadAllImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            //UncheckMenu();
            //tm.Checked = true;
            //_command = Common.ListWebCommand.DownloadAllImage;
            //ExcuteCommand(_command, e);
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.LoadImage;
            ExcuteCommand(_command, e);
        }
        private void loadImageĐãValidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            //UncheckMenu();
            //tm.Checked = true;
            //_command = Common.ListWebCommand.DownloadImage;
            //ExcuteCommand(_command, e);
        }
        private void loadAllImageValidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            //UncheckMenu();
            //tm.Checked = true;
            //_command = Common.ListWebCommand.DownloadAll_Image;
            //ExcuteCommand(_command, e);
        }



        private void ctrListWebSite_ControlRemoved(object sender, ControlEventArgs e)
        {
            FileLog.WriteText(_pageIndex.ToString() + "\r\n" + _pageCount.ToString(), "pageIndex.log");
        }

        private void btRunAllQueue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UncheckMenu();
            //crawlerAllQueueToolStripMenuItem.Checked = true;
            _command = Common.ListWebCommand.CrawlerAllQueue;
            ExcuteCommand(_command, e);
            FileLog.WriteText(_pageIndex.ToString() + "\r\n" + _pageCount.ToString(), "pageIndex.log");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (Common.Obj2Byte(this.statusLabel1.Text) != Common.CompanyStatus.CONFIG)
            {
                if (MessageBox.Show("Are you sure Delete website" + this.websiteLabel1.Text, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.companyTableAdapter1.DeleteQuery(Common.Obj2Int64(this.iDLabel1.Text));
                }
            }
        }

        private void notAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = false;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            this.GetDomain();
            this.companyTableAdapter1.UpdateQuery_Status(Common.CompanyStatus.NOAVAILABLE, GetIDCompanyCurrent);
            this.companyBindingSource.RemoveCurrent();
        }

        private void NewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = false;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            this.companyTableAdapter1.UpdateQuery_Status(Common.CompanyStatus.TIN, GetIDCompanyCurrent);
            this.companyBindingSource.RemoveCurrent();
        }

        private void NotProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = false;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            this.companyTableAdapter1.UpdateQuery_Status(Common.CompanyStatus.NOTPRODUCT, GetIDCompanyCurrent);
            this.companyBindingSource.RemoveCurrent();
        }

        private void setStatusNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
        }

        private bool loadByType = false;
        private bool loadByStatus = false;
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            loadByType = true;
            LoadData();
        }

        private void btRunQueue_Click(object sender, EventArgs e)
        {
            UncheckMenu();
            //crawlerAllQueueToolStripMenuItem.Checked = true;
            _command = Common.ListWebCommand.CrawlerAllQueue;
            ExcuteCommand(_command, e);
            FileLog.WriteText(_pageIndex.ToString() + "\r\n" + _pageCount.ToString(), "pageIndex.log");
        }

        private void btAllHistory_Click(object sender, EventArgs e)
        {
            UncheckMenu();
            //crawlerAllSanPhamCuToolStripMenuItem.Checked = true;
            _command = Common.ListWebCommand.CrawlerAllSanPhamCu;
            ExcuteCommand(_command, e);
            FileLog.WriteText(_pageIndex.ToString() + "\r\n" + _pageCount.ToString(), "pageIndex.log");
        }

        private void luCompanyStatus_EditValueChanged(object sender, EventArgs e)
        {
            loadByType = false;
            loadByStatus = true;
            _status = (byte)luCompanyStatus.EditValue;
            LoadData();
            long.Parse((companyTableAdapter1.CMS_Company_CountByStatus(_status)).ToString());
        }

        private void btLoadManagerCrawler_Click(object sender, EventArgs e)
        {
            this.viewManagerCrawlerTableAdapter.FillByTop1000(dBCom.ViewManagerCrawler);
            this.xtraTabControl1.SelectedTabPage = this.tabCrawler;
            this.gridView2.ExpandAllGroups();
        }

        private void btLoadDistinct_Click(object sender, EventArgs e)
        {
            this.viewManagerCrawlerTableAdapter.FillByDistinct(dBCom.ViewManagerCrawler, DateTime.Now.AddMinutes(-3));
            this.xtraTabControl1.SelectedTabPage = this.tabCrawler;
            this.gridView2.ExpandAllGroups();
        }

        private void viewQuangCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.ViewQuangCao;
            ExcuteCommand(_command, e);
        }

        private void viewThongKeLuotClick_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.ViewThongKeClick;
            ExcuteCommand(_command, e);
        }

        private void menuItemExportExcel_Click(object sender, EventArgs e)
        {
            string fileName = "Companies";
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            //string currentDirectorypath = Environment.CurrentDirectory;
            string finalFileNameWithPath = string.Empty;

            fileName = string.Format("{0}_{1}", fileName, DateTime.Now.ToString("dd-MM-yyyy"));
            finalFileNameWithPath = string.Format("{0}\\{1}.xlsx", folderBrowserDialog.SelectedPath, fileName);

            //Delete existing file with same file name.
            if (File.Exists(finalFileNameWithPath))
                File.Delete(finalFileNameWithPath);
            var excelSheetName = "Thống kê lượt click";
            var newFile = new FileInfo(finalFileNameWithPath);

            //Step 1 : Create object of ExcelPackage class and pass file path to constructor.
            using (var package = new ExcelPackage(newFile))
            {
                //Step 2 : Add a new worksheet to ExcelPackage object and give a suitable name
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(excelSheetName);
                //Get datatable
                var dtv = this.dBCom.Company.DefaultView;
                dtv.Sort = "TotalViewMonth desc";
                var sortedDatatable = dtv.ToTable("Companies", true, "Name", "Website", "TotalViewMonth",
                    "TotalProduct", "AlexaRank");
                //Step 3 : Start loading datatable form A1 cell of worksheet.
                worksheet.Cells["A1"].LoadFromDataTable(sortedDatatable, true, TableStyles.None);

                //Step 4 : (Optional) Set the file properties like title, author and subject
                package.Workbook.Properties.Title = @"Company Click statics";
                package.Workbook.Properties.Author = "Websosanh";
                package.Workbook.Properties.Subject = @"Manager";

                //Step 5 : Save all changes to ExcelPackage object which will create Excel 2007 file.
                package.Save();
            }
        }

        private void barLoadT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Wait.CreateWaitDialog();
            try
            {
                this.dB.Company.Rows.Clear();
                Wait.Show("Đang tải dữ liệu");
                this.companyTableAdapter1.FillBy_KyTu(this.dBCom.Company);
                foreach (Company.DBCom.CompanyRow dr in this.dBCom.Company)
                {
                    dr.Check = true;
                }
                companyBindingSource.EndEdit();
                Wait.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorr: " + ex.ToString());
            }
            Wait.Close();
        }

        private void AddNewProductMerchanttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.AddNewProductMerchant;
            ExcuteCommand(_command, e);
        }

        private void btnCrawlerNewProduct_Click(object sender, EventArgs e)
        {
            //QueuePushHandle queuePushHandle = new QueuePushHandle();
            //long companyID = this.GetIDCompanyCurrent;
            //long configID = SqlDb.Instance.GetConfigIDByCompanyID(companyID);
            //if (configID == -1)
            //{
            //    MessageBox.Show("Chua co config");
            //}
            //try
            //{
            //    queuePushHandle.PushTaskCrawlNewProduct(companyID, configID);
            //    MessageBox.Show("Da day vao queue");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnReloadProduct_Click(object sender, EventArgs e)
        {
            //QueuePushHandle queuePushHandle = new QueuePushHandle();
            //long companyID = this.GetIDCompanyCurrent;
            //long configID = SqlDb.Instance.GetConfigIDByCompanyID(companyID);
            //if (configID == -1)
            //{
            //    MessageBox.Show("Chua co config");
            //}
            //try
            //{
            //    queuePushHandle.PushTaskCrawlReloadProduct(companyID, configID);
            //    MessageBox.Show("Da day vao queue");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnCrawlerByQueue_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.CrawlerByNewSystem;
            ExcuteCommand(_command, e);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnCrawlerInRedis_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.CrawlProductInRedis;
            ExcuteCommand(_command, e);
        }

        private void btnMapCategoryAndClassification_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.MapCatAndClass;
            ExcuteCommand(_command, e);
        }

        private void btnPushQueueFindData_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.PushToJobCrawler;
            ExcuteCommand(_command, e);
        }

        private void btnNotShowProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Toàn bộ số công ty trong group sẽ bị ẩn. Đồng ý", "Queuesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.OK)
                {
                    ProductAdapter productAdapter = new ProductAdapter(new Entities.Data.SqlDb(QT.Entities.Server.ConnectionString));
                    int TypeCompany = Convert.ToInt32(lookUpEdit1.EditValue);
                    if (TypeCompany > 0)
                    {
                        DataTable tblCompanyNeedNotShow = productAdapter.GetListCompanyByStatus(TypeCompany);
                        if (tblCompanyNeedNotShow != null && tblCompanyNeedNotShow.Rows.Count > 0)
                        {
                            foreach (DataRow row in tblCompanyNeedNotShow.Rows)
                            {
                                bool bOK = productAdapter.UpdateNotShowProductForCompany(Convert.ToInt64(row["id"]), false);
                                if (bOK == false &&
                                      MessageBox.Show("Xem log lỗi. Chạy tiếp compnay tiếp?", "Question", MessageBoxButtons.YesNo
                                    , MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    break;
                                }
                            }
                            MessageBox.Show("Success!");
                        }
                    }
                }
            }
            catch (Exception ex01)
            {
                MessageBox.Show(ex01.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMapCatAndClassAuto_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.MapCatAndClassForCompany;
            ExcuteCommand(_command, e);
        }

        private void btnLoadErrorConfig_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPage2;
            loadByType = false;
            loadByStatus = false;
            //LoadData();
            Wait.Show("Đang tải dữ liệu");
            DataTable temp = new DataTable();
            Company.DBCom.Company1DataTable Com1Table = new Company.DBCom.Company1DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection conn = new SqlConnection(Server.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CMS_Company_SelectErrorConfig";
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            da.Fill(temp);

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                int result = 0;
                int.TryParse(temp.Rows[i]["TheoDoi"].ToString(), out result);
                if ((!string.IsNullOrEmpty(temp.Rows[i]["TheoDoi"].ToString())) && (result != 0))
                {
                    int TheoDoi = int.Parse(temp.Rows[i]["TheoDoi"].ToString());
                    company1TableAdapter.FillBy_ErrorConfig(Com1Table, _pageIndex, _pageCount, TheoDoi);
                    dBCom.Company1.Merge(Com1Table);
                }
            }

            //Wait.Show("Đang tải dữ liệu");
            //this.company1TableAdapter.FillBy_ErrorConfig(this.dBCom.Company1, _pageIndex, _pageCount);
            //company1BindingSource.EndEdit();
            Wait.Close();
        }
        private DataTable tblReport = null;
        private SqlDb sqldb = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=5000");
        private long CompanyID = 0;

        private void btnNeedRepair_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = ListError;
            tblReport = sqldb.GetTblData("prc_Report_Company_Config_Error", CommandType.StoredProcedure, new SqlParameter[] { });
            grvListNeedRepair.DataSource = tblReport;
        }
        public long getNeedRepairID()
        {
            CompanyID = QT.Entities.Common.Obj2Int64((this.gridView4.GetRow(this.gridView4.FocusedRowHandle) as DataRowView)["ID"]);
            return CompanyID;
        }
        private void repositoryItemHyperLinkFixed_Click(object sender, EventArgs e)
        {
            CompanyID = getNeedRepairID();
            sqldb.RunQuery("update Company_Check_Config set LastRepairConfig = GETDATE() where CompanyID = @CompanyID", CommandType.Text, new SqlParameter[]{
                sqldb.CreateParamteter("@CompanyID",CompanyID,SqlDbType.BigInt)
            });
            btnNeedRepair_Click(null, null);
        }
        public event EventHandler RepaiConfig;
        private void grvListNeedRepair_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RepaiConfig(sender, e);
        }
        
        private void gridView4_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnHistoryCrawlerData_Click(object sender, EventArgs e)
        {
            FrmHistoryCrawlerForCompany frm = new FrmHistoryCrawlerForCompany(GetIDCompanyCurrent);
            frm.ShowDialog();
        }

        private void btnNoReload_Click(object sender, EventArgs e)
        {

        }

        private void pushIsNewToQueueImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPushIsNewProductToChangeImage frm = new FrmPushIsNewProductToChangeImage();
            frm.LoadDomain(new QT.Entities.Company(this.GetIDCompanyCurrent).Domain);
            frm.Show();
        }

        private void crawlerReloadNoValidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsExcuteCommand = true;
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            UncheckMenu();
            tm.Checked = true;
            _command = Common.ListWebCommand.ReloadNoValidManual;
            ExcuteCommand(_command, e);
        }

        private void btnRpMinLastRL_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageRpMinLastRL;
        }
        private DataTable tblReprot = null;
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            int typeReload = 0;
            if (CkVipCom.Checked) typeReload = 1;
            else typeReload = 2;

            tblReprot = sqldb.GetTblData("prc_Report_MinLastUpdateProductCrawler", CommandType.StoredProcedure, new System.Data.SqlClient.SqlParameter[] { 
                SqlDb.CreateParamteterSQL("@TypeReport",typeReload,SqlDbType.Int)});

            gridControlRpMinLastRL.DataSource = tblReprot;
        }

        private void pushCompanyDownloadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public int ChoseTabPage()
        {
            return xtraTabControl1.SelectedTabPageIndex;
        }

        private void gridView5_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnDanhGiaCongTy_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemoveFailRegexProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnViewCount_Click(object sender, EventArgs e)
        {
            var rowSelect = GetListSelectedRow();
            lblCountSelected.Text = rowSelect.Count.ToString();
        }

        private void btnAddQueueReload_Click(object sender, EventArgs e)
        {

        }

        private void copyDomainToClipboadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            List<long> lstCompanyID = new List<long>();

            foreach (GridView gridView in this.gridControl1.Views)
            {
                if (gridView.SelectedRowsCount > 0)
                {
                    foreach (int iRow in gridView.GetSelectedRows())
                    {
                        lstCompanyID.Add(Convert.ToInt64(gridView.GetRowCellValue(iRow, "ID")));
                    }
                }
                Clipboard.SetText(string.Join("\n", lstCompanyID));
            }
        }

        private void updateCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

                IsExcuteCommand = true;
                ToolStripMenuItem tm = (ToolStripMenuItem)sender;
                UncheckMenu();
                tm.Checked = true;
                _command = Common.ListWebCommand.UpdateCategory;
                ExcuteCommand(_command, e);

            
        }

        private void btnPushCompanyInfoReset_Click(object sender, EventArgs e)
        {
            long companyInfo = this.GetIDCompanyCurrent;
            ProducerBasic producerBasic = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct), ConfigRun.QueueUpdateCompanyInfoToWeb);
            producerBasic.PublishString(companyInfo.ToString());
            MessageBox.Show("Pushed company!");
        }




        //public void GetListCompanySelected ()
        //{
        //    int numerRowView = this.gridView1.RowCount;
        //    for (int i=0; i<numerRowView;i++)
        //    {
        //        if (this.ivie)
        //    }
        //}
    }
}
