using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.UpdateProductPartnerProducer
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            Log.InfoFormat("Start producer :{0}", DateTime.Now);
            string connection = ConfigurationSettings.AppSettings["ConnectionString"];
            string rabbitMQServerName = ConfigurationSettings.AppSettings["rabbitMQServerName"];
            int updateProductToWebJobExpirationMS = 3500000;
            updateProductToWebJobExpirationMS = Convert.ToInt32(ConfigurationSettings.AppSettings["updateProductToWebJobExpirationMS"]);
            string updateProductGroupName = ConfigurationSettings.AppSettings["updateProductGroupName"];
            string updateProductJobName_Haravan = ConfigurationSettings.AppSettings["updateProductJobName_Haravan"];
            string updateProductJobName_Bizweb = ConfigurationSettings.AppSettings["updateProductJobName_Bizweb"];

            RabbitMQServer rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
            JobClient updateProductHaravantJobClient = new JobClient(updateProductGroupName, GroupType.Topic, updateProductJobName_Haravan, true, rabbitMQServer);
            JobClient updateProductBizwebJobClient = new JobClient(updateProductGroupName, GroupType.Topic, updateProductJobName_Bizweb, true, rabbitMQServer);
            try
            {
                DBPartnerTableAdapters.Company_HaravanTableAdapter haravanAdapter = new DBPartnerTableAdapters.Company_HaravanTableAdapter();
                haravanAdapter.Connection.ConnectionString = connection;
                DBPartner.Company_HaravanDataTable haravanTable = new DBPartner.Company_HaravanDataTable();
                haravanAdapter.FillBy_ActiveAndPulic(haravanTable);
                if (haravanTable.Rows.Count > 0)
                {
                    for (int i = 0; i < haravanTable.Rows.Count; i++)
                    {
                        long idwebsosanh = Convert.ToInt64(haravanTable.Rows[i]["CompanyIdWSS"]);
                        Job job = new Job();
                        job.Data = BitConverter.GetBytes(idwebsosanh);
                        updateProductHaravantJobClient.PublishJob(job, updateProductToWebJobExpirationMS);

                    }
                    Log.Info(string.Format("HARAVAN: Send {0} Company to RabbitMQServer {1}, Routing Key {2}", haravanTable.Rows.Count, rabbitMQServerName, updateProductJobName_Haravan));
                }
            }
            catch (Exception ex)
            {
                Log.Error("ERROR: ", ex);
            }

            try
            {
                DBPartnerTableAdapters.Company_BizwebTableAdapter bizwebAdapter = new DBPartnerTableAdapters.Company_BizwebTableAdapter();
                bizwebAdapter.Connection.ConnectionString = connection;
                DBPartner.Company_BizwebDataTable bizwebTable = new DBPartner.Company_BizwebDataTable();
                bizwebAdapter.FillBy_ActiveAndPublic(bizwebTable);
                if (bizwebTable.Rows.Count > 0)
                {
                    for (int i = 0; i < bizwebTable.Rows.Count; i++)
                    {
                        long idwebsosanh = Convert.ToInt64(bizwebTable.Rows[i]["CompanyIdWSS"]);
                        Job job = new Job();
                        job.Data = BitConverter.GetBytes(idwebsosanh);
                        updateProductBizwebJobClient.PublishJob(job, updateProductToWebJobExpirationMS);
                    }
                    Log.Info(string.Format("BIZWEB: Send {0} Company to RabbitMQServer {1}, Routing Key {2}", bizwebTable.Rows.Count, rabbitMQServerName, updateProductJobName_Bizweb));
                }
            }
            catch (Exception ex)
            {
                Log.Error("ERROR: ", ex);
            }
            rabbitMQServer.Stop();
        }
    }
}
