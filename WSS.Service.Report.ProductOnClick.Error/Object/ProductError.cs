using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.Report.ProductOnClick.Error.Object
{
    public class ProductError
    {
        public long ProductId { get; set; }
        public long CompanyId { get; set; }
        public string DetailUrl { get; set; }
        public DateTime DateLog { get; set; }
        public string Keyword { get; set; }
        public int Type { get; set; }
    }
}
