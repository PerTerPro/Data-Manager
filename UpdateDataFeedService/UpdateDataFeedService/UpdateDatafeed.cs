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

namespace WSS.UpdateDataFeedService
{
    public partial class UpdateDatafeed : ServiceBase
    {
        private Consumer consumer1;
        private Consumer consumer2;
        private Consumer consumer3;
        private string _hostName;
        private string _queueName;
        private string connectionString;
        private Company _company;
        private CancellationTokenSource cancelUpdateDataFeedTokenSource;
        private static readonly ILog Log = LogManager.GetLogger(typeof(UpdateDatafeed));
        public UpdateDatafeed()
        {
            InitializeComponent();
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
            _hostName = ConfigurationSettings.AppSettings["HostName"];
            _queueName = ConfigurationSettings.AppSettings["QueueName"];
        }
        protected override void OnStart(string[] args)
        {
            consumer1 = new Consumer(_hostName, _queueName);
            consumer1.onMessageReceived += UpdateDataFeedProducts;
            consumer1.StartConsuming();
            consumer2 = new Consumer(_hostName, _queueName);
            consumer2.onMessageReceived += UpdateDataFeedProducts2;
            consumer2.StartConsuming();
            consumer3 = new Consumer(_hostName, _queueName);
            consumer3.onMessageReceived += UpdateDataFeedProducts3;
            consumer3.StartConsuming();
        }

        protected override void OnStop()
        {
            cancelUpdateDataFeedTokenSource.Cancel();
            consumer1.Dispose();
            consumer2.Dispose();
            consumer3.Dispose();
        }
        
        private void UpdateDataFeedProducts(byte[] message)
        {
            Thread.Sleep(10000);
            JobRabbitMQ jobReceived = ProtobufTool.DeSerialize<JobRabbitMQ>(message);
            if (jobReceived.JobName == "UpdateDatafeed")
            {
                if (jobReceived.JobType == 1)
                {
                    Log.InfoFormat("Consumer1 worked with CompanyID = {0}", jobReceived.JobInformation);
                    QT.Entities.Server.ConnectionString = connectionString;
                    CompanyFunctions companyfuncition = new CompanyFunctions();
                    Company company = new Company(Common.Obj2Int64(jobReceived.JobInformation));
                    cancelUpdateDataFeedTokenSource = new CancellationTokenSource();
                    companyfuncition.UpdateDataFeedProducts(company, cancelUpdateDataFeedTokenSource);
                }
            }
        }
        private void UpdateDataFeedProducts2(byte[] message)
        {
            Thread.Sleep(10000);
            JobRabbitMQ jobReceived = ProtobufTool.DeSerialize<JobRabbitMQ>(message);
            if (jobReceived.JobName == "UpdateDatafeed")
            {
                if (jobReceived.JobType == 1)
                {
                    Log.InfoFormat("Consumer2 worked with CompanyID = {0}", jobReceived.JobInformation);
                    QT.Entities.Server.ConnectionString = connectionString;
                    CompanyFunctions companyfuncition = new CompanyFunctions();
                    Company company = new Company(Common.Obj2Int64(jobReceived.JobInformation));
                    cancelUpdateDataFeedTokenSource = new CancellationTokenSource();
                    companyfuncition.UpdateDataFeedProducts(company, cancelUpdateDataFeedTokenSource);
                }
            }
        }
        private void UpdateDataFeedProducts3(byte[] message)
        {
            Thread.Sleep(10000);
            JobRabbitMQ jobReceived = ProtobufTool.DeSerialize<JobRabbitMQ>(message);
            if (jobReceived.JobName == "UpdateDatafeed")
            {
                if (jobReceived.JobType == 1)
                {
                    Log.InfoFormat("Consumer3 worked with CompanyID = {0}", jobReceived.JobInformation);
                    QT.Entities.Server.ConnectionString = connectionString;
                    CompanyFunctions companyfuncition = new CompanyFunctions();
                    Company company = new Company(Common.Obj2Int64(jobReceived.JobInformation));
                    cancelUpdateDataFeedTokenSource = new CancellationTokenSource();
                    companyfuncition.UpdateDataFeedProducts(company, cancelUpdateDataFeedTokenSource);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }


        [ProtoContract]
        public class JobRabbitMQ
        {
            [ProtoMember(1)]
            public string JobName { set; get; }
            [ProtoMember(2)]
            public int JobType { set; get; }
            [ProtoMember(3)]
            public string JobInformation { set; get; }
        }
    }
}
