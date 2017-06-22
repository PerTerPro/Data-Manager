using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Websosanh.Product
{
    public class ProductService:IProducerService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductWebService _productWebService;

        public ProductService(IProductRepository productRepository, IProductWebService productWebService)
        {
            _productRepository = productRepository;
            _productWebService = productWebService;
        }

        public void SetStatusProduct(long productId, EStatusProduct newStatus)
        {
            _productRepository.SetStatus(productId, newStatus);
            _productWebService.PushMqToRedisProduct(productId);
            _productWebService.PushMqToSoldProduct(productId);

        }
    }
}
