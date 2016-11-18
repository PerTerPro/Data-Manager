using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.ProducProperties.Core
{
    public class Product
    {
        public Product()
        {
            dicValue=new Dictionary<string, string>();
        }
        public long ProductId { get; set; }
        public Dictionary<string, string> dicValue { get; set; } 
    }
}
