using System.Threading.Tasks;
using WSS.Crl.ProducProperties.Core.Entity;

namespace WSS.Crl.ProducProperties.Core.Storage
{
    public interface IStorageHtml
    {
        void SaveHtml(HtmlProduct htmlProduct);
        HtmlProduct GetHtml(long productId);
    }
}
