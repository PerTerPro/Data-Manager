using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using WSS.Crl.ProducProperties.Core.Handler;
using WSS.Crl.ProducProperties.Core.Parser;
using WSS.Crl.ProducProperties.Core.Storage;
using WSS.LibExtra;

namespace WSS.Crl.ProducProperties.Core.DI
{
    public class DomainModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IParser>().To<ParserProperties>();Bind<IStorageHtml>().To<StorageHtmlMongo>();
            Bind<IStorageConfigCrl>().To<StorageConfigCrl>();
            Bind<IStorageProduct>().To<StorageProduct>();
            Bind<IDownloadHtml>().To<DownloadHtmlCrawler>();
            Bind<IHandlerDownloadHtml>().To<HandlerDownloadHtml>();
            Bind<IProducerBasic>().To<ProducerBasic>();
            Bind<IHandlerParserProperties>().To<HandlerParseProperties>();
            Bind<IStoragePropertiesProduct>().To<StoragePropertiesProductMongo>();
        }
    }
}
