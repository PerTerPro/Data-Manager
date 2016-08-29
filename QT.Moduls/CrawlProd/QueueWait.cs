using QT.Moduls.Crawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlProd
{
    public class QueueWait : IQueueWait
    {
        Queue<Job> queue = new Queue<Job>();
        public void PushJob(Job mss)
        {
            queue.Enqueue(mss);
        }

        public Job GetJob()
        {
            return queue.Dequeue();
        }
    }
}

