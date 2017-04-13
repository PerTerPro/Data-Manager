using log4net;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Merchant.BAL;
using Websosanh.Core.Merchant.BO;
using Websosanh.Core.Product.BO;
using WebsosanhCacheTool;
using DevExpress.XtraEditors;
using Websosanh.Core.Product.BAL;
using UpdateSolrTools;
using System.Text.RegularExpressions;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using GABIZ.Base;
using QT.Entities;
using QT.Entities.MasOffer;
using WSS.Product.Utilities;

namespace CacheManager
{
    public partial class formCacheManager : Form
    {
        private string _productConnectionString;
        private string _userConnectionString;
        private string _searchEnginesServiceUrl;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(formCacheManager));
        private static readonly ILog ProductNameLogger = LogManager.GetLogger("ProductNameLogger");
        public formCacheManager()
        {
            InitializeComponent();
            _productConnectionString =
                ConfigurationManager.ConnectionStrings["ProductConnectionString"].ToString();
            _userConnectionString = ConfigurationManager.ConnectionStrings["UserConnectionString"].ToString();
            _searchEnginesServiceUrl = ConfigurationManager.AppSettings["searchEnginesServiceUrl"];
            MasOfferAdapter.SetConnection(_productConnectionString);
        }

        private void DisableButton(SimpleButton button)
        {
            this.Invoke((MethodInvoker)delegate
              {
                  button.Enabled = false;
              });
        }

        private void EnableButton(SimpleButton button)
        {
            this.Invoke((MethodInvoker)delegate
            {
                button.Enabled = true;
            });
        }

        #region Product Identity
        private void buttonInsertProductIdentities_Click(object sender, EventArgs e)
        {
            var insertTask = new Task(() => ProductIdentityCacheTool.InsertProductIdentities(_productConnectionString));
            insertTask.Start();
        }


        private void buttonInsertProductIdentity_Click(object sender, EventArgs e)
        {
            long productIdentityID = 0;
            if (string.IsNullOrEmpty(textEditProductIdentityID.Text))
            {
                UpdateInsertProductIdentityStatus("ProductIdentityID null or empty");
            }
            long.TryParse(textEditProductIdentityID.Text, out productIdentityID);
            if (productIdentityID > 0)
            {
                UpdateInsertProductIdentityStatus(
                    !ProductIdentityCacheTool.InsertProductIdentity(productIdentityID, _productConnectionString)
                        ? "Update fail"
                        : "Update Success");
            }

        }

        private void UpdateInsertProductIdentityStatus(string message)
        {
            textEditInsertProductIdentityStatus.Text =
                    string.Format("[{0:MM-dd H:mm:ss}] - {1}", DateTime.Now,message);
        }
        #endregion

        #region RootProduct Mapping.Run 4:00 and 12:00 daily
        private void buttonInsertAllRootProductMapping_Click(object sender, EventArgs e)
        {
            var insertTask = new Task(() => {
                DisableButton(buttonInsertAllRootProductMapping);
                try
                {                    
                    RootProductMappingCacheTool.InsertAllRootProductMappingIntoCache(_productConnectionString, _searchEnginesServiceUrl);                    
                }
                catch(Exception exception)
                {
                    Logger.Error("ScheduleInsertAllRootProductMappingIntoCache", exception);
                }
                finally
                {
                    EnableButton(buttonInsertAllRootProductMapping);
                }
            });
            insertTask.Start();
        }

        private void buttonInsertRootProductMappingByID_Click(object sender, EventArgs e)
        {
            long rootProductID = 0;
            if (string.IsNullOrEmpty(textEditRootProductMappingID.Text))
            {
                UpdateInsertRootProductMappingStatus("RootProductID null or empty");
            }
            long.TryParse(textEditRootProductMappingID.Text, out rootProductID);
            if (rootProductID > 0)
            {
                UpdateInsertRootProductMappingStatus(
                    !RootProductMappingCacheTool.InsertRootProductMappingCache(rootProductID, _searchEnginesServiceUrl)
                        ? "Update fail"
                        : "Update Success");
            }
        }

        private void UpdateInsertRootProductMappingStatus(string message)
        {
            this.Invoke((MethodInvoker)delegate
               {
                   textEditInsertRootProductMappingStatus.Text =
                           string.Format("[{0:MM-dd H:mm:ss}] - {1}", DateTime.Now, message);
               });
        }

        private bool isRunScheduleUpdateRootProductMapping;
        private void simpleButtonScheduleUpdateRootProductMapping_Click(object sender, EventArgs e)
        {
            var scheduleTask = new Task(() =>
                {                    
                    DisableButton(simpleButtonScheduleUpdateRootProductMapping);
                    RunScheduleUpdateRootProductMapping();
                    EnableButton(simpleButtonScheduleUpdateRootProductMapping);
                });
            scheduleTask.Start();
            
        }

        private void RunScheduleUpdateRootProductMapping()
        {
            isRunScheduleUpdateRootProductMapping = true;
            while (isRunScheduleUpdateRootProductMapping)
            {
                Thread.Sleep(1000);
                if ((DateTime.Now.Hour != 4 && DateTime.Now.Hour != 12) || DateTime.Now.Minute > 5)
                    continue;
                try
                {
                    Logger.Info("ScheduleInsertAllRootProductMapping Task started.");
                    RootProductMappingCacheTool.InsertAllRootProductMappingIntoCache(_productConnectionString, _searchEnginesServiceUrl);
                    Logger.Info("ScheduleInsertAllRootProductMapping Task Finished.");
                }
                catch(Exception exception)
                {
                    Logger.Error("InsertAllRootProductMappingIntoCache", exception);
                }
            }
        }

        private void simpleButtonStopScheduleUpdateRootProductMapping_Click(object sender, EventArgs e)
        {
            isRunScheduleUpdateRootProductMapping = false;
        }
        #endregion

        #region Products. Update at 00:30, 12:30 daily

