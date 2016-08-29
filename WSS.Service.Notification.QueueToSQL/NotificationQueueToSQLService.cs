using log4net;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;


namespace WSS.Service.Notification.QueueToSQL
{
    public partial class ServiceCacheProductInfo : ServiceBase
    {

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ServiceCacheProductInfo));
        string connectionString = "";
        CancellationTokenSource cancelTokenSource = null;
        RabbitMQServer rabbitMQServer = null;
        List<string> jobQueues = new List<string>();
        Worker[] workers = null;
        SqlDb dbNotify = null;

        public ServiceCacheProductInfo()
        {
            InitializeComponent();

            try
            {
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
                connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                dbNotify = new SqlDb(connectionString);
                DataTable queueWriteSqls = dbNotify.GetTblData("Select * from Notification_Queue", CommandType.Text, null);
                foreach (DataRow row in queueWriteSqls.Rows)
                {
                    this.jobQueues.Add(row["Queue"].ToString());
                }
                log.Info("Number queue write to sql:" + queueWriteSqls.Rows.Count);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        protected override void OnStart(string[] args)
        {
            
            log.Info("Start service");
            try
            {
                int numberQUeue = this.jobQueues.Count();
                InitializeComponent();
                cancelTokenSource = new CancellationTokenSource();
                Server.LogConnectionString = ConfigurationManager.AppSettings["LogConnectionString"];
                QT.Entities.Server.ConnectionString = connectionString;
                string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
                workers = new Worker[numberQUeue];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                for (int i = 0; i < numberQUeue; i++)
                {
                    int indexQueue = i;
                    log.InfoFormat("Start worker {i}", i.ToString());
                    var worker = new Worker(this.jobQueues[indexQueue], false, rabbitMQServer);
                    workers[i] = worker;
                    var token = this.cancelTokenSource.Token;
                    Task workerTask = new Task(() =>
                    {
                        string queueName = this.jobQueues[indexQueue];
                        QT.Moduls.Notifycation.NotifycationAdapter adapter = new QT.Moduls.Notifycation.NotifycationAdapter();
                        worker.JobHandler = (updateDatafeedJob) =>
                        {
                            try
                            {
                                string strMessage = System.Text.Encoding.UTF8.GetString(updateDatafeedJob.Data, 0, updateDatafeedJob.Data.Length);
                                adapter.InsertMessage(queueName, strMessage, 0);
                                log.Info(string.Format("MSS:{0}. Queue:{1}", strMessage, queueName));
                                return true;
                            }
                            catch (OperationCanceledException opc)
                            {
                                log.Info("End worker");
                                return true;
                            }
                            catch (Exception ex01)
                            {
                                log.Error(ex01);
                                return true;
                            }
                        };
                        worker.Start();
                    },token);
                    workerTask.Start();
                    log.InfoFormat("Worker {0} started", i);
                }
            }
            catch (Exception ex)
            {
                log.Error("Start error", ex);
                throw;
            }
        }

        protected override void OnStop()
        {
            if (this.cancelTokenSource != null
                && !this.cancelTokenSource.IsCancellationRequested)
            {
                log.Info("Cancellation all thread");
                this.cancelTokenSource.Cancel();
            }
        }
    }
}
