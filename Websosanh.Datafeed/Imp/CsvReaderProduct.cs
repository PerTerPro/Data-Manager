using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using log4net;
using QT.Entities;
using QT.Moduls.Company;
using Websosanh.Datafeed.Model;

namespace Websosanh.Datafeed.Imp
{
    public class CsvReaderProduct:ICsvReaderProduct
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(CsvReaderProduct));
        private readonly IDataFeedConfigRepository _dataFeedConfigRepository;
         

        public CsvReaderProduct(IDataFeedConfigRepository dataFeedConfigRepository)
        {
            _dataFeedConfigRepository = dataFeedConfigRepository;
        }

        public HashSet<long> GetProductIds (string csvPath, long companyId, string domain)
        {
           
            HashSet<long> hs = new HashSet<long>();
            var datafeedConfig = this._dataFeedConfigRepository.Get(companyId);
            var csv = new CsvHelper.CsvReader(new StreamReader(csvPath));
            while (csv.Read())
            {
                long id = UtilIdProduct.GenerateId(csv.GetField<string>(datafeedConfig.ProductNameNode));
                if (!hs.Contains(id))
                    hs.Add(id);
                if (hs.Count%1000 == 0) _log.InfoFormat("Loaded {0} id to hashset", hs.Count);
            }
            return hs;
        }

        public void ReadDataFeedProductsFromCsvFile(string csvPath, long companyId, string domain, EventHandler<Product> eventToProduct)
        {
            var datafeedConfig = this._dataFeedConfigRepository.Get(companyId);
            var csv = new CsvHelper.CsvReader(new StreamReader(csvPath));
            while (csv.Read())
            {
                string name = csv.GetField<string>(datafeedConfig.ProductNameNode);
                string detailUrl = csv.GetField<string>(datafeedConfig.UrlNode);
                var decodedUrl = UtilIdProduct.GenerateId(detailUrl, datafeedConfig.RegexConfigUrl);
                string sku = csv.GetField<string>(datafeedConfig.SkuNode);
                string branch = csv.GetField<string>(datafeedConfig.BrandNode);
                string productContent = csv.GetField<string>(datafeedConfig.DescriptionNode);
                string image = csv.GetField<string>(datafeedConfig.PictureUrl1Node);
                string strDiscountedPrice = csv.GetField<string>(datafeedConfig.DiscountedPriceNode);
                string strOriginPrice = csv.GetField<string>(datafeedConfig.PriceNode);
                string category = csv.GetField<string>(datafeedConfig.Category1Node);
                string parrentCategory = csv.GetField<string>(datafeedConfig.ParentOfCategory1Node);
                CultureInfo cultureInfo;
                if (datafeedConfig.CurrencyFormat == CurrencyFormat.Vietnamese)
                    cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
                else
                    cultureInfo = CultureInfo.GetCultureInfo("en-US");
                int discountedPrice = (int) Decimal.Parse(Regex.Replace(strDiscountedPrice.ToLower().Trim(), @"\s*vnd|\s*vnđ|\s*đ", ""), cultureInfo);
                int originPrice = (int) Decimal.Parse(Regex.Replace(strOriginPrice.ToLower().Trim(), @"\s*vnd|\s*vnđ|\s*đ", ""), cultureInfo);
                Product tmpProduct = new Product();
                //Mặc định trạng thái sản phẩm là Available
                tmpProduct.Status = Common.ProductStatus.Available;
                tmpProduct.Instock = Common.GetProductInstockFormStatus(tmpProduct.Status);
                tmpProduct.HashName = Common.GetHashNameProduct(domain, tmpProduct.Name.Trim());

                #region Price

                if (discountedPrice > 0)
                {
                    if (originPrice > discountedPrice)
                    {
                        tmpProduct.Price = discountedPrice;
                        tmpProduct.OriginPrice = originPrice;
                        //tmpProduct.IsDeal = true;
                    }
                    else
                    {
                        tmpProduct.Price = tmpProduct.OriginPrice = discountedPrice;
                        //tmpProduct.IsDeal = false;
                    }
                }
                else if (originPrice > 0)
                {
                    int discountPrice = 0;
                    //DiscountPrice (số tiền giảm)
                    try
                    {
                        discountPrice = (int) Decimal.Parse(Regex.Replace(strDiscountedPrice.ToLower().Trim(), @"\s*vnd|\s*vnđ|\s*đ", ""), cultureInfo);
                    }
                    catch (Exception)
                    {
                    }
                    if (discountPrice > 0)
                    {
                        tmpProduct.Price = originPrice - discountPrice;
                        tmpProduct.OriginPrice = originPrice;
                        //tmpProduct.IsDeal = true;
                    }
                    else
                    {
                        tmpProduct.Price = tmpProduct.OriginPrice = originPrice;
                        //tmpProduct.IsDeal = false;
                    }
                }

                #endregion

                if (tmpProduct.Price <= 0)
                {
                    _log.Warn(string.Format("Product price equal {0}. Product: ID {1} - {2}", tmpProduct.Price, tmpProduct.ID, tmpProduct.Name));
                    continue;
                }
                tmpProduct.IDCategories = Common.GetIDClassification(Common.ConvertToString(tmpProduct.Categories, " -> "));
                tmpProduct.VATStatus = 1;

                eventToProduct(this, tmpProduct);
            }
        }
    }
}
