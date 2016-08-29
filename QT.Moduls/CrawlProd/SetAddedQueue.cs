using QT.Moduls.Crawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlProd
{
    public class SetAddedQueue : ISetAddedVisited
    {
        public Dictionary<long, long> dic = new Dictionary<long, long>();
        private long company;
        private int typeCrawler;

        public SetAddedQueue(long company, int typeCrawler)
        {
            // TODO: Complete member initialization
            this.company = company;
            this.typeCrawler = typeCrawler;
        }

        public bool Exists(int p)
        {
           return dic.ContainsKey(p);
        }

        public void Add(int p, string a)
        {
            dic.Add(p, 0);
        }

     


      

        void ISetAddedVisited.Clean()
        {
            throw new NotImplementedException();
        }
    }
}
