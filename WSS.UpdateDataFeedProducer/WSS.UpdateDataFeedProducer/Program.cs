using log4net;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.UpdateDataFeedProducer
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            try
            {
                Log.InfoFormat("Start...");
                Console.WriteLine("Start...");
                QT_2DataSet QT2 = new QT_2DataSet();
                QT_2DataSetTableAdapters.CompanyTableAdapter companyTableAdapter = new QT_2DataSetTableAdapters.CompanyTableAdapter();
                string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
                string updateDatafeedGroupName = ConfigurationManager.AppSettings["updateDatafeedGroupName"];
                string updateDatafeedJobName = ConfigurationManager.AppSettings["updateDatafeedJobName"];
                int updateDatafeedJobExpirationMS = CommonUtilities.Object2Int(ConfigurationManager.AppSettings["updateDatafeedJobExpirationMS"], 0);
                string connectionstring = ConfigurationManager.AppSettings["ConnectionString"];
                var rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                JobClient jobClient = new JobClient(updateDatafeedGroupName, GroupType.Topic, updateDatafeedJobName, true, rabbitMQServer);
                //Log.InfoFormat("ConnectionString = {0}", connectionstring);
                companyTableAdapter.Connection.ConnectionString = connectionstring;
                companyTableAdapter.FillByCompanyDataFeed(QT2.Company);
                Log.InfoFormat("Got {0} companies.", QT2.Company.Rows.Count);
                int sendmessage = 0;
                for (int i = 0; i < QT2.Company.Rows.Count; i++)
                {
                    var companyID = (long)QT2.Company.Rows[i]["ID"];
                    int updateFreq = 0;
                    int.TryParse(QT2.Company.Rows[i]["UpdateFreq"].ToString(), out updateFreq);
                    // Check UpdateFreq nếu > 0 thì đi tiếp, còn = 0 có thể đã lỗi dữ liệu
                    if (updateFreq <= 0)
                        continue;
                    string timeupdate = QT2.Company.Rows[i]["LastUpdateDataFeed"].ToString();
                    //Kiểm tra LastUpdate nếu NULL thì thực hiện 
                    if (timeupdate != "")
                    {
                        DateTime lastUpdateDataFeed = DateTime.Parse(timeupdate);
                        var duration = DateTime.Now - lastUpdateDataFeed;
                        if (duration.TotalHours < updateFreq)
                            continue;
                    }
                    var job = new Job();
                    job.Data = BitConverter.GetBytes(companyID);
                    try
                    {
                        jobClient.PublishJob(job, updateDatafeedJobExpirationMS);
                        sendmessage++;
                        Console.WriteLine(string.Format("{0}. Published UpdateDatafeed job for Company: {1}", i, companyID));
                        Log.InfoFormat("Published UpdateDatafeed job for Company: {0}", companyID);
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Publish UpdateDatafeed job error. Company:" + companyID, ex);
                    }
                }
                Console.WriteLine(string.Format("Publish {0} company to service.", sendmessage));
                Log.Info(string.Format("Publish {0} company to service.", sendmessage));
                rabbitMQServer.Stop();
            }
            catch (Exception ex)
            {
                Log.Error("ERROR: " + ex);
            }
            Thread.Sleep(10000);
            
        }
    }
}
