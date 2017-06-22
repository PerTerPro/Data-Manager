using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Websosanh.Core.Drivers.RabbitMQ;
using Wss.Lib.RabbitMq;
using WSS.Service.Report.ProductOnClick.Error.ImplementCode;
using WSS.Service.Report.ProductOnClick.Error.Model;

namespace WSS.Service.Report.ProductOnClick.Error.Test
{
    [TestFixture]
    public class ProductProcessTest
    {
        [Test]
        public void ProductIsAdsScoreTest()
        {
            //IKerner 
            //long ProductId = 42839061800553;
            //bool x = (new ProductProcess()).IsAdsScore(ProductId);
            //Assert.Greater(x, true);
        }

        [Test]
        public void ProductIsUrlEncodedTest()
        {
            //string url = @"http://ho.lazada.vn/SHDCvl?url=http%3A%2F%2Fwww.lazada.vn%2Fday-nhay-patch-cord-amp-cat6-dai-3m-xanh-duong-1891739.html%3Foffer_id%3D%7Boffer_id%7D%26affiliate_id%3D%7Baffiliate_id%7D%26offer_name%3D%7Boffer_name%7D_%7Boffer_file_id%7D%26affiliate_name%3D%7Baffiliate_name%7D%26transaction_id%3D%7Btransaction_id%7D%26aff_source%3D%7Bsource%7D&aff_sub=&aff_sub2=&aff_sub3=&aff_sub4=&aff_sub5=&source=";
            //bool x = .IsUrlEncoded(url);
            //Assert.Greater(x, true);
        }

        [Test]
        public void ShouldProcess()
        {
            IKernel kerner = new StandardKernel(new MappingNinject());
            var handlerClick = kerner.Get<HandlerClick>();
            handlerClick.Process(new MsProduct()
            {
                DetailUrlMerchant = @"http://hello247.net/san-pham/dam-xoe-cao-cap/47823/dam-xoe-co-yem-that-lung-mau-do-sang-trong-thoi-tr/",
                ProductId = 4051828322537495673
            });
        }

        [Test]
        public void RunTest()
        {
            IKernel kerner = new StandardKernel(new MappingNinject());

            var settingRepository = kerner.Get<ISettingRepository>();
            var handler = kerner.Get<IHandlerClick>();
            ConsumerBasic<MsProduct> consumer = new ConsumerBasic<MsProduct>(RabbitMQManager.GetRabbitMQServer("rabbitMQ177_OnClick"), settingRepository.QueueProductClick);
            consumer._eventProcessJob += (job) =>
            {
                handler.Process(job);
            };
            consumer.StartConsume();
        }

      
    }
}
