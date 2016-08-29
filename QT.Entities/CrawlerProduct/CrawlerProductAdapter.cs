using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    public class CrawlerProductAdapter
    {
        public Data.SqlDb sqlDb;
        public CrawlerProductAdapter(Data.SqlDb sqlDb)
        {
            // TODO: Complete member initialization
            this.sqlDb = sqlDb;
        }
        public CrawlerProductAdapter()
        {

        }

        /// <summary>
        /// Xóa Queue và VisitedLink của công ty này.
        /// </summary>
        /// <param name="p"></param>
        public bool ClearSessionCrawler(long p)
        {
            return true;
        }

        public void SaveLog(long ProductID, long NewPrice, long OldPrice)
        {
            bool bok = false;
            while (bok == false)
            {
               bok= this.sqlDb.RunQuery("Insert Into Price_Logs (ProductId, DateUpdate, NewPrice, OldPrice) Values (@ProductId, GetDate(), @NewPrice, @OldPrice)",
                    System.Data.CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@ProductId",ProductID,System.Data.SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("@NewPrice",NewPrice,System.Data.SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@OldPrice",OldPrice,System.Data.SqlDbType.Int)
                });
               if (bok == false) Thread.Sleep(10000);
            }
        }

        public void SaveLogAddProduct(long ProductID, string Name, long CompanyID, string URL, DateTime dtAdd)
        {
            this.sqlDb.RunQuery("insert into Product_LogsAddProduct (IDCOmpany, IDProduct, Name, URl, DateAdd) Values (@IDCompany, @IDProduct, @Name, @URL, @DateAdd)"
                , System.Data.CommandType.Text, new SqlParameter[]{
            SqlDb.CreateParamteterSQL("IDProduct",ProductID,System.Data.SqlDbType.BigInt),
            SqlDb.CreateParamteterSQL("Name",Name,System.Data.SqlDbType.NVarChar),
            SqlDb.CreateParamteterSQL("IDCompany",CompanyID,System.Data.SqlDbType.BigInt),
            SqlDb.CreateParamteterSQL("URL",URL,System.Data.SqlDbType.NVarChar),
            SqlDb.CreateParamteterSQL("DateAdd",dtAdd,System.Data.SqlDbType.DateTime)
            });
        }

        public void LogError(long IData, string Content)
        {
            this.sqlDb.RunQuery("Insert LogErrorCrawler (IDData, Content) Values (@IData, @Content)", System.Data.CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("IDData",IData,System.Data.SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("Content",Content,System.Data.SqlDbType.NVarChar)
                });
        }


        public DataTable GetVisitedCRC(long CompanyID)
        {
            string query = @"SELECT CRC
	FROM VisitedLinks
	WHERE Company=@CompanyID";
            return this.sqlDb.GetTblData(query, System.Data.CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("CompanyID",CompanyID,System.Data.SqlDbType.BigInt)
            });

        }
        public System.Data.DataTable GetVisitedLinkByCompany(long CompanyID, int PageIndex)
        {
            return this.sqlDb.GetTblData("prc_VisitedLink_GetByCompany", System.Data.CommandType.StoredProcedure, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("CompanyID",CompanyID,System.Data.SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("PageIndex",PageIndex,System.Data.SqlDbType.Int)
            }, null, true);
        }

        public System.Data.DataTable GetQueueOfCompany(long CompanyID, int PageIndex)
        {
            return this.sqlDb.GetTblData("prc_QueueLink_GetByCompany", System.Data.CommandType.StoredProcedure, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("CompanyID",CompanyID,System.Data.SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("PageIndex",PageIndex,System.Data.SqlDbType.Int)
            }, null, true);
        }

       public DataTable GetQueueOfCompany (long CompanyID)
        {
            string query = @"  	SELECT a.CRC, a.URL
	                            FROM [dbo].[QueueLinks] a
	                            WHERE Company=@CompanyID";
            return this.sqlDb.GetTblData(query, CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
           });
        }

        public void DeleteQueueLink(List<long> lstDeleteQueueLink)
        {
            string sql = "";
            string sqlDelACrc = "DELETE QueueLinks WHERE CRC = {0}";
            foreach(long crc in lstDeleteQueueLink)
            {
                sql += string.Format(sqlDelACrc, crc.ToString());
            }
            this.sqlDb.RunQuery(sql, System.Data.CommandType.Text, null, true);
        }
    }
}
