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

        public Parameter()
        {
            Thread = 1;
            Directory = "";
        }
        internal static Parameter FromStr(string p)
        {
            Parameter p1 = new Parameter();
            string[] arSubPara = p.Split(new []{'-'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var VARIABLE in arSubPara)
            {
                string[] paras = VARIABLE.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (paras[0] == "dir")
                {
                    p1.Directory = paras[1];
                }
                else if (paras[0] == "cmd")
                {
                    p1.Cmd = paras[1];
                    ;
                }
            }
            return p1;
        }

        public string Directory { get; set; }
    }
}
