using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.RaoVat
{
    public class RaoVatClassification
    {
        public RaoVatClassification ()
        {
            city_ids = new int[] { };
            category_ids = new int[] { };
        }

        public int[] city_ids { get; set; }
        public long id { get; set; }
        public string name { get; set; }
        public int website_id { get; set; }

        public int[] category_ids { get; set; }
    }
}
