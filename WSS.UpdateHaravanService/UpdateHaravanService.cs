using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using System.Configuration;
using QT.Entities;
using System.Threading;
using QT.Moduls.Company;
namespace WSS.UpdateHaravanService
{
    public partial class UpdateHaravanService : ServiceBase
    {
        private Worker[] workers;
        private string connectionString = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
        private string logConnectionString = "Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
        private static readonly ILog Log = LogManager.GetLogger(typeof(UpdateHaravanService));
        RabbitMQServer rabbitMQServer;
        string rabbitMQServerName = "";
        string updateProductImageCompanyJobName = "";

        public UpdateHaravanService()
        {
            InitializeComponent();
            //UpdateProductHaravan(7454838586300231435);
            //OnStart(new string[]{});
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
                logConnectionString = ConfigurationSettings.AppSettings["LogConnectionString"];
                //CompanyFunctions dùng đến 2 connectionString này
                QT.Entities.Server.ConnectionString = connectionString;
                QT.Entities.Server.LogConnectionString = logConnectionString;

                rabbitMQServerName = ConfigurationSettings.AppSettings["rabbitMQServerName"];
                //woker receive message idharavan
                string updateProductGroupName_Haravan = ConfigurationSettings.AppSettings["updateProductGroupName"];
                updateProductImageCompanyJobName = ConfigurationSettings.AppSettings["updateProductWebPartnerJobName_Haravan"];

                int workerCount = Common.Obj2Int(ConfigurationSettings.AppSettings["workerCount"]);

                workers = new Worker[workerCount];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                for (int i = 0; i < workerCount; i++)
                {
                    var worker = new Worker(updateProductImageCompanyJobName, false, rabbitMQServer);
                    workers[i] = worker;
                    CompanyFunctions companyFunctions = new CompanyFunctions();
                    Task workerTask = new Task(() =>
                    {
                        worker.JobHandler = (updateProductJob) =>
                        {
                            long id = -1;
                            try
                            {
                                id = BitConverter.ToInt64(updateProductJob.Data, 0);
                                UpdateProductHaravan(companyFunctions, id);
                            }
                            catch (Exception ex)
                            {
                                Log.Error("Execute Job Error. ID:" + id, ex);
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
                Log.Error("ERROR :", ex);
            }

        }
        private void UpdateProductHaravan(CompanyFunctions companyFunctions, long idWebsosanh)
        {
            //Log.Info(string.Format("Nhan message {0}", idWebsosanh));
            DBHarTableAdapters.Company_HaravanTableAdapter haravanAdapter = new DBHarTableAdapters.Company_HaravanTableAdapter();
            haravanAdapter.Connection.ConnectionString = connectionString;
            DBHar.Company_HaravanDataTable haravanTable = new DBHar.Company_HaravanDataTable();
            try
            {
                haravanAdapter.FillBy_IDWSS(haravanTable, idWebsosanh);
                if (haravanTable.Rows.Count > 0)
                {

                    QT.Entities.Company company = new QT.Entities.Company(idWebsosanh);
                    if (company.Name.ToLower() == "not in database")
                        Log.ErrorFormat("HARAVAN : ID received in RabbitMQ not in Company... ID = {0} ", idWebsosanh);
                    else
                    {
                        string shopname = haravanTable.Rows[0]["ShopName"].ToString();
                        string accesstoken = haravanTable.Rows[0]["AccessToken"].ToString();
                        List<QT.Entities.Product> ListProducts = QT.Moduls.WebPartner.frmSettingHaravan.GetProductFromHaravan(shopname, accesstoken, company);
                        Log.InfoFormat("Get {0} product of Company {1}, ID = {2}", ListProducts.Count,
                            company.Domain, company.ID);
                        var cancelUpdateDataFeedTokenSource = new CancellationTokenSource();
                        companyFunctions.UpdateProductsToSql(company, ListProducts,
                            cancelUpdateDataFeedTokenSource);
                    }
                }
                else
                    Log.ErrorFormat("HARAVAN: ID received in RabbitMQ not in Company_Haravan... ID = {0}", idWebsosanh);

            }
            catch (Exception exx)
            {
                Log.Error("HARAVAN ERROR: ", exx);
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
