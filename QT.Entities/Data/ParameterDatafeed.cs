using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.Data
{
    public class ParameterDatafeed
    {
        //Cấu trúc json phân trang
        public string feed_url { set; get; }
        public int total_page { set; get; }
        public string page_param { set; get; }

        //cấu trúc json gồm list các chuyên mục
        public string DatafeedUrl { set; get; }
        public List<string> Files { get; set; }
        public string LastUpdate { get; set; }
    }

    public class ParameterDatafeedAdayroi
    {
        public string LastUpdate { get; set; }
        public List<string> Files { get; set; }
    }
}
