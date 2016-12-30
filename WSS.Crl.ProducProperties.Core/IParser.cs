using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;

namespace WSS.Crl.ProducProperties.Core
{
    public interface IParser
    {
        PropertyData ParseData(HtmlDocument document);
    }
}
