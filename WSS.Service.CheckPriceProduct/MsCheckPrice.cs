using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.CheckPriceProduct
{
    class MsCheckPrice
    {
        public decimal price { get; set; }
        public string productName { get; set; }

        internal static MsCheckPrice FromJSON(string strData)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MsCheckPrice>(strData);
        }
    }
}
