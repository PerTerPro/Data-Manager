using System.Data;
using System.Data.SqlClient;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.LibExtra;

namespace WSS.Crl.ProducProperties.Core.Storage
{
    public class StorageConfigCrl : IStorageConfigCrl
    {
        private readonly SqlDb _sqlDbProduct = new SqlDb(ConfigStatic.ProductConnection);

        public Entity.ConfigProperty GetConfig(string domain)
        {
            DataTable tbl = this._sqlDbProduct.GetTblData(@"
      SELECT TOP 1 c.[Id]
      ,c.[CompanyId]
      ,c.[TypeLayout]
      ,c.[XPath]
      ,c.[JSonOtherConfig]
      ,c.[JSonOtherConfigDemo]
	  ,c.UrlTest
	  , cf.CategoryXPath
      , co.Domain
      , cf.RemoveLastItemClassification
      , cf.TimeDelay
  FROM [dbo].[Configuration_Property] c
  INNER JOIN Configuration cf ON cf.CompanyID = c.CompanyId
  INNER JOIN Company co ON co.Id = cf.CompanyId
  Where co.Domain = @CompanyId"
                , CommandType.Text, new SqlParameter[]
            {
                SqlDb.CreateParamteterSQL("@CompanyId", domain, SqlDbType.NVarChar)
            });
            if (tbl.Rows.Count > 0)
            {
                var row = tbl.Rows[0];
                return new ConfigProperty()
                {
                    CategoryXPath = CommonConvert.Obj2String(row["CategoryXPath"]),
                    CompanyId = CommonConvert.Obj2Int64(row["CompanyId"]),
                    JSonOtherConfig = CommonConvert.Obj2String(row["JSonOtherConfig"]),
                    TypeLayout = CommonConvert.Obj2Int(row["TypeLayout"]),
                    XPath = CommonConvert.Obj2String(row["XPath"]),
                    UrlTest = CommonConvert.Obj2String(row["UrlTest"]),
                    Domain = CommonConvert.Obj2String(row["Domain"]),
                    RemoveLastItemClassification = CommonConvert.Obj2Bool(row["RemoveLastItemClassification"]),
                    TimeDelay = CommonConvert.Obj2Int(row["TimeDelay"])
                };
            }
            else
            {
                return null;
            }
        }




        public void Save(ConfigProperty conf)
        {
            var bOk = this._sqlDbProduct.RunQuery(@"

Update Configuration 
set CategoryXPath = @CategoryXPath
Where CompanyID = @CompanyId

IF Not Exists (Select Id From Configuration_Property cp Where CompanyId = @CompanyId)
Begin
    Insert Into Configuration_Property  (CompanyId, TypeLayout, XPath, JSonOtherConfig, UrlTest)
    Values (@CompanyId, @TypeLayout, @XPath, @JSonOtherConfig, @UrlTest)
End
Else 
Begin
    Update Configuration_Property Set TypeLayout=@TypeLayout, XPath=@XPath, JSonOtherConfig=@JSonOtherConfig, UrlTest = @UrlTest
    WHere CompanyId = @CompanyId
End
"
               , CommandType.Text, new SqlParameter[]
            {
                SqlDb.CreateParamteterSQL("CompanyId", conf.CompanyId, SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("TypeLayout", conf.TypeLayout, SqlDbType.Int),
                SqlDb.CreateParamteterSQL("XPath", conf.XPath, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("JSonOtherConfig", conf.JSonOtherConfig, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("CategoryXPath", conf.CategoryXPath, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("UrlTest", conf.UrlTest, SqlDbType.NVarChar),
            });
        }

      
    }
}
