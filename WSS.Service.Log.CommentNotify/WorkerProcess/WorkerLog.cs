using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Service.Log.CommentNotify.Object;
using Dapper;
using Websosanh.Core.JobServer;
using System.Data;
using System.Data.SqlClient;

namespace WSS.Service.Log.CommentNotify.WorkerProcess
{

    public class WorkerLog
    {
        RabbitMQServer _rabbitMqServer;
        string _connectionString = "";
        Worker _worker;

        public WorkerLog()
        {
            _rabbitMqServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ177");
            _worker = new Worker("CMS.CommentNotify", false, _rabbitMqServer);
        }
        public void Run()
        {
            _worker.JobHandler = (downloadImageJob) =>
            {
                var comment = Comment.GetDataFromMessage(downloadImageJob.Data);
                LogToSql(comment);

                return true;
            };
            _worker.Start();
        }

        private void LogToSql(Comment comment)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute("Insert into CommentNotify (CommentID, TypeComment, IsCommentParent) values (@CommentID, @TypeComment, @IsCommentParent)",
                    new {
                        CommentID = comment.CommentID,
                        TypeComment = comment.TypeComment,
                        IsCommentParent = comment.IsCommentParent
                    });
            }
        }
        private void Stop()
        {
            _worker.Stop();
        }
    }
}
