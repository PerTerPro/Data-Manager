using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using WSS.Service.Report.ProductOnClick.Error.ImplementCode;

namespace WSS.Service.Report.ProductOnClick.Error.Model
{
    public class MappingNinject : Ninject.Modules.NinjectModule
    {

        public override void Load()
        {
            Bind<ISettingRepository>().To<SettingRepository>();
            Bind<IHandlerClick>().To<HandlerClick>();
            Bind<IProductProcess>().To<ProductProcess>();
            Bind<ICheckLast>().To<CheckLast>();
            Bind<IProductAdapter>().To<ProductAdapter>();
        }
    }
}
