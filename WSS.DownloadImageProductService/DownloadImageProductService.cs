using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.JobServer;
using System.Configuration;
using log4net;
using QT.Entities;
using Websosanh.Core.Drivers.RabbitMQ;
using System.IO;
using System.Drawing;
using System.Threading;

namespace WSS.DownloadImageProductService
{
    public partial class DownloadImageProductService : ServiceBase
    {
        private Worker[] workers;
        private string connectionString = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
        private static readonly ILog Log = LogManager.GetLogger(typeof(DownloadImageProductService));
        RabbitMQServer rabbitMQServer;
        string pathImage = "D:\\Image\\";
        string pathImageSPGOC = "D:\\Image\\images\\";
        int updateProductJobExpirationMS = 3500000;
        string rabbitMQServerName = "";
        private bool checkstop = true;
        private int numbererror = 0;

        public DownloadImageProductService()
        {
            InitializeComponent();
            //DownloadImageProduct(5772544095770815746);
            //DownloadImageCompany(8361001349943590728);
            //OnStart(new string[]{});
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                pathImage = ConfigurationSettings.AppSettings["FolderImage"];
                pathImageSPGOC = ConfigurationSettings.AppSettings["FolderImageSPGoc"];

                connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
                rabbitMQServerName = ConfigurationSettings.AppSettings["rabbitMQServerName"];
                //woker nhận message downloadimage
                //product
                string downloadImageProductJobName = ConfigurationSettings.AppSettings["updateProductJobName_ChangeImageProduct"];
                //company
                //string downloadImageCompanyJobName = ConfigurationSettings.AppSettings["updateProductJobName_ChangeImageCompany"];

                //jobclient send message download image product fails
                string updateProductImageGroupName = ConfigurationSettings.AppSettings["updateProductImageGroupName"];
                string updateProductImageProductJobName = ConfigurationSettings.AppSettings["updateProductImageProductJobName"];
                string updateProductImageProductSpGocJobName =
                    ConfigurationSettings.AppSettings["updateProductImageProductSPGocJobName"];
                int workerCount = Common.Obj2Int(ConfigurationSettings.AppSettings["workerCount"]);
                //jobclient send message update redis sau khi downloadimage
                string updateProductExchangeGroupName = ConfigurationSettings.AppSettings["updateProductGroupName_UpSolrRedis"];
                string updateProductqueueJobName = ConfigurationSettings.AppSettings["updateProductJobName_UpSolrRedis"];

                //jobclient send message delete thumb image
                string deleteThumbImageProductJobName = ConfigurationSettings.AppSettings["deleteThumbImageProductJobName"];

                updateProductJobExpirationMS = Common.Obj2Int(ConfigurationSettings.AppSettings["updateJobExpirationMS"]);

                //Số lần tối đa download lỗi ảnh này (check để gửi lại tin nhắn lên rabbit)
                numbererror = Common.Obj2Int(ConfigurationSettings.AppSettings["numberError"]);

                workers = new Worker[workerCount + 1];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);

