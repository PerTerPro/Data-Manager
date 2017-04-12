using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.MapProperties.Product.Has.ProductId.Entity
{
    public class Product
    {
        public long ID { get; set; }
        public long ClassificationID { get; set; }
        public long Company { get; set; }
        public string Domain { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string DetailUrl { get; set; }
        public string ImageUrls { get; set; }
        public int CategoryID { get; set; }
        public string ImageId { get; set; }
    }
}
