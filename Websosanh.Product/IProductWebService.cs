using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websosanh.Product
{
    public interface IProductWebService
    {
        void PushMqToRedisProduct(long productId);
        void PushMqToSoldProduct(long productId);
    }
}
