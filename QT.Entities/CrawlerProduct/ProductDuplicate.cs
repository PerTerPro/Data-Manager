using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    public class ProductDuplicate
    {
        public long Id { get; set; }
        public long CId { get; set; }
        public long IdDup { get; set; }
        public long Hash { get; set; }
        public string Url { get; set; }
    }
}
