using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.SaleNews
{
    public class LogErrorToDb
    {
        static LogErrorToDb errorCode = new LogErrorToDb();
        public static LogErrorToDb Instance
        {
            get
            {
                return errorCode == null ? errorCode = new LogErrorToDb() : errorCode;

            }
        }

        public LogErrorToDb()
        {
            try
            {
                sqlDb = new Data.SqlDb(QT.Entities.Server.ConnectionStringCrawler);
            }
            catch (Exception ex)
            {

            }
        }


        static Data.SqlDb sqlDb = null;

        public static string errorParsePostDate = "errorParsePostDate";
        public static string errorParseTitleProduct = "errorParseTitleProduct";
        public static string errorParseWebCategory = "errorParseWebCategory";
        public static string errorRegonizeCategory = "errorRegonizeCategory";
        public static string errorParseContent = "errorParseContent";
        public static string errorParseImage = "errorParseImage";
        public static string errorParseProduct = "errorParseProduct";



        private static void ConnectToDb()
        {
            try
            {
                sqlDb = new Data.SqlDb(QT.Entities.Server.ConnectionString);
            }
            catch (Exception ex)
            {

            }
        }

        public void SaveError(string code, string url, int configID, string detail)
        {
            try
            {
                if (sqlDb == null) sqlDb = new Data.SqlDb(QT.Entities.Server.ConnectionStringCrawler);
                sqlDb.RunQuery("INSERT INTO [dbo].[LogErrorCrawl] ([id],[code],[detail],[configId], [url]) values (@id, @code, @detail, @configid, @url)",
                    System.Data.CommandType.Text, new SqlParameter[]{
                    sqlDb.CreateParamteter("id",Guid.NewGuid().ToString(),System.Data.SqlDbType.NVarChar),
                    sqlDb.CreateParamteter("code",code,System.Data.SqlDbType.NVarChar),
                    sqlDb.CreateParamteter("url",url,System.Data.SqlDbType.NVarChar),
                    sqlDb.CreateParamteter("detail",detail,System.Data.SqlDbType.NVarChar),
                    sqlDb.CreateParamteter("configid",configID,System.Data.SqlDbType.NVarChar),

                });
            }
            catch (Exception ex)
            {
                log.ErrorFormat("{0}", ex.Message);
            }
        }

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(LogErrorToDb));
        public static string errorParsePrice = "errorParsePrice";
        public static string errorSaveDelProduct = "errorSaveDelProduct";
        public static string errorExceptionConsumer = "errorExceptionConsumer";
    }
}
