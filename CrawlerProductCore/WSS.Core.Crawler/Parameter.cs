using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace WSS.Core.Crawler
{
    public class Parameter
    {
        public int NumberThread { get; set; }
        public int TypeRun { get; set; }
        public string Domain { get; set; }

        public void ParseData(string[] ar)
        {
            for (var i = 0; i < ar.Length; i = i + 2)
            {
                if (ar[i] == "-t")
                {
                    TypeRun = Convert.ToInt32(ar[i + 1]);
                }
                else if (ar[i] == "-nt")
                {
                    NumberThread = Convert.ToInt32(ar[i + 1]);
                }
                else if (ar[i] == "-dm")
                {
                    Domain = Convert.ToString(ar[i + 1]);
                }
            }
        }
    }
}
