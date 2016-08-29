using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.SaleNews
{
    public class PhoneComputer:BaseClass
    {
        public PhoneComputer ()
        {
            Quality = "";

        }

        public override string ToString()
        {
            return string.Format("\nID:{0}\nCategory:{10}\nTitle:{1}\nPrice:{2}\nPostDate:{3}\nLastChange:{4}\nLocation:{5}\nPhoneSaler:{7}\nQuality:{8}\nAddress:{9}\nContent:{6}",
                ID.ToString()
                , Title.ToString()
                , Price.ToString()
                , PostDate.ToString()
                , LastChange.ToString()
                , Location
                , Content
                , PhoneSaler
                , Quality
                , Address
                , Category
                );
        }
        public string Marker { get; set; }
        public string TypeSim { get; set; }
        public string NumberSim{get; set;}
        public string OS { get; set; }
        public string SizeScreen { get; set; }
        public string TypeScreen { get; set; }
        public string Resolution { get; set; }
        public string PhoneSaler { get; set; }

        public string Address { get; set; }

        public string Quality { get; set; }
    }
}
