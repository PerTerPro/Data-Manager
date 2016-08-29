//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//using QT.Entities;
//using GABIZ.Base;
//using GABIZ.Base.HtmlUrl;
//using System.Text.RegularExpressions;
//using System.Threading;
//using System.Data.SqlClient;
//using GABIZ.DAS.ContentAnalysis;
//using QT.Entities.Data;
//using OpenQA.Selenium.Firefox;
//using System.IO;
//using QT.Moduls.CrawlerProduct;

//namespace QT.Moduls.Crawler
//{
//    public partial class frmCrawlerProduct : QT.Entities.frmBase
//    {

//        log4net.ILog log = log4net.LogManager.GetLogger(typeof(frmCrawlerProduct));

//        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));

//        private ProductLogAddAdapter productLogAddAdapter = null;
//        private SqlDb sqlDbLog = null;

//        private List<long> lisIDClassification;
//        private DB.ClassificationDataTable _dtClassification;
//        private DBTableAdapters.ClassificationTableAdapter _adtClass;
//        private DBTableAdapters.ProductTableAdapter _adtProduct;
//        private DBCrawlerTableAdapters.Price_LogsTableAdapter _adtPriceLog;

//        private QT.Entities.Company company;
//        private DateTime start;
//        private Thread crawlerThread;
//        private Queue<string> crawlerLink;
//        private List<long> queueLinkCrawlerCRC;
//        private List<long> visitedCRC;
//        private List<long> NameCRC;
//        private int CountProducts = 0;
//        Dictionary<long, int> _listIDPrice;
//        List<long> _listIDDomain;
//        private List<string> P_Show;
//        private Uri rootUri;
//        private bool finish = false;
//        private bool pause = false;
//        private int visitedCount = 0;
//        private int ignoredCount = 0;
//        private string currentUrl = "";
//        private List<string> crawlerRegex;
//        private List<string> noCrawlerRegex;
//        private List<string> detailLinkRegex;
//        private string rootUrl = "";
//        private Configuration config;
//        private bool isFullCrawler = false;
        
//        private int stickReCrawler = 0;
//        private int stickFullCrawler = 0;
//        private int stickQueueCrawler = 0;
        
//        private bool showLog = false;
//        public bool IsClose = false;
//        public QT.Entities.Common.CrawlerCommand crawlerCommand;
//        private long _idCongTy = 0;

//        public bool _bTimSPMoi = false;
//        public bool _bQuetSPCu = false;
//        public QT.Entities.Common.ListWebCommand WebCommand = Common.ListWebCommand.ReloadManual;

//        /// <summary>
//        ///Tool phân tích mới.
//        /// </summary>
//        FirefoxDriver driver = null;

//        public frmCrawlerProduct(long idCongTy)
//        {

//            InitializeComponent();


           

//            this.sqlDbLog = new SqlDb(QT.Entities.Server.LogConnectionString);
//            this.productLogAddAdapter = new Entities.Data.ProductLogAddAdapter(this.sqlDbLog);

//            _idCongTy = idCongTy;
//            company = new Entities.Company(_idCongTy);
//            this.configurationTableAdapter.Connection.ConnectionString = Server.ConnectionString;

//            _dtClassification = new DB.ClassificationDataTable();
//            _adtClass = new DBTableAdapters.ClassificationTableAdapter();
//            _adtClass.Connection.ConnectionString = Server.ConnectionString;


//            _adtProduct = new DBTableAdapters.ProductTableAdapter();
//            _adtProduct.Connection.ConnectionString = Server.ConnectionString;

//            _adtPriceLog = new DBCrawlerTableAdapters.Price_LogsTableAdapter();
//            _adtPriceLog.Connection.ConnectionString = Server.ConnectionString;

            

//            this.chkLog.Checked = true;

//            this.EnabledStart = true;
//            this.EnabledStop = false;
//            this.EnabledPause = false;
//            this.EnabledRestart = false;
//        }

//        public override bool Start()
//        {
//            try
//            {

//                while (true)
//                {
//                    try
//                    {
//                        this.WindowState = System.Windows.Forms.FormWindowState.Normal;
//                        this.EnabledStart = false;
//                        this.EnabledStop = true;
//                        this.EnabledPause = true;
//                        this.EnabledRestart = true;
//                        rootUrl = company.Website;
//                        this.configurationBindingSource.EndEdit();
//                        this.configurationTableAdapter.Update(dB.Configuration);
//                        config = new Configuration(_idCongTy, true);
//                        rootUri = new Uri(rootUrl);
//                        pause = false;
//                        finish = false;
//                        start = DateTime.Now;
//                        visitedCount = 0;
//                        currentUrl = "";
//                        /// check thời gian crawler full
//                        isFullCrawler = ValidCrawlerFull();
//                        stickQueueCrawler = 0;
//                        timerQueue.Stop();
//                        break;
//                    }
//                    catch (Exception ex01)
//                    {
//                        RestartWaitNext();
//                    }
//                }

//                switch (WebCommand)
//                {
//                    case Common.ListWebCommand.ReloadManual:
//                        if (isFullCrawler)
//                        {
//                            timerFullCrawler.Stop();
//                            this.laStatus.Text = "Running full crawler ";
//                        }
//                        else
//                        {
//                            timerRecrawler.Stop();
//                            this.laStatus.Text = "Running normal crawler ";
//                        }
//                        crawlerThread = new Thread(new ThreadStart(doCrawler));
//                        break;
//                    case Common.ListWebCommand.FindNewManual:
//                        timerQueue.Stop();
//                        this.laStatus.Text = "Running Crawler Queue";
//                        if (company.Status == Common.CompanyStatus.WEB_CRAWLERDOMAIN)
//                        {
//                            crawlerThread = new Thread(new ThreadStart(doCrawlerTimWebMoiQueue));
//                        }
//                        else
//                            crawlerThread = new Thread(new ThreadStart(doCrawlerTimSPMoiQueue));
//                        break;
//                    case Common.ListWebCommand.CrawlerSanPhamCu:
//                        timerReCrawlerHistory.Stop();
//                        this.laStatus.Text = "Running Crawler History";
//                        crawlerThread = new Thread(new ThreadStart(doCrawlerQuetSPCu));
//                        break;
//                }
//                crawlerThread.Start();
//                return true;
//            }
//            catch (Exception ex)
//            {
//                string mssReport = string.Format("\nException in start method: {0}", ex.Message);
//                txtResult.AppendText(mssReport);
//                RestartWaitNext();
//            }
//            return true;
//        }

//        private void RestartWaitNext()
//        {
//            if (this.WebCommand == Common.ListWebCommand.FindNewManual) stickQueueCrawler = 10 * 10 * 60;
//            else if (WebCommand == Common.ListWebCommand.CrawlerSanPhamCu) stickQueueCrawler = 5 * 60;
//        }

//        public override bool Stop()
//        {
//            finish = true;
//            if (crawlerThread != null)
//            {
//                if (crawlerThread.IsAlive)
//                {
//                    crawlerThread.Abort();
//                    crawlerThread.Join();
//                    crawlerThread = null;
//                }
//            }
//            this.EnabledStart = true;
//            this.EnabledStop = false;
//            this.EnabledPause = false;
//            this.EnabledRestart = false;
//            return true;
//        }
//        public override bool Restart()
//        {
//            finish = true;
//            if (crawlerThread != null)
//            {
//                if (crawlerThread.IsAlive)
//                {
//                    crawlerThread.Abort();
//                    crawlerThread.Join();
//                    crawlerThread = null;
//                }
//            }
//            Start();
//            return true;
//        }
//        public override bool Pause()
//        {
//            pause = !pause;
//            if (pause)
//            {
//                this.EnabledStart = true;
//                this.EnabledStop = true;
//                this.EnabledPause = false;
//                this.EnabledRestart = true;
//            }
//            else
//            {
//                this.EnabledStart = false;
//                this.EnabledStop = true;
//                this.EnabledPause = true;
//                this.EnabledRestart = true;
//            }
//            return true;
//        }

//        public bool TimSPMoi
//        {
//            set { _bTimSPMoi = value; }
//            get { return _bTimSPMoi; }
//        }
//        public bool QuetSPCu
//        {
//            set { _bQuetSPCu = value; }
//            get { return _bQuetSPCu; }
//        }
//        private string DisplayProduct(Product product)
//        {
//            StringBuilder sb = new StringBuilder();
//            sb.Append("------------------------------------------------------------------------------------------------------");
//            sb.Append("\r\nURL\t:  " + product.DetailUrl);
//            sb.Append("\r\nCategory\t:  " + Common.ConvertToString(product.Categories, " -> "));
//            sb.Append("\r\nName\t:  " + product.Name);
//            sb.Append("\r\nPrice\t:  " + product.Price + " VND");
//            sb.Append("\t\tWarranty\t:  " + (int)(product.Warranty / 30) + " months");
//            sb.Append("\t\tStatus\t:  " + product.Status.ToString());
//            sb.Append("\t\tImage\t:  " + Common.ConvertToString(product.ImageUrls, "\r\n           ") + "\r\n");
//            return sb.ToString();
//        }
//        void ShowProduct(Product _product)
//        {
//            if (showLog)
//            {
//                StringBuilder sb = new StringBuilder();

//                if (P_Show.Count >= 8)
//                    P_Show.RemoveAt(0);

//                string ss = DisplayProduct(_product);

//                P_Show.Add(ss);

//                for (int i = 0; i < P_Show.Count; i++)
//                {
//                    sb.Append(P_Show[i]);
//                }

//                this.Invoke((MethodInvoker)delegate
//                {
//                    txtResult.Text = sb.ToString();
//                });
//            }
//        }
//        void ShowDomain(List<QT.Entities.Company> _lsCom)
//        {
//            if (showLog)
//            {
//                StringBuilder sb = new StringBuilder();

//                if (P_Show.Count >= 8)
//                    P_Show.RemoveAt(0);

//                string ss = "";
//                ss += string.Format("\r\n count: {0}   ",_lsCom.Count);
//                for (int i = 0; i < _lsCom.Count; i++)
//                {
//                    ss += _lsCom[i].Domain + "  ";
//                }
//                P_Show.Add(ss);

//                for (int i = 0; i < P_Show.Count; i++)
//                {
//                    sb.Append(P_Show[i]);
//                }

//                this.Invoke((MethodInvoker)delegate
//                {
//                    txtResult.Text = sb.ToString();
//                });
//            }
//        }
        
        
//        void DeleteProduct(long productID)
//        {
//            try
//            {
//                if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();
//                _adtProduct.DeleteQuery(productID);
//                _adtProduct.Connection.Close();
//            }
//            catch (Exception)
//            {
//            }
//        }
//        void UpdateProductNotValid(long idProduc)
//        {
//            try
//            {
//                if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();
//                _adtProduct.UpdateQuery_KhongTimThay(false, idProduc);
//            }
//            catch (Exception)
//            {
//            }

//        }

//        void UpdateProduct(Product _product)
//        {
//            _product.IDCongTy = this._idCongTy;
//            int index = lisIDClassification.BinarySearch(_product.IDCategories);
//            if (index < 0)
//            {
//                //Cập nhật phân nhóm theo web.
//                lisIDClassification.Insert(~index, _product.IDCategories);
//                try
//                {
//                    productAdapter.UpsertCategory(_product.IDCategories
//                        , Common.ConvertToString(_product.Categories, " -> ")
//                        , _idCongTy);
//                    //_adtClass.Insert(_product.IDCategories, Common.ConvertToString(_product.Categories, " -> "));
//                }
//                catch (Exception ex1)
//                {
//                    log.ErrorFormat(ex1.Message);
//                }
//            }
//            string image = "";
//            if (_product.ImageUrls.Count > 0) { image = _product.ImageUrls[0]; }

//            // check sản phẩm đã có chưa để update
//            try
//            {
//                if (_listIDPrice.ContainsKey(_product.ID))
//                {
//                    //update
//                    if (_product.Price != _listIDPrice[_product.ID])
//                    {
//                        InsertPriceLog(_product.ID, DateTime.Now, _product.Price, _listIDPrice[_product.ID]);
//                    }

