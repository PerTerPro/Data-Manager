using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;
using System.Net;
using System.IO;
using Websosanh.Imaging;
using System.Threading;
using Bussiness;
namespace QT.Moduls.Tool
{
    public partial class frmToolMain : QT.Entities.frmBase
    {

        public frmToolMain()
        {
            InitializeComponent();
        }

        private void btUpdateCompany_Click(object sender, EventArgs e)
        {
            Dictionary<long, int> listQueue = new Dictionary<long, int>();
            Dictionary<long, int> listVisited = new Dictionary<long, int>();
            Dictionary<long, int> listTotal = new Dictionary<long, int>();
            Dictionary<long, int> listTotalValid = new Dictionary<long, int>();



            this.laMess1.Text = "Start download data";
            this.view_TongSanPhamTableAdapter.Fill(dBTool.View_TongSanPham);

            Application.DoEvents();
            foreach (DBTool.View_TongSanPhamRow dr in dBTool.View_TongSanPham)
            {
                listTotal.Add(dr.ID, dr.TongSP);
                //this.laMess1.Text = "Update TongSanPham " + dr.Domain.ToString();
                //this.companyTableAdapter.UpdateQuery_TotalProduct(dr.TongSP, dr.ID);
                //Application.DoEvents();
            }
            this.laMess1.Text = "Start download data valid";
            this.view_TongSanPhamValidTableAdapter.Fill(dBTool.View_TongSanPhamValid);
            Application.DoEvents();
            foreach (DBTool.View_TongSanPhamValidRow dr in dBTool.View_TongSanPhamValid)
            {
                listTotalValid.Add(dr.ID, dr.TongSP);
                //this.laMess1.Text = "Update TongSanPhamValid " + dr.Domain.ToString();
                //this.companyTableAdapter.UpdateQuery_TotalValid(dr.TongSP, dr.ID);
                //Application.DoEvents();
            }

            this.laMess1.Text = "Start download data Queue";
            this.view_QueueCountTableAdapter.Fill(dBTool.View_QueueCount);
            Application.DoEvents();
            foreach (DBTool.View_QueueCountRow dr in dBTool.View_QueueCount)
            {
                listQueue.Add(dr.Company, dr.Count);
                //this.laMess1.Text = "Update Queue " + dr.Company.ToString();
                //this.companyTableAdapter.UpdateQuery_Queue(dr.Count, dr.Company);
                //Application.DoEvents();
            }
            this.laMess1.Text = "Start download data Visited";
            this.view_VisitedCountTableAdapter.Fill(dBTool.View_VisitedCount);
            Application.DoEvents();
            foreach (DBTool.View_VisitedCountRow dr in dBTool.View_VisitedCount)
            {
                listVisited.Add(dr.Company, dr.Count);
            }

            this.laMess1.Text = "Update data Company";
            this.companyTableAdapter.FillBy_AllCalculatorTotal(dBTool.Company);
            //DBTool.CompanyDataTable dt = new DBTool.CompanyDataTable();
            //this.companyTableAdapter.FillBy_Status(dt, Common.CompanyStatus.SPGOC);
            //this.dBTool.Company.Merge(dt);
            foreach (DBTool.CompanyRow dr in dBTool.Company)
            {
                int total = 0, valid = 0, queue = 0, visited = 0, maxValid = 0;
                try { total = listTotal[dr.ID]; }
                catch (Exception) { }
                try { valid = listTotalValid[dr.ID]; }
                catch (Exception) { }
                try { queue = listQueue[dr.ID]; }
                catch (Exception) { }
                try { visited = listVisited[dr.ID]; }
                catch (Exception) { }
                try { maxValid = dr.TimeDelay; }
                catch (Exception) { }
                if (maxValid < valid) { maxValid = valid; }
                this.laMess1.Text = "Update Domain " + dr.Domain.ToString();
                this.companyTableAdapter.UpdateQuery_Total_Valid_Queue_Visited(total, total - valid, queue, visited, maxValid, dr.ID);
                Application.DoEvents();
            }

            this.laMess1.Text = "Finish...";

        }

