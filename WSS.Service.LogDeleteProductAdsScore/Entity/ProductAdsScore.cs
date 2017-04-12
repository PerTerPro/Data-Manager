using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.LogDeleteProductAdsScore.Entity
{
    public class ProductAdsScore
    {
        public long ProductId { get; set; }
        public long CompanyId { get; set; }
        public string Keyword { get; set; }
    }
}
