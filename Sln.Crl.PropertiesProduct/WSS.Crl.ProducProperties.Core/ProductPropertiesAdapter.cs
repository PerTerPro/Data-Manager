using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.LibExtra;

namespace WSS.Crl.ProducProperties.Core
{
    public class ProductPropertiesAdapter
    {
        private SqlDb sqlDbProperties = new SqlDb(ConfigStatic.ProductPropertyConnection);
        private SqlDb sqlDbProduct = new SqlDb(ConfigStatic.ProductConnection);

        public void SaveHtm(long productId, string html, string domain, string url)
        {                                            
        }

        public ConfigProperty GetConfig(long companyId)
        {
            DataTable tbl = this.sqlDbProduct.GetTblData(@"
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
                return new ConfigProperty()
                {
                    CategoryXPath = CommonConvert.Obj2String(row["CategoryXPath"]),
                    CompanyId = CommonConvert.Obj2Int64(row["CompanyId"]),
                    JSonOtherConfig = CommonConvert.Obj2String(row["JSonOtherConfig"]),
                    TypeLayout = CommonConvert.Obj2Int(row["TypeLayout"]),
                    XPath = CommonConvert.Obj2String(row["XPath"]),
                    UrlTest = CommonConvert.Obj2String(row["UrlTest"]),
                    Domain = CommonConvert.Obj2String(row["Domain"]),
                    RemoveLastItemClassification = CommonConvert.Obj2Bool(row["RemoveLastItemClassification"])
                };
            }
            else
            {
                return null;
            }
        }

        internal void UpsertProduct(ProductE pt)
        {
            const string sqlDel = "Delete Product_PropertyValue Where ProductId = @ProductId";
            sqlDbProperties.RunQuery(sqlDel, CommandType.Text, new[]
            {
                SqlDb.CreateParamteterSQL("ProductId", pt.ProductId, SqlDbType.BigInt)
            });
            foreach (var variable in pt.DicValue)
            {
                sqlDbProperties.RunQuery("prc_ProductProperty_Ins", CommandType.StoredProcedure, new[]
                {
                    SqlDb.CreateParamteterSQL("@ProductId",pt.ProductId,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("@HashPropertyId",GABIZ.Base.Tools.getCRC32(variable.Key),SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@PropertyName",variable.Key,SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("@Value",variable.Value,SqlDbType.NVarChar),
                });
            }
        }

        public void InsertCategory(long ID, string Name, long comanyId, long categoryId)
        {
            this.sqlDbProperties.RunQuery(@"
If Not Exists (Select Id From Product_PropertyCategory pc Where pc.Id = @ID)
Begin
    Insert Into Product_PropertyCategory (Id, Name, CompanyId, CategoryId)
    Values (@ID, @Name, @CompanyId, @CategoryId)
End

", CommandType.Text, new SqlParameter[]
            {
                SqlDb.CreateParamteterSQL("@ID", ID, SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@CompanyId", comanyId, SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@Name", Name, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@CategoryId", categoryId, SqlDbType.BigInt)
            });
        }

        public  DataTable GetCategoryConfigByCompany(long p)
        {
            return null;
        }

        public void FattanToSql(PropertyProduct propertyData)
        {
            foreach (var VARIABLE in propertyData.Properties)
            {
                string propertyName = propertyData.Category + ":" + VARIABLE.Key;
                long propertyID = CommonConvert.CrcProductID(propertyName);
                bool bOk = this.sqlDbProperties.RunQuery("sp_Property_Ins", CommandType.StoredProcedure, new[]
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
