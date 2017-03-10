using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Image.GetSize.Object
{
    public class Product
    {
        public int Count { get; set; }
        public long ID { get; set; }
        public string ImageUrls { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
    }
}
