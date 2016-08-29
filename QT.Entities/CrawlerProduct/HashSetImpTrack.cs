using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    public class HashSetImpTrack<T>
    {
        readonly HashSet<T> _hash=new HashSet<T>();

        readonly List<T> _lstAdded = new List<T>();
        readonly List<T> _lstDeleted = new List<T>();

        public delegate void EventSaveDataChange(List<T> lstAdded, List<T> lstDeleted);
        public EventSaveDataChange EventSaveChange = null;

        public bool Contains(T item)
        {
            return _hash.Contains(item);
        }

        public void Add(T item)
        {
            _lstAdded.Add(item);
             _hash.Add(item);
        }

        public void SaveChange()
        {
            if (EventSaveChange != null) EventSaveChange(_lstAdded, _lstDeleted); 
            _lstAdded.Clear();
            _lstDeleted.Clear();
        }
    }
}
