using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Articles.BAL;
using Websosanh.Core.Articles.BO;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.Test.UpdateArticle
{
    class Program
    {
        
        CancellationTokenSource cancelTokenSource = null;
        RabbitMQServer rabbitMQServer = null;
        string jobNameUpdateArticle = "";
        Worker[] workers = null;
        int workerCount = 1;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        public void Run()
        {
            
            Article art = new Article();
            try
            {
                jobNameUpdateArticle = "Article.Update";
                cancelTokenSource = new CancellationTokenSource();
                string rabbitMQServerName = "rabbitMQ177";
                workers = new Worker[workerCount];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                for (int i = 0; i < workerCount; i++)
                {
                    var worker = new Worker(jobNameUpdateArticle, false, rabbitMQServer);
                    workers[i] = worker;
                    var token = this.cancelTokenSource.Token;
                    Task workerTask = new Task(() =>
                    {
                        worker.JobHandler = (Job) =>
                        {
                            try
                            {
                                token.ThrowIfCancellationRequested();
                                long articleID = BitConverter.ToInt64(Job.Data, 0);
                                art = ArticleRespository.GetArticleFromDb(articleID, "server=172.22.1.82;uid=wss_news;pwd=HzlRt4$$axzG-*UlpuL2gYDu;database=ReviewsCMS");
                                ArticleRespository.InsertArticleIntoCache(art);
                                ArticleShortInfoRespository.InsertArticleShortInfoIntoCache(art);

                                return true;
                            }
                            catch (Exception ex01)
                            {
                                return true;
                            }
                        };
                        worker.Start();
                    }, token);
                    workerTask.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
