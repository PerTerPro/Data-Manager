using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.ImageServer.Service
{
    public class Parameter
    {
        public string Cmd { get; set; }
        public string[] Domain { get; set; }
        public int Thread { get; set; }


        internal static Parameter FromStr(string p)
        {
            return null;
        }
    }
}