//                    //Cập nhật thông tin.
//                    //this.productAdapter.UpdateProduct(_product.Name,
//                    //    _product.IDCategories,
//                    //    _product.Price,
//                    //    _product.Warranty,
//                    //    (short)_product.Status,
//                    //    image,
//                    //    _idCongTy,
//                    //    DateTime.Now,
//                    //    _product.DetailUrl,
//                    //    _product.Promotion,
//                    //    _product.Summary,
//                    //    _product.ProductContent,
//                    //    Common.UnicodeToKoDauFulltext(_product.Name + " " + _product.Domain),
//                    //    DateTime.Now,
//                    //     _listIDPrice[_product.ID],
//                    //     0, _product.DeliveryInfo
//                    //     , _product.OriginPrice
//                    //     , _product.ID
//                    //    , _product.VATInfo
//                    //    , _product.PromotionInfo
//                    //    , _product.ShortDescription
//                    //    , _product.StartDeal
//                    //    , _product.EndDeal
//                    //    , company.IDManagerType == 230);
//                }
//                else
//                {
//                    // insert product
//                    // đẩy vào list theo dõi.
//                    _listIDPrice.Add(_product.ID, _product.Price);
//                    int iname = NameCRC.BinarySearch(_product.HashName);
//                    if (iname < 0)
//                    {
//                        NameCRC.Insert(~iname, _product.HashName);
//                        //this.productAdapter.InsertToSQLDB(
//                        //        _product.ID,
//                        //        _product.Name,
//                        //        _product.IDCategories,
//                        //        _product.Price,
//                        //        _product.Warranty,
//                        //        (short)_product.Status,
//                        //        image,
//                        //        _idCongTy,
//                        //        DateTime.Now,
//                        //        _product.DetailUrl,
//                        //        0,
//                        //        _product.Promotion,
//                        //        _product.Summary,
//                        //        _product.ProductContent,
//                        //        Common.UnicodeToKoDauFulltext(_product.Name + " " + _product.Domain),
//                        //        _product.Valid,
//                        //        true,
//                        //        _product.HashName, 0, 0, _product.VATInfo
//                        //        , _product.PromotionInfo
//                        //        , _product.DeliveryInfo
//                        //        , _product.OriginPrice, _product.ShortDescription
//                        //        ,_product.StartDeal
//                        //        ,_product.EndDeal
//                        //        ,company.,config.VATStatus);

//                        InsertPriceLog(_product.ID, DateTime.Now, _product.Price, 0);


//                        //this.productLogAddAdapter.InsertLogAddProduct(
//                        //  _idCongTy, _product.ID
//                        //    , _product.Name, _product.DetailUrl);

//                    }
//                    else
//                    {
//                        FileLog.WriteAppendText("Trùng tên " + _product.Name, company.Domain + ".csv");
//                    }
//                }
//                //Cập nhật CategoryID.
//                try
//                {
//                    this.productAdapter.AutoFindCategoryID(_product.ID);
//                }
//                catch (Exception ex)
//                {
//                    log.ErrorFormat("Error when find categoryID for product {0}",ex.Message);
//                }
//            }
//            catch (Exception ex)
//            {
//                FileLog.WriteAppendText(ex.ToString(), company.Domain + ".csv");
//            }
//        }

//        #region UpdateProductOld
//        //void UpdateProduct(Product _product)
//        //{

//        //    int index = lisIDClassification.BinarySearch(_product.IDCategories);
//        //    if (index < 0)
//        //    {
//        //        lisIDClassification.Insert(~index, _product.IDCategories);
//        //        try
//        //        {
//        //            _adtClass.Connection.Open();
//        //            _adtClass.Insert(_product.IDCategories, Common.ConvertToString(_product.Categories, " -> "));
//        //            _adtClass.Connection.Close();
//        //        }
//        //        catch (Exception)
//        //        {
//        //        }
//        //    }
//        //    string image = "";
//        //    if (_product.ImageUrls.Count > 0) { image = _product.ImageUrls[0]; }
//        //    // check sản phẩm đã có chưa để update

//        //    try
//        //    {
//        //        if (_listIDPrice.ContainsKey(_product.ID))
//        //        {
//        //            //update
//        //            if (_product.Price != _listIDPrice[_product.ID])
//        //            {
//        //                // update ngày thay đổi giá và giá tiền
//        //                if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();
//        //                _adtProduct.Update_PriceChange(
//        //                    _product.Name,
//        //                    _product.IDCategories,
//        //                    _product.Price,
//        //                    _product.Warranty,
//        //                    (short)_product.Status,
//        //                    image,
//        //                    _idCongTy,
//        //                    DateTime.Now,
//        //                    _product.DetailUrl,
//        //                    _product.Promotion,
//        //                    _product.Summary,
//        //                    _product.ProductContent,
//        //                    Common.UnicodeToKoDauFulltext(_product.Name + " " + _product.Domain),
//        //                    DateTime.Now,
//        //                    false,
//        //                     _listIDPrice[_product.ID],
//        //                     0,
//        //                    _product.ID);
//        //                _adtProduct.Connection.Close();
//        //                InsertPriceLog(_product.ID, DateTime.Now, _product.Price, _listIDPrice[_product.ID]);

//        //            }
//        //            else
//        //            {
//        //                //update ngày cập nhật
//        //                if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();
//        //                _adtProduct.Update_LastUpdate(
//        //                   _product.Name,
//        //                   _product.IDCategories,
//        //                   _product.Price,
//        //                   _product.Warranty,
//        //                   (short)_product.Status,
//        //                   image,
//        //                   _idCongTy,
//        //                   DateTime.Now,
//        //                   _product.DetailUrl,
//        //                   _product.Promotion,
//        //                   _product.Summary,
//        //                   _product.ProductContent,
//        //                  Common.UnicodeToKoDauFulltext(_product.Name + " " + _product.Domain),
//        //                   false,
//        //                   0,
//        //                   _product.ID);
//        //                _adtProduct.Connection.Close();
//        //            }
//        //        }
//        //        else
//        //        {
//        //            // insert
//        //            _listIDPrice.Add(_product.ID, _product.Price);
//        //            int iname = NameCRC.BinarySearch(_product.HashName);
//        //            if (iname < 0)
//        //            {
//        //                NameCRC.Insert(~iname, _product.HashName);
//        //                if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();
//        //                _adtProduct.InsertQuery(
//        //                        _product.ID,
//        //                        _product.Name,
//        //                        _product.IDCategories,
//        //                        _product.Price,
//        //                        _product.Warranty,
//        //                        (short)_product.Status,
//        //                        image,
//        //                        _idCongTy,
//        //                        DateTime.Now,
//        //                        _product.DetailUrl,
//        //                        0,
//        //                        _product.Promotion,
//        //                        _product.Summary,
//        //                        _product.ProductContent,
//        //                        Common.UnicodeToKoDauFulltext(_product.Name + " " + _product.Domain),
//        //                        false,
//        //                        DateTime.Now,
//        //                        true,
//        //                        _product.HashName, 0,0
//        //                       );
//        //                _adtProduct.Connection.Close();
//        //                InsertPriceLog(_product.ID, DateTime.Now, _product.Price, 0);
//        //            }
//        //            else
//        //            {
//        //                FileLog.WriteAppendText("Trùng tên " + _product.Name, company.Domain + ".csv");
//        //            }
//        //        }
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        FileLog.WriteAppendText(ex.ToString(), company.Domain + ".csv");
//        //    }


//        //} 
//        #endregion
//        void InsertPriceLog(long productID,DateTime datePublic, int newsPrice, int oldPrice)
//        {
//            try
//            {
//                if (_adtPriceLog.Connection.State == ConnectionState.Closed) _adtPriceLog.Connection.Open();
//                _adtPriceLog.Insert(
//                    productID,
//                    datePublic,
//                    newsPrice,
//                    oldPrice);
//                _adtPriceLog.Connection.Close();
//            }
//            catch (Exception)
//            {
//                _adtPriceLog.Connection.Close();
//            }
            
//        }
//        // doi promotion thanh date public
//        void InsertNews(Product _product)
//        {

//            int index = lisIDClassification.BinarySearch(_product.IDCategories);
//            if (index < 0)
//            {
//                lisIDClassification.Insert(~index, _product.IDCategories);
//                try
//                {
//                    if (_adtClass.Connection.State == ConnectionState.Closed) _adtClass.Connection.Open();
//                    //_adtClass.Insert(_product.IDCategories, Common.ConvertToString(_product.Categories, " -> "));
//                    _adtClass.Connection.Close();
//                }
//                catch (Exception)
//                {
//                    _adtClass.Connection.Close();
//                }
//            }
//            string image = "";
//            if (_product.ImageUrls.Count > 0) { image = _product.ImageUrls[0]; }
//            // check sản phẩm đã có chưa để update

//            try
//            {
//                DateTime datepublic;
//                DatetimeParsing.DateTimeFormat dtFormat;
//                dtFormat = DatetimeParsing.DateTimeFormat.UK_DATE;
//                string s = _product.Promotion.Replace("Ngày gửi: ", "");
//                DateTime t1 = new DateTime(1900, 1, 1);
//                DateTime t2 = new DateTime(1900, 1, 1);
//                bool ok1 = DatetimeParsing.TryParseDate(s, dtFormat, out t1);
//                bool ok2 = DatetimeParsing.TryParseTime(s, dtFormat, out t2);
//                datepublic = new DateTime(t1.Year, t1.Month, t1.Day, t2.Hour, t2.Minute, t2.Second);


//                // insert
//                if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();
//                //_adtProduct.InsertQuery(
//                //        _product.ID,
//                //        _product.Name,
//                //        _product.IDCategories,
//                //        _product.Price,
//                //        _product.Warranty,
//                //        (short)_product.Status,
//                //        image,
//                //        _idCongTy,
//                //        datepublic,
//                //        _product.DetailUrl,
//                //        0,
//                //        _product.Promotion,
//                //        _product.Summary,
//                //        _product.ProductContent,
//                //        Common.UnicodeToKoDauFulltext(_product.Name),
//                //        false,
//                //        DateTime.Now,
//                //        true,
//                //        _product.HashName, 0,0,_product.VATInfo,_product.PromotionInfo,
//                //        _product.DeliveryInfo, _product.OriginPrice
//                //        );
//                _adtProduct.Connection.Close();
//                InsertPriceLog(_product.ID, DateTime.Now, _product.Price, 0);
//            }
//            catch (Exception ex)
//            {
//                FileLog.WriteAppendText(ex.ToString(), company.Domain + ".csv");
//            }


//        }
//        void UpdatePromotionSummary(Product _product, long idOld)
//        {
//            try
//            {
//                if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();

//                String image = Common.ConvertToString(Common.ParseImage(_product.Summary, rootUri,config.ImageGetFromRoot), "\n");
//                _adtProduct.UpdateQuery_Promotion_Summary(image, _product.Summary, idOld);
//                _adtProduct.Connection.Close();
//            }
//            catch (Exception ex)
//            {
//                FileLog.WriteAppendText(ex.ToString(), company.Domain + ".csv");
//            }
//        }


//        private bool IsRelevantUrl(string url)
//        {
//            //url = url.ToLower();
//            for (int i = 0; i < crawlerRegex.Count; i++)
//            {
//                Match m = Regex.Match(url, crawlerRegex[i]);
//                if (m.Success)
//                    return true;
//            }
//            return false;
//        }
//        private bool IsDetailUrl(string url)
//        {
//            for (int i = 0; i < detailLinkRegex.Count; i++)
//            {
//                Match m = Regex.Match(url, detailLinkRegex[i]);
//                if (m.Success)
//                    return true;
//            }
//            return false;


//            //url = url.ToLower();
//            //for (int i = 0; i < detailLinkRegex.Count; i++)
//            //{
//            //    Match m = Regex.Match(url, detailLinkRegex[i].ToLower());
//            //    if (m.Success)
//            //        return true;
//            //}
//            //return false;
//        }
//        private bool IsNoVisitUrl(string url)
//        {
//            //url = url.ToLower();
//            for (int i = 0; i < noCrawlerRegex.Count; i++)
//            {
//                Match m = Regex.Match(url, noCrawlerRegex[i]);
//                if (m.Success)
//                    return true;
//            }
//            Match m0 = Regex.Match(url, ".+.jpg$");
//            if (m0.Success) { return true; }
//            m0 = Regex.Match(url, ".+.png$");
//            if (m0.Success) { return true; }
//            m0 = Regex.Match(url, ".+facebook.+");
//            if (m0.Success) { return true; }
//            m0 = Regex.Match(url, ".+twitter.+");
//            if (m0.Success) { return true; }
//            m0 = Regex.Match(url, ".+filter.+");
//            if (m0.Success) { return true; }
//            m0 = Regex.Match(url, ".+dispatch.+");
//            if (m0.Success) { return true; }
//            m0 = Regex.Match(url, ".+product_compare.+");
//            if (m0.Success) { return true; }
//            m0 = Regex.Match(url, ".+login.+");
//            if (m0.Success) { return true; }
//            m0 = Regex.Match(url, ".+print.+");
//            if (m0.Success) { return true; }
//            m0 = Regex.Match(url, ".+search.+");
//            if (m0.Success) { return true; }
//            m0 = Regex.Match(url, ".+rao-vat.+");
//            if (m0.Success) { return true; }
//            m0 = Regex.Match(url, ".+sort.+");
//            if (m0.Success) { return true; }
//            m0 = Regex.Match(url, ".+price.+");
//            if (m0.Success) { return true; }

