using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities.Data;

namespace WSS.Crl.ProducProperties.Core
{
    public class ProductPropertiesAdapter
    {
        private SqlDb sqlDb = new SqlDb(ConfigStatic.ProductPropertyConnection);

        public void SaveHtm(long productId, string html, string domain, string url)
        {                                            
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
