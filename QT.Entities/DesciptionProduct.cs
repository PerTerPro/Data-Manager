using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities
{
    public class DesciptionProduct
    {
        public DesciptionProduct(Product pt)
        {
            this.FullDesc = pt.FullDescHtml;
            this.SpecsDesc = pt.SpecsDescHtml;
            this.VideoDesc = pt.VideoDescHtml;
            this.ShortDescription = pt.ShortDescription;
        }

        public long product_id { get; set; }
        public string FullDesc { get; set; }
        public string SpecsDesc { get; set; }
        public string VideoDesc { get; set; }
        public string ShortDescription { get; set; }
    }
}