        #region WebMerchantProduct
        private void buttonInsertMerchantProductInfos_Click(object sender, EventArgs e)
        {
            var insertTask = new Task(() => {
                DisableButton(buttonInsertMerchantProductInfos);
                try
                {
                    WebMerchantProductCacheTool.InsertAllWebMerchantProductToCache(_productConnectionString);
                }
                catch (Exception ex)
                {
                    Logger.Error("InsertAllWebMerchantProductToCache Error", ex);
                }
                finally
                {
                    EnableButton(buttonInsertMerchantProductInfos);
                }
            });
            insertTask.Start();
        }


        private void buttonInsertMerchantProductInfosByMerchantID_Click(object sender, EventArgs e)
        {
            var insertTask = new Task(() =>
            {
                string merchantIDString = null;
                long merchantID = 0;
                this.Invoke((MethodInvoker)delegate
                {
                    merchantIDString = textEditMerchantIDForInsertMerchantProductInfoToCache.Text;
                });
                if (!string.IsNullOrEmpty(merchantIDString) && long.TryParse(merchantIDString, out merchantID))
                {
                    WebMerchantProductCacheTool.InsertWebMerchantProductToCache(merchantID, "", _productConnectionString);
                    UpdateInsertMerchantProductInfosByMerchantIDStatus("Update Success");
                }
                else
                    UpdateInsertMerchantProductInfosByMerchantIDStatus("MerchantID null or empty");
              
            });
            insertTask.Start();
        }

        private void UpdateInsertMerchantProductInfosByMerchantIDStatus(string message)
        {
            this.Invoke((MethodInvoker)delegate
                {
                    textEditInsertMerchantProductInfosByMerchantIDStatus.Text =
                            string.Format("[{0:MM-dd H:mm:ss}] - {1}", DateTime.Now, message);
                });
        }
        #endregion
        #region WebRootProduct
        private void simpleButtonUpdateAllRootProduct_Click(object sender, EventArgs e)
        {
            var insertTask = new Task(() =>
            {
                DisableButton(simpleButtonUpdateAllRootProduct);
                try
                {
                    WebRootProductCacheTool.InsertAllWebRootProductIntoCache(_productConnectionString, _userConnectionString, _searchEnginesServiceUrl);
                }
                catch (Exception exception)
                {
                    Logger.Error("InsertAllWebRootProductIntoCache", exception);
                }
                finally
                {
                    EnableButton(simpleButtonUpdateAllRootProduct);
                }
                EnableButton(simpleButtonUpdateAllRootProduct);
            });
            insertTask.Start();
        }

        private void simpleButtonUpdateWebRootProduct_Click(object sender, EventArgs e)
        {
            var insertTask = new Task(() =>
            {
                string productIDString = null;
                long productID = 0;
                this.Invoke((MethodInvoker)delegate
                {
                    productIDString = textEditWebRootProductIDToInsert.Text;
                });
                try
                {
                    if (!string.IsNullOrEmpty(productIDString) && long.TryParse(productIDString, out productID))
                    {
                        WebRootProductCacheTool.InsertWebRootProductIntoCache(productID, _productConnectionString, _userConnectionString, _searchEnginesServiceUrl);
                        UpdateInsertWebRootProductStatus("Update Success");
                    }
                    else
                        UpdateInsertWebRootProductStatus("ProductID null or empty");
                }
                catch(Exception ex)
                {
                    UpdateInsertWebRootProductStatus(ex.Message);
                }

            });
            insertTask.Start();
        }
        private void UpdateInsertWebRootProductStatus(string message)
        {
            this.Invoke((MethodInvoker)delegate
               {
                   textEditInsertWebRootProductStatus.Text =
                           string.Format("[{0:MM-dd H:mm:ss}] - {1}", DateTime.Now, message);
               });
        }
        #endregion

        private bool isRunScheduleUpdateAllProduct;
        private void simpleButtonScheduleUpdateAllProduct_Click(object sender, EventArgs e)
        {
             var runScheduleTask = new Task(() =>
                {                    
                    DisableButton(simpleButtonScheduleUpdateAllProduct);
                    RunScheduleUpdateAllProduct();
                    EnableButton(simpleButtonScheduleUpdateAllProduct);
                });
            runScheduleTask.Start();
        }

        private void simpleButtonStopScheduleUpdateAllProduct_Click(object sender, EventArgs e)
        {
            isRunScheduleUpdateAllProduct = false;
        }
        private void RunScheduleUpdateAllProduct()
        {
            isRunScheduleUpdateAllProduct = true;
            while (isRunScheduleUpdateAllProduct)
            {
                Thread.Sleep(1000);
                if ((DateTime.Now.Hour != 0 && DateTime.Now.Hour != 12) || DateTime.Now.Minute < 30 || DateTime.Now.Minute > 35)
                    continue;
                Logger.Info("ScheduleUpdateAllProduct Task Started.");
                try
                {
                    WebRootProductCacheTool.InsertAllWebRootProductIntoCache(_productConnectionString, _userConnectionString, _searchEnginesServiceUrl);                    
                }
                catch (Exception ex)
                {
                    Logger.Error("InsertAllWebRootProductIntoCache Task Failed", ex);
                }
                try
                {
                    WebMerchantProductCacheTool.InsertAllWebMerchantProductToCache(_productConnectionString);
                }
                catch (Exception ex)
                {
                    Logger.Error("InsertAllWebMerchantProductToCache Task Failed", ex);
                }
                Logger.Info("ScheduleUpdateAllProduct Task finished.");
            }
            
        }
        #endregion

