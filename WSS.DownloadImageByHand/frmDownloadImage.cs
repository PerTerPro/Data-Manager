using log4net;
using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.DownloadImageByHand
{
    public partial class frmDownloadImage : Form
    {
        private string connectionString = "";
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmDownloadImage));
        RabbitMQServer rabbitMQServer;
        string pathImage = "D:\\Image\\";
        string pathImageSPGOC = "D:\\Image\\images\\";
        int updateProductJobExpirationMS = 3500000;
        string rabbitMQServerName = "";
        private bool checkstop = true;
        private int numbererror = 0;
        //Jobclient update solr and redis
        //private JobClient updateProductJobClient;
        //JobClient download image fails
        //private JobClient downloadImageProductJobClient;
        //JobClient delete thumb
        //private JobClient deleteThumbJobClient;

        private string updateProductExchangeGroupName = "";
        private string updateProductImageGroupName = "";
        private string updateProductqueueJobName = "";
        private string deleteThumbImageProductJobName = "";
        public frmDownloadImage()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            pathImage = System.Configuration.ConfigurationSettings.AppSettings["FolderImage"];
            connectionString = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
            rabbitMQServerName = System.Configuration.ConfigurationSettings.AppSettings["rabbitMQServerName"];
            //jobclient send message download image product fails
            updateProductImageGroupName = System.Configuration.ConfigurationSettings.AppSettings["updateProductImageGroupName"];
            //string updateProductImageProductJobName = System.Configuration.ConfigurationSettings.AppSettings["updateProductImageProductJobName"];
            //jobclient send message update solr sau khi downloadimage
            updateProductExchangeGroupName = System.Configuration.ConfigurationSettings.AppSettings["updateProductGroupName_UpSolrRedis"];
            updateProductqueueJobName = System.Configuration.ConfigurationSettings.AppSettings["updateProductJobName_UpSolrRedis"];
            //jobclient send message delete thumb image
            deleteThumbImageProductJobName = System.Configuration.ConfigurationSettings.AppSettings["deleteThumbImageProductJobName"];
            updateProductJobExpirationMS = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["updateJobExpirationMS"]);
            //Số lần tối đa download lỗi ảnh này (check để gửi lại tin nhắn lên rabbit)
            //numbererror = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["numberError"]);

            //rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
            ////Jobclient update solr and redis
            //updateProductJobClient = new JobClient(updateProductExchangeGroupName, GroupType.Topic, updateProductqueueJobName, true, rabbitMQServer);
            ////JobClient download image fails
            ////JobClient downloadImageProductJobClient = new JobClient(updateProductImageGroupName, GroupType.Topic, updateProductImageProductJobName, true, rabbitMQServer);
            ////JobClient delete thumb
            //deleteThumbJobClient = new JobClient(updateProductImageGroupName, GroupType.Topic, deleteThumbImageProductJobName, true, rabbitMQServer);
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            long companyId = Convert.ToInt64(txtCompanyId.Text);
            bool reloadall = false;
            if (checkReloadAll.Checked)
            {
                reloadall = true;
            }
            if (companyId == 6619858476258121218)
            {
                Thread tr = new Thread(() => DownloadImageSPGoc(companyId, reloadall));
                tr.Start();
            }
            else
            {
                Thread tr = new Thread(() => DownLoad(1, companyId, reloadall));
                tr.Start();
            }
        }
        private void DownLoad(int index, long companyId, bool reloadall)
        {
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
            //Jobclient update solr and redis
            var updateProductJobClient = new JobClient(updateProductExchangeGroupName, GroupType.Direct, updateProductqueueJobName, true, rabbitMQServer);
            //JobClient download image fails
            //JobClient downloadImageProductJobClient = new JobClient(updateProductImageGroupName, GroupType.Topic, updateProductImageProductJobName, true, rabbitMQServer);
            //JobClient delete thumb
            var deleteThumbJobClient = new JobClient(updateProductImageGroupName, GroupType.Topic, deleteThumbImageProductJobName, true, rabbitMQServer);
            WSS.DownloadImageByHand.DBTableAdapters.ProductTableAdapter productAdapter = new WSS.DownloadImageByHand.DBTableAdapters.ProductTableAdapter();
            productAdapter.Connection.ConnectionString = connectionString;
            WSS.DownloadImageByHand.DB.ProductDataTable productTable = new WSS.DownloadImageByHand.DB.ProductDataTable();
            int demgetproduct = 0;
            this.Invoke(new Action(() =>
            {
                rbIndex.AppendText("Get list Product from SQL..." + companyId+System.Environment.NewLine);
            }));
            while (true)
            {
                try
                {
                    if (reloadall)
                        productAdapter.FillBy_AllValid(productTable, companyId);
                    else
                        //Lấy danh sách sản phẩm valid = 1
                        productAdapter.FillBy_CompanyIDValid1AndImagePathNull(productTable, companyId);
                    break;
                }
                catch (Exception ex)
                {
                    demgetproduct++;
                    if (demgetproduct == 1)
                    {
                        Log.Error(string.Format("CompanyID = {0} Get Product of Company in SQL Error 1", companyId), ex);
                        this.Invoke(new Action(() =>
                        {
                            rbIndex.AppendText("1.CompanyID = " + companyId + ". Get Product of Company in SQL Error" + ex.ToString() + System.Environment.NewLine);
                        }));
                    }
                    else if (demgetproduct == numbererror)
                    {
                        Log.Error(string.Format("CompanyID = {0} Get Product of Company in SQL Error {1}", companyId, numbererror), ex);
                        this.Invoke(new Action(() =>
                        {
                            rbIndex.AppendText(numbererror + ".CompanyID = " + companyId + ". Get Product of Company in SQL Error." + ex.ToString() + System.Environment.NewLine);
                        }));
                        break;
                    }
                    Thread.Sleep(60000);
                } 
            }
            
            try
            {
                if (productTable.Rows.Count > 0)
                {
                    int total = productTable.Rows.Count;
                    this.Invoke(new Action(() =>
                    {
                        rbIndex.AppendText(companyId + ".Get " + total + " Product from SQL..." + System.Environment.NewLine);
                    }));
                    String path = pathImage;
                    int countsuccess = 0;
                    int countfail = 0;
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
                        string direct = namepath + "\\";
                        string filename = Common.UnicodeToKoDauAndGach(productTable.Rows[i]["Name"].ToString());
                        string tempf = filename.Replace("-", "");
                        if (tempf.Length < 3)
                            continue;
                        string folder = tempf.Substring(0, 3);
                        if (folder == "bin") folder = "bin1";
                        if (folder == "con") folder = "con1";
                        if (folder == "aux") folder = "aux1";
                        if (folder == "prn") folder = "prn1";
                        if (folder == "nul") folder = "nul1";
                        direct += folder + "\\";
                        if (filename.Length > 100)
                        {
                            filename = filename.Substring(0, 99);
                        }
                        filename += "_" + productId;
                        String fullfile = path + direct + filename + ".jpg";
                        int w = 0, h = 0;
                        string imageurl = string.Empty;
                        imageurl = productTable.Rows[i]["ImageUrls"].ToString();
                        if (string.IsNullOrEmpty(imageurl))
                        {
                            Log.Error(string.Format("CompanyID = {0} ProductID = {1} ImageUrl is null or empty.", companyId, productId));
                            this.Invoke(new Action(() =>
                            {
                                rbListFails.AppendText(i+"."+productId+": ImageUrl Null or Empty."+ System.Environment.NewLine);
                            }));
                            continue;
                        }
                        bool fileSaved = Common.SaveFileDownloadImage(imageurl, path + direct, filename + ".jpg", productId, companyId);
                        if (fileSaved)
                        {
                            this.Invoke(new Action(() =>
                            {
                                rbIndex.AppendText(string.Format("{0}...{1}: {2}/{3} . {4} sucess.",index,companyId,i,total,productId) + System.Environment.NewLine);
                            }));
                            string pathsave = direct + filename.Replace('\\', '/') + ".jpg";
                            pathsave = "Store/" + pathsave.Replace('\\', '/');
                            try
                            {
                                productAdapter.UpdateQuery(pathsave, w, h, productId);
                                Log.InfoFormat("CompanyID = {0} ProductID = {1} Download Image success.", companyId, productId);
                                countsuccess++;
                                this.Invoke(new Action(() =>
                                {
                                    lbSuccess.Text = countsuccess.ToString();
                                }));
                            }
                            catch (Exception ex)
                            {
                                //Thread.Sleep(10000);
                                //dem++;
                                //if (dem == 1)
                                Log.Error(string.Format("CompanyID = {0} Product = {1}, Update ImagePath Error", companyId, productId), ex);
                                this.Invoke(new Action(() =>
                                {
                                    rbListFails.AppendText(i + "." + productId + ": Update SQL fails."+ex.ToString() + System.Environment.NewLine);
                                }));
                                //else if (dem == numbererror)
                                //{
                                //    Log.Error(string.Format("CompanyID = {0} Product = {1}, Update ImagePath Error {2}", companyId, productId, numbererror), ex);
                                //    break;
                                //}
                            }
                            try
                            {
                                #region Send Message Update solr and redis
                                Job job = new Job();
                                job.Data = BitConverter.GetBytes(productId);
                                job.Type = 2;
                                updateProductJobClient.PublishJob(job, updateProductJobExpirationMS);
                                //Log.InfoFormat("Send message To RabbitMq {0} with ID = {1}", rabbitMQServerName, productId);
                                #endregion

                                #region Xóa ảnh Thumb nếu có
                                //push message lên service xóa ảnh thumb
                                Job deletejob = new Job();
                                MqThumbImageInfo thumb = new MqThumbImageInfo();
                                thumb.ProductId = productId;
                                thumb.FolderImage = direct;
                                thumb.ImageName = filename;
                                thumb.TypeProduct = 1;
                                deletejob.Data = MqThumbImageInfo.GetMess(thumb);
                                deleteThumbJobClient.PublishJob(deletejob);
                                #endregion
                            }
                            catch (Exception ex)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    rbListFails.AppendText(i + "." + productId + ": Update Solr + Push service Delete Thumb fails." + ex.ToString() + System.Environment.NewLine);
                                }));
                            }
                        }
                        else
                        {
                            countfail++;
                            //Show thông tin không download được ảnh ra
                            this.Invoke(new Action(() =>
                            {
                                lbFails.Text = countfail.ToString();
                                rbIndex.AppendText(string.Format("{0}...{1}: {2}/{3} . {4} fails.",index, companyId, i,total, productId) + System.Environment.NewLine);
                                rbListLinksFails.AppendText(i + "." + productId + ": Download fails." + imageurl + "DetailUrl: " + url + System.Environment.NewLine);
                            }));

                            //Check số lần download error trên Redis
                            //int errordowbload = RedisErrorDownloadImageProductAdapter.GetErrorDownloadImage(productId);
                            ////Nếu số lần < numbererror thì push lại message lên để lúc khác download
                            //if (errordowbload <= numbererror)
                            //{
                            //    errordowbload++;
                            //    RedisErrorDownloadImageProductAdapter.SetErrorDownloadImage(productId, errordowbload);
                            //    Job job = new Job();
                            //    MQChangeImage mq = new MQChangeImage();
                            //    mq.ProductID = productId;
                            //    mq.Type = 1;
                            //    job.Data = MQChangeImage.GetMess(mq);
                            //    try
                            //    {
                            //        jobclientDownloadImageProduct.PublishJob(job);
                            //    }
                            //    catch (Exception ex)
                            //    {
                            //        Log.Error(string.Format("CompanyID = {0} ProductID = {1} Send message Redownload image.", companyId, productId), ex);
                            //    }
                            //}
                        }

                    }
                    Log.InfoFormat("CompanyID = {0} Download Image Success {1}/{2}", companyId, countsuccess, productTable.Rows.Count);
                    this.Invoke(new Action(() =>
                    {
                        rbIndex.AppendText(companyId + " FINISHED...Success: " +countsuccess + "- Fails: "+ countfail + System.Environment.NewLine);
                    }));
                }
                else
                {
                    Log.InfoFormat("CompanyID = {0} 0 product (valid = 1 and ImagePath is Null or empty)", companyId);
                    this.Invoke(new Action(() =>
                    {
                        rbIndex.AppendText(companyId + "Get 0 Product from SQL..." +System.Environment.NewLine);
                    }));
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("CompanyID = {0} ERROR~~~", companyId), ex);
                this.Invoke(new Action(() =>
                {
                    rbListFails.AppendText(companyId + " FAILS..."+ex.ToString() + System.Environment.NewLine);
                }));
            }
        
        }

        private void btnTestLinks_Click(object sender, EventArgs e)
        {
            string directory = "D:\\Image\\"; string url = txtLinks.Text;
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            try
            {
                var a = Regex.Match(url, "http").Captures;
                url = url.Substring(url.LastIndexOf("http"));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Bitmap thumbBitmap = null;
                thumbBitmap = new Bitmap(response.GetResponseStream());
                thumbBitmap.Save(directory + @"\" + "Test.jpg");
                lbKq.Text = "success";
            }
            catch (Exception ex)
            {
                lbKq.Text = ex.Message;
            }
        }

        private void btnDownloadMultiThread_Click(object sender, EventArgs e)
        {
            
            bool reloadall = false;
            if (checkReloadAll.Checked)
            {
                reloadall = true;
            }
            var listid = txtCompanyId.Text.Split(new char[] { ',' });
            for (int i = 0; i < listid.Length; i++)
            {
                long companyId = Convert.ToInt64(listid[i]);
                int index = i + 1;
                Thread tr = new Thread(() => DownLoad(index, companyId, reloadall));
                tr.Start();
            }
        }


        private void DownloadImageSPGoc(long companyId, bool reloadall = false)
        {
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
            //Jobclient update solr and redis
            var updateProductJobClient = new JobClient(updateProductExchangeGroupName, GroupType.Direct, updateProductqueueJobName, true, rabbitMQServer);
            //JobClient download image fails
            //JobClient downloadImageProductJobClient = new JobClient(updateProductImageGroupName, GroupType.Topic, updateProductImageProductJobName, true, rabbitMQServer);
            //JobClient delete thumb
            var deleteThumbJobClient = new JobClient(updateProductImageGroupName, GroupType.Topic, deleteThumbImageProductJobName, true, rabbitMQServer);

            WSS.DownloadImageByHand.DBTableAdapters.ProductTableAdapter productAdapter = new WSS.DownloadImageByHand.DBTableAdapters.ProductTableAdapter();
            productAdapter.Connection.ConnectionString = connectionString;
            WSS.DownloadImageByHand.DB.ProductDataTable productTable = new WSS.DownloadImageByHand.DB.ProductDataTable();
            int demgetproduct = 0;

            while (true)
            {
                try
                {
                    if (reloadall)
                        productAdapter.FillBy_AllSPGoc(productTable, companyId);
                    else
                        //Lấy danh sách sản phẩm valid = 1
                        productAdapter.FillBy_SPGocAndValid(productTable, companyId);
                    break;
                }
                catch (Exception ex)
                {
                    demgetproduct++;
                    if (demgetproduct == 1)
                        Log.Error(string.Format("CompanyID = {0} Get Product of Company in SQL Error 1", companyId), ex);
                    else if (demgetproduct == numbererror)
                    {
                        Log.Error(string.Format("CompanyID = {0} Get Product of Company in SQL Error {1}", companyId, numbererror), ex);
                        break;
                    }
                    Thread.Sleep(60000);
                }
            }
            try
            {
                if (productTable.Rows.Count > 0)
                {
                    this.Invoke(new Action(() =>
                    {
                        rbIndex.AppendText(companyId + ".Get " + productTable.Rows.Count + " Product from SQL..." + System.Environment.NewLine);
                    }));
                    string path = pathImageSPGOC;
                    int countsuccess = 0;
                    int countproduct = productTable.Rows.Count;
                    for (int i = 0; i < productTable.Rows.Count; i++)
                    {
                        long productId = Common.Obj2Int64(productTable.Rows[i]["ID"].ToString());
                        string nameProduct = productTable.Rows[i]["Name"].ToString();
                        string imageUrl = productTable.Rows[i]["ImageUrls"].ToString();
                        if (string.IsNullOrEmpty(nameProduct) || string.IsNullOrEmpty(imageUrl))
                        {
                            Log.Error(string.Format("CompanyID = {0} ProductID = {1} Name or ImageUrl is null or empty.", companyId, productId));
                            continue;
                        }
                        string filename = Common.UnicodeToKoDauAndGach(nameProduct);
                        string tempf = filename.Replace("-", "");
                        if (tempf.Length < 3)
                            continue;
                        string folder = tempf.Substring(0, 3);
                        if (folder == "bin") folder = "bin1";
                        if (folder == "con") folder = "con1";
                        if (folder == "aux") folder = "aux1";
                        if (folder == "prn") folder = "prn1";
                        if (folder == "nul") folder = "nul1";
                        if (filename.Length > 100)
                            filename = filename.Substring(0, 99);
                        bool fileSaved = true;
                        try
                        {
                            fileSaved = Common.SaveFileDownloadImage(imageUrl, path + folder, filename + ".jpg", productId, companyId);
                        }
                        catch (Exception)
                        { 
                        }
                        if (fileSaved)
                        {
                            int w = 0, h = 0;
                            string pathsave = "Store/images/" + folder + "/" + filename + ".jpg";
                            while (checkstop)
                            {
                                try
                                {
                                    productAdapter.UpdateQuery(pathsave, w, h, productId);
                                    Log.InfoFormat("{0}/{1}. CompanyID = {2} ProductID = {3} Download Image success.", i, countproduct, companyId, productId);
                                    countsuccess++;
                                    #region Send Message Update solr and redis
                                    Job job = new Job();
                                    job.Data = BitConverter.GetBytes(productId);
                                    job.Type = 2;
                                    updateProductJobClient.PublishJob(job, updateProductJobExpirationMS);
                                    //Log.InfoFormat("Send message To RabbitMq {0} with ID = {1}", rabbitMQServerName, productId);
                                    #endregion

                                    #region Xóa ảnh Thumb nếu có
                                    //push message lên service xóa ảnh thumb
                                    Job deletejob = new Job();
                                    MqThumbImageInfo thumb = new MqThumbImageInfo();
                                    thumb.ProductId = productId;
                                    thumb.FolderImage = folder;
                                    thumb.ImageName = filename;
                                    thumb.TypeProduct = 2;
                                    deletejob.Data = MqThumbImageInfo.GetMess(thumb);
                                    deleteThumbJobClient.PublishJob(deletejob);
                                    #endregion
                                    this.Invoke(new Action(() =>
                                    {
                                        rbIndex.AppendText(string.Format("{0}...{1}: {2}.{3} sucess.", 1, companyId, i, productId) + System.Environment.NewLine);
                                    }));
                                    break;
                                }
                                catch (Exception ex)
                                {
                                    this.Invoke(new Action(() =>
                                    {
                                        rbListFails.AppendText(i + "." + productId + ": Update Solr + Push service Delete Thumb fails." + ex.ToString() + System.Environment.NewLine);
                                    }));
                                    break;
                                    //Thread.Sleep(10000);
                                    //dem++;
                                    //if (dem == 1)
                                    //    Log.Error(string.Format("CompanyID = {0} Product = {1}, Update ImagePath Error 1", companyId, productId), ex);
                                    //else if (dem == numbererror)
                                    //{
                                    //    Log.Error(string.Format("CompanyID = {0} Product = {1}, Update ImagePath Error {2}", companyId, productId, numbererror), ex);
                                    //    break;
                                    //}
                                }
                            }
                        }
                        else
                        {
                            this.Invoke(new Action(() =>
                            {
                                //lbFails.Text = countfail.ToString();
                                rbIndex.AppendText(string.Format("{0}...{1}: {2}.{3} fails.", 1, companyId, i, productId) + System.Environment.NewLine);
                                rbListLinksFails.AppendText(i + "." + productId + ": Download fails." + imageUrl + " ...Name: " + nameProduct + System.Environment.NewLine);
                            }));
                        }
                    }
                    Log.InfoFormat("CompanyID = {0} Download Image Success {1}/{2}", companyId, countsuccess, productTable.Rows.Count);
                }
                else
                {
                    Log.InfoFormat("CompanyID = {0} 0 product (valid = 1 and ImagePath is Null or empty)", companyId);

                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("CompanyID = {0} ERROR~~~", companyId), ex);
            }
        }

        private void btnUpdateImagePath_Click(object sender, EventArgs e)
        {
            frmUpdateImagePath frm = new frmUpdateImagePath();
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmLogo frm = new frmLogo();
            frm.Show();
        }

        private void btnDownloadSingleProduct_Click(object sender, EventArgs e)
        {
            
        }
        //private void RunDownloadProduct(long[] listidproduct)
        //{
        //    if (listidproduct.Length == 0)
        //    {
        //        this.Invoke(new Action(() =>
        //        {
        //            rbIndex.AppendText("~~~ 0 product!");
        //        }));
        //    }
        //    else
        //    {
        //        DBTableAdapters.ProductTableAdapter productAdapter = new DBTableAdapters.ProductTableAdapter();
        //        productAdapter.Connection.ConnectionString = connectionString;
        //        DB.ProductDataTable productTable = new DB.ProductDataTable();
        //        int count = listidproduct.Length;
        //        int countsuccess = 0;
        //        for (int i = 0; i < count; i++)
        //        {
        //            long idproduct = listidproduct[i];
        //            productTable.Clear();
        //            try
        //            {
        //                productAdapter.FillBy_ID(productTable,idproduct);
        //            }
        //            catch (Exception ex)
        //            {
        //                this.Invoke(new Action(() =>
        //                {
        //                    rbListLinksFails.AppendText(string.Format("{0}/{1}. {2} get in SQL fails!\n{3}", i, count, idproduct, ex.ToString()) + System.Environment.NewLine);
        //                }));
        //            }
        //            if (productTable.Rows.Count == 0)
        //            {
        //                this.Invoke(new Action(() =>
        //                {
        //                    rbListLinksFails.AppendText(string.Format("{0}/{1}. {2} not in database.", i, count, idproduct) + System.Environment.NewLine);
        //                }));
        //            }
        //            else
        //            {
        //                long idcompany = Common.Obj2Int64(productTable.Rows[0]["Company"].ToString());
        //                if (idcompany == 6619858476258121218)
        //                {
        //                    #region DownloadImageSPGoc
        //                    string path = pathImageSPGOC;
        //                    string nameProduct = productTable.Rows[i]["Name"].ToString();
        //                    string imageUrl = productTable.Rows[i]["ImageUrls"].ToString();
        //                    if (string.IsNullOrEmpty(nameProduct) || string.IsNullOrEmpty(imageUrl))
        //                    {
        //                        Log.Error(string.Format("CompanyID = {0} ProductID = {1} Name or ImageUrl is null or empty.", idcompany, idproduct));
        //                        continue;
        //                    }
        //                    string filename = Common.UnicodeToKoDauAndGach(nameProduct);
        //                    string tempf = filename.Replace("-", "");
        //                    if (tempf.Length < 3)
        //                        continue;
        //                    string folder = tempf.Substring(0, 3);
        //                    if (folder == "bin") folder = "bin1";
        //                    if (folder == "con") folder = "con1";
        //                    if (folder == "aux") folder = "aux1";
        //                    if (folder == "prn") folder = "prn1";
        //                    if (folder == "nul") folder = "nul1";
        //                    if (filename.Length > 100)
        //                        filename = filename.Substring(0, 99);
        //                    bool fileSaved = true;
        //                    try
        //                    {
        //                        fileSaved = Common.SaveFileDownloadImage(imageUrl, path + folder, filename + ".jpg", idproduct, idcompany);
        //                    }
        //                    catch (Exception)
        //                    {
        //                    }
        //                    if (fileSaved)
        //                    {
        //                        int w = 0, h = 0;
        //                        string pathsave = "Store/images/" + folder + "/" + filename + ".jpg";
        //                        while (checkstop)
        //                        {
        //                            try
        //                            {
        //                                productAdapter.UpdateQuery(pathsave, w, h, idproduct);
        //                                Log.InfoFormat("{0}/{1}. CompanyID = {2} ProductID = {3} Download Image success.", i, count, idcompany, idproduct);
        //                                countsuccess++;
        //                                #region Send Message Update solr and redis
        //                                Job job = new Job();
        //                                job.Data = BitConverter.GetBytes(idproduct);
        //                                job.Type = 2;
        //                                updateProductJobClient.PublishJob(job, updateProductJobExpirationMS);
        //                                //Log.InfoFormat("Send message To RabbitMq {0} with ID = {1}", rabbitMQServerName, productId);
        //                                #endregion

        //                                #region Xóa ảnh Thumb nếu có
        //                                //push message lên service xóa ảnh thumb
        //                                Job deletejob = new Job();
        //                                MQThumbImageInfo thumb = new MQThumbImageInfo();
        //                                thumb.ProductID = productId;
        //                                thumb.FolderImage = folder;
        //                                thumb.ImageName = filename;
        //                                thumb.TypeProduct = 2;
        //                                deletejob.Data = MQThumbImageInfo.GetMess(thumb);
        //                                deleteThumbJobClient.PublishJob(deletejob);
        //                                #endregion
        //                                this.Invoke(new Action(() =>
        //                                {
        //                                    rbIndex.AppendText(string.Format("{0}...{1}: {2}.{3} sucess.", 1, companyId, i, productId) + System.Environment.NewLine);
        //                                }));
        //                                break;
        //                            }
        //                            catch (Exception ex)
        //                            {
        //                                this.Invoke(new Action(() =>
        //                                {
        //                                    rbListFails.AppendText(i + "." + productId + ": Update Solr + Push service Delete Thumb fails." + ex.ToString() + System.Environment.NewLine);
        //                                }));
        //                                break;
        //                                //Thread.Sleep(10000);
        //                                //dem++;
        //                                //if (dem == 1)
        //                                //    Log.Error(string.Format("CompanyID = {0} Product = {1}, Update ImagePath Error 1", companyId, productId), ex);
        //                                //else if (dem == numbererror)
        //                                //{
        //                                //    Log.Error(string.Format("CompanyID = {0} Product = {1}, Update ImagePath Error {2}", companyId, productId, numbererror), ex);
        //                                //    break;
        //                                //}
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        this.Invoke(new Action(() =>
        //                        {
        //                            //lbFails.Text = countfail.ToString();
        //                            rbIndex.AppendText(string.Format("{0}...{1}: {2}.{3} fails.", 1, companyId, i, productId) + System.Environment.NewLine);
        //                            rbListLinksFails.AppendText(i + "." + productId + ": Download fails." + imageUrl + " ...Name: " + nameProduct + System.Environment.NewLine);
        //                        }));
        //                    }
        //                    #endregion
        //                }
        //                else
        //                {
        //                    #region DownloadImageMerchant

        //                    #endregion
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
