using GABIZ.Base.HtmlAgilityPack;
using WSS.Crl.ProducProperties.Core.Entity;

namespace WSS.Crl.ProducProperties.Core.Parser
{
    public interface IParser
    {
        PropertyProduct ParseData(HtmlDocument document );
        void Init(string domain);
    }
}
