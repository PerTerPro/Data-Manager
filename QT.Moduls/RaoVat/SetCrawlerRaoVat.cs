using QT.Entities.Data;
using QT.Moduls.Crawler;
using System.Data.SqlClient;
public class SetCrawlerRaoVat : ISetAddedVisited
{
    private SqlDb sqlDb;
    int configID = 0;
    int typeCrawler = 0;

    public SetCrawlerRaoVat(SqlDb sqlDb, int configID, int typeCrawler)
    {
        this.sqlDb = sqlDb;
        this.configID = configID;
        this.typeCrawler = typeCrawler;
    }

    public bool Exists(int p)
    {
        return this.sqlDb.GetTblData("Select * from visitedpage where configid = @configid and CrcUrl=@CrcUrl and TypeCrawler=@TypeCrawler"
            , System.Data.CommandType.Text,
            new SqlParameter[] { 
                SqlDb.CreateParamteterSQL("ConfigID",configID,System.Data.SqlDbType.Int),
                SqlDb.CreateParamteterSQL("CrcUrl",p,System.Data.SqlDbType.Int)
               ,SqlDb.CreateParamteterSQL("TypeCrawler",typeCrawler,System.Data.SqlDbType.Int)}).Rows.Count > 0;

    }

    public void Add(int p, string url)
    {
        this.sqlDb.RunQuery("Insert Into VisitedPage (ConfigID, TypeCrawler, CrcUrl, Url) values (@ConfigID, @TypeCrawler, @CrcUrl, @Url)",
            System.Data.CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("ConfigID",this.configID,System.Data.SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("TypeCrawler",this.typeCrawler,System.Data.SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("CrcUrl",p,System.Data.SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("Url",url,System.Data.SqlDbType.NVarChar)
                });
    }

    public void Clean()
    {
        this.sqlDb.RunQuery("Delete From VisistedPage Where ConfigID = @COnfigID And TypeCrawler=@TypeCrawler"
            , System.Data.CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("ConfigID",this.configID,System.Data.SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("TypeCrawler",this.typeCrawler,System.Data.SqlDbType.Int)
                });
    }


}