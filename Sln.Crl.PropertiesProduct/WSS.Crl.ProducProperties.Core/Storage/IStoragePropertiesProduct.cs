using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Crl.ProducProperties.Core.Entity;

namespace WSS.Crl.ProducProperties.Core.Storage
{
    public interface IStoragePropertiesProduct
    {
        void SaveProperiesProduct(PropertyProduct propertyData);
        Task<PropertyProduct> GetProperiesProduct(long productId);
        void DelProperiesProduct(long productId);
    }
}
