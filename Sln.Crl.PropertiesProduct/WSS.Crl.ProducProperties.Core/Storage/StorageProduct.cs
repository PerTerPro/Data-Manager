using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.LibExtra;
using Product = WSS.Crl.ProducProperties.Core.Entity.Product;

namespace WSS.Crl.ProducProperties.Core.Storage
{
    public class StorageProduct : IStorageProduct
    {
        private readonly SqlDb _sqlDb = new SqlDb(ConfigStatic.ProductConnection);

        public void ProcessProduct(string domain, EventHandler<Product> eventHandler)
        {

            long companyID = CommonConvert.Obj2Int64(this._sqlDb.GetTblData((string.Format("select ID from Company where Domain = '{0}'", domain))).Rows[0]["ID"]);
            this._sqlDb.ProcessDataTableLarge(string.Format(@"
select 
--top 1000  
pt.ID, pt.DetailUrl
from  Product pt
where pt.Company = {0}
order by pt.ID
", companyID),
 1000, (obj, iRow) =>
            {
                eventHandler(this, new Product()
                {
                    Id = Convert.ToInt64(obj["ID"]),
                    DetailUrl = Convert.ToString(obj["DetailUrl"]),
                    ClassificationId = 0,// CommonConvert.Obj2Int64(obj["ClassificationID"]),
                    Classification = ""//Convert.Obj2String(obj["Classification"])
                });
                return true;
            });
        }
    }
}
