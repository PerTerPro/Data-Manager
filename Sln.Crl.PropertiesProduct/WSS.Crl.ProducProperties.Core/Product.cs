using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.ProducProperties.Core
{
    public class ProductE
    {
        public ProductE()
        {
            DicValue=new Dictionary<string, string>();
        }
        public long ProductId { get; set; }
        public Dictionary<string, string> DicValue { get; set; } 
    }
}
