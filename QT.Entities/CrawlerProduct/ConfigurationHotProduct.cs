using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolrNet.Impl.FieldParsers;

namespace QT.Entities.CrawlerProduct
{
    public class ConfigurationHotProduct
    {
        public string HotProduct_Xpath { get; set; }
        public string HotProduct_Link { get; set; }
        public long CompanyId { get; set; }
        public bool HotProduct_UseSelenium { get; set; }
    }
}
