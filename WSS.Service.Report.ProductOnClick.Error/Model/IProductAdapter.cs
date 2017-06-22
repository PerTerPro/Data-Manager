using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using WSS.Service.Report.ProductOnClick.Error.Entity;
using WSS.Service.Report.ProductOnClick.Error.Object;

namespace WSS.Service.Report.ProductOnClick.Error.Model
{
    public interface IProductAdapter
    {
        Company GetCompanyId(long productId);
        Product GetProduct(long productId);
        void UpdateInvalidProduct(long productId);
    }
}
