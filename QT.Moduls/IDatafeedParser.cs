using CsvHelper;
using GABIZ.Base.Statistics.Kernels;
using QT.Entities;
using QT.Moduls.Company;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using log4net;
using ServiceStack;

namespace QT.Moduls
{
    interface IDatafeedParser
    {
        List<Product> GetAllProduct(string csvPath, QT.Entities.Company company, DatafeedConfig datafeedConfig, Action<string> eventLog=null);
    }
    public class DatafeedParser : IDatafeedParser
    {
        private string strNotMeanPrice = @"\s*vnd|\s*vnđ|\s*đ";
        private ILog _log = LogManager.GetLogger(typeof(DatafeedParser));

        public List<Product> GetAllProduct(string csvPath, QT.Entities.Company company, DatafeedConfig datafeedConfig, Action<string> eventLog=null)
        {
            List<Product> lstPt = new List<Product>();
            CultureInfo cultureInfo = (datafeedConfig.CurrencyFormat == CurrencyFormat.Vietnamese) ? CultureInfo.GetCultureInfo("vi-VN") : CultureInfo.GetCultureInfo("en-US");
            var csv = new Wss.Lib.CsvHelper.CsvFile(csvPath, new Action<string>((string str) =>
            {
                _log.ErrorFormat("Can't parser csv line: {0}", str);
            }));
           
            while (csv.Read())
            {
                try
                {
                    var tmpProduct = new Product
                    {
                        Domain = company.Domain,
                        IDCongTy = company.ID,
                        Status = Common.ProductStatus.Available,
                        Instock = Common.GetProductInstockFormStatus(Common.ProductStatus.Available)
                    };
                    string strTemp = "";
                    long discountedPrice = 0;
                    long originPrice = 0;
                    List<string> lstCat = new ArrayOfString();

                    if (csv.TryGetField(datafeedConfig.ProductNameNode, ref strTemp))
                    {
                        tmpProduct.Name = strTemp;
                    }

                    if (csv.TryGetField(datafeedConfig.UrlNode, ref strTemp))
                    {
                        tmpProduct.DetailUrl = strTemp;
                        tmpProduct.ID = Wss.Lib.Utilities.UtilIdProduct.GenId(tmpProduct.DetailUrl, datafeedConfig.RegexConfigUrl);
                    }

                    if (csv.TryGetField(datafeedConfig.SkuNode, ref strTemp))
                    {
                        tmpProduct.MerchantSku = strTemp;
                    }

                    if (csv.TryGetField(datafeedConfig.BrandNode, ref strTemp))
                    {
                        tmpProduct.Manufacture = strTemp;
                    }
                    tmpProduct.HashName = Common.GetHashNameProduct(company.Domain, tmpProduct.Name.Trim());

                    if (csv.TryGetField(datafeedConfig.DiscountedPriceNode, ref strTemp))
                    {
                        discountedPrice = (int) Decimal.Parse(Regex.Replace(strTemp.ToLower().Trim(), strNotMeanPrice, ""), cultureInfo);
                    }

                    if (csv.TryGetField(datafeedConfig.PriceNode, ref strTemp))
                    {
                        originPrice = (int) Decimal.Parse(Regex.Replace(strTemp.ToLower().Trim(), strNotMeanPrice, ""), cultureInfo);
                    }

                    #region {xuligia}

                    if (discountedPrice > 0)
                    {
                        if (originPrice > discountedPrice)
                        {
                            tmpProduct.Price = (int) discountedPrice;
                            tmpProduct.OriginPrice = (int) originPrice;
                            //tmpProduct.IsDeal = true;
                        }
                        else
                        {
                            tmpProduct.Price = tmpProduct.OriginPrice = (int) discountedPrice;
                            //tmpProduct.IsDeal = false;
                        }
                    }
                    //
                    else if (originPrice > 0)
                    {
                        int discountPrice = 0;
                        //DiscountPrice (số tiền giảm)
                        try
                        {
                            if (csv.TryGetField(datafeedConfig.DiscountNode, ref strTemp))
                            {
                                discountPrice = (int) Decimal.Parse(Regex.Replace(strTemp.ToLower().Trim(), strNotMeanPrice, ""), cultureInfo);
                            }
                        }
                        catch (Exception)
                        {
                        }
                        if (discountPrice > 0)
                        {
                            tmpProduct.Price = (int) originPrice - (int) discountPrice;
                            tmpProduct.OriginPrice = (int) originPrice;
                            //tmpProduct.IsDeal = true;
                        }
                        else
                        {
                            tmpProduct.Price = tmpProduct.OriginPrice = (int) originPrice;
                            //tmpProduct.IsDeal = false;
                        }
                    }

                    #endregion

                    if (csv.TryGetField(datafeedConfig.Category1Node, ref strTemp))
                    {
                        lstCat.Add(strTemp);
                    }

                    if (csv.TryGetField(datafeedConfig.Category2Node, ref strTemp))
                    {
                        lstCat.Add(strTemp);
                    }
                    tmpProduct.Categories = lstCat;
                    tmpProduct.IDCategories = Common.GetIDClassification(Common.ConvertToString(tmpProduct.Categories, " -> "));

                    if (csv.TryGetField(datafeedConfig.PictureUrl1Node, ref strTemp))
                    {
                        tmpProduct.ImageUrls = new ArrayOfString() {strTemp};
                    }

                    tmpProduct.VATStatus = 1;


                    eventLog(string.Format("NumbItem: {0} CheckInfoProduct: {1}", lstPt.Count, CheckWarnInfo(tmpProduct)));
                    lstPt.Add(tmpProduct);
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                    throw ex;
                }
               
            }
            return lstPt;
        }

        private string CheckWarnInfo(Product tmpProduct)
        {
            string str = "";
            if (tmpProduct.ID == 0) str += " Id is null";
            if (string.IsNullOrEmpty(tmpProduct.Name)) str += "Name empty";
            if (tmpProduct.Price <= 0) str += "Price 0";
            return str;
        }
    }
}
