using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using QT.Entities;
using GABIZ.Base;
using GABIZ.Base.HtmlUrl;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;
using System.Net;
using QT.Moduls.Crawler.DBCrawlerTableAdapters;
using log4net;
using log4net.Config;
using Websosanh.Core.Common.BO;
using QT.Entities.Data;
using QT.Entities.CrawlerProduct;
using Newtonsoft.Json;
using QT.Moduls.CrawlerProduct;
using System.Drawing;
using QT.Moduls.DBTableAdapters;
using Keys = OpenQA.Selenium.Keys;

namespace QT.Moduls.Company
{
    public partial class frmCongTy : QT.Entities.frmBase
    {
        private long _idCongTy = 0;
        private bool _upSpilit = true;
        private Entities.Company _company;
        private string _htmlSource = "";
        
        //private Price_LogsTableAdapter _adtPriceLog;
        //private DBTableAdapters.ClassificationTableAdapter _adtClass;
        //private DBTableAdapters.ProductTableAdapter _adtProduct;
        private CancellationTokenSource cancelUpdateDataFeedTokenSource;
        private Task updateDataFeedTask;
        private CompanyFunctions _companyFuction;
        public frmCongTy()
        {
            InitializeComponent();
            this.companyTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.company_StatusTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.configurationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.company_AddressTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.company_StatusTableAdapter.FillBySTT(dB.Company_Status);
            this.historyDatafeedTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.productTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.statusCombobox.SelectedIndex = 0;
            comboBoxDataFeedType.Items.Add(new ComboboxItem()
            {
                Text = Entities.Company.DataFeedType.None.ToString("G"),
                Value = (int)Entities.Company.DataFeedType.None
            });
            comboBoxDataFeedType.Items.Add(new ComboboxItem()
            {
                Text = Entities.Company.DataFeedType.AllProductsFromURL.ToString("G"),
                Value = (int)Entities.Company.DataFeedType.AllProductsFromURL
            });
            comboBoxDataFeedType.Items.Add(new ComboboxItem()
            {
                Text = Entities.Company.DataFeedType.AllProductsFromFile.ToString("G"),
                Value = (int)Entities.Company.DataFeedType.AllProductsFromFile
            });
            comboBoxDataFeedType.Items.Add(new ComboboxItem()
            {
                Text = Entities.Company.DataFeedType.SpecialProductsFromUrl.ToString("G"),
                Value = (int)Entities.Company.DataFeedType.SpecialProductsFromUrl
            });
            comboBoxDataFeedType.Items.Add(new ComboboxItem()
            {
                Text = Entities.Company.DataFeedType.SpecialProductsFromFile.ToString("G"),
                Value = (int)Entities.Company.DataFeedType.SpecialProductsFromFile
            });
            comboBoxDataFeedType.Items.Add(new ComboboxItem()
            {
                Text = Entities.Company.DataFeedType.MasOfferDatafeed.ToString("G"),
                Value = (int)Entities.Company.DataFeedType.MasOfferDatafeed
            });
            comboBoxDataFeedType.SelectedIndex = 0;

            #region Button Push Message to Rabbit Update SolrRedis
            if (QT.Users.User.UserName == "admin")
            {
                btnUpdateSolrRedis.Visible = true;
            }
            #endregion
        }
        public void LoadHistoryDatafeed(long ID)
        {
            try
            {
                //Lich su update datafeed
                this.historyDatafeedTableAdapter.FillBy_CompanyID(dBCom.HistoryDatafeed, ID);
            }
            catch (Exception)
            {
            }
        }
        public void SelectCompany(long ID)
        {
            _idCongTy = ID;
            LoadHistoryDatafeed(ID);

            this.dBCom.Company_Address.CompanyIDColumn.DefaultValue = _idCongTy;
            this.companyTableAdapter.Company_SelectOne(this.dB.Company, ID);
            if (QT.Entities.Common.Obj2Int(this.dB.Company.Rows[0]["DeliveryType"]) == 0)
            {
                _deliveryType = 0;
                //cmbDeliveryType.SelectedValue = 0;
                cmbDeliveryType.Text = "Miễn phí";
            }
            else if (QT.Entities.Common.Obj2Int(this.dB.Company.Rows[0]["DeliveryType"]) == 1)
            {
                _deliveryType = 1;
                //cmbDeliveryType.SelectedValue = 1;
                cmbDeliveryType.Text = "Tính phí";
            }
            else if (QT.Entities.Common.Obj2Int(this.dB.Company.Rows[0]["DeliveryType"]) == 2)
            {
                _deliveryType = 2;
                //cmbDeliveryType.SelectedValue = 2;
                cmbDeliveryType.Text = "Miễn phí có điều kiện";
            }
            else
            {
                _deliveryType = 3;
                //cmbDeliveryType.SelectedValue = 3;
                cmbDeliveryType.Text = "Ko xác định";
            }



            this.configurationTableAdapter.FillBy_CompanyID(dB.Configuration, ID);
            if (dB.Configuration.Rows.Count <= 0)
            {
                this.dB.Configuration.CompanyIDColumn.DefaultValue = ID;
                this.dB.Configuration.TimeDelayColumn.DefaultValue = 500;
                this.configurationBindingSource.AddNew();
                this.configurationBindingSource.EndEdit();
            }
            _company = new Entities.Company(_idCongTy);
            ctrLogMananger2.loadCompany(_idCongTy);
            this.company_AddressTableAdapter.FillBy_CompanyID(this.dBCom.Company_Address, _idCongTy);

            DBCom.ManagerTypeRCompanyDataTable dt = new DBCom.ManagerTypeRCompanyDataTable();
            DBComTableAdapters.ManagerTypeRCompanyTableAdapter adt = new DBComTableAdapters.ManagerTypeRCompanyTableAdapter();
            adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            adt.FillBy_IDCompany(dt, _idCongTy);
            if (dt.Rows.Count > 0)
            {
                this.laMapCrawler.Text = dt.Rows[0]["Name"].ToString();
            }
            dt.Dispose();
            adt.Dispose();

            if (_company.Status == Common.CompanyStatus.WEB_CRAWLERDOMAIN)
            {
                priceXPathLabel.Text = "Domain xpath";
                warrantyXPathLabel.Text = "Addres xpath";
                statusXPathLabel.Text = "Phone xpath";
                manufactureXPathLabel.Text = "fax xpath";
            }
            //DataFeed

            try
            {
                int iStatus = (dB.Configuration.Rows[0]["VATStatus"] == DBNull.Value) ? 0 : Convert.ToInt32(dB.Configuration.Rows[0]["VATStatus"]);
                if (iStatus == 0) ckNoVAT.Checked = true;
                else if (iStatus == 1) ckHaveVAT.Checked = true;
                else if (iStatus == 2) ckNoConfigVaT.Checked = true;
                else MessageBox.Show(string.Format("No vat status is:{0}", iStatus));
            }
            catch (Exception ex01)
            {
                MessageBox.Show(ex01.Message);
            }

            if (this.dB.Company.Count > 0)
            {
                if (this.dB.Company[0]["DataFeedType"] != DBNull.Value)
                {
                    foreach (var item in comboBoxDataFeedType.Items)
                    {
                        if ((int)((ComboboxItem)item).Value == this.dB.Company[0].DataFeedType)
                            comboBoxDataFeedType.SelectedItem = item;
                    }
                }
            }
        }
        public override bool Analytics()
        {
            AnalyticProduct();
            return true;
        }
        public void updateCompany()
        {
            try
            {
                this.companyBindingSource.EndEdit();
                this.companyTableAdapter.UpdateQuery(
                    Common.GetIDCompany(this.domainTextBox.Text.Trim()),
                    this.nameTextBox.Text.Trim(),
                    this.descriptionTextBox.Text.Trim(),
                    this.websiteTextBox.Text.Trim(),
                    this.domainTextBox.Text.Trim(),
                    this.phoneTextBox.Text.Trim(),
                    this.faxTextBox.Text.Trim(),
                    this.yahooTextBox.Text.Trim(),
                    this.addressTextBox.Text.Trim(),
                    Common.Obj2Byte(this.dB.Company.Rows[0]["Status"]),
                    this.checkBoxUseDataFeed.Checked,
                    this.imageTextBox.Text.Trim(),
                    this.lastFullCrawlerDateTimePicker.Value,
                    this.lastCrawlerDateTimePicker.Value,
                    this.keywordsTextBox.Text,
                    Common.Obj2Int(this.pageRankTextBox.Text),
                    Common.Obj2Int(this.alexaRankTextBox.Text), (int)this.numericUpDownUpdateDataFeedFrequence.Value, (byte)((ComboboxItem)this.comboBoxDataFeedType.SelectedItem).Value, this.textBoxDataFeedUrl.Text,
                    userDatafeedTextEdit.Text, passwordDatafeedTextEdit.Text, false, QT.Entities.Common.Obj2Bool(allowAutoBlackLinkCheckEdit), QT.Entities.Common.Obj2Bool(allowAutoPushNewProductCheckEdit.Checked),
                    QT.Entities.Common.Obj2Bool(allowFindNewCheckEdit.Checked), QT.Entities.Common.Obj2Bool(allowReloadCheckEdit.Checked), clearQueueWhenFNCheckEdit.Checked, DateTime.Now, trustedCheckEdit.Checked,
                    this.deliveryInfomationTextBox.Text, _deliveryType,
                    this._idCongTy);

                //LogJobAdapter.SaveLog(JobName.FrmCompany_ChangeCompany, "", QT.Entities.Common.Obj2Int64(iDCompanyTextBox.Text), (int)JobTypeData.Company);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public bool CheckSaveNewConfig()
        {
            Configuration config = new Configuration(QT.Entities.Common.Obj2Int64(this.companyIDTextBox.Text));
            if ((config.PriceXPath == null || config.PriceXPath.Count == 0)
                && (config.ImageXPath == null || config.ImageXPath.Count == 0)
                && !string.IsNullOrEmpty(this.imageXPathTextBox.Text)
                && !string.IsNullOrEmpty(this.priceXPathTextBox.Text))
            {
                return true;
            }
            else return false;
        }

        public override bool Save()
        {
            try
            {


                this.Validate();
                byte status = Common.Obj2Byte(this.dB.Company.Rows[0]["Status"]);
                this.iDCompanyTextBox.Text = Common.GetIDCompany(this.domainTextBox.Text.Trim()).ToString();
                _company = new Entities.Company(Common.GetIDCompany(this.domainTextBox.Text.Trim()));

                //try
                //{
                //    bool bSuccess = true;
                //    if (notVisibleProductCheckEdit.Checked == true
                //        && _company.notVisibleProduct == false)
                //    {
                //        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                //        bSuccess = productAdapter.UpdateNotShowProductForCompany(_company.ID, false);
                //    }
                //    else if (notVisibleProductCheckEdit.Checked == false
                //        && _company.notVisibleProduct == true)
                //    {
                //        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
                //        bSuccess = productAdapter.UpdateNotShowProductForCompany(_company.ID, true);
                //    }
                //    if (bSuccess==false)
                //    {
                //        MessageBox.Show("Có lỗi khi chuyển trạng thái hiện sản phẩm. Xem log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                //catch (Exception ex01)
                //{
                //}


                if (this.CheckSaveNewConfig())
                {
                    LogJobAdapter.SaveLog(JobName.FrmCompany_ChangeConfig_New, "Thiết lập config mới", QT.Entities.Common.Obj2Int64(this.iDCompanyTextBox.Text), (int)JobTypeData.Company);
                }
                else
                {
                    LogJobAdapter.SaveLog(JobName.FrmCompany_ChangeConfig_Fix, "Fix config lỗi", QT.Entities.Common.Obj2Int64(this.iDCompanyTextBox.Text), (int)JobTypeData.Company);
                }

                if ((status == Common.CompanyStatus.CONFIG)
                    || (status == Common.CompanyStatus.NOTCONFIG))
                {
                    if ((this.productUrlsRegexTextBox.Text.Trim().Length > 0) && (this.productNameXPathTextBox.Text.Trim().Length > 0))
                    {
                        this.statusCombobox.SelectedValue = Common.CompanyStatus.CONFIG;
                    }
                    else
                    {
                        this.statusCombobox.SelectedValue = Common.CompanyStatus.NOTCONFIG;
                    }
                }
                updateCompany();

                this.dB.Configuration.Rows[0]["VATStatus"] = this.GetVATCheckedCurrent();

                //this.dB.Company.Rows[0]["DeliveryType"] = this.GetDeliveryType();

                //this.companyBindingSource.EndEdit();
                //this.companyTableAdapter.Update(this.dB.Company);
                try
                {
                    this.configurationBindingSource.EndEdit();
                    this.companyBindingSource.EndEdit();
                    this.companyAddressBindingSource.EndEdit();


                    this.configurationTableAdapter.Update(this.dB.Configuration);
                    //this.companyTableAdapter.Update(this.dB.Company);
                    this.company_AddressTableAdapter.Update(this.dBCom.Company_Address);
                }
                catch (Exception)
                {
                    SelectCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()));
                    this.configurationBindingSource.EndEdit();
                    this.companyBindingSource.EndEdit();
                    this.configurationTableAdapter.Update(this.dB.Configuration);
                }
                this.ctrLogMananger2.Save();

                //LogJobAdapter.SaveLog(JobName.FrmCompany_ChangeConfig, "", QT.Entities.Common.Obj2Int64(this.iDCompanyTextBox.Text), (int)JobTypeData.Company);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
        }

        private int GetVATCheckedCurrent()
        {
            if (ckNoConfigVaT.Checked) return QT.Entities.Common.VATStatus.UndefinedVAT;
            else if (ckHaveVAT.Checked) return QT.Entities.Common.VATStatus.HaveVAT;
            else return QT.Entities.Common.VATStatus.NotVAT;
        }
        //private int GetDeliveryType()
        //{
        //    if (ckFree.Checked) return QT.Entities.Common.DeliveryType.Free;
        //    else if (ckFreeAndCondition.Checked) return QT.Entities.Common.DeliveryType.FreeAndCondition;
        //    else if(ckUndefind.Checked) return QT.Entities.Common.DeliveryType.UndefinedDelivery;
        //    else return QT.Entities.Common.DeliveryType.NotFree;
        //}
        private void frmCongTy_Load(object sender, EventArgs e)
        {
            #region Instock
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("ID", typeof(int));
            //DataRow dr = dt.NewRow();
            //dr["Name"] = "Liên hệ";
            //dr["ID"] = 0;
            //dt.Rows.Add(dr);
            //DataRow dr2 = dt.NewRow();
            //dr2["Name"] = "Còn hàng";
            //dr2["ID"] = 0;
            //dt.Rows.Add(dr2);
            //DataRow dr3 = dt.NewRow();
            //dr3["Name"] = "Hết hàng";
            //dr3["ID"] = 0;
            //dt.Rows.Add(dr3);
            //DataRow dr4 = dt.NewRow();
            //dr4["Name"] = "Đặt hàng";
            //dr4["ID"] = 0;
            //dt.Rows.Add(dr4);
            //repositoryItemLookUpEditInstock.DataSource = dt;
            #endregion
            PhanQuyen();
        }

        private void PhanQuyen()
        {
            if (QT.Users.User.UserName == "admin")
            {
                this.btDeleteProduct.Visible = true;
            }
            else
            {
                this.btDeleteProduct.Visible = false;
            }
        }

        private void frmCongTy_FormClosing(object sender, FormClosingEventArgs e)
        {
            finish = true;
            if (crawlerThread != null)
            {
                if (crawlerThread.IsAlive)
                {
                    crawlerThread.Abort();
                    crawlerThread.Join();
                    crawlerThread = null;
                }
            }
        }

        private void AnalyticProduct()
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtResult.Text = "";
            });

