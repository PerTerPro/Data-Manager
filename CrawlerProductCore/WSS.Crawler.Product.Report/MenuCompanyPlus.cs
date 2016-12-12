using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Moduls.CrawlerProduct.Comment;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using WSS.Service.Crawler.Consumer.FindNew;
using System.Data;
using System.Threading;
using log4net;
using QT.Entities.CrawlerProduct;
using QT.Moduls;
using QT.Moduls.Company;
using WSS.Core.Crawler;
using Job = Websosanh.Core.JobServer.Job;
using QT.Moduls.RabbitMQ;
using QT.Entities.Images;
using SolrNet.Impl.FieldParsers;
using QT.Entities;


namespace WSS.Crawler.Product.Report
{
    public class MenuCompanyPlus : ContextMenuStrip
    {
        public delegate string DelegateGetSession();
        public DelegateGetSession eventGetSession;
        public delegate long DelegateGetCompanyID();
        public DelegateGetCompanyID eventGetCompanyHandle = null;
        public delegate long DelegateGetProductID();
        public DelegateGetProductID eventGetProductID = null;
        public delegate List<long> DelegateGetCompanys();
        public DelegateGetCompanys eventGetCompanys = null;
        public delegate Dictionary<long, List<long>> DelegateGetProductss();
        public DelegateGetProductss eventGetProductIDs = null;
        private ILog log = LogManager.GetLogger(typeof(MenuCompanyPlus));

        public MenuCompanyPlus()
        {

        }

