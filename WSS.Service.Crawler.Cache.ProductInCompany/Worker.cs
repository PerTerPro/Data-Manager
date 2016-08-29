using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.Crawler.Cache.ProductInCompany
{
    class Worker
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Worker));
        public void Run()
        {
            QT.Entities.Server.ConnectionString = @"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200";
            QT.Moduls.CrawlerProduct.Cache.RedisProductIDOfCompany redisProductInCompany = QT.Moduls.CrawlerProduct.Cache.RedisProductIDOfCompany.Instance();
            int countCompany = 0;
            SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);
            DataTable tblCompany = sqlDb.GetTblData("select id from company where status = 1 and datafeedtype = 0");
            foreach (DataRow rowComp in tblCompany.Rows)
            {
                countCompany++;
                long companyID = Convert.ToInt64(rowComp["id"]);
                DataTable tblProductID = sqlDb.GetTblData("select id from product where company = @company_id", CommandType.Text, new System.Data.SqlClient.SqlParameter[]{
                   SqlDb.CreateParamteterSQL("company_id",companyID,SqlDbType.BigInt)
                });
                if (tblProductID.Rows.Count > 0)
                {
                    List<long> lstproductid = new List<long>();
                    foreach (DataRow rowProduct in tblProductID.Rows)
                    {
                        lstproductid.Add(Convert.ToInt64(rowProduct["id"]));
                    }
                    redisProductInCompany.SetForCompany(companyID, lstproductid);
                }
                log.InfoFormat("{0} - {1}/{2}", companyID, countCompany, tblCompany.Rows.Count);
            }
        }
    }
}
