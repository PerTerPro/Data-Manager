using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraRichEdit.Model;
using QT.Entities;
using QT.Entities.Data;

namespace WSS.Crl.ProducProperties.Core
{
    public class ProductPropertiesAdapter
    {
        private SqlDb sqlDb = new SqlDb(ConfigStatic.ProductPropertyConnection);

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
      , co.Domain
      , cf.RemoveLastItemClassification
  FROM [dbo].[Configuration_Property] c
  INNER JOIN Configuration cf ON cf.CompanyID = c.CompanyId
  INNER JOIN Company co ON co.Id = cf.CompanyId
  Where c.CompanyId = @CompanyId"

                , CommandType.Text, new SqlParameter[]
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
                    UrlTest = Common.Obj2String(row["UrlTest"]),
                    Domain = Common.Obj2String(row["Domain"]),
                    RemoveLastItemClassification = Common.Obj2Bool(row["RemoveLastItemClassification"])
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

        public void InsertCategory(long ID, string Name, long comanyId)
        {
            this.sqlDb.RunQuery(@"
If Not Exists (Select Id From Product_PropertyCategory pc Where pc.Id = @ID)
Begin
    Insert Into Product_PropertyCategory (Id, Name, CompanyId)
    Values (@ID, @Name, @CompanyId)
End

", CommandType.Text, new SqlParameter[]
            {
                SqlDb.CreateParamteterSQL("@ID", ID, SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@CompanyId", comanyId, SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@Name", Name, SqlDbType.NVarChar)
            });
        }

        public  DataTable GetCategoryConfigByCompany(long p)
        {
            return null;
        }

        public void FattanToSql(PropertyData propertyData)
        {
            foreach (var VARIABLE in propertyData.Properties)
            {
                string propertyName = propertyData.Category + ":" + VARIABLE.Key;
                long propertyID = Common.CrcProductID(propertyName);
                bool bOk = this.sqlDb.RunQuery("sp_Property_Ins", CommandType.StoredProcedure, new[]
                {
                    SqlDb.CreateParamteterSQL("CategoryID", propertyData.CategoryId, SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("CategoryName", propertyData.Category, SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("ProperyID", propertyID, SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("ProperyValue", VARIABLE.Value, SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("CompanyID", propertyData.CompanyID, SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("ProductID", propertyData.ProductId, SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("PropertyName", propertyName, SqlDbType.NVarChar),
                });
            }
        }
    }
}
