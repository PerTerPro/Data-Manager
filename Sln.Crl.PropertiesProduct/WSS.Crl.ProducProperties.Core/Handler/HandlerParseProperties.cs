using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base;
using GABIZ.Base.HtmlAgilityPack;
using Newtonsoft.Json.Linq;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Parser;
using WSS.Crl.ProducProperties.Core.Storage;

namespace WSS.Crl.ProducProperties.Core.Handler
{
    public interface IHandlerParserProperties
    {
        void Init(string domain);
        void ProcessJob(long productId);
    }

    public class HandlerParseProperties:IHandlerParserProperties
    {
        private readonly IStorageHtml _storageHtml = null;
        private readonly IStoragePropertiesProduct _storagePropertiesProduct = null;
        private readonly IParser _parser;

        public HandlerParseProperties(IStorageHtml storageHtml, IStoragePropertiesProduct storagePropertiesProduct, IParser parser)
        {
            _storageHtml = storageHtml;
            _parser = parser;
            _storagePropertiesProduct = storagePropertiesProduct;
        }

        public void ProcessJob(long productId)
        {
            var htmlProduct = this._storageHtml.GetHtml(productId);
            if (htmlProduct != null)
            {
                HtmlDocument htmlDocument = new HtmlDocument();string html = System.Web.HttpUtility.HtmlDecode(htmlProduct.Html);htmlDocument.LoadHtml(html);
                var productProperty = this._parser.ParseData(htmlDocument);
                if (productProperty != null)
                {
                    productProperty.Category = htmlProduct.Classification;
                    productProperty.ProductId = productId;
                    this._storagePropertiesProduct.SaveProperiesProduct(productProperty);
                }
            }
        }


        public void Init(string domain)
        {
            _parser.Init(domain);
        }
    }
}
