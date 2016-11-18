using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Core.Crawler
{
    public interface IWorker
    {
        void StartCrawler();
        void StartCrawler(List<string> linkStarts);
        void Stop();
        bool Init();
        void End();
       
    }
}
