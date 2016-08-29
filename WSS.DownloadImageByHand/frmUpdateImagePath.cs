using log4net;
using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.DownloadImageByHand
{
    public partial class frmUpdateImagePath : Form
    {
        private string connectionString = "";
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmUpdateImagePath));
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
        public frmUpdateImagePath()
        {
            InitializeComponent();
            Init();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            long companyId = Convert.ToInt64(txtCompanyId.Text);
            bool reloadall = false;
            if (checkEdit1.Checked)
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
                Thread tr = new Thread(() => DownloadImageSPGoc(companyId, reloadall));
                tr.Start();
            }
        }

        private void DownloadImageSPGoc(long companyId, bool reloadall = false)
        {
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
            //Jobclient update solr and redis
            var updateProductJobClient = new JobClient(updateProductExchangeGroupName, GroupType.Topic, updateProductqueueJobName, true, rabbitMQServer);
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
                        rbsuccess.AppendText(companyId + ".Get " + productTable.Rows.Count + " Product from SQL..." + System.Environment.NewLine);
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
                            //fileSaved = Common.SaveFileDownloadImage(imageUrl, path + folder, filename + ".jpg", productId, companyId);
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
                                        rbsuccess.AppendText(string.Format("{0}...{1}: {2}.{3} sucess.", 1, companyId, i, productId) + System.Environment.NewLine);
                                    }));
                                    break;
                                }
                                catch (Exception ex)
                                {
                                    this.Invoke(new Action(() =>
                                    {
                                        rbfail.AppendText(i + "." + productId + ": Update Solr + Push service Delete Thumb fails." + ex.ToString() + System.Environment.NewLine);
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
                                rbsuccess.AppendText(string.Format("{0}...{1}: {2}.{3} fails.", 1, companyId, i, productId) + System.Environment.NewLine);
                                rbfail.AppendText(i + "." + productId + ": Download fails." + imageUrl + " ...Name: " + nameProduct + System.Environment.NewLine);
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
    }
}
