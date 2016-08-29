using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    public class QueueImpTrack<T> 
    {
        readonly Queue<T> _queueData = new Queue<T>();

        public delegate void SaveAfterDispose(List<T> lstAdded, List<T> lstDeleted);
        public SaveAfterDispose EventSaveChange = null;

        readonly List<T> _lstAdded = new List<T>();
        readonly List<T> _lstDeleted = new List<T>();

        public void Clearn()
        {
            _queueData.Clear();
        }

        public T Dequeue(bool addTrack = true)
        {
            var item = _queueData.Dequeue();
            if (item != null && addTrack) _lstDeleted.Add(item);
            return item;
        }

        public void Enqueue(T item, bool addTrack = true)
        {
            _queueData.Enqueue(item);
            if (addTrack) _lstAdded.Add(item);
        }

        public void SaveChange()
        {
            if (EventSaveChange != null) EventSaveChange(_lstAdded, _lstDeleted); 
            _lstAdded.Clear();
            _lstDeleted.Clear();
        }

        public int Count
        {
            get { return _queueData.Count; }
        }


        public int CountDelete
        {
            get { return _lstDeleted.Count; }

        }

        public int CountAdded
        {
            get { return _lstAdded.Count; }
        }
    }
}