                for (int i = 0; i < workerCount; i++)
                {
                    var worker = new Worker(downloadImageProductJobName, false, rabbitMQServer);
                    workers[i] = worker;
                    Task workerTask = new Task(() =>
                    {
                        //Jobclient update redis
                        JobClient updateProductJobClient = new JobClient(updateProductExchangeGroupName, GroupType.Direct, updateProductqueueJobName, true, rabbitMQServer);
                        //JobClient download image fails
                        JobClient downloadImageProductJobClient = new JobClient(updateProductImageGroupName, GroupType.Topic, updateProductImageProductJobName, true, rabbitMQServer);
                        //JobClient delete thumb
                        JobClient deleteThumbJobClient = new JobClient(updateProductImageGroupName, GroupType.Topic, deleteThumbImageProductJobName, true, rabbitMQServer);

                        worker.JobHandler = (downloadImageJob) =>
                        {
                            try
                            {
                                MqChangeImage mq = MqChangeImage.GetDataFromMessage(downloadImageJob.Data);
                                if (mq.ProductId != 0)
                                {
                                    //Sản phẩm gốc
                                    if (mq.Type == 3)
                                    {
                                        DownloadImageProductSpGoc(mq, updateProductJobClient, downloadImageProductJobClient, deleteThumbJobClient);
                                    }
                                    else
                                    {
                                        DownloadImageProduct(mq, updateProductJobClient, downloadImageProductJobClient, deleteThumbJobClient);
                                    }
                                }
                                else
                                    Log.Error("Get ID from Message fails. ProductID = 0");
                            }
                            catch (Exception ex)
                            {
                                Log.Error("Execute Job Error.", ex);
                            }
                            return true;
                        };
                        worker.Start();
                    });
                    workerTask.Start();
                    Log.InfoFormat("Worker {0} started", i);
                }
                #region Tách 1 consumer ra để download ảnh sp gốc
                var workerSpGoc = new Worker(updateProductImageProductSpGocJobName, false, rabbitMQServer);
                workers[workerCount] = workerSpGoc;
                Task workerSpGocTask = new Task(() =>
                {
                    //Jobclient update redis
                    JobClient updateProductJobClient = new JobClient(updateProductExchangeGroupName, GroupType.Direct, updateProductqueueJobName, true, rabbitMQServer);
                    //JobClient download image fails
                    JobClient downloadImageProductJobClient = new JobClient(updateProductImageGroupName, GroupType.Topic, updateProductImageProductSpGocJobName, true, rabbitMQServer);
                    //JobClient delete thumb
                    JobClient deleteThumbJobClient = new JobClient(updateProductImageGroupName, GroupType.Topic, deleteThumbImageProductJobName, true, rabbitMQServer);

                    workerSpGoc.JobHandler = (downloadImageJob) =>
                    {
                        try
                        {
                            MqChangeImage mq = MqChangeImage.GetDataFromMessage(downloadImageJob.Data);
                            if (mq.ProductId != 0)
                            {
                                DownloadImageProductSpGoc(mq, updateProductJobClient, downloadImageProductJobClient, deleteThumbJobClient);
                            }
                            else
                                Log.Error("Get ID from Message fails. ProductID = 0");
                        }
                        catch (Exception ex)
                        {
                            Log.Error("Execute Job Error.", ex);
                        }
                        return true;
                    };
                    workerSpGoc.Start();
                });
                workerSpGocTask.Start();
                Log.InfoFormat("Worker(SpGoc) {0} started", workerCount);
                #endregion
            }
            catch (Exception ex)
            {
                Log.Error("Start error", ex);
                throw;
            }
        }

        private void DownloadImageProductSpGoc(MqChangeImage mqProduct, JobClient updateProductJobClient, JobClient downloadImageProductJobClient, JobClient deleteThumbJobClient)
        {
            string path = pathImageSPGOC;
            var productAdapter = new DBTableAdapters.ProductTableAdapter();
            var historyDownloadAdapter = new DBTableAdapters.History_DownloadImageProductTableAdapter();
            var productTable = new DB.ProductDataTable();
            productAdapter.Connection.ConnectionString = connectionString;
            historyDownloadAdapter.Connection.ConnectionString = connectionString;
            //bien dem lay du lieu loi tu sql = 3 thì dừng
            int dem = 0;
            //lấy dữ liệu từ sql
            while (checkstop)
            {
                try
                {
                    productAdapter.FillBy_ID(productTable, mqProduct.ProductId);
                    break;
                }
                catch (Exception ex)
                {
                    if (dem == 3)
                    {
                        historyDownloadAdapter.Insert(mqProduct.ProductId, DateTime.Now, false, "Get product from Database error." + ex, false);
                        Log.ErrorFormat("SP Gốc : ProductID = {0} Get product from Database error. \r\n {1}", mqProduct.ProductId, ex);
                        return;
                    }
                    dem++;
                    Thread.Sleep(30000);
                }
            }
            if (productTable.Rows.Count > 0)
            {
                string nameProduct = productTable.Rows[0]["Name"].ToString();
                string imageUrl = productTable.Rows[0]["ImageUrls"].ToString();
                if (string.IsNullOrEmpty(nameProduct) || string.IsNullOrEmpty(imageUrl))
                {
                    Log.Error(string.Format("SP Gốc : ProductID = {0} Name or ImageUrl is null or empty.", mqProduct.ProductId));
                    return;
                }
                else
                {
                    string filename = Common.UnicodeToKoDauAndGach(nameProduct);
                    if (filename.Length > 100)
                        filename = filename.Substring(0, 99);
                    string folder = Common.GetFolderSaveImageRootProduct(filename);
                    bool fileSaved = Common.SaveFileDownloadImage(imageUrl, path + folder, filename + ".jpg", mqProduct.ProductId, 6619858476258121218);
                    if (fileSaved)
                    {
                        string pathsave = Common.GetImagePath(folder, filename); 
                        int demupdate = 0;
                        while (checkstop)
                        {
                            try
                            {
                                productAdapter.UpdateImagePathAndValid(pathsave, 0, 0, true, mqProduct.ProductId);

                                #region Send Message Update solr and redis
                                Job job = new Job();
                                job.Data = BitConverter.GetBytes(mqProduct.ProductId);
                                job.Type = 2;
                                updateProductJobClient.PublishJob(job, updateProductJobExpirationMS);
                                //Log.InfoFormat("Send message To RabbitMq {0} with ID = {1}", rabbitMQServerName, productId);
                                #endregion

                                #region Xóa ảnh Thumb nếu có
                                //push message lên service xóa ảnh thumb
                                Job deletejob = new Job();
                                var thumb = new MqThumbImageInfo
                                {
                                    ProductId = mqProduct.ProductId,
                                    FolderImage = folder,
                                    ImageName = filename,
                                    TypeProduct = 2
                                };
                                deletejob.Data = MqThumbImageInfo.GetMess(thumb);
                                deleteThumbJobClient.PublishJob(deletejob);
                                #endregion
                                #region Log Finished
                                historyDownloadAdapter.Insert(mqProduct.ProductId, DateTime.Now, true, "SP Gốc", false);
                                #endregion
                                break;
                            }
                            catch (Exception ex)
                            {
                                Thread.Sleep(10000);
                                demupdate++;
                                if (demupdate == 1)
                                    Log.Error(string.Format("SP Gốc : CompanyID = {0} Product = {1}, Update ImagePath Error 1", 6619858476258121218, mqProduct.ProductId), ex);
                                else if (demupdate == numbererror)
                                {
                                    historyDownloadAdapter.Insert(mqProduct.ProductId, DateTime.Now, false, "Update sql fail or push message fail.", false);
                                    Log.Error(string.Format("SP Gốc : CompanyID = {0} Product = {1}, Update ImagePath Error {2}", 6619858476258121218, mqProduct.ProductId, numbererror), ex);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                historyDownloadAdapter.Insert(mqProduct.ProductId, DateTime.Now, false, "Product not in Database.", false);
                Log.ErrorFormat("SP Gốc : ProductID = {0} Khong ton tai trong Database.", mqProduct.ProductId);
            }
        }

        protected override void OnStop()
        {
            foreach (var worker in workers)
                worker.Stop();
            rabbitMQServer.Stop();
            checkstop = false;
        }
        private void DownloadImageProduct(MqChangeImage mqProduct, JobClient jobclientUpdateSolr, JobClient jobclientDownloadImageProduct, JobClient jobclientDeleteThumb)
        {
            WSS.DownloadImageProductService.DBTableAdapters.ProductTableAdapter productAdapter = new WSS.DownloadImageProductService.DBTableAdapters.ProductTableAdapter();
            WSS.DownloadImageProductService.DBTableAdapters.History_DownloadImageProductTableAdapter historyDownloadAdapter = new DBTableAdapters.History_DownloadImageProductTableAdapter();
            WSS.DownloadImageProductService.DB.ProductDataTable productTable = new WSS.DownloadImageProductService.DB.ProductDataTable();
            productAdapter.Connection.ConnectionString = connectionString;
            historyDownloadAdapter.Connection.ConnectionString = connectionString;
            try
            {
                productAdapter.FillBy_ID(productTable, mqProduct.ProductId);
                if (productTable.Rows.Count > 0)
                {
                    String path = pathImage;
                    string filename = Common.UnicodeToKoDauAndGach(productTable.Rows[0]["Name"].ToString());
                    if (filename.Length > 100)
                    {
                        filename = filename.Substring(0, 99);
                    }
                    filename += "_" + mqProduct.ProductId;

                    var url = productTable.Rows[0]["DetailUrl"].ToString();
                    var folder = Common.GetFolderSaveImageProduct(filename, url);
                    var imageurl = productTable.Rows[0]["ImageUrls"].ToString();
                    if (string.IsNullOrEmpty(imageurl))
                    {
                        historyDownloadAdapter.Insert(mqProduct.ProductId, DateTime.Now, false, "DetailUrl: " + url + " Null or Empty!", false);
                        Log.Error(string.Format("ProductID = {0} ImageUrl is null or empty.", mqProduct.ProductId));
                        return;
                    }
                    bool fileSaved = Common.SaveFileDownloadImage(imageurl, path + folder, filename + ".jpg", mqProduct.ProductId, 0);
                    if (fileSaved)
                    {
                        string pathsave = Common.GetImagePath(folder,filename);
                        int dem = 1;
                        while (checkstop)
                        {
                            try
                            {
                                
                                productAdapter.UpdateImagePathAndValid(pathsave, 0, 0, true, mqProduct.ProductId);
                                bool isnews = false;
                                isnews = Common.Obj2Bool(productTable.Rows[0]["IsNews"].ToString());

                                Log.InfoFormat("ProductID = {0} Download Image success.", mqProduct.ProductId);#region Send Message Update solr and redis
                                Job job = new Job();
                                job.Data = BitConverter.GetBytes(mqProduct.ProductId);
                                job.Type = 2;
                                jobclientUpdateSolr.PublishJob(job, updateProductJobExpirationMS);

                                #endregion
                                #region Send message services delete image thumb
                                Job deletejob = new Job();
                                MqThumbImageInfo thumb = new MqThumbImageInfo
                                {
                                    ProductId = mqProduct.ProductId,
                                    FolderImage = folder,
                                    ImageName = filename,
                                    TypeProduct = 1
                                };
                                deletejob.Data = MqThumbImageInfo.GetMess(thumb);
                                jobclientDeleteThumb.PublishJob(deletejob);
                                #endregion
                                #region Log Finished
                                historyDownloadAdapter.Insert(mqProduct.ProductId, DateTime.Now, true, "", isnews);
                                #endregion
                                break;
                            }
                            catch (Exception ex)
                            {
                                Thread.Sleep(10000);
                                if (dem == 1)
                                    Log.Error(string.Format("ProductID = {0}, Update ImagePath Error lan 1", mqProduct.ProductId), ex);
                                else if (dem == numbererror)
                                {
                                    #region Log error in here
                                    historyDownloadAdapter.Insert(mqProduct.ProductId, DateTime.Now, false, "UpdateImagePath OR Update Solr or Redis OR Send Message Delete Thumb Error: " + ex.Message, false);
                                    #endregion
                                    Log.Error(string.Format("ProductID = {0}, Update ImagePath Error lan {1}", mqProduct.ProductId, numbererror), ex);
                                    break;
                                }
                                else
                                    dem++;
                            }
                        }
                    }
                    else
                    {
                        historyDownloadAdapter.Insert(mqProduct.ProductId, DateTime.Now, false, imageurl + " . Download Fails.", false);
                        //CheckErrorDownloadImage(mqProduct, jobclientDownloadImageProduct);
                    }
                }
                else
                {
                    historyDownloadAdapter.Insert(mqProduct.ProductId, DateTime.Now, false, "Product not in Database.", false);
                    Log.ErrorFormat("ProductID = {0} Khong ton tai trong Database.", mqProduct.ProductId);
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("ProductID = {0} Get Info Product in SQL Error.", mqProduct.ProductId), ex);
                historyDownloadAdapter.Insert(mqProduct.ProductId, DateTime.Now, false, "Error: " + ex.Message, false);
                //CheckErrorDownloadImage(mqProduct, jobclientDownloadImageProduct);
            }
        }
        public void CheckErrorDownloadImage(MqChangeImage mqProduct, JobClient jobClient)
        {
            //Check số lần download error trên Redis
            int errordownload = RedisErrorDownloadImageProductAdapter.GetErrorDownloadImage(mqProduct.ProductId);
            //Nếu số lần < numbererror thì push lại message lên để lúc khác download
            if (errordownload <= numbererror)
            {
                errordownload++;
                RedisErrorDownloadImageProductAdapter.SetErrorDownloadImage(mqProduct.ProductId, errordownload);
                Job job = new Job();
                job.Data = MqChangeImage.GetMess(mqProduct);
                try
                {
                    jobClient.PublishJob(job);
                }
                catch (Exception ex)
                {
                    Log.Error(string.Format("ProductID = {0} Send message Redownload image.", mqProduct.ProductId), ex);
                }
            }
        }
    }
}