//            m0 = Regex.Match(url, ".+view=.+");
//            if (m0.Success) { return true; }
//            m0 = Regex.Match(url, ".+=.+=.+=.+");
//            if (m0.Success) { return true; }
//            return false;
//        }
//        private bool ValidCrawlerFull()
//        {
//            try
//            {
//                int day = (DateTime.Now.Year * 1000 + DateTime.Now.DayOfYear) - (company.LastCrawler.Year * 1000 + company.LastCrawler.DayOfYear);
//                if (config.DayReFullCrawler <= day)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//            catch (Exception)
//            {
//                return true;
//            }
//        }
//        void doCrawler()
//        {
//            #region Khởi tạo biến
//            lisIDClassification = new List<long>();
//            visitedCount = 0;
//            config = new Configuration(_idCongTy,true);
//            crawlerRegex = config.VisitUrlsRegex;
//            detailLinkRegex = config.ProductUrlsRegex;
//            noCrawlerRegex = config.NoVisitUrlRegex;
//            P_Show = new List<string>();
//            CountProducts = 0;
//            crawlerLink = new Queue<string>();
//            visitedCRC = new List<long>();
//            rootUri = new Uri(rootUrl);
//            #endregion

//            #region Nạp dữ liệu chuyên mục cũ web vào
//            try
//            {
//                _adtClass.Connection.Open();
//                _adtClass.FillBy_CompanyID(_dtClassification, _idCongTy);
//                _adtClass.Connection.Close();
//            }
//            catch (Exception)
//            {
//            }
//            int i0 = 0;
//            foreach (var dr in _dtClassification)
//            {
//                i0 = lisIDClassification.BinarySearch(dr.ID);
//                if (i0 < 0)
//                    lisIDClassification.Insert(~i0, dr.ID);
//            }
//            #endregion

//            crawlerLink.Enqueue(rootUrl);

//            #region Nạp dữ liệu toàn bộ sản phẩm đã crawler vào Dictionary
//            _listIDPrice = new Dictionary<long, int>();
//            NameCRC = new List<long>();
//            DB.ProductDataTable dtpd = new DB.ProductDataTable();

//            _adtProduct.Connection.Open();
//            _adtProduct.FillBy_ID_Price_HashName_By_Company(dtpd, _idCongTy);
//            _adtProduct.Connection.Close();

//            int i1 = 0;
//            foreach (DB.ProductRow dr in dtpd)
//            {
//                _listIDPrice.Add(dr.ID, dr.Price);
//                i1 = NameCRC.BinarySearch(dr.HashName);
//                if (i1 < 0)
//                    NameCRC.Insert(~i1, dr.HashName);
//            }
//            dtpd.Clear();
//            dtpd.Dispose();
//            #endregion

//            while (crawlerLink.Count > 0)
//            {
//                if (finish) { break; }
//                if (!isFullCrawler)
//                {
//                    if (CountProducts >= config.ItemReCrawler)
//                    {
//                        finish = true;
//                    }
//                }
//                if (!pause)
//                {
//                    #region Pause
//                    string c_url = crawlerLink.Dequeue();
//                    try
//                    {
//                        string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(c_url, 45, 2);

                        

//                        html = html.Replace("<form", "<div");
//                        html = html.Replace("</form", "</div");
//                        if (html != "")
//                        {
//                            GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
//                            if (config.UseClearHtml)
//                            {
//                                html = Common.TidyCleanR(html);
//                            }
//                            doc.LoadHtml(html);
//                            var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");
//                            if (a_nodes != null)
//                            {
//                                #region add link to process
//                                for (int i = 0; i < a_nodes.Count; i++)
//                                {
//                                    string s = Common.GetAbsoluteUrl(a_nodes[i].Attributes["href"].Value, rootUri);
//                                    long s_crc = Tools.getCRC64(LinkCanonicalization.NormalizeLink(s));
//                                    int index = visitedCRC.BinarySearch(s_crc);
//                                    if (index < 0)
//                                    {
//                                        if (IsRelevantUrl(s))
//                                            crawlerLink.Enqueue(s);
//                                        visitedCRC.Insert(~index, s_crc);
//                                    }
//                                }
//                                #endregion
//                            }

//                            if (IsDetailUrl(c_url))
//                            {
//                                #region analytic product
//                                QT.Entities.Product p = new Product();
//                                p.Analytics(doc, c_url, config, false, company.Domain);

//                                if (p != null)
//                                {
//                                    if ((p.Price > 0) && (p.Name.Trim().Length > 0))
//                                    {
//                                        //Products.Add(p);
//                                        CountProducts++;
//                                        ShowProduct(p);
//                                        UpdateProduct(p);
//                                    }
//                                }
//                                else
//                                {
//                                    ignoredCount++;
//                                }
//                                #endregion
//                            }
//                            if (showLog)
//                            {
//                                #region show log
//                                this.Invoke((MethodInvoker)delegate
//                                {
//                                    lblVisited.Text = visitedCount.ToString();
//                                    lblQueue.Text = crawlerLink.Count.ToString();
//                                    //lblProduct.Text = Products.Count.ToString();
//                                    lblProduct.Text = CountProducts.ToString();
//                                    txtUrlCurrent.Text = currentUrl;
//                                    var xx = DateTime.Now - start;
//                                    DateTime mydate = new DateTime(xx.Ticks);
//                                    lblTime.Text = mydate.ToString("HH:mm:ss");
//                                    lblIgnored.Text = ignoredCount.ToString();
//                                });
//                                #endregion
//                            }
//                        }
//                        visitedCount++;
//                        currentUrl = c_url;
//                        Thread.Sleep(config.TimeDelay);
//                    }
//                    catch (Exception ex)
//                    {
//                        FileLog.WriteAppendText(DateTime.Now.ToString("dd/MM HH:mm:ss") + "\t, " + c_url + "\r\n" + ex.ToString(), rootUri.Host + ".csv");
//                    }
//                    #endregion
//                }
//                else
//                {
//                    Thread.Sleep(10000);
//                }
//            }
//            #region kết thúc và giải phóng bộ nhớ
//            finish = true;
//            this.Invoke(
//                (MethodInvoker)delegate
//                {
//                    if (isFullCrawler)
//                    {
//                        stickFullCrawler = 0;
//                        timerFullCrawler.Start();
//                        this.laStatus.Text = "Crawler full finish";
//                    }
//                    else
//                    {
//                        stickReCrawler = 0;
//                        timerRecrawler.Start();
//                        this.laStatus.Text = "Crawler normal finish";
//                    }
//                    this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
//                });
//            //company.UpdateAfterCrawler(true);
//            crawlerLink.Clear();
//            crawlerLink = null;
//            _dtClassification.Clear();
//            _dtClassification.Dispose();
//            lisIDClassification.Clear(); lisIDClassification = null;
//            _listIDPrice.Clear(); _listIDPrice = null;
//            visitedCRC.Clear(); visitedCRC = null;
//            if (crawlerThread != null)
//            {
//                if (crawlerThread.IsAlive)
//                {
//                    crawlerThread.Abort();
//                    crawlerThread.Join();
//                    crawlerThread = null;
//                }
//            }
//            #endregion

//        }

//        void doCrawlerTimSPMoiQueue()
//        {
//            try
//            {
//                #region Khởi tạo biến
//                lisIDClassification = new List<long>();
//                queueLinkCrawlerCRC = new List<long>();
//                visitedCount = 0;
//                config = new Configuration(_idCongTy, true);
//                crawlerRegex = config.VisitUrlsRegex;
//                detailLinkRegex = config.ProductUrlsRegex;
//                noCrawlerRegex = config.NoVisitUrlRegex;
//                P_Show = new List<string>();
//                CountProducts = 0;
//                crawlerLink = new Queue<string>();
//                visitedCRC = new List<long>();
//                rootUri = new Uri(rootUrl);


//                if (this.config.use_selenium_crawler == true)
//                {
//                    this.driver = new FirefoxDriver();
//                }

//                #endregion

//                #region Nạp dữ liệu chuyên mục cũ web vào
//                try
//                {
//                    //if (_adtClass.Connection.State == ConnectionState.Closed) _adtClass.Connection.Open();
//                    _adtClass.FillBy_CompanyID(_dtClassification, _idCongTy);
//                    //_adtClass.Connection.Close();
//                }
//                catch (Exception)
//                {
//                }
//                int i0 = 0;
//                foreach (var dr in _dtClassification)
//                {
//                    i0 = lisIDClassification.BinarySearch(dr.ID);
//                    if (i0 < 0)
//                        lisIDClassification.Insert(~i0, dr.ID);
//                }
//                #endregion

//                crawlerLink.Enqueue(rootUrl);


//                bool checkLoadProduct = false;
//                #region Load link đã visited đưa vào visitedCRC
//                DBQueue.VisitedLinksDataTable dtVisited = new DBQueue.VisitedLinksDataTable();
//                DBQueueTableAdapters.VisitedLinksTableAdapter adtVisited = new DBQueueTableAdapters.VisitedLinksTableAdapter();
//                adtVisited.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;

//                adtVisited.FillBy_Company(dtVisited, _idCongTy);
//                if (dtVisited.Rows.Count > 0) checkLoadProduct = true;
//                foreach (DBQueue.VisitedLinksRow dr in dtVisited)
//                {
//                    int index = visitedCRC.BinarySearch(dr.CRC);
//                    if (index < 0)
//                    {
//                        visitedCRC.Insert(~index, dr.CRC);
//                    }
//                }

//                dtVisited.Rows.Clear();
//                dtVisited.Dispose();
//                #endregion


//                #region Nạp dữ liệu toàn bộ sản phẩm đã crawler vào Dictionary
//                _listIDPrice = new Dictionary<long, int>();
//                NameCRC = new List<long>();
//                if (checkLoadProduct)
//                {
//                    DB.ProductDataTable dtpd = new DB.ProductDataTable();
//                    _adtProduct.FillBy_ID_Price_HashName_By_Company(dtpd, _idCongTy);
//                    int i1 = 0;
//                    foreach (DB.ProductRow dr in dtpd)
//                    {
//                        _listIDPrice.Add(dr.ID, dr.Price);
//                        i1 = NameCRC.BinarySearch(dr.HashName);
//                        if (i1 < 0) NameCRC.Insert(~i1, dr.HashName);
//                    }
//                    dtpd.Clear();
//                    dtpd.Dispose();
//                }
//                #endregion




//                #region ----Load dữ liệu queue cũ đưa vào visitedCRC để chỉ tải sản phẩm mới nếu trường hợp data trong bảng VisitedLink bị xóa
//                DBCrawler.ProductQueueDataTable dtProductOld = new DBCrawler.ProductQueueDataTable();
//                DBCrawlerTableAdapters.ProductQueueTableAdapter adtProductOld = new DBCrawlerTableAdapters.ProductQueueTableAdapter();
//                adtProductOld.Connection.ConnectionString = Server.ConnectionString;
//                adtProductOld.FillByCompanyID(dtProductOld, _idCongTy);

//                foreach (DBCrawler.ProductQueueRow dr in dtProductOld)
//                {
//                    //string s = dr.DetailUrl.ToString().Trim();// Common.GetAbsoluteUrl(dr.DetailUrl.ToString().Trim(), rootUri);
//                    //long s_crc = Tools.getCRC64(LinkCanonicalization.NormalizeLink(s));
//                    int index = visitedCRC.BinarySearch(dr.ID);
//                    if (index < 0)
//                    { visitedCRC.Insert(~index, dr.ID); }
//                }
//                CountProducts += dtProductOld.Rows.Count;
//                dtProductOld.Clear();
//                dtProductOld.Dispose();
//                adtProductOld.Dispose();
//                #endregion

//                #region Load queue đã lưu lại trong db
//                DBQueue.QueueLinksDataTable dtQueue = new DBQueue.QueueLinksDataTable();
//                DBQueueTableAdapters.QueueLinksTableAdapter adtQueue = new DBQueueTableAdapters.QueueLinksTableAdapter();
//                adtQueue.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;
//                try
//                {
//                    if (adtQueue.Connection.State == ConnectionState.Closed) adtQueue.Connection.Open();
//                    adtQueue.FillBy_Company(dtQueue, _idCongTy);
//                    adtQueue.Connection.Close();

//                    foreach (DBQueue.QueueLinksRow dr in dtQueue)
//                    {
//                        int index = queueLinkCrawlerCRC.BinarySearch(dr.CRC);
//                        if (index < 0)
//                        {
//                            crawlerLink.Enqueue(dr.URL.Trim());
//                            queueLinkCrawlerCRC.Insert(~index, dr.CRC);
//                        }
//                    }
//                }
//                catch (Exception)
//                {
//                }
//                dtQueue.Rows.Clear();
//                dtQueue.Dispose();
//                #endregion


//                DBQueue.QueueLinksDataTable dtQueueBulkCopy = new DBQueue.QueueLinksDataTable();
//                DBQueue.VisitedLinksDataTable dtVisitedBulkCopy = new DBQueue.VisitedLinksDataTable();
//                /// tổng giá trị khi insert
//                int CountInsert = 50;
//                /// index insert
//                int indexPositionQueue = 1;
//                int indexPositionLinkVisited = 1;


//                while (crawlerLink.Count > 0)
//                {
//                    if (finish) { break; }
//                    if (!pause)
//                    {
//                        #region Pause
//                        string c_url = crawlerLink.Dequeue();

