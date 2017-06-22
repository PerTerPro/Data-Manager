using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities.CrawlerProduct.RabbitMQ;

namespace WSS.Service.Report.ProductOnClick.Error.Model
{
    public interface IHandlerClick
    {
        void Process(MsProduct job);
    }
}
