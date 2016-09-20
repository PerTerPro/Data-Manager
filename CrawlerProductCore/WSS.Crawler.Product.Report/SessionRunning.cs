using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities.CrawlerProduct;

namespace WSS.Crawler.Product.Report
{
    public class SessionRunningTrack
    {
        private Dictionary<string, ReportSessionRunning> dictionarySessionRunning =
            new Dictionary<string, ReportSessionRunning>();

        public void AddItem(ReportSessionRunning item)
        {
            if (!dictionarySessionRunning.ContainsKey(item.Session))
            {
                dictionarySessionRunning.Add(item.Session, item);
            }
            else
            {
                dictionarySessionRunning[item.Session] = item;
            }
        }

        public List<ReportSessionRunning> GetCurrent()
        {
            var a = from x in dictionarySessionRunning
                where (x.Value.TimeReport - DateTime.Now).TotalMinutes > 10
                select x.Value;
            return a.ToList();
        }
    }
}
