using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    public class JobRabbitChangePrice
    {
        public long CompanyID { get; set; }

        public long ProductID { get; set; }

        public long OldPrice { get; set; }

        public long NewPrice { get; set; }

        public string Name { get; set; }

        public byte[] ToArrayByte()
        {
            return Encoding.UTF8.GetBytes(GetJSON());
        }

        public string GetJSON()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

    }

    public class JobMqChangeDesc
    {
        public long Id { get; set; }
        public string SpecDesc { get; set; }
        public string FullDesc { get; set; }
        public string ShortDesc { get; set; }
        public string VideoDesc { get; set; }

        public string GetJSON()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }

    public class JobRabbitAddProduct
    {
        public long ProductID { get; set; }

        public string DetailUrl { get; set; }

        public string Name { get; set; }

        public long IDCompnay { get; set; }

        public DateTime DateAdd { get; set; }
    }
}
