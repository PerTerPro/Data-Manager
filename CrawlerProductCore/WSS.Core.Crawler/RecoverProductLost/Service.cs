using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Entities.Data;
using StackExchange.Redis;
using Websosanh.Core.Drivers.Redis;

namespace WSS.Core.Crawler.RecoverProductLost
{
    public class Service
    {
        private readonly string connectionSource = "Data Source=172.22.1.83;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss;Password=HzlRt4$$axzG-*UlpuL2gYDu;Connect Timeout=5000";
        private readonly string connectionDestination = "Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
        private IDatabase database = null;
        public RedisKey KeyRedis = "recov_product";
        private ILog log = LogManager.GetLogger(typeof (Service));

        public Service()
        {
            while (database == null)
            {
                try
                {
                    var redisServer = RedisManager.GetRedisServer("redisVisitedCrcFN");
              
                    database = redisServer.GetDatabase(0);
                    return;
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                    Thread.Sleep(10000);
                }
            }
        }

        public void TransferData(long idStart)
        {
            HashSet<long> hsProductOld = this.GetHsOld();
            SqlDb sqlSource = new SqlDb(connectionSource);
            SqlDb sqlDestion = new SqlDb(connectionDestination);

            int countProduct = 0;
            sqlSource.ProcessDataTableLarge(string.Format("Select Id From Product p  where Id > {0} Order By p.Id", idStart), 10000, (row) =>
            {
                countProduct++;
                long productId = Common.Obj2Int64(row["Id"]);
                if (!hsProductOld.Contains(productId))
                {
                    DataRow rowProductInfo = sqlSource.GetTblData(string.Format("Select Id, Company, Price, Name, DetailUrl From Product where Id = {0}", productId), CommandType.Text, null).Rows[0];
                    long cmpId = Common.Obj2Int64(rowProductInfo["Company"]);
                    long prdId = Common.Obj2Int64(rowProductInfo["Id"]);
                    string name = Common.Obj2String(rowProductInfo["Name"]);
                    string urlDetail = Common.Obj2String(rowProductInfo["DetailUrl"]);
                    sqlDestion.RunQuery(@"insert into Product_LogsAddProduct (IDCompany, IDProduct, Name, Url, DateAdd) values (@IDCompany, @IDProduct, @Name, @Url, '2015-5-5')",
                        CommandType.Text, new[]
                        {
                            SqlDb.CreateParamteterSQL("IDCompany", cmpId, SqlDbType.BigInt),
                            SqlDb.CreateParamteterSQL("IDProduct", prdId, SqlDbType.BigInt),
                            SqlDb.CreateParamteterSQL("Name", name, SqlDbType.NVarChar),
                            SqlDb.CreateParamteterSQL("Url", urlDetail, SqlDbType.NVarChar),
                        });
                  
                }
                if (countProduct % 10000 == 0)
                    log.Info(string.Format("Process {0} lastProductId {1}", productId));
            });
        }

        private HashSet<long> GetHsOld()
        {
            HashSet<long> hst = new HashSet<long>();

            foreach (var VARIABLE in this.database.SetScan(this.KeyRedis, "*", 10000, CommandFlags.HighPriority))
            {
                hst.Add(Convert.ToInt64(VARIABLE));
                if (hst.Count%10000 == 0) log.Info(string.Format("Loaded {0}", hst.Count));
            }return hst;
        }

        public void PushToRedis(int startId)
        {
            List<long> lstTemp = new List<long>();
            HashSet<long> hstOld = this.GetHsOld();

            SqlDb sqlDb = new SqlDb(connectionDestination);
            sqlDb.ProcessDataTableLarge(string.Format("Select IDProduct, ID From Product_LogsAddProduct Where ID > {0} ORDER BY ID ",startId), 50000, (row) =>
            {
                long ID = Common.Obj2Int64(row["ID"]);
                long ProductId = Common.Obj2Int64(row["IDProduct"]);
                if (lstTemp.Count > 10000)
                {
                    UpProductIdsToRedis(lstTemp);
                    lstTemp.Clear();
                    log.Info(string.Format("LastID: {0}", ID));
                }

                if (!hstOld.Contains(ProductId))
                {
                    hstOld.Add(ProductId);
                    lstTemp.Add(ProductId);
                }
            
            });
        }
        private void UpProductIdsToRedis(List<long> hsTemp)
        {
            RedisValue[] rvs = new RedisValue[hsTemp.Count];
            for (int i = 0; i < rvs.Length; i++)
            {
                rvs[i] = hsTemp[i];
            }
            database.SetAdd(this.KeyRedis, rvs);
            
        }
    }
}