//                        if (IsNoVisitUrl(currentUrl))
//                        {
//                            #region  xoa blacklink trong queue
//                            try
//                            {
//                                Thread.Sleep(100);
//                                long s_crcNoCrawler = Tools.getCRC64(LinkCanonicalization.NormalizeLink(c_url));
//                                //if (adtQueue.Connection.State == ConnectionState.Closed) adtQueue.Connection.Open();
//                                adtQueue.DeleteQuery_By_CRC(s_crcNoCrawler);
//                                //adtQueue.Connection.Close();
//                            }
//                            catch (Exception)
//                            {
//                            }
//                            #endregion
//                        }
//                        else
//                        {
//                            /// kiem tra link nay da visit thi xoa di
//                            long s_crcDelete = Tools.getCRC64(LinkCanonicalization.NormalizeLink(c_url));
//                            int indexDelelte = visitedCRC.BinarySearch(s_crcDelete);
//                            if (indexDelelte > 0)
//                            {
//                                //delete
//                                try
//                                {
//                                    Thread.Sleep(100);
//                                    adtQueue.DeleteQuery_By_CRC(s_crcDelete);
//                                }
//                                catch (Exception)
//                                {
//                                }
//                            }
//                            else
//                            {
//                                try
//                                {
//                                    if (indexDelelte < 0) visitedCRC.Insert(~indexDelelte, s_crcDelete);
//                                    // insert vào visited db
//                                    dtVisitedBulkCopy.Rows.Add(-indexPositionLinkVisited, s_crcDelete, _idCongTy);
//                                    indexPositionLinkVisited++;

//                                    #region  Phân tích link lấy ra từ queue
//                                    string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(c_url, 45, 2);
//                                    try
//                                    {
//                                        if (driver != null)
//                                        {

//                                            driver.Url = c_url;
//                                            html = driver.PageSource;
//                                        }
//                                    }
//                                    catch (Exception ex)
//                                    {
//                                    }

//                                    if (html != "")
//                                    {
//                                        html = html.Replace("<form", "<div");
//                                        html = html.Replace("</form", "</div");
//                                        GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
//                                        if (config.UseClearHtml)
//                                        {
//                                            html = Common.TidyCleanR(html);
//                                        }
//                                        doc.LoadHtml(html);
//                                        var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");

//                                        List<string> lstLink = new List<string>();
//                                        foreach (var itemNode in a_nodes) lstLink.Add(itemNode.Attributes["href"].Value.ToString());
//                                        string a = Common.ConvertToString(lstLink, "\n");
//                                        log.Info(a);
//                                        if (a_nodes != null)
//                                        {
//                                            #region add link to process and insert to db
//                                            for (int i = 0; i < a_nodes.Count; i++)
//                                            {
//                                                string s = System.Web.HttpUtility.HtmlDecode(
//                                                    Common.GetAbsoluteUrl(a_nodes[i].Attributes["href"].Value, rootUri));

//                                                string url = LinkCanonicalization.NormalizeLink(s);

//                                                string urlPost = Common.GetAbsoluteUrl(s, rootUri);

//                                                //Thêm xử lí cho adayroi.
//                                                if (url.Contains("adayroi")) url = url.Replace(@"https://", @"https://www.");

//                                                if (url.Length < 512)
//                                                {
//                                                    long s_crc = Tools.getCRC64(url.Trim());
//                                                    // kiểm tra link này có được sử lý không
//                                                    // nếu có kiểm tra link này đã có trong queue chưa
//                                                    // nếu chưa có kiểm tra trong visited
//                                                    // nếu chưa có đưa vào queue sử lý
//                                                    if (!IsNoVisitUrl(s))
//                                                    {
//                                                        if (IsRelevantUrl(s))
//                                                        {
//                                                            int indexQueue = queueLinkCrawlerCRC.BinarySearch(s_crc);
//                                                            if (indexQueue < 0)
//                                                            {
//                                                                int indexVisited = visitedCRC.BinarySearch(s_crc);
//                                                                if (indexVisited < 0)
//                                                                {
//                                                                    crawlerLink.Enqueue(urlPost);
//                                                                    queueLinkCrawlerCRC.Insert(~indexQueue, s_crc);
//                                                                    dtQueueBulkCopy.Rows.Add(-indexPositionQueue, s_crc, _idCongTy, url);
//                                                                    indexPositionQueue++;
//                                                                }
//                                                            }
//                                                        }
//                                                    }
//                                                }
//                                            }
//                                            #endregion

//                                            #region Inser db crawler
//                                            //var x = CreateChecksumeRows(crawlerLinks);

//                                            try
//                                            {
//                                                if (dtQueueBulkCopy.Rows.Count >= CountInsert)
//                                                {
//                                                    SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionStringCrawler);
//                                                    sqlConn.Open();
//                                                    var bulkCopyQueue = new SqlBulkCopy(sqlConn);
//                                                    bulkCopyQueue.DestinationTableName = "QueueLinks";
//                                                    bulkCopyQueue.WriteToServer(dtQueueBulkCopy);
//                                                    if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
//                                                    dtQueueBulkCopy.Rows.Clear();
//                                                    dtQueueBulkCopy = new DBQueue.QueueLinksDataTable();
//                                                    indexPositionQueue = 1;
//                                                }
//                                                if (dtVisitedBulkCopy.Rows.Count >= CountInsert)
//                                                {
//                                                    SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionStringCrawler);
//                                                    sqlConn.Open();
//                                                    var bulkCopyVisited = new SqlBulkCopy(sqlConn);
//                                                    bulkCopyVisited.DestinationTableName = "VisitedLinks";
//                                                    bulkCopyVisited.WriteToServer(dtVisitedBulkCopy);
//                                                    if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
//                                                    dtVisitedBulkCopy.Rows.Clear();
//                                                    dtVisitedBulkCopy = new DBQueue.VisitedLinksDataTable();
//                                                    indexPositionLinkVisited = 1;
//                                                }
//                                            }
//                                            catch (Exception)
//                                            {
//                                            }


//                                            #endregion
//                                        }

//                                        #region {Xuân Tráng - Nạp code html từ folder. Giải quyết java scrip từ danh mục.}
//                                        if (this.company.Domain.Contains("dodiengiare"))
//                                        {
//                                            string[] arFile = System.IO.Directory.GetFiles("dodiengiare.vn");
//                                            for (var iFile = arFile.Length - 1; iFile >= 0; iFile--)
//                                            {
//                                                string file = arFile[iFile];
//                                                ; if (file.EndsWith(@".txt"))
//                                                {
//                                                    string htmlCode = File.ReadAllText(file);
//                                                    GABIZ.Base.HtmlAgilityPack.HtmlDocument docHtml = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
//                                                    doc.LoadHtml(htmlCode);
//                                                    var a_nodes1 = doc.DocumentNode.SelectNodes("//a[@href]");
//                                                    if (a_nodes1 != null)
//                                                    {
//                                                        #region add link to process and insert to db
//                                                        for (int i = 0; i < a_nodes1.Count; i++)
//                                                        {
//                                                            string s = System.Web.HttpUtility.HtmlDecode(
//                                                                Common.GetAbsoluteUrl(a_nodes1[i].Attributes["href"].Value, rootUri));
//                                                            string url = LinkCanonicalization.NormalizeLink(s);
//                                                            string urlPost = Common.GetAbsoluteUrl(s, rootUri);
//                                                            //Thêm xử lí cho adayroi.
//                                                            if (url.Contains("adayroi")) url = url.Replace(@"https://", @"https://www.");
//                                                            if (url.Length < 512)
//                                                            {
//                                                                long s_crc = Tools.getCRC64(url.Trim());
//                                                                // kiểm tra link này có được sử lý không
//                                                                // nếu có kiểm tra link này đã có trong queue chưa
//                                                                // nếu chưa có kiểm tra trong visited
//                                                                // nếu chưa có đưa vào queue sử lý
//                                                                if (!IsNoVisitUrl(s))
//                                                                {
//                                                                    if (IsRelevantUrl(s))
//                                                                    {
//                                                                        int indexQueue = queueLinkCrawlerCRC.BinarySearch(s_crc);
//                                                                        if (indexQueue < 0)
//                                                                        {
//                                                                            int indexVisited = visitedCRC.BinarySearch(s_crc);
//                                                                            if (indexVisited < 0)
//                                                                            {
//                                                                                crawlerLink.Enqueue(urlPost);
//                                                                                queueLinkCrawlerCRC.Insert(~indexQueue, s_crc);
//                                                                                dtQueueBulkCopy.Rows.Add(-indexPositionQueue, s_crc, _idCongTy, url);
//                                                                                indexPositionQueue++;
//                                                                            }
//                                                                        }
//                                                                    }
//                                                                }
//                                                            }
//                                                        }
//                                                        #endregion

//                                                        #region Inser db crawler
//                                                        //var x = CreateChecksumeRows(crawlerLinks);

//                                                        try
//                                                        {
//                                                            if (dtQueueBulkCopy.Rows.Count >= CountInsert)
//                                                            {
//                                                                SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionStringCrawler);
//                                                                sqlConn.Open();
//                                                                var bulkCopyQueue = new SqlBulkCopy(sqlConn);
//                                                                bulkCopyQueue.DestinationTableName = "QueueLinks";
//                                                                bulkCopyQueue.WriteToServer(dtQueueBulkCopy);
//                                                                if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
//                                                                dtQueueBulkCopy.Rows.Clear();
//                                                                dtQueueBulkCopy = new DBQueue.QueueLinksDataTable();
//                                                                indexPositionQueue = 1;
//                                                            }
//                                                            if (dtVisitedBulkCopy.Rows.Count >= CountInsert)
//                                                            {
//                                                                SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionStringCrawler);
//                                                                sqlConn.Open();
//                                                                var bulkCopyVisited = new SqlBulkCopy(sqlConn);
//                                                                bulkCopyVisited.DestinationTableName = "VisitedLinks";
//                                                                bulkCopyVisited.WriteToServer(dtVisitedBulkCopy);
//                                                                if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
//                                                                dtVisitedBulkCopy.Rows.Clear();
//                                                                dtVisitedBulkCopy = new DBQueue.VisitedLinksDataTable();
//                                                                indexPositionLinkVisited = 1;
//                                                            }
//                                                        }
//                                                        catch (Exception)
//                                                        {
//                                                        }


//                                                        #endregion
//                                                    }
//                                                    System.IO.File.Delete(Application.StartupPath + @"\" + file);
//                                                }
//                                            }
//                                        }
//                                        #endregion


//                                        if (IsDetailUrl(c_url))
//                                        {
//                                            if (company.Status == Common.CompanyStatus.TIN)
//                                            {
//                                                QT.Entities.Product p = new Product();
//                                                p.Analytics(doc, c_url, config, false, company.Domain);
//                                                CountProducts++;
//                                                ShowProduct(p);
//                                                InsertNews(p);
//                                            }
//                                            else
//                                            {
//                                                #region analytic product
//                                                QT.Entities.Product p = new Product();
//                                                p.Analytics(doc, c_url, config, false, company.Domain);

//                                                if (p != null)
//                                                {

//                                                    if ((p.Price > 0) && (p.Name.Trim().Length > 0))
//                                                    {
//                                                        //Products.Add(p);
//                                                        CountProducts++;
//                                                        ShowProduct(p);
//                                                        UpdateProduct(p);
//                                                    }

//                                                }
//                                                else
//                                                {
//                                                    ignoredCount++;
//                                                }
//                                                #endregion
//                                            }

//                                        }

//                                        if (showLog)
//                                        {
//                                            #region show log
//                                            this.Invoke((MethodInvoker)delegate
//                                            {
//                                                lblVisited.Text = visitedCount.ToString();
//                                                lblQueue.Text = crawlerLink.Count.ToString();
//                                                //lblProduct.Text = Products.Count.ToString();
//                                                lblProduct.Text = CountProducts.ToString();
//                                                txtUrlCurrent.Text = currentUrl;
//                                                var xx = DateTime.Now - start;
//                                                DateTime mydate = new DateTime(xx.Ticks);
//                                                lblTime.Text = mydate.ToString("HH:mm:ss");
//                                                lblIgnored.Text = ignoredCount.ToString();
//                                            });
//                                            #endregion
//                                        }

//                                    }
//                                    visitedCount++;
//                                    currentUrl = c_url;
//                                    #endregion

