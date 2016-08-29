using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Model.SaleNews
{
    public class Vehicle : QT.Entities.Model.SaleNews.BaseClass
    {
        public override string ToString()
        {
            return string.Format("PostDate:{0}\nLastChange:{1}Title:{2}\nPrice:{3}", PostDate, LastChange, Title, Price);
        }

        public string Carmarker { get; set; }
        public string Model { get; set; }
        public int YearPublish { get; set; }
        public int KmDriven { get; set; }
        public string Fuel { get; set; }
        public string NumberSeat { get; set; }
        public string NumberWindow { get; set; }
        public string SteeringWheel { get; set; }

        
    }
}
