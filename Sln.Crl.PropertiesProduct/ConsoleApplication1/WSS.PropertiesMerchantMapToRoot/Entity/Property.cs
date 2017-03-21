using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.PropertiesMerchantMapToRoot.Entity
{
    public class Property
    {
        public int ID { get; set; }
        public bool Valid { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
