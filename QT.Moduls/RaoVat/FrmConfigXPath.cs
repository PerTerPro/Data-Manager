
using QT.Entities;
using QT.Entities.AnaylysicData;
using QT.Entities.RaoVat;
using QT.Entities.Data;
using QT.Entities.Data.SolrDb.SaleNews;
using QT.Entities.Model.SaleNews;
using RabbitMQ.Client;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using wssCommon = QT.Entities.Common;

namespace QT.Moduls.CrawlSale
{
    public partial class FrmConfigXPath : Form
    {
        MongoDbRaoVat mongoDbAdapter = new MongoDbRaoVat();
        ConnectionFactory factoryMQ = null;

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmConfigXPath));

        QT.Entities.RaoVat.HandlerContentOfHtml hanlerContentOfHtml;
        public bool IsNew;

         SqlDb sqlDb;
         RaoVatSQLAdapter raovatSqlAdapter;
         ProductSaleNewDataAdapter productAdapter;
        CassandraDb cassandraDb;

        private SolrRaoVatDriver slr = null;
        ManagerNameNameCrawler managerName = new ManagerNameNameCrawler();

        public FrmConfigXPath()
        {
            try
            {
                InitializeComponent();

                
                sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
                raovatSqlAdapter = new RaoVatSQLAdapter(sqlDb);
                productAdapter = new ProductSaleNewDataAdapter(sqlDb);

                this.hanlerContentOfHtml = new QT.Entities.RaoVat.HandlerContentOfHtml();
                InitData();
            }
            catch (Exception ex)
            {

            }
        }

        private void InitData()
        {
            try
            {
                RaoVatSQLAdapter raovat = new RaoVatSQLAdapter(new SqlDb(QT.Entities.Server.ConnectionStringCrawler));
                this.CboWebSiteID.DataSource = raovat.GetTblWebSite();
                this.CboWebSiteID.ValueMember = "id";
                this.CboWebSiteID.DisplayMember = "domain";

                string Webdomain = "raovat";
                string URLSolrConnect = "http://118.70.205.94:9104/solr/raovat";
                slr = SolrRaoVatDriver.GetDriver(null);

                this.LoadEventCheckRegex(new RichTextBox[]{
                this.NoProductUrlRegexTextBox,
                this.noVisitUrlsRegexTextBox,
                this.ProductUrlsRegexTextBox,
                this.visitUrlsRegexTextBox
            });

                this.LoadEventCheckXPaths(new RichTextBox[]{
                this.PhoneSalerXPathsTextBox,
                this.AddressXPathsTextBox,
                this.AvaiableXPathsTextBox,
                this.QualityXPathsTextBox,
                this.ImageUrlsXPathsTextBox,
                this.LastChangeXPathsTextBox,
                this.PostDateXPathsTextBox,
                this.PriceXPathsTextBox,
                this.ProvinceXPathsTextBox,
                this.UserNameXPathsTextBox,
                this.TitleXPathsTextBox,
                this.ContentXPathTextbox,
                this.txtTagXPaths,
                this.webCategoryXPathsTextBox,
                this.txtLastEditXPaths
            });

                this.factoryMQ = new ConnectionFactory();
                factoryMQ.UserName = QT.Entities.Server.RabbitMQ_User;
                factoryMQ.Password = QT.Entities.Server.RabbitMQ_Pass;
                factoryMQ.Protocol = Protocols.DefaultProtocol;
                factoryMQ.HostName = QT.Entities.Server.RabbitMQ_Host;
                factoryMQ.Port = QT.Entities.Server.RabbitMQ_Port;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void LoadInfo(int configXPathID)
        {

        }

        private void SaveInfo()
        {

        }

        private void ClearAfterInsert()
        {

        }



        private bool LoadFormToConfig(ref ConfigXPaths config)
        {
            try
            {
                config.website_id = Convert.ToInt32(CboWebSiteID.SelectedValue);
                config.TitleXPaths = wssCommon.GetListXPathFromString(this.TitleXPathsTextBox.Text);
                config.PriceXPaths = wssCommon.GetListXPathFromString(this.PriceXPathsTextBox.Text);
                config.PostDateXPaths = wssCommon.GetListXPathFromString(this.PostDateXPathsTextBox.Text);
                config.LastChangeXPaths = wssCommon.GetListXPathFromString(this.LastChangeXPathsTextBox.Text);
                config.ProvinceXPaths = wssCommon.GetListXPathFromString(this.ProvinceXPathsTextBox.Text);
                config.PhoneSalerXPaths = wssCommon.GetListXPathFromString(this.PhoneSalerXPathsTextBox.Text);
                config.AddressXPaths = wssCommon.GetListXPathFromString(this.AddressXPathsTextBox.Text);
                config.ContentXPaths = wssCommon.GetListXPathFromString(this.ContentXPathTextbox.Text);
                config.AvaiableXPaths = wssCommon.GetListXPathFromString(this.AvaiableXPathsTextBox.Text);
                config.QualityXPaths = wssCommon.GetListXPathFromString(this.QualityXPathsTextBox.Text);
                config.UserNameXPaths = wssCommon.GetListXPathFromString(this.UserNameXPathsTextBox.Text);
                config.ThumbUrlXPaths = wssCommon.GetListXPathFromString(this.txtThumbXPaths.Text);
                config.AllowExtractProductLink = ckExtractProduct.Checked;

                config.ReloadVisitUrlsRegex = wssCommon.GetListXPathFromString(this.ExtrationRegex_richTextBox4.Text);
                config.ReloadNoVisitUrlsRegex = wssCommon.GetListXPathFromString(this.NoExtrationRegex_richTextBox4.Text);
                config.ReloadProductUrlsRegex = wssCommon.GetListXPathFromString(this.ProductRegex_RichTextBox.Text);
                config.ReloadNoProductUrlRegex = wssCommon.GetListXPathFromString(this.NoProductRegex_RichTextBox.Text);
                config.RegexReloadLikeFull = this.RegexReloadLikeFull_CheckEdit.Checked;

                config.image_regex = wssCommon.GetListXPathFromString(this.txtImage.Text);
                config.noimage_regex = wssCommon.GetListXPathFromString(this.txtNoRegexImage.Text);

                config.UrlTest = this.urlTestTextBox.Text;
                config.VisitUrlsRegex = wssCommon.GetListXPathFromString(this.visitUrlsRegexTextBox.Text);
                config.NoVisitUrlRegex = wssCommon.GetListXPathFromString(this.noVisitUrlsRegexTextBox.Text);
                config.ProductUrlsRegex = wssCommon.GetListXPathFromString(this.ProductUrlsRegexTextBox.Text);
                config.NoProductUrlRegex = wssCommon.GetListXPathFromString(this.NoProductUrlRegexTextBox.Text);
                config.AllowExtractProductLink = ckExtractProduct.Checked;
                config.TimeDelay = (int)timeDelaySpinEdit.Value;
                config.ItemReCrawler = (int)itemReCrawlerSpinEdit.Value;
                config.RootLink = Common.GetListXPathFromString(rootLinkTextBox.Text);
                config.ID = Convert.ToInt32(configXPathIDSpinEdit.Value);
                config.ImageUrlsXPaths = wssCommon.GetListXPathFromString(this.ImageUrlsXPathsTextBox.Text);
                config.WebCategoryXPaths = wssCommon.GetListXPathFromString(this.webCategoryXPathsTextBox.Text);
                config.extend_xpaths = Common.GetListXPathFromString(this.textPropertyTextBox.Text);

                config.tags_xpaths = Common.GetListXPathFromString(txtTagXPaths.Text);

                config.wss_interval_push = Convert.ToInt32(minMinuteWaitSpin.Value);
                config.wss_allow_auto_push = Convert.ToBoolean(allowAutoPushCheckBox.Checked);
                config.wss_deep_full_crawler = Convert.ToInt32(wss_deep_full_crawler_TextBox.Value);
                config.wss_deep_reload_crawler = Convert.ToInt32(wss_deep_reload_crawler_TextBox.Value);

                config.RegexStringToCategory = Common.GetListXPathFromString(txtRegexCatToID.Text);
                config.Name = txtNameConfig.Text;

                config.last_edit_xpaths = wssCommon.GetListXPathFromString(this.txtLastEditXPaths.Text);
                config.last_comment_xpaths = wssCommon.GetListXPathFromString(this.richTextBox2.Text);

                config.domain = this.txtDomain.Text;
                config.view_count_xpaths = wssCommon.GetListXPathFromString(this.txtViewCount.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        private void FrmConfigXPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveData();
            }

            else if (e.Control && e.KeyCode == Keys.T)
            {
                btnTestLink.PerformClick();
            }
        }

        private void SaveData()
        {
            try
            {
                bool bExits = false;
                ConfigXPaths config = this.raovatSqlAdapter.GetConfigByID((int)configXPathIDSpinEdit.Value);
                if (config == null)
                {
                    config = new ConfigXPaths() { ID = (int)this.configXPathIDSpinEdit.Value };
                    bExits = false;
                }
                else
                {
                    bExits = true;
                }
                if (this.LoadFormToConfig(ref config))
                {
                    if ((!bExits) || (
                        bExits && MessageBox.Show("Đã tồn tại, muốn ghi đè không", "Warning"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes))
                    {
                        if (this.raovatSqlAdapter.UpdateConfigXPath(config))
                        {
                            //Cap nhat len Redis.
                            config = this.raovatSqlAdapter.GetConfigByID(config.ID);
                            LoadConfigToForm(config);

                            //this.redisDb.SetValueSession("", config.ID
                            //    , RedisDb.FieldSession_LastUpdateToSql
                            //    , (config.wws_last_change_config).ToString(RedisDb.Format_DateTime));
                            MessageBox.Show("Updated!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void FrmConfigXPath_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadEventCheckXPaths(RichTextBox[] textBoxs)
        {
            foreach (RichTextBox textBox in textBoxs)
            {
                textBox.KeyDown += new KeyEventHandler(EventCheckXPaths);
            }
        }
        private void LoadEventCheckRegex(RichTextBox[] textBoxs)
        {
            foreach (var textBox in textBoxs)
            {
                textBox.KeyDown += new KeyEventHandler(EventCheckRegex);
            }
        }

        private void EventCheckRegex(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.F10)
                {
                    List<string> lsStr = wssCommon.GetListXPathFromString((sender as RichTextBox).Text);
                    foreach (string str in lsStr)
                    {
                        Match m = Regex.Match(urlTestTextBox.Text, str);
                        if (m.Success)
                        {
                            MessageBox.Show("OK");
                            return;
                        }
                    }
                    MessageBox.Show("Fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EventCheckXPaths(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                try
                {
                    string url = urlTestTextBox.Text;
                    string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2);
                    GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);
                    var sXPaths = (sender as RichTextBox).Text.Trim().Split(SqlDb.arSplit, 100, StringSplitOptions.RemoveEmptyEntries);
                    if (sXPaths != null)
                    {
                        foreach (var xPath in sXPaths)
                        {
                            var nodes = doc.DocumentNode.SelectNodes(xPath);
                            if (nodes != null)
                            {
                                foreach (var node1 in nodes)
                                {
                                    MessageBox.Show(node1.InnerText);
                                }
                            }
                            else
                            {
                                MessageBox.Show("NoData", "NoData", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error XPaths Config", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RefreshData()
        {
            var config = this.raovatSqlAdapter.GetConfigByID(Convert.ToInt32(configXPathIDSpinEdit.Value));
            LoadConfigToForm(config);
        }





        private void btnLoad_Click(object sender, EventArgs e)
        {
            var config = this.raovatSqlAdapter.GetConfigByID(Convert.ToInt32(configXPathIDSpinEdit.Value));
            LoadConfigToForm(config);
        }

        private void LoadConfigToForm(ConfigXPaths config)
        {
            if (config == null) return;
            this.TitleXPathsTextBox.Text = wssCommon.ConvertToString(config.TitleXPaths);
            this.PriceXPathsTextBox.Text = wssCommon.ConvertToString(config.PriceXPaths);
            this.PostDateXPathsTextBox.Text = wssCommon.ConvertToString(config.PostDateXPaths);
            this.LastChangeXPathsTextBox.Text = wssCommon.ConvertToString(config.LastChangeXPaths);
            this.ProvinceXPathsTextBox.Text = wssCommon.ConvertToString(config.ProvinceXPaths);
            this.PhoneSalerXPathsTextBox.Text = wssCommon.ConvertToString(config.PhoneSalerXPaths);
            this.ContentXPathTextbox.Text = wssCommon.ConvertToString(config.ContentXPaths);
            this.AddressXPathsTextBox.Text = wssCommon.ConvertToString(config.AddressXPaths);
            this.AvaiableXPathsTextBox.Text = wssCommon.ConvertToString(config.AvaiableXPaths);
            this.QualityXPathsTextBox.Text = wssCommon.ConvertToString(config.QualityXPaths);
            this.ImageUrlsXPathsTextBox.Text = wssCommon.ConvertToString(config.ImageUrlsXPaths);
            this.UserNameXPathsTextBox.Text = wssCommon.ConvertToString(config.UserNameXPaths);
            this.urlTestTextBox.Text = config.UrlTest;

            this.ExtrationRegex_richTextBox4.Text = wssCommon.ConvertToString(config.ReloadVisitUrlsRegex);
            this.NoExtrationRegex_richTextBox4.Text = wssCommon.ConvertToString(config.ReloadNoVisitUrlsRegex);
            this.ProductRegex_RichTextBox.Text = wssCommon.ConvertToString(config.ReloadProductUrlsRegex);
            this.NoProductRegex_RichTextBox.Text = wssCommon.ConvertToString(config.ReloadNoProductUrlRegex);
            this.RegexReloadLikeFull_CheckEdit.Checked = config.RegexReloadLikeFull;

            this.txtImage.Text = wssCommon.ConvertToString(config.image_regex);
            this.txtNoRegexImage.Text = wssCommon.ConvertToString(config.noimage_regex);

            this.visitUrlsRegexTextBox.Text = wssCommon.ConvertToString(config.VisitUrlsRegex);
            this.noVisitUrlsRegexTextBox.Text = wssCommon.ConvertToString(config.NoVisitUrlRegex);
            this.ProductUrlsRegexTextBox.Text = wssCommon.ConvertToString(config.ProductUrlsRegex);
            this.NoProductUrlRegexTextBox.Text = wssCommon.ConvertToString(config.NoProductUrlRegex);
            this.txtThumbXPaths.Text = wssCommon.ConvertToString(config.ThumbUrlXPaths);

            this.timeDelaySpinEdit.Value = config.TimeDelay;
            this.itemReCrawlerSpinEdit.Value = config.ItemReCrawler;
            this.rootLinkTextBox.Text = Common.ConvertToString(config.RootLink);


            this.webCategoryXPathsTextBox.Text = wssCommon.ConvertToString(config.WebCategoryXPaths);
            this.textPropertyTextBox.Text = Common.ConvertToString(config.extend_xpaths);
            this.txtTagXPaths.Text = Common.ConvertToString(config.tags_xpaths);
            this.ckExtractProduct.Checked = config.AllowExtractProductLink;

            this.allowAutoPushCheckBox.Checked = config.wss_allow_auto_push;
            this.minMinuteWaitSpin.Value = config.wss_interval_push;
            this.dateTimePicker1.Value = config.wss_last_push;

            this.wss_deep_full_crawler_TextBox.Value = config.wss_deep_full_crawler;
            this.wss_deep_reload_crawler_TextBox.Value = config.wss_deep_reload_crawler;

            this.txtRegexCatToID.Text = Common.ConvertToString(config.RegexStringToCategory);
            this.txtNameConfig.Text = Common.Obj2String(config.Name);

            this.txtLastEditXPaths.Text = wssCommon.ConvertToString(config.last_edit_xpaths);
            this.richTextBox2.Text = wssCommon.ConvertToString(config.last_comment_xpaths);
            this.txtViewCount.Text = wssCommon.ConvertToString(config.view_count_xpaths);

            this.txtDomain.Text = config.domain;
            this.CboWebSiteID.SelectedValue = config.website_id;
        }



        private void btnTestProduct_Click(object sender, EventArgs e)
        {
            string urlTest = urlTestTextBox.Text;
            if (!string.IsNullOrWhiteSpace(urlTest))
            {
                string url = urlTestTextBox.Text;
                string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2);
                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();

                WebExceptionStatus status = WebExceptionStatus.Success;
                html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2, out status);
                doc.LoadHtml(html);
            
                ConfigXPaths config = this.raovatSqlAdapter.GetConfigByID((int)this.configXPathIDSpinEdit.Value);
                if (config == null) config = new ConfigXPaths() { ID = -1 };
                if (this.LoadFormToConfig(ref config))
                {
                    var product = new ProductSaleNew();
                    int iError = this.hanlerContentOfHtml.AnalyticsProductSaleNew(config.domain, urlTest, config, product, 
                        this.raovatSqlAdapter.GetDicMapClassificationAndCategories(config.website_id),
                        this.raovatSqlAdapter.GetDicCityAndRegex());

                    FrmDataShow frmDataShow = new FrmDataShow(product.ToString());
                    frmDataShow.btnSave.Click += new EventHandler(delegate(object obj, EventArgs eventArg)
                    {
                        if (MessageBox.Show("Save to Cassandra?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                        {
                            bool bExits = this.mongoDbAdapter.CheckExistsProductSalenew(product.id);
                            if (bExits)
                            {
                                mongoDbAdapter.UpdateProduct(product);
                                mongoDbAdapter.SaveHtml(product.id, html, bExits);
                            }
                            else
                            {
                                mongoDbAdapter.InsertProduct(product);
                                mongoDbAdapter.SaveHtml(product.id, html, bExits);
                            }
                        }
                    });
                    frmDataShow.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Not url test");
            }
        }
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
        private string StringFromUrl(string url)
        {
            return "";
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //Bitmap thumbBitmap = new Bitmap(response.GetResponseStream());
            //thumbBitmap = new Bitmap(thumbBitmap, 160, 32);
            //thumbBitmap.Save("trang.png");
            //for (int i = 0; i < thumbBitmap.Width; i++)
            //    for (int j = 0; j < thumbBitmap.Height; j++)
            //    {
            //        Color cell = thumbBitmap.GetPixel(i, j);
            //        if (cell == Color.Transparent || (cell.A == 0 && cell.B == 0 && cell.G == 0 && cell.R == 0))
            //        {
            //            thumbBitmap.SetPixel(i, j, Color.Violet);
            //        }
            //    }
            //thumbBitmap.Save(@"trang1.png");
            //thumbBitmap = new Bitmap(@"trang1.png");

            //ocr.SetVariable("tessedit_char_whitelist", "0123456789"); // If digit only
            ////@"C:\OCRTest\tessdata" contains the language package, without this the method crash and app breaks
            //ocr.Init(@"C:\Program Files (x86)\Tesseract-OCR", "eng", true);
            //var result = ocr.DoOCR(thumbBitmap, Rectangle.Empty);
            //string str = "";
            //foreach (Word word in result)
            //    str = str + word.Text;
            //return str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var thumbBitmap = this.pictureBox1.Image;
            //thumbBitmap.Save("trang.png");
            //for (int i = 0; i < thumbBitmap.Width; i++)
            //    for (int j = 0; j < thumbBitmap.Height; j++)
            //    {
            //        Color cell = thumbBitmap.GetPixel(i, j);
            //        if (cell == Color.Transparent || (cell.A == 0 && cell.B == 0 && cell.G == 0 && cell.R == 0))
            //        {
            //            thumbBitmap.SetPixel(i, j, Color.Violet);
            //        }
            //    }
            //thumbBitmap.Save(@"trang1.png");
            //thumbBitmap = new Bitmap(@"trang1.png");
            //var ocr = new Tesseract();
            //ocr.SetVariable("tessedit_char_whitelist", "0123456789"); // If digit only
            ////@"C:\OCRTest\tessdata" contains the language package, without this the method crash and app breaks
            //ocr.Init(@"C:\Program Files (x86)\Tesseract-OCR", "eng", true);
            //var result = ocr.DoOCR(thumbBitmap, Rectangle.Empty);
            //string str = "";
            //foreach (Word word in result)
            //    str = str + word.Text;
            //return str;     

            //this.IsNew = true;
            //SaveData();
        }

        private void cboTypeData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRunCrawlAll_Click(object sender, EventArgs e)
        {

        }

        Thread thread = null;

        public void RunCrawler(bool bSaveData, string NameCrawler)
        {
           
        }



        private void btnStop_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    for (int i = lstCrawler.Count - 1; i >= 0; i--)
            //    {
            //        lstCrawler[i].Dispose();
            //    }
            //    MessageBox.Show("Đã dừng");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lsStr = wssCommon.GetListXPathFromString(noVisitUrlsRegexTextBox.Text);
                foreach (string str in lsStr)
                {
                    Match m = Regex.Match(urlTestTextBox.Text, str);
                    if (m.Success)
                    {
                        MessageBox.Show("OK");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Fail");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> lsStr = wssCommon.GetListXPathFromString(visitUrlsRegexTextBox.Text);
            foreach (string str in lsStr)
            {
                Match m = Regex.Match(urlTestTextBox.Text, str);
                if (m.Success)
                {
                    MessageBox.Show("OK");
                    return;
                }
            }
            MessageBox.Show("Fail");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> lsStr = wssCommon.GetListXPathFromString(ProductUrlsRegexTextBox.Text);
            foreach (string str in lsStr)
            {
                Match m = Regex.Match(urlTestTextBox.Text, str);
                if (m.Success)
                {
                    MessageBox.Show("OK");
                    return;
                }
            }
            MessageBox.Show("Fail");
        }


        private void btnCheckProductNoRegex_Click(object sender, EventArgs e)
        {
            List<string> lsStr = wssCommon.GetListXPathFromString(ProductUrlsRegexTextBox.Text);
            foreach (string str in lsStr)
            {
                Match m = Regex.Match(urlTestTextBox.Text, str);
                if (m.Success)
                {
                    MessageBox.Show("OK");
                    return;
                }
            }
            MessageBox.Show("Fail");
        }

        private void btnAnalysic_Click(object sender, EventArgs e)
        {

        }

        public void LoadConfigByID(int ConfigID)
        {
            this.configXPathIDSpinEdit.Value = ConfigID;
            this.RefreshData();
        }

        public void LoadConfigByWebsite(int website_id)
        {
            int config_Id =  this.raovatSqlAdapter.GetConfigIDByWebsite(website_id);
            this.configXPathIDSpinEdit.Value = config_Id;
            this.RefreshData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }



        private void tbReloadSpGoc_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(hanlerContentOfHtml.GetNumberfromLink(txtImage.Text));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog frmSave = new SaveFileDialog();
            frmSave.DefaultExt = ".png";
            if (frmSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string locationFile = frmSave.FileName;
                Image bitmap = this.pictureBox1.Image;
                bitmap.Save(locationFile);
                MessageBox.Show("Đã lưu");
            }
        }

        private void btnReadTextToData(object sender, EventArgs e)
        {
            //try
            //{
            //    //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullLink);
            //    //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //    Bitmap thumbBitmap = new Bitmap(this.pictureBox2.Image);
            //    thumbBitmap = new Bitmap(thumbBitmap, 166, 77);
            //    //thumbBitmap.Save("trang.png");
            //    for (int i = 0; i < thumbBitmap.Width; i++)
            //        for (int j = 0; j < thumbBitmap.Height; j++)
            //        {
            //            Color cell = thumbBitmap.GetPixel(i, j);
            //            if (cell == Color.Transparent || (cell.A == 0 && cell.B == 0 && cell.G == 0 && cell.R == 0))
            //            {
            //                thumbBitmap.SetPixel(i, j, Color.White);
            //            }
            //        }



            //    ocr.SetVariable("tessedit_char_whitelist", "0123456789"); // If digit only
            //    //@"C:\OCRTest\tessdata" contains the language package, without this the method crash and app breaks
            //    ocr.Init(@"C:\Program Files (x86)\Tesseract-OCR", "eng", true);
            //    var result = ocr.DoOCR(thumbBitmap, Rectangle.Empty);
            //    string str = "";
            //    foreach (Word word in result)
            //        str = str + word.Text;
            //    MessageBox.Show(str);
            //}
            //catch (Exception ex)
            //{

            //}
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            string fullLink = txtImage.Text;
            if (!string.IsNullOrEmpty(fullLink))
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullLink);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Bitmap thumbBitmap = new Bitmap(response.GetResponseStream());
                thumbBitmap = new Bitmap(thumbBitmap, 166, 77);
                this.pictureBox1.Image = thumbBitmap;
            }
        }

        private void btnTestExtracktion(object sender, EventArgs e)
        {
            try
            {
                var config = this.raovatSqlAdapter.GetConfigByID((int)this.configXPathIDSpinEdit.Value);
                List<string> lstLink = Common.GetListXPathFromString(urlTestTextBox.Text);
                List<string> lstExtractLink = new List<string>();
                foreach (string str in lstLink)
                {
                    GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                    string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(str, 45, 2, true);
                    doc.LoadHtml(html);
                    var nodes = doc.DocumentNode.SelectNodes(@"//a[@href]");
                    if (nodes != null) foreach (var node in nodes)
                        {
                            string url = Common.GetAbsoluteUrl(node.Attributes["href"].Value.Trim(), config.domain);
                            if (QT.Entities.Common.CheckRegex(url, config.VisitUrlsRegex, config.NoVisitUrlRegex, false))
                            {
                                if (!lstExtractLink.Contains(url.Trim())) lstExtractLink.Add(url.Trim());
                            }
                        }
                }
                FrmDataShow fr = new FrmDataShow(QT.Entities.Common.ConvertToString(lstExtractLink, "\n"));
                fr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRemoveSolr_Click(object sender, EventArgs e)
        {
            try
            {
                string Webdomain = "raovat";
                string URLSolrConnect = "http://118.70.205.94:9104/solr/raovat";
           
                var slr = SolrRaoVatDriver.GetDriver(null);
                string query = "is_crawled:1 AND is_standard:1";
                bool bOK = slr.RunQuery(query);
                slr.Commit();
                MessageBox.Show("Sucsses!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveToCassandra_Click(object sender, EventArgs e)
        {

        }



        private void btnLoadConfigCassandra_Click(object sender, EventArgs e)
        {
      
        }

        private void btnLoadCategory_Click(object sender, EventArgs e)
        {

        }



        private void button4_Click_1(object sender, EventArgs e)
        {

        }



        private void btnLoadKeyWord_Click(object sender, EventArgs e)
        {
            DataTable tblKeyWord = this.productAdapter.GetTableKeyWord();
            foreach (DataRow row in tblKeyWord.Rows)
            {
                int keyHash = Convert.ToInt32(row["KeyHash"]);
                string keyWord = row["KeyName"].ToString();
                int i = slr.CountOfKeyWord(keyWord);
                this.productAdapter.SaveNumberKeyWordInProduct(keyHash, keyWord, i);
            }
            MessageBox.Show("OK");
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            //DataTable tblKeyWord = this.productAdapter.GetTableKeyWordCategories();
            //foreach (DataRow row in tblKeyWord.Rows)
            //{
            //    int keyHash = Convert.ToInt32(row["KeyHash"]);
            //    string keyWord = row["KeyName"].ToString();
            //    int i = slr.CountOfKeyWord(keyWord);
            //    this.productAdapter.SaveNumberKeyWordInProduct(keyHash, keyWord, i);
            //}
            //MessageBox.Show("OK");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ConfigXPaths config = this.raovatSqlAdapter.GetConfigByID((int)configXPathIDSpinEdit.Value);
            if (config == null) config = new ConfigXPaths() { ID = (int)this.configXPathIDSpinEdit.Value };
            if (this.LoadFormToConfig(ref config))
            {
                if (this.raovatSqlAdapter.UpdateConfigXPath(config))
                {
                    MessageBox.Show("Updated!");
                }
            }
        }

        private void btnLoadFormSQL_Click(object sender, EventArgs e)
        {
            var config = this.raovatSqlAdapter.GetConfigByID(Convert.ToInt32(configXPathIDSpinEdit.Value));
            LoadConfigToForm(config);
        }



        private void btnStartNew_Click(object sender, EventArgs e)
        {

        }


        List<IDisposable> lst = new List<IDisposable>();

        private void btnStartConsumer_Click(object sender, EventArgs e)
        {



        }

        IConnection connectMQ;
        private RedisDb redisDb;
        private void stopConsumer_Click(object sender, EventArgs e)
        {
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                lst[i].Dispose();
                lst.RemoveAt(i);
            }
            if (this.connectMQ != null && this.connectMQ.IsOpen == true)
            {
                this.connectMQ.Close();
                this.connectMQ.Dispose();
            }


            MessageBox.Show("OK");
        }

        private void btnCopyToReload_Click(object sender, EventArgs e)
        {
            ExtrationRegex_richTextBox4.Text = visitUrlsRegexTextBox.Text;
            NoExtrationRegex_richTextBox4.Text = noVisitUrlsRegexTextBox.Text;
            ProductRegex_RichTextBox.Text = this.ProductUrlsRegexTextBox.Text;
            NoProductRegex_RichTextBox.Text = this.NoProductRegex_RichTextBox.Text;
            MessageBox.Show("Da chuyen");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGetProductLInk_Click(object sender, EventArgs e)
        {
            try
            {
                var config = this.raovatSqlAdapter.GetConfigByID((int)this.configXPathIDSpinEdit.Value);
                List<string> lstLink = Common.GetListXPathFromString(urlTestTextBox.Text);
                List<string> lstExtractLink = new List<string>();
                foreach (string str in lstLink)
                {
                    GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                    string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(str, 45, 2, true);
                    doc.LoadHtml(html);
                    var nodes = doc.DocumentNode.SelectNodes(@"//a[@href]");
                    if (nodes != null) foreach (var node in nodes)
                        {
                            string url = Common.GetAbsoluteUrl(node.Attributes["href"].Value.Trim(), config.domain);
                            if (QT.Entities.Common.CheckRegex(url, config.ProductUrlsRegex, config.NoProductUrlRegex, false))
                            {
                                if (!lstExtractLink.Contains(url.Trim())) lstExtractLink.Add(url.Trim());
                            }
                        }
                }
                FrmDataShow fr = new FrmDataShow(QT.Entities.Common.ConvertToString(lstExtractLink, "\n"));
                fr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetHTML_Click(object sender, EventArgs e)
        {
            try
            {
                var config = this.raovatSqlAdapter.GetConfigByID((int)this.configXPathIDSpinEdit.Value);
                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(urlTestTextBox.Text, 45, 2, true);
                doc.LoadHtml(html);
                FrmDataShow fr = new FrmDataShow(html);
                fr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void label8_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
        }

        private void btnAutoFindCategory_Click(object sender, EventArgs e)
        {
            MySqlAdapterRaoVat mySqlDb = new MySqlAdapterRaoVat();
            Dictionary<string, List<int>> dicmap = new Dictionary<string, List<int>>();
            try
            {
                List<string> lst = Common.GetListXPathFromString(txtRegexCatToID.Text);
                foreach (var itemCat in lst)
                {
                    var arData = itemCat.Split(new char[] { ':' }, 2, StringSplitOptions.RemoveEmptyEntries);
                    string strRegex = arData[0];
                    string strCat = arData[1];
                    List<int> lstCat = new List<int>();
                    foreach (var itemCatId in strCat.Split(new char[] { ',' }, 10, StringSplitOptions.RemoveEmptyEntries))
                    {
                        int iCat = 0;
                        int.TryParse(itemCatId, out iCat);
                        if (!lstCat.Contains(iCat) && iCat > 0) lstCat.Add(iCat);
                    }
                    dicmap.Add(strRegex, lstCat);
                }

                //Thêm các cat còn thiếu
                for (int i=0; i<dicmap.Count;i++)
                {
                    List<int> lstData = dicmap.ElementAt(i).Value;
                    List<int> lstNeedAdd = new List<int>();
                    foreach(var itemCat in lstData)
                    {
                        List<int> lstPath = mySqlDb.GetListPathOfCategory(itemCat);
                        foreach(var itemCatPath in lstPath)
                        {
                            if (!lstData.Contains(itemCatPath)) lstNeedAdd.Add(itemCatPath);
                        }
                       
                    }
                    lstData.AddRange(lstNeedAdd.ToArray());
                }

                string genText = "";
                for (int i=0; i<dicmap.Count;i++)
                {
                    string aMapText = dicmap.ElementAt(i).Key + ":" + Common.ConvertToString(dicmap.ElementAt(i).Value,", ");
                    genText = genText + aMapText + ";\n";
                }
                txtRegexCatToID.Text = genText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
