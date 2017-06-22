using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Service.Report.ProductOnClick.Error.Entity;

namespace WSS.Service.Report.ProductOnClick.Error.Model
{
    public interface IProductProcess
    {
        bool IsUrlEncoded(string url);
        void UpdateError(ProductError productError);
        string GetKeywordAds(long productId);
        bool IsAdsScore(long productId);
    }
}
