using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.MapProperties.Product.Has.ProductId.Entity
{
    public class RootProperty
    {
        public long ProductID { get; set; }
        public int PropertiesID { get; set; }
        public int PropertiesGroupID { get; set; }
        public int PropertiesValueID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }
    }
}
