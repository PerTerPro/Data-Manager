using log4net;
using QT.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.ProducerCheckCompanyDownloadImage
{
    class Program
    {
        public static readonly ILog Log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            string connectionString = string.Empty;
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

            //JobClientRabbitMQ
            string rabbitMQServerName = ConfigurationSettings.AppSettings["rabbitMQServerName"];
            string updateProductImageGroupName = ConfigurationSettings.AppSettings["updateProductImageGroupName"];
            string updateProductImageJobName = ConfigurationSettings.AppSettings["updateProductImageCompanyJobName"];
            int updateProductToWebJobExpirationMS = Common.Obj2Int(ConfigurationSettings.AppSettings["updateProductToWebJobExpirationMS"]);
            var rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
            JobClient jobClientDownloadImage = new JobClient(updateProductImageGroupName, GroupType.Topic, updateProductImageJobName, true, rabbitMQServer);
            if (!string.IsNullOrEmpty(connectionString))
            {
                try
                {
                    SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("prc_Report_ValidProductNotImage", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            int count = 0;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                long idcompany = Common.Obj2Int64(dt.Rows[i]["ID"].ToString());
                                Job job = new Job();
                                job.Data = BitConverter.GetBytes(idcompany);
                                job.Type = (int)TypeJobWithRabbitMQ.Company;
                                try
                                {
                                    //jobClientDownloadImage.PublishJob(job, updateProductToWebJobExpirationMS);
                                    jobClientDownloadImage.PublishJob(job);
                                    count++;
                                    //Log.InfoFormat("Published Message Company DownloadImage: {0}", companyID);
                                }
                                catch (Exception ex)
                                {
                                    Log.Error("Publish Message Company DownloadImage job error. Company:" + idcompany, ex);
                                }
                            }
                            Log.Info(string.Format("Send {0}/{1} success!", count, dt.Rows.Count));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.Error(ex);
                }
            }
            Thread.Sleep(10000);
            rabbitMQServer.Stop();
        }
    }
}
