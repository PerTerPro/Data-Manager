using log4net;
using System;
using System.Configuration;
using System.ServiceProcess;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using WebsosanhCacheTool;


namespace WSS.Service.UpdateMerchant
{
    public partial class UpdateMerchantService : ServiceBase
    {
        static readonly ILog Logger = LogManager.GetLogger(typeof(UpdateMerchantService));
        RabbitMQServer _rabbitMQServer;
        readonly string _updateMerchantJobName;
        Worker _worker;
        readonly string _productConnectionString;
        readonly string _userConnectionString;
        public UpdateMerchantService()
        {
            InitializeComponent();
            _updateMerchantJobName = ConfigurationManager.AppSettings["UpdateMerchantJobName"];
            _productConnectionString = ConfigurationManager.ConnectionStrings["ProductConnectionString"].ConnectionString;
            _userConnectionString = ConfigurationManager.ConnectionStrings["UserConnectionString"].ConnectionString;
        }
        protected override void OnStart(string[] args)
        {
            InitializeComponent();
            try
            {
                var rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
                _rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
                _worker = new Worker(_updateMerchantJobName, false, _rabbitMQServer);
                var workerTask = new Task(() =>
                {
                    _worker.JobHandler = (job) =>
                    {
                        long merchantID = 0;
                        try
                        {
                            merchantID = BitConverter.ToInt64(job.Data, 0);
                            if (merchantID == -1)
                            {
                                WebMerchantCacheTool.InsertAllMerchantShortInfoToCache(_productConnectionString, _userConnectionString);
                                WebMerchantCacheTool.InsertAllBranchesAndRegionsOfAllMerchant(_productConnectionString);
                            }
                            else
                            {
                                WebMerchantCacheTool.InsertMerchantShortInfoToCache(merchantID, _productConnectionString, _userConnectionString);
                                WebMerchantCacheTool.InsertAllBranchesAndRegionsOfMerchant(merchantID,
                                    _productConnectionString);
                            }
                            
                        }
                        catch (Exception jobHandlerEx)
                        {
                            Logger.Error("Update Merchant Error! ID: " + merchantID +jobHandlerEx);
                            return false;
                        }
                        return true;
                    };
                    _worker.Start();

                });
                workerTask.Start();
            }
            catch (Exception ex)
            {
                Logger.Error("Start error", ex);
                throw;
            }
        }

        protected override void OnStop()
        {
            _worker.Stop();
        }
    }
}
