using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Data
{
    public class ProductLogAddAdapter
    {
        SqlDb sqlDb = null;
        log4net.ILog log = null;

        public ProductLogAddAdapter(SqlDb sqlDb)
        {
            this.sqlDb = sqlDb;
            this.log = log4net.LogManager.GetLogger(typeof(ProductLogAddAdapter));
        }

        public void InsertLogAddProduct(long companyID, long productID, string productName, string productDetailUrl)
        {
            try
            {
                this.sqlDb.RunQuery(@"INSERT [dbo].[Product_LogsAddProduct] (IDCompany, 
                    IDProduct, Name, URL, DateAdd) VALUES (@IDCompany, 
                    @IDProduct, @Name, @URL, GETDATE())", System.Data.CommandType.Text,
                    new SqlParameter[]{
                        this.sqlDb.CreateParamteter("@IDCompany",companyID,System.Data.SqlDbType.BigInt),
                        this.sqlDb.CreateParamteter("@IDProduct",productID,System.Data.SqlDbType.BigInt),
                        this.sqlDb.CreateParamteter("@Name",productName,System.Data.SqlDbType.NVarChar),
                        this.sqlDb.CreateParamteter("@URL",productDetailUrl,System.Data.SqlDbType.NVarChar)
                    });
            }
            catch (Exception ex)
            {
                this.log.ErrorFormat("Error when InsertLogAddProduct ", ex.Message);
            }
        }
    }
}