//                                    #region xóa link đã được sử lý trong queue db
//                                    try
//                                    {
//                                        if (adtQueue.Connection.State == ConnectionState.Closed) adtQueue.Connection.Open();
//                                        adtQueue.DeleteQuery_By_CRC(s_crcDelete);
//                                        adtQueue.Connection.Close();
//                                    }
//                                    catch (Exception)
//                                    {
//                                    }
//                                    #endregion
//                                    Thread.Sleep(config.TimeDelay);
//                                }
//                                catch (Exception ex)
//                                {
//                                    FileLog.WriteAppendText(DateTime.Now.ToString("dd/MM HH:mm:ss") + "\t, " + c_url + "\r\n" + ex.ToString(), rootUri.Host + ".csv");
//                                }
//                            }
//                        }
//                        if (showLog)
//                        {
//                            #region show log
//                            this.Invoke((MethodInvoker)delegate
//                            {
//                                lblVisited.Text = visitedCount.ToString();
//                                lblQueue.Text = crawlerLink.Count.ToString();
//                                //lblProduct.Text = Products.Count.ToString();
//                                lblProduct.Text = CountProducts.ToString();
//                                txtUrlCurrent.Text = currentUrl;
//                                var xx = DateTime.Now - start;
//                                DateTime mydate = new DateTime(xx.Ticks);
//                                lblTime.Text = mydate.ToString("HH:mm:ss");
//                                lblIgnored.Text = ignoredCount.ToString();
//                            });
//                            #endregion
//                        }
//                        #endregion
//                    }
//                    else
//                    {
//                        Thread.Sleep(10000);
//                    }
//                }

//                #region Lưu queue và visited còn lại vào db
//                try
//                {
//                    if (dtQueueBulkCopy.Rows.Count > 0)
//                    {
//                        SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionStringCrawler);
//                        sqlConn.Open();
//                        var bulkCopyQueue = new SqlBulkCopy(sqlConn);
//                        bulkCopyQueue.DestinationTableName = "QueueLinks";
//                        bulkCopyQueue.WriteToServer(dtQueueBulkCopy);
//                        if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
//                        dtQueueBulkCopy.Rows.Clear();
//                    }
//                    if (dtVisitedBulkCopy.Rows.Count > 0)
//                    {
//                        SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionStringCrawler);
//                        sqlConn.Open();
//                        var bulkCopyVisited = new SqlBulkCopy(sqlConn);
//                        bulkCopyVisited.DestinationTableName = "VisitedLinks";
//                        bulkCopyVisited.WriteToServer(dtVisitedBulkCopy);
//                        if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
//                        dtVisitedBulkCopy.Rows.Clear();
//                    }
//                }
//                catch (Exception)
//                {
//                }
//                #endregion

//                #region kết thúc và giải phóng bộ nhớ
//                company.UpdateAfterCrawler(true);
//                dtQueueBulkCopy.Rows.Clear();
//                dtQueueBulkCopy.Dispose();
//                dtVisitedBulkCopy.Rows.Clear();
//                dtVisitedBulkCopy.Dispose();
//                finish = true;
//                this.Invoke(
//                    (MethodInvoker)delegate
//                    {
//                        stickQueueCrawler = 21600; // 30*60 phút sau chạy lại
//                        timerQueue.Start();
//                        this.laStatus.Text = "Crawler Queue finish wating";
//                        this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
//                        if (IsClose) { this.Close(); }
//                    });

//                crawlerLink.Clear();
//                crawlerLink = null;
//                _dtClassification.Clear();
//                _dtClassification.Dispose();
//                lisIDClassification.Clear(); lisIDClassification = null;
//                _listIDPrice.Clear(); _listIDPrice = null;
//                visitedCRC.Clear(); visitedCRC = null;
//                adtVisited.Dispose();
//                adtQueue.Dispose();
//                queueLinkCrawlerCRC = null;
//                if (crawlerThread != null)
//                {
//                    if (crawlerThread.IsAlive)
//                    {
//                        crawlerThread.Abort();
//                        crawlerThread.Join();
//                        crawlerThread = null;
//                    }
//                }
//                #endregion
//            }
//            catch (ThreadAbortException threadException)
//            {
//                stickFullCrawler = 60;
//                return;
//            }
//            catch (Exception ex)
//            {
//                stickFullCrawler = 60;
//                string strLog = string.Format("\nException code:{0}", ex.Message);
//                log.ErrorFormat(strLog);
//                txtResult.AppendText(strLog);
//                return;
//            }
//        }

//        void doCrawlerTimWebMoiQueue()
//        {
//            #region Khởi tạo biến
//            lisIDClassification = new List<long>();
//            queueLinkCrawlerCRC = new List<long>();
//            visitedCount = 0;
//            config = new Configuration(_idCongTy, true);
//            crawlerRegex = config.VisitUrlsRegex;
//            detailLinkRegex = config.ProductUrlsRegex;
//            noCrawlerRegex = config.NoVisitUrlRegex;
//            P_Show = new List<string>();
//            CountProducts = 0;
//            crawlerLink = new Queue<string>();
//            visitedCRC = new List<long>();
//            rootUri = new Uri(rootUrl);
//            #endregion

//            crawlerLink.Enqueue(rootUrl);

//            #region Nạp dữ liệu toàn bộ Domain vào Dictionary
//            _listIDDomain = new List<long>();
//            DB.CompanyDataTable dtCom = new DB.CompanyDataTable();
//            DBTableAdapters.CompanyTableAdapter adtCom = new DBTableAdapters.CompanyTableAdapter();
//            if (adtCom.Connection.State == ConnectionState.Closed) adtCom.Connection.Open();

//            try
//            {
//                if (adtCom.Connection.State == ConnectionState.Closed) adtCom.Connection.Open();
//                adtCom.Fill(dtCom);
//                adtCom.Connection.Close();

//            }
//            catch (Exception )
//            {
//            }

//            foreach (DB.CompanyRow dr in dtCom)
//            {
//                int index = _listIDDomain.BinarySearch(dr.ID);
//                if (index < 0)
//                {
//                    _listIDDomain.Insert(~index, dr.ID);
//                }
//            }
//            dtCom.Dispose();
//            adtCom.Dispose();
//            #endregion

//            #region Load link đã visited đưa vào visitedCRC
//            DBQueue.VisitedLinksDataTable dtVisited = new DBQueue.VisitedLinksDataTable();
//            DBQueueTableAdapters.VisitedLinksTableAdapter adtVisited = new DBQueueTableAdapters.VisitedLinksTableAdapter();
//            adtVisited.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;
//            try
//            {
//                if (adtVisited.Connection.State == ConnectionState.Closed) adtVisited.Connection.Open();
//                adtVisited.FillBy_Company(dtVisited, _idCongTy);
//                adtVisited.Connection.Close();
//                foreach (DBQueue.VisitedLinksRow dr in dtVisited)
//                {
//                    int index = visitedCRC.BinarySearch(dr.CRC);
//                    if (index < 0)
//                    {
//                        visitedCRC.Insert(~index, dr.CRC);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {

//                throw ex;
//            }


//            dtVisited.Rows.Clear();
//            dtVisited.Dispose();
//            #endregion

          

//            #region Load queue đã lưu lại trong db
//            DBQueue.QueueLinksDataTable dtQueue = new DBQueue.QueueLinksDataTable();
//            DBQueueTableAdapters.QueueLinksTableAdapter adtQueue = new DBQueueTableAdapters.QueueLinksTableAdapter();
//            adtQueue.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;
//            try
//            {
//                if (adtQueue.Connection.State == ConnectionState.Closed) adtQueue.Connection.Open();
//                adtQueue.FillBy_Company(dtQueue, _idCongTy);
//                adtQueue.Connection.Close();

//                foreach (DBQueue.QueueLinksRow dr in dtQueue)
//                {
//                    int index = queueLinkCrawlerCRC.BinarySearch(dr.CRC);
//                    if (index < 0)
//                    {
//                        crawlerLink.Enqueue(dr.URL.Trim());
//                        queueLinkCrawlerCRC.Insert(~index, dr.CRC);
//                    }
//                }
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//            dtQueue.Rows.Clear();
//            dtQueue.Dispose();
//            #endregion


//            DBQueue.QueueLinksDataTable dtQueueBulkCopy = new DBQueue.QueueLinksDataTable();
//            DBQueue.VisitedLinksDataTable dtVisitedBulkCopy = new DBQueue.VisitedLinksDataTable();
//            /// tổng giá trị khi insert
//            int CountInsert = 50;
//            /// index insert
//            int indexPositionQueue = 1;
//            int indexPositionLinkVisited = 1;

//            #region Load toàn bộ link trang chủ đưa lại vào queue
//            string htmlroot = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(rootUrl, 45, 2);
//            if (htmlroot != "")
//            {

//                #region nạp trang chủ
//                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
//                doc.LoadHtml(htmlroot);
//                var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");
//                if (a_nodes != null)
//                {
//                    #region add link to process and insert to db
//                    for (int i = 0; i < a_nodes.Count; i++)
//                    {
//                        string s = Common.GetAbsoluteUrl(a_nodes[i].Attributes["href"].Value, rootUri);
//                        string url = LinkCanonicalization.NormalizeLink(s);
//                        if (url.Length < 512)
//                        {
//                            long s_crc = Tools.getCRC64(url.Trim());
//                            // kiểm tra link này có được sử lý không
//                            // nếu có kiểm tra link này đã có trong queue chưa
//                            // nếu chưa có kiểm tra trong visited
//                            // nếu chưa có đưa vào queue sử lý
//                            if (!IsNoVisitUrl(s))
//                            {
//                                if (IsRelevantUrl(s))
//                                {
//                                    int indexQueue = queueLinkCrawlerCRC.BinarySearch(s_crc);
//                                    if (indexQueue < 0)
//                                    {
//                                        int indexVisited = -1;// visitedCRC.BinarySearch(s_crc);
//                                        if (indexVisited < 0)
//                                        {
//                                            crawlerLink.Enqueue(url);
//                                            queueLinkCrawlerCRC.Insert(~indexQueue, s_crc);

//                                            dtQueueBulkCopy.Rows.Add(-indexPositionQueue, s_crc, _idCongTy, url);
//                                            indexPositionQueue++;
//                                            #region show log
//                                            this.Invoke((MethodInvoker)delegate
//                                            {
//                                                lblVisited.Text = visitedCount.ToString();
//                                                lblQueue.Text = crawlerLink.Count.ToString();
//                                                //lblProduct.Text = Products.Count.ToString();
//                                                lblProduct.Text = CountProducts.ToString();
//                                                txtUrlCurrent.Text = "nap trang chu " + i.ToString() + currentUrl;
//                                                var xx = DateTime.Now - start;
//                                                DateTime mydate = new DateTime(xx.Ticks);
//                                                lblTime.Text = mydate.ToString("HH:mm:ss");
//                                                lblIgnored.Text = ignoredCount.ToString();
//                                            });
//                                            #endregion
//                                        }
//                                    }
//                                }
//                            }
//                        }
//                    }
//                    #endregion
//                }
//                #endregion
//                #region Nạp trang cấp 1
//                DBQueue.QueueLinksDataTable dt0 = new DBQueue.QueueLinksDataTable();
//                dt0.Merge(dtQueueBulkCopy);
//                int k = 0;
//                foreach (DBQueue.QueueLinksRow dr in dt0)
//                {
//                    k++;
//                    if (crawlerLink.Count + k > 500)
//                    {
//                        break;
//                    }
//                    string html1 = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(dr.URL, 45, 2);
//                    doc.LoadHtml(html1);
//                    var a1_nodes = doc.DocumentNode.SelectNodes("//a[@href]");
//                    if (a1_nodes != null)
//                    {
//                        #region add link to process and insert to db
//                        for (int i = 0; i < a1_nodes.Count; i++)
//                        {

//                            string s = Common.GetAbsoluteUrl(a1_nodes[i].Attributes["href"].Value, rootUri);
//                            string url = LinkCanonicalization.NormalizeLink(s);
//                            if (url.Length < 512)
//                            {
//                                long s_crc = Tools.getCRC64(url.Trim());
//                                // kiểm tra link này có được sử lý không
//                                // nếu có kiểm tra link này đã có trong queue chưa
//                                // nếu chưa có kiểm tra trong visited
//                                // nếu chưa có đưa vào queue sử lý
//                                if (!IsNoVisitUrl(s))
//                                {
//                                    if (IsRelevantUrl(s))
//                                    {
//                                        int indexQueue = queueLinkCrawlerCRC.BinarySearch(s_crc);
//                                        if (indexQueue < 0)
//                                        {
//                                            int indexVisited = visitedCRC.BinarySearch(s_crc);
//                                            if (indexVisited < 0)
//                                            {
//                                                crawlerLink.Enqueue(url);
//                                                queueLinkCrawlerCRC.Insert(~indexQueue, s_crc);
//                                                dtQueueBulkCopy.Rows.Add(-indexPositionQueue, s_crc, _idCongTy, url);
//                                                //if (dtQueueBulkCopy.Rows.Count > 1000)
//                                                //    break;
//                                                indexPositionQueue++;
//                                            }
//                                        }
//                                    }
//                                }
//                                #region show log
//                                this.Invoke((MethodInvoker)delegate
//                                {
//                                    lblVisited.Text = visitedCount.ToString();
//                                    lblQueue.Text = crawlerLink.Count.ToString();
//                                    //lblProduct.Text = Products.Count.ToString();
//                                    lblProduct.Text = CountProducts.ToString();
//                                    txtUrlCurrent.Text = string.Format("nap trang chủ thứ {0}: ", k) + i.ToString() + currentUrl;
//                                    var xx = DateTime.Now - start;
//                                    DateTime mydate = new DateTime(xx.Ticks);
//                                    lblTime.Text = mydate.ToString("HH:mm:ss");
//                                    lblIgnored.Text = ignoredCount.ToString();
//                                });
//                                #endregion
//                            }
//                        }
//                        #endregion
//                    }
//                    Thread.Sleep(config.TimeDelay);
//                    #region show log
//                    this.Invoke((MethodInvoker)delegate
//                    {
//                        lblVisited.Text = visitedCount.ToString();
//                        lblQueue.Text = crawlerLink.Count.ToString();
//                        //lblProduct.Text = Products.Count.ToString();
//                        lblProduct.Text = CountProducts.ToString();
//                        txtUrlCurrent.Text = currentUrl;
//                        var xx = DateTime.Now - start;
//                        DateTime mydate = new DateTime(xx.Ticks);
//                        lblTime.Text = mydate.ToString("HH:mm:ss");
//                        lblIgnored.Text = ignoredCount.ToString();
//                    });
//                    #endregion
//                }
//                #endregion
//            }
//            #endregion
//            while (crawlerLink.Count > 0)
//            {
//                if (finish) { break; }
//                if (!pause)
//                {
//                    #region Pause
//                    string c_url = crawlerLink.Dequeue();

