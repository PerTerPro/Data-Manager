using Cassandra;
using MongoDB.Bson;
using MongoDB.Driver;
using QT.Entities;
using QT.Entities.RaoVat;
using QT.Entities.Model.SaleNews;
using QT.Moduls.RaoVat;
using RabbitMQ.Client;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSS.CrawlerSale.Manager;
using saleNew = QT.Entities.Model.SaleNews;
using QT.Entities.Data.SolrDb.SaleNews;
using QT.Moduls.CrawlProd;
namespace QT.Moduls.CrawlSale
{
    

    public partial class FrmMainSale : Form
    {
        HandlerContentOfHtml handerContent = new HandlerContentOfHtml();
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmMainSale));
        QT.Entities.Data.SqlDb sqlDb = null;
        RaoVatSQLAdapter configXPathAdapter = null;
        Dictionary<int, FrmConfigXPath> dicFrmConfigXPath = new Dictionary<int, FrmConfigXPath>();
        Dictionary<int, ConfigXPaths> dicConfigXPath = new Dictionary<int, ConfigXPaths>();
        int iTypeAuto = 0;
        QT.Entities.RaoVat.RaoVatSQLAdapter raovatAdapter = new RaoVatSQLAdapter(new Entities.Data.SqlDb(QT.Entities.Server.ConnectionStringCrawler));

        public FrmMainSale()
        {
            InitializeComponent();
            sqlDb = new QT.Entities.Data.SqlDb(QT.Entities.Server.ConnectionStringCrawler);
            configXPathAdapter = new RaoVatSQLAdapter(sqlDb);
            foreach (var item in this.configXPathAdapter.GetListConfig())
            {
                this.dicConfigXPath.Add(item.ID, item);
            }
        }

        public void ReloadWebSite()
        {
         
        }

        private void txtSerch1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReloadWebSite();
                e.Handled = true;
            }
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                txtSerch1.Focus();
                txtSerch1.SelectAll();
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {

                FrmRunnerCrawler frmRunnerCrawler = new FrmRunnerCrawler();
                frmRunnerCrawler.Show();
                frmRunnerCrawler.MdiParent = this;
                frmRunnerCrawler.eventRunnerCrawler += new FrmRunnerCrawler.DelegateRunnerCrawler(delegate(int idRunner)
                    {
                        FrmCrawlerRaoVat2 frmCrawlerRaoVat = new FrmCrawlerRaoVat2(idRunner);
                        frmCrawlerRaoVat.Start();
                        frmCrawlerRaoVat.MdiParent = this;
                        frmCrawlerRaoVat.Show();
                    });

            }
            else if (e.Control && e.KeyCode == Keys.F5)
            {
                ReloadListConfig();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            FrmConfigXPath frm = new FrmConfigXPath();
            frm.IsNew = true;
            frm.MdiParent = this;
            frm.Show();
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {            
            //Thread threadStopApp = new Thread(() =>
            //{
            //    while (true)
            //    {
            //        try
            //        {
            //            this.Invoke(new Action(()
            //           =>
            //            {
            //                lblStopAppAfter.Text = string.Format("Stop after {0}'s", this.iStopAfer--);
            //                if (this.iStopAfer == 0)
            //                    Application.ExitThread();
            //            }));


            //            Thread.Sleep(1000);
            //        }
            //        catch (Exception ex)
            //        {
            //            break;
            //        }
            //    }
            //});
            //threadStopApp.Start();

            ReloadListConfig();

            if (iTypeAuto==1)
            {
                int[] ar = configXPathAdapter.GetListConfigIDRunCrawling().ToArray();
                StartConsumer(ar, ETypeCrawlRaoVat.CrawlerRealTime);
            }
        }

     

        public void ReloadListConfig()
        {
            this.gridControl1.DataSource = this.raovatAdapter.GetTblWebSite();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int rowFocus = this.gridView1.FocusedRowHandle;
            if (rowFocus >= 0)
            {
                FrmConfigXPath frmConfig = new FrmConfigXPath();
                int website_id = Convert.ToInt32((this.gridView1.GetRow(rowFocus) as DataRowView)["Id"]);
                frmConfig.Text = string.Format("ConfigID:{0}", website_id);
                frmConfig.FormClosed += new FormClosedEventHandler(delegate(object obj01, FormClosedEventArgs args)
                {
                    dicConfigXPath.Remove(website_id);
                });
                frmConfig.Dock = DockStyle.Fill;
                frmConfig.MdiParent = this;
                frmConfig.LoadConfigByWebsite(website_id);
                frmConfig.Show();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadListConfig();
        }

        private void refreshDanhMụcÔTôToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrackSiteOfData frm = new FrmTrackSiteOfData();
            frm.MdiParent = this;
            frm.Show();

            //try
            //{
            //    if (MessageBox.Show("Bạn có muốn reset thật không?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            //    {
            //        ProductSaleNewDataAdapter productAdapter = new ProductSaleNewDataAdapter(new QT.Entities.Data.SqlDb(QT.Entities.Server.ConnectionStringCrawler));
            //        string root = "http://motoring.vn/tra-cuu/index.html";
            //        Uri uriroot = new Uri(root);
            //        string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(root, 45, 2);
            //        GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            //        doc.LoadHtml(html);
            //        var nodeMakers = doc.DocumentNode.SelectNodes(@"//div[@class='category']//li//a"); //Danh sách các node gốc
            //        //span[@class='here']
            //        foreach (var nodeMaker in nodeMakers) //Vào từng trang maker
            //        {
            //            string linkToMaker = nodeMaker.Attributes["href"].Value.ToString().Trim();
            //            if (linkToMaker.StartsWith(@"/")) linkToMaker = uriroot.Scheme + @"://" + uriroot.Host + linkToMaker;
            //            if (!string.IsNullOrEmpty(linkToMaker))
            //            {
            //                GABIZ.Base.HtmlAgilityPack.HtmlDocument docMaker = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            //                docMaker.LoadHtml(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(linkToMaker, 45, 2));

            //                var nodeMaker1 = docMaker.DocumentNode.SelectSingleNode("//span[@class='here']");
            //                if (nodeMaker1 != null)
            //                {
            //                    string maker = nodeMaker.InnerText.Trim();

            //                    string imageMaker = "";
            //                    var nodeImageMaker = docMaker.DocumentNode.SelectSingleNode("//img[@id='ContentPlaceHolder1_imgManufactor']");
            //                    if (nodeMaker != null)
            //                    {
            //                        imageMaker = nodeImageMaker.Attributes["src"].Value.ToString();
            //                        if (!string.IsNullOrEmpty(imageMaker) && imageMaker.StartsWith(@"/")) imageMaker = uriroot.Scheme + @"://" + uriroot.Host + imageMaker;
            //                    }


            //                    var nodeDescMaker = docMaker.DocumentNode.SelectSingleNode("//div[@class='text_center_tracuu']");
            //                    string desMaker = (nodeDescMaker == null) ? "" : nodeDescMaker.InnerText.Replace("Motoring.vn", "");
            //                    var a = Common.RemoveCommentXML(desMaker);
            //                    productAdapter.SaveConfigRootToDb(maker, 0, a.Trim(), linkToMaker, imageMaker);

            //                    var nodeModels = docMaker.DocumentNode.SelectNodes(@"//div[@class='text_img_size2']//a");
            //                    if (nodeModels != null)
            //                    {

            //                        foreach (var nodeModel in nodeModels) //Vào từng model xe một
            //                        {
            //                            string imageModel = "";
            //                            var nodeImageModel = docMaker.DocumentNode.SelectSingleNode("//img[@id='ContentPlaceHolder1_imgCarModel']");
            //                            if (imageModel != null)
            //                            {
            //                                imageModel = nodeImageMaker.Attributes["src"].Value.ToString();
            //                                if (!string.IsNullOrEmpty(imageModel) && imageModel.StartsWith(@"/")) imageModel = uriroot.Scheme + @"://" + uriroot.Host + imageModel;
            //                            }

            //                            string model = nodeModel.InnerText.Trim();

            //                            string linkToModel = nodeModel.Attributes["href"].Value.ToString().Trim();
            //                            if (linkToModel.StartsWith(@"/")) linkToModel = uriroot.Scheme + @"://" + uriroot.Host + linkToModel;

            //                            GABIZ.Base.HtmlAgilityPack.HtmlDocument docModelDetail = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
            //                            docModelDetail.LoadHtml(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(linkToModel, 45, 2));


            //                            var nodeTextDesc = docModelDetail.DocumentNode.SelectSingleNode("//div[@class='text_center_tracuu']");
            //                            var nodeImage = docModelDetail.DocumentNode.SelectSingleNode("//div[@class='center_tracuu_img']//img");
            //                            string modelDesc = (nodeTextDesc == null) ? "" : nodeTextDesc.InnerText.Replace("Motoring.vn", "").Trim();
            //                            modelDesc = Common.RemoveCommentXML(modelDesc);
            //                            if (nodeTextDesc != null)
            //                            {
            //                                productAdapter.SaveCategoryLevel1(model, maker, modelDesc, linkToModel, 1
            //                                    , string.Format("{0}->{1}", maker, model)
            //                                    , imageModel);
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    MessageBox.Show("Hoàn tất!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnDuyetTang_Click(object sender, EventArgs e)
        {
            ProductSaleNewDataAdapter productAdapter = new ProductSaleNewDataAdapter(new QT.Entities.Data.SqlDb(QT.Entities.Server.ConnectionStringCrawler));
            try
            {

                string root = "http://bantoyota.com.vn";
                Uri uriroot = new Uri(root);
                string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(root, 45, 2);
                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                var nodeMakers = doc.DocumentNode.SelectNodes(@"//ul[@class='sub-menu']//li//a"); //Danh sách các dòng xe
                foreach (var nodeModelCar in nodeMakers) //Vào node dòng xe
                {
                    string strModelCar = nodeModelCar.InnerText.Trim();
                    if (productAdapter.CheckExitFullLink("toyota->" + strModelCar) >= 0)
                    {
                        string urlToModel = nodeModelCar.Attributes["href"].Value.ToString();
                        urlToModel = uriroot.Scheme + @"://" + uriroot.Host + urlToModel;

                        GABIZ.Base.HtmlAgilityPack.HtmlDocument docModel = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                        docModel.LoadHtml(System.Web.HttpUtility.HtmlDecode(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(urlToModel, 45, 2)));
                        string xPathKeyWord = "//div[@class='rightsearch classhot']//div[@class='item']//a";
                        var nodesKeyWords = docModel.DocumentNode.SelectNodes(xPathKeyWord);
                        if (nodesKeyWords != null)
                        {
                            foreach (var nodeKeyWord in nodesKeyWords)
                            {
                                string keyWord = nodeKeyWord.Attributes["title"].Value.Trim().ToLower().Replace("  ", "");
                                string urlDetailKeyWord = nodeKeyWord.Attributes["href"].Value.ToString();
                                urlDetailKeyWord = uriroot.Scheme + @"://" + uriroot.Host + urlDetailKeyWord;


                                GABIZ.Base.HtmlAgilityPack.HtmlDocument docKeyWordDetail = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                                docKeyWordDetail.LoadHtml(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(urlDetailKeyWord, 45, 2));

                                string descXPath = @"//meta[@name='description']/@content";
                                var node = docKeyWordDetail.DocumentNode.SelectSingleNode(descXPath);
                                string description = "";// (node == null) ? "" : Common.GetTextOfXPath(descXPath,,)[0];

                                //Lưu dữ liệu.
                                try
                                {
                                    productAdapter.SaveKeyWord("toyota", strModelCar, keyWord.Replace("bán xe", ""), keyWord, description);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Hoàn tất!");
        }

        private void btnKeyWordXe360_Click(object sender, EventArgs e)
        {
            ProductSaleNewDataAdapter productAdapter = new ProductSaleNewDataAdapter(new QT.Entities.Data.SqlDb(QT.Entities.Server.ConnectionStringCrawler));
            try
            {

                string root = "http://xe360.vn/ban-oto/toyota-corolla.html";
                Uri uriroot = new Uri(root);
                string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(root, 45, 2, true);
                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                //var nodeMakers = doc.DocumentNode.SelectNodes(@"//li[@class='modfloat']//a"); //Danh sách các dòng xe

                var nodeMakers = doc.DocumentNode.SelectNodes(@"//ul[@class='top-level']//li[@class='parent']/a"); //Danh sách các dòng xe;
                foreach (var nodeModelCar in nodeMakers) //Vào node dòng xe
                {
                    string strModelCar = nodeModelCar.Attributes["title"].Value.Replace("-", " ").ToLower().Trim();
                    int iCategories = productAdapter.CheckExitFullLink01(strModelCar);
                    if (iCategories >= 0)
                    {
                        string urlToModel = nodeModelCar.Attributes["href"].Value.ToString();
                        urlToModel = uriroot.Scheme + @"://" + uriroot.Host + urlToModel;

                        GABIZ.Base.HtmlAgilityPack.HtmlDocument docModel = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                        docModel.LoadHtml(System.Web.HttpUtility.HtmlDecode(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(urlToModel, 45, 2, true)));
                        string xPathKeyWord = @"//meta[@name='keywords']";
                        var nodesKeyWords = docModel.DocumentNode.SelectNodes(xPathKeyWord);
                        if (nodesKeyWords != null)
                        {
                            foreach (var nodeKeyWord in nodesKeyWords)
                            {
                                string keyWord = Common.RemoveDumplicateSpace(nodeKeyWord.Attributes["content"].Value.Trim().ToLower());


                                //string urlDetailKeyWord = nodeKeyWord.Attributes["href"].Value.ToString();
                                //urlDetailKeyWord = uriroot.Scheme + @"://" + uriroot.Host + urlDetailKeyWord;


                                //GABIZ.Base.HtmlAgilityPack.HtmlDocument docKeyWordDetail = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                                //docKeyWordDetail.LoadHtml(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(urlDetailKeyWord, 45, 2));

                                //string descXPath = @"//meta[@name='description']/@content";
                                //var node = docKeyWordDetail.DocumentNode.SelectSingleNode(descXPath);
                                string description = "";

                                //Lưu dữ liệu.
                                try
                                {
                                    foreach (var str in keyWord.Split(new char[] { ',' }, 1000, StringSplitOptions.RemoveEmptyEntries))
                                    {
                                        productAdapter.SaveKeyWord(iCategories, str.Trim().Replace("bán xe", ""), str, description);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Hoàn tất!");
        }

        private void btnSearchStandard_Click(object sender, EventArgs e)
        {
        }

        private ProductStandard AnalysicProduct(GABIZ.Base.HtmlAgilityPack.HtmlDocument doc1)
        {
            throw new NotImplementedException();
        }

        private void btnQuanLiSanPhamMau_Click(object sender, EventArgs e)
        {
        }
    
        private void crawlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCrawl_Click(object sender, EventArgs e)
        {
            try
            {
                FrmControlAutoPush frm = new FrmControlAutoPush();
                frm.MdiParent = this;
                DataTable tbl = new DataTable();
                tbl.Columns.Add("id", typeof(long));
                tbl.Columns.Add("Website", typeof(string));
                foreach (int iRow in this.gridView1.GetSelectedRows())
                {
                    DataRowView row = gridView1.GetRow(iRow) as DataRowView;
                    if (row != null)
                    {
                        DataRow row1 = tbl.NewRow();
                        row1["id"] = Convert.ToInt64(row["id"]);
                        row1["Website"] = Convert.ToString(row["RootLink"].ToString().Split(';')[0]);
                        tbl.Rows.Add(row1);
                    }
                }
                frm.LoadOutData(tbl);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.gridControl1, new Point(e.X, e.Y));
            }
        }

        private void btnUpdateTotalProduct_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
          
        }

        private void reloadTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void productManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAutoPush_Click(object sender, EventArgs e)
        {
            FrmControlAutoPush frm = new FrmControlAutoPush();
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmPushJobReload frm = new FrmPushJobReload();
            frm.MdiParent = this;
            frm.Show();

      
        }

        private void btnFindKeyWord_Click(object sender, EventArgs e)
        {
            FrmKeyWord frm = new FrmKeyWord();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmFindExtraInfo frm = new FrmFindExtraInfo();
        }

        private void btnReloadThumb_Click(object sender, EventArgs e)
        {
            
        }

        private void addNullToFieldProcessedimageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReloadData frm = new FrmReloadData(new FrmReloadData.MethodRun(ProcessData_AddFiedlProcessedImage), 0);
            frm.Text = "Thêm thuộc tính processed_image";
            frm.txtQuery.Text = "{'processed_image':{$exists:false}}";
            frm.txtFieldUpdate.Text = "{'processed_image':false}";
            frm.MdiParent = this;
            frm.Show();
        }

        private void ProcessData_AddFiedlProcessedImage(object objSender, MongoDB.Bson.BsonDocument productNeedProcess)
        {
            mon.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", productNeedProcess["_id"].AsObjectId),
                Builders<BsonDocument>.Update
                .Set("processed_image", true));
        }

        private void processDataForprocessedimagefalseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReloadData frm = new FrmReloadData(new FrmReloadData.MethodRun(ProcessData_AddFiedlProcessedImage), 0);
            frm.Text = "Thêm thuộc tính processed_city";
            frm.txtQuery.Text = "{'processed_image':false}";
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReloadAllField_Click(object sender, EventArgs e)
        {
            FrmReloadData frm = new FrmReloadData(new FrmReloadData.MethodRun(ProcessData_ReloadAllField),0);
            frm.Text = "Reload toàn bộ thuộc tính";
            frm.txtQuery.Text = "{'processed':false}";
            frm.MdiParent = this;
            frm.Show();
        }

        private void ProcessData_ReloadAllField(object objSender, BsonDocument productNeedProcess)
        {
            ProductSaleNew productSaleNew = new ProductSaleNew();
            ConfigXPaths configXPath = this.dicConfigXPath[productNeedProcess["source_id"].AsInt32];
            int iFail = handerContent.AnalyticsProductSaleNew(configXPath.domain,
                productNeedProcess["url"].AsString, configXPath, productSaleNew,
                null, null);

            if (productSaleNew.IsDetailSucess)
            {
                //Cập nhật hàng hóa.
                mon.UpdateProduct(productSaleNew);
                mon.colProduct.UpdateOneAsync(
                    Builders<BsonDocument>.Filter.Eq("_id", productNeedProcess["_id"].AsObjectId)
                    , Builders<BsonDocument>.Update
                     .Set("processed", true));
            }
            else
            {
                int iNumberFail = 0;
                int iStatusCurrent = productNeedProcess["status"].AsInt32;
                if (productNeedProcess.Contains("fail_count")) iNumberFail = productNeedProcess["fail_count"].AsInt32;
                iNumberFail++;
                if (iNumberFail >= 1 && iStatusCurrent == 1) iStatusCurrent = 2;
                mon.colProduct.UpdateOneAsync(
                   Builders<BsonDocument>.Filter.Eq("_id", productNeedProcess["_id"].AsObjectId)
                   , Builders<BsonDocument>.Update
                    .Set("status", iStatusCurrent)
                    .Set("fail_count", iNumberFail)
                    .Set("is_solr_updated", false)
                    .CurrentDate("updated_at"));

            }
        }

        MongoDbRaoVat mon = new MongoDbRaoVat();

        private void btnProcessToFalse_Click(object sender, EventArgs e)
        {
            FrmReloadData frm = new FrmReloadData(new FrmReloadData.MethodRun(ProcessData_UpdateProcessedToFalse),0);
            frm.Text = "Update Processed To False";
            frm.lblDescription.Text = "Chuyển trạng thái Processed => False. Chờ Reload lại các thuộc tính cơ bản (thuộc tính có thể tính nhanh)";
            frm.txtQuery.Text = "{'processed':true}";
            frm.MdiParent = this;
            frm.Show();
        }

        private void ProcessData_UpdateProcessedToFalse(object objSender, BsonDocument productNeedProcess)
        {
            mon.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", productNeedProcess["_id"].AsObjectId),
             Builders<BsonDocument>.Update
             .Set("processed", false));
        }

        private void MethodData_Product_WaitQuickReload(object objSender, BsonDocument productNeedProcess)
        {
            mon.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", productNeedProcess["_id"].AsObjectId),
             Builders<BsonDocument>.Update
             .Set("wait_quick_reload", true));
        }

        private void btnFixSlug_Click(object sender, EventArgs e)
        {
            FrmReloadData frm = new FrmReloadData(new FrmReloadData.MethodRun(ProcessData_UpdateSlugData),0);
            frm.Text = "Sửa Slug";
            frm.txtQuery.Text = "{'processed':false}";
            frm.MdiParent = this;
            frm.Show();
        }

        private void ProcessData_UpdateSlugData(object objSender, BsonDocument productNeedProcess)
        {
            string slugCurrent = productNeedProcess["slug"].AsString;
            slugCurrent = Common.RemoveDumplicateSpace(slugCurrent.ToLower()).Replace(" ", "-");
            mon.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", productNeedProcess["_id"].AsObjectId),
            Builders<BsonDocument>.Update
            .Set("slug", slugCurrent)
            .Set("is_solr_updated", false)
            .Set("processed", true)
            .CurrentDate("updated_at"));
        }

        private void KeyWord_FixSlug(object objSender, BsonDocument productNeedProcess)
        {
            string slugCurrent = productNeedProcess["slug"].AsString;
            slugCurrent = Common.RemoveDumplicateSpace(slugCurrent.ToLower()).Replace(" ", "-");
            (objSender as FrmReloadData).collection.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", productNeedProcess["_id"].AsObjectId),
            Builders<BsonDocument>.Update
            .Set("slug", slugCurrent)
            .Set("processed", true)
            .CurrentDate("updated_at"));
        }

        private void btnFixImage_Click(object sender, EventArgs e)
        {
            FrmReloadData frm = new FrmReloadData(new FrmReloadData.MethodRun(ProcessData_FixImage),0);
            frm.Text = "Fix ảnh";
            frm.txtQuery.Text = "{'processed':false}";
            frm.MdiParent = this;
            frm.Show();
        }

        private void ProcessData_FixImage(object objSender, BsonDocument productNeedProcess)
        {
            string url = productNeedProcess["url"].AsString;
            BsonValue[] arImage = productNeedProcess["images"].AsBsonArray.ToArray();
            if (Regex.Matches(url, "http").Count > 1)
            {
                (objSender as FrmReloadData).WriteLog(url);
            }
            mon.colProduct.UpdateOneAsync(Builders<BsonDocument>.Filter.Eq("_id", productNeedProcess["_id"].AsObjectId),
           Builders<BsonDocument>.Update
           .Set("processed", true)
           .CurrentDate("updated_at"));
        }

        private void fixSlugKeywordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReloadData frm = new FrmReloadData(new FrmReloadData.MethodRun(KeyWord_FixSlug), 1);
            frm.Text = "Fix slug keyword";
            frm.txtQuery.Text = "{'processed':false}";
            frm.MdiParent = this;
            frm.Show();
        }

        private void keywordsProcessedfalseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReloadData frm = new FrmReloadData(new FrmReloadData.MethodRun(Method_KeyWord_ProcessedToFalse), 1);
            frm.Text = "Fix slug keyword";
            frm.txtQuery.Text = "{'processed':{$exists:false}}";
            frm.MdiParent = this;
            frm.Show();
        }

        private void Method_KeyWord_ProcessedToFalse(object objSender, BsonDocument productNeedProcess)
        {
            (objSender as FrmReloadData).collection.UpdateOneAsync(
                    Builders<BsonDocument>.Filter.Eq("_id", productNeedProcess["_id"].AsObjectId)
                    , Builders<BsonDocument>.Update
                     .Set("processed", false));
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void productAddProcessedTermToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReloadData frm = new FrmReloadData(new FrmReloadData.MethodRun(Method_Product_ProcessedTerm), 1);
            frm.Text = "Xử lý term";
            frm.txtQuery.Text = "{$or:[{'processed_term':{$exists:false}},{'processed_term':false}]}";
            frm.MdiParent = this;
            frm.Show();
        }

        private void Method_Product_ProcessedTerm(object objSender, BsonDocument productNeedProcess)
        {
            if (productNeedProcess.Contains("tags"))
            {
                BsonArray tags = productNeedProcess["tags"].AsBsonArray;
                if (tags.Count > 0)
                {
                    foreach (var itemtag in tags.ToList())
                    {
                        string keyword = itemtag.AsString;
                        var docTag = this.mon.GetKeywordByName(keyword).Result;
                        mon.colKeyWord.Find("{'name':" + keyword + "}");
                    }
                }

                (objSender as FrmReloadData).collection.UpdateOneAsync(
                       Builders<BsonDocument>.Filter.Eq("_id", productNeedProcess["_id"].AsObjectId)
                       , Builders<BsonDocument>.Update
                        .Set("processed", false));
            }
        }

        private void productWaitReloadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReloadData frm = new FrmReloadData(new FrmReloadData.MethodRun(MethodData_Product_WaitQuickReload), 0);
            frm.Text = "Chờ Quick Reload";
            frm.lblDescription.Text = "Chờ Quick Reload. Chờ reload thông tin nhanh";
            frm.funcOption = new FindOptions<BsonDocument>() { Limit = 500, Sort = "{updated_at:-1}" };
            frm.txtQuery.Text = "{$and:[{'status':1}, {$or:[{'wait_quick_reload':{$exists:false}},{'wait_quick_reload':false}]}]}";
            frm.MdiParent = this;
            frm.Show();
        }

        private void productAutoSetWaitQuickReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReloadData frm = new FrmReloadData();
            frm.txtFieldUpdate.Visible = false;
            frm.txtOptionFind.Visible = false;
            frm.spinEdit1.Visible = false;
            frm.txtQuery.Visible = false;
            frm.MdiParent = this;
            frm.iSpecial = 1;
            frm.Show();
        }

        private void extractKeyWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExtractionKeyWord frm = new FrmExtractionKeyWord();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnneedUpdate_Click(object sender, EventArgs e)
        {
            int a = mon.UpdateWaitQuickReload("{$or:[{'wait_quick_reload':false},{'source_updated_at':{$gt:ISODate('2015-09-07T08:08:06.400Z')}}]}").Result;
            MessageBox.Show(string.Format("Updated {0}!", a.ToString()));

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRunQuickMongo frm = new FrmRunQuickMongo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void autoPushToMQreloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPushJobReload frm = new FrmPushJobReload();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reportCrawlerRealTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consumerToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void phânTíchTừKhóaTinRaoVặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void phânTíchKeyword1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExtractKeyWordSQL frm = new FrmExtractKeyWordSQL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQuanLiBaiViet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManagerKeywords_Click(object sender, EventArgs e)
        {
            
        }

        private void regexLọcKeywordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void keywordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chuyểnTrạngTháiStatusKeywordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QT.Moduls.CrawlSale.FrmSyncData frm = new FrmSyncData();
            frm.TypeProcess = TypeRunSync.ChangeStausKeyWordFromFiedBlock;
            frm.ShowDialog();
           
        }

        private void crawlBySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RaoVat.FrmPushJobToSQL frm = new FrmPushJobToSQL();
                frm.MdiParent = this;
                DataTable tbl = new DataTable();
                tbl.Columns.Add("id", typeof(long));
                tbl.Columns.Add("RootLink", typeof(string));
                foreach (int iRow in this.gridView1.GetSelectedRows())
                {
                    DataRowView row = gridView1.GetRow(iRow) as DataRowView;
                    if (row != null)
                    {
                        DataRow row1 = tbl.NewRow();
                        row1["id"] = Convert.ToInt64(row["id"]);
                        row1["RootLink"] = Convert.ToString(row["RootLink"].ToString());
                        tbl.Rows.Add(row1);
                    }
                }
                frm.LoadOutData(tbl);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reloadAllProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSyncData frm = new FrmSyncData();
            frm.TypeProcess = TypeRunSync.ReloadAllProuduct;
            frm.MdiParent = this;
            frm.Show();
        }

        private void fixProductAutoFindFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSyncData frm = new FrmSyncData();
            frm.TypeProcess = TypeRunSync.AnalyscFieldProduct;
            frm.MdiParent = this;
            frm.Show();
        }

        private void consumerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] arRowSelected = this.gridView1.GetSelectedRows();
            List<int> arConfig = new List<int>();
            foreach (int iRow in arRowSelected)
            {
                arConfig.Add(Convert.ToInt32(this.gridView1.GetRowCellValue(iRow,"ID")));
            }
            StartConsumer(arConfig.ToArray(), ETypeCrawlRaoVat.CrawlerRealTime);
        }

        private void StartConsumer(int[] arConfigID, QT.Entities.RaoVat.ETypeCrawlRaoVat iTypeCrawler)
        {
            try
            {
                foreach (int ConfigID in arConfigID)
                {
                    RaoVat.FrmCrawlerRaoVatConsumer frm = new FrmCrawlerRaoVatConsumer(ConfigID, iTypeCrawler);
                    frm.MdiParent = this;
                    frm.Text = frm.Text + string.Format(". ConfigID:{0}", ConfigID);
                    frm.Show();
                    frm.StartCrawler();
                    lstFrmCrawlRunning.Add(frm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        List<Form> lstFrmCrawlRunning = new List<Form>();
        private int iStopAfer = 1000000;

        private void keyWordAnalysicKeywordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Quét các bài viết chưa dược phân tích keyword.
            //Phân tích keyword dựa trên: cú pháp mặc đinh + Regex đã thiết lập 
            FrmSyncData frm = new FrmSyncData();
            frm.TypeProcess = TypeRunSync.AnalysicKeywordFromProduct ;
            frm.MdiParent = this;
            frm.Show();
        }

        private void keyWordFixSlugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Quét toàn bộ KeyWord.
            //Chuyển Slug Từ chữ không dấu về có dấu.
            FrmSyncData frm = new FrmSyncData();
            frm.TypeProcess = TypeRunSync.FixSlug;
            frm.MdiParent = this;
            frm.Show();
        }

        private void keyWordAutoPushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSyncData frm = new FrmSyncData();
            frm.TypeProcess = TypeRunSync.SyncKeyWordMongoAndSolr;
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchWebsiteCrawlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void classificationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void syncCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýRegexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void phânTíchTừKhóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFindKeywordOfProduct frm = new FrmFindKeywordOfProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void trackRealTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrackSiteOfData frm = new FrmTrackSiteOfData();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
        }

        private void cacadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = null;
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void verticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = null;
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = null;
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegexManager frm = new FrmRegexManager();
            frm.MdiParent = this;
            frm.Show();
        }

        private void regexLọcKeywordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRegexKeyword frm = new FrmRegexKeyword();
            frm.ShowDialog();
        }

        private void lọcThủCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagerKeyword frm = new FrmManagerKeyword();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lọcThủCôngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmManagerProductSale frm = new FrmManagerProductSale();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đồngBộDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSyncDataMySqlAndSqlServer frm = new FrmSyncDataMySqlAndSqlServer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void websiteCrawlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWebSites frm = new FrmWebSites();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reloadDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPushReloadProduct frm = new FrmPushReloadProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consumerReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arRowSelected = this.gridView1.GetSelectedRows();
            List<int> arConfig = new List<int>();
            foreach (int iRow in arRowSelected)
            {
                arConfig.Add(Convert.ToInt32(this.gridView1.GetRowCellValue(iRow, "ID")));
            }
            StartConsumer(arConfig.ToArray(), ETypeCrawlRaoVat.ReloadData);
        }

        private void synSorlMongoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSyncData frm = new FrmSyncData();
            frm.TypeProcess = TypeRunSync.SyncProductSolrAndMongo;
            frm.MdiParent = this;
            frm.Show();
        }

        private void syncSolrMongoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSyncData frm = new FrmSyncData();
            frm.TypeProcess = TypeRunSync.SyncKeyWordMongoAndSolr;
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchListDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void consumerFindKeywordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arRowSelected = this.gridView1.GetSelectedRows();
            List<int> arConfig = new List<int>();
            foreach (int iRow in arRowSelected)
            {
                arConfig.Add(Convert.ToInt32(this.gridView1.GetRowCellValue(iRow, "ID")));
            }
            StartConsumer(arConfig.ToArray(), QT.Entities.RaoVat.ETypeCrawlRaoVat.CrawlerKeyWord);
        }

        private void runnerCrawlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRunnerCrawler frm = new FrmRunnerCrawler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPushFromSQL_Click(object sender, EventArgs e)
        {
            FrmPushKeyWordFroSql frm = new FrmPushKeyWordFroSql();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hideContainerLeft_Click(object sender, EventArgs e)
        {

        }

        private void mapClassificationAndCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iWebSite = Convert.ToInt32(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "id"));
            RaoVat.FrmMapClassficationAndCategory frm = new RaoVat.FrmMapClassficationAndCategory(iWebSite);
            frm.Show();
        }

        private void trackCrawlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDuyetLai_Click(object sender, EventArgs e)
        {
            FrmValidAllKeyword frm = new FrmValidAllKeyword();
            frm.Show();
        }

        private void quảnLíProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
