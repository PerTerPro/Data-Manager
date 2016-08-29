using GABIZ.Base.Keyword;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.UpdateRankKeyword
{
    public partial class UpdateRankKeyword : ServiceBase
    {
        private Worker[] workers;
        RabbitMQServer rabbitMQServer;
        private static readonly ILog Log = LogManager.GetLogger(typeof(UpdateRankKeyword));
        private string connectionString = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
        public UpdateRankKeyword()
        {
            InitializeComponent();
            //OnStart(new string[] { });
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
                string rabbitMQServerName = ConfigurationSettings.AppSettings["rabbitMQServerName"];
                //worker
                string updateRankJobName = ConfigurationSettings.AppSettings["updateRankKeywordJobName"];
                int workerCount = Convert.ToInt32(ConfigurationSettings.AppSettings["workerCount"]);
                workers = new Worker[workerCount];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                for (int i = 0; i < workerCount; i++)
                {
                    var worker = new Worker(updateRankJobName, false, rabbitMQServer);
                    workers[i] = worker;
                    Task workerTask = new Task(() =>
                    {
                        worker.JobHandler = (updateRankJob) =>
                        {
                            try
                            {
                                //Do something here!
                                RankKeywordInfo rk = new RankKeywordInfo();
                                rk = RankKeywordInfo.GetDataFromMessage(updateRankJob.Data);
                                UpdateRank(rk);
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

        private void UpdateRank(RankKeywordInfo rankKeywordInfo)
        {
            DBKeywordTableAdapters.Keyword_RankTableAdapter kwRankAdapter = new DBKeywordTableAdapters.Keyword_RankTableAdapter();
            kwRankAdapter.Connection.ConnectionString = connectionString;
            try
            {
                kwRankAdapter.Insert(rankKeywordInfo.KeywordID,rankKeywordInfo.Keyword, rankKeywordInfo.RankKeyword, rankKeywordInfo.DateCheck);
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("ERROR with Keyword: {0}", rankKeywordInfo.Keyword), ex);
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
