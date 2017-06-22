using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websosanh.Datafeed.Model
{
    public interface IProductRepository
    {
        HashSet<long> GetProductIds(long companyId);
    }
}