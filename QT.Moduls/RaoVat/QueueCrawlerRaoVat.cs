using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.Crawler;
using System;
using System.Data;
using System.Data.SqlClient;
namespace QT.Moduls.RaoVat
{
    public class QueueCrawlerRaoVat : IQueueWait
    {
        private SqlDb sqlDb;
        int configID = 0;
        int typeCrawler = 0;


        public QueueCrawlerRaoVat(SqlDb sqlDb, int configID, int typeCrawler)
        {
            this.sqlDb = sqlDb;
            this.configID = configID;
            this.typeCrawler = typeCrawler;
        }

        public void PushJob(QT.Moduls.Crawler.Job mss)
        {
            this.sqlDb.RunQuery(@"Insert Into QueueWait (ConfigID, TypeCrawler, CrcUrl, Url, Deep) 
                                  Values (@ConfigID, @TypeCrawler, @CrcUrl, @Url, @Deep)", System.Data.CommandType.Text,
                new SqlParameter[]{
                SqlDb.CreateParamteterSQL("ConfigID",configID,System.Data.SqlDbType.Int)
                , SqlDb.CreateParamteterSQL("TypeCrawler",typeCrawler,System.Data.SqlDbType.Int)
                , SqlDb.CreateParamteterSQL("Url",mss.url,System.Data.SqlDbType.NVarChar)
                , SqlDb.CreateParamteterSQL("Deep",mss.deep,System.Data.SqlDbType.Int)
                , SqlDb.CreateParamteterSQL("CrcUrl",Math.Abs(GABIZ.Base.Tools.getCRC32(Common.CompactUrl(mss.url))),System.Data.SqlDbType.Int)
                });
        }

        public Job GetJob()
        {
            while (true)
            {
                DataTable tblJob = this.sqlDb.GetTblData("SELECT TOP 1 * FROM QueueWait Where ConfigId = @ConfigId And TypeCrawler = @TypeCrawler Order By Deep Asc",
                    CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@ConfigId",this.configID,SqlDbType.Int),
                SqlDb.CreateParamteterSQL("@TypeCrawler",this.typeCrawler,SqlDbType.Int)
                });
                if (tblJob.Rows.Count > 0)
                {
                    this.sqlDb.RunQuery("DELETE FROM QueueWait Where ConfigId = @ConfigId And TypeCrawler=@TypeCrawler And CrcUrl = @CrcUrl", CommandType.Text,
                        new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("ConfigId",this.configID,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("TypeCrawler",this.typeCrawler,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("CrcUrl",Convert.ToInt64(tblJob.Rows[0]["CrcUrl"]),SqlDbType.BigInt)
                    });
                    return new QT.Moduls.Crawler.Job()
                    {
                        ConfigID = this.configID,
                        deep = Convert.ToInt32(tblJob.Rows[0]["Deep"]),
                        ProductId = 0,
                        url = tblJob.Rows[0]["Url"].ToString()
                    };
                }
                else return null;
            }
        }
    }
}