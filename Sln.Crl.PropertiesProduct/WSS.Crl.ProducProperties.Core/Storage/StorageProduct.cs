using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.LibExtra;
using Product = WSS.Crl.ProducProperties.Core.Entity.Product;

namespace WSS.Crl.ProducProperties.Core.Storage
{
    public class StorageProduct:IStorageProduct
    {
        private readonly SqlDb _sqlDb = new SqlDb(ConfigStatic.ProductConnection);

        public void ProcessProduct(string domain, EventHandler<Product> eventHandler)
        {
            this._sqlDb.ProcessDataTableLarge(string.Format(@" 
select 
--top 100  
pt.ID, pt.DetailUrl, x.Name as Classification
, pt.ClassificationID
from COmpany  c
inner join Product pt on c.id = pt.Company
inner join Classification x on x.ID = pt.ClassificationID
where domain = '{0}'
order by pt.ID
", domain), 10000, (obj, iRow) =>
            {
                eventHandler(this, new Product()
                {
                    Id = Convert.ToInt64(obj["ID"]),
                    DetailUrl = Convert.ToString(obj["DetailUrl"]),
                    ClassificationId = CommonConvert.Obj2Int64(obj["ClassificationID"]),
                    Classification = CommonConvert.Obj2String(obj["Classification"])
                });
                return true;
            });
        }
    }
}
