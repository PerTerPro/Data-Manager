using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Service.Report.ProductOnClick.Error.Model;

namespace WSS.Service.Report.ProductOnClick.Error.ImplementCode
{
    public class CheckLast : ICheckLast
    {
        static readonly Dictionary<string,DateTime> DicLastUpdate = new Dictionary<string, DateTime>(); 

        public void SetLast(string domain)
        {
            if (DicLastUpdate.ContainsKey(domain))
            {
                DicLastUpdate[domain] = DateTime.Now;
            }
            else
            {
                DicLastUpdate.Add(domain,DateTime.Now);
            }
        }

        public bool CheckCanDownload(string domain)
        {
            return (!DicLastUpdate.ContainsKey(domain)) || ((DateTime.Now - DicLastUpdate[domain]).TotalSeconds > 3);
        }
    }
}
