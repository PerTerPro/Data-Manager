using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WSS.Crl.ProducProperties.Core.Entity;

namespace WSS.Crl.ProducProperties.Core.Storage
{
    public interface IStorageProduct
    {
        void ProcessProduct(string domain, EventHandler<Product> evetnHandler);
    }
}
