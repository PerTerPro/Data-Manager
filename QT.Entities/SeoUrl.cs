using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities
{
    public class SeoUrl
    {
       

        public class LinkDetail
        {
            public LinkDetail()
            {
                anchors = "";
                link = "";
            }
            public string anchors { get; set; }
            public string link { get; set; }
            public override string ToString()
            {
                return "{" + string.Format("anchor:'{0}', length:{1}, link:'{2}'", Common.GetParaForCassDb(anchors), WordCounting.CountWords1(anchors), link) + "}";
            }

            public string text { get; set; }
        }

        public SeoUrl ()
        {
            anchor_external_link_follows = new List<string>();
            path = "";
            host = "";
            anchor_external_link_nofollows = new List<string>();
            anchor_internal_link_follows = new List<string>();
            anchor_internal_link_nofollows = new List<string>();
            canonical = "";
            external_link_follow_count = 0;
            external_link_follows = new List<LinkDetail>();
            external_link_nofollow_count = 0;
            external_link_nofollows = new List<LinkDetail>();
            internal_link_follow_count = 0;
            internal_link_follows = new List<LinkDetail>();
            internal_link_nofollow_count = 0;
            internal_link_nofollows = new List<LinkDetail>();
            meta_description = "";
            meta_keywords = new HashSet<string>();
            related_site = new HashSet<string>();
            robots = new HashSet<string>();
            title = "";
        }

        public List<string> anchor_external_link_follows { get; set; }


        public string host { get; set; }

        public string path { get; set; }

        public List<string> anchor_external_link_nofollows { get; set; }

        public List<string> anchor_internal_link_follows { get; set; }

        public List<string> anchor_internal_link_nofollows { get; set; }

        public string canonical { get; set; }

        public int external_link_follow_count { get; set; }

        public List<LinkDetail> external_link_follows { get; set; }

        public int external_link_nofollow_count { get; set; }

        public List<LinkDetail> external_link_nofollows { get; set; }

        public static string GetStrToCassandra(List<LinkDetail> data)
        {
            return "[" + string.Join(",", data) + "]";
        }

        public int internal_link_follow_count { get; set; }

        public List<LinkDetail> internal_link_follows { get; set; }

        public int internal_link_nofollow_count { get; set; }

        public List<LinkDetail> internal_link_nofollows { get; set; }

        public string meta_description { get; set; }

        public HashSet<string> meta_keywords { get; set; }

        public List<string> h1 { get; set; }
        public List<string> h2 { get; set; }
        public List<string> h3 { get; set; }
        public List<string> h4 { get; set; }
        public List<string> h5 { get; set; }
        public List<string> h6 { get; set; }
        public List<string> bl { get; set; }

        public HashSet<string> related_site { get; set; }

        public HashSet<string> robots { get; set; }

        public string title { get; set; }

        public List<string> images_internal { get; set; }
        public List<string> images_external { get; set; }

        public long time_insert { get; set; }

        public long id { get; set; }


        public byte[] GetArByteJSON()
        {
            return Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(this));
        }
    }
}