//                    if (IsNoVisitUrl(currentUrl))
//                    {
//                        #region  xoa blacklink trong queue
//                        try
//                        {
//                            Thread.Sleep(100);
//                            long s_crcNoCrawler = Tools.getCRC64(LinkCanonicalization.NormalizeLink(c_url));
//                            if (adtQueue.Connection.State == ConnectionState.Closed) adtQueue.Connection.Open();
//                            adtQueue.DeleteQuery_By_CRC(s_crcNoCrawler);
//                            adtQueue.Connection.Close();
//                        }
//                        catch (Exception)
//                        {
//                            throw;
//                        }
//                        #endregion
//                    }
//                    else
//                    {
//                        /// kiem tra link nay da visit thi xoa di
//                        long s_crcDelete = Tools.getCRC64(LinkCanonicalization.NormalizeLink(c_url));
//                        int indexDelelte = visitedCRC.BinarySearch(s_crcDelete);
//                        if (indexDelelte > 0)
//                        {
//                            //delete
//                            try
//                            {
//                                Thread.Sleep(100);
//                                if (adtQueue.Connection.State == ConnectionState.Closed) adtQueue.Connection.Open();
//                                adtQueue.DeleteQuery_By_CRC(s_crcDelete);
//                                adtQueue.Connection.Close();
//                            }
//                            catch (Exception)
//                            {
//                                throw;
//                            }
//                        }
//                        else
//                        {
//                            try
//                            {
//                                if (indexDelelte < 0)
//                                    visitedCRC.Insert(~indexDelelte, s_crcDelete);
//                                // insert vào visited db
//                                dtVisitedBulkCopy.Rows.Add(-indexPositionLinkVisited, s_crcDelete, _idCongTy);
//                                indexPositionLinkVisited++;

//                                #region  Phân tích link lấy ra từ queue
//                                string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(c_url, 45, 2);
//                                if (html != "")
//                                {
//                                    html = html.Replace("<form", "<div");
//                                    html = html.Replace("</form", "</div");
//                                    GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
//                                    if (config.UseClearHtml)
//                                    {
//                                        html = Common.TidyCleanR(html);
//                                    }
//                                    doc.LoadHtml(html);
//                                    var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");
//                                    if (a_nodes != null)
//                                    {
//                                        #region add link to process and insert to db
//                                        for (int i = 0; i < a_nodes.Count; i++)
//                                        {
//                                            string s = Common.GetAbsoluteUrl(a_nodes[i].Attributes["href"].Value, rootUri);
//                                            string url = LinkCanonicalization.NormalizeLink(s);
//                                            if (url.Length < 512)
//                                            {
//                                                long s_crc = Tools.getCRC64(url.Trim());
//                                                // kiểm tra link này có được sử lý không
//                                                // nếu có kiểm tra link này đã có trong queue chưa
//                                                // nếu chưa có kiểm tra trong visited
//                                                // nếu chưa có đưa vào queue sử lý
//                                                if (!IsNoVisitUrl(s))
//                                                {
//                                                    if (IsRelevantUrl(s))
//                                                    {
//                                                        int indexQueue = queueLinkCrawlerCRC.BinarySearch(s_crc);
//                                                        if (indexQueue < 0)
//                                                        {
//                                                            int indexVisited = visitedCRC.BinarySearch(s_crc);
//                                                            if (indexVisited < 0)
//                                                            {
//                                                                crawlerLink.Enqueue(url);
//                                                                queueLinkCrawlerCRC.Insert(~indexQueue, s_crc);
//                                                                dtQueueBulkCopy.Rows.Add(-indexPositionQueue, s_crc, _idCongTy, url);
//                                                                indexPositionQueue++;
//                                                            }
//                                                        }
//                                                    }
//                                                }
//                                            }
//                                        }
//                                        #endregion

//                                        #region Inser db crawler
//                                        //var x = CreateChecksumeRows(crawlerLinks);

//                                        try
//                                        {
//                                            if (dtQueueBulkCopy.Rows.Count >= CountInsert)
//                                            {
//                                                SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionStringCrawler);
//                                                sqlConn.Open();
//                                                var bulkCopyQueue = new SqlBulkCopy(sqlConn);
//                                                bulkCopyQueue.DestinationTableName = "QueueLinks";
//                                                bulkCopyQueue.WriteToServer(dtQueueBulkCopy);
//                                                if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
//                                                dtQueueBulkCopy.Rows.Clear();
//                                                dtQueueBulkCopy = new DBQueue.QueueLinksDataTable();
//                                                indexPositionQueue = 1;
//                                            }
//                                            if (dtVisitedBulkCopy.Rows.Count >= CountInsert)
//                                            {
//                                                SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionStringCrawler);
//                                                sqlConn.Open();
//                                                var bulkCopyVisited = new SqlBulkCopy(sqlConn);
//                                                bulkCopyVisited.DestinationTableName = "VisitedLinks";
//                                                bulkCopyVisited.WriteToServer(dtVisitedBulkCopy);
//                                                if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
//                                                dtVisitedBulkCopy.Rows.Clear();
//                                                dtVisitedBulkCopy = new DBQueue.VisitedLinksDataTable();
//                                                indexPositionLinkVisited = 1;
//                                            }
//                                        }
//                                        catch (Exception)
//                                        {

//                                        }
//                                        #endregion
//                                    }

//                                    if (IsDetailUrl(c_url))
//                                    {
//                                        if (company.Status == Common.CompanyStatus.WEB_CRAWLERDOMAIN)
//                                        {
//                                            QT.Entities.CrawlerDomain cd = new CrawlerDomain();
//                                            List<QT.Entities.Company> lsc = cd.Analytics(doc, config, c_url);
//                                            CountProducts++;
//                                            ShowDomain(lsc);
//                                            //InsertNews(p);
//                                        }
//                                    }
//                                }
//                                visitedCount++;
//                                currentUrl = c_url;
//                                #endregion

//                                #region xóa link đã được sử lý trong queue db
//                                try
//                                {
//                                    if (adtQueue.Connection.State == ConnectionState.Closed) adtQueue.Connection.Open();
//                                    adtQueue.DeleteQuery_By_CRC(s_crcDelete);
//                                    adtQueue.Connection.Close();
//                                }
//                                catch (Exception)
//                                {
//                                }
//                                #endregion
//                                Thread.Sleep(config.TimeDelay);
//                            }
//                            catch (Exception ex)
//                            {
//                                FileLog.WriteAppendText(DateTime.Now.ToString("dd/MM HH:mm:ss") + "\t, " + c_url + "\r\n" + ex.ToString(), rootUri.Host + ".csv");
//                            }
//                        }
//                    }
//                    if (showLog)
//                    {
//                        #region show log
//                        this.Invoke((MethodInvoker)delegate
//                        {
//                            lblVisited.Text = visitedCount.ToString();
//                            lblQueue.Text = crawlerLink.Count.ToString();
//                            //lblProduct.Text = Products.Count.ToString();
//                            lblProduct.Text = CountProducts.ToString();
//                            txtUrlCurrent.Text = currentUrl;
//                            var xx = DateTime.Now - start;
//                            DateTime mydate = new DateTime(xx.Ticks);
//                            lblTime.Text = mydate.ToString("HH:mm:ss");
//                            lblIgnored.Text = ignoredCount.ToString();
//                        });
//                        #endregion
//                    }
//                    #endregion
//                }
//                else
//                {
//                    Thread.Sleep(10000);
//                }
//            }

//            #region Lưu queue và visited còn lại vào db
//            try
//            {
//                if (dtQueueBulkCopy.Rows.Count > 0)
//                {
//                    SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionStringCrawler);
//                    sqlConn.Open();
//                    var bulkCopyQueue = new SqlBulkCopy(sqlConn);
//                    bulkCopyQueue.DestinationTableName = "QueueLinks";
//                    bulkCopyQueue.WriteToServer(dtQueueBulkCopy);
//                    if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
//                    dtQueueBulkCopy.Rows.Clear();
//                }
//                if (dtVisitedBulkCopy.Rows.Count > 0)
//                {
//                    SqlConnection sqlConn = new SqlConnection(QT.Entities.Server.ConnectionStringCrawler);
//                    sqlConn.Open();
//                    var bulkCopyVisited = new SqlBulkCopy(sqlConn);
//                    bulkCopyVisited.DestinationTableName = "VisitedLinks";
//                    bulkCopyVisited.WriteToServer(dtVisitedBulkCopy);
//                    if (sqlConn.State != ConnectionState.Closed) sqlConn.Close();
//                    dtVisitedBulkCopy.Rows.Clear();
//                }
//            }
//            catch (Exception)
//            {
//            }
//            #endregion

//            #region kết thúc và giải phóng bộ nhớ

//            dtQueueBulkCopy.Rows.Clear();
//            dtQueueBulkCopy.Dispose();
//            dtVisitedBulkCopy.Rows.Clear();
//            dtVisitedBulkCopy.Dispose();
//            finish = true;
//            this.Invoke(
//                (MethodInvoker)delegate
//                {
//                    stickQueueCrawler = 21600; // 6 tiếng sau chạy lại
//                    timerQueue.Start();
//                    this.laStatus.Text = "Crawler Queue finish wating";
//                    this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
//                    if (IsClose) { this.Close(); }
//                });
//            //company.UpdateAfterCrawler(true);
//            crawlerLink.Clear();
//            crawlerLink = null;
//            _dtClassification.Clear();
//            _dtClassification.Dispose();
//            visitedCRC.Clear(); visitedCRC = null;
//            adtVisited.Dispose();
//            adtQueue.Dispose();
//            queueLinkCrawlerCRC = null;
//            if (crawlerThread != null)
//            {
//                if (crawlerThread.IsAlive)
//                {
//                    crawlerThread.Abort();
//                    crawlerThread.Join();
//                    crawlerThread = null;
//                }
//            }
//            #endregion

//        }




//        /// <summary>
//        /// Không tải được dữ liệu update tăng [DownloadError] lên 1
//        /// </summary>
//        void doCrawlerQuetSPCu()
//        {
//            try
//            {
//                #region Khởi tạo biến
//                lisIDClassification = new List<long>();
//                visitedCount = 0;
//                config = new Configuration(_idCongTy, true);
//                crawlerRegex = config.VisitUrlsRegex;
//                detailLinkRegex = config.ProductUrlsRegex;
//                noCrawlerRegex = config.NoVisitUrlRegex;
//                P_Show = new List<string>();
//                CountProducts = 0;
//                crawlerLink = new Queue<string>();
//                visitedCRC = new List<long>();
//                rootUri = new Uri(rootUrl);
//                #endregion

//                #region Nạp dữ liệu chuyên mục cũ web
//                _adtClass.FillBy_CompanyID(_dtClassification, _idCongTy);
//                int i0 = 0;
//                foreach (var dr in _dtClassification)
//                {
//                    i0 = lisIDClassification.BinarySearch(dr.ID);
//                    if (i0 < 0) lisIDClassification.Insert(~i0, dr.ID);
//                }
//                #endregion

//                #region Nạp dữ liệu toàn bộ sản phẩm đã crawler vào Dictionary
//                _listIDPrice = new Dictionary<long, int>();
//                NameCRC = new List<long>();
//                DB.ProductDataTable dtpd = new DB.ProductDataTable();
//                _adtProduct.FillBy_ID_Price_HashName_By_Company(dtpd, _idCongTy);

//                int i1 = 0;
//                foreach (DB.ProductRow dr in dtpd)
//                {
//                    _listIDPrice.Add(dr.ID, dr.Price);
//                    i1 = NameCRC.BinarySearch(dr.HashName);
//                    if (i1 < 0) NameCRC.Insert(~i1, dr.HashName);
//                }
//                dtpd.Clear();
//                dtpd.Dispose();
//                #endregion

