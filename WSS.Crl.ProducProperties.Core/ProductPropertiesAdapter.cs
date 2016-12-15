using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;
using QT.Entities.Data;

namespace WSS.Crl.ProducProperties.Core
{
    public class ProductPropertiesAdapter
    {
        private SqlDb sqlDb = new SqlDb(ConfigStatic.ProductConnection);

        public void SaveHtm(long productId, string html, string domain, string url)
        {                                            
        }

        public ConfigPropertySql GetConfig(long companyId)
        {
            DataTable tbl = this.sqlDb.GetTblData(@"
      SELECT TOP 1 c.[Id]
      ,c.[CompanyId]
      ,c.[TypeLayout]
      ,c.[XPath]
      ,c.[JSonOtherConfig]
      ,c.[JSonOtherConfigDemo]
	  ,c.UrlTest
	  , cf.CategoryXPath
  FROM [dbo].[Configuration_Property] c
  INNER JOIN Configuration cf ON cf.CompanyID = c.CompanyId
  Where c.CompanyId = @CompanyId", CommandType.Text, new SqlParameter[]
            {
                SqlDb.CreateParamteterSQL("@CompanyId", companyId, SqlDbType.BigInt)
            });
            if (tbl.Rows.Count > 0)
            {
                var row = tbl.Rows[0];
                return new ConfigPropertySql()
                {
                    CategoryXPath = Common.Obj2String(row["CategoryXPath"]),
                    CompanyId = Common.Obj2Int64(row["CompanyId"]),
                    JSonOtherConfig = Common.Obj2String(row["JSonOtherConfig"]),
                    TypeLayout = Common.Obj2Int(row["TypeLayout"]),
                    XPath = Common.Obj2String(row["XPath"]),
                    UrlTest = Common.Obj2String(row["UrlTest"])
                };
            }
            else
            {
                return null;
            }
        }

        internal void UpsertProduct(Product pt)
        {
            const string sqlDel = "Delete Product_PropertyValue Where ProductId = @ProductId";
            sqlDb.RunQuery(sqlDel, CommandType.Text, new[]
            {
                SqlDb.CreateParamteterSQL("ProductId", pt.ProductId, SqlDbType.BigInt)
            });
            foreach (var variable in pt.dicValue)
            {
                sqlDb.RunQuery("prc_ProductProperty_Ins", CommandType.StoredProcedure, new[]
                {
                    SqlDb.CreateParamteterSQL("@ProductId",pt.ProductId,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("@HashPropertyId",GABIZ.Base.Tools.getCRC32(variable.Key),SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@PropertyName",variable.Key,SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("@Value",variable.Value,SqlDbType.NVarChar),
                });
            }
        }
    }
}
