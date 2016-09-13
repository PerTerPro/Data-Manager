using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QT.Moduls;
using QT.Moduls.Tool;
using QT.Moduls.Company;
using QT.Entities;
using QT.Moduls.Crawler;
using QT.Moduls.Maps;
using System.Threading;
using QT.Moduls.ProductID;
using QT.Users;
using QT.Moduls.Web;
using QT.Moduls.News;
using System.Diagnostics;
using QT.Moduls.View;
using QT.NewsRelation;
using WSS.CrawlerSale.Manager;
using QT.Moduls.WebPartner;
using QT.Entities.Model.SaleNews;
using QT.Entities.Data;
using QT.Moduls.Bizweb;
using QT.Entities.CrawlerProduct;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlProd;
using QT.Moduls.Tag;
//using AnalysicInfoFacbook;
using QT.Moduls.CrawlerReviewFacebook;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Websosanh.Core.Drivers.RabbitMQ;
using System.Collections;
using System.Threading.Tasks;
using QT.Moduls.LogJob;
using QT.Moduls.Excel;
using System.Data.SqlClient;
using QT.Entities;
using QT.Moduls.RatingCompany;
using QT.Moduls.Notifycation;
using QT.Moduls.Keyword;
using WSS.Service.Crawler.Consumer.FindNew;
//using UpdateSolrTools;

namespace _000
{
    public partial class XMain : DevExpress.XtraEditors.XtraForm
    {
        public XMain()
        {
            InitializeComponent();
            DisabelAll();
        }

        public void DisabelAll()
        {
            //this.barSubItemTools.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barSubItemMap.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barSubItemWeb.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barSubItemTools.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barSubItemNews.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barSubItemProduct.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barSubItemJob.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barSubItemSale.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barSubItemThietLapProduct.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            this.barButtonAnanyticProduct.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            //job
            this.barButtonJobType.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonJobMananager.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonJob_PhanSanPhamNhapLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonJob_BaoCaoNhapLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonJob_BaoCaoConfigWeb.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonJob_ManagerCrawler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;



            this.barCommand.Visible = false;
            this.barRun20.Visible = false;
            ListCompanyDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }
        public void EnableAll()
        {
            this.barSubItemTools.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.barSubItemMap.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.barSubItemTools.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.barSubItemWeb.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.barSubItemNews.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.barSubItemProduct.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.barSubItemJob.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.barSubItemSale.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.barSubItemThietLapProduct.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            this.barButtonAnanyticProduct.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            /// job
            this.barButtonJobType.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.barButtonJobMananager.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.barButtonJob_PhanSanPhamNhapLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.barButtonJob_BaoCaoNhapLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.barButtonJob_BaoCaoConfigWeb.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            this.barButtonJob_ManagerCrawler.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;


            this.barCommand.Visible = true;
            this.barRun20.Visible = true;
            ListCompanyDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;


        }
        public void EnableNhapDuLieuMedia()
        {
            this.barSubItemProduct.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }
        public void EnableAnanyticProduct()
        {
            this.barButtonAnanyticProduct.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }
        private void XMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Load");
            QT.Users.User.UserID = 1;
            QT.Users.User.UserName = "admin";

            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            frm.Dispose();