        private void frmToolMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTool.ManagerType' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dBTool.View_VisitedCount' table. You can move, or remove it, as needed.
            this.managerTypeTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.view_VisitedCountTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;
            this.view_QueueCountTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;
            this.productIDHashNameTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.view_TongSanPhamValidTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.view_TongSanPhamTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.companyTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.managerTypeTableAdapter.Fill(this.dBTool.ManagerType);
            this.companyTableAdapter.FillBy_Status(dBTool.Company, QT.Entities.Common.CompanyStatus.CONFIG);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            this.laMess1.Text = "Start download data update  hashname";
            this.productIDHashNameTableAdapter.FillByAllAndDomain(dBTool.ProductIDHashName);
            Application.DoEvents();
            int i = 0;
            foreach (DBTool.ProductIDHashNameRow dr in dBTool.ProductIDHashName)
            {
                i++;
                string f = "Update Hash ID {0}/{1} - {2}";
                this.laMess1.Text = String.Format(f, i, dBTool.ProductIDHashName.Rows.Count, dr.Name.ToString());
                long hash = QT.Entities.Common.GetHashNameProduct(dr.Domain, dr.Name);
                long id = QT.Entities.Common.GetIDProduct(dr.DetailUrl);
                //this.productIDHashNameTableAdapter.UpdateQuery_ID_HashName(id, hash, dr.ID);
                this.productIDHashNameTableAdapter.UpdateQuery_HashName(hash, dr.ID);
                Application.DoEvents();
            }
            this.laMess1.Text = "Finish...";

        }

        private void btUpdateComID_Click(object sender, EventArgs e)
        {
            this.laMess1.Text = "Start download data update Company ID";
            this.companyTableAdapter.FillBy_Status(dBTool.Company, QT.Entities.Common.CompanyStatus.NOAVAILABLE);
            Application.DoEvents();
            int i = 0;
            Uri rootUri;
            foreach (DBTool.CompanyRow dr in dBTool.Company)
            {
                i++;
                string f = "Update Company ID {0}/{1} - {2}";
                this.laMess1.Text = String.Format(f, i, dBTool.Company.Rows.Count, dr.Domain.ToString());

                try
                {
                    rootUri = new Uri(dr.Website);
                    string domain = rootUri.Host;
                    domain = domain.Replace("www.", "");
                    domain = domain.Replace("WWW.", "");
                    long id = QT.Entities.Common.GetIDCompany(domain);
                    this.companyTableAdapter.UpdateQuery_ID_Domain(id, domain, dr.ID);
                }
                catch (Exception)
                {
                    //MessageBox.Show("trùng domain" + dr.Website);
                }
                Application.DoEvents();
            }
            this.laMess1.Text = "Finish...";
        }

        private void btUpdateClassification_Click(object sender, EventArgs e)
        {
            this.laMess1.Text = "Start download data Classification";
            this.companyTableAdapter.FillBy_Status(dBTool.Company, QT.Entities.Common.CompanyStatus.NOAVAILABLE);
            Application.DoEvents();
            int i = 0;
            Uri rootUri;
            foreach (DBTool.CompanyRow dr in dBTool.Company)
            {
                i++;
                string f = "Update Company ID {0}/{1} - {2}";
                this.laMess1.Text = String.Format(f, i, dBTool.Company.Rows.Count, dr.Domain.ToString());

                try
                {
                    rootUri = new Uri(dr.Website);
                    string domain = rootUri.Host;
                    domain = domain.Replace("www.", "");
                    domain = domain.Replace("WWW.", "");
                    long id = QT.Entities.Common.GetIDCompany(domain);
                    this.companyTableAdapter.UpdateQuery_ID_Domain(id, domain, dr.ID);
                }
                catch (Exception)
                {
                    //MessageBox.Show("trùng domain" + dr.Website);
                }
                Application.DoEvents();
            }
            this.laMess1.Text = "Finish...";
        }

        private void btDownloadLogo_Click(object sender, EventArgs e)
        {
            //DBTool.CompanyDataTable dt = new DBTool.CompanyDataTable();
            //companyTableAdapter.FillBy_Status(dt, Common.CompanyStatus.CONFIG);

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    try
            //    {
            //        this.laMess1.Text = " download logo " + i.ToString() + "/" + dt.Rows.Count.ToString() + dt.Rows[i]["Domain"].ToString();
            //        String name = dt.Rows[i]["Domain"].ToString().Replace('.', '_');
            //        String folder = dt.Rows[i]["Domain"].ToString().Substring(0, 2);
            //        //folder = "";
            //        Common.SaveFile(dt.Rows[i]["Image"].ToString(), "C:\\QTLog\\Logo\\" + folder + "\\", name + ".jpg");
            //        Application.DoEvents();
            //    }
            //    catch (Exception)
            //    {
            //    }
            //}
            //this.laMess1.Text = " download logo finish";

        }

