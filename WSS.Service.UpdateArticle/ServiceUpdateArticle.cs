using log4net;
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
using Websosanh.Core.Articles.BAL;
using Websosanh.Core.Articles.BO;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;


namespace WSS.Service.UpdateArticle
{
    public partial class ServiceUpdateArticle : ServiceBase
    {

         
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(ServiceUpdateArticle));
        RabbitMQServer rabbitMQServer = null;
        string jobNameUpdateArticle = "";
        Worker[] workers = null;
        Worker worker = null;
        int workerCount = 1;
        string articleConnectionString = "";
        public ServiceUpdateArticle()
        {
            InitializeComponent();
            jobNameUpdateArticle = ConfigurationManager.AppSettings["UpdateArticleJobName"];
            //OnStart(new string[] { });
        }
        protected override void OnStart(string[] args)
        {
            InitializeComponent();
            log.Info("Start service");
            Article art = new Article();

            try
            {
                string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
                workers = new Worker[workerCount];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                articleConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
                for (int i = 0; i < workerCount; i++)
                {
                    worker = new Worker(jobNameUpdateArticle, false, rabbitMQServer);
                    workers[i] = worker;
                    Task workerTask = new Task(() =>
                    {
                        worker.JobHandler = (Job) =>
                        {
                            try
                            {
                                long articleID = BitConverter.ToInt64(Job.Data, 0);
                                art = ArticleRespository.GetArticleFromDb(articleID,articleConnectionString);
                                if (art!=null)
                                {
                                    ArticleRespository.InsertArticleIntoCache(art);
                                    ArticleShortInfoRespository.InsertArticleShortInfoIntoCache(art);
                                    log.InfoFormat("insert complete:{0}", articleID);
                                    return true;
                                }
                                else
                                {
                                    log.InfoFormat("{0}: null", articleID);
                                    return true;
                                }
                            }
                            catch (Exception ex01)
                            {
                                log.Error(ex01);
                                return true;
                            }
                        };
                        worker.Start();
                        
                    });
                    workerTask.Start();
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
            worker.Stop();
        }
    }
}
