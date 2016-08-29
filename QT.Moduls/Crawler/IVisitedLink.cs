using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.Crawler
{
    public interface ISetAddedVisited
    {
        bool Exists(int p);

        void Add(int p, string url);

        void Clean();
    }
}
