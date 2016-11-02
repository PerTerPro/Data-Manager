using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.Statistics.Object
{
    public class Product
    {
        public long ID { get; set; }
        public string  Name { get; set; }
        public string DetailUrl { get; set; }
        public string ImnageUrl { get; set; }
        public int Price { get; set; }
        public long Company { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public int TotalClick { get; set; }
    }
}
