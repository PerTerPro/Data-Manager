using System;

namespace WSS.Service.Report.ProductOnClick.Error.Entity
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
