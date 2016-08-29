using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.SaleNews
{
    public class BaseClass
    {
        public BaseClass ()
        {
            PostDate = SqlDb.MinDateDb;
            LastChange = SqlDb.MinDateDb;
        }

        public long ID { set; get; }
        public int CategoryID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime LastChange { get; set; }

        public string Content { get; set; }

        public string Location { get; set; }

        public string Url { get; set; }



        public string PhoneSaler { get; set; }

        public string Address { get; set; }

        public string Quality { get; set; }
    }
}
