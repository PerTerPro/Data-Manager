using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Product;

namespace Websosanh.Product
{
    public interface IProductRepository
    {
        void SetStatus(long productId, EStatusProduct statusProduct);
        Product GetProduct(long productId);
    }
}
