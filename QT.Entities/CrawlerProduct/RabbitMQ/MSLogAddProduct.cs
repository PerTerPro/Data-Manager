using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct.RabbitMQ
{
    [ProtoBuf.ProtoContract]
    public class MSLogAddProduct
    {
        public MSLogAddProduct(Product productNew)
        {
            this.Id = productNew.ID;
            this.Name = productNew.Name;
            this.ImageUrl = productNew.ImageUrl;
            this.Price = productNew.Price;
            this.HashChange = productNew.GetHashChange();
        }

        public string ImageUrl { get; set; }

        public long Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public long HashChange { get; set; }

        public byte[] GetArByte()
        {
            throw new NotImplementedException();
        }
    }
}
