using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.RaoVat
{
    /// <summary>
    /// Cấu hình bộ chạy crawler.
    /// </summary>
    public class RunnerCrawler
    {
        public RunnerCrawler ()
        {
            id = 0;
            name = "";
            website_id = 0;
            root_link = new List<string>();
            number_thread = 1;
            second_sleep_recrawler = 10 * 60;
            is_find_new = true;
            is_reload_item = true;
            max_deep = 100000;
            max_item = 10000;
            max_time_run_crawler = 100000;
            description = "";
            state = 0;
        }

        public int id { get; set; }
        public string name { get; set; }
        public int website_id { get; set; }
        public List<string> root_link { get; set; }
        public int number_thread { get; set; }
        public int second_sleep_recrawler { get; set; }
        public bool is_find_new { get; set; }
        public bool is_reload_item { get; set; }
        public int max_deep { get; set; }
        public int max_item { get; set; }
        public DateTime last_push { get; set; }
        public DateTime last_end { get; set; }
        public int max_time_run_crawler { get; set; }


        public string description { get; set; }

        public int state { get; set; }
    }
}
