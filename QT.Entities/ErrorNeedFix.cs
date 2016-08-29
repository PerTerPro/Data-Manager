using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities
{
    public class ErrorNeedFix
    {
        public string ErrorDetail { get; set; }
        public long CompanyID { get; set; }
        public long ProductID { get; set; }
        public DateTime TimeError { get; set; }
    }
}
