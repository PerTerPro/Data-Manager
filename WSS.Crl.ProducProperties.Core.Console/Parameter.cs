using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;

namespace WSS.Crl.ProducProperties
{
    public class Parameter
    {
        private string p;
        public IEnumerable<string> domains;

        public Parameter()
        {
            cmd = "";
            thread = 1;
        }


        public Parameter(string p)
            : base()
        {
            string[] arCmd = p.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var VARIABLE in arCmd)
            {
                string[] ar1 = VARIABLE.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (ar1[0] == "c")
                {
                    this.cmd = ar1[1];
                }
                else if (ar1[0] == "t")
                {
                    this.thread = 1;
                }
                else if (ar1[0] == "cat")
                {
                    this.CatId = Convert.ToInt32(ar1[1]);
                }
                else if (ar1[0] == "dm")
                {
                    this.domains = ar1.SubArray(1, ar1.Length - 1);
                }

            }
        }
        public string cmd { get; set; }
        public int thread { get; set; }

        public int CatId { get; set; }
    }
}
