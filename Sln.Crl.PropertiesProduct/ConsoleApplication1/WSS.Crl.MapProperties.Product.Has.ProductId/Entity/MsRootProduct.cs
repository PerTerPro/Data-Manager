using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.MapProperties.Product.Has.ProductId.Entity
{
    public class MsRootProduct
    {
        public int RootID { get; set; }
        public string GetJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MsRootProduct FromJson(string str)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MsRootProduct>(str);
        }
    }
}