            this.Save();
            Wait.CreateWaitDialog();
            Wait.Show("Đang tải dữ liệu");
            QT.Entities.Configuration c = new Configuration(_idCongTy);
            if (_company.Status == Common.CompanyStatus.WEB_CRAWLERDOMAIN)
            {
                List<QT.Entities.Company> ls = new List<Entities.Company>();
                QT.Entities.CrawlerDomain obj = new CrawlerDomain();
                string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(this.linkTestTextBox.Text.Trim(), 15, 1);

                if (useClearHtmlCheckBox.Checked)
                {
                    html = Common.TidyCleanR(html);
                }
                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                html = html.Replace("<form", "<div");
                html = html.Replace("</form", "</div");
                doc.LoadHtml(html);
                ShowTest(obj.Analytics(doc, c, this.linkTestTextBox.Text.Trim()));
                Wait.Close();
            }
            else
            {
                QT.Entities.Product p = new Product();
                string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(this.linkTestTextBox.Text.Trim(), 45, 2);
                if (c.ContentAnanyticXPath.Count >= 1)
                {
                    int i1 = 0, i2 = 0;
                    i1 = html.IndexOf(c.ContentAnanyticXPath[0]);
                    if (i1 >= 0)
                    {
                        html = html.Substring(i1);
                        if (c.ContentAnanyticXPath.Count >= 2)
                        {
                            i2 = html.IndexOf(c.ContentAnanyticXPath[1]);
                            if (i2 >= 0)
                            {
                                html = html.Substring(0, i2 + c.ContentAnanyticXPath[1].Length);
                            }
                        }
                    }
                    html = html.Replace("<form", "<div");
                    html = html.Replace("</form", "</div");
                    html = Common.TidyCleanR(html);
                }


                if (useClearHtmlCheckBox.Checked)
                {
                    html = Common.TidyCleanR(html);
                }
                _htmlSource = html;
                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                html = html.Replace("<form", "<div");
                html = html.Replace("</form", "</div");
                doc.LoadHtml(html);
                p.Analytics(doc, this.linkTestTextBox.Text.Trim(), c, checboxPrice.Checked, _company.Domain, null);
                ShowTest(p);
                pictureBox1.Image = null;
                if (p.ImageUrls != null && p.ImageUrls.Count > 0)
                {
                    //this.webBrowserImage.Url = new System.Uri(p.ImageUrls[0].ToString(), System.UriKind.Absolute);
                    pictureBox1.ImageLocation = p.ImageUrls[0].ToString();
                }
                Wait.Close();
            }
        }
        private void btTestLink_Click(object sender, EventArgs e)
        {
            LogJobAdapter.SaveLog(JobName.FrmCompany_TestLink, "", QT.Entities.Common.Obj2Int64(iDCompanyTextBox.Text), (int)JobTypeData.Company);
            AnalyticProduct();
        }

        private void ShowTest(Product outPro)
        {
            if (outPro != null)
            {
                string str = "";
                str += "------------------------------------------------------";
                str += "\r\n Category\t:  " + Common.ConvertToString(outPro.Categories, " -> ");
                str += "\r\n Name\t:  " + outPro.Name + "\t\tID\t: " + outPro.ID.ToString();
                str += "\r\n Price\t: " + outPro.Price + " VND";
                str += "\r\n Image\t:  " + Common.ConvertToString(outPro.ImageUrls, "\r\n           " + "\r\n");
                str += "\r\n Status\t:  " + outPro.Status.ToString();
                str += "\t\t Warranty\t:  " + Convert.ToString((outPro.Warranty / 30 + " months"));
                str += "\r\n SortDescription\t:  " + outPro.ShortDescription;
                str += "\r\n StartDeal\t:  " + outPro.StartDeal.ToString("dd/MM/yyyy");
                str += "\t\t EndDeal\t:  " + outPro.EndDeal.ToString("dd/MM/yyyy");
                str += "\r\n PromotionInfo\t:  " + outPro.PromotionInfo + "\r";
                str += "\r\n DeliveryInfo\t:  " + outPro.DeliveryInfo + "\r";
                str += "\r\n OriginalPrice\t:  " + outPro.OriginPrice + "\r";
                str += "\r\n VATInfo\t:  " + outPro.VATInfo + "\r";
                str += "\r\n Sumary\t:  " + outPro.Summary + "\r";
                str += "\r\n Content\t:  " + outPro.ProductContent + "\r";
                str += "\r\n IsSuccess\t:  " + outPro.IsSuccessData(checkPriceCheckEdit.Checked) + "\r";
                txtResult.Text = str;

                txtVideo.Text = outPro.VideoDescHtml;
                txtSpe.Text = outPro.SpecsDescHtml;
                txtFullXpath.Text = outPro.FullDescHtml;
                txtShortDesc.Text = outPro.ShortDescHtml;
            }
        }

        private void ShowTest(List<Entities.Company> ls)
        {
            if (ls != null)
            {
                txtResult.AppendText("------------------------------------------------------");
                txtResult.AppendText("\r\nTong web\t:  " + ls.Count.ToString());
                for (int i = 0; i < ls.Count; i++)
                {
                    txtResult.AppendText(string.Format("\r\n domain: {0}  ", ls[i].Domain));
                    txtResult.AppendText(string.Format("\r\n image: {0}  ", ls[i].Image));
                    txtResult.AppendText(string.Format("\r\n Addres: {0}  ", ls[i].Address));
                    txtResult.AppendText(string.Format("\r\n Phone: {0}  ", ls[i].Phone));
                    txtResult.AppendText(string.Format("\r\n Fax: {0}  ", ls[i].Fax));
                    txtResult.AppendText(string.Format("\r\n Fax: {0}  ", ls[i].Fax));
                    txtResult.AppendText(string.Format("\r\n Yahoo: {0}  ", ls[i].Yahoo));
                }
            }
        }

        string DisplayProduct(Product product)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("------------------------------------------------------------------------------------------------------");
            sb.Append("\r\nURL\t:  " + product.DetailUrl);
            sb.Append("\r\nCategory\t:  " + Common.ConvertToString(product.Categories, " -> "));
            sb.Append("\r\nName\t:  " + product.Name);
            sb.Append("\r\nPrice\t:  " + product.Price + " VND");
            sb.Append("\t\tWarranty\t:  " + (int)(product.Warranty / 30) + " months");
            sb.Append("\t\tStatus\t:  " + product.Status.ToString());
            sb.Append("\r\nImage\t:  " + Common.ConvertToString(product.ImageUrls, "\r\n           ") + "\r\n");
            return sb.ToString();
        }
        void ShowTestRun(Product _product)
        {
            StringBuilder sb = new StringBuilder();

            //if (P_Show.Count >= 3)
            //    P_Show.RemoveAt(0);

            string ss = DisplayProduct(_product);

            P_Show.Add(ss);

            for (int i = 0; i < P_Show.Count; i++)
            {
                sb.Append(P_Show[i]);
            }

            this.Invoke((MethodInvoker)delegate
            {
                txtResult.Text = sb.ToString();
            });
        }
        private void btUp_Click(object sender, EventArgs e)
        {
            if (_upSpilit)
            {
                splitContainerControl2.SplitterPosition = 0;
                btUp.Text = "V";
            }
            else
            {
                splitContainerControl2.SplitterPosition = 330;
                btUp.Text = "^";
            }
            _upSpilit = !_upSpilit;
        }


        private void btRunTest_Click(object sender, EventArgs e)
        {
            rootUrl = this.websiteTextBox.Text.Trim();
            try
            {
                rootUri = new Uri(rootUrl);
                this.Save();
                this.btRunTest.Enabled = false;
                this.btPauseTest.Enabled = true;
                this.btStopTest.Enabled = true;
                pause = false;

                finish = false;

                start = DateTime.Now;
                visitedCount = 0;
                currentUrl = "";

                crawlerThread = new Thread(new ThreadStart(doCrawler));
                crawlerThread.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Website không đúng định dạng, bạn hãy chọn đường dẫn khác");
                this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
                this.websiteTextBox.Focus();
            }
        }
        private void btPauseTest_Click(object sender, EventArgs e)
        {
            pause = !pause;
            if (pause)
            {
                this.btPauseTest.Text = "Resume test";
            }
            else
            {
                this.btPauseTest.Text = "Pause test";
            }
        }
        private void btStopTest_Click(object sender, EventArgs e)
        {
            this.btRunTest.Enabled = true;
            this.btPauseTest.Enabled = false;
            this.btStopTest.Enabled = false;
            finish = true;
        }

        DateTime start;
        Thread crawlerThread;
        Queue<string> crawlerLink;
        List<long> visitedCRC;
        List<Product> Products;
        List<string> P_Show;
        Uri rootUri;
        bool finish = false;
        bool pause = false;
        int visitedCount = 0;
        int ignoredCount = 0;
        string currentUrl = "";
        List<string> crawlerRegex;
        List<string> detailLinkRegex;
        string rootUrl = "";

        private bool IsRelevantUrl(string url)
        {
            for (int i = 0; i < crawlerRegex.Count; i++)
            {
                Match m = Regex.Match(url, crawlerRegex[i]);
                if (m.Success)
                    return true;
            }
            return false;
        }
        private bool IsDetailUrl(string url)
        {
            for (int i = 0; i < detailLinkRegex.Count; i++)
            {
                Match m = Regex.Match(url, detailLinkRegex[i]);
                if (m.Success)
                    return true;
            }
            return false;
        }
        void doCrawler()
        {
            visitedCount = 0;
            Configuration config = new Configuration(_idCongTy);
            crawlerRegex = config.VisitUrlsRegex;
            detailLinkRegex = config.ProductUrlsRegex;
            P_Show = new List<string>();
            Products = new List<Product>();
            crawlerLink = new Queue<string>();
            visitedCRC = new List<long>();
            rootUri = new Uri(rootUrl);
            crawlerLink.Enqueue(rootUrl);

            while (crawlerLink.Count > 0)
            {
                if (Products.Count >= config.ItemReCrawler) { break; }
                if (finish) { break; }
                if (!pause)
                {
                    try
                    {
                        string c_url = crawlerLink.Dequeue();
                        FileLog.WriteAppendText(DateTime.Now.ToString("dd/MM HH:mm:ss") + "\t, " + c_url, rootUri.Host + ".txt");
                        string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(c_url, 45, 2);

                        if (html != "")
                        {
                            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                            if (config.UseClearHtml)
                            {
                                html = Common.TidyCleanR(html);
                            }
                            doc.LoadHtml(html);

                            var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");
                            if (a_nodes != null)
                            {
                                for (int i = 0; i < a_nodes.Count; i++)
                                {
                                    string s = Common.GetAbsoluteUrl(a_nodes[i].Attributes["href"].Value, rootUri);
                                    long s_crc = Tools.getCRC64(LinkCanonicalization.NormalizeLink(s));
                                    int index = visitedCRC.BinarySearch(s_crc);
                                    if (index < 0)
                                    {
                                        if (IsRelevantUrl(s))
                                            crawlerLink.Enqueue(s);

                                        visitedCRC.Insert(~index, s_crc);
                                    }
                                }
                            }

                            if (IsDetailUrl(c_url))
                            {

                                QT.Entities.Product p = new Product();
                                p.Analytics(doc, c_url, config, checboxPrice.Checked, _company.Domain, null);

                                if (p != null)
                                {
                                    if (p.Name != null)
                                    {
                                        if (p.Name.Trim() != "")
                                        {
                                            Products.Add(p);
                                            ShowTestRun(p);
                                        }
                                        else
                                        {
                                            FileLog.WriteAppendText(DateTime.Now.ToString("dd/MM HH:mm:ss") + "\t, " + "Product not name", rootUri.Host + ".txt");
                                        }
                                    }
                                }
                                else
                                {
                                    ignoredCount++;
                                }
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                lblVisited.Text = visitedCount.ToString();
                                lblQueue.Text = crawlerLink.Count.ToString();
                                lblProduct.Text = Products.Count.ToString();
                                txtUrlCurrent.Text = currentUrl;
                                var xx = DateTime.Now - start;
                                DateTime mydate = new DateTime(xx.Ticks);
                                lblTime.Text = mydate.ToString("HH:mm:ss");
                                lblIgnored.Text = ignoredCount.ToString();
                            });
                        }

                        visitedCount++;
                        currentUrl = c_url;
                        Thread.Sleep(config.TimeDelay);
                    }
                    catch (Exception ex)
                    {
                        FileLog.WriteAppendText(DateTime.Now.ToString("dd/MM HH:mm:ss") + "\t, " + ex.ToString(), rootUri.Host + ".txt");
                    }

                }
            }
            finish = true;
            this.Invoke((MethodInvoker)delegate
            {
                this.btRunTest.Enabled = true;
                this.btPauseTest.Enabled = false;
                this.btStopTest.Enabled = false;
            });
        }

        private void btClearVisited_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All data visited link can be delete?", "Messenger", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Crawler.DBQueueTableAdapters.VisitedLinksTableAdapter adt = new Crawler.DBQueueTableAdapters.VisitedLinksTableAdapter();
                    adt.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;
                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()));
                    adt.Dispose();

                    LogJobAdapter.SaveLog(JobName.FrmCompany_ClearVisited, "", QT.Entities.Common.Obj2Int64(iDCompanyTextBox.Text), (int)JobTypeData.Company);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btClearQueue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All data visited link can be delete?", "Messenger", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    Crawler.DBQueueTableAdapters.QueueLinksTableAdapter adt = new Crawler.DBQueueTableAdapters.QueueLinksTableAdapter();
                    adt.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;
                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), -9223357590766565814);
                    txtResult.Text = "Clear lần 1";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), -9223357590766565814);
                    txtResult.Text = "Clear lần 2";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), -8223357590766565814);
                    txtResult.Text = "Clear lần 3";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), -7223357590766565814);
                    txtResult.Text = "Clear lần 4";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), -6223357590766565814);
                    txtResult.Text = "Clear lần 5";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), -5223357590766565814);
                    txtResult.Text = "Clear lần 6";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), -4223357590766565814);
                    txtResult.Text = "Clear lần 7";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), -3223357590766565814);
                    txtResult.Text = "Clear lần 8";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), -2223357590766565814);
                    txtResult.Text = "Clear lần 9";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), -1223357590766565814);
                    txtResult.Text = "Clear lần 10";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), 0);
                    txtResult.Text = "Clear lần 11";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), 1223357590766565814);
                    txtResult.Text = "Clear lần 12";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), 2223357590766565814);
                    txtResult.Text = "Clear lần 13";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), 3223357590766565814);
                    txtResult.Text = "Clear lần 14";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), 4223357590766565814);
                    txtResult.Text = "Clear lần 15";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), 5223357590766565814);
                    txtResult.Text = "Clear lần 16";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), 6223357590766565814);
                    txtResult.Text = "Clear lần 17";
                    Application.DoEvents();

                    adt.DeleteQuery_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()), 7223357590766565814);
                    txtResult.Text = "Clear lần 18";
                    Application.DoEvents();
                    adt.DeleteQuery_ALL_ByCompany(Common.GetIDCompany(this.domainTextBox.Text.Trim()));
                    txtResult.Text = "Clear All finish";

                    LogJobAdapter.SaveLog(JobName.FrmCompany_ClearQueue, "", QT.Entities.Common.Obj2Int64(iDCompanyTextBox.Text), (int)JobTypeData.Company);

                    Application.DoEvents();
                    adt.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btViewQueue_Click(object sender, EventArgs e)
        {
            Crawler.frmCrawlerViewQueue frm = new Crawler.frmCrawlerViewQueue(Common.GetIDCompany(this.domainTextBox.Text.Trim()));
            frm.Show();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtResult.Text = "";
            });
        }

        private void visitUrlsRegexTextBox_Enter(object sender, EventArgs e)
        {
            if (visitUrlsRegexTextBox.Text.Trim() == "")
            {

                if (this.domainTextBox.Text.IndexOf("vatgia.com") > 0)
                {
                    #region domain vatgia
                    //QT.Entities.Configuration obj = new Configuration(4597063254163339898); //mobile.vatgia.com
                    //http://www.vatgia.com/1127/quat-dien-dan-dung.html
                    String idCatVatGia = ""; int count = 0;
                    string web = this.websiteTextBox.Text.Trim();
                    for (int i = 0; i < web.Length; i++)
                    {
                        if (web[i] == '/')
                        {
                            count++;
                        }
                        if (count == 3)
                        {
                            for (int j = i + 1; j < web.Length; j++)
                            {
                                if (web[j] == '/')
                                {
                                    idCatVatGia = web.Substring(i + 1, j - i - 1);
                                    break;
                                }
                            }
                            break;
                        }

                    }

                    DB.ConfigurationDataTable dt = new DB.ConfigurationDataTable();
                    this.configurationTableAdapter.FillBy_CompanyID(dt, 4597063254163339898);//mobile.vatgia.com
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DB.ConfigurationRow dr in dt)
                        {
                            this.visitUrlsRegexTextBox.Text = dr.VisitUrlsRegex.Replace("438", idCatVatGia);
                            this.productUrlsRegexTextBox.Text = dr.ProductUrlsRegex.Replace("438", idCatVatGia);
                            this.productNameXPathTextBox.Text = dr.ProductNameXPath;
                            this.categoryXPathTextBox.Text = dr.CategoryXPath;
                            this.priceXPathTextBox.Text = dr.PriceXPath;
                            this.imageXPathTextBox.Text = dr.ImageXPath;
                            this.contentXPathTextBox.Text = dr.ContentXPath;
                            this.blockXPathTextBox.Text = dr.BlockXPath;
                        }
                    }
                    #endregion
                }
                if (this.domainTextBox.Text.IndexOf("gsmarena.com") > 0)
                {
                    #region domain gsmarena.com
                    //http://www.gsmarena.com/sony-phones-7.php
                    string domain = this.domainTextBox.Text;
                    string category = "";
                    for (int i = 0; i < domain.Length; i++)
                    {
                        if (domain[i] == '.')
                        {
                            category = domain.Substring(0, i);
                            break;
                        }
                    }
                    DB.ConfigurationDataTable dt = new DB.ConfigurationDataTable();
                    this.configurationTableAdapter.FillBy_CompanyID(dt, 7293263928681582292);//nokia.gsmareba.com
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DB.ConfigurationRow dr in dt)
                        {
                            this.visitUrlsRegexTextBox.Text = dr.VisitUrlsRegex.Replace("nokia", category);
                            this.productUrlsRegexTextBox.Text = dr.ProductUrlsRegex.Replace("nokia", category);
                            this.productNameXPathTextBox.Text = dr.ProductNameXPath;
                            this.categoryXPathTextBox.Text = dr.CategoryXPath;
                            this.priceXPathTextBox.Text = dr.PriceXPath;
                            this.imageXPathTextBox.Text = dr.ImageXPath;
                            this.contentXPathTextBox.Text = dr.ContentXPath;
                            this.blockXPathTextBox.Text = dr.BlockXPath;
                        }
                    }
                    #endregion
                }
                else
                {
                    visitUrlsRegexTextBox.Text = String.Format("^http://w*.*{0}/.+", domainTextBox.Text);
                }
            }
        }

        private void btViewHtml_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtResult.Text = _htmlSource;
            });
        }

        private void productUrlsRegexTextBox_Enter(object sender, EventArgs e)
        {
            if (productUrlsRegexTextBox.Text.Trim() == "")
            {
                productUrlsRegexTextBox.Text = String.Format("^http://w*.*{0}/.+", domainTextBox.Text);
            }
        }

        private void btUpdateRedownload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All data can be redownload?", "Messenger", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DBComTableAdapters.ProductTableAdapter adt = new DBComTableAdapters.ProductTableAdapter();
                    adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
                    adt.UpdateQuery_LastUpdateByCopany(DateTime.Now.AddDays(-10), Common.GetIDCompany(this.domainTextBox.Text.Trim()));
                    LogJobAdapter.SaveLog(JobName.FrmCompany_Redownload, "", QT.Entities.Common.Obj2Int64(iDCompanyTextBox.Text), (int)JobTypeData.Company);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void linkTestTextBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
        }

        private void timeDelayTextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (Common.Obj2Int(txt.Text.Trim()) == 0)
                timeDelayTextBox1.Text = "500";
        }

        private void btGetAlexa_Click(object sender, EventArgs e)
        {
            Alexa obj = Common.GetRankAlexa(this.domainTextBox.Text);
            this.pageRankTextBox.Text = obj.AlexaRankContries.ToString();
            this.alexaRankTextBox.Text = obj.AlexaRank.ToString();
        }

        private void btMapQueue_Click(object sender, EventArgs e)
        {
            DBComTableAdapters.ManagerTypeRCompanyTableAdapter adtMTRC = new DBComTableAdapters.ManagerTypeRCompanyTableAdapter();
            adtMTRC.Connection.ConnectionString = Server.ConnectionString;

            DBComTableAdapters.Job_WebsiteConfigLogTableAdapter adtJob = new DBComTableAdapters.Job_WebsiteConfigLogTableAdapter();
            adtJob.Connection.ConnectionString = Server.ConnectionString;

            frmChonNhomQuanLy frm = new frmChonNhomQuanLy();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // delete cong ty ở tất cả các nhóm
                // insert vào nhóm mới

                adtMTRC.DeleteQuery_IDCompany(_idCongTy);
                adtMTRC.Insert(frm.IDManager, _idCongTy);

                adtJob.Insert(QT.Users.User.UserID, _idCongTy, laMapCrawler.Text, frm.NameTypeManager, QT.Users.JobNhapLieuStatus.FixLoi, DateTime.Now);

                LogJobAdapter.SaveLog(JobName.FrmCompany_ThayNhomQuanLy, "", Convert.ToInt64(iDCompanyTextBox.Text), (int)JobTypeData.Company);
            }
            frm.Dispose();
            adtMTRC.Dispose();
        }

        private void btMapTest_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://beta.websosanh.net/admin/googlemap/" + this.iDMapTextBox.Text + ".htm");
            Process.Start(sInfo);
        }

        private void btDeleteAddress_Click(object sender, EventArgs e)
        {

            if (this.companyAddressBindingSource.Count > 0)
            {
                this.companyAddressBindingSource.RemoveCurrent();
                LogJobAdapter.SaveLog(JobName.FrmCompany_XoaDiaChi, "", QT.Entities.Common.Obj2Int64(iDCompanyTextBox.Text), (int)JobTypeData.Company);
            }
        }

        private void btDeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All data product delete?", "Messenger", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_idCongTy != Common.GetIDCompany("quangtrung.vn"))
                {
                    DBComTableAdapters.ProductTableAdapter adt = new DBComTableAdapters.ProductTableAdapter();
                    adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
                    adt.DeleteQuery_ByCompany(_idCongTy);
                    adt.Dispose();
                }
            }
        }

        #region Data Feed

        private void checkBoxUseDataFeed_CheckedChanged(object sender, EventArgs e)
        {
            xtraTabPageConfigDataFeedXml.Visible = checkBoxUseDataFeed.Checked;
        }

        private void buttonOpenDataFeedFile_Click(object sender, EventArgs e)
        {
            var openDataFeedFileResult = openDataFeedFileDialog.ShowDialog();
            if (openDataFeedFileResult == DialogResult.OK)
            {
                txtDataFeedFileDir.Text = string.Join(";", openDataFeedFileDialog.FileNames);
            }
        }

        private void buttonUpdateProducts_Click(object sender, EventArgs e)
        {
            switch (_company.CompanyDataFeedType)
            {
                case Entities.Company.DataFeedType.AllProductsFromFile:
                case Entities.Company.DataFeedType.SpecialProductsFromFile:
                    _company.DataFeedPath = txtDataFeedFileDir.Text;
                    break;
                case Entities.Company.DataFeedType.AllProductsFromURL:
                case Entities.Company.DataFeedType.SpecialProductsFromUrl:
                case Entities.Company.DataFeedType.MasOfferDatafeed:
                    _company.DataFeedPath = textBoxDataFeedUrl.Text;
                    break;
                default:
                    return;
            }
            LogJobAdapter.SaveLog(JobName.FrmCompany_UpdateDatafeed, "Update datafeed...", _company.ID, (int)JobTypeData.Company);
            cancelUpdateDataFeedTokenSource = new CancellationTokenSource();
            updateDataFeedTask = Task.Factory.StartNew(UpdateDataFeedProducts, cancelUpdateDataFeedTokenSource.Token);
            buttonStopUpdateDataFeed.Enabled = true;
        }

        private void UpdateDataFeedProducts()
        {
            if (_companyFuction == null)
                _companyFuction = new CompanyFunctions();
            _companyFuction.UpdateDataFeedProducts(_company, cancelUpdateDataFeedTokenSource);
            Invoke((MethodInvoker)delegate
            {
                buttonStopUpdateDataFeed.Enabled = false;
            });
        }

        private void buttonStopUpdateDataFeed_Click(object sender, EventArgs e)
        {
            cancelUpdateDataFeedTokenSource.Cancel();
            buttonStopUpdateDataFeed.Enabled = false;
        }

        #endregion

        private void btSelectRegion_Click(object sender, EventArgs e)
        {
            frmChonRegion frm = new frmChonRegion();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.thanhPhoTextBox.Text = frm.NameThanhPho;
                this.quanHuyenTextBox.Text = frm.NameQuanHuyen;
                this.regionIDTextBox.Text = frm.IDRegion.ToString();
            }
        }

        private void comboBoxDataFeedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxDataFeedFromFile.Enabled = false;
            groupBoxDataFeedFromUrl.Enabled = false;
            if (comboBoxDataFeedType.SelectedIndex >= 0)
            {
                var selectItem = (Websosanh.Core.Common.BO.ComboboxItem)(comboBoxDataFeedType.SelectedItem);
                var selectType = (Entities.Company.DataFeedType)((int)selectItem.Value);
                if (selectType == Entities.Company.DataFeedType.AllProductsFromFile ||
                    selectType == Entities.Company.DataFeedType.SpecialProductsFromFile)  //file
                {
                    groupBoxDataFeedFromFile.Enabled = true;
                }
                else if (selectType == Entities.Company.DataFeedType.AllProductsFromURL ||
                    selectType == Entities.Company.DataFeedType.SpecialProductsFromUrl || selectType== Entities.Company.DataFeedType.MasOfferDatafeed)
                {
                    groupBoxDataFeedFromUrl.Enabled = true;
                }
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDataFeedUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTestDataFeed_Click(object sender, EventArgs e)
        {
            //Wait.Show("Đang load dữ liệu!");
            buttonTestDataFeed.Enabled = false;
            _companyFuction = new CompanyFunctions();
            List<Product> expected = new List<Product>();
            QT.Entities.Company companyTest = new Entities.Company(Common.Obj2Int64(iDCompanyTextBox.Text));
            var datafeedType = (Entities.Company.DataFeedType)(comboBoxDataFeedType.SelectedItem as ComboboxItem).Value;
            if (datafeedType == Entities.Company.DataFeedType.AllProductsFromFile || datafeedType == Entities.Company.DataFeedType.SpecialProductsFromFile)
            {
                companyTest.CompanyDataFeedType = datafeedType;
                companyTest.DataFeedPath = txtDataFeedFileDir.Text;
            }
            else if (datafeedType == Entities.Company.DataFeedType.AllProductsFromURL || datafeedType == Entities.Company.DataFeedType.SpecialProductsFromUrl || datafeedType == Entities.Company.DataFeedType.MasOfferDatafeed)
            {
                companyTest.CompanyDataFeedType = datafeedType;
                companyTest.DataFeedPath = textBoxDataFeedUrl.Text;
            }
            try
            {

                expected = _companyFuction.ReturnListProduct(companyTest);
                gridControlListProduct.DataSource = expected;
                richTextBoxDataFeedError.AppendText(string.Format("[{0}] Result: {1} products\n", DateTime.Now, expected.Count));
                LogJobAdapter.SaveLog(JobName.FrmCompany_TestDatafeed, string.Format("Test datafeed...ImagePath(url or file){0}", companyTest.DataFeedPath), companyTest.ID, (int)JobTypeData.Company);
            }
            catch (Exception ex)
            {
                richTextBoxDataFeedError.AppendText(string.Format("[{0}] Error:{1}\n", DateTime.Now, ex.Message));
                richTextBoxDataFeedError.AppendText(string.Format("{0}\n", ex.StackTrace));
            }
            buttonTestDataFeed.Enabled = true;
            //Wait.Close();
        }

        private void gridControlListProduct_Click(object sender, EventArgs e)
        {

        }

        private void DatafeedConfigButton_Click(object sender, EventArgs e)
        {
            frmDatafeedConfig frm = new frmDatafeedConfig(_idCongTy);
            frm.ShowDialog();
        }

        private void UploadImageMerchantButton_Click(object sender, EventArgs e)
        {
            DBComTableAdapters.Company_ImageTableAdapter companyimageAdapter = new DBComTableAdapters.Company_ImageTableAdapter();
            openFileDialogUploadImageMerchant.InitialDirectory = "C:\\";
            openFileDialogUploadImageMerchant.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG";
            openFileDialogUploadImageMerchant.FilterIndex = 2;
            openFileDialogUploadImageMerchant.RestoreDirectory = true;
            long companyId = Common.Obj2Int64(iDCompanyTextBox.Text);
            companyimageAdapter.Connection.ConnectionString = Server.ConnectionString;
            DBCom.Company_ImageDataTable companyimageTable = new DBCom.Company_ImageDataTable();
            try
            {
                companyimageAdapter.FillByIDCompany(companyimageTable, companyId);
            }
            catch (Exception exx)
            {
                richTextBoxMessage.Text = exx.Message.ToString();
            }
            int temp = 1;
            if (companyimageTable.Rows.Count > 0)
            {
                temp = Common.Obj2Int(companyimageTable.Rows[0]["ImageIndex"].ToString()) + 1;
            }
            int countsuccess = 0;
            if (openFileDialogUploadImageMerchant.ShowDialog() == DialogResult.OK)
            {
                Wait.Show("Đang upload ảnh!");
                if (openFileDialogUploadImageMerchant.FileNames.Length > 0)
                {
                    foreach (string filename in openFileDialogUploadImageMerchant.FileNames)
                    {
                        if (Common.UploadImageStore(companyId, domainTextBox.Text, filename, temp))
                        {
                            countsuccess++;
                            Wait.Show(string.Format("Upload {0}/{1} ảnh!", countsuccess, openFileDialogUploadImageMerchant.FileNames.Length));
                            temp++;
                        }
                    }
                    labelControlMessage.Text = String.Format("Upload {0}/{1} image!", countsuccess, openFileDialogUploadImageMerchant.FileNames.Length);
                }
                else
                    richTextBoxMessage.Text += " Loi tao duong dan tren server!\n";
            }
            else
                MessageBox.Show("Vui lòng chọn lại ảnh!");
            Wait.Close();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));

                this.Invoke((MethodInvoker)delegate
                    {
                        txtResult.Text = "";
                    });
                Wait.CreateWaitDialog();
                Wait.Show("Đang tải dữ liệu");
                QT.Entities.Configuration config = new Configuration(_idCongTy);
                if (_company.Status == Common.CompanyStatus.WEB_CRAWLERDOMAIN)
                {
                    List<QT.Entities.Company> ls = new List<Entities.Company>();
                    QT.Entities.CrawlerDomain obj = new CrawlerDomain();
                    string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(this.linkTestTextBox.Text.Trim(), 15, 1);
                    if (useClearHtmlCheckBox.Checked)
                    {
                        html = Common.TidyCleanR(html);
                    }
                    GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                    html = html.Replace("<form", "<div");
                    html = html.Replace("</form", "</div");
                    doc.LoadHtml(html);
                    ShowTest(obj.Analytics(doc, config, this.linkTestTextBox.Text.Trim()));
                    Wait.Close();
                }
                else
                {
                    int numberItemSaved = 0;
                    string[] arLink = this.linkTestTextBox.Text.Trim().Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in arLink)
                    {

                        QT.Entities.Product _product = new Product();
                        string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(item, 45, 2);
                        if (config.ContentAnanyticXPath.Count >= 1)
                        {
                            int i1 = 0, i2 = 0;
                            i1 = html.IndexOf(config.ContentAnanyticXPath[0]);
                            if (i1 >= 0)
                            {
                                html = html.Substring(i1);
                                if (config.ContentAnanyticXPath.Count >= 2)
                                {
                                    i2 = html.IndexOf(config.ContentAnanyticXPath[1]);
                                    if (i2 >= 0)
                                    {
                                        html = html.Substring(0, i2 + config.ContentAnanyticXPath[1].Length);
                                    }
                                }
                            }
                            html = html.Replace("<form", "<div");
                            html = html.Replace("</form", "</div");
                            html = Common.TidyCleanR(html);
                        }


                        if (useClearHtmlCheckBox.Checked)
                        {
                            html = Common.TidyCleanR(html);
                        }
                        _htmlSource = html;
                        GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                        html = html.Replace("<form", "<div");
                        html = html.Replace("</form", "</div");
                        doc.LoadHtml(html);

                        List<Product> lstUpdateProduct = new List<Product>();
                        List<Product> lstInsertProduct = new List<Product>();

                        _product.Analytics(doc, item, config, checboxPrice.Checked, _company.Domain, null);

                        if (_product != null && _product.IsSuccessData(checkPriceCheckEdit.Checked))
                        {
                            numberItemSaved++;
                            if (productAdapter.CheckExistInDb(_product.ID))
                            {
                                lstUpdateProduct.Add(_product);
                            }
                            else
                            {
                                lstInsertProduct.Add(_product);
                            }
                            productAdapter.UpdateProductsChangeToDb(lstUpdateProduct);
                            productAdapter.InsertListProduct(lstInsertProduct);

                            productAdapter.PushQueueIndexCompany(config.CompanyID);
                            //productAdapter.PushQueueChangeChangeImage(new MqChangeImage()
                            //{
                            //    ProductID = _product.ID,
                            //    Type = 1
                            //});

                            txtResult.AppendText(string.Format("Saved {0} item product!", _product.Name));
                        }
                        else
                        {
                            txtResult.AppendText(string.Format("{0} Fail", _product.Name));
                        }

                    }
                    Wait.Close();
                }
            }
            catch (Exception ex01)
            {
                MessageBox.Show(ex01.Message + ex01.StackTrace);
            }
        }
        private void ButtonPushMessageDownloadImage_Click(object sender, EventArgs e)
        {
            long idcompany = Common.Obj2Int64(iDCompanyTextBox.Text);
            bool reloadall = false;
            if (checkEditReloadAllImage.Checked)
                reloadall = true;
            if (_companyFuction == null)
                _companyFuction = new CompanyFunctions();
            if (_companyFuction.SendMessageDownloadImage(idcompany, reloadall))
            {
                LogJobAdapter.SaveLog(JobName.FrmCompany_PushMessageDownloadImage, "", idcompany, (int)JobTypeData.Company);
                ButtonPushMessageDownloadImage.Visible = false;
                MessageBox.Show("Send Message success!");
            }
            else
                MessageBox.Show("Send Message error!");
        }

        private void ButtonLoadProductFromDatabase_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang tải dữ liệu!");
            bool valid = true;
            if (checkEditValid.Checked)
                valid = true;
            else
                valid = false;
            try
            {
                if (checkEditLoadProductNotImagePath.Checked)
                    productTableAdapter.FillBy_CompanyAndValidAndImagePath(dB.Product, _idCongTy, valid);
                else
                    productTableAdapter.FillBy_CompanyAndValid(dB.Product, _idCongTy, valid);
            }
            catch (Exception)
            {
            }
            Wait.Close();
        }

        private void simpleButtonReloadHistory_Click(object sender, EventArgs e)
        {
            LoadHistoryDatafeed(_idCongTy);
        }
        private void simpleButtonExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;
                    //NImageExporter imageExporter = chartControl.ImageExporter;
                    switch (fileExtenstion)
                    {
                        case ".xls":
                            productGridControl.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            productGridControl.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            productGridControl.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            productGridControl.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            productGridControl.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            productGridControl.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                }
            }
            MessageBox.Show("Export Excel to Documents");
        }

        private void notVisibleProductCheckEdit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panelControl8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTestXpath_Click(object sender, EventArgs e)
        {
            TestXpath();
        }
        public override bool TestXpath()
        {
            QT.Entities.Product p = new Product();
            string a = p.TestXpath(linkTestTextBox.Text, textabc);
            MessageBox.Show(a);
            textabc = "";
            return true;
        }

        private string textabc = "";
        private void productNameXPathTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            textabc = productNameXPathTextBox.SelectedText;
        }

        private void priceXPathTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            textabc = priceXPathTextBox.SelectedText;
        }

        private void categoryXPathTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            textabc = categoryXPathTextBox.SelectedText;
        }

        private void imageXPathTextBox_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void txtResult_KeyDown(object sender, KeyEventArgs e)
        {
            //if ()
            //{

            //}
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang tải dữ liệu!");
            //bool isOriginal = true;
            //if (ckOriginalProduct.Checked)
            //    isOriginal = true;
            //else
            //    isOriginal = false;
            if ((ckOriginalProduct.Checked == true) && (ckNotOriginalProduct.Checked == false))
                productTableAdapter.FillBy_OriginalProduct(dB.Product, _idCongTy);
            else if ((ckOriginalProduct.Checked == false) && (ckNotOriginalProduct.Checked == true))
                productTableAdapter.FillBy_NotOriginalProduct(dB.Product, _idCongTy);
            else if ((ckOriginalProduct.Checked == true) && (ckNotOriginalProduct.Checked == true))
                productTableAdapter.FillBy_ListByCompany(dB.Product, _idCongTy);
            else
                dB.Product.Clear();
            Wait.Close();
        }

        private void btnExportToExel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;
                    //NImageExporter imageExporter = chartControl.ImageExporter;
                    switch (fileExtenstion)
                    {
                        case ".xls":
                            productGridControl1.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            productGridControl1.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            productGridControl1.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            productGridControl1.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            productGridControl1.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            productGridControl1.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                }
            }
            MessageBox.Show("Export Excel to Documents");
        }

        private void btntest_Click(object sender, EventArgs e)
        {

        }


        private void frmCongTy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode ==System.Windows.Forms.Keys.F6)
            {
                FrmShowDetailProduct.ShowProduct(this._company.ID);
            }
        }

        private void btnUpdateSolrRedis_Click(object sender, EventArgs e)
        {
            var _adtCompany = new CompanyTableAdapter();
            _adtCompany.Connection.ConnectionString = Server.ConnectionString;
            try
            {
                _adtCompany.UpdateLastUpdateDataFeedAndTotalValidAndTotalProduct(DateTime.Now, _company.ID);
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.ToString());
            }
            CompanyFunctions companyFunctions = new CompanyFunctions();
            if (companyFunctions.SendMessageUpdateSolrRedis(_company.ID))
                MessageBox.Show("Done!");
            else
                MessageBox.Show("False!");
        }

        private void btnUpdateVat_Click(object sender, EventArgs e)
        {
            long CompanyID = _idCongTy;
            

            SqlDb sqldb = new SqlDb(QT.Entities.Server.ConnectionString);
            if(ckHaveVAT.Checked)
            {
                sqldb.RunQuery("update Product set VATStatus = 1 where Company = @CompanyID", CommandType.Text, new SqlParameter[] { 
                    SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
                });
            }
            else if (ckNoVAT.Checked)
            {
                sqldb.RunQuery("update Product set VATStatus = 0 where Company = @CompanyID", CommandType.Text, new SqlParameter[] { 
                    SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
                });
            }
            else
            {
                sqldb.RunQuery("update Product set VATStatus = 2 where Company = @CompanyID", CommandType.Text, new SqlParameter[] { 
                    SqlDb.CreateParamteterSQL("@CompanyID",CompanyID,SqlDbType.BigInt)
                });
            }
            btnUpdateVat.Enabled = false;
        }

        private void ckNoConfigVaT_CheckedChanged(object sender, EventArgs e)
        {
            btnUpdateVat.Enabled = true;
        }
        private void ckHaveVAT_CheckedChanged(object sender, EventArgs e)
        {
            btnUpdateVat.Enabled = true;
        }

        private void ckNoVAT_CheckedChanged(object sender, EventArgs e)
        {
            btnUpdateVat.Enabled = true;
        }
        int _deliveryType = 0;
        private void cmbDeliveryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbDeliveryType.Text=="Miễn phí")
            {
                _deliveryType = 0;
            }
            else if (cmbDeliveryType.Text=="Tính phí")
            {
                _deliveryType = 1;
            }
            else if (cmbDeliveryType.Text == "Miễn phí có điều kiện")
            {
                _deliveryType = 2;
            }
            else
            {
                _deliveryType = 3;
            }
        }



    }

}

