using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using log4net;
using Websosanh.Core.Product.BAL;
using Websosanh.Core.Product.BO;
using WebsosanhCacheTool.CompanyDataSetTableAdapters;
using Websosanh.Core.Common.BAL;
using UTF_Converter;
using WebsosanhCacheTool.ProductDataSetTableAdapters;
using Websosanh.Core.Drivers.Redis;
using ProtoBuf;
using QT.Entities.MasOffer;

namespace WebsosanhCacheTool
{
    public class WebMerchantProductCacheTool
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (WebMerchantProductCacheTool));
        //private static MasOfferAdapter masOffer = MasOfferAdapter.Instance();

        public static void InsertAllWebMerchantProductToCache(string connProductString)
        {
            try
            {
                var startTime = DateTime.Now;
                //Get List Company
                var companyTableAdapter = new CompanyTableAdapter()
                {
                    Connection = {ConnectionString = connProductString}
                };
                var companyDataTable = companyTableAdapter.GetAllCompanies();

                for (int rowIndex = 0; rowIndex < companyDataTable.Rows.Count; rowIndex++)
                {
                    var companyRow = companyDataTable[rowIndex];
                    var companyID = companyRow.ID;
                    var companyDomain = "";
                    if (companyRow["Domain"] != DBNull.Value)
                        companyDomain = companyRow.Domain;
                    InsertWebMerchantProductToCache(companyID,companyDomain,connProductString);
                    Log.InfoFormat("Insert WebMerchantProductToCache - Company [{0}/{1}]",rowIndex, companyDataTable.Rows.Count);
                }
                var totalTime = (DateTime.Now - startTime).TotalSeconds;
                Log.InfoFormat("Total Time: {0} s", totalTime);
            }
            catch (Exception ex)
            {
                Log.Error("InsertAllWebMerchantProductToCache Error", ex);
            }
        }

        public static void InsertWebMerchantProductToCache(long companyID, string companyDomain, string connProductString)
        {
            try
            {
                //Get List Product Of Company
                var listWebMerchantProducts = WebMerchantProductBAL.GetListWebMerchantProductsOfCompany(companyID,
                        connProductString);

                //XT. Change link if is MasOffer
                if (masOffer.CheckIsMasOffer(companyID))
                {
                    
                    foreach (var itemProduct in listWebMerchantProducts)
                    {
                        itemProduct.DetailUrl = masOffer.GetFullUrl(companyID, itemProduct.DetailUrl);
                    }
                    Log.Info("Masoffer: "+companyID + " : " + listWebMerchantProducts.Count);
                }

                if (listWebMerchantProducts.Count > 0)
                    {
                        var parts = CollectionUtilities.Partition<WebMerchantProduct>(listWebMerchantProducts, 2000);
                        foreach (var part in parts)
                        {
                            WebMerchantProductBAL.InsertWebMerchantProductsIntoCache(part);
                        }
                    }
                Log.InfoFormat("InsertWebMerchantProductToCache - Company [{0}] - {1} - {2} products]",
                    companyID, companyDomain, listWebMerchantProducts.Count);
            }
            catch (Exception ex)
            {
                Log.Error("InsertWebMerchantProductToCache Error", ex);
            }
        }

    }
}