//                #region Load dữ liệu cũ đưa vào crawerLink để tải lại
//                DBCrawler.ProductQueueDataTable dtProductOld = new DBCrawler.ProductQueueDataTable();
//                DBCrawlerTableAdapters.ProductQueueTableAdapter adtProductOld = new DBCrawlerTableAdapters.ProductQueueTableAdapter();
//                adtProductOld.Connection.ConnectionString = Server.ConnectionString;

//                // nạp lại top 1000 sản phẩm chưa được quét trong vòng 24h
//                adtProductOld.FillBy_CompanyID_LastUpdate(dtProductOld, _idCongTy, DateTime.Now.AddHours(-3));

//                for (int i = 0; i < dtProductOld.Rows.Count; i++)
//                {
//                    string c_url = dtProductOld.Rows[i]["DetailUrl"].ToString().Trim();
//                    crawlerLink.Enqueue(c_url);

//                    string s = Common.GetAbsoluteUrl(c_url, rootUri);
//                    long s_crc = Tools.getCRC64(LinkCanonicalization.NormalizeLink(s));
//                    visitedCRC.Insert(~-1, s_crc);
//                }
//                dtProductOld.Clear();
//                dtProductOld.Dispose();
//                adtProductOld.Dispose();
//                #endregion

//                while (crawlerLink.Count > 0)
//                {
//                    if (finish) { break; }
//                    if (!pause)
//                    {
//                        #region Pause
//                        string c_url = crawlerLink.Dequeue();
//                        try
//                        {
//                            string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(c_url, 120, 2);
//                            if (html != "")
//                            {
//                                html = html.Replace("<form", "<div");
//                                html = html.Replace("</form", "</div");
//                                GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
//                                if (config.UseClearHtml)
//                                {
//                                    html = Common.TidyCleanR(html);
//                                }
//                                doc.LoadHtml(html);

//                                #region analytic product
//                                QT.Entities.Product p = new Product();
//                                p.Analytics(doc, c_url, config, false, company.Domain);
//                                if (p != null)
//                                {
//                                    if ((p.Price > 0) && (p.Name.Trim().Length > 0))
//                                    {
//                                        CountProducts++;
//                                        ShowProduct(p);
//                                        UpdateProduct(p);
//                                    }
//                                    else
//                                    {
//                                        //delete
//                                        // khi tên hoặc giá=0 update sản phẩm thành not valid
//                                        if (chkAutoDelete.Checked == false)
//                                        {
//                                            UpdateProductNotValid(p.ID);
//                                            ignoredCount++;
//                                            if (ignoredCount >= 10)
//                                            {
//                                                pause = true;
//                                                //ignoredCount = 0;
//                                                this.Invoke((MethodInvoker)delegate
//                                                {
//                                                    laStatus.Text = "Kiểm tra dữ liệu đang xóa";
//                                                });
//                                            }
//                                        }
//                                        else
//                                        {
//                                            DeleteProduct(p.ID);
//                                            this.Invoke((MethodInvoker)delegate
//                                            {
//                                                txtResult.Text = "delete link \n " + c_url;
//                                            });

//                                        }
//                                    }
//                                }
//                                else
//                                {
//                                    //delete
//                                    ignoredCount++;
//                                    UpdateProductNotValid(p.ID);
//                                    //DeleteProduct(p.ID);
//                                }
//                                #endregion

//                            }
//                            else
//                            {
//                                if (chkAutoDelete.Checked == true)
//                                {
//                                    DeleteProduct(Common.GetIDProduct(c_url));
//                                    this.Invoke((MethodInvoker)delegate
//                                    {
//                                        txtResult.Text = "delete link \n " + c_url;
//                                    });
//                                }
//                                else
//                                {
//                                    this.Invoke((MethodInvoker)delegate
//                                    {
//                                        txtResult.Text = "Không tải được dữ liệu, chờ 5 phút sau tải tiếp \n " + c_url;
//                                    });
//                                    Thread.Sleep(300000);

//                                }


//                                // không tải được nội dung trang web do website bị die
//                                ignoredCount++;
//                                UpdateProductNotValid(Common.GetIDProduct(c_url));
//                                //DeleteProduct(Common.GetIDProduct(c_url));
//                                if (ignoredCount > 10)
//                                {
//                                    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
//                                }
//                            }
//                            if (showLog)
//                            {
//                                #region show log
//                                this.Invoke((MethodInvoker)delegate
//                                {
//                                    lblVisited.Text = visitedCount.ToString();
//                                    lblQueue.Text = crawlerLink.Count.ToString();
//                                    lblProduct.Text = CountProducts.ToString();
//                                    txtUrlCurrent.Text = currentUrl;
//                                    var xx = DateTime.Now - start;
//                                    DateTime mydate = new DateTime(xx.Ticks);
//                                    lblTime.Text = mydate.ToString("HH:mm:ss");
//                                    lblIgnored.Text = ignoredCount.ToString();
//                                });
//                                #endregion
//                            }
//                            visitedCount++;
//                            currentUrl = c_url;
//                            Thread.Sleep(config.TimeDelay);
//                        }
//                        catch (Exception ex)
//                        {
//                            FileLog.WriteAppendText(DateTime.Now.ToString("dd/MM HH:mm:ss") + "\t, " + c_url + "\r\n" + ex.ToString(), rootUri.Host + ".csv");
//                        }
//                        #endregion
//                    }
//                    else
//                    {
//                        Thread.Sleep(10000);
//                    }
//                }

//                #region kết thúc và giải phóng bộ nhớ
//                finish = true;
//                this.Invoke(
//                    (MethodInvoker)delegate
//                    {
//                        stickReCrawler = 10;  // 6 phút sau chạy lại
//                        timerReCrawlerHistory.Start();
//                        this.laStatus.Text = "Crawler History Product finish waiting";
//                        this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
//                        if (IsClose) { this.Close(); }
//                    });
//                crawlerLink.Clear();
//                crawlerLink = null;
//                _dtClassification.Clear();
//                _dtClassification.Dispose();
//                lisIDClassification.Clear(); lisIDClassification = null;
//                _listIDPrice.Clear(); _listIDPrice = null;
//                visitedCRC.Clear(); visitedCRC = null;
                
//                if (crawlerThread != null)
//                {
//                    if (crawlerThread.IsAlive)
//                    {
//                        crawlerThread.Abort();
//                        crawlerThread.Join();
//                        crawlerThread = null;
//                    }
//                }
//                #endregion
//            }
//            catch (ThreadAbortException exThread)
//            {
//                stickReCrawler = 60;
//                return;

//            }
//            catch (Exception ex)
//            {
//                this.Invoke(new Action(() =>
//                {
//                    string strData = string.Format("\n Exception in code:{0}", ex.Message);
//                    log.ErrorFormat(strData);
//                    this.txtResult.AppendText(strData);
//                    this.stickReCrawler = 10 * 60; //10 phút sau quay lại.
//                }));
//            }
//        }


       

//        private void frmCrawlerProduct_Load(object sender, EventArgs e)
//        {
//        }

//        private void frmCrawlerProduct_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            finish = true;
//            if (crawlerThread != null)
//            {
//                if (crawlerThread.IsAlive)
//                {
//                    crawlerThread.Abort();
//                    crawlerThread.Join();
//                    crawlerThread = null;
//                }
//            }
//        }

//        private void frmCrawlerProduct_Shown(object sender, EventArgs e)
//        {
//            this.configurationTableAdapter.FillBy_CompanyID(dB.Configuration, _idCongTy);
//            this.ctrLogMananger1.loadCompany(_idCongTy);
//        }


//        public override bool Save()
//        {
//            Wait.CreateWaitDialog();
//            try
//            {
//                Wait.Show("Save");
//                this.configurationBindingSource.EndEdit();
//                this.configurationTableAdapter.Update(dB.Configuration);
//                config = new Configuration(_idCongTy,true);
//                this.ctrLogMananger1.Save();
//            }
//            catch (Exception)
//            {
//                MessageBox.Show("Bạn phải nhaapjv ");
//                return false;
//            }
//            Wait.Close();
//            return true;
//        }
//        public override bool Log()
//        {
//            this.chkLog.Checked = !this.chkLog.Checked;
//            return showLog;
//        }
//        private void timeDelayTextBox_KeyDown(object sender, KeyEventArgs e)
//        {

//        }

//        private void itemReCrawlerTextBox_KeyDown(object sender, KeyEventArgs e)
//        {

//        }

//        private void hoursReCrawlerTextBox_KeyDown(object sender, KeyEventArgs e)
//        {
//        }

//        private void dayReFullCrawlerTextBox_KeyDown(object sender, KeyEventArgs e)
//        {

//        }

//        private void timerRecrawler_Tick(object sender, EventArgs e)
//        {
//            stickReCrawler++;
//            this.laStickNormal.Text = stickReCrawler.ToString();
//            this.laStickFull.Text = stickFullCrawler.ToString();
//            if (stickReCrawler >= config.HoursReCrawler)
//            {
//                isFullCrawler = false;
//                Start();
//            }
//        }

//        private void timerFullCrawler_Tick(object sender, EventArgs e)
//        {
//            stickFullCrawler++;
//            this.laStickNormal.Text = stickReCrawler.ToString();
//            this.laStickFull.Text = stickFullCrawler.ToString();
//            if (stickFullCrawler >= config.DayReFullCrawler)
//            {
//                isFullCrawler = true;
//                Start();
//            }
//        }
//        private void timerReCrawlerHistory_Tick(object sender, EventArgs e)
//        {
//            stickReCrawler--;
//            this.laStickNormal.Text = stickReCrawler.ToString();
//            this.laStickFull.Text = stickFullCrawler.ToString();
//            if (stickReCrawler <= 0)
//            {
//                Start();
//            }
//        }

//        private void chkLog_CheckedChanged(object sender, EventArgs e)
//        {
//            showLog = this.chkLog.Checked;
//        }

//        private void timerQueue_Tick(object sender, EventArgs e)
//        {
//            stickQueueCrawler--;
//            this.laStickNormal.Text = stickQueueCrawler.ToString();
//            this.laStickFull.Text = stickFullCrawler.ToString();
//            if (stickQueueCrawler <= 0)
//            {
//                Start();
//            }
//        }


//    }
//}

// //public bool StartDownloadImageVatGia()
// //       {
// //           this.WindowState = System.Windows.Forms.FormWindowState.Normal;
// //           this.EnabledStart = false;
// //           this.EnabledStop = true;
// //           this.EnabledPause = true;
// //           this.EnabledRestart = false;
// //           rootUrl = company.Website;
// //           this.configurationBindingSource.EndEdit();
// //           this.configurationTableAdapter.Update(dB.Configuration);
// //           config = new Configuration(_idCongTy);
// //           try
// //           {
// //               rootUri = new Uri(rootUrl);
// //               pause = false;
// //               finish = false;
// //               start = DateTime.Now;
// //               visitedCount = 0;
// //               currentUrl = "";

// //               this.laStatus.Text += "DownloadImageVatGia";
// //               crawlerThread = new Thread(new ThreadStart(doCrawlerImageVatGia));


// //               crawlerThread.Start();
// //           }
// //           catch (Exception)
// //           {
// //           }
// //           return true;
// //       }


// //void doCrawlerImageVatGia()
// //       {
// //           #region Khởi tạo biến
// //           lisIDClassification = new List<long>();
// //           visitedCount = 0;
// //           config = new Configuration(_idCongTy);
// //           crawlerRegex = config.VisitUrlsRegex;
// //           detailLinkRegex = config.ProductUrlsRegex;
// //           noCrawlerRegex = config.NoVisitUrlRegex;
// //           P_Show = new List<string>();
// //           CountProducts = 0;
// //           crawlerLink = new Queue<string>();
// //           visitedCRC = new List<long>();
// //           rootUri = new Uri(rootUrl);
// //           #endregion

// //           #region Nạp dữ liệu chuyên mục cũ web vào
// //           try
// //           {
// //               if (_adtClass.Connection.State == ConnectionState.Closed) _adtClass.Connection.Open();
// //               _adtClass.FillBy_CompanyID(_dtClass, _idCongTy);
// //               _adtClass.Connection.Close();
// //           }
// //           catch (Exception)
// //           {
// //               throw;
// //           }
// //           int i0 = 0;
// //           foreach (var dr in _dtClass)
// //           {
// //               i0 = lisIDClassification.BinarySearch(dr.ID);
// //               if (i0 < 0)
// //                   lisIDClassification.Insert(~i0, dr.ID);
// //           }
// //           #endregion

// //           #region Nạp dữ liệu toàn bộ sản phẩm đã crawler vào Dictionary
// //           _listIDPrice = new Dictionary<long, int>();
// //           NameCRC = new List<long>();
// //           DB.ProductDataTable dtpd = new DB.ProductDataTable();

