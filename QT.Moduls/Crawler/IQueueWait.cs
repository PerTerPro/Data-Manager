using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.Crawler
{
    public interface IQueueWait
    {
        void PushJob(Job mss);
        Job GetJob();
    }
}
