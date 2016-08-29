using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct.Comment
{
    public  class JobComment
    {
        public long CompanyId { get; set; }

        public long ProductId { get; set; }
        public string Url { get; set; }

        public byte[] ToArbyteJSON()
        {
            return Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(this));
        }
    }
}