        #region MerchantShortInfo. Update at 0, 4, 8, 12, 16, 20 h daily
        private void simpleButtonInsertAllMerchantShortInfoToCache_Click(object sender, EventArgs e)
        {
            var insertTask = new Task(() =>
            {
                DisableButton(simpleButtonInsertAllMerchantShortInfoToCache);
                try
                {
                    WebMerchantCacheTool.InsertAllMerchantShortInfoToCache(_productConnectionString, _userConnectionString);
                }
                catch (Exception exception)
                {
                    Logger.Error("InsertAllMerchantShortInfoToCache", exception);
                }
                finally
                {
                    EnableButton(simpleButtonInsertAllMerchantShortInfoToCache);
                }

            });
            insertTask.Start();
        }



        private void simpleButtonInsertMerchantToCache_Click(object sender, EventArgs e)
        {
            var insertTask = new Task(() =>
            {
                string merchantIDString = null;
                long merchantID = 0;
                this.Invoke((MethodInvoker)delegate
                {
                    merchantIDString = textEditMerchantIDForInsertMerchantToCache.Text;
                });
                if (!string.IsNullOrEmpty(merchantIDString) && long.TryParse(merchantIDString, out merchantID))
                {
                    if(WebMerchantCacheTool.InsertMerchantShortInfoToCache(merchantID,_productConnectionString, _userConnectionString))
                        UpdateInsertMerchantByMerchantIDStatus("Update Success");
                    else
                        UpdateInsertMerchantByMerchantIDStatus("Merchant not exist");
                }
                else
                    UpdateInsertMerchantByMerchantIDStatus("MerchantID null or empty");

            });
            insertTask.Start();
        }
        private void UpdateInsertMerchantByMerchantIDStatus(string message)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textEditInsertMerchantToCacheStatus.Text =
                        string.Format("[{0:MM-dd H:mm:ss}] - {1}", DateTime.Now, message);
            });
        }

        private bool isRunScheduleUpdateMerchantToCache;
        private void simpleButtonScheduleUpdateMerchantToCache_Click(object sender, EventArgs e)
        {
            var scheduleTask = new Task(() =>
            {
                DisableButton(simpleButtonScheduleUpdateMerchantToCache);
                RunScheduleUpdateMerchantToCache();
                EnableButton(simpleButtonScheduleUpdateMerchantToCache);
            });
            scheduleTask.Start();
        }

        private void RunScheduleUpdateMerchantToCache()
        {
            isRunScheduleUpdateMerchantToCache = true;            
            while (isRunScheduleUpdateMerchantToCache)
            {
                Thread.Sleep(1000);
                if ((DateTime.Now.Hour != 0 && DateTime.Now.Hour != 8 && DateTime.Now.Hour != 12 && DateTime.Now.Hour != 16 && DateTime.Now.Hour != 20) || DateTime.Now.Minute > 0 || DateTime.Now.Second > 30)
                    continue;
                Logger.Info("ScheduleUpdateMerchantToCache Task Started.");
                try
                {
                    WebMerchantCacheTool.InsertAllMerchantShortInfoToCache(_productConnectionString,_userConnectionString);
                }
                catch (Exception ex)
                {

                    Logger.Error("ScheduleUpdateMerchantToCache Task Failed", ex);
                }
                Logger.Info("ScheduleUpdateMerchantToCache Task finished.");
                Thread.Sleep(30000);
            }
        }

        private void simpleButtonStopScheduleUpdateMerchantToCache_Click(object sender, EventArgs e)
        {
            isRunScheduleUpdateMerchantToCache = false;
        }
        #endregion

        #region MerchantBranch: Update at 0, 4, 8, 12, 16, 20 h daily
        private void simpleButtonInsertAllBranchesOfAllMerchantToCache_Click(object sender, EventArgs e)
        {
            var insertTask = new Task(() =>
            {
                DisableButton(simpleButtonInsertAllBranchesOfAllMerchantToCache);
                try
                {
                    WebMerchantCacheTool.InsertAllBranchesAndRegionsOfAllMerchant(_productConnectionString);
                }
                catch(Exception exception)
                {
                    Logger.Error("InsertAllBranchesAndRegionsOfAllMerchant", exception);
                }
                finally
                {
                    EnableButton(simpleButtonInsertAllBranchesOfAllMerchantToCache);
                }
            });
            insertTask.Start();
        }



        private void simpleButtonInsertMerchantBranchesToCache_Click(object sender, EventArgs e)
        {
            var insertTask = new Task(() =>
            {
                string merchantIDString = null;
                long merchantID = 0;
                this.Invoke((MethodInvoker)delegate
                {
                    merchantIDString = textEditMerchantIDForInsertMerchantBranchesToCache.Text;
                });
                if (!string.IsNullOrEmpty(merchantIDString) && long.TryParse(merchantIDString, out merchantID))
                {
                    var numBranch = WebMerchantCacheTool.InsertAllBranchesAndRegionsOfMerchant(merchantID, _productConnectionString);
                    UpdateInsertMerchantBranchesByMerchantIDStatus(string.Format("Update Success {0} {1}", numBranch, numBranch > 1? "branches" : "branch"));
                }
                else
                    UpdateInsertMerchantBranchesByMerchantIDStatus("MerchantID null or empty");

            });
            insertTask.Start();
        }
        private void UpdateInsertMerchantBranchesByMerchantIDStatus(string message)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textEditInsertMerchantBranchesToCacheStatus.Text =
                        string.Format("[{0:MM-dd H:mm:ss}] - {1}", DateTime.Now, message);
            });
        }
        private bool isRunScheduleUpdateAllBranchesOfAllMerchantsToCache;
        private void simpleButtonScheduleUpdateAllBranchesOfAllMerchantToCache_Click(object sender, EventArgs e)
        {
            var scheduleTask = new Task(() =>
                {
                    DisableButton(simpleButtonScheduleUpdateAllBranchesOfAllMerchantToCache);
                    RunScheduleUpdateAllBranchesOfAllMerchantsToCache();
                    EnableButton(simpleButtonScheduleUpdateAllBranchesOfAllMerchantToCache);
                });
            scheduleTask.Start();
        }
        private void RunScheduleUpdateAllBranchesOfAllMerchantsToCache()
        {
            isRunScheduleUpdateAllBranchesOfAllMerchantsToCache = true;               
            while (isRunScheduleUpdateAllBranchesOfAllMerchantsToCache)
            {
                Thread.Sleep(1000);
                if ((DateTime.Now.Hour != 0 && DateTime.Now.Hour != 8 && DateTime.Now.Hour != 12 && DateTime.Now.Hour != 16 && DateTime.Now.Hour != 20) || DateTime.Now.Minute > 0 || DateTime.Now.Second > 30)
                    continue;
                Logger.Info("ScheduleUpdateAllBranchesOfAllMerchantsToCache Task Started.");
                try
                {
                    WebMerchantCacheTool.InsertAllBranchesAndRegionsOfAllMerchant(_productConnectionString);
                }
                catch (Exception ex)
                {
                    Logger.Error("ScheduleUpdateAllBranchesOfAllMerchantsToCache Task Failed", ex);
                }
                Logger.Info("ScheduleUpdateAllBranchesOfAllMerchantsToCache Task finished.");
                Thread.Sleep(30000);
            }
        }
        private void simpleButtonStopScheduleUpdateAllBranchesOfAllMerchantToCache_Click(object sender, EventArgs e)
        {
            isRunScheduleUpdateAllBranchesOfAllMerchantsToCache = false;
        }
        #endregion


        #region Product Properties. Update at 7, 13, 18 h daily
        private void simpleButtonInsertAllProductProperties_Click(object sender, EventArgs e)
        {
            var insertTask = new Task(() =>
            {
                DisableButton(simpleButtonInsertAllProductProperties);
                try
                {
                    WebProductPropertyCacheTool.InsertProductPropertiesToCache(_productConnectionString);
                }
                catch (Exception exception)
                {
                    Logger.Error("InsertAllWebRootProductIntoCache", exception);
                }
                finally
                {
                    EnableButton(simpleButtonUpdateAllRootProduct);
                }
                EnableButton(simpleButtonInsertAllProductProperties);
            });
            insertTask.Start();
        }

        private void RunScheduleUpdateAllProductProperties()
        {
            isRunScheduleUpdateAllProductProperties = true;            
            while (isRunScheduleUpdateAllProductProperties)
            {
                Thread.Sleep(1000);
                if ((DateTime.Now.Hour != 7 && DateTime.Now.Hour != 13 && DateTime.Now.Hour != 18) || DateTime.Now.Minute > 0 || DateTime.Now.Second > 20)
                    continue;
                Logger.Info("ScheduleUpdateAllProductProperties Task Started.");
                try
                {
                    WebProductPropertyCacheTool.InsertProductPropertiesToCache(_productConnectionString);
                }
                catch (Exception ex)
                {
                    Logger.Error("ScheduleUpdateAllProductProperties Task Failed", ex);
                }
                Logger.Info("ScheduleUpdateAllProductProperties Task finished.");
                Thread.Sleep(30000);
            }
        }

        private bool isRunScheduleUpdateAllProductProperties;
        private void simpleButtonScheduleUpdateAllProductProperties_Click(object sender, EventArgs e)
        {
            var scheduleTask = new Task(() => {
                DisableButton(simpleButtonScheduleUpdateAllProductProperties);
                RunScheduleUpdateAllProductProperties();
                EnableButton(simpleButtonScheduleUpdateAllProductProperties);
            });
            scheduleTask.Start();
        }
        private void simpleButtonStopScheduleUpdateAllProductProperties_Click(object sender, EventArgs e)
        {
            isRunScheduleUpdateAllProductProperties = false;
        }
        #endregion

        #region Build PriceLog
        private void simpleButtonBuildRootProductPriceLog_Click(object sender, EventArgs e)
        {
            var buildTask = new Task(() =>
            {
                DisableButton(simpleButtonBuildRootProductPriceLog);
                try
                {
                    var allProductIdentities = ProductIdentityBAL.GetListCompletedProductIdentity(_productConnectionString);
                    Logger.InfoFormat("BuildRootProductPriceLog. Get {0} rootProductID", allProductIdentities.Count);
                    int insertedCount = 0;
                    foreach (var productIdentity in allProductIdentities)
                    {
                        if(InsertRootProductPriceLog(productIdentity.ProductID))
                        insertedCount++;
                    }
                    Logger.InfoFormat("BuildRootProductPriceLog. Insert {0}/{1} rootProductID",insertedCount, allProductIdentities.Count);
                }
                catch(Exception exception)
                {
                    Logger.Error("BuildRootProductPriceLog", exception);
                }
                finally
                {
                    EnableButton(simpleButtonBuildRootProductPriceLog);
                }
            });
            buildTask.Start();
        }
        /// <summary>
        /// Use for build price log from scratch only!
        /// </summary>
        /// <param name="rootProductID"></param>
        /// <returns></returns>
            private bool InsertRootProductPriceLog(long rootProductID)
            {
                var filledPricelogDict = new Dictionary<DateTime, Dictionary<long, long>>();
                var storedPriceLogDict = new Dictionary<long, List<KeyValuePair<DateTime, long>>>();
                var startTime = DateTime.Now;
                var rootProductMapping = RootProductMappingBAL.GetRootProductMappingFromCache(rootProductID, 0, RootProductMappingSortType.PriceWithVAT,false);
                if (rootProductMapping == null)
                    return false;
                if (rootProductMapping.ListMerchantProducts == null)
                {
                    Logger.WarnFormat("rootProductMapping.ListProductID = NULL. ProductID: {0}, numProduct: {1}", rootProductID, rootProductMapping.NumMerchant);
                    return false;
                }
                var productIDs = new List<long>();
                foreach (var merchantProducts in rootProductMapping.ListMerchantProducts)
                {
                    productIDs.AddRange(merchantProducts.Value);
                }
                foreach (long productID in productIDs)
                {
                    var productPriceLog = RedisPriceLogAdapter.GetMerchantProductPriceLog(productID);
                    if (productPriceLog.Count > 0)
                        storedPriceLogDict.Add(productID, productPriceLog.Select(x => new KeyValuePair<DateTime, long>(x.Key.Date, x.Value)).ToList());
                }
                var getRedisDuration = (DateTime.Now - startTime).TotalMilliseconds;
                var keyValueComparer = new KeyValueComparer();
                foreach (var merchantProductPricelog in storedPriceLogDict)
                {
                    var priceLogList = merchantProductPricelog.Value;
                    foreach (var priceLogEntry in priceLogList)
                    {
                        if (!filledPricelogDict.ContainsKey(priceLogEntry.Key))
                            filledPricelogDict.Add(priceLogEntry.Key, new Dictionary<long, long>());
                        //Fill All merchantProduct Price value
                        foreach (var merchantProductPricelog2 in storedPriceLogDict)
                        {
                            //if(filledPricelogDict.[priceLogEntry.Key])
                            var merchantProductID = merchantProductPricelog2.Key;
                            int logEntryIndex = storedPriceLogDict[merchantProductID].BinarySearch(priceLogEntry, keyValueComparer);
                            if (logEntryIndex >= 0)
                            {
                                filledPricelogDict[priceLogEntry.Key][merchantProductID] = storedPriceLogDict[merchantProductID][logEntryIndex].Value;
                            }
                            else
                            {
                                var nextEntryIndex = ~logEntryIndex;
                                if (nextEntryIndex > 0)
                                    filledPricelogDict[priceLogEntry.Key][merchantProductID] = storedPriceLogDict[merchantProductID][nextEntryIndex - 1].Value;
                                //else
                                //    filledPricelogDict[priceLogEntry.Key][merchantProductID] = storedPriceLogDict[merchantProductID][nextEntryIndex].Value;
                            }
                        }
                    }
                }
                var rootPriceLog = new List<KeyValuePair<DateTime, long[]>>();
                foreach (var filledPricelogEntry in filledPricelogDict)
                {
                    var priceList = filledPricelogEntry.Value.Values;
                    RedisPriceLogAdapter.PushRootProductPrice(rootProductID, priceList.Min(), priceList.Max(), priceList.Sum() / priceList.Count, filledPricelogEntry.Key);
                }
                return true;
            }        
        public class KeyValueComparer : IComparer<KeyValuePair<DateTime,long>>
        {
            public int Compare(KeyValuePair<DateTime, long> x, KeyValuePair<DateTime, long> y)
            {
                if (x.Key > y.Key)
                    return 1;
                if (x.Key < y.Key)
                    return -1;
                return 0;
            }
        }
        #endregion
        #region Build Category. Run continuous

        private void simpleButtonBuildProductCategory_Click(object sender, EventArgs e)
        {
            var runTask = new Task(() =>
            {
                DisableButton(simpleButtonBuildProductCategory);
                try
                {
                    ProductCategorizationTool.BuildCategory(_productConnectionString);
                }
                catch (Exception ex)
                {
                    Logger.Error("Build Category exception", ex);
                }
                EnableButton(simpleButtonBuildProductCategory);
            });
            runTask.Start();
        }
        private bool isRunScheduleUpdateProductCategory;
        private void simpleButtonScheduleUpdateProductCategory_Click(object sender, EventArgs e)
        {
            var runTask = new Task(() =>
            {
                DisableButton(simpleButtonBuildProductCategory);
                RunScheduleUpdateProductCategory();
                EnableButton(simpleButtonBuildProductCategory);
            });
            runTask.Start();
        }

        private void RunScheduleUpdateProductCategory()
        {
            isRunScheduleUpdateProductCategory = true;
            while (isRunScheduleUpdateProductCategory)
            {
                try
                {
                    Logger.Info("ScheduleBuildCategory Task Started.");
                    ProductCategorizationTool.BuildCategory(_productConnectionString);
                    Logger.Info("ScheduleBuildCategory Task Finished.");
                }
                catch (Exception ex)
                {
                    Logger.Error("Build Category exception", ex);
                }
            }
        }

        private void simpleButtonStopScheduleUpdateProductCategory_Click(object sender, EventArgs e)
        {
            isRunScheduleUpdateProductCategory = false;
        }
        #endregion
        #region Build NameHash. Run 06:00 and 17: 00 daily.
        private void simpleButtonBuildProductHash_Click(object sender, EventArgs e)
        {
            var runTask = new Task(() =>
            {
                DisableButton(simpleButtonBuildProductHash);
                ProductNameHashTool.BuildNameHash(_productConnectionString);
                EnableButton(simpleButtonBuildProductHash);
            });
            runTask.Start();
        }

        private bool isRunScheduleUpdateProductHash;
        private void simpleButtonScheduleUpdateProductHash_Click(object sender, EventArgs e)
        {
            var scheduleTask = new Task(() =>
                {
                    DisableButton(simpleButtonScheduleUpdateProductHash);
                    RunScheduleUpdateProductHash();
                    EnableButton(simpleButtonScheduleUpdateProductHash);
                });
            scheduleTask.Start();
            
        }

        private void RunScheduleUpdateProductHash()
        {
            isRunScheduleUpdateProductHash = true;
            while (isRunScheduleUpdateProductHash)
            {
                Thread.Sleep(1000);
                if ((DateTime.Now.Hour != 6 && DateTime.Now.Hour != 17) || DateTime.Now.Minute > 0 || DateTime.Now.Second > 20)
                    continue;
                Logger.Info("ScheduleUpdateProductHash Task Started.");
                ProductNameHashTool.BuildNameHash(_productConnectionString);
                Logger.Info("ScheduleUpdateProductHash Task Finished.");
            }
        }

        private void simpleButtonStopScheduleUpdateProductHash_Click(object sender, EventArgs e)
        {
            isRunScheduleUpdateProductHash = false;
        }
        #endregion

        #region Online Friday
        private void simpleButtonScanOnlineFridayProducts_Click(object sender, EventArgs e)
        {
            var runTask = new Task(() =>
            {
                DisableButton(simpleButtonScanOnlineFridayProducts);
                try
                {
                    ScanOnlineFridayProduct();
                }
                catch (Exception ex)
                {
                    Logger.Error("ScanOnlineFridayProduct", ex);
                }
                EnableButton(simpleButtonScanOnlineFridayProducts);
            });
            runTask.Start();
        }

        private bool isRunScheduleScanOnlineFridayProducts;
        private void simpleButtonScheduleScanOnlineFridayProducts_Click(object sender, EventArgs e)
        {
            var task = new Task(() =>
            {
                DisableButton(simpleButtonScheduleScanOnlineFridayProducts);
                RunScheduleScanOnlineFridayProducts();
                EnableButton(simpleButtonScheduleScanOnlineFridayProducts);
            });
            task.Start();
        }

        private void RunScheduleScanOnlineFridayProducts()
        {
            isRunScheduleScanOnlineFridayProducts = true;
            while (isRunScheduleScanOnlineFridayProducts)
            {
                Thread.Sleep(1000);
                if (DateTime.Now.Minute > 3 || DateTime.Now.Hour % 6 > 0)
                    continue;
                Logger.Info("ScheduleScanOnlineFridayProducts Task Started.");
                try
                {
                    ScanOnlineFridayProduct();
                }
                catch (Exception ex)
                {
                    Logger.Error("ScheduleScanOnlineFridayProducts Task Failed", ex);
                }
                Logger.Info("ScheduleScanOnlineFridayProducts Task finished.");
                Thread.Sleep(30000);
            }
        }
        private void simpleButtonStopScheduleScanOnlineFridayProducts_Click(object sender, EventArgs e)
        {
            isRunScheduleScanOnlineFridayProducts = false;
        }
        private void ScanOnlineFridayProduct()
        {
            var startTime = DateTime.Now;
            var getTotalResult = GetOnlineFridayResult(0, 1);
            var totalProduct = getTotalResult.total;
            Logger.InfoFormat("Total Products: {0}",totalProduct);
            if (ProductNameHashTool.ProductIdentitiesDict == null)
                ProductNameHashTool.BuildProductIdentitiesDict(_productConnectionString);
            int taskNum = 16;
            var taskSize = totalProduct / taskNum;

            int[] haveRootID = new int[taskNum];
            int[] haveHashID = new int[taskNum];
            int[] haveNerID = new int[taskNum];
            var runTasks = new Task[taskNum];
            for (int i = 0; i < taskNum; i++)
            {
                var taskIndex = i;
                int start = taskIndex * taskSize;
                int size = taskIndex < taskNum - 1 ? taskSize : taskSize + 200;
                runTasks[taskIndex] = new Task(() => RunScanOnlineFridayProductPart(start, size, out haveRootID[taskIndex], out haveHashID[taskIndex], out haveNerID[taskIndex]));
                runTasks[taskIndex].Start();
            }
            Task.WaitAll(runTasks);
            var duration = (DateTime.Now - startTime).TotalSeconds;
            Logger.InfoFormat("Scan OnlineFriday complete. Time: {0} s. Total product: {1}. HaveRootID: {2}. HaveHashID: {3}. Have NerID: {4}", duration, totalProduct, haveRootID.Sum(), haveHashID.Sum(), haveNerID.Sum());
        }

        private void RunScanOnlineFridayProductPart(int start,int partSize, out int haveRootID, out int haveHashID, out int haveNerID)
        {
            const int limit = 60;
            haveRootID = 0;
            haveHashID = 0;
            haveNerID = 0;
            for (int i = start; i < start + partSize; i = i + limit)
            {
                var result = GetOnlineFridayResult(i, i+limit <= start + partSize ? limit :  start + partSize - i);
                if (result.data != null)
                    foreach (var product in result.data)
                    {
                        var startTime = DateTime.Now;
                        string clusterID = Tools.getuCRC64(product.url + "wss").ToString();
                        if (ProductNameHashTool.ProductIdentitiesDict == null)
                            ProductNameHashTool.BuildProductIdentitiesDict(_productConnectionString);

                        int minPrice = 0;
                        long wssID = ProductNameHashTool.IdentifyProduct(product.product_name, (long) product.sale_price);
                        if (wssID != 0)
                        {
                            var rootProductMapping = RootProductMappingBAL.GetRootProductMappingFromCache(wssID, 0,
                                RootProductMappingSortType.PriceWithVAT,false);
                            if (rootProductMapping == null)
                            {
                                RootProductMappingCacheTool.InsertRootProductMappingCache(wssID, _searchEnginesServiceUrl);
                                rootProductMapping = RootProductMappingBAL.GetRootProductMappingFromCache(wssID, 0,
                                    RootProductMappingSortType.PriceWithVAT,false);
                            }
                            if (rootProductMapping != null)
                            {
                                haveRootID++;
                                minPrice = (int) rootProductMapping.MinPrice;
                                OnlineFridayIDBAL.InsertID(clusterID, wssID, 1);
                                Logger.InfoFormat("Have RootId,{0},{1}", product.product_name, wssID);
                            }
                            else
                                wssID = 0;
                        }
                        if (wssID == 0)
                        {
                            //Use IdentityMapping
                            //List<long> productIDs = GetOnlineFridayProductMap(product.product_name);
                            //if (productIDs != null && productIDs.Count > 0)
                            //{
                            //    var products = WebMerchantProductBAL.GetWebMerchantProductsFromCache(productIDs);
                            //    if (products.Count > 0)
                            //    {
                            //        minPrice = (int)products.Min(x => x.Value.Price);
                            //        haveNerID++;
                            //        wssID = Tools.getCRC32(product.url + "wss");
                            //        OnlineFridayIDBAL.InsertID(clusterID, wssID, 3);
                            //        ProductNameHashBAL.InsertOnlineFridayProductMapSet(wssID, productIDs);
                            //        Logger.InfoFormat("HaveNer,{0},{1},{2} products", product.product_name, wssID, products.Count);
                            //    }}
                        }
                        if (wssID == 0)
                        {
                            ProductNameLogger.InfoFormat("Unrecognized! Name: {0} - Price: {1}", product.product_name, product.sale_price);
                            List<KeyValuePair<long, long>> productID;
                            int rootID;
                            ProductNameHashBAL.GetListProductByName(product.product_name, out productID, out minPrice,
                                out rootID, out wssID);
                            if (productID.Count > 0)
                            {
                                haveHashID++;
                                OnlineFridayIDBAL.InsertID(clusterID, wssID, 2);
                            }
                            else
                                wssID = 0;
                        }
                        if (wssID != 0)
                        {
                            if (UpdateOnlineFridayProduct((long) product.product_id, minPrice, clusterID));
                        }
                        else 
                        {
                            //if (!string.IsNullOrEmpty(product.cluster_id_wss))
                            //{
                            //    long clusterId;
                            //    long.TryParse(product.cluster_id_wss, out clusterId);
                            //    if (clusterId != 0)
                            //        UpdateOnlineFridayProduct((long) product.product_id, 0, "0");
                            //}
                        }
                        Logger.DebugFormat("Product run duration: {0:0.00} ms",(DateTime.Now-startTime).TotalMilliseconds);
                    }
            }
            Logger.InfoFormat("RunScanOnlineFridayProductPart Task at offset {0} completed! Total product: {1}. HaveRootID: {2}. HaveHashID: {3}. Have NerID: {4}",start,partSize,haveRootID,haveHashID,haveNerID);
        }

        private OnlineFridayResult GetOnlineFridayResult(int offset, int limit)
        {
            var start = DateTime.Now;
            var result = new OnlineFridayResult();
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    string urlFormat = "http://api.onlinefriday.vn/api/websosanh?type=1&limit={1}&offset={0}&key=92aabeacf70eeaa892b9e99a3b11c9e5";
                    using (WebClient client = new WebClient())
                    {
                        client.Headers.Add("Accept-Language", " en-US");
                        client.Headers.Add("Accept-Encoding", "gzip, deflate");
                        client.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
                        client.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)");
                        client.Encoding = Encoding.UTF8;
                        string url = string.Format(urlFormat, offset, limit);
                        string s = client.DownloadString(url);
                        result = JsonConvert.DeserializeObject<OnlineFridayResult>(s);
                    }
                }
                catch (Exception ex)
                {
                    if (i == 9)
                    Logger.Error("GetOnlineFridayResult", ex);
                    Thread.Sleep(100);
                }
            }
            var duration = (DateTime.Now - start).TotalMilliseconds;
            Logger.DebugFormat("GetOnlineFridayResult. Offset: {0} - Limit: {1} - Time: {2} ms)",offset,limit,duration);
            return result;
        }

        private bool UpdateOnlineFridayProduct(long productID, int price, string cluster_Id)
        {
            var startTime = DateTime.Now;
            for (int i = 0; i < 10; i++)
            {
                string url = "";
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Headers.Add("Accept-Language", " en-US");
                        client.Headers.Add("Accept-Encoding", "gzip, deflate");
                        client.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
                        client.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)");
                        client.Encoding = Encoding.UTF8;
                        url = string.Format("http://api.onlinefriday.vn/api/websosanh?type=2&product_id={0}&market_price={1}&cluster_id={2}&key=92aabeacf70eeaa892b9e99a3b11c9e5", productID, price, cluster_Id);
                        string s = client.DownloadString(url);
                        var result = JsonConvert.DeserializeObject<OnlineFridayUpdateResult>(s);
                        return result.error == 0;
                    }
                }
                catch (Exception ex)
                {
                    if (i == 9)
                        Logger.Error("Update OF Price Error. Url: " + url, ex);
                    Thread.Sleep(100);
                }
                
            }
            var duration = (DateTime.Now - startTime).TotalMilliseconds;
            if(duration > 1000)
                Logger.DebugFormat("UpdateOnlineFridayProduct. - Time: {0:0.00} ms)", duration);
            return false;
        }

        private List<long> GetOnlineFridayProductMap(string productName)
        {
            var cacheServer = Websosanh.Core.Drivers.Caching.CacheManager.GetCacheServer("ProductMap");
            string url = string.Format("http://172.22.1.108/api/NerApi/recog.htm?text={0}&size=100", Uri.EscapeUriString(productName.Replace(':',' ')));
            List<long> result = cacheServer.Get<List<long>>(url,false);
            if (result == null)
            {
                
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Headers.Add("Accept-Language", " en-US");
                        client.Headers.Add("Accept-Encoding", "gzip, deflate");
                        client.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
                        client.Headers.Add("User-Agent",
                            "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)");
                        client.Encoding = Encoding.UTF8;
                        var startTime = DateTime.Now;
                        string s = client.DownloadString(url);
                        var duration = (DateTime.Now - startTime).TotalMilliseconds;
                        if (duration > 3000)
                            Logger.DebugFormat("GetOnlineFridayProductMap. Name: {0}, - Time: {1:0.00} ms)", productName, duration);
                        var recognResult = JsonConvert.DeserializeObject<OnlineFridayProductMappingResult>(s);
                        result = (recognResult.answer != null && recognResult.answer.Length > 0)
                            ? recognResult.answer.ToList()
                            : new List<long>();
                        cacheServer.Set(url, result, false, new TimeSpan(10, 0, 0, 0));
                    }
                }
                catch (Exception ex)
                {
                        Logger.Error("GetOnlineFridayProductMap Error. url:" + url, ex);
                        result = null;
                }
                
            }
            
            return result;
        }

        public class OnlineFridayProductMappingResult
        {
            public long[] answer;
            public string text;
        }
        #endregion
        private void simpleButtonDetectRootProduct_Click(object sender, EventArgs e)
        {
            if (ProductNameHashTool.ProductIdentitiesDict == null)
                ProductNameHashTool.BuildProductIdentitiesDict(_productConnectionString);
            var input = textEditProductName.Text.Split('|');
            string name = input[0];
            long price = long.Parse(input[1]);
            long rootID = ProductNameHashTool.IdentifyProduct(name,price);
            textEditDetectionResult.Text = rootID.ToString();
            return;
        }
        private void simpleButtonTestDetectUnit_Click(object sender, EventArgs e)
        {
            var merchantID = long.Parse(textEditIDMerchantToTestDetectUnit.Text);
            var products = WebMerchantProductBAL.GetListWebMerchantProductsOfCompany(merchantID, _productConnectionString);
            var numProducs = products.Count;
            var numProductHaveUnit = 0;
            var startTime = DateTime.Now;
            foreach (var product in products)
            {
                var otherName = UnitNormalization.GetUnitNormalizedName(product.Name);
                if (otherName.Count > 0)
                    numProductHaveUnit++;
            }
            var duration = (DateTime.Now - startTime).TotalSeconds;
            Logger.InfoFormat("NumProduct: {0}. NumFound: {1}. Time: {2} s", numProducs, numProductHaveUnit, duration);
        }
        

        private void simpleButtonScanCGDProducts_Click(object sender, EventArgs e)
        {
            var getTotalResult = GetOnlineFridayResult(0, 1);
             var totalProduct = getTotalResult.total;
            int pageSize = 50;
            int cgdProduct = 0;
            int wssProduct = 0;
            int notHave = 0;
            for (int i = 0; i < totalProduct; i = i + pageSize)
            {
                var result = GetOnlineFridayResult(i, pageSize);
                if(result.data != null)
                    foreach (var product in result.data)
                    {
                        bool cgd = false;
                        bool wss = false;
                        if (!string.IsNullOrEmpty(product.cluster_id) && !string.IsNullOrEmpty(product.market_price) && Int32.Parse(product.market_price) > 0)
                            cgd = true;
                        if (!string.IsNullOrEmpty(product.cluster_id_wss) && !string.IsNullOrEmpty(product.market_price_wss) && Int32.Parse(product.market_price_wss) > 0)
                            wss = true;
                        if(cgd)
                            cgdProduct++;
                        if (wss)
                            wssProduct++;
                        if (cgd && !wss)
                            notHave++;
                    }
            }
            return;
        }

        private void simpleButtonTestGetNameLength_Click(object sender, EventArgs e)
        {
            var merchantID = long.Parse(textEditIDMerchantToTestNameLength.Text);
            var products = WebMerchantProductBAL.GetListWebMerchantProductsOfCompany(merchantID, _productConnectionString);
            var numProducs = products.Count;
            var startTime = DateTime.Now;
            foreach (var product in products)
            {
                var nameLength =
                    product.Name.Split(SolrProductConstants.IGNORE_CHARS.ToCharArray(),
                        StringSplitOptions.RemoveEmptyEntries).Length;
            }
            var duration = (DateTime.Now - startTime).TotalSeconds;
            Logger.InfoFormat("NumProduct: {0}. Time: {1} s", numProducs, duration);
        }

        private void buttonGetAllOnlineFridayProductName_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                DisableButton(buttonGetAllOnlineFridayProductName);
                var getTotalResult = GetOnlineFridayResult(0, 1);
                var totalProduct = getTotalResult.total;
                var allName = new StringBuilder();
                for (int i = 0; i < totalProduct; i +=60)
                {
                    var resultPart = GetOnlineFridayResult(i, 60);
                    foreach (var product in resultPart.data)
                    {
                        allName.AppendLine(string.Join(",",product.product_name,product.original_price,product.category_id,product.category_name));
                    }
                }
                File.WriteAllText("C:\\Users\\vuhoang\\Desktop\\OFProductName.csv",allName.ToString(),Encoding.UTF8);
                EnableButton(buttonGetAllOnlineFridayProductName);
            });
        }

        private void simpleButtonFixRootProductUrl_Click(object sender, EventArgs e)
        {
            
            
            Task.Run(() =>
            {
                if (ProductNameHashTool.ProductIdentitiesDict == null)
                    ProductNameHashTool.BuildProductIdentitiesDict(_productConnectionString);
                var rootProductSummaryDataAccess = new RootProductSummaryDataAccess(_productConnectionString);
                var productSummaryList = rootProductSummaryDataAccess.GetProductsWhichSummaryNotEqualName();
                int count = 0;
                int nothaveRootProductCount = 0;
                int obsolatedProductCount = 0;
                foreach (var productSummary in productSummaryList)
                {
                    var rootProduct = WebRootProductBAL.GetWebRootProductFromCache(productSummary.ID);
                    if (rootProduct == null)
                    {
                        nothaveRootProductCount ++;
                        continue;
                    }
                    if(rootProduct.NumProduct == 0)
                    {
                        obsolatedProductCount++;
                        continue;
                    }
                    long rootID = ProductNameHashTool.IdentifyProduct(productSummary.Summary, rootProduct.Price);
                    if (rootID == productSummary.ID)
                        continue;
                    var coverRatio = ProductNameAnalyser.MeasureNameCoverRatioForSummary(rootProduct.Name, productSummary.Summary);
                    if (coverRatio >= 0.3)
                        continue;
                    count ++;
                    rootProductSummaryDataAccess.UpdateProductSummaryByName(productSummary.ID);
                    Logger.DebugFormat("Name: {0} | Summary: {1} | Ratio: {2:0.00}", rootProduct.Name, productSummary.Summary,coverRatio);
                }
                Logger.InfoFormat("Number product Url need to fix: {0}.",  count);
                Logger.InfoFormat("Number product not have RootMapping: {0}.", nothaveRootProductCount);
            });
        }





    }
}