        void doDowload(Object id)
        {
            DBToolTableAdapters.View_SanPhamImageTableAdapter adt = new DBToolTableAdapters.View_SanPhamImageTableAdapter();
            DBTool.View_SanPhamImageDataTable dt = new DBTool.View_SanPhamImageDataTable();
            adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            if (adt.Connection.State == ConnectionState.Closed) adt.Connection.Open();
            long idCompany = 0;
            bool isdownloadImageNhap = false;
            this.Invoke((MethodInvoker)delegate
            {
                this.laMess1.Text = String.Format("Start download data");
                idCompany = QT.Entities.Common.Obj2Int64(id);
                isdownloadImageNhap = chkImageAdmin.Checked;
            });
            switch (cboCommand.SelectedIndex)
            {
                case 0: //Current Not Valid
                    adt.FillBy_ChuaKiemTraTheoCongTy(dt, idCompany);
                    break;
                case 1: //Current All
                    adt.FillBy_AllByCompany(dt, idCompany);
                    break;
                case 2: //All Check not valid
                    adt.FillBy_ChuaKiemTraTheoCongTy(dt, idCompany);
                    //DBTool.View_SanPhamImageDataTable dt1 = new DBTool.View_SanPhamImageDataTable();
                    //foreach (DBTool.CompanyRow dr in this.dBTool.Company)
                    //{
                    //    if (dr.CheckD == true)
                    //    {
                    //        this.Invoke((MethodInvoker)delegate
                    //        {
                    //            this.laMess1.Text = String.Format("start download {0}", dr.Domain);
                    //        });
                    //        adt.FillBy_ChuaKiemTraTheoCongTy(dt1, dr.ID);
                    //        dt.Merge(dt1);
                    //    }
                    //}
                    //dt.AcceptChanges();
                    break;
                case 3: //All Check
                    adt.FillBy_AllByCompany(dt, idCompany);
                    //DBTool.View_SanPhamImageDataTable dt2 = new DBTool.View_SanPhamImageDataTable();
                    //foreach (DBTool.CompanyRow dr in this.dBTool.Company)
                    //{
                    //    if (dr.CheckD == true)
                    //    {
                    //        this.Invoke((MethodInvoker)delegate
                    //        {
                    //            this.laMess1.Text = String.Format("start download {0}", dr.Domain);
                    //        });
                    //        adt.FillBy_AllByCompany(dt2, dr.ID);
                    //        dt.Merge(dt2);
                    //    }
                    //}
                    //dt.AcceptChanges();
                    break;
                case 4: //Config ananytic
                    DBTool.View_SanPhamImageDataTable dt3 = new DBTool.View_SanPhamImageDataTable();
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.laMess1.Text = String.Format("start download {0}", "quangtrung.vn");
                    });
                    if (isdownloadImageNhap)
                    {
                        // Update ảnh ở bảng ProductImage sang 

                        adt.FillBy_SanPhamGocCoAnhNhap(dt3, QT.Entities.Common.GetIDCompany("quangtrung.vn"));
                    }
                    else
                    {
                        adt.FillBy_SPConfigAnanytic(dt3, QT.Entities.Common.GetIDCompany("quangtrung.vn"));
                    }
                    dt.Merge(dt3);
                    dt.AcceptChanges();
                    break;
            }
            this.Invoke((MethodInvoker)delegate
            {
                this.laMess1.Text = String.Format("download finish");
            });
            String path = "";
            path = "D:\\Beta\\img\\";
            path = QT.Entities.Common.FolderImage;
            DBToolTableAdapters.ProductImagePathTableAdapter adtPro = new DBToolTableAdapters.ProductImagePathTableAdapter();
            adtPro.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            if (adtPro.Connection.State == ConnectionState.Closed) adtPro.Connection.Open();

            int count = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    String url = dt.Rows[i]["DetailUrl"].ToString();
                    Uri root = new Uri(url);
                    String namepath = root.DnsSafeHost.Replace("www.", "").Replace('.', '_');
                    //namepath = Common.UnicodeToKoDauAndGach(namepath.Replace("  ", " ").Replace("  ", " ").Trim());
                    if (cboCommand.SelectedIndex == 4)
                    {
                        namepath = "images";
                    }
                    string ss = namepath + "\\";
                    string filename = QT.Entities.Common.UnicodeToKoDauAndGach(dt.Rows[i]["Name"].ToString());
                    string tempf = filename.Replace("-","");
                    string s3 = tempf.Substring(0, 3);
                    if (s3 == "bin") s3 = "bin1";
                    ss += s3 + "\\";
                    if (filename.Length > 100)
                    {
                        filename = filename.Substring(0, 99);
                    }

                    String fullfile = path + ss + filename + ".jpg";

                    if (chkRedownload.Checked == true)
                    {
                        //Bitmap thumbBitmap = null;
                        //try
                        //{
                        //    thumbBitmap = new Bitmap(fullfile);
                        //    string pathsave = ss + filename + ".jpg";
                        //    pathsave = "Store/" + pathsave.Replace('\\', '/');
                        //    adtPro.UpdateQuery(pathsave, thumbBitmap.Width, thumbBitmap.Height, QT.Entities.Common.Obj2Int64(dt.Rows[i]["ID"].ToString()));
                        //}
                        //catch (Exception ex)
                        //{
                        //    this.Invoke((MethodInvoker)delegate
                        //    {
                        //        this.laMess1.Text = String.Format("Error {0}/{1}{2}", i, dt.Rows.Count, ex);
                        //    });
                        //}
                    }
                    else
                    {
                        if (!File.Exists(fullfile))
                        {
                            /// chưa có file --> tải lại dữ liệu
                            int w = 0, h = 0;
                            string fileSave = QT.Entities.Common.SaveFile(dt.Rows[i]["ImageUrls"].ToString(), path + ss, filename + ".jpg", out w, out h,false);
                            count++;
                            if (fileSave != "")
                            {
                                string pathsave = ss + filename.Replace('\\', '/') + ".jpg";
                                pathsave = "Store/" + pathsave.Replace('\\', '/');
                                adtPro.UpdateQuery(pathsave, w, h, QT.Entities.Common.Obj2Int64(dt.Rows[i]["ID"].ToString()));
                                count++;
                            }
                        }
                        else
                        {
                            if (dt.Rows[i]["ImagePath"].ToString() == "")
                            {
                                Bitmap thumbBitmap = null;
                                try
                                {
                                    thumbBitmap = new Bitmap(fullfile);
                                    string pathsave = ss + filename + ".jpg";
                                    pathsave = "Store/" + pathsave.Replace('\\', '/');
                                    adtPro.UpdateQuery(pathsave, thumbBitmap.Width, thumbBitmap.Height, QT.Entities.Common.Obj2Int64(dt.Rows[i]["ID"].ToString()));
                                }
                                catch (Exception ex)
                                {
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        this.laMess1.Text = String.Format("Error {0}/{1}{2}", i, dt.Rows.Count, ex);
                                    });
                                }
                            }
                        }
                    }
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.laMess1.Text = String.Format("{0}/{1} download:{2} - {3}\n{4}", i, dt.Rows.Count, count, dt.Rows[i]["Name"].ToString(), dt.Rows[i]["DetailUrl"].ToString());
                    });
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.laMess1.Text = String.Format("{0}/{1} download:{2} - {3}\n{4}\n{5}", i, dt.Rows.Count, count, dt.Rows[i]["Name"].ToString(), dt.Rows[i]["DetailUrl"].ToString(),ex.ToString());
                        Thread.Sleep(5000);
                    });
                }


                
            }
            adtPro.Dispose();
            dt.Clear();
            dt.Dispose();
            adt.Dispose();
        }

        private Thread downloadThread;
        private void btDownloadImage_Click(object sender, EventArgs e)
        {
            this.companyBindingSource.EndEdit();
            switch (cboCommand.SelectedIndex)
            {
                case 3:
                case 2: //All Check not valid
                    this.companyBindingSource.MoveFirst();
                    for (int i = 0; i < companyBindingSource.Count; i++)
                    {
                        if (this.checkDCheckBox.Checked == true)
                        {
                            //downloadThread = new Thread(new ThreadStart(doDowload(long)));
                            downloadThread =  new Thread(doDowload);
                            downloadThread.Start(QT.Entities.Common.Obj2Int64(this.iDTextBox.Text.Trim()));
                        }
                        this.companyBindingSource.MoveNext();
                    }
                    break;
                default:
                    //downloadThread = new Thread(new ThreadStart(doDowload(Common.Obj2Int64(this.iDTextBox.Text.Trim()))));
                    //downloadThread.Start();
                    downloadThread =  new Thread(doDowload);
                    downloadThread.Start(QT.Entities.Common.Obj2Int64(this.iDTextBox.Text.Trim()));
                    break;
            }



           
        }

        private void btDownloadImg_Click(object sender, EventArgs e)
        {
            DBToolTableAdapters.View_SanPhamImageTableAdapter adt = new DBToolTableAdapters.View_SanPhamImageTableAdapter();
            DBTool.View_SanPhamImageDataTable dt = new DBTool.View_SanPhamImageDataTable();
            adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            if (adt.Connection.State == ConnectionState.Closed) adt.Connection.Open();
            adt.FillByAll_Da_TaiImage(dt);
            DowloadImageV2(dt);
            dt.Dispose();
            adt.Dispose();

        }

        private void btDownloadImageChuaTai_Click(object sender, EventArgs e)
        {
            /// Download lại toàn bộ ảnh của những sản phẩm chưa được kiểm tra
            /// 
            DBToolTableAdapters.View_SanPhamImageTableAdapter adt = new DBToolTableAdapters.View_SanPhamImageTableAdapter();
            DBTool.View_SanPhamImageDataTable dt = new DBTool.View_SanPhamImageDataTable();
            adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            if (adt.Connection.State == ConnectionState.Closed) adt.Connection.Open();
            adt.FillBy_SanPhamChuaKiemTra(dt);
            DowloadImageV2(dt);
            dt.Dispose();
            adt.Dispose();

        }

        public void DownloadImage(DBTool.View_SanPhamImageDataTable dt, bool ReplateImage)
        {
            //String path = "C:\\Inetpub\\vhosts\\image.quangtrung.vn\\httpdocs\\", folder = "", name = "";

            //path = "C:\\Windows\\Images\\";
            //DBToolTableAdapters.ProductImagePathTableAdapter adtPro = new DBToolTableAdapters.ProductImagePathTableAdapter();
            //adtPro.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            //if (adtPro.Connection.State == ConnectionState.Closed) adtPro.Connection.Open();

            //int count = 0;

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
                
            //    String url = dt.Rows[i]["DetailUrl"].ToString();
            //    Uri root = new Uri(url);
            //    String namepath = root.DnsSafeHost.Replace("www.","").Replace('.', '_');
            //    string ss = namepath + "\\";
            //    string filename = Common.UnicodeToKoDauAndGach(dt.Rows[i]["Name"].ToString());
            //    if (filename.Length > 200)
            //    {
            //        filename = filename.Substring(0, 199);
            //    }
            //    String fullfile = path + ss + filename + ".jpg";
            //    // kiểm tra xem file đã có chưa nếu có rồi thì không download lại nữa
            //    if (!File.Exists(fullfile))
            //    {
            //        try
            //        {
            //            string fileSave = Common.SaveFile(dt.Rows[i]["ImageUrls"].ToString(), path + ss, filename + ".jpg");
            //            if (fileSave != "")
            //            {
            //                string pathsave = ss + filename.Replace('\\', '/') + ".jpg";
            //                pathsave = "Store/" + pathsave.Replace('\\', '/');
            //                adtPro.UpdateQuery(pathsave, Common.Obj2Int64(dt.Rows[i]["ID"].ToString()));
            //                count++;
            //            }
            //        }
            //        catch (Exception)
            //        {
            //        }
                    
            //    }
            //    this.laMess1.Text = String.Format("{0}/{1} download:{2} - {3}\n{4}", i, dt.Rows.Count, count, dt.Rows[i]["Name"].ToString(), dt.Rows[i]["DetailUrl"].ToString());
            //    Application.DoEvents();
            //}
            //adtPro.Dispose();
        }
        public void DowloadImageV2(DBTool.View_SanPhamImageDataTable dt)
        {
            //DBToolTableAdapters.ProductImagePathTableAdapter adtPro = new DBToolTableAdapters.ProductImagePathTableAdapter();
            //adtPro.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            //if (adtPro.Connection.State == ConnectionState.Closed) adtPro.Connection.Open();
            //String path = "D:\\Web\\img.websosanh.vn\\", folder = "", name = "";
            //int count = 0;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    List<string> rowMap = new List<string>();
            //    rowMap.AddRange(dt.Rows[i]["NameCategory"].ToString().Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries));
            //    String namepath = GABIZ.Base.Tools.removeHTML(rowMap[rowMap.Count - 1].ToString().Trim()).Replace("\t", "").Replace("  ", " ");
            //    if (namepath.Length > 6)
            //    {
            //        namepath = namepath.Substring(0, 5).Trim();
            //    }
            //    namepath = Common.UnicodeToKoDauAndGach(namepath.Replace("  ", " ").Replace("  ", " ").Trim());
            //    string ss = namepath + "\\";
            //    string filename = Common.UnicodeToKoDauAndGach(dt.Rows[i]["Name"].ToString());
            //    String fullfile = path + ss + filename + ".jpg";

            //    if (!File.Exists(path + ss + "no.jpg"))
            //    {
            //        Common.SaveFile("http://websosanh.vn/NoImages/no.jpg", path + ss, "no.jpg");
            //    }

            //    try
            //    {
            //        String url = dt.Rows[i]["ImageUrls"].ToString();
            //        ImageExt tImg = new ImageExt(url, "");
            //        byte[] bmp = tImg.GetData();
            //        var t = Websosanh.Imaging.ImageTools.ToBitmap(bmp);
            //        Image temp = Websosanh.Imaging.ImageTools.CropImage(t, 0.5, 1);
            //        Websosanh.Imaging.ImageTools.SaveJPEG(fullfile, (Bitmap)temp, 100);
            //        string fileSave = fullfile;
            //        if (fileSave != "")
            //        {
            //            string pathsave = ss + filename.Replace('\\', '/') + ".jpg";
            //            pathsave = pathsave.Replace('\\', '/');
            //            adtPro.UpdateQuery(pathsave, Common.Obj2Int64(dt.Rows[i]["ID"].ToString()));
            //            count++;
            //        }
            //    }
            //    catch (Exception)
            //    {
            //    }
            //    this.laMess1.Text = String.Format("{0}/{1} download:{2} - {3}", i, dt.Rows.Count, count, dt.Rows[i]["Name"].ToString());
            //    Application.DoEvents();
            //}
        }

      

        private void frmToolMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (downloadThread != null)
            {
                if (downloadThread.IsAlive)
                {
                    downloadThread.Abort();
                    downloadThread.Join();
                    downloadThread = null;
                }
            }
        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ctrLogMananger1.loadCompany(QT.Entities.Common.Obj2Int64(iDTextBox.Text));
        }

        private void btCheckAll_Click(object sender, EventArgs e)
        {
            foreach (DBTool.CompanyRow dr in this.dBTool.Company)
            {
                dr.CheckD = !dr.CheckD;

            }
            dBTool.Company.AcceptChanges();
        }

        private void cboManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.companyTableAdapter.FillBy_IDTypeMan(dBTool.Company, QT.Entities.Common.Obj2Int(cboManager.SelectedValue));
        }

        private void btUpdateSizeImage_Click(object sender, EventArgs e)
        {
            #region update search sản phẩm gốc
            DBTool2.ProductDataTable dtps = new DBTool2.ProductDataTable();
            DBTool2TableAdapters.ProductTableAdapter adtps = new DBTool2TableAdapters.ProductTableAdapter();
            adtps.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            adtps.FillByCategorySPGoc(dtps);
            for (int i = 0; i < dtps.Rows.Count; i++)
            {
                try
                {
                    adtps.UpdateQuery_NameFT(QT.Entities.Common.UnicodeToKoDauFulltext(dtps.Rows[i]["Name"].ToString() + " " + dtps.Rows[i]["Category"].ToString()) + " " + dtps.Rows[i]["Category"].ToString(), QT.Entities.Common.Obj2Int64(dtps.Rows[i]["ID"].ToString()));
                    this.laMess1.Text = String.Format("{0}/{1}", i, dtps.Rows.Count);
                }
                catch (Exception ex)
                {
                    this.laMess1.Text = String.Format("Error {0}/{1}{2}", i, dtps.Rows.Count, ex);
                }

                Application.DoEvents();
            }
            #endregion

            #region update size image
            //DBToolTableAdapters.ProductImagePathTableAdapter adt = new DBToolTableAdapters.ProductImagePathTableAdapter();
            //adt.Connection.ConnectionString = Server.ConnectionString;
            //DBTool.ProductImagePathDataTable dt = new DBTool.ProductImagePathDataTable();
            //adt.FillBy_ChuaUpdateWidth(dt);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{

            //    string path = "C:\\Windows\\Images\\" + dt.Rows[i]["ImagePath"].ToString().Replace("Store/","").Replace('/','\\');
            //    Bitmap thumbBitmap = null;
            //    try
            //    {
            //        thumbBitmap = new Bitmap(path);
            //        adt.UpdateQuery_WH(thumbBitmap.Width, thumbBitmap.Height, Common.Obj2Int64(dt.Rows[i]["ID"].ToString()));
            //        this.laMess1.Text = String.Format("{0}/{1}", i, dt.Rows.Count);
            //    }
            //    catch (Exception ex)
            //    {
            //        this.laMess1.Text = String.Format("Error {0}/{1}{2}", i, dt.Rows.Count,ex);
            //    }
                
            //    Application.DoEvents();
            //}
            #endregion
        }

        private void btUpdateCountSearch_Click(object sender, EventArgs e)
        {

        }

        private void btDeleteTrungten_Click(object sender, EventArgs e)
        {
            DBTool2.View_SanPhamBiTrungDataTable dt = new DBTool2.View_SanPhamBiTrungDataTable();
            DBTool2.ProductDataTable dtpro = new DBTool2.ProductDataTable();
            DBTool2TableAdapters.View_SanPhamBiTrungTableAdapter adtViewTrung = new DBTool2TableAdapters.View_SanPhamBiTrungTableAdapter();
            DBTool2TableAdapters.ProductTableAdapter adtPro = new DBTool2TableAdapters.ProductTableAdapter();
            adtPro.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            adtViewTrung.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            adtViewTrung.Fill(dt);
            int j = 0;
            foreach (DBTool2.View_SanPhamBiTrungRow dr in dt)
            {
                try
                {
                    adtPro.FillBy_Company_Name(dtpro, dr.Company, dr.Name);
                    if (dtpro.Rows.Count > 1)
                    {
                        for (int i = 1; i < dtpro.Rows.Count; i++)
                        {
                            adtPro.DeleteQuery(QT.Entities.Common.Obj2Int64(dtpro.Rows[i]["ID"].ToString()));
                        }
                    }
                    this.laMess1.Text = String.Format("Delete {0}/{1}", j, dt.Rows.Count);
                    j++;
                    Application.DoEvents();
                }
                catch (Exception)
                {
                }

            }
            adtViewTrung.Dispose();
            dt.Dispose();
            adtPro.Dispose();
        }

        private void btUpDateViewCompany_Click(object sender, EventArgs e)
        {
            DBTool2.View_Product_LogsDataTable dt = new DBTool2.View_Product_LogsDataTable();
            DBTool2TableAdapters.View_Product_LogsTableAdapter adtViewLog = new DBTool2TableAdapters.View_Product_LogsTableAdapter();
            DBTool2TableAdapters.CompanyTableAdapter adtCom = new DBTool2TableAdapters.CompanyTableAdapter();
            adtViewLog.Connection.ConnectionString = QT.Entities.Server.LogConnectionString;
            adtCom.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            DateTime datime = DateTime.Now.AddDays(-30);
            adtViewLog.FillTongViewByCompanyMonth(dt, datime);
            int j = 0;
            foreach (DBTool2.View_Product_LogsRow dr in dt)
            {
                try
                {
                    adtCom.UpdateQuery_TotalViewMonth(dr.Count, dr.IDCompany);

                    this.laMess1.Text = String.Format("Update {0}/{1} count={2}", j, dt.Rows.Count, dr.Count);
                    j++;
                    Application.DoEvents();
                }
                catch (Exception)
                {
                }

            }
            adtViewLog.Dispose();
            dt.Dispose();
            adtCom.Dispose();
        }
    }
}
