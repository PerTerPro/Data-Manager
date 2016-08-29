using log4net;
using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.ReDownloadImage
{
    public partial class frmReDownloadImage : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmReDownloadImage));
        private bool istop = false;
        private bool istopgetdata = false;
        private bool istoplog = false;
        private bool istopcompany = false;
        public frmReDownloadImage()
        {
            InitializeComponent();
            
        }
        private long GetIDCompanyDownloadImage()
        {
            Random rd = new Random();
            long iDCompany = 0;
            while (!istopcompany)
            {
                try
                {
                    Thread.Sleep(rd.Next(1000, 20000));
                    SqlConnection conn = new SqlConnection(ServerConnection.ConnectionString);
                    SqlCommand cmd = new SqlCommand("prc_CompanyResetImageTemp_GetTop1", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        iDCompany = Common.Obj2Int64(dt.Rows[0]["ID"].ToString());
                        this.Invoke(new Action(() =>
                        {
                            this.Text ="Domain: " + dt.Rows[0]["Domain"].ToString();
                            textEdit1.Text = iDCompany.ToString();
                        }));
                        break;
                    }
                    else
                        break;
                }
                catch (Exception)
                {
                    Thread.Sleep(10000);
                }
            }
            return iDCompany;
        }
        private void RunDownloadImage()
        {
            while (!istop)
            {
                ReDownloadImageCompany(GetIDCompanyDownloadImage());
                Thread.Sleep(1000);
            }
        }
        public void RunDownload()
        {
            Thread tr = new Thread(new ThreadStart(RunDownloadImage));
            tr.Start();
        }
        private void ReDownloadImageCompany(long companyId)
        {
            if (companyId == 0)
            {
                this.Invoke(new Action(() =>
                {
                    richTextBox1.AppendText("Complete!");
                    this.Text = "Complete!";
                }));
                return;
            }
            this.Invoke(new Action(() =>
            {
                richTextBox1.AppendText("CompanyID: " + companyId + ": Start get Product in SQL!\r\n");
            }));
            WSS.ReDownloadImage.DBTableAdapters.ProductTableAdapter productAdapter = new WSS.ReDownloadImage.DBTableAdapters.ProductTableAdapter();
            productAdapter.Connection.ConnectionString = ServerConnection.ConnectionString;
            WSS.ReDownloadImage.DB.ProductDataTable productTable = new WSS.ReDownloadImage.DB.ProductDataTable();

            DBTableAdapters.DownloadImageTempTableAdapter logAdapter = new DBTableAdapters.DownloadImageTempTableAdapter();
            logAdapter.Connection.ConnectionString = ServerConnection.ConnectionString;

            int demgetproduct = 0;
            while (!istopgetdata)
            {
                try
                {
                    productAdapter.FillBy_Company(productTable, companyId);
                    break;
                }
                catch (Exception ex)
                {
                    demgetproduct++;
                    if (demgetproduct == 1)
                        Log.Error(string.Format("CompanyID = {0} Get Product of Company in SQL Error 1", companyId), ex);
                    else if (demgetproduct == 5)
                    {
                        Log.Error(string.Format("CompanyID = {0} Get Product of Company in SQL Error {1}", companyId, 5), ex);
                        break;
                    }
                    Thread.Sleep(60000);
                }
            }
            try
            {
                if (productTable.Rows.Count > 0)
                {
                    String path = ServerConnection.FolderImage;
                    int countsuccess = 0;
                    for (int i = 0; i < productTable.Rows.Count; i++)
                    {
                        long productId = Common.Obj2Int64(productTable.Rows[i]["ID"].ToString());
                        string url = productTable.Rows[i]["DetailUrl"].ToString();
                        if (string.IsNullOrEmpty(url))
                            continue;
                        Uri root = new Uri(url);
                        string domain = root.DnsSafeHost.Replace("www.", "");
                        string char1 = domain.Substring(0, 1);
                        String namepath = domain.Substring(0, 1) + "\\" + root.DnsSafeHost.Replace("www.", "").Replace('.', '_');
                        string ss = namepath + "\\";
                        string filename = Common.UnicodeToKoDauAndGach(productTable.Rows[i]["Name"].ToString());
                        string tempf = filename.Replace("-", "");
                        if (tempf.Length < 3)
                            continue;
                        string folder = tempf.Substring(0, 3);
                        if (folder == "bin") folder = "bin1";
                        if (folder == "con") folder = "con1";
                        ss += folder + "\\";
                        if (filename.Length > 100)
                        {
                            filename = filename.Substring(0, 99);
                        }
                        filename += "_" + productId;
                        String fullfile = path + ss + filename + ".jpg";
                        string imageurl = string.Empty;
                        imageurl = productTable.Rows[i]["ImageUrls"].ToString();
                        if (string.IsNullOrEmpty(imageurl))
                        {
                            Log.Error(string.Format("CompanyID = {0} ProductID = {1} ImageUrl is null or empty.", companyId, productId));
                            continue;
                        }
                        bool fileSaved = Common.SaveFileDownloadImage(imageurl, path + ss, filename + ".jpg", productId, companyId);
                        if (fileSaved)
                        {
                            #region Log download
                            int dem = 0;
                            while (!istoplog)
                            {
                                try
                                {
                                    logAdapter.Insert(productId, companyId, true, DateTime.Now,"");
                                    break;
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(string.Format("Write log product {0} / company {1} error", productId, companyId), ex);
                                    if (dem == 5)
                                        break;
                                    else
                                        dem++;
                                    Thread.Sleep(10000);
                                }
                            }
                            #endregion
                            countsuccess++;
                            this.Invoke(new Action(() =>
                            {
                                richTextBox1.AppendText(string.Format("{0}.Download Image Product {1} success!\r\n", i + 1,productId));
                            }));
                        }
                        else
                        {
                            #region Log download
                            int dem = 0;
                            while (!istoplog)
                            {
                                try
                                {
                                    logAdapter.Insert(productId, companyId, false, DateTime.Now,"");
                                    break;
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(string.Format("Write log product {0} / company {1} error", productId, companyId), ex);
                                    if (dem == 5)
                                        break;
                                    else
                                        dem++;
                                    Thread.Sleep(10000);
                                }
                            }
                            #endregion
                            this.Invoke(new Action(() =>
                            {
                                richTextBox1.AppendText(string.Format("{0}.Download Image Product {1} fails!\r\n", i + 1,productId));
                            }));
                        }

                    }
                    Log.InfoFormat("CompanyID = {0} Download Image Success {1}/{2}", companyId, countsuccess, productTable.Rows.Count);
                    WriteLogCompanyImage(companyId, countsuccess, productTable.Rows.Count);
                    this.Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText(string.Format("CompanyID = {0}. Download Image Product success {1}/{2}", companyId, countsuccess, productTable.Rows.Count));
                    }));
                }
                else
                {
                    Log.InfoFormat("CompanyID = {0} 0 product", companyId);
                    WriteLogCompanyImage(companyId, 0, 0);
                    this.Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText(string.Format("CompanyID = {0} 0 product", companyId));
                    }));
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("CompanyID = {0} ERROR~~~", companyId), ex);
                this.Invoke(new Action(() =>
                {
                    richTextBox1.AppendText(string.Format("CompanyID = {0} ERROR:\n{1}", companyId,ex));
                }));
            }
        }

        private void WriteLogCompanyImage(long companyID, int countSuccess, int countProduct)
        {
            DBTableAdapters.DownloadImageCompanyTempTableAdapter logCompanyAdapter = new DBTableAdapters.DownloadImageCompanyTempTableAdapter();
            logCompanyAdapter.Connection.ConnectionString = ServerConnection.ConnectionString;
            int dem = 0;
            while (!istoplog)
            {
                try
                {
                    logCompanyAdapter.Insert(companyID, countSuccess,countProduct, DateTime.Now);
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("Write log company {0} error", companyID), ex);
                    if (dem == 5)
                        break;
                    else
                        dem++;
                    Thread.Sleep(10000);
                }
            }
        }

        private void frmReDownloadImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            istop = true;
            istoplog = true;
            istopgetdata = true;
            istopcompany = true;
        }
    }
}
