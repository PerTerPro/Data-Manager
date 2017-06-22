using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Ninject.Modules;
using Ninject.Parameters;
using Websosanh.Product;
using WSS.Service.Report.ProductOnClick.Error.ImplementCode;
using WSS.Service.Report.ProductOnClick.Error.Model;

namespace WSS.Service.Report.ProductOnClick.Error
{
    public class MappingNinject :NinjectModule
    {
        public override void Load()
        {
            Bind<ICheckLinkValid>().To<CheckLinkValid>();
            Bind<IHandlerClick>().To<HandlerClick>();
            Bind<IProducerService>().To<ProductService>();
            Bind<IProductWebService>().To<ProductWebService>()
                .WithConstructorArgument("rabbitMq", "rabbitMQ177")
                .WithConstructorArgument("queueRedis", "UpdateProduct.InsertProductToRedis")
                .WithConstructorArgument("queueSolr", "UpdateProduct.IndexProductToSolr");
            Bind<ISettingRepository>().To<SettingRepository>();
            Bind<IProductProcess>().To<ProductProcess>();
            Bind<ICheckLast>().To<CheckLast>();
            Bind<IProductAdapter>().To<ProductAdapter>().WithConstructorArgument("sqlConnection", ConfigurationManager.AppSettings["ConnectionString"]);
            Bind<IProductRepository>().To<ProductRepositorySql>().WithConstructorArgument("sqlConnection", ConfigurationManager.AppSettings["ConnectionString"]);
        }

    }
}