// //           if (_adtProduct.Connection.State == ConnectionState.Closed) _adtProduct.Connection.Open();
// //           _adtProduct.FillBy_ID_Price_HashName_By_Company(dtpd, _idCongTy);
// //           _adtProduct.Connection.Close();

// //           int i1 = 0;
// //           foreach (DB.ProductRow dr in dtpd)
// //           {
// //               _listIDPrice.Add(dr.ID, dr.Price);
// //               i1 = NameCRC.BinarySearch(dr.HashName);
// //               if (i1 < 0)
// //                   NameCRC.Insert(~i1, dr.HashName);
// //           }
// //           dtpd.Clear();
// //           dtpd.Dispose();
// //           #endregion

// //           #region Load dữ liệu cũ đưa vào crawerLink để tải lại
// //           DBCrawler.ProductQueueDataTable dtProductOld = new DBCrawler.ProductQueueDataTable();
// //           DBCrawlerTableAdapters.ProductQueueTableAdapter adtProductOld = new DBCrawlerTableAdapters.ProductQueueTableAdapter();
// //           adtProductOld.Connection.ConnectionString = Server.ConnectionString;

// //           //id vat giá
// //           _idCongTy = 135646091696711971;
// //           try
// //           {
// //               if (adtProductOld.Connection.State == ConnectionState.Closed) adtProductOld.Connection.Open();
// //               adtProductOld.FillBy_Company_PromotionNull(dtProductOld, _idCongTy);
// //               adtProductOld.Connection.Close();
// //           }
// //           catch (Exception ex)
// //           {
// //               MessageBox.Show(ex.ToString());
// //               this.Close();
// //           }
// //           for (int i = 0; i < dtProductOld.Rows.Count; i++)
// //           {
// //               string c_url = dtProductOld.Rows[i]["DetailUrl"].ToString().Trim();
// //               crawlerLink.Enqueue(c_url);

// //               //string s = Common.GetAbsoluteUrl(c_url, rootUri);
// //               //long s_crc = Tools.getCRC64(LinkCanonicalization.NormalizeLink(s));
// //               //visitedCRC.Insert(~-1, s_crc);
// //           }
// //           dtProductOld.Clear();
// //           dtProductOld.Dispose();
// //           adtProductOld.Dispose();
// //           #endregion

// //           while (crawlerLink.Count > 0)
// //           {
// //               if (finish) { break; }
// //               if (!pause)
// //               {
// //                   #region Pause
// //                   string c_url = crawlerLink.Dequeue();
// //                   long idold = Common.GetIDProduct(c_url);
// //                   c_url = c_url.Replace("thong_so_ky_thuat", "hinh_anh");
// //                   try
// //                   {
// //                       string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(c_url, 45, 2);
// //                       if (html != "")
// //                       {
// //                           html = html.Replace("<form", "<div");
// //                           html = html.Replace("</form", "</div");
// //                           GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
// //                           if (config.UseClearHtml)
// //                           {
// //                               html = Common.TidyCleanR(html);
// //                           }
// //                           doc.LoadHtml(html);

// //                           #region analytic product
// //                           QT.Entities.Product p = new Product();
// //                           p.Analytics(doc, c_url, config, false, company.Domain);
// //                           CountProducts++;
// //                           ShowProduct(p);
// //                           UpdatePromotionSummary(p, idold);
// //                           #endregion

// //                           if (showLog)
// //                           {
// //                               #region show log
// //                               this.Invoke((MethodInvoker)delegate
// //                               {
// //                                   lblVisited.Text = visitedCount.ToString();
// //                                   lblQueue.Text = crawlerLink.Count.ToString();
// //                                   //lblProduct.Text = Products.Count.ToString();
// //                                   lblProduct.Text = CountProducts.ToString();
// //                                   txtUrlCurrent.Text = currentUrl;
// //                                   var xx = DateTime.Now - start;
// //                                   DateTime mydate = new DateTime(xx.Ticks);
// //                                   lblTime.Text = mydate.ToString("HH:mm:ss");
// //                                   lblIgnored.Text = ignoredCount.ToString();
// //                               });
// //                               #endregion
// //                           }
// //                       }
// //                       visitedCount++;
// //                       currentUrl = c_url;
// //                       Thread.Sleep(config.TimeDelay);
// //                   }
// //                   catch (Exception ex)
// //                   {
// //                       FileLog.WriteAppendText(DateTime.Now.ToString("dd/MM HH:mm:ss") + "\t, " + c_url + "\r\n" + ex.ToString(), rootUri.Host + ".csv");
// //                   }
// //                   #endregion
// //               }
// //               else
// //               {
// //                   Thread.Sleep(10000);
// //               }
// //           }
// //           #region kết thúc và giải phóng bộ nhớ
// //           finish = true;
// //           this.Invoke(
// //               (MethodInvoker)delegate
// //               {
// //                   this.laStatus.Text = "Crawler Image vatgia finish";
// //                   this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
// //               });
// //           //company.UpdateAfterCrawler(true);
// //           crawlerLink.Clear();
// //           crawlerLink = null;
// //           _dtClass.Clear();
// //           _dtClass.Dispose();
// //           lisIDClassification.Clear(); lisIDClassification = null;
// //           _listIDPrice.Clear(); _listIDPrice = null;
// //           visitedCRC.Clear(); visitedCRC = null;
// //           if (crawlerThread != null)
// //           {
// //               if (crawlerThread.IsAlive)
// //               {
// //                   crawlerThread.Abort();
// //                   crawlerThread.Join();
// //                   crawlerThread = null;
// //               }
// //           }
// //           #endregion
// //       }


////void doCrawlerTimSPMoi()
////       {
////           #region Khởi tạo biến
////           lisIDClassification = new List<long>();
////           visitedCount = 0;
////           config = new Configuration(_idCongTy);
////           crawlerRegex = config.VisitUrlsRegex;
////           detailLinkRegex = config.ProductUrlsRegex;
////           noCrawlerRegex = config.NoVisitUrlRegex;
////           P_Show = new List<string>();
////           CountProducts = 0;
////           crawlerLink = new Queue<string>();
////           visitedCRC = new List<long>();
////           rootUri = new Uri(rootUrl);
////           #endregion

////           #region Nạp dữ liệu chuyên mục cũ web vào
////           try
////           {
////               _adtClass.FillBy_CompanyID(_dtClass, _idCongTy);
////           }
////           catch (Exception)
////           {
////               throw;
////           }
////           int i0 = 0;
////           foreach (var dr in _dtClass)
////           {
////               i0 = lisIDClassification.BinarySearch(dr.ID);
////               lisIDClassification.Insert(~i0, dr.ID);
////           }
////           #endregion

////           crawlerLink.Enqueue(rootUrl);

////           #region Nạp dữ liệu toàn bộ sản phẩm đã crawler vào Dictionary
////           _listIDPrice = new Dictionary<long, int>();
////           NameCRC = new List<long>();
////           DB.ProductDataTable dtpd = new DB.ProductDataTable();
////           _adtProduct.FillBy_ID_Price_HashName_By_Company(dtpd, _idCongTy);
////           int i1 = 0;
////           foreach (DB.ProductRow dr in dtpd)
////           {
////               _listIDPrice.Add(dr.ID, dr.Price);
////               i1 = NameCRC.BinarySearch(dr.HashName);
////               NameCRC.Insert(~i1, dr.HashName);
////           }
////           dtpd.Clear();
////           dtpd.Dispose();
////           #endregion

////           #region Load dữ liệu cũ đưa vào visitedCRC để chỉ tải sản phẩm mới
////           DBCrawler.ProductQueueDataTable dtProductOld = new DBCrawler.ProductQueueDataTable();
////           DBCrawlerTableAdapters.ProductQueueTableAdapter adtProductOld = new DBCrawlerTableAdapters.ProductQueueTableAdapter();
////           adtProductOld.Connection.ConnectionString = Server.ConnectionString;
////           try
////           {
////               adtProductOld.FillByCompanyID(dtProductOld, _idCongTy);
////           }
////           catch (Exception ex)
////           {
////               MessageBox.Show(ex.ToString());
////               this.Close();
////           }
////           for (int i = 0; i < dtProductOld.Rows.Count; i++)
////           {
////               string c_url = dtProductOld.Rows[i]["DetailUrl"].ToString().Trim();
////               string s = Common.GetAbsoluteUrl(c_url, rootUri);
////               long s_crc = Tools.getCRC64(LinkCanonicalization.NormalizeLink(s));
////               visitedCRC.Insert(~-1, s_crc);
////           }
////           dtProductOld.Clear();
////           dtProductOld.Dispose();
////           adtProductOld.Dispose();
////           #endregion

////           while (crawlerLink.Count > 0)
////           {
////               if (finish) { break; }
////               if (!isFullCrawler)
////               {
////                   if (CountProducts >= config.ItemReCrawler)
////                   {
////                       finish = true;
////                   }
////               }
////               if (!pause)
////               {
////                   #region Pause
////                   string c_url = crawlerLink.Dequeue();
////                   try
////                   {
////                       string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(c_url, 45, 2);
////                       if (html != "")
////                       {
////                           GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
////                           if (config.UseClearHtml)
////                           {
////                               html = Common.TidyCleanR(html);
////                           }
////                           doc.LoadHtml(html);
////                           var a_nodes = doc.DocumentNode.SelectNodes("//a[@href]");
////                           if (a_nodes != null)
////                           {
////                               #region add link to process
////                               for (int i = 0; i < a_nodes.Count; i++)
////                               {
////                                   string s = Common.GetAbsoluteUrl(a_nodes[i].Attributes["href"].Value, rootUri);
////                                   long s_crc = Tools.getCRC64(LinkCanonicalization.NormalizeLink(s));
////                                   int index = visitedCRC.BinarySearch(s_crc);
////                                   if (index < 0)
////                                   {
////                                       if (IsRelevantUrl(s))
////                                           crawlerLink.Enqueue(s);

////                                       visitedCRC.Insert(~index, s_crc);
////                                   }
////                               }
////                               #endregion
////                           }

////                           if (IsDetailUrl(c_url))
////                           {
////                               #region analytic product
////                               QT.Entities.Product p = new Product();
////                               p.Analytics(doc, c_url, config, false, company.Domain);

////                               if (p != null)
////                               {
////                                   if ((p.Price > 0) && (p.Name.Trim().Length > 0))
////                                   {
////                                       //Products.Add(p);
////                                       CountProducts++;
////                                       ShowProduct(p);
////                                       UpdateProduct(p);
////                                   }
////                               }
////                               else
////                               {
////                                   ignoredCount++;
////                               }
////                               #endregion
////                           }
////                           if (showLog)
////                           {
////                               #region show log
////                               this.Invoke((MethodInvoker)delegate
////                               {
////                                   lblVisited.Text = visitedCount.ToString();
////                                   lblQueue.Text = crawlerLink.Count.ToString();
////                                   //lblProduct.Text = Products.Count.ToString();
////                                   lblProduct.Text = CountProducts.ToString();
////                                   txtUrlCurrent.Text = currentUrl;
////                                   var xx = DateTime.Now - start;
////                                   DateTime mydate = new DateTime(xx.Ticks);
////                                   lblTime.Text = mydate.ToString("HH:mm:ss");
////                                   lblIgnored.Text = ignoredCount.ToString();
////                               });
////                               #endregion
////                           }
////                       }
////                       visitedCount++;
////                       currentUrl = c_url;
////                       Thread.Sleep(config.TimeDelay);
////                   }
////                   catch (Exception ex)
////                   {
////                       FileLog.WriteAppendText(DateTime.Now.ToString("dd/MM HH:mm:ss") + "\t, " + c_url + "\r\n" + ex.ToString(), rootUri.Host + ".csv");
////                   }
////                   #endregion
////               }
////               else
////               {
////                   Thread.Sleep(10000);
////               }
////           }
////           #region kết thúc và giải phóng bộ nhớ
////           finish = true;
////           this.Invoke(
////               (MethodInvoker)delegate
////               {
////                   if (isFullCrawler)
////                   {
////                       stickFullCrawler = 0;
////                       timerFullCrawler.Start();
////                       this.laStatus.Text = "Crawler full finish";
////                   }
////                   else
////                   {
////                       stickReCrawler = 0;
////                       timerRecrawler.Start();
////                       this.laStatus.Text = "Crawler normal finish";
////                   }
////                   this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
////               });
////           //company.UpdateAfterCrawler(true);
////           crawlerLink.Clear();
////           crawlerLink = null;
////           _dtClass.Clear();
////           _dtClass.Dispose();
////           lisIDClassification.Clear(); lisIDClassification = null;
////           _listIDPrice.Clear(); _listIDPrice = null;
////           visitedCRC.Clear(); visitedCRC = null;
////           if (crawlerThread != null)
////           {
////               if (crawlerThread.IsAlive)
////               {
////                   crawlerThread.Abort();
////                   crawlerThread.Join();
////                   crawlerThread = null;
////               }
////           }
////           #endregion

////       }