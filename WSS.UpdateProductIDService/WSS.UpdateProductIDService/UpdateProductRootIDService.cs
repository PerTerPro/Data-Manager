using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ServiceProcess;
using System.Threading.Tasks;
using log4net;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using Websosanh.Core.Product.BAL;
using Websosanh.Core.Product.BO;

namespace WSS.UpdateProductRootIDService
{
    public partial class UpdateProductRootIDService : ServiceBase
    {
        private Worker[] _updateProductRootIdWorkers;
        private RabbitMQServer _rabbitMqServer;
        private string _connectionString;
        private static readonly ILog Log = LogManager.GetLogger(typeof (UpdateProductRootIDService));

        public UpdateProductRootIDService()
        {
            InitializeComponent();
            //OnStart(new string[] { });
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                _connectionString = ConfigurationManager.ConnectionStrings["productConnectionString"].ConnectionString;
                string rabbitMqServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
                string updateProductRootIdJobName = ConfigurationManager.AppSettings["updateProductRootIDJobName"];
                int updateProductRootIdWorkerCount =CommonUtilities.Object2Int(ConfigurationManager.AppSettings["updateProductRootIDWorkerCount"], 1);
                _updateProductRootIdWorkers = new Worker[updateProductRootIdWorkerCount];
                _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(rabbitMqServerName);
                for (int workerIndex = 0; workerIndex < updateProductRootIdWorkerCount; workerIndex++)
                {
                    var worker = new Worker(updateProductRootIdJobName, false, _rabbitMqServer);
                    _updateProductRootIdWorkers[workerIndex] = worker;
                    var workerTask = new Task(() =>
                    {
                        worker.JobHandler = (updateAllProductOfMerchantToRedisJob) =>
                        {
                            long rootId = 0;
                            try
                            {
                                rootId = BitConverter.ToInt64(updateAllProductOfMerchantToRedisJob.Data, 0);
                                UpdateProductRootId(rootId);
                                return true;
                            }
                            catch (Exception ex)
                            {
                                Log.Error("Update productRootID failed!. RootID: " + rootId, ex);
                                return false;
                            }
                        };
                        worker.Start();
                    });
                    workerTask.Start();
                    Log.InfoFormat("Worker {0} started", workerIndex);
                }

            }
            catch (Exception ex)
            {
                Log.Error("Service start failed!", ex);
                throw;
            }
        }

        protected override void OnStop()
        {
            if (_updateProductRootIdWorkers != null)
                foreach (var worker in _updateProductRootIdWorkers)
                    worker.Stop();
        }

        #region Method
        private void UpdateProductRootId(long rootId)
        {
            int rootIDtemp = 0;
            int.TryParse(rootId.ToString(), out rootIDtemp);
            if (rootIDtemp == 0)
            {
                Log.Error(string.Format("RootID = {0} vượt quá int =)) ", rootId));
                return;
            }
            UpdateProductCategoryToZero((int)rootId);
            var rootProductMapping = RootProductMappingBAL.GetRootProductMappingFromCache(rootId, 0,RootProductMappingSortType.PriceWithVAT);
            if (rootProductMapping == null)
            {
                Log.WarnFormat("Get RootProductMapping return null! with ProductID = {0}",rootId);
                return;
            }
            if (rootProductMapping.ListMerchantProducts == null)
            {
                Log.WarnFormat("Root Product {0} have no product", rootId);
                return;
            }
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(long));
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("CategoryID", typeof(int));

            int categoryId = GetProductCategoryId(rootId);
            foreach (var productIdGroup in rootProductMapping.ListMerchantProducts)
            {
                foreach (var merchantProductId in productIdGroup.Value)
                {
                    dt.Rows.Add(merchantProductId, rootId, categoryId);
                }
            }
            //Update ProductID và CategoryID các sản phẩm merchant theo nhận diện mới
            UpdateBulk(dt);
            Log.Info(string.Format("Update rootID for rootProduct {0} - {1} products", rootId, dt.Rows.Count));
        }
        private int GetProductCategoryId(long productId)
        {
            int categoryid = 0; 
            try
            {
                SqlConnection connect = new SqlConnection(_connectionString);
                SqlCommand command = new SqlCommand("Product_GetCategoryIDSPGoc");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connect;
                command.Parameters.AddWithValue("ProductID", productId);
                connect.Open();
                SqlDataReader dt = command.ExecuteReader();
                while (dt.Read())
                {
                    categoryid = int.Parse(dt[0].ToString());
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                Log.Error("Get CategoryID error: " + ex.ToString());
            }
            return categoryid;
        }

        /// <summary>
        /// Cập nhật lại ProductID = 0 trước khi cập nhật ProductID mới theo nhận diện mới
        /// </summary>
        /// <param name="rootId"></param>
        private void UpdateProductCategoryToZero(int rootId)
        {
            try
            {
                SqlConnection connect = new SqlConnection(_connectionString);
                SqlCommand command = new SqlCommand("Product_UpdateProductIDEqual0");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connect;
                command.Parameters.AddWithValue("ProductID", rootId);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                Log.Error("UpdateProductCategory = 0 error:\r\n" + ex.ToString());
            }
        }

        /// <summary>
        /// Update ProductID và Category theo nhận diện mới
        /// </summary>
        /// <param name="dt"></param>
        private void UpdateBulk(DataTable dt)
        {
            try
            {
                SqlConnection connect = new SqlConnection(_connectionString);
                SqlCommand command = new SqlCommand("Product_UpdateProductIDNew");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connect;
                command.Parameters.AddWithValue("@tblProduct", dt);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                Log.Error("Update ProductIDNew error:\r\n" + ex.ToString());
            }
        }
        #endregion
    }
}
