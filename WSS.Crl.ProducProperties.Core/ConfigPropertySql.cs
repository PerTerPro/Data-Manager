using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.ProducProperties.Core
{
    public class ConfigPropertySql
    {
        public long CompanyId { get; set; }
        public int TypeLayout { get; set; }
        public string XPath { get; set; }
        public string JSonOtherConfig { get; set; }

        public string CategoryXPath { get; set; }

        public string UrlTest { get; set; }

        public string Domain { get; set; }
        public bool RemoveLastItemClassification { get; set; }
    }
}