        public void Init()
        {
            if (eventGetCompanyHandle != null)
            {

                var itemFnInputLinkStart = new ToolStripMenuItem
                {
                    Text = @"FN_InputLinkStart",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemFnInputLinkStart);
                itemFnInputLinkStart.Click += new EventHandler(delegate(object o, EventArgs args)
                {
                    long companyID = eventGetCompanyHandle();
                    FrmCrawlerManal frm = new FrmCrawlerManal(companyID);
                    frm.Show();
                    frm.Start(true, FrmGetLink.GetLinks());
                });

                var itemViewHistoryCrawlerCompnay = new ToolStripMenuItem
                {
                    Text = @"HistoryCrawler",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemViewHistoryCrawlerCompnay);
                itemViewHistoryCrawlerCompnay.Click += new EventHandler(ViewHistoryCrawlerCompany);


                var itemConfig = new ToolStripMenuItem
                {
                    Text = @"Config",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemConfig);
                itemConfig.Click += new EventHandler(SetConfig);

                var itemViewDuplicateProduct = new ToolStripMenuItem
                {
                    Text = @"View_Duplicate",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemViewDuplicateProduct);
                itemViewDuplicateProduct.Click += new EventHandler(ViewDuplicateProduct);

                var itemViewProductInSqlDb = new ToolStripMenuItem
                {
                    Text = @"View_Product_SQL",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemViewProductInSqlDb);
                itemViewProductInSqlDb.Click += new EventHandler(ViewProductInDb);

                var itemProductInCache = new ToolStripMenuItem
                {
                    Text = @"View_Product_Cache",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemProductInCache);
                itemProductInCache.Click += new EventHandler(ViewProductInCache);

                var itemRefreshCacheCompany = new ToolStripMenuItem
                {
                    Text = @"Refresh Cache",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemRefreshCacheCompany);
                itemRefreshCacheCompany.Click += new EventHandler(RefreshCacheCompany);

                var itemScoreProduct = new ToolStripMenuItem
                {
                    Text = @"ViewScoreProduct",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemScoreProduct);
                itemScoreProduct.Click += new EventHandler(ViewScoreLastUpdateProduct);

                var itemPushDesription = new ToolStripMenuItem
                {
                    Text = @"PushDescription",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemPushDesription);
                itemScoreProduct.Click += new EventHandler(PushDescription);
            } 
            
            if (eventGetProductIDs != null)
            {
                var itemLoadSetLastUpdateIncache = new ToolStripMenuItem
                {
                    Text = @"Set LastUpdate to First",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemLoadSetLastUpdateIncache);
                itemLoadSetLastUpdateIncache.Click += new EventHandler(ClickUpdateLastUpdateToFisrt);

                var itemPushDownloadImage = new ToolStripMenuItem
                {
                    Text = @"Push_DownloadImage",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemPushDownloadImage);
                itemPushDownloadImage.Click += new EventHandler(ClickPushToDownloadImage);



                var itemPushIndexToSolr = new ToolStripMenuItem
                {
                    Text = @"Push_IndexToSolr",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemPushIndexToSolr);
                itemPushIndexToSolr.Click += new EventHandler(ClickPushToDownloadImage);

                var itemBlackListProduct = new ToolStripMenuItem
                {
                    Text = @"SetBlackListProduct",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemBlackListProduct);
                itemBlackListProduct.Click += new EventHandler(ClickSetBlackList);

                var itemCopyProductIdsToClipboad = new ToolStripMenuItem
                {
                    Text = @"CopyProductIdsToClipboad",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemCopyProductIdsToClipboad);
                itemCopyProductIdsToClipboad.Click += new EventHandler(ClickitemCopyProductIdsToClipboad);
            }

            if (eventGetSession != null)
            {
                var itemViewReload = new ToolStripMenuItem
                {
                    Text = @"View_Product_Session",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemViewReload);
                itemViewReload.Click += new EventHandler(ViewSessionReload);

                var itemViewFindNew = new ToolStripMenuItem
                {
                    Text = @"View_FN_Session",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemViewFindNew);
                itemViewFindNew.Click += new EventHandler(ViewSessionFindNew);
            }

            if (eventGetProductID != null)
            {
                var itemViewHistoryChangeProduct = new ToolStripMenuItem
                {
                    Text = @"HistoryChangeByProduct",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemViewHistoryChangeProduct);
                itemViewHistoryChangeProduct.Click += new EventHandler(ViewHistoryChangeProduct6);
            }

            if (eventGetCompanys != null)
            {
                var itemFn = new ToolStripMenuItem { Text = @"FN", TextImageRelation = TextImageRelation.ImageBeforeText };

                Items.Add(itemFn);
                itemFn.Click += new EventHandler(delegate(object o, EventArgs args)
                {
                    foreach (var VARIABLE in eventGetCompanys())
                    {
                        FrmCrawlerManal frm = new FrmCrawlerManal(VARIABLE);
                        frm.Show();
                        frm.Start(bFN: true);
                    }
                });




                var itemRl = new ToolStripMenuItem
                {
                    Text = @"RL",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemRl);
                itemRl.Click += new EventHandler(delegate(object o, EventArgs args)
                {
                    foreach (var VARIABLE in eventGetCompanys())
                    {
                        FrmCrawlerManal frm = new FrmCrawlerManal(VARIABLE);
                        frm.Show();
                        frm.Start(false);
                    }

                });

                var itemPushToQueueCrawler = new ToolStripMenuItem
                {
                    Text = @"Push_FN",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemPushToQueueCrawler);
                itemPushToQueueCrawler.Click += new EventHandler(PushQueueCrawlerFindNew);


                var itemPushToQueueReload = new ToolStripMenuItem
                {
                    Text = @"Push_RL",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemPushToQueueReload);
                itemPushToQueueReload.Click += new EventHandler(PushQueueCrawlerReload);

                var itemPushResetDuplicate = new ToolStripMenuItem
                {
                    Text = @"Push_ResetDuplicate",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemPushResetDuplicate);
                itemPushResetDuplicate.Click += new EventHandler(PushResetDuplicateCompany);

                var itemPushResetCacheProduct = new ToolStripMenuItem
                {
                    Text = @"Push_ResetCacheProduct",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemPushResetCacheProduct);
                itemPushResetCacheProduct.Click += new EventHandler(PushResetCacheCompany);

                var itemCopyCompanyIdsToClipboard = new ToolStripMenuItem
                {
                    Text = @"CopyCompanyIdsToClipboard",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemCopyCompanyIdsToClipboard);
                itemCopyCompanyIdsToClipboard.Click += new EventHandler(CopyCompanyIDToClipboard);

                var itemPushUpdateInfoToWeb = new ToolStripMenuItem
                {
                    Text = @"Push_UpdateCompanyInfoToWeb",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemPushUpdateInfoToWeb);
                itemPushUpdateInfoToWeb.Click += new EventHandler(ClickUpdateCompanyInfoToWeb);

                var itemDownloadHtml = new ToolStripMenuItem
                {
                    Text = @"PushDownloadHtm",
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };
                Items.Add(itemDownloadHtml); itemDownloadHtml.Click += new EventHandler(PushDownloadHtml);
            }
        }

