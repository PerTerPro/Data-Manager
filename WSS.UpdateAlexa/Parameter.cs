using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.UpdateAlexaData
{
    public class Parameter
    {
        private string desp;
        public int NumberThread;

        public Parameter(string desp)
        {
            string[] arStr = desp.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var VARIABLE in arStr)
            {
                string[] arStr1 = VARIABLE.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var a1 = arStr1[0];
                if (a1 == "s") this.TypeSystem = Convert.ToInt32(arStr1[1]);
                else if (a1 == "t") this.TypeRun = Convert.ToInt32(arStr1[1]);
                else if (a1 == "nt") this.NumberThread = Convert.ToInt32(arStr1[1]);
            }

        }
        public int TypeSystem { get; set; }
        public int TypeRun { get; set; }
    }
}
