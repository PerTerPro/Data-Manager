using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace WSS.Core.Crawler
{
    public class Parameter
    {
        public string QueueMQ { get; set; }
        public int NumberThread { get; set; }
        public int TypeRun { get; set; }
        public string Domain { get; set; }

        public void ParseData(string ars)
        {
            string[] ar = ars.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var VARIABLE in ar)
            {
                string[] ar1 =  VARIABLE.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                int i = 0;
                if (ar1[i] == "t")
                {
                    TypeRun = Convert.ToInt32(ar1[i + 1]);
                }
                else if (ar1[i] == "nt")
                {
                    NumberThread = Convert.ToInt32(ar1[i + 1]);
                }
                else if (ar1[i] == "dm")
                {
                    Domain = Convert.ToString(ar1[i + 1]);
                }
                else if (ar1[i] == "QueueMq")
                {
                    this.QueueMQ = Convert.ToString(ar1[i + 1]);
                }
                else if (ar1[i] == "ackIm")
                {
                    this.AckIm = Convert.ToInt32(ar1[i + 1]) == 1;
                }
            }

        }

        public bool AckIm { get; set; }
    }
}
