using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.SaleNews
{
    public class RealEstate : QT.Entities.Model.SaleNews.BaseClass
    {
        public override string ToString()
        {
            return string.Format("ID:{0}\nTitle:{1}\nPrice:{2}\nPostDate:{3}\nLastChange:{4}",
                ID.ToString(), Title.ToString(), Price.ToString(), PostDate.ToString(), LastChange.ToString());
        }

        public RealEstate ()
        {
            StateAnalysic = 0;
        }

        /// <summary>
        /// 0-0 Xác đinh. 1-OK.
        /// </summary>
        public int StateAnalysic { get; set; }

        public decimal Area { get; set; }
        public decimal Cash { get; set; }
        public string Direction { get; set; }
        /// <summary>
        /// Hướng ban công
        /// </summary>
        public string BalconyDirection { get; set; }
        public string NumberFloor { get; set;  }
        public string NumberBedroom { get; set; }
        public string NumberToilet { get; set; }
        /// <summary>
        /// Nội thất
        /// </summary>
        public string Furrniture { get; set; }

        public string Url { get; set; }

        public string Content { get; set; }

        public string Location { get; set; }
    }
}
