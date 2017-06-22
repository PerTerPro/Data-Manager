using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.ProductManager
{
    public interface IPublisherProductChange
    {
        void Push(JobMqChangeProduct jobMqChangeProduct);
    }

    public class PublisherProductChange : IPublisherProductChange
    {

        public void Push(JobMqChangeProduct jobMqChangeProduct)
        {
            throw new NotImplementedException();
        }
    }
}
