using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.GetKeywordFromRabbitMQ
{
    public class MsProduct
    {
        public string ProductName { get; set; }
        public long ProductID { get; set; }
        public long[] ProductIDs { get; set; }
    }
}
