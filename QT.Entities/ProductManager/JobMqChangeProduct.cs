using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.ProductManager
{
    public class JobMqChangeProduct
    {
        public long ProductId { get; set; }
        public Product ProductOrigin { get; set; }
        public Product ProductAfter { get; set; }
    }
}
