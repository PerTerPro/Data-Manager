using log4net;
using QT.Entities;
using QT.Moduls.Company;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.XtraBars.Ribbon.Drawing;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.UpdateBizwebService
{
    public partial class UpdateBizwebService : ServiceBase
    {
        private Worker[] workers;
        private string connectionString = "Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
        private string logConnectionString = "Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
        private static readonly ILog Log = LogManager.GetLogger(typeof(UpdateBizwebService));
        RabbitMQServer rabbitMQServer;
        string rabbitMQServerName = "";
        string updateProductImageCompanyJobName = "";
        public UpdateBizwebService()
        {
            InitializeComponent();
            //OnStart(new string[] { });
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
                string updateProductGroupName_Bizweb = ConfigurationSettings.AppSettings["updateProductGroupName"];
                updateProductImageCompanyJobName = ConfigurationSettings.AppSettings["updateProductWebPartnerJobName_Bizweb"];
                string workercount = ConfigurationSettings.AppSettings["workerCount"];
                int workerCount = Common.Obj2Int(workercount);

                workers = new Worker[workerCount];
                rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                for (int i = 0; i < workerCount; i++)
                {
                    var worker = new Worker(updateProductImageCompanyJobName, false, rabbitMQServer);
                    CompanyFunctions companyFunctions = new CompanyFunctions();
                    workers[i] = worker;
                    Task workerTask = new Task(() =>
                    {
                        worker.JobHandler = (updateProductJob) =>
                        {
                            long id = -1;
                            try
                            {
                                id = BitConverter.ToInt64(updateProductJob.Data, 0);
                                UpdateProductBizweb(companyFunctions,id);
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

        private void UpdateProductBizweb(CompanyFunctions companyFunctions,long idWebsosanh)
        {
            DBBizTableAdapters.Company_BizwebTableAdapter bizwebTableAdapter = new DBBizTableAdapters.Company_BizwebTableAdapter();
            bizwebTableAdapter.Connection.ConnectionString = connectionString;
            DBBiz.Company_BizwebDataTable bizwebTable = new DBBiz.Company_BizwebDataTable();
            try
            {
                bizwebTableAdapter.FillBy_IDWSS(bizwebTable, idWebsosanh);
                if (bizwebTable.Rows.Count > 0)
                {
                    QT.Entities.Company company = new QT.Entities.Company(idWebsosanh);
                    if (company.Name.ToLower() == "not in database")
                        Log.ErrorFormat("BIZWEB : ID received in RabbitMQ not in Company... ID = {0} ", idWebsosanh);
                    else
                    {
                        string shopname = bizwebTable.Rows[0]["ShopName"].ToString();
                        string accesstoken = bizwebTable.Rows[0]["AccessToken"].ToString();
                        List<QT.Entities.Product> ListProducts = QT.Moduls.Bizweb.frmSettingBizwebs.GetProductFromBizweb(shopname, accesstoken, company);
                        if (ListProducts.Count == 0)
                        {
                            HistoryDatafeedAdapter.InsertHistory(company.ID, company.DataFeedPath, ListProducts.Count, 0, 0, string.Format("Get 0 product from API BIZWEB"));
                        }
                        else if (ListProducts.Count < company.TotalProduct && ((company.TotalProduct - ListProducts.Count) < 10000 || (ListProducts.Count / company.TotalProduct) < 0.8))
                        {
                            HistoryDatafeedAdapter.InsertHistory(company.ID, company.DataFeedPath, ListProducts.Count, 0, 0, string.Format("Số sản phẩm lấy về quá ít so với số có trong database. Kiểm tra lại"));
                        }
                        else
                        {
                            Log.InfoFormat("Get {0} product of Company {1}, ID = {2}", ListProducts.Count, company.Domain, company.ID);
                            var cancelUpdateDataFeedTokenSource = new CancellationTokenSource();
                            companyFunctions.UpdateProductsToSql(company, ListProducts, cancelUpdateDataFeedTokenSource);
                        }

                    }
                }
                else
                    Log.ErrorFormat("BIZWEB: ID received in RabbitMQ not in Company_Bizweb... ID = {0}", idWebsosanh);

            }
            catch (Exception ex)
            {
                Log.Error("BIZWEB ERROR : ", ex);
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
