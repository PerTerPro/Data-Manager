using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using WSS.Service.Log.CommentNotify.Object;
using WSS.Service.Log.CommentNotify.WorkerProcess;
using Dapper;
using System.Configuration;
using log4net;

namespace WSS.Service.Log.CommentNotify
{
    public partial class ServiceLogCommentNotify : ServiceBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(ServiceLogCommentNotify));
        private Worker[] _workers;
        RabbitMQServer _rabbitMqServer;
        string _connectionString = "";
        int _workerCount;
        public ServiceLogCommentNotify()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.AppSettings["UserConnectionString"];
            _rabbitMqServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            _workerCount = int.Parse(ConfigurationManager.AppSettings["WorkerCount"]);
            //OnStart(new string[] { });
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                _workers = new Worker[_workerCount];
                for (int i = 0; i < _workerCount; i++)
                {
                    var worker = new Worker("CMS.CommentNotify", false, _rabbitMqServer);
                    _workers[i] = worker;
                    var workerTask = new Task(() =>
                    {
                        worker.JobHandler = (downloadImageJob) =>
                        {
                            var comment = Comment.GetDataFromMessage(downloadImageJob.Data);
                            LogToSql(comment);
                            Log.InfoFormat("{0}: Log comment succes!", comment.CommentID);
                            return true;
                        };
                        worker.Start();
                    });
                    workerTask.Start();
                }
            }
            catch (Exception ex01)
            {
                Log.Error(ex01);
            }
            
        }
        protected override void OnStop()
        {
            foreach (var worker in _workers)
                worker.Stop();
            _rabbitMqServer.Stop();

        }
        private void LogToSql(Comment comment)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute("Insert into CommentNotify (CommentID, TypeComment, IsCommentParent) values (@CommentID, @TypeComment, @IsCommentParent)",
                    new
                    {
                        CommentID = comment.CommentID,
                        TypeComment = comment.TypeComment,
                        IsCommentParent = comment.IsCommentParent
                    });
            }
        }


    }
}
