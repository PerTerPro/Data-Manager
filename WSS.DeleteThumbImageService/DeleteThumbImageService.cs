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
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.DeleteThumbImageService
{
    public partial class DeleteThumbImageService : ServiceBase
    {
        private Worker[] workers;
        RabbitMQServer rabbitMQServer;
        private static readonly ILog Log = LogManager.GetLogger(typeof(DeleteThumbImageService));
        //folder ảnh sản phẩm thường
        private string _folderImage = "";
        //folder ảnh sản phẩm gốc
        private string _folderImageSPGoc = "";
        public DeleteThumbImageService()
        {
            InitializeComponent();
            //OnStart(new string[] { });
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                _folderImage = ConfigurationSettings.AppSettings["FolderImage"];
                _folderImageSPGoc = ConfigurationSettings.AppSettings["FolderImageSPGoc"];
                string rabbitMQServerName = ConfigurationSettings.AppSettings["rabbitMQServerName"];
                //worker
                string deleteThumbJobName = ConfigurationSettings.AppSettings["updateProductJobName_DeleteThumbImage"];
                int workerCount = Convert.ToInt32(ConfigurationSettings.AppSettings["workerCount"]);
                workers = new Worker[workerCount];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                for (int i = 0; i < workerCount; i++)
                {
                    var worker = new Worker(deleteThumbJobName, false, rabbitMQServer);
                    workers[i] = worker;
                    Task workerTask = new Task(() =>
                    {
                        worker.JobHandler = (updateDatafeedJob) =>
                        {
                            try
                            {
                                DeleteImageThumb(updateDatafeedJob.Data);
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

            }
            catch (Exception ex)
            {
                Log.Error("Start error", ex);
                throw;
            }
        }
        private void DeleteImageThumb(byte[] data)
        {
            MqThumbImageInfo thumbImageInfo = new MqThumbImageInfo();
            try
            {
                thumbImageInfo = MqThumbImageInfo.GetDataFromMessage(data);
            }
            catch (Exception ex)
            {
                Log.Error("ERROR convert byte -> MQThumbImageInfo.", ex);
            }
            string directory = string.Empty;
            try
            {
                //SP thường
                if (thumbImageInfo.TypeProduct == 1)
                {
                    directory = _folderImage + thumbImageInfo.FolderImage;
                }
                //SP gốc
                else if (thumbImageInfo.TypeProduct == 2)
                {
                    directory = _folderImageSPGoc + thumbImageInfo.FolderImage;
                }
                DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(directory);
                FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles(thumbImageInfo.ImageName + "*.*");
                //if (filesInDir.Count() > 0)
                //{
                //    Log.Info(string.Format("Delete {0} file with directory {1} filename {2}", filesInDir.Count(), directory, thumbImageInfo.ImageName));
                //}
                foreach (FileInfo foundFile in filesInDir)
                {
                    File.Delete(foundFile.FullName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Could not find a part of the path") || ex.Message.Contains("The device is not ready"))
                {
                }
                else
                    Log.Error(string.Format("Error delete file with path {0}", directory), ex);
            }
        }
        protected override void OnStop()
        {
            foreach (var worker in workers)
                worker.Stop();
            rabbitMQServer.Stop();
        }
    }
}
