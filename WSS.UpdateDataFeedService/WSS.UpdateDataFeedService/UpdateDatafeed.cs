using log4net;
using ProtoBuf;
using QT.Entities;
using QT.Moduls.Company;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.UpdateDataFeedService
{
    public partial class UpdateDatafeed : ServiceBase
    {
        private Worker[] workers;
        int updateProductJobExpirationMS;
        private string connectionString;
        //Update Datafeed
        string updateDatafeedJobName;
        //Update Product
        string updateProductGroupName;
        string updateProductJobName;
        RabbitMQServer rabbitMQServer;
        CancellationTokenSource cancelUpdateDataFeedTokenSource;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(UpdateDatafeed));
        public UpdateDatafeed()
        {
            InitializeComponent();
            //OnStart(new string[] { });
        }
        protected override void OnStart(string[] args)
        {
            try
            {
                cancelUpdateDataFeedTokenSource = new CancellationTokenSource();
                connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                Server.LogConnectionString = ConfigurationManager.AppSettings["LogConnectionString"];
                QT.Entities.Server.ConnectionString = connectionString;
                string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];

                //worker
                updateDatafeedJobName = ConfigurationManager.AppSettings["updateDatafeedJobName"];
                int workerCount = CommonUtilities.Object2Int(ConfigurationManager.AppSettings["workerCount"], 1);
                workers = new Worker[workerCount];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                for (int i = 0; i < workerCount; i++)
                {
                    var worker = new Worker(updateDatafeedJobName, false, rabbitMQServer);
                    workers[i] = worker;
                    Task workerTask = new Task(() =>
                    {
                        worker.JobHandler = (updateDatafeedJob) =>
                            {
                                long companyId = -1;
                                try
                                {
                                    companyId = BitConverter.ToInt64(updateDatafeedJob.Data, 0);
                                    RunUpdateDatafeed(companyId);
                                }
                                catch (Exception ex)
                                {
                                    Logger.Error("Execute Job Error. Company:" + companyId, ex);
                                }
                                return true;
                            };
                        worker.Start();
                    });
                    workerTask.Start();
                    Logger.InfoFormat("Worker {0} started", i);
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Start error", ex);
                throw;
            }
        }

        private void RunUpdateDatafeed(long companyId)
        {
            var companyfunction = new CompanyFunctions();
            var company = new Company(Common.Obj2Int64(companyId));
            companyfunction.UpdateDataFeedProducts(company, cancelUpdateDataFeedTokenSource);
        }
        protected override void OnStop()
        {
            cancelUpdateDataFeedTokenSource.Cancel();
            foreach (var worker in workers)
                worker.Stop();
            rabbitMQServer.Stop();
        }

    }
}
