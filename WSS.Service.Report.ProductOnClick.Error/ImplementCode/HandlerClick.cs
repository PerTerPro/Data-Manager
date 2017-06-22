using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using log4net;
using NUnit.Framework.Interfaces;
using QT.Entities.ProductManager;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Product;
using Wss.Lib.RabbitMq;
using WSS.Service.Report.ProductOnClick.Error.Entity;
using WSS.Service.Report.ProductOnClick.Error.Model;
using WSS.Service.Report.ProductOnClick.Error.Object;
using WSS.Service.Report.ProductOnClick.Error.Worker;

namespace WSS.Service.Report.ProductOnClick.Error.ImplementCode
{
    public class HandlerClick:IHandlerClick
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(WorkerCheckError));
        private readonly IProductProcess _productProcess;
        private readonly ICheckLast _checkLast;
        private readonly IProductAdapter _productAdapter;
        private readonly IProducerService _producerService;
        private readonly ProducerBasic _producer;
        private readonly ICheckLinkValid _checkLinkValid;

        public HandlerClick(IProductProcess productProcess, ICheckLast checkLast, IProductAdapter productAdapter, IProducerService producerService,
           WSS.Service.Report.ProductOnClick.Error.Model.ISettingRepository settingRepository, ICheckLinkValid checkLinkValid)
        {
            _productProcess = productProcess;
            _checkLast = checkLast;
            _productAdapter = productAdapter;
            _producerService = producerService;
            _checkLinkValid = checkLinkValid;
            _producer = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(settingRepository.RabbitMq), "Product.ErrorRequest");
        }

        private void PushlishErrorWhenRequest(MsProduct msProductError)
        {
            
            _producer.PublishString(msProductError.GetJson());
        }

        public void Process(MsProduct msProduct)
        {
            Regex regex = new Regex(@"http.+html");
            if (msProduct != null)
            {
                long productId = msProduct.ProductId;
                string url = msProduct.DetailUrlMerchant;
                if (string.IsNullOrEmpty(msProduct.DetailUrlMerchant))
                {
                    var product =
                        _productAdapter.GetProduct(msProduct.ProductId);
                    if (product != null) url = product.DetailUrl;
                }
                if (!string.IsNullOrEmpty(url))
                {
                    if (!url.Contains("http")) url = "http://" + url;
                    string keyword = "";
                    int Type = 2;
                    if (_productProcess.IsUrlEncoded(url))
                    {
                        string urlencode = url;
                        string urldecode = HttpUtility.UrlDecode(HttpUtility.UrlDecode(HttpUtility.UrlDecode(urlencode)));
                        url = urldecode;
                        MatchCollection matches = regex.Matches(url);
                        if (matches.Count > 0)
                        {
                            url = matches[0].Value.ToString().Trim();
                        }
                        Regex regexReplace = new Regex(@"http.+url=");
                        url = regexReplace.Replace(url, "");
                    }
                    try
                    {
                        Uri uri = new Uri(url);
                        if (!_checkLast.CheckCanDownload(uri.Host))
                        {
                            Log.Info("Sleep to download html");
                            Thread.Sleep(3000);

                        }
                        if (!_checkLinkValid.CheckLink(url))
                        {
                            var company = _productAdapter.GetCompanyId(productId);
                            if (_productProcess.IsAdsScore(productId))
                            {
                                keyword = _productProcess.GetKeywordAds(productId);
                                Type = 1;
                            }
                            else
                            {
                                ////Nếu không phải sản phẩm quảng cáo => Hạ sản phẩm xuống và Gửi phá cache.
                                _producerService.SetStatusProduct(productId, EStatusProduct.NoValid);
                                Log.InfoFormat("Invalid product {0} : {1} because not download html", msProduct.ProductId, url);
                            }
                            _productProcess.UpdateError(new ProductError
                            {
                                ProductId = productId,
                                CompanyId = (company == null) ? 0 : company.Id,
                                DetailUrl = url,
                                DateLog = DateTime.Now,
                                Keyword = keyword,
                                Type = Type

                            });
                            _checkLast.SetLast(uri.Host);
                            Log.InfoFormat("Saved Product: {0}", productId);
                        }
                        else
                        {
                            Log.InfoFormat("Product {0} is ok", msProduct.ProductId);
                        }
                    }
                    catch (UriFormatException uriFormatException)
                    {
                        Log.ErrorFormat("Error UriFormatException {0} {1}", msProduct.ProductId, uriFormatException.Message);
                    }
                    catch (WebException ex)
                    {
                        MsProduct reqError = new MsProduct();
                        reqError.ProductId = productId;
                        reqError.DetailUrlMerchant = url;
                        reqError.Error = ex.ToString();
                        PushlishErrorWhenRequest(reqError);
                        Log.ErrorFormat("Error: {0}", ex.Status);
                        Thread.Sleep(10000);
                    }
                }
            }
        }
    }
}