        private void ClickUpdateCompanyInfoToWeb(object sender, EventArgs e)
        {
            var companyIds = eventGetCompanys();
            ProducerBasic producer = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqProduct), "UpdateCompany.ToWeb");
            foreach (var companyId in companyIds)
            {
                producer.PublishString(companyId.ToString());
            }
            MessageBox.Show(string.Format("Pushed {0}!", companyIds.Count));
        }

        private void SetConfig(object sender, EventArgs e)
        {
            long companyId = eventGetCompanyHandle();
            frmCongTy frm = new frmCongTy();
            frm.SelectCompany(companyId);
            frm.Show();
        }
        private void ClickitemCopyProductIdsToClipboad(object sender, EventArgs e)
        {
            var lstProductId = this.eventGetProductIDs();
            Clipboard.Clear();
            Clipboard.SetText(string.Join("\n", lstProductId.ElementAt(0).Value));
        }
        private void ViewDuplicateProduct(object sender, EventArgs e)
        {
            long company = eventGetCompanyHandle();
            FrmViewDuplicateProduct frm = new FrmViewDuplicateProduct();
            frm.LoadByCompany(company);
            frm.Show();
        }
        private void PushQueueCrawlerFindNew(object sender, EventArgs e)
        {
            ProducerBasic producerReloadCompany = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.ExchangeCompanyFindNew, ConfigCrawler.RoutingkeyCompanyFindNew);
            foreach (var item in eventGetCompanys())
            {
                producerReloadCompany.PublishString(new JobCompanyCrawler() { CompanyId = item, CheckRunning = false }.GetJSon());
            }
        }

        private void PushQueueCrawlerReload(object sender, EventArgs e)
        {
            ProducerBasic producerReloadCompany = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.ExchangeCompanyReload, ConfigCrawler.RoutingkeyCompanyReload);
            foreach (var item in eventGetCompanys())
            {
                producerReloadCompany.PublishString(new JobCompanyCrawler() { CompanyId = item, CheckRunning = false }.GetJSon());
            }
        }

        private void PushResetDuplicateCompany(object sender, EventArgs e)
        {
            var lstCompany = eventGetCompanys();
            ProducerBasic producerBasic = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.ExchangeResetDuplicate, ConfigCrawler.RoutingkeyResetDuplicate);
            foreach (var item in lstCompany)
            {
                ((ProducerBasic)producerBasic).PublishString(item.ToString());
            }
            MessageBox.Show(string.Format("Pushed {0} companys", lstCompany.Count));
        }

        private void PushResetCacheCompany(object sender, EventArgs e)
        {
            var lstCompany = eventGetCompanys();
            ProducerBasic producerBasic = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigCrawler.KeyRabbitMqCrawler), ConfigCrawler.QueueResetCacheProduct);
            foreach (var item in lstCompany)
            {
                producerBasic.PublishString(item.ToString());
            }
            MessageBox.Show(string.Format("Pushed {0} companys", lstCompany.Count));
        }


        private void PushDownloadHtml(object sender, EventArgs e)
        {
            var rabbitMqServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ_DownloadComment");
            var publisher = new ProducerBasic(rabbitMqServer, ConsumerDownlaodHtml.WSS_DOWNLOADHTML);
            var productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            var companys = eventGetCompanys();
            foreach (var companyId in companys)
            {

                int pageIndex = 1;
                DataTable lstProduct = productAdapter.GetProductLinkPushDownloadHtml(companyId, pageIndex);
                while (lstProduct.Rows.Count > 0)
                {

                    foreach (DataRow tuple in lstProduct.Rows)
                    {
                        while (true)
                        {
                            try
                            {
                                publisher.Publish(new QT.Entities.CrawlerProduct.Comment.JobComment() { CompanyId = companyId, ProductId = Convert.ToInt64(tuple["ID"]), Url = Convert.ToString(tuple["DetailUrl"]) }
                                        .ToArbyteJSON());
                                break;
                            }
                            catch (Exception ex)
                            {
                                log.Info(ex);
                                Thread.Sleep(1000);
                            }
                        }

                    }lstProduct = productAdapter.GetProductLinkPushDownloadHtml(companyId, ++pageIndex);
                }
            }
            MessageBox.Show(string.Format("Pushed for {0} company!", companys.Count));
        }

        private void ClickSetBlackList(object sender, EventArgs e)
        {int countData = 0;var lstProductGroup = eventGetProductIDs();
            var pa = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));

            MQPushDownloadImage mqPushDownloadImage = new MQPushDownloadImage();
            for (int i = 0; i < lstProductGroup.Count; i++)
            {
                var lstProductIds = lstProductGroup.ElementAt(i).Value;
                foreach (var product in pa.GetProductEntitieBy(lstProductIds))
                {
                    countData++;
                    mqPushDownloadImage.PushQueueChangeChangeImage(new ImageProductInfo(product.ID, product.Name, product.DetailUrl, product.ImageUrl, product.IsNews));
                }
            }
            //foreach (var VARIABLE in lstProductGroup.Values)
            //{
            //    pa.SetBlackListForProduct(VARIABLE);
            //    mqPushDownloadImage.PushQueueChangeChangeImage(new ImageProductInfo(product.ID, product.Name, product.DetailUrl, product.ImageUrl, product.IsNews));
            //}
            
            MessageBox.Show(string.Format("Pushed {0} message", countData));
        }

        private void ClickPushToDownloadImage(object sender, EventArgs e)
        {
            int countData = 0;
            var lstProductGroup = eventGetProductIDs();
            var pa = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString)); 
            MQPushDownloadImage mqPushDownloadImage = new MQPushDownloadImage();
            for (int i = 0; i < lstProductGroup.Count; i++)
            {
                var lstProductIds = lstProductGroup.ElementAt(i).Value;
                foreach (var product in pa.GetProductEntitieBy(lstProductIds))
                {
                    countData++;
                    mqPushDownloadImage.PushQueueChangeChangeImage(new ImageProductInfo(product.ID, product.Name, product.DetailUrl, product.ImageUrl, product.IsNews));
                }
            }
            MessageBox.Show(string.Format("Pushed {0} message", countData));
        }

        private void DeleteDuplicateProduct(object sender, EventArgs e)
        {
            var companyId = eventGetProductID();
            var productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            var hsCheckDuplicate = new HashSet<long>();
        }

        private void PushDescription(object sender, EventArgs e)
        {
            var companyId = eventGetProductID();
            var redisServer = RabbitMQManager.GetRabbitMQServer("rabbitMQDescription");
            var jobClient = new JobClient("", GroupType.Direct, "ProductIDs", true, redisServer);
            jobClient.PublishJob(new Job()
            {
                Type = 0,
                Data = BitConverter.GetBytes(companyId)
            });
            MessageBox.Show(@"Pushed!");
        }

        private void ViewScoreLastUpdateProduct(object sender, EventArgs e)
        {
            var frm = new FrmViewScoreProductLastCrawler(Convert.ToInt64(eventGetCompanyHandle()));
            frm.Show();
        }

        private void ClickUpdateLastUpdateToFisrt(object sender, EventArgs e)
        {
            var redisLstUpdate = QT.Moduls.CrawlerProduct.Cache.RedisLastUpdateProduct.Instance();
            var item = eventGetProductIDs();
            redisLstUpdate.UpdateBathLastUpdateProduct(item.ElementAt(0).Key, item.ElementAt(0).Value, new DateTime(1900, 1, 1));
            return;
        }

        private void ViewSessionFindNew(object sender, EventArgs e)
        {
            var Session = eventGetSession();
            var frm = new FrmViewLinkVisitFindNew();
            frm.LoadBySession(Session);
            frm.ShowDialog();
        }

        private void ViewSessionReload(object sender, EventArgs e)
        {
            FrmHistoryProduct frmHistoryProduct = new FrmHistoryProduct();
            frmHistoryProduct.LoadBySession(eventGetSession());
            frmHistoryProduct.Show();
        }

        private void CopyCompanyIDToClipboard(object sender, EventArgs e)
        {
            var listCompanyIDs = eventGetCompanys();
            Clipboard.Clear();
            Clipboard.SetText(string.Join("\n", listCompanyIDs));
        }

        private void CrawlerFindNew(object sender, EventArgs e)
        {
            var lstCompanyId = new Queue<long>();
            foreach (var cmp in eventGetCompanys()) lstCompanyId.Enqueue(cmp);
            var frmCrawlerData = new FrmCrawlerData(lstCompanyId, 1);
            frmCrawlerData.Show();
        }

        private void CrawlerReload(object sender, EventArgs e)
        {
            var lstCompanyID = new Queue<long>();
            foreach (var rowView in lstCompanyID)
            {
                lstCompanyID.Enqueue(rowView);
            }
            var frmCrawlerData = new FrmCrawlerData(lstCompanyID, 1);
            frmCrawlerData.Show();
        }

        private void RefreshCacheCompany(object sender, EventArgs e)
        {
            var frm = new FrmRefreshCache(eventGetCompanyHandle());
            frm.Show();
        }

        private void ViewProductInCache(object sender, EventArgs e)
        {
            var frm = new FrmViewProductInCache(eventGetCompanyHandle());
            frm.ShowDialog();
        }

        private void ViewProductInDb(object sender, EventArgs e)
        {
            var frm = new FrmViewProductInDb(eventGetCompanyHandle());
            frm.ShowDialog();
        }



        private void ViewHistoryCrawlerCompany(object sender, EventArgs e)
        {
            var frm = new FrmHistoryCrawlerByCompany(eventGetCompanyHandle());
            frm.ShowDialog();
        }

        private void ViewHistoryChangeProduct6(object sender, EventArgs e)
        {
            var frm = new FrmHistoryChangeProductCrawler(eventGetProductID());
            frm.ShowDialog();
        }
    }
}
