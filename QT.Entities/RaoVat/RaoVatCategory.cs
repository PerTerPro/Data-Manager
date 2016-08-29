using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.RaoVat
{
    public class RaoVatCategory
    {
        public int id { get; set; }
        public string name { get; set; }
        public int parent_id { get; set; }
        public string slug { get; set; }
        public int level { get; set; }

        public string path { get; set; }
    }
}
