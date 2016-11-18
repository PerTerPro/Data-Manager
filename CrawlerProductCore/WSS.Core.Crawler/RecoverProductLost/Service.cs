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
        private string connectionSource = "Data Source=172.22.1.83;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss;Password=HzlRt4$$axzG-*UlpuL2gYDu;Connect Timeout=5000";
        private string connectionDestination = "Data Source=172.22.30.86,1455;Initial Catalog=QT_2;Persist Security Info=True;User ID=qt_vn;Password=@F4sJ=l9/ryJt9MT;connection timeout=200";
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
            SqlDb sqlDb = new SqlDb(connectionSource);
            sqlDb.ProcessDataTableLarge(string.Format("Select Id From Product p Order By p.Id where Id > {0}",idStart), 10000, (row) =>
            {
                long productId = Common.Obj2Int64(row["Id"]);
                if (!hsProductOld.Contains(productId))
                {
                    DataRow rowProductInfo = sqlDb.GetTblData(string.Format("Select Id, Company, Price, Name, DetailUrl From Product where Id = {0}", productId), CommandType.Text, null).Rows[0];
                    long cmpId = Common.Obj2Int64(rowProductInfo["Company"]);
                    long prdId = Common.Obj2Int64(rowProductInfo["Id"]);
                    string name = Common.Obj2String(rowProductInfo["Name"]);
                    string urlDetail = Common.Obj2String(rowProductInfo["DetailUrl"]);
                    sqlDb.RunQuery(@"insert into Product_LogsAddProduct(IDCompany, IDProduct, Name, Url, DateAdd) values (@IDCompany, @IDProduct, Name, @Url, '2015-5-5')",
                        CommandType.Text, new[]
                        {
                            SqlDb.CreateParamteterSQL("IDCompany", cmpId, SqlDbType.BigInt),
                            SqlDb.CreateParamteterSQL("IDProduct", prdId, SqlDbType.BigInt),
                            SqlDb.CreateParamteterSQL("Name", name, SqlDbType.NVarChar),
                            SqlDb.CreateParamteterSQL("Url", urlDetail, SqlDbType.NVarChar),
                        });
                }
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

        public void PushToRedis()
        {
        
            List<long> lstTemp = new List<long>();
            HashSet<long> hstOld = this.GetHsOld();

            SqlDb sqlDb = new SqlDb(connectionDestination);
            sqlDb.ProcessDataTableLarge("Select IDProduct, ID From Product_LogsAddProduct Where ID > 12970000 ORDER BY ID ", 10000, (row) =>
            {
                long IDProduct = Common.Obj2Int64(row["ID"]);
                if (lstTemp.Count > 10000)
                {
                    UpProductIdsToRedis(lstTemp);
                    lstTemp.Clear();
                    log.Info(string.Format("LastID: {0}", IDProduct));
                }

                if (!hstOld.Contains(IDProduct))
                {
                    hstOld.Add(IDProduct);
                    lstTemp.Add(IDProduct);
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
