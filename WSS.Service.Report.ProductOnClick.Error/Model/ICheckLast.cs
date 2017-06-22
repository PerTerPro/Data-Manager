using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.Report.ProductOnClick.Error.Model
{
    public interface ICheckLast
    {
        void SetLast(string domain);
        bool CheckCanDownload(string domain);
    }
}