            if (QT.Users.User.UserName == "admin")
            {
                EnableAll();
            }
            else
            {
                this.btnCleanDuplicateProduct.Enabled = false;
                QT.Users.User_Permission objPermission = new User_Permission();
                ///2
                if (objPermission.CheckPermission(QT.Users.User.UserID,
                    QT.Users.Permission.ThietLapQuyenHeThong))
                {
                    this.barSubItemTools.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                ///4
                if (objPermission.CheckPermission(QT.Users.User.UserID,
                    QT.Users.Permission.PhanCongNhapDuLieu))
                {
                    this.barSubItemJob.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    this.barButtonJobType.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    this.barButtonJobMananager.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    this.barButtonJob_PhanSanPhamNhapLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    this.barButtonJob_BaoCaoNhapLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                ///6
                if (objPermission.CheckPermission(QT.Users.User.UserID,
                    QT.Users.Permission.XemBaoCaoConfigWeb))
                {
                    this.barSubItemJob.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    this.barButtonJob_BaoCaoConfigWeb.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                ///7
                if (objPermission.CheckPermission(QT.Users.User.UserID,
                    QT.Users.Permission.ConfigWeb))
                {
                    this.barSubItemJob.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    ListCompanyDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                    this.barButtonJob_ManagerCrawler.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                // 8
                if (objPermission.CheckPermission(QT.Users.User.UserID, QT.Users.Permission.PhanTichSanPhamGoc))
                {
                    this.barButtonAnanyticProduct.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                // 9
                if (objPermission.CheckPermission(QT.Users.User.UserID, QT.Users.Permission.NhapSanPhamGoc))
                {
                    this.barSubItemProduct.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                // 10
                if (objPermission.CheckPermission(QT.Users.User.UserID, QT.Users.Permission.ThietLapSanPham))
                {
                    this.barSubItemThietLapProduct.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                // 11 hiện danh sách website chỉ có 1 chức năng là nhập sản phẩm merchant
                if (objPermission.CheckPermission(QT.Users.User.UserID, QT.Users.Permission.NhapSPMarketing))
                {
                    ListCompanyDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                }
            }
            ////MessageBox.Show("Check Permission");
            //if(objPermission.CheckPermission(QT.Users.User.UserID,QT.Users.Permission.PermissionNhaSoLieuDacBiet))
            //{
            //    EnableNhapDuLieuMedia();
            //}
            //if (objPermission.CheckPermission(QT.Users.User.UserID, QT.Users.Permission.PermissionAnanyticProduct))
            //{
            //    EnableAnanyticProduct();
            //}


            this.ctrListWebSite1.InitControl();

            bool allowAutoRunCrawler = QT.Entities.Server.AllowAutoCrawler;
            int maxThread = QT.Entities.Server.MaxThreadCrawler;
            string queueName = QT.Entities.Server.QueueNameCrawler;

            if (allowAutoRunCrawler && QT.Moduls.Crawler.FrmQuestionAuto.GetQuestionRun(queueName + @"/" + maxThread))
            {
                btnStartConsumerCrawler.PerformClick();
            }
        }

        private void ShowFormToolMain()
        {
            var frm = new frmToolMain();
            frm.MdiParent = this;
            frm.Text = "Tool Optimise";
            frm.Show();
        }
        private void ShowFormGetContentNews()
        {
            var frm = new frmManagerNews();
            frm.MdiParent = this;
            frm.Text = "Get content";
            frm.Show();
        }
        private void ShowFormUserManager()
        {
            var frm = new frmUserManager();
            frm.MdiParent = this;
            frm.Text = "Quản lý user";
            frm.Show();
        }

        private void ShowFormUpdateAlexaRank()
        {
            var frm = new frmUpdateAlexa();
            frm.MdiParent = this;
            frm.Text = "Update Alexa Rank";
            frm.Show();
        }
        private void ShowFormCheckXPath()
        {
            var frm = new frmCheckXPath();
            frm.MdiParent = this;
            frm.Text = "Check XPath";
            frm.Show();
        }
        private void ShowFormPhanTichTuKhoa()
        {
            var frm = new frmPhanTichTuKhoa();
            frm.MdiParent = this;
            frm.Text = "Phân tích từ khóa sản phẩm";
            frm.Show();
        }

        private void tool_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool valForm = false;
                //foreach (var child in MdiChildren)
                //{
                //    if (child is frmToolMain)
                //    {
                //        var f = (frmToolMain)child;

                //        child.BringToFront();
                //        valForm = true;
                //        break;
                //    }
                //}
                if (!valForm)
                {
                    try
                    {
                        ShowFormToolMain();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void tool_UpdateSolrSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool valForm = false;

                if (!valForm)
                {
                    try
                    {
                        var frm = new frmToolUpdateSolr();
                        frm.MdiParent = this;
                        frm.Text = "Tool Update Solr";
                        frm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void barButtonItemUpdateSolrV2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tool_PhanTichTuKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool valForm = false;
                foreach (var child in MdiChildren)
                {
                    if (child is frmPhanTichTuKhoa)
                    {
                        var f = (frmPhanTichTuKhoa)child;

                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
                if (!valForm)
                {
                    try
                    {
                        ShowFormPhanTichTuKhoa();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void tool_UpdateAlexaRank_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool valForm = false;
                foreach (var child in MdiChildren)
                {
                    if (child is frmUpdateAlexa)
                    {
                        var f = (frmUpdateAlexa)child;

                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
                if (!valForm)
                {
                    try
                    {
                        ShowFormUpdateAlexaRank();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void tool_TestXPath_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool valForm = false;
                foreach (var child in MdiChildren)
                {
                    if (child is frmCheckXPath)
                    {
                        var f = (frmCheckXPath)child;

                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
                if (!valForm)
                {
                    try
                    {
                        ShowFormCheckXPath();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void tool_TestPerpormanceWeb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //bool valForm = false;
                //foreach (var child in MdiChildren)
                //{
                //    if (child is frmWebPerformance)
                //    {
                //        var f = (frmWebPerformance)child;

                //        child.BringToFront();
                //        valForm = true;
                //        break;
                //    }
                //}
                //if (!valForm)
                //{
                try
                {
                    frmWebPerformance frm = new frmWebPerformance();
                    frm.MdiParent = this;
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //}
            }
            catch (Exception)
            {
            }
        }
        private void tool_ChuanHoaThanhPho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool valForm = false;
                foreach (var child in MdiChildren)
                {
                    if (child is frmChuanHoaThanhPho)
                    {
                        var f = (frmChuanHoaThanhPho)child;

                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
                if (!valForm)
                {
                    try
                    {
                        var frm = new frmChuanHoaThanhPho();
                        frm.MdiParent = this;
                        frm.Text = "Chuẩn hóa thành phố";
                        frm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void tool_XoaProductLogAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool valForm = false;
                //foreach (var child in MdiChildren)
                //{
                //    if (child is frmXoaSPLogTrung)
                //    {
                //        var f = (frmXoaSPLogTrung)child;

                //        child.BringToFront();
                //        valForm = true;
                //        break;
                //    }
                //}
                if (!valForm)
                {
                    try
                    {
                        var frm = new frmXoaSPLogTrung();
                        frm.MdiParent = this;
                        frm.Text = "Xóa Dữ liệu trùng bảng Product_LogAddProduct";
                        frm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void tool_ThongKeLenhSQL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool valForm = false;
                foreach (var child in MdiChildren)
                {
                    if (child is frmAnanyticTradeSQL)
                    {
                        var f = (frmAnanyticTradeSQL)child;

                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
                if (!valForm)
                {
                    try
                    {
                        var frm = new frmAnanyticTradeSQL();
                        frm.MdiParent = this;
                        frm.Text = "Phân tích SQL";
                        frm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void tool_NapCache_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var frm = new frmLoadCacheWeb();
                frm.MdiParent = this;
                frm.Text = "Nạp Cache";
                frm.Show();
            }
            catch (Exception)
            {
            }
        }




        private void barButtonItemUpdateRegions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool isFormOpened = false;
                foreach (var child in MdiChildren)
                {
                    if (child is FrmEditCompanyRegion)
                    {
                        child.BringToFront();
                        isFormOpened = true;
                        break;
                    }
                }
                if (!isFormOpened)
                {
                    try
                    {
                        var frm = new FrmEditCompanyRegion();
                        frm.MdiParent = this;
                        frm.Text = "Cập nhập địa chỉ công ty bị thiếu";
                        frm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }


        private void FindNewManual(QT.Entities.Common.ListWebCommand typeWebCommand)
        {
            CrawlerProduct3_FindNew_Manual_ItemClick(null, null);

            //Dictionary<long, string> dicCompanySelected = new Dictionary<long, string>();
            //var listCompanyID = this.ctrListWebSite1.GetListSelectedRow();
            //foreach (var itemRow in listCompanyID)
            //{
            //    dicCompanySelected.Add(Convert.ToInt64(itemRow["ID"]), Convert.ToString(itemRow["Domain"]));
            //}

            //foreach (var item in dicCompanySelected)
            //{
            //    long companyID = item.Key;
            //    string domain = item.Value;

            //    bool valForm = false;
            //    foreach (var child in MdiChildren)
            //    {
            //        if (child is QT.Moduls.Crawler.frmCrawlerProduct)
            //        {
            //            var f = (frmCrawlerProduct)child;
            //            if (f.Text == domain)
            //            {
            //                child.BringToFront();
            //                valForm = true;
            //                break;
            //            }
            //        }
            //    }

            //    if (!valForm)
            //    {
            //        try
            //        {
            //            frmCrawlerProduct frm = new frmCrawlerProduct(companyID);
            //            frm.MdiParent = this;
            //            frm.QuetSPCu = true;
            //            frm.WebCommand = typeWebCommand;
            //            frm.Text = domain;
            //            frm.Start();
            //            frm.Show();
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.ToString());
            //        }
            //    }
            //}
        }


        private void ReloadManual(QT.Entities.Common.ListWebCommand typeWebCommand)
        {
            if (typeWebCommand == QT.Entities.Common.ListWebCommand.ReloadManual) Crawlerreload(1);
            else if (typeWebCommand == QT.Entities.Common.ListWebCommand.ReloadNoValidManual) Crawlerreload(2);
        }

        //private void ShowFormCrawlerQueue()
        //{
        //    bool valForm = false;
        //    foreach (var child in MdiChildren)
        //    {
        //        if (child is QT.Moduls.Crawler.frmCrawlerProduct)
        //        {
        //            var f = (frmCrawlerProduct)child;
        //            if (f.Text == this.ctrListWebSite1.GetDomain())
        //            {
        //                child.BringToFront();
        //                valForm = true;
        //                break;
        //            }
        //        }
        //    }
        //    if (!valForm)
        //    {
        //        try
        //        {
        //            frmCrawlerProduct frm = new frmCrawlerProduct(this.ctrListWebSite1.GetIDCompanyCurrent);
        //            frm.MdiParent = this;
        //            frm.WebCommand = Common.ListWebCommand.FindNewManual;
        //            frm.Text = this.ctrListWebSite1.GetDomain();
        //            frm.Start();
        //            frm.Show();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.ToString());
        //        }
        //    }
        //}
        private void ShowFormDownloadLoadAllImage()
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmWeb)
                {
                    var f = (frmWeb)child;
                    if (f.Text == "LoadImage " + this.ctrListWebSite1.GetUrlWebCurrent())
                    {
                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
            }
            if (!valForm)
            {
                try
                {
                    frmWeb frm = new frmWeb();
                    frm.MdiParent = this;
                    frm.Text = "LoadImage " + this.ctrListWebSite1.GetUrlWebCurrent();
                    frm.URL = "http://websosanh.vn/admin/domain/" + this.ctrListWebSite1.GetDomain().ToString() + ".htm";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ShowFormDownloadImage()
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmDowloadImage)
                {
                    var f = (frmDowloadImage)child;
                    if (f.Text == "LoadImage " + this.ctrListWebSite1.GetDomain())
                    {
                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
            }
            if (!valForm)
            {
                try
                {
                    frmDowloadImage frm = new frmDowloadImage(this.ctrListWebSite1.GetIDCompanyCurrent,
                        this.ctrListWebSite1.GetDomain());
                    frm.MdiParent = this;
                    frm.Text = "LoadImage " + this.ctrListWebSite1.GetDomain();
                    frm.Dowload();
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void ShowFormThongKeClick()
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmThongKeClick)
                {
                    var f = (frmThongKeClick)child;
                    if (f.Text == "ViewClick " + this.ctrListWebSite1.GetDomain())
                    {
                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
            }
            if (!valForm)
            {
                try
                {
                    frmThongKeClick frm = new frmThongKeClick(this.ctrListWebSite1.GetIDCompanyCurrent,
                        this.ctrListWebSite1.GetDomain());
                    frm.MdiParent = this;
                    frm.Text = "ViewClick " + this.ctrListWebSite1.GetDomain();
                    frm.InitData();
                    //frm.RefreshData();
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ctrListWebSite1_ExcuteCommand(QT.Entities.Common.ListWebCommand command, EventArgs e)
        {

            bool valForm = false;
            switch (command)
            {
                case QT.Entities.Common.ListWebCommand.MapCatAndClassForCompany:
                    {
                        List<DataRowView> lst = this.ctrListWebSite1.GetListSelectedRow();
                        if (lst != null && lst.Count > 0)
                        {
                            foreach (DataRowView rowView in lst)
                            {
                                long CompanyID = Convert.ToInt64(rowView["ID"]);
                                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                                productAdapter.MapCatAndClassAutoForCompany(CompanyID);
                            }
                            MessageBox.Show("Success!");
                        }
                        else
                        {
                            MessageBox.Show("Chưa chọn công ty!");
                        }

                    } break;
                case QT.Entities.Common.ListWebCommand.DanhGiaCongTy:
                    {
                        FrmRattingCompany frmRattingCompany = new FrmRattingCompany(this.ctrListWebSite1.GetIDCompanyCurrent);
                        frmRattingCompany.MdiParent = this;
                        frmRattingCompany.Show();
                    } break;

                case QT.Entities.Common.ListWebCommand.MapCatAndClass:
                    {
                        FrmMapCategoryAndClassification frm = new FrmMapCategoryAndClassification();
                        int currentFocusRow = this.ctrListWebSite1.GetGridView().FocusedRowHandle;
                        long obj = Convert.ToInt64(this.ctrListWebSite1.GetGridView().GetRowCellValue(currentFocusRow, "ID"));
                        frm.LoadCompany(obj);
                        frm.MdiParent = this;
                        frm.Show();

                    } break;
                case QT.Entities.Common.ListWebCommand.PushToJobCrawler:
                    {
                        DataTable tbl = new DataTable();
                        tbl.Columns.Add("ID", typeof(long));
                        tbl.Columns.Add("Domain", typeof(string));
                        foreach (DataRowView rowView in ctrListWebSite1.GetListSelectedRow())
                        {
                            tbl.Rows.Add(Convert.ToInt64(rowView["ID"]), Convert.ToString(rowView["Domain"]));
                        }
                        FrmPushJobCrawler frm = new FrmPushJobCrawler();
                        frm.MdiParent = this;
                        frm.LoadOutData(tbl);
                        frm.Show();
                    } break;

                case QT.Entities.Common.ListWebCommand.FindNewManual:
                    FindNewManual(Common.ListWebCommand.FindNewManual);
                    break;
                    //case QT.Entities.Common.ListWebCommand.CrawlerAllQueue:
                    //    #region Crawler cong ty
                    //    this.ctrListWebSite1.companyBindingSource.MoveFirst();
                    //    while (ctrListWebSite1.companyBindingSource.Position < ctrListWebSite1.companyBindingSource.Count - 1)
                    //    {
                    //        if (ctrListWebSite1.checkCheckBox.Checked == true)
                    //        {
                    //            ShowFormCrawlerQueue();
                    //        }
                    //        ctrListWebSite1.companyBindingSource.MoveNext();
                    //    }
                    //    if (ctrListWebSite1.checkCheckBox.Checked == true)
                    //    {
                    //        ShowFormCrawlerQueue();
                    //    }
                    break;
                //#endregion
                case QT.Entities.Common.ListWebCommand.ViewWeb:
                    #region viewWeb
                    foreach (var child in MdiChildren)
                    {
                        if (child is frmWeb)
                        {
                            var f = (frmWeb)child;
                            if (f.Text == "View " + this.ctrListWebSite1.GetUrlWebCurrent())
                            {
                                child.BringToFront();
                                valForm = true;
                                break;
                            }
                        }
                    }
                    if (!valForm)
                    {
                        try
                        {
                            frmWeb frm = new frmWeb();
                            frm.MdiParent = this;
                            frm.Text = "View " + this.ctrListWebSite1.GetUrlWebCurrent();
                            frm.URL = this.ctrListWebSite1.GetUrlWebCurrent();
                            frm.Show();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("xx");
                        }
                    }
                    break;
                    #endregion
                case QT.Entities.Common.ListWebCommand.LoadImage:
                    #region LoadImage
                    ProcessStartInfo sInfo = new ProcessStartInfo("http://beta.websosanh.net/admin/domain/" + this.ctrListWebSite1.GetDomain().ToString() + ".htm");
                    Process.Start(sInfo);
                    //foreach (var child in MdiChildren)
                    //{
                    //    if (child is frmWeb)
                    //    {
                    //        var f = (frmWeb)child;
                    //        if (f.Text == "LoadImage " + this.ctrListWebSite1.GetUrlWebCurrent())
                    //        {
                    //            child.BringToFront();
                    //            valForm = true;
                    //            break;
                    //        }
                    //    }
                    //}
                    //if (!valForm)
                    //{
                    //    try
                    //    {
                    //        frmWeb frm = new frmWeb();
                    //        frm.MdiParent = this;
                    //        frm.Text = "LoadImage " + this.ctrListWebSite1.GetUrlWebCurrent();
                    //        frm.URL = "http://websosanh.vn/admin/domain/" + this.ctrListWebSite1.GetDomain().ToString() + ".htm";
                    //        frm.Show();
                    //    }
                    //    catch (Exception)
                    //    {
                    //        MessageBox.Show("xx");
                    //    }
                    //}
                    break;
                    #endregion

                case QT.Entities.Common.ListWebCommand.DownloadAll_Image:
                    #region LoadAllImageValid
                    this.ctrListWebSite1.companyBindingSource.MoveFirst();
                    while (ctrListWebSite1.companyBindingSource.Position < ctrListWebSite1.companyBindingSource.Count - 1)
                    {
                        if (ctrListWebSite1.checkCheckBox.Checked == true)
                        {
                            ShowFormDownloadImage();
                        }
                        ctrListWebSite1.companyBindingSource.MoveNext();
                    }
                    if (ctrListWebSite1.checkCheckBox.Checked == true)
                    {
                        ShowFormDownloadImage();
                    }
                    break;
                    #endregion
                case QT.Entities.Common.ListWebCommand.DownloadImage:
                    ShowFormDownloadImage();
                    break;
                case QT.Entities.Common.ListWebCommand.DownloadAllImage:
                    #region DownloadAllImage
                    this.ctrListWebSite1.companyBindingSource.MoveFirst();
                    while (ctrListWebSite1.companyBindingSource.Position < ctrListWebSite1.companyBindingSource.Count - 1)
                    {
                        if (ctrListWebSite1.checkCheckBox.Checked == true)
                        {
                            ShowFormDownloadLoadAllImage();
                        }
                        ctrListWebSite1.companyBindingSource.MoveNext();
                    }
                    if (ctrListWebSite1.checkCheckBox.Checked == true)
                    {
                        ShowFormDownloadLoadAllImage();
                    }
                    break;
                    #endregion
                case QT.Entities.Common.ListWebCommand.ViewProduct:
                    #region ViewProduct
                    foreach (var child in MdiChildren)
                    {
                        if (child is frmProduct)
                        {
                            var f = (frmProduct)child;
                            if (f.Text == "listProduct " + this.ctrListWebSite1.GetUrlWebCurrent())
                            {
                                child.BringToFront();
                                valForm = true;
                                f.RefreshData();
                                break;
                            }
                        }
                    }
                    if (!valForm)
                    {
                        try
                        {
                            frmProduct frm = new frmProduct(this.ctrListWebSite1.GetIDCompanyCurrent);
                            frm.MdiParent = this;
                            frm.Text = "listProduct " + this.ctrListWebSite1.GetUrlWebCurrent();
                            frm.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    break;
                    #endregion
                case QT.Entities.Common.ListWebCommand.ExportProduct:
                    #region ExportProduct
                    foreach (var child in MdiChildren)
                    {
                        if (child is FrmExportProduct)
                        {
                            var f = (FrmExportProduct)child;
                            if (f.Text == "listProduct " + this.ctrListWebSite1.GetUrlWebCurrent())
                            {
                                child.BringToFront();
                                valForm = true;
                                f.RefreshData();
                                break;
                            }
                        }
                    }
                    if (!valForm)
                    {
                        try
                        {
                            FrmExportProduct frm = new FrmExportProduct(this.ctrListWebSite1.GetIDCompanyCurrent);
                            frm.MdiParent = this;
                            frm.Text = "listProduct " + this.ctrListWebSite1.GetUrlWebCurrent();
                            frm.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    break;
                    #endregion
                case QT.Entities.Common.ListWebCommand.ViewQuangCao:
                    #region ViewProduct
                    foreach (var child in MdiChildren)
                    {
                        if (child is frmProduct)
                        {
                            var f = (frmProduct)child;
                            if (f.Text == "viewQuangCao " + this.ctrListWebSite1.GetUrlWebCurrent())
                            {
                                child.BringToFront();
                                valForm = true;
                                f.RefreshData();
                                break;
                            }
                        }
                    }
                    if (!valForm)
                    {
                        try
                        {
                            frmQuangCao frm = new frmQuangCao(this.ctrListWebSite1.GetIDCompanyCurrent);
                            frm.MdiParent = this;
                            frm.Text = "viewQuangCao " + this.ctrListWebSite1.GetUrlWebCurrent();
                            frm.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    break;
                    #endregion
                case QT.Entities.Common.ListWebCommand.ViewProfile:
                    #region viewCongTy
                    foreach (var child in MdiChildren)
                    {
                        if (child is frmCongTy)
                        {
                            var f = (frmCongTy)child;
                            if (f.Text == "CongTy " + this.ctrListWebSite1.GetUrlWebCurrent())
                            {
                                child.BringToFront();
                                valForm = true;
                                break;
                            }
                        }
                    }
                    if (!valForm)
                    {
                        try
                        {
                            frmCongTy frm = new frmCongTy(false);
                            frm.MdiParent = this;
                            frm.Text = "CongTy " + this.ctrListWebSite1.GetUrlWebCurrent();
                            frm.SelectCompany(this.ctrListWebSite1.GetIDCompanyCurrent);
                            frm.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    break;
                    #endregion
                case QT.Entities.Common.ListWebCommand.ReloadManual:
                    ReloadManual(Common.ListWebCommand.ReloadManual);
                    break;
                case QT.Entities.Common.ListWebCommand.ReloadNoValidManual:
                    ReloadManual(Common.ListWebCommand.ReloadNoValidManual);
                    break;
                case QT.Entities.Common.ListWebCommand.CrawlerAll:
                    #region Crawler cong ty
                    this.ctrListWebSite1.companyBindingSource.MoveFirst();
                    while (ctrListWebSite1.companyBindingSource.Position < ctrListWebSite1.companyBindingSource.Count - 1)
                    {
                        if (ctrListWebSite1.checkCheckBox.Checked == true)
                        {
                            ReloadManual(Common.ListWebCommand.ReloadManual);
                        }
                        ctrListWebSite1.companyBindingSource.MoveNext();
                    }
                    if (ctrListWebSite1.checkCheckBox.Checked == true)
                    {
                        ReloadManual(Common.ListWebCommand.ReloadManual);
                    }
                    break;
                    #endregion
                case QT.Entities.Common.ListWebCommand.CrawlerAllSanPhamCu:
                    break;
                case QT.Entities.Common.ListWebCommand.CrawlerSanPhamCu:
                    FindNewManual(Common.ListWebCommand.CrawlerSanPhamCu);
                    break;
                case QT.Entities.Common.ListWebCommand.ViewThongKeClick:
                    ShowFormThongKeClick();
                    break;
                case QT.Entities.Common.ListWebCommand.AddNewProductMerchant:
                    ShowFormAddNewProductMerchant();
                    break;
                case QT.Entities.Common.ListWebCommand.ViewProduct1:
                    #region ViewProduct1
                    foreach (var child in MdiChildren)
                    {
                        if (child is FrmPublicProduct)
                        {
                            var f = (FrmPublicProduct)child;
                            if (f.Text == "listProduct " + this.ctrListWebSite1.GetUrlWebCurrent())
                            {
                                child.BringToFront();
                                valForm = true;
                                f.LoadData();
                                break;
                            }
                        }
                    }
                    if (!valForm)
                    {
                        try
                        {
                            FrmPublicProduct frm = new FrmPublicProduct(this.ctrListWebSite1.GetIDCompanyCurrent);
                            frm.MdiParent = this;
                            frm.Text = "listProduct " + this.ctrListWebSite1.GetUrlWebCurrent();
                            frm.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    break;
                    #endregion
                case QT.Entities.Common.ListWebCommand.UpdateCategory:
                    #region UpdateCategory
                    foreach (var child in MdiChildren)
                    {
                        if (child is FrmUpdateCategory)
                        {
                            var f = (FrmUpdateCategory)child;
                            if (f.Text == "CongTy " + this.ctrListWebSite1.GetUrlWebCurrent())
                            {
                                child.BringToFront();
                                valForm = true;
                                break;
                            }
                        }
                    }
                    if (!valForm)
                    {
                        try
                        {
                            FrmUpdateCategory frm = new FrmUpdateCategory(this.ctrListWebSite1.GetIDCompanyCurrent);
                            frm.MdiParent = this;
                            frm.Text = "CongTy " + this.ctrListWebSite1.GetUrlWebCurrent();
                            frm.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    #endregion
                    break;
            }
        }

        private void ShowFormAddNewProductMerchant()
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmAddMerchantProduct)
                {
                    var f = (frmAddMerchantProduct)child;
                    if (f.Text == "frmAddMerchantProduct")
                    {
                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
            }
            if (!valForm)
            {
                try
                {
                    frmAddMerchantProduct frm = new frmAddMerchantProduct(this.ctrListWebSite1.GetIDCompanyCurrent);
                    frm.MdiParent = this;
                    frm.Text = "frmAddMerchantProduct";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void barRegexpal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmWeb)
                {
                    var f = (frmWeb)child;
                    if (f.Text == "Config Regex")
                    {
                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
            }
            if (!valForm)
            {
                try
                {
                    frmWeb frm = new frmWeb();
                    frm.MdiParent = this;
                    frm.Text = "Config Regex";
                    frm.URL = @"http://regexpal.com/";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void win_Tab_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
        }

        private void win_Cascade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = null;
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void win_Vertical_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            xtraTabbedMdiManager1.MdiParent = null;
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void win_Horirontal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = null;
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void file_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm != null)
            {
                frm.Close();
                frm.Dispose();
            }
        }

        private void file_CloseAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng toàn bộ form đang chạy ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var child in MdiChildren)
                {
                    child.Close();
                    child.Dispose();
                }
            }

        }
        private void barButtonItemMinimize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm != null)
            {
                frm.WindowState = FormWindowState.Minimized;
            }
        }
        private void barButtonItemMinimizeAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var child in MdiChildren)
            {
                child.WindowState = FormWindowState.Minimized;
            }
        }
        private void btnNormal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm != null)
            {
                frm.WindowState = FormWindowState.Normal;
            }
        }
        private void btnNormalAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var child in MdiChildren)
            {
                child.WindowState = FormWindowState.Normal;
            }
        }


        #region Command

        private void barComandStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmReportCrawler frm = new FrmReportCrawler();
            frm.MdiParent = this;
            frm.Show();

            //string cman = "start ";
            //try
            //{
            //    var f = (frmBase)this.ActiveMdiChild;
            //    if (f != null)
            //    {
            //        Wait.CreateWaitDialog();
            //        Wait.Show("Đang " + cman + f.Text);
            //        if (!f.Start())
            //        {
            //            Wait.Show("Đã có sự cố khi " + cman + " Bạn hãy thử lại hoặc kiểm tra mạng");
            //        }
            //        else
            //        {
            //            Wait.Show("Complete");
            //        }
            //        Wait.Close();
            //    }
            //    else
            //    {
            //    }
            //    XMain_MdiChildActivate(null, null);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }

        private void barComandStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cman = "stop ";
            try
            {
                var f = (frmBase)this.ActiveMdiChild;
                if (f != null)
                {
                    Wait.CreateWaitDialog();
                    Wait.Show("Đang " + cman + f.Text);
                    if (!f.Stop())
                    {
                        Wait.Show("Đã có sự cố khi " + cman + " Bạn hãy thử lại hoặc kiểm tra mạng");
                    }
                    else
                    {
                        Wait.Show("Complete");
                    }
                    Wait.Close();
                }
                else
                {
                }
                XMain_MdiChildActivate(null, null);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void barComandPause_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cman = "pause ";
            try
            {
                var f = (frmBase)this.ActiveMdiChild;
                if (f != null)
                {
                    Wait.CreateWaitDialog();
                    Wait.Show("Đang " + cman + f.Text);
                    if (!f.Pause())
                    {
                        Wait.Show("Đã có sự cố khi " + cman + " Bạn hãy thử lại hoặc kiểm tra mạng");
                    }
                    else
                    {
                        Wait.Show("Complete");
                    }
                    Wait.Close();
                }
                else
                {
                }
                XMain_MdiChildActivate(null, null);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //private void barComandRestart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    string cman = "restart ";
        //    try
        //    {
        //        if (barComandRunAll.Checked)
        //        {
        //            foreach (var child in MdiChildren)
        //            {
        //                var f = (frmBase)child;
        //                if (child is frmCrawlerProduct)
        //                {
        //                    f.Restart();
        //                }
        //                Thread.Sleep(3000);
        //            }
        //        }
        //        else
        //        {
        //            var f = (frmBase)this.ActiveMdiChild;
        //            if (f != null)
        //            {
        //                f.Restart();
        //            }
        //            else
        //            {
        //            }
        //            XMain_MdiChildActivate(null, null);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        private void barComandSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var f = (frmBase)this.ActiveMdiChild;
                if (f != null)
                {
                    Wait.CreateWaitDialog();
                    Wait.Show("Đang lưu dữ liệu " + f.Text);
                    if (!f.Save())
                    {
                        Wait.Show("Đã có sự cố khi lưu dữ liệu. Bạn hãy thử lại hoặc kiểm tra mạng");
                    }
                    else
                    {
                        Wait.Show("Complete");
                    }
                    Wait.Close();
                }
                else
                {
                }
                XMain_MdiChildActivate(null, null);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //private void barComandViewLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        if (barComandRunAll.Checked)
        //        {
        //            foreach (var child in MdiChildren)
        //            {
        //                var f = (frmBase)child;
        //                if (child is frmCrawlerProduct)
        //                {
        //                    f.Log();
        //                }
        //            }
        //        }
        //        else
        //        {
        //            var f = (frmBase)this.ActiveMdiChild;
        //            if (f != null)
        //            {
        //                f.Log();
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        #endregion

        private void ActiveCommadButton()
        {

        }
        private void barComandReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var f = (frmBase)this.ActiveMdiChild;
                if (f != null)
                {
                    Wait.CreateWaitDialog();
                    Wait.Show("Đang tải dữ liệu " + f.Text);
                    if (!f.RefreshData())
                    {
                        Wait.Show("Đã có sự cố khi lưu dữ liệu. Bạn hãy thử lại hoặc kiểm tra mạng");
                    }
                    else
                    {
                        Wait.Show("Complete");
                    }
                    Wait.Close();
                }
                else
                {
                }
                XMain_MdiChildActivate(null, null);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void barButtonAnalytics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var f = (frmBase)this.ActiveMdiChild;
                if (f != null)
                {
                    Wait.CreateWaitDialog();
                    Wait.Show("Analytics .... " + f.Text);
                    if (!f.Analytics())
                    {
                        Wait.Show("Đã có sự cố khi phân tích. Bạn hãy thử lại hoặc kiểm tra mạng");
                    }
                    else
                    {
                        Wait.Show("Complete");
                    }
                    Wait.Close();
                }
                else
                {
                }
                XMain_MdiChildActivate(null, null);
            }
            catch (Exception)
            {
              
            }
        }
        private void barButtonItemTestXpath_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var f = (frmBase)this.ActiveMdiChild;
                if (f != null)
                {
                    Wait.CreateWaitDialog();
                    Wait.Show("Analytics .... " + f.Text);
                    if (!f.TestXpath())
                    {
                        Wait.Show("Đã có sự cố khi phân tích. Bạn hãy thử lại hoặc kiểm tra mạng");
                    }
                    else
                    {
                        Wait.Show("Complete");
                    }
                    Wait.Close();
                }
                else
                {
                }
                XMain_MdiChildActivate(null, null);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void barButtonItemMapCrawler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //try
            //{
            //    var f = (frmBase)this.ActiveMdiChild;
            //    if (f != null)
            //    {
            //        Wait.CreateWaitDialog();
            //        Wait.Show("Analytics .... " + f.Text);
            //        if (!f.TestXpath())
            //        {
            //            Wait.Show("Đã có sự cố khi phân tích. Bạn hãy thử lại hoặc kiểm tra mạng");
            //        }
            //        else
            //        {
            //            Wait.Show("Complete");
            //        }
            //        Wait.Close();
            //    }
            //    else
            //    {
            //    }
            //    XMain_MdiChildActivate(null, null);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }

        private void XMain_MdiChildActivate(object sender, EventArgs e)
        {
            try
            {
                var f = (frmBase)this.ActiveMdiChild;
                if (f != null)
                {
                    this.barComandPause.Visibility = f.VisiblePause;
                    this.barComandRestart.Visibility = f.VisibleRestart;
                    this.barComandSave.Visibility = f.VisibleSave;
                    this.barComandStart.Visibility = f.VisibleStart;
                    this.barComandStop.Visibility = f.VisibleStop;

                    this.barComandPause.Enabled = f.EnabledPause;
                    this.barComandRestart.Enabled = f.EnabledRestart;
                    this.barComandSave.Enabled = f.EnabledSave;
                    this.barComandStart.Enabled = f.EnabledStart;
                    this.barComandStop.Enabled = f.EnabledStop;
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }
        private void map_GroupProperties_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmEditeGroupProperties)
                {
                    var f = (frmEditeGroupProperties)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmEditeGroupProperties frm = new frmEditeGroupProperties();
                    frm.MdiParent = this;
                    frm.Text = "EditeGroupProperties";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void map_ChuyenMuc_ThuocTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmMapClassificationProperties)
                {
                    var f = (frmMapClassificationProperties)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmMapClassificationProperties frm = new frmMapClassificationProperties();
                    frm.MdiParent = this;
                    frm.Text = "MapClassificationProperties";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void barButtonDinhNghiaThongSoKyThuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmDinhNghiaThongSoKyThuat)
                {
                    var f = (frmDinhNghiaThongSoKyThuat)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmDinhNghiaThongSoKyThuat frm = new frmDinhNghiaThongSoKyThuat();
                    frm.MdiParent = this;
                    frm.Text = "frmDinhNghiaThongSoKyThuat";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void barButtonGhepChuyenMucVoiDinhNghia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmGhepChuyenMucVoiDinhNghia)
                {
                    var f = (frmGhepChuyenMucVoiDinhNghia)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmGhepChuyenMucVoiDinhNghia frm = new frmGhepChuyenMucVoiDinhNghia();
                    frm.MdiParent = this;
                    frm.Text = "frmGhepChuyenMucVoiDinhNghia";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonChuanHoaGiatriThuocTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmChuanHoaThongSoKyThuat)
                {
                    var f = (frmChuanHoaThongSoKyThuat)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmChuanHoaThongSoKyThuat frm = new frmChuanHoaThongSoKyThuat();
                    frm.MdiParent = this;
                    frm.Text = "frmChuanHoaThongSoKyThuat";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void map_Properties_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmEditeProperties)
                {
                    var f = (frmEditeProperties)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmEditeProperties frm = new frmEditeProperties();
                    frm.MdiParent = this;
                    frm.Text = "EditeProperties";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void map_PropertiesValue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmEditePropertiesValue)
                {
                    var f = (frmEditePropertiesValue)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmEditePropertiesValue frm = new frmEditePropertiesValue();
                    frm.MdiParent = this;
                    frm.Text = "frmEditePropertiesValue";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void map_BuildTree_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //bool valForm = false;
            //foreach (var child in MdiChildren)
            //{
            //    if (child is QT.Moduls.Maps.frmTreeCategory)
            //    {
            //        var f = (frmTreeCategory)child;
            //        if (f.Text == "Maps Classification")
            //        {
            //            child.BringToFront();
            //            valForm = true;
            //            break;
            //        }
            //    }
            //}
            //if (!valForm)
            //{
            //    try
            //    {
            //        frmTreeCategory frm = new frmTreeCategory();
            //        frm.MdiParent = this;
            //        frm.Text = "Maps Classification";
            //        frm.Show();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}
        }

        private void map_CompanyToTree_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            //foreach (var child in MdiChildren)
            //{
            //    if (child is QT.Moduls.Maps.frmClassificationToTree)
            //    {
            //        var f = (frmClassificationToTree)child;
            //        if (f.Text == "ComToTree")
            //        {
            //            child.BringToFront();
            //            valForm = true;
            //            break;
            //        }
            //    }
            //}
            if (!valForm)
            {
                try
                {
                    frmClassificationToTree frm = new frmClassificationToTree();
                    frm.MdiParent = this;
                    frm.Text = "ComToTree";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void map_VatGiaToTree_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //bool valForm = false;
            //foreach (var child in MdiChildren)
            //{
            //    if (child is QT.Moduls.Maps.frmVatGiaToTree)
            //    {
            //        var f = (frmTreeCategory)child;
            //        if (f.Text == "VGToTree")
            //        {
            //            child.BringToFront();
            //            valForm = true;
            //            break;
            //        }
            //    }
            //}
            //if (!valForm)
            //{
            //    try
            //    {
            //        frmVatGiaToTree frm = new frmVatGiaToTree();
            //        frm.MdiParent = this;
            //        frm.Text = "VGToTree";
            //        frm.Show();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}
        }

        private void map_ListSPVatGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //bool valForm = false;
            //foreach (var child in MdiChildren)
            //{
            //    if (child is QT.Moduls.Maps.frmProductVatGia)
            //    {
            //        var f = (frmProductVatGia)child;
            //        if (f.Text == "productVG")
            //        {
            //            child.BringToFront();
            //            valForm = true;
            //            break;
            //        }
            //    }
            //}
            //if (!valForm)
            //{
            //    try
            //    {
            //        frmProductVatGia frm = new frmProductVatGia();
            //        frm.MdiParent = this;
            //        frm.Text = "productVG";
            //        frm.Show();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}
        }

        private void XMain_Shown(object sender, EventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = null;
            this.LayoutMdi(MdiLayout.Cascade);
            this.Text += "  " + QT.Entities.Server.ServerName;
        }

        private void map_SPGTuVatGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //bool valForm = false;
            //foreach (var child in MdiChildren)
            //{
            //    if (child is QT.Moduls.Maps.frmConvertSPVG_to_SPGoc)
            //    {
            //        var f = (frmConvertSPVG_to_SPGoc)child;
            //        if (f.Text == "convertVG")
            //        {
            //            child.BringToFront();
            //            valForm = true;
            //            break;
            //        }
            //    }
            //}
            //if (!valForm)
            //{
            //    try
            //    {
            //        frmConvertSPVG_to_SPGoc frm = new frmConvertSPVG_to_SPGoc();
            //        frm.MdiParent = this;
            //        frm.Text = "convertVG";
            //        frm.Show();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}
        }

        private void map_ThongSoKyThuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is QT.Moduls.ProductID.frmThongSoKyThuat)
                {
                    var f = (frmThongSoKyThuat)child;
                    if (f.Text == "Properties")
                    {
                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
            }
            if (!valForm)
            {
                try
                {
                    frmThongSoKyThuat frm = new frmThongSoKyThuat();
                    frm.MdiParent = this;
                    frm.Text = "Properties";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void map_Product_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmEditeProductByCat)
                {
                    var f = (frmEditeProductByCat)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmEditeProductByCat frm = new frmEditeProductByCat();
                    frm.MdiParent = this;
                    frm.Text = "frmEditeProductByCat";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void map_ChuyenMucVaoWebMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //bool valForm = false;
            //foreach (var child in MdiChildren)
            //{
            //    if (child is QT.Moduls.Maps.frmMapClassificationToCompany)
            //    {
            //        var f = (frmMapClassificationToCompany)child;
            //        child.BringToFront();
            //        valForm = true;
            //        break;
            //    }
            //}
            //if (!valForm)
            //{
            //    try
            //    {
            //        frmMapClassificationToCompany frm = new frmMapClassificationToCompany();
            //        frm.MdiParent = this;
            //        frm.Text = "ghép chuyên mục";
            //        frm.Show();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}
        }

        private void fileUserManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool valForm = false;
                foreach (var child in MdiChildren)
                {
                    if (child is frmUserManager)
                    {
                        var f = (frmUserManager)child;

                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
                if (!valForm)
                {
                    try
                    {
                        ShowFormUserManager();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void fileChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmResetPass frm = new frmResetPass(true);
                frm.ShowDialog();
                frm.Dispose();
            }
            catch (Exception)
            {
            }
        }

        private void tool_downloadImageVatGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void tool_Permitsion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool valForm = false;
                foreach (var child in MdiChildren)
                {
                    if (child is frmDanhSachQuyen)
                    {
                        var f = (frmDanhSachQuyen)child;

                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
                if (!valForm)
                {
                    try
                    {
                        var frm = new frmDanhSachQuyen();
                        frm.MdiParent = this;
                        frm.Text = "Danh sách quyền";
                        frm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }




        private void web_Footer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is QT.Moduls.Web.frmFooter)
                {
                    var f = (frmFooter)child;
                    if (f.Text == "Web footer")
                    {
                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
            }
            if (!valForm)
            {
                try
                {
                    frmFooter frm = new frmFooter();
                    frm.MdiParent = this;
                    frm.Text = "Web footer";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barManagerProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is QT.Moduls.Maps.frmManagerProduct)
                {
                    var f = (frmManagerProduct)child;
                    if (f.Text == "Manager product id")
                    {
                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
            }
            if (!valForm)
            {
                try
                {
                    frmManagerProduct frm = new frmManagerProduct();
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Text = "Manager product id";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barMapProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            //foreach (var child in MdiChildren)
            //{
            //    if (child is QT.Moduls.Maps.frmClassificationToTree)
            //    {
            //        var f = (frmClassificationToTree)child;
            //        if (f.Text == "ComToTree")
            //        {
            //            child.BringToFront();
            //            valForm = true;
            //            break;
            //        }
            //    }
            //}
            if (!valForm)
            {
                try
                {
                    frmClassificationToTree frm = new frmClassificationToTree();
                    frm.MdiParent = this;
                    frm.Text = "ComToTree";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barManagerCrawler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            if (!valForm)
            {
                try
                {
                    frmManagerCom frm = new frmManagerCom();
                    frm.MdiParent = this;
                    frm.Text = "Mannager Company Run";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void web_STTProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is QT.Moduls.Web.frmWebViewType)
                {
                    var f = (frmWebViewType)child;
                    if (f.Text == "Web ViewsType")
                    {
                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
            }
            if (!valForm)
            {
                try
                {
                    frmWebViewType frm = new frmWebViewType();
                    frm.MdiParent = this;
                    frm.Text = "Web ViewsType";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonGetContentNews_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool valForm = false;
                //foreach (var child in MdiChildren)
                //{
                //    if (child is frmToolMain)
                //    {
                //        var f = (frmToolMain)child;

                //        child.BringToFront();
                //        valForm = true;
                //        break;
                //    }
                //}
                if (!valForm)
                {
                    try
                    {
                        ShowFormGetContentNews();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void barButtonIChamNhuanBut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmNewsReport)
                {
                    var f = (frmNewsReport)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmNewsReport frm = new frmNewsReport();
                    frm.MdiParent = this;
                    frm.Text = "frmNewsReport";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void file_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void barRun20CrawlerHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmReportCompanyNeedFixConfig frm = new FrmReportCompanyNeedFixConfig();
            frm.MdiParent = this;
            frm.Show();

            //comandCrawler = Common.ListWebCommand.CrawlerSanPhamCu;
            //_lsIDCongTy = new List<long>();
            //_lsIDCongTy = this.ctrListWebSite1.GetListIDCompany();
            //_lsDomainCongTy = this.ctrListWebSite1.GetListDomainCompany();
            //this.timerHistory.Interval = Common.Obj2Int(barRun20TimeDelay.EditValue.ToString()) * 1000;
            //timerHistory_Tick(sender, e);
            //timerHistory.Start();
        }
        private void barRun20Queue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmReportReloadTimeNewProduct fr = new FrmReportReloadTimeNewProduct();
            fr.MdiParent = this;
            fr.Show();

            //comandCrawler = Common.ListWebCommand.FindNewManual;
            //_lsIDCongTy = new List<long>();
            //_lsIDCongTy = this.ctrListWebSite1.GetListIDCompany();
            //_lsDomainCongTy = this.ctrListWebSite1.GetListDomainCompany();
            //this.timerHistory.Interval = Common.Obj2Int(barRun20TimeDelay.EditValue.ToString()) * 1000;
            //timerHistory_Tick(sender, e);
            //timerHistory.Start();
        }

        private void barRunImage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            comandCrawler = Common.ListWebCommand.DownloadAllImage;
            _lsIDCongTy = new List<long>();
            _lsIDCongTy = this.ctrListWebSite1.GetListIDCompany();
            _lsDomainCongTy = this.ctrListWebSite1.GetListDomainCompany();
            this.timerHistory.Interval = Common.Obj2Int(barRun20TimeDelay.EditValue.ToString()) * 1000;
            timerHistory_Tick(sender, e);
            timerHistory.Start();

        }

        private void barStopRun20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            //timerHistory.Stop();
            //barLaRun20.Caption = "Stop";
        }


        private List<long> _lsIDCongTy;
        private List<string> _lsDomainCongTy;
        private int _positionCrawer = 0;
        private int _tongCrawler = 15;
        private Common.ListWebCommand comandCrawler = Common.ListWebCommand.CrawlerSanPhamCu;
        private DateTime _LastUpdateManager = DateTime.Now;
        private void timerHistory_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now > _LastUpdateManager.AddMinutes(1))
            {
                _LastUpdateManager = DateTime.Now;
                QT.Moduls.Crawler.ManagerCrawler obj = new ManagerCrawler();
                switch (comandCrawler)
                {
                    case Common.ListWebCommand.CrawlerSanPhamCu:
                        obj.Insert(this.ctrListWebSite1.GetIDManagerType(), (int)comandCrawler, MdiChildren.Length, QT.Entities.Server.ServerRun + "-" + this.ctrListWebSite1.GetCommentCrawler()); ;
                        break;
                    case Common.ListWebCommand.DownloadAllImage:
                        obj.Insert(this.ctrListWebSite1.GetIDManagerType(), (int)comandCrawler, MdiChildren.Length, QT.Entities.Server.ServerRun + "-" + this.ctrListWebSite1.GetCommentCrawler()); ;
                        break;
                    case Common.ListWebCommand.FindNewManual:
                        obj.Insert(this.ctrListWebSite1.GetIDManagerType(), (int)comandCrawler, MdiChildren.Length, QT.Entities.Server.ServerRun);
                        break;
                }
            }


            if (comandCrawler == Common.ListWebCommand.FindNewManual)
            {
                barLaRun20.Caption = String.Format("Run Queue - {0} - {1}", _positionCrawer, _lsDomainCongTy[_positionCrawer]);
                //barRun20Total.EditValue = _lsIDCongTy.Count.ToString();
            }
            if (comandCrawler == Common.ListWebCommand.CrawlerSanPhamCu)
            {
                barLaRun20.Caption = String.Format("Run History - {0} - {1}", _positionCrawer, _lsDomainCongTy[_positionCrawer]);
            }
            _tongCrawler = Common.Obj2Int(barRun20Total.EditValue.ToString());
            this.timerHistory.Interval = Common.Obj2Int(barRun20TimeDelay.EditValue.ToString()) * 1000;
            if (MdiChildren.Length < _tongCrawler)
            {
                // kiểm tra form tiếp theo có đang chạy không
                // nếu không thì bật form mới
                bool valForm = false;
                foreach (var child in MdiChildren)
                {
                    //if (child is QT.Moduls.Crawler.frmCrawlerProduct)
                    //{
                    //    var f = (frmCrawlerProduct)child;
                    //    if (f.Text == _lsDomainCongTy[_positionCrawer])
                    //    {
                    //        child.BringToFront();
                    //        valForm = true;
                    //        break;
                    //    }
                    //}
                }
                if (!valForm)
                {
                    Company objcompany = new Company(_lsIDCongTy[_positionCrawer]);
                    switch (comandCrawler)
                    {
                        case Common.ListWebCommand.FindNewManual:
                            if (objcompany.LastCrawler < DateTime.Now.AddMinutes(-30))
                            {
                                //frmCrawlerProduct frm = new frmCrawlerProduct(_lsIDCongTy[_positionCrawer]);
                                //frm.MdiParent = this;
                                //frm.QuetSPCu = true;
                                //frm.IsClose = true;
                                //frm.WebCommand = comandCrawler;
                                //frm.Text = _lsDomainCongTy[_positionCrawer];
                                //frm.Start();
                                //frm.Show();
                            }
                            break;
                        case Common.ListWebCommand.CrawlerAllSanPhamCu:
                        //frmCrawlerProduct frm1 = new frmCrawlerProduct(_lsIDCongTy[_positionCrawer]);
                        //frm1.MdiParent = this;
                        //frm1.QuetSPCu = true;
                        //frm1.IsClose = true;
                        //frm1.WebCommand = comandCrawler;
                        //frm1.Text = _lsDomainCongTy[_positionCrawer];
                        //frm1.Start();
                        //frm1.Show();
                        //break;
                        case Common.ListWebCommand.DownloadAllImage:
                            try
                            {
                                frmDowloadImage frm2 = new frmDowloadImage(_lsIDCongTy[_positionCrawer],
                                    "");
                                frm2.MdiParent = this;
                                frm2.FinishClose = true;
                                frm2.Text = "LoadImage " + this.ctrListWebSite1.GetDomain();
                                frm2.Dowload();
                                frm2.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;

                    }
                    if (comandCrawler == Common.ListWebCommand.FindNewManual)
                    {

                    }
                    else
                    {

                    }
                }

                if (_positionCrawer == _lsIDCongTy.Count - 1)
                {
                    _positionCrawer = 0;
                }
                else
                {
                    _positionCrawer = _positionCrawer + 1;
                }
            }
            xtraTabbedMdiManager1.MdiParent = null;
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void barButtonJobType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmJobType)
                {
                    var f = (frmJobType)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmJobType frm = new frmJobType();
                    frm.MdiParent = this;
                    frm.Text = "Loại công việc";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonJobMananager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmManagerJob)
                {
                    var f = (frmManagerJob)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmManagerJob frm = new frmManagerJob();
                    frm.MdiParent = this;
                    frm.Text = "Quản lý công việc";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonJob_PhanSanPhamNhapLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmPhanCongNhapDuLieuSanPhamGoc)
                {
                    var f = (frmPhanCongNhapDuLieuSanPhamGoc)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmPhanCongNhapDuLieuSanPhamGoc frm = new frmPhanCongNhapDuLieuSanPhamGoc();
                    frm.MdiParent = this;
                    frm.Text = "Quản lý Nhập dữ liệu sản phẩm gốc";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            ListCompanyDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
        }

        private void barButtonJob_BaoCaoNhapLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is ReportNhapDuLieuSPGoc)
                {
                    var f = (ReportNhapDuLieuSPGoc)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    ReportNhapDuLieuSPGoc frm = new ReportNhapDuLieuSPGoc();
                    frm.MdiParent = this;
                    frm.Text = "ReportNhapDuLieuSPGoc";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonJob_ConfigWeb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is ReportConfigWebsite)
                {
                    var f = (ReportConfigWebsite)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    ReportConfigWebsite frm = new ReportConfigWebsite();
                    frm.MdiParent = this;
                    frm.Text = "ReportConfigWebsite";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void barButtonJob_ManagerCrawler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            if (!valForm)
            {
                try
                {
                    frmManagerCom frm = new frmManagerCom();
                    frm.MdiParent = this;
                    frm.Text = "Mannager Company Run";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }


        private void barButtonDoiTenSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmEditeTenSanPham)
                {
                    var f = (frmEditeTenSanPham)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmEditeTenSanPham frm = new frmEditeTenSanPham();
                    frm.MdiParent = this;
                    frm.Text = "Đổi tên sản phẩm";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void news_threatManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmThreatManager)
                {
                    var f = (frmThreatManager)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmThreatManager frm = new frmThreatManager();
                    frm.MdiParent = this;
                    frm.Text = "Quản lý nội dung";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void btNewsThreadViewType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmThreadViewType)
                {
                    var f = (frmThreadViewType)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmThreadViewType frm = new frmThreadViewType();
                    frm.MdiParent = this;
                    frm.Text = "Quản lý loại nội dung";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void bt_Sales_ChonKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmManagerOwnWebsite)
                {
                    var f = (frmManagerOwnWebsite)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmManagerOwnWebsite frm = new frmManagerOwnWebsite();
                    frm.MdiParent = this;
                    frm.Text = "Quản lý Khách hàng";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonItemTagProductAndCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmTagSPGoc)
                {
                    var f = (frmTagSPGoc)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmTagSPGoc frm = new frmTagSPGoc();
                    frm.MdiParent = this;
                    frm.Text = "Nhập tag sản phẩm và category";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ConfigHaravanButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmSettingHaravan)
                {
                    var f = (frmSettingHaravan)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmSettingHaravan frm = new frmSettingHaravan();
                    frm.MdiParent = this;
                    frm.Text = "Thiết lập Haravan";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void ConfigBizwebButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmSettingBizwebs)
                {
                    var f = (frmSettingBizwebs)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmSettingBizwebs frm = new frmSettingBizwebs();
                    frm.MdiParent = this;
                    frm.Text = "Thiết lập Bizweb";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }



        private void btnTrackCrawler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QT.Moduls.Crawler.FrmViewLogAllCompany frm = new QT.Moduls.Crawler.FrmViewLogAllCompany();
            frm.Show();
        }




        private void barButtonItemTagByCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmTagByCompany)
                {
                    var f = (frmTagByCompany)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmTagByCompany frm = new frmTagByCompany();
                    frm.MdiParent = this;
                    frm.Text = "Nhập tag theo Công ty";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void PriorityCategoryButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmCategorySearchPriority)
                {
                    var f = (frmCategorySearchPriority)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmCategorySearchPriority frm = new frmCategorySearchPriority();
                    frm.MdiParent = this;
                    frm.Text = "Nhập Priority Category";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAnalysicInfoFacebook frm = new FrmAnalysicInfoFacebook();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmManagerFacebook frm = new FrmManagerFacebook();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnFindNewProduct_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string query = @"
Select top 10
a.ID, a.Name, a.Domain, b.id as Config_id, LastCrawlerFindNew, IsNULL(a.LastEndCrawlerFindNew, c.LastUpdateProduct) as LastEndCrawlerFindNew, b.HoursReCrawler
from Company a
inner join Configuration b on a.id = b.CompanyID
left join V_CompanyLast c on c.id = a.id
where 1=1
and a.ID > 0																				 --ID Hợp lệ
and datediff(minute, isnull([LastEndCrawlerFindNew],'2000-10-10 10:10:10'),getdate())>120	--Hoàn thành crawler (nếu có) cách đây ít nhất 2 tiếng.
and DataFeedType = 0                                                                        --Không sử dụng DataFeed
and Website like '%http%'                                                                   --Website có cấu trúc tốt
and (IsNULL([IsStopCrawlerImediate],0)=0)													--không dừng bởi người dùng 
and (DATEDIFF(MINUTE,ISNULL([LastJobCrawlerFindNew],'2010-10-10 10:10:10'),GETDATE())>120)    --Xứ lí job cuối cùng cách đây 60 phút
and a.TotalProduct>1600  and a.TotalProduct<2400                                              --Ràng buộc tổng số sản phẩm
and  [status] = 1 
--and a.id = 13503212810074591                                                               --ID Test nếu cần
order by ISNULL([LastJobCrawlerFindNew],'2010-10-10 10:10:10') ASC  --Ưu tiên dữ liệu crawler cũ nhất lên đầu
";

            FrmPushJobCrawler frm = new FrmPushJobCrawler(query, "TaskCrawler_FindNewProduct", 0);
            frm.MdiParent = this;
            frm.Show();
        }

        int numberRunning = 0;
        private IConnection rabbitMQConnection;
        private System.Windows.Forms.Timer timmerRun;


        private void btnGetJob_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void XMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                RabbitMQManager.GetRabbitMQServer(QT.Entities.Server.RabbitMQ_CrawlerProduct).Stop();
            }
            catch (Exception)
            {
            }

            if (this.timmerRun != null)
            {
                this.timmerRun.Dispose();
            }
            if (this.rabbitMQConnection != null && this.rabbitMQConnection.IsOpen)
            {
                this.rabbitMQConnection.Close();
            }
        }

        private void btnStopConsumer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnPushJobReloadProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<DataRowView> lstRowSelected = ctrListWebSite1.GetListSelectedRow();
            if (lstRowSelected.Count > 0)
            {
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                foreach (DataRowView dataRow in lstRowSelected)
                {
                    long CompanyID = Convert.ToInt64(dataRow["ID"]);
                    productAdapter.PushQueueIndexCompany(CompanyID);
                }
            }
            MessageBox.Show("Success!");
        }

        private void btnCacheRedis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPushCacheRedis frm = new FrmPushCacheRedis();
            frm.MdiParent = this;
            frm.Show();
        }


        private void btnFindNewProductInList_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoCrawlerManual(true);
        }

        private string QueueName = "TaskCrawler_Manual_" + Guid.NewGuid().ToString();
        private bool bRunned = false;
        private IConnection mqConnecManual = null;
        IModel channel = null;
        private void DoCrawlerManual(bool IsFindNew)
        {
            //if (mqConnecManual == null  || mqConnecManual.IsOpen == false)
            //{
            //    mqConnecManual = RabbitMQCreator.CreateConnection();
            //    channel =  mqConnecManual.CreateModel();
            //    channel.QueueDeclare(QueueName, true, false, true, null);
            //    this.FormClosing += new FormClosingEventHandler(delegate(object obj01, FormClosingEventArgs args1)
            //    {
            //        if (mqConnecManual != null && mqConnecManual.IsOpen == true) mqConnecManual.Close();
            //    });
            //}

            //if (!bRunned)
            //{
            //    for (int i = 0; i < 1; i++)
            //    {
            //        frmCrawlerProductRedis frm = new frmCrawlerProductRedis(mqConnecManual, QueueName);
            //        frm.MdiParent = this;
            //        frm.Start();
            //        frm.Show();
            //    }
            //    bRunned = true;
            //}

            //xtraTabbedMdiManager1.MdiParent = null;
            //this.LayoutMdi(MdiLayout.TileVertical);
            //var lstSelected = this.ctrListWebSite1.GetListSelectedRow();
            //if (lstSelected != null && lstSelected.Count > 0)
            //{
            //    //Crawler dữ liệu từ Form tự tạo. 
            //    //Khi kết thúc hệ thống tự Remove queue.
            //    CrawlerProductAdapter crawlerAdapter = new CrawlerProductAdapter(new SqlDb(QT.Entities.Server.ConnectionStringCrawler));
            //    SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);
            //    foreach (DataRowView row in this.ctrListWebSite1.GetListSelectedRow())
            //    {
            //        long company = Convert.ToInt64(row["ID"]);
            //        string domain = Convert.ToString(row["Domain"]);
            //        QT.Entities.CrawlerProduct.TaskCrawlerCompany task = new TaskCrawlerCompany()
            //        {
            //            IdCompany = company,
            //            iType = (IsFindNew == true) ? 0 : 1,
            //            Domain = domain,
            //            DatePushJob = sqlDb.GetCurrent()
            //        };
            //        var a1 = Websosanh.Core.Common.BAL.ProtobufTool.Serialize(task);
            //        if (IsFindNew) crawlerAdapter.ClearSessionCrawler(task.IdCompany);
            //        channel.BasicPublish("", QueueName, null, a1);
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Chưa chọn dữ liệu!");
            //}
        }

        private void btnCrawlerManualReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DoCrawlerManual(false);
        }

        private void btnStartCrawlerMQ2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }






        private Queue<long> QueueCompanyCrawlerReload = new Queue<long>();
        private bool IsQueueCompanyCrawlerReload = false;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Crawlerreload(1);
        }

        public void Crawlerreload(int TypeReload)
        {
            Queue<long> lstCompanyID = new Queue<long>();
            var rowSelected = ctrListWebSite1.GetListSelectedRow();
            foreach (DataRowView rowView in rowSelected)
            {
                long a = Convert.ToInt64(rowView["ID"]);
                lstCompanyID.Enqueue(a);
            }
            FrmCrawlerData frmCrawlerData = new FrmCrawlerData(lstCompanyID, 1);
            frmCrawlerData.MdiParent = this;
            frmCrawlerData.Show();
        }

        Queue<long> QueueCompanyCrawler = new Queue<long>();
        private void CrawlerProduct3_FindNew_Manual_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Queue<long> lstCompanyID = new Queue<long>();
            var rowSelected = ctrListWebSite1.GetListSelectedRow();
            foreach (DataRowView rowView in rowSelected)
            {
                long a = Convert.ToInt64(rowView["ID"]);
                lstCompanyID.Enqueue(a);
            }
            FrmCrawlerData frmCrawlerData = new FrmCrawlerData(lstCompanyID, 0);
            frmCrawlerData.MdiParent = this;
            frmCrawlerData.Show();
        }



        private void barButtonItemConfigClassification_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmConfigClassification)
                {
                    var f = (frmConfigClassification)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmConfigClassification frm = new frmConfigClassification();
                    frm.MdiParent = this;
                    frm.Text = "Thiết lập chuyên mục cho khách hàng";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnCacheRedisDataCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<DataRowView> lst = ctrListWebSite1.GetListSelectedRow();
            List<long> lstCompany = new List<long>();
            foreach (DataRowView row in lst)
            {
                lstCompany.Add(Convert.ToInt64(row["ID"]));
            }
            FrmPushCacheRedis frm = new FrmPushCacheRedis(lstCompany);
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Thread threadUpdateCountProduct = new Thread(new ThreadStart(RunUpdateCountProduct));
            threadUpdateCountProduct.Start();
        }

        private void RunUpdateCountProduct()
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            productAdapter.UpdateCountProduct();
            this.Invoke(new Action(() =>
                {
                    MessageBox.Show("Đã cập nhật!");
                }));
        }

        private void btnDuyetID(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QT.Moduls.CrawlerProduct.WorkerDuyetID workerDuyetID = new WorkerDuyetID(1);
            workerDuyetID.Run();
        }

        private void btnPublicProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //QT.Moduls.Company.FrmPublicProduct frm = new FrmPublicProduct();
            //frm.Show();
        }

        private void btnPushLogPriceToRedis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPushPriceLogDataRedis frm = new FrmPushPriceLogDataRedis();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPriceChange frm = new FrmPriceChange();
            frm.Show();
        }

        private void btnLocSPSaiGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnReloadIsDealForCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            List<DataRowView> lst = ctrListWebSite1.GetListSelectedRow();
            List<long> lstCompany = new List<long>();
            foreach (DataRowView row in lst)
            {
                long CompanyID = Convert.ToInt64(row["ID"]);
                productAdapter.UpdateIsDealForCompany(CompanyID);
                LogJobAdapter.SaveLog(JobName.FrmCompany_ReloadIsDealState, "", CompanyID, (int)JobTypeData.Company);
            }
            MessageBox.Show(string.Format("Cập nhật cho {0} công ty", lst.Count));


        }

        private void btnViewLogJob_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLogJobViewReport frm = new FrmLogJobViewReport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCheckWebAlive_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QT.Moduls.FindWeb.FrmCheckAliveWeb frmCheckAliveWeb = new QT.Moduls.FindWeb.FrmCheckAliveWeb();
            frmCheckAliveWeb.Show();
        }

        private void btnViewMax_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLocSanPhamGoc frm = new FrmLocSanPhamGoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool valForm = false;
                foreach (var child in MdiChildren)
                {
                    if (child is frmProductToExcel)
                    {
                        var f = (frmProductToExcel)child;

                        child.BringToFront();
                        valForm = true;
                        break;
                    }
                }
                if (!valForm)
                {
                    try
                    {
                        var frm = new frmProductToExcel();
                        frm.MdiParent = this;
                        frm.Text = "Export to excel";
                        frm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnPushCacheAllCompanyToRedis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPushCacheAllCompanyToRedis frm = new FrmPushCacheAllCompanyToRedis();
            frm.MdiParent = this;
            frm.Show();
        }


        private void barButtonItemCheckUrlDatafeed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool valForm = false;
            foreach (var child in MdiChildren)
            {
                if (child is frmCheckDataFeedUrl)
                {
                    var f = (frmCheckDataFeedUrl)child;
                    child.BringToFront();
                    valForm = true;
                    break;
                }
            }
            if (!valForm)
            {
                try
                {
                    frmCheckDataFeedUrl frm = new frmCheckDataFeedUrl();
                    frm.MdiParent = this;
                    frm.Text = "Danh sách DataFeed";
                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnCleanDuplicateProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCleanDuplicateProduct frm = new FrmCleanDuplicateProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCleanAllDuplicateProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnReportErrorConfig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmReportCompanyNeedFixConfig frm = new FrmReportCompanyNeedFixConfig();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSmallCrawler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            var rowSelected = ctrListWebSite1.GetListSelectedRow();
            if (rowSelected.Count > 0)
            {
                foreach (DataRowView rowView in ctrListWebSite1.GetListSelectedRow())
                {
                    long _companyID = Convert.ToInt64(rowView["ID"]);
                    if (productAdapter.CheckAllowCrawler(_companyID))
                    {
                        FrmImportProductFromFixedLink frm = new FrmImportProductFromFixedLink(_companyID);
                        frm.MdiParent = this;
                        frm.Text = "ID:" + _companyID;
                        frm.WindowState = FormWindowState.Minimized;
                        frm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn công ty để import!");
            }
        }

        private void ctrListWebSite1_RepaiConfig(object sender, EventArgs e)
        {
            frmCongTy frm = new frmCongTy();
            frm.MdiParent = this;
            frm.SelectCompany(ctrListWebSite1.getNeedRepairID());
            frm.Show();
        }

        private void btnPuslSolrProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPushProductSolr frmPushProductSOlr = new FrmPushProductSolr();
            frmPushProductSOlr.Show();
        }

        private void btnReportMinLastUpdateProductCrawler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmReportMinLastUpdateProductCrawler frm = new FrmReportMinLastUpdateProductCrawler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmReportReloadTimeNewProduct fr = new FrmReportReloadTimeNewProduct();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnCurrentCrawler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCurrentCrawlerProduct frm = new FrmCurrentCrawlerProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCheckClassification_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCheckClassification frm = new FrmCheckClassification();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRattingCompany frm = new FrmRattingCompany();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFindWebsite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFindWebsiteFromGoogle frm = new FrmFindWebsiteFromGoogle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnWebsiteNewMn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmWebsiteNewManager frm = new FrmWebsiteNewManager();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKeywordMn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKeywordManager frm = new FrmKeywordManager();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnLogReportCrawlerMQ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmReportLogCrawlerMQ frm = new FrmReportLogCrawlerMQ();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnValidCrawler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FrmValidCrawler frm = new FrmValidCrawler();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            List<DataRowView> lstRowSelected = ctrListWebSite1.GetListSelectedRow();
            if (lstRowSelected.Count > 0)
            {
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                foreach (DataRowView dataRow in lstRowSelected)
                {
                    long CompanyID = Convert.ToInt64(dataRow["ID"]);
                    string Domain = Convert.ToString(dataRow["Domain"]);
                    productAdapter.PushQueueReloadCacheProductInfo(CompanyID, Domain);
                }
            }
            MessageBox.Show("Success!");
        }

        private void btnNotifycation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNotifications frm = new FrmNotifications();
            frm.MdiParent = this;
            frm.Show();
        }


        private void barButtonItem17_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnStartNotification_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.btnStartNotification.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            QT.Moduls.Notifycation.FrmNotifications frm = new FrmNotifications();
            frm.RunTrackAuto();
        }

        private void btnCrawlerProductLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmWSS_LogManager frm = new FrmWSS_LogManager();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnResetCompanyCacheCrawler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmResetCompanyCacheCrawler frm = new FrmResetCompanyCacheCrawler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnImportLink_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmImportLink frm = new FrmImportLink();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFixPhoneError_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFixPhone frm = new FrmFixPhone();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QT.Moduls.KeywordSuggest.FrmViewKeywordSuggest frm = new QT.Moduls.KeywordSuggest.FrmViewKeywordSuggest();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItemPushKeyword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKeywordRank frm = new frmKeywordRank();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPustProductImage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPushProductImage frm = new FrmPushProductImage();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnViewReportFielCrawler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTrackFieldCrawler frm = new FrmTrackFieldCrawler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItemTrustedFollow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTrustedFollow frm = new FrmTrustedFollow();
            frm.MdiParent = this;
            frm.Show();
        }





    }
}