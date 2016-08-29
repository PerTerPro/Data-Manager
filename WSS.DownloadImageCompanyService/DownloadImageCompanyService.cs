using log4net;
using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.DownloadImageCompanyService
{
    public partial class DownloadImageCompanyService : ServiceBase
    {
        private Worker[] workers;
        private string connectionString = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
        private static readonly ILog Log = LogManager.GetLogger(typeof(DownloadImageCompanyService));
        RabbitMQServer rabbitMQServer;
        string pathImage = "D:\\Image\\";
        string pathImageSPGOC = "D:\\Image\\images\\";
        //string pathImageThumb = "F:\\img.websosanh.net\\ThumbImages\\Store\\";
        //string sizeThumb = "_140";
        int updateProductJobExpirationMS = 3500000;
        string rabbitMQServerName = "";
        private bool checkstop = true;
        private int numbererror = 0;
        public DownloadImageCompanyService()
        {
            InitializeComponent();
            //DownloadImageCompany(6932001158608411370, null, null,null);
            //DownloadImageSPGoc(6619858476258121218, null, null,true);
            //OnStart(new string[] { });
        }

        protected override void OnStart(string[] args)
        {
            pathImage = ConfigurationSettings.AppSettings["FolderImage"];
            pathImageSPGOC = ConfigurationSettings.AppSettings["FolderImageSPGoc"];
            //sizeThumb = ConfigurationSettings.AppSettings["SizeImageThumb"];
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
            rabbitMQServerName = ConfigurationSettings.AppSettings["rabbitMQServerName"];
            //woker nhận message downloadimage
            //product
            //string downloadImageProductJobName = ConfigurationSettings.AppSettings["updateProductJobName_ChangeImageProduct"];
            //company
            string downloadImageCompanyJobName = ConfigurationSettings.AppSettings["updateProductJobName_ChangeImageCompany"];

            //jobclient send message download image product fails
            string updateProductImageGroupName = ConfigurationSettings.AppSettings["updateProductImageGroupName"];
            string updateProductImageProductJobName = ConfigurationSettings.AppSettings["updateProductImageProductJobName"];

            int workerCount = Common.Obj2Int(ConfigurationSettings.AppSettings["workerCount"]);
            //jobclient send message update solr sau khi downloadimage
            string updateProductExchangeGroupName = ConfigurationSettings.AppSettings["updateProductGroupName_UpSolrRedis"];
            string updateProductqueueJobName = ConfigurationSettings.AppSettings["updateProductJobName_UpSolrRedis"];

            //jobclient send message delete thumb image
            string deleteThumbImageProductJobName = ConfigurationSettings.AppSettings["deleteThumbImageProductJobName"];

            updateProductJobExpirationMS = Common.Obj2Int(ConfigurationSettings.AppSettings["updateJobExpirationMS"]);
            //Số lần tối đa download lỗi ảnh này (check để gửi lại tin nhắn lên rabbit)
            numbererror = Common.Obj2Int(ConfigurationSettings.AppSettings["numberError"]);

            //DownloadImageSPGoc(6619858476258121218, null, null, null, false);


            workers = new Worker[workerCount];
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
            for (int i = 0; i < workerCount; i++)
            {
                var worker = new Worker(downloadImageCompanyJobName, false, rabbitMQServer);
                workers[i] = worker;
                Task workerTask = new Task(() =>
                {
                    //Jobclient update solr and redis
                    JobClient updateProductJobClient = new JobClient(updateProductExchangeGroupName, GroupType.Direct, updateProductqueueJobName, true, rabbitMQServer);
                    //JobClient download image fails
                    JobClient downloadImageProductJobClient = new JobClient(updateProductImageGroupName, GroupType.Topic, updateProductImageProductJobName, true, rabbitMQServer);
                    //JobClient delete thumb
                    JobClient deleteThumbJobClient = new JobClient(updateProductImageGroupName, GroupType.Topic, deleteThumbImageProductJobName, true, rabbitMQServer);

                    worker.JobHandler = (downloadImageJob) =>
                    {
                        long id = -1;
                        try
                        {
                            id = BitConverter.ToInt64(downloadImageJob.Data,0);
                            int typejob = downloadImageJob.Type;
                            if (typejob == (int)TypeJobWithRabbitMQ.ReloadAll)
                            {
                                if (id == 6619858476258121218)
                                    DownloadImageSPGoc(id, updateProductJobClient, downloadImageProductJobClient,deleteThumbJobClient, true);
                                else
                                    DownloadImageCompany(id, updateProductJobClient, downloadImageProductJobClient, deleteThumbJobClient, true);
                            }
                            else
                            {
                                if (id == 6619858476258121218)
                                    DownloadImageSPGoc(id, updateProductJobClient, downloadImageProductJobClient,deleteThumbJobClient);
                                else
                                    DownloadImageCompany(id, updateProductJobClient, downloadImageProductJobClient,deleteThumbJobClient);
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.Error("Execute Job Error. ID:" + id, ex);
                        }
                        return true;
                    };
                    worker.Start();
                });
                workerTask.Start();
                Log.InfoFormat("Worker {0} started", i);
            }
        }
        private void DownloadImageCompany(long companyId, JobClient jobclientUpdateSolr, JobClient jobclientDownloadImageProduct, JobClient jobclientDeleteThumb, bool reloadall = false)
        {
            DateTime startDownload = DateTime.Now;
            WSS.DownloadImageCompanyService.DBTableAdapters.ProductTableAdapter productAdapter = new WSS.DownloadImageCompanyService.DBTableAdapters.ProductTableAdapter();
            WSS.DownloadImageCompanyService.DBTableAdapters.History_DownloadImageCompanyTableAdapter historyAdapter = new DBTableAdapters.History_DownloadImageCompanyTableAdapter();
            productAdapter.Connection.ConnectionString = connectionString;
            historyAdapter.Connection.ConnectionString = connectionString;
            WSS.DownloadImageCompanyService.DB.ProductDataTable productTable = new WSS.DownloadImageCompanyService.DB.ProductDataTable();
            int demgetproduct = 0;
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
                        Log.Error(string.Format("CompanyID = {0} Get Product of Company in SQL Error 1", companyId), ex);
                    else if (demgetproduct == numbererror)
                    {
                        Log.Error(string.Format("CompanyID = {0} Get Product of Company in SQL Error {1}", companyId, numbererror), ex);
                        //Ghi log
                        historyAdapter.Insert(companyId, 0, 0, 0, startDownload, DateTime.Now, "Lấy dữ liệu " + numbererror + " lần từ SQL fails. " + ex.ToString());
                        return;
                    }
                    Thread.Sleep(60000);
                }
            }

            if (productTable.Rows.Count > 0)
            {
                String path = pathImage;
                int countsuccess = 0;
                int fail = 0;
                List<long> listIDFail = new List<long>();
                string exception = "";
                try
                {
                    for (int i = 0; i < productTable.Rows.Count; i++)
                    {
                        long productId = Common.Obj2Int64(productTable.Rows[i]["ID"].ToString());
                        string url = productTable.Rows[i]["DetailUrl"].ToString();
                        if (string.IsNullOrEmpty(url))
                        {
                            fail++;
                            listIDFail.Add(productId);
                            continue;
                        }
                            
                        Uri root = new Uri(url);
                        string domain = root.DnsSafeHost.Replace("www.", "");
                        string char1 = domain.Substring(0, 1);
                        String namepath = domain.Substring(0, 1) + "\\" + root.DnsSafeHost.Replace("www.", "").Replace('.', '_');
                        string direct = namepath + "\\";
                        string filename = Common.UnicodeToKoDauAndGach(productTable.Rows[i]["Name"].ToString());
                        string tempf = filename.Replace("-", "");
                        if (tempf.Length < 3)
                        {
                            fail++;
                            listIDFail.Add(productId);
                            continue;
                        }
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
                            fail++;
                            Log.Error(string.Format("CompanyID = {0} ProductID = {1} ImageUrl is null or empty.", companyId, productId));
                            continue;
                        }
                        bool fileSaved = false;
                        try
                        {
                            fileSaved = Common.SaveFileDownloadImage(imageurl, path + direct, filename + ".jpg", productId, companyId);
                        }
                        catch (Exception ex)
                        {
                            exception += ex.Message + "|";
                        }
                        
                        if (fileSaved)
                        {
                            string pathsave = direct + filename.Replace('\\', '/') + ".jpg";
                            pathsave = "Store/" + pathsave.Replace('\\', '/');
                            int dem = 0;
                            while (checkstop)
                            {
                                try
                                {
                                    productAdapter.UpdateQuery(pathsave, w, h,true, productId);
                                    Log.InfoFormat("CompanyID = {0} ProductID = {1} Download Image success.", companyId, productId);
                                    #region Send Message Update solr and redis

                                    var job = new Job {Data = BitConverter.GetBytes(productId), Type = 2};
                                    jobclientUpdateSolr.PublishJob(job, updateProductJobExpirationMS);
                                    //Log.InfoFormat("Send message To RabbitMq {0} with ID = {1}", rabbitMQServerName, productId);
                                    #endregion

                                    #region Xóa ảnh Thumb nếu có
                                    //push message lên service xóa ảnh thumb
                                    var deletejob = new Job();
                                    var thumb = new MqThumbImageInfo
                                    {
                                        ProductId = productId,
                                        FolderImage = direct,
                                        ImageName = filename,
                                        TypeProduct = 1
                                    };
                                    deletejob.Data = MqThumbImageInfo.GetMess(thumb);
                                    jobclientDeleteThumb.PublishJob(deletejob);
                                    #endregion
                                    countsuccess++;
                                    break;
                                }
                                catch (Exception ex)
                                {
                                    Thread.Sleep(10000);
                                    dem++;
                                    if (dem == 1)
                                        Log.Error(string.Format("CompanyID = {0} Product = {1}, Update ImagePath Error 1", companyId, productId), ex);
                                    else if (dem == numbererror)
                                    {
                                        fail++;
                                        listIDFail.Add(productId);
                                        Log.Error(string.Format("CompanyID = {0} Product = {1}, Update ImagePath Error {2}", companyId, productId, numbererror), ex);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            fail++;
                            listIDFail.Add(productId);
                            //Check số lần download error trên Redis
                            //int errordowbload = errordowbload = RedisErrorDownloadImageProductAdapter.GetErrorDownloadImage(productId);
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
                    //Ghi log
                    historyAdapter.Insert(companyId, productTable.Rows.Count,countsuccess, fail, startDownload, DateTime.Now, "Finised! "+ConvertListToString(listIDFail) + " . MessageError: "+ exception);
                }
                catch (Exception ex)
                {
                    //Ghi log
                    historyAdapter.Insert(companyId, productTable.Rows.Count,countsuccess, fail, startDownload, DateTime.Now, "Error: "+ ex.Message+" "+ ConvertListToString(listIDFail));
                    Log.Error(string.Format("CompanyID = {0} ERROR~~~", companyId), ex);
                }
            }
            else
            {
                Log.InfoFormat("CompanyID = {0} 0 product (valid = 1 and ImagePath is Null or empty)", companyId);
                //Ghi log
                historyAdapter.Insert(companyId, 0, 0, 0, startDownload, DateTime.Now, "0 Product Valid = 1 and ImagePath is Null or empty");
            }
        }
        private void DownloadImageSPGoc(long companyId, JobClient jobclientUpdateSolr, JobClient jobclientDownloadImageProduct,JobClient jobclientDeleteThumb, bool reloadall = false)
        {
            var productAdapter = new WSS.DownloadImageCompanyService.DBTableAdapters.ProductTableAdapter();
            productAdapter.Connection.ConnectionString = connectionString;
            var productTable = new WSS.DownloadImageCompanyService.DB.ProductDataTable();
            int demgetproduct = 0;
            
            while (true)
            {
                try
                {
                    if (reloadall)
                        productAdapter.FillBy_AllSPGoc(productTable, companyId);
                    else
                        //Lấy danh sách sản phẩm valid = 1 mà chưa có imagepath hoặc sản phẩm có stt =11
                        productAdapter.FillBy_SPGocCanDownloadImage(productTable, companyId);
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
                        bool fileSaved = Common.SaveFileDownloadImage(imageUrl, path + folder, filename + ".jpg", productId, companyId);
                        if (fileSaved)
                        {
                            int w = 0, h = 0;
                            string pathsave = "Store/images/" + folder + "/" + filename + ".jpg";
                            int dem = 0;
                            while (checkstop)
                            {
                                try
                                {
                                    productAdapter.UpdateQuery(pathsave, w, h,true, productId);
                                    Log.InfoFormat("{0}/{1}. CompanyID = {2} ProductID = {3} Download Image success.", i, countproduct, companyId, productId);
                                    countsuccess++;
                                    #region Send Message Update solr and redis

                                    var job = new Job {Data = BitConverter.GetBytes(productId), Type = 2};
                                    jobclientUpdateSolr.PublishJob(job, updateProductJobExpirationMS);
                                    //Log.InfoFormat("Send message To RabbitMq {0} with ID = {1}", rabbitMQServerName, productId);
                                    #endregion

                                    #region Xóa ảnh Thumb nếu có
                                    //push message lên service xóa ảnh thumb
                                    var deletejob = new Job();
                                    var thumb = new MqThumbImageInfo
                                    {
                                        ProductId = productId,
                                        FolderImage = folder,
                                        ImageName = filename,
                                        TypeProduct = 2
                                    };
                                    deletejob.Data = MqThumbImageInfo.GetMess(thumb);
                                    jobclientDeleteThumb.PublishJob(deletejob);
                                    #endregion
                                    break;
                                }
                                catch (Exception ex)
                                {
                                    Thread.Sleep(10000);
                                    dem++;
                                    if (dem == 1)
                                        Log.Error(string.Format("CompanyID = {0} Product = {1}, Update ImagePath Error 1", companyId, productId), ex);
                                    else if (dem == numbererror)
                                    {
                                        Log.Error(string.Format("CompanyID = {0} Product = {1}, Update ImagePath Error {2}", companyId, productId, numbererror), ex);
                                        break;
                                    }
                                }
                            }
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
        protected override void OnStop()
        {
            foreach (var worker in workers)
                worker.Stop();
            rabbitMQServer.Stop();
            checkstop = false;
        }
        private string ConvertListToString(List<long> listid)
        {
            string res = "{";
            for (int i = 0; i < listid.Count; i++)
            {
                if (i == listid.Count - 1)
                {
                    res += listid[i];
                }
                else
                    res += listid[i] + ",";
            }
            return res + "}";
        }
    }
}
