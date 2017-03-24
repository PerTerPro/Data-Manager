using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using WSS.LibExtra;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Service.Delete.ProductAdsScore
{
    public class Runner
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Runner));

        ProducerBasic _producer;
        private string _queueName = "";

        private string _connectinString;
        private int MAX_HOUR_LOOP = 24;
        private int HOUR_RUN = 1;
        DateTime NextRun = new DateTime();
        public Runner()
        {

            _connectinString = ConfigurationManager.AppSettings["ConnectionString"];
            _producer = new ProducerBasic(RabbitMQManager.GetRabbitMQServer("rabbitMqCrlProperties"), "Product.AdsScore.Deleted");
            MAX_HOUR_LOOP = CommonConvert.Obj2Int(ConfigurationManager.AppSettings["MAX_HOUR_LOOP"]);
            HOUR_RUN = CommonConvert.Obj2Int(ConfigurationManager.AppSettings["HOUR_RUN"]);
        }

        public void Run(System.Threading.CancellationToken token)
        {
            log.InfoFormat("start: {0}", DateTime.Now.ToString());
            int PageIndex = 1;
            using (IDbConnection db = new SqlConnection(_connectinString))
            {
                List<Entity.ProductAdsScore> lstProductAds = new List<Entity.ProductAdsScore>();
                do
                {
                    lstProductAds = db.Query<Entity.ProductAdsScore>(@"SELECT *
                                        FROM Product_AdsScore
                                        ORDER BY ProductId Desc
                                        OFFSET ((@PageIndex - 1) * @PageSize) ROWS
                                        FETCH NEXT @PageSize ROWS ONLY;", new { PageIndex = PageIndex, PageSize = 1000 }).ToList();

                    foreach (var item in lstProductAds)
                    {
                        if (CheckExists(item.ProductId) == false)
                        {
                            //db.Execute("Delete from Product_AdsScore where ProductId = @ProductId", new { ProductId = item.ProductId });
                            _producer.PublishString(new Entity.ProductAdsScore
                            {
                                ProductId = item.ProductId,
                                CompanyId = item.CompanyId,
                                Keyword = item.Keyword
                            }.GetJson());
                            log.InfoFormat("Product: {0} not exists", item.ProductId);
                        }
                    }
                    PageIndex++;
                } while (lstProductAds != null && lstProductAds.Count > 0);
                log.InfoFormat("Finish!");

                NextRun = DateTime.Now.AddHours(MAX_HOUR_LOOP);
                log.InfoFormat("End: {0}", DateTime.Now.ToString());

            }
        }


        private bool CheckExists(long ProductId)
        {
            using (IDbConnection db = new SqlConnection(_connectinString))
            {
                var product = db.Query<Entity.Product>("Select ID from Product where ID = @ID", new { ID = ProductId }).ToList();
                if (product != null && product.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }


        internal void Start(System.Threading.CancellationToken token)
        {
            while (true)
            {
                token.ThrowIfCancellationRequested();
                if (DateTime.Now.Hour == this.HOUR_RUN && NextRun < DateTime.Now)
                {
                    Run(token);
                }
                else
                {
                    log.InfoFormat("Running at {0} h. App run last {1} Minute", HOUR_RUN, (int)(DateTime.Now - NextRun).TotalMinutes);
                    token.WaitHandle.WaitOne(60000 * 5);
                }
            }
        }
    }
}
