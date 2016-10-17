using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.QAComment.Core
{
    public class Comment
    {
        public string DatePublish { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string Score { get; set; }
        public long ProductId { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public long CompanyId { get; set; }
    }
}
