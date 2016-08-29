using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.SaleNews
{
    public class ConfigBaseClass
    {
        public List<string> PriceXPaths { get; set; }
        public List<string> PostDateXPaths { get; set; }
        public List<string> LastChangeXPaths { get; set; }
        public List<string> CategoryXPaths { get; set; }
    }
}
