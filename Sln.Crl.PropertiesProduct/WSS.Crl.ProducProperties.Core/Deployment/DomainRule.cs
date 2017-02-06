using Ninject.Modules;
using WSS.Crl.ProducProperties.Core.Storage;
using WSS.LibExtra;

namespace WSS.Crl.ProducProperties.Core.Deployment
{
    public class DomainRule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IStorageHtml>().To<StorageHtmlMongo>();
            this.Bind<IStoragePropertiesParse>().To<StoragePropertiesParseMongo>();
            this.Bind<IStorageConfigCrl>().To<StorageConfigCrl>();
            this.Bind<IStorageFattenData>().To<StorageFattenDataSql>();
            this.Bind<IDownloadHtml>().To<DownloadHtmlCrawler>();
        }
    }
}
