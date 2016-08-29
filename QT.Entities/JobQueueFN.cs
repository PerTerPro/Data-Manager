using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities
{
    public class JobQueueFN
    {
        public long id;
        public string url { get; set; }
        public int deep { get; set; }
        public long link_parent { get; set; }

        public long GetID()
        {
            return QT.Entities.Common.CrcProductID(url);
        }
    }
}
