using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using QT.Moduls.Tool;
using QT.Entities;
using System.IO;
using log4net;

namespace QT.Moduls.Crawler
{
    public partial class frmDowloadImage : QT.Entities.frmBase
    {
        private long _idCompany = 0;
        private string _sDomain = "";
        private bool _bDownloadF = false;
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmDowloadImage));
        private bool isDatafeed = false;
        public bool FinishClose { set; get; }
        public frmDowloadImage(long idCompany, string domain)
        {
            InitializeComponent();
            _idCompany = idCompany;
            _sDomain = domain;
            Company.DBCom.CompanyDataTable dtcom = new Company.DBCom.CompanyDataTable();
            Company.DBComTableAdapters.CompanyTableAdapter adtCom = new Company.DBComTableAdapters.CompanyTableAdapter();
            adtCom.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            adtCom.FillBy_SelectOne(dtcom, _idCompany);
            if (dtcom.Rows.Count > 0)
            {
                int total = Common.Obj2Int(dtcom.Rows[0]["TotalProduct"].ToString());
                var datafeedtype = Common.Obj2Int(dtcom.Rows[0]["DataFeedType"].ToString());
                var datafeedurl = dtcom.Rows[0]["DataFeedUrl"].ToString();
                if (datafeedtype > 0 && !string.IsNullOrEmpty(datafeedurl))
                {
                    isDatafeed = true;
                }
                if (total > 2500) _bDownloadF = true;
            }
        }

        

        void doDowload()
        {
            QT.Moduls.Tool.DBToolTableAdapters.View_SanPhamImageTableAdapter adt = new QT.Moduls.Tool.DBToolTableAdapters.View_SanPhamImageTableAdapter();
            DBTool.View_SanPhamImageDataTable dt = new DBTool.View_SanPhamImageDataTable();
            adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            if (adt.Connection.State == ConnectionState.Closed) adt.Connection.Open();
            
            this.Invoke((MethodInvoker)delegate
            {
                this.laMess1.Text = String.Format("Start download du lieu tu sql");
            });

            if (Common.DowloadFullImage)
            {
                //fix riêng cho lazada : download toàn bộ ảnh cho sản phẩm valid = 1
                //if (_idCompany == 3502170206813664485)
                //{
                //    adt.FillBy_CompanyValid1(dt, _idCompany);
                //}
                //else 
                if (isDatafeed)
                {
                    adt.FillBy_CompanyValid1(dt, _idCompany);
                }
                else
                    adt.FillBy_AllByCompany(dt, _idCompany);
            }
            else
            {
                //15.10.2015 - Hải
                //fix riêng cho lazada chỉ load những ảnh sản phẩm valid = 1 và imagepath is null or ''
                //if (_idCompany == 3502170206813664485)
                //{
                //    adt.FillBy_CompanyValid1ImagePathNull(dt, _idCompany);
                //}
                //else 
                if (isDatafeed)
                {
                    adt.FillBy_CompanyValid1ImagePathNull(dt, _idCompany);
                }
                else
                    adt.FillBy_ChuaKiemTraTheoCongTy(dt, _idCompany);
            }
            
            this.Invoke((MethodInvoker)delegate
            {
                this.laMess1.Text = String.Format("download du lieu san pham tu sql finish");
            });
            String path = "D:\\Image\\";
            path = Common.FolderImage;
            //if (_bDownloadF)
            //{
            //    path = path.Replace("D:", "F:") + "big\\";
            //}

            QT.Moduls.Tool.DBToolTableAdapters.ProductImagePathTableAdapter adtPro = new QT.Moduls.Tool.DBToolTableAdapters.ProductImagePathTableAdapter();
            adtPro.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            if (adtPro.Connection.State == ConnectionState.Closed) adtPro.Connection.Open();

            int count = 0;
            Log.InfoFormat("path = ", path);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string url = string.Empty;
                try
                {
                    url = dt.Rows[i]["DetailUrl"].ToString();
                    Uri root = new Uri(url);
                    string domain = root.DnsSafeHost.Replace("www.", "");
                    string char1 = domain.Substring(0, 1);
                    String namepath = domain.Substring(0, 1) + "\\" + root.DnsSafeHost.Replace("www.", "").Replace('.', '_');
                    string ss = namepath + "\\";
                    string filename = Common.UnicodeToKoDauAndGach(dt.Rows[i]["Name"].ToString());
                    string tempf = filename.Replace("-", "");
                    string sf = tempf.Substring(0, 3);
                    if (sf == "bin") sf = "bin1";
                    if (sf == "con") sf = "con1";
                    ss += sf + "\\";
                    if (filename.Length > 100)
                    {
                        filename = filename.Substring(0, 99);

                    }
                    String fullfile = path + ss + filename + ".jpg";

                    if (chkRedownload.Checked == true)
                    {
                        Bitmap thumbBitmap = null;
                        try
                        {
                            thumbBitmap = new Bitmap(fullfile);
                            string pathsave = ss + filename + ".jpg";

                            pathsave = "Store/" + pathsave.Replace('\\', '/');
                        }
                        catch (Exception ex)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                this.laMess1.Text = String.Format("Error {0}/{1}{2}", i, dt.Rows.Count, ex);
                                //Thread.Sleep(5000);
                            });
                        }
                    }
                    else
                    {
                        if (!File.Exists(fullfile))
                        {
                            Log.InfoFormat("/// chưa có file --> tải lại dữ liệu");
                            /// chưa có file --> tải lại dữ liệu
                            int w = 0, h = 0;
                            string fileSave = Common.SaveFile(dt.Rows[i]["ImageUrls"].ToString(), path + ss, filename + ".jpg", out w, out h, false);
                            if (fileSave != "")
                            {
                                string pathsave = ss + filename.Replace('\\', '/') + ".jpg";
                                pathsave = "Store/" + pathsave.Replace('\\', '/');
                                adtPro.UpdateQuery(pathsave, w, h, Common.Obj2Int64(dt.Rows[i]["ID"].ToString()));
                                count++;
                            }
                        }
                        else
                        {
                            /// Nếu chưa update ảnh vào hệ thống  thì update
                           
                            Bitmap thumbBitmap = null;
                            try
                            {
                                thumbBitmap = new Bitmap(fullfile);
                                string pathsave = ss + filename + ".jpg";
                                pathsave = "Store/" + pathsave.Replace('\\', '/');

                                adtPro.UpdateQuery(pathsave, thumbBitmap.Width, thumbBitmap.Height, Common.Obj2Int64(dt.Rows[i]["ID"].ToString()));
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
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.laMess1.Text = String.Format("{0}/{1} download:{2} - {3}\n{4}", i, dt.Rows.Count, count, dt.Rows[i]["Name"].ToString(), dt.Rows[i]["DetailUrl"].ToString());
                    });
                }
                catch (Exception ex)
                {
                    Log.ErrorFormat("Links : {0} ERROR : {1}.  ",url, ex);
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.laMess1.Text = ex.ToString();
                        //Thread.Sleep(1000);
                    });
                }
               
            }
            adtPro.Dispose();
            dt.Clear();
            dt.Dispose();
            adt.Dispose();
            this.Invoke((MethodInvoker)delegate
            {
                this.laMess1.Text = "Finish";
                this.WindowState = FormWindowState.Minimized;
                if (FinishClose) this.Close();
            });
        }

        private Thread downloadThread;
        public void Dowload()
        {
            downloadThread = new Thread(new ThreadStart(doDowload));
            downloadThread.Start();
        }

        private void frmDowloadImage_Load(object sender, EventArgs e)
        {

        }

        private void frmDowloadImage_FormClosing(object sender, FormClosingEventArgs e)
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

        private void chkRedownload_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
