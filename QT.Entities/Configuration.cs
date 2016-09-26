using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QT.Entities
{
    [ProtoBuf.ProtoContract]
    public class Configuration
    {
        private DB.ConfigurationDataTable _dt;
        private DBTableAdapters.ConfigurationTableAdapter _adt;
        public string Domain;
        private long _idCongTy;
        private bool p;
        public int MaxHourFindNew = 7;
        public int MaxLinksFindNew;
        public int NumberThreadCrawler { get; set; }

        public string RegexNoPrice { get; set; }
        public string company_domain { get; set; }
        public Configuration()
        {
            use_selenium_crawler = false;
            Domain = "";
        }
        public Configuration(long idCongTy, string connectionString = "")
        {
            LoadBasicInfo(idCongTy, connectionString);

        }

        private void LoadBasicInfo(long idCongTy, string connectionString = "")
        {
            _dt = new DB.ConfigurationDataTable();
            _adt = new DBTableAdapters.ConfigurationTableAdapter();
            _adt.Connection.ConnectionString = (connectionString == "") ? Server.ConnectionString : connectionString;
            _adt.FillBy_CompanyID(_dt, idCongTy);
            this.VisitUrlsRegex = new List<string>();
            this.ProductUrlsRegex = new List<string>();
            if (_dt.Rows.Count > 0)
            {
                ID = Convert.ToInt32(_dt.Rows[0]["id"]);
                CompanyID = Common.Obj2Int64(_dt.Rows[0]["CompanyID"].ToString());
                VisitUrlsRegex = _dt.Rows[0]["VisitUrlsRegex"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                ProductUrlsRegex = _dt.Rows[0]["ProductUrlsRegex"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                NoVisitUrlRegex = _dt.Rows[0]["BlockXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                ProductNameXPath = _dt.Rows[0]["ProductNameXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                CategoryXPath = _dt.Rows[0]["CategoryXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                PriceXPath = _dt.Rows[0]["PriceXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                OriginPriceXPath = _dt.Rows[0]["OriginPriceXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                DeliveryInfoXPath = _dt.Rows[0]["DeliveryInfoXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                RegexDeliveryInfoXPath = _dt.Rows[0]["RegexDeliveryInfoXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                WarrantyXPath = _dt.Rows[0]["WarrantyXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                StatusXPath = _dt.Rows[0]["StatusXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                ImageXPath = _dt.Rows[0]["ImageXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                ImageGetFromRoot =  Common.Obj2Bool(_dt.Rows[0]["ImageGetFromRoot"].ToString());
                ManufactureXPath = _dt.Rows[0]["ManufactureXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                OriginXPath = _dt.Rows[0]["OriginXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                UseClearHtml = Common.Obj2Bool(_dt.Rows[0]["UseClearHtml"].ToString());
                TimeDelay = Common.Obj2Int(_dt.Rows[0]["TimeDelay"].ToString());
                HoursReCrawler = Common.Obj2Int(_dt.Rows[0]["HoursReCrawler"].ToString());
                ItemReCrawler = Common.Obj2Int(_dt.Rows[0]["ItemReCrawler"].ToString());
                DayReFullCrawler = Common.Obj2Int(_dt.Rows[0]["DayReFullCrawler"].ToString());
                PromotionXPath = _dt.Rows[0]["PromotionXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                SummaryXPath = _dt.Rows[0]["SummaryXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                ContentXPath = _dt.Rows[0]["ContentXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                ContentAnanyticXPath = _dt.Rows[0]["ContentAnanyticXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                AutoDelete = (_dt.Rows[0]["AutoDelete"] == DBNull.Value) || Common.Obj2Bool(_dt.Rows[0]["AutoDelete"].ToString());
                VATInfoXPath = _dt.Rows[0]["VATInfoXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                PromotionInfoXPath = _dt.Rows[0]["PromotionInfoXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                ShortDescriptionXPath = _dt.Rows[0]["ShortDescriptionXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                StartDealXPath = _dt.Rows[0]["StartDealXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                EndDealXPath = _dt.Rows[0]["EndDealXPath"].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                ValidXPath = Common.Obj2String(_dt.Rows[0]["ValidProductXpath"]).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                //ReviewXPath = Common.Obj2String(_dt.Rows[0]["ReviewXPath"]).Split(Common.arSplitToList, StringSplitOptions.RemoveEmptyEntries).ToList();
                RegexNotValid = Common.Obj2String(_dt.Rows[0]["RegexNotValidProduct"]).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                use_selenium_crawler = (_dt.Rows[0]["UseSeleniumCrawler"] != DBNull.Value) && Convert.ToBoolean(_dt.Rows[0]["UseSeleniumCrawler"]);
                RemoveLastItemClassification = (_dt.Rows[0]["RemoveLastItemClassification"] != DBNull.Value) && Convert.ToBoolean(_dt.Rows[0]["RemoveLastItemClassification"]);
                ReloadAllNoValid = (_dt.Rows[0]["ReloadAllNoValid"] == DBNull.Value) || Convert.ToBoolean(_dt.Rows[0]["ReloadAllNoValid"]);
                VATStatus = (_dt.Rows[0]["VATStatus"] == DBNull.Value) ? QT.Entities.Common.VATStatus.UndefinedVAT : Convert.ToInt32(_dt.Rows[0]["VATStatus"]);
                ReloadWhenCrawlerFindNew = (_dt.Rows[0]["ReloadWhenCrawlerFindNew"] != DBNull.Value) && Convert.ToBoolean(_dt.Rows[0]["ReloadWhenCrawlerFindNew"]);
                WaitToNextCrawlerReload = (_dt.Rows[0]["WaitToNextCrawlerReload"] == DBNull.Value) ? 0 : Convert.ToInt32(_dt.Rows[0]["WaitToNextCrawlerReload"]);
                MaxToNoValid = Common.Obj2Int(_dt.Rows[0]["MaxToNoValid"]);
                FixedLinkShow = (_dt.Rows[0]["FixedLinkShow"] != DBNull.Value) && Common.Obj2Bool(_dt.Rows[0]["FixedLinkShow"]);
                LinkTest = (_dt.Rows[0]["LinkTest"] == DBNull.Value) ? "" : Common.Obj2String(_dt.Rows[0]["LinkTest"]);
                AutoFixLinkImage = (_dt.Rows[0]["AutoFixLinkImage"] != DBNull.Value) && Common.Obj2Bool(_dt.Rows[0]["AutoFixLinkImage"]);
                RegexNoPrice = (_dt.Rows[0]["RegexNoPrice"] == DBNull.Value) ? "^$" : Common.Obj2String(_dt.Rows[0]["RegexNoPrice"]);
                RegexPrice = (_dt.Rows[0]["RegexPrice"] == DBNull.Value) ? "" : Common.Obj2String(_dt.Rows[0]["RegexPrice"]);
                DefaultRegexPrice = (_dt.Rows[0]["DefaultRegexPrice"] == DBNull.Value) || Common.Obj2Bool(_dt.Rows[0]["DefaultRegexPrice"]);
                CheckPrice = (_dt.Rows[0]["CheckPrice"] == DBNull.Value) || Common.Obj2Bool(_dt.Rows[0]["CheckPrice"]);
                MinHourReload = Common.CellToInt(_dt.Rows[0], "MinHourReload", 72);
                MinHourFindNew = Common.CellToInt(_dt.Rows[0], "MinHourFindNew", 72);
                NumberThreadCrawler = Common.CellToInt(_dt.Rows[0], "NumberThreadCrawler", 1);
                MaxHourFindNew = Common.CellToInt(_dt.Rows[0], "MaxHourFindNew", 10);
                MaxLinksFindNew = Common.CellToInt(_dt.Rows[0], "MaxLinksFindNew", 10000);
                
                VideoXpath = Common.CellToString(_dt.Rows[0], "VideoXpath", "");
                SpecsXPath = Common.CellToString(_dt.Rows[0], "SpecsXPath", "");
                FullDescXPath = Common.CellToString(_dt.Rows[0], "FullDescXPath", "");
                LimitProductValid = Common.CellToInt(_dt.Rows[0], "LimitProductValid", 0);
                MaxDeep = Common.CellToInt(_dt.Rows[0], "MaxDeep", 20);
                LimitFailToDelProduct = Common.CellToInt(_dt.Rows[0], "LimitFailToDelProduct", 1);
            }
        }

        public int LimitFailToDelProduct { get; set; }

        public int MaxDeep { get; set; }

        public Configuration(long _idCongTy, bool bFullInfo)
        {
            LoadBasicInfo(_idCongTy);
        }



        [ProtoBuf.ProtoMember(26)]
        public List<string> VisitUrlsRegex { get; set; }

        [ProtoBuf.ProtoMember(1)]
        public List<string> ProductUrlsRegex { get; set; }

        [ProtoBuf.ProtoMember(2)]
        public List<string> NoVisitUrlRegex { get; set; }

        [ProtoBuf.ProtoMember(3)]
        public List<string> ProductNameXPath { get; set; }

        [ProtoBuf.ProtoMember(4)]
        public List<string> CategoryXPath { get; set; }

        public int MaxToNoValid { get; set; }


        [ProtoBuf.ProtoMember(5)]
        public List<string> PriceXPath { get; set; }

        [ProtoBuf.ProtoMember(26)]
        public List<string> OriginPriceXPath { get; set; }

        [ProtoBuf.ProtoMember(27)]
        public List<string> DeliveryInfoXPath { get; set; }


        [ProtoBuf.ProtoMember(6)]
        public List<string> WarrantyXPath { get; set; }

        [ProtoBuf.ProtoMember(7)]
        public List<string> StatusXPath { get; set; }

        [ProtoBuf.ProtoMember(8)]
        public List<string> ImageXPath { get; set; }

        [ProtoBuf.ProtoMember(9)]
        public List<string> ManufactureXPath { get; set; }

        [ProtoBuf.ProtoMember(10)]
        public List<string> OriginXPath { get; set; }

        [ProtoBuf.ProtoMember(11)]
        public Boolean UseClearHtml { get; set; }

        [ProtoBuf.ProtoMember(12)]
        public int TimeDelay { get; set; }

        [ProtoBuf.ProtoMember(13)]
        public int HoursReCrawler { get; set; }

        [ProtoBuf.ProtoMember(14)]
        public int ItemReCrawler { get; set; }

        [ProtoBuf.ProtoMember(15)]
        public int DayReFullCrawler { get; set; }

        [ProtoBuf.ProtoMember(16)]
        public List<string> PromotionXPath { get; set; }

        [ProtoBuf.ProtoMember(17)]
        public List<string> SummaryXPath { get; set; }

        public List<string> ValidXPath { get; set; }

        public List<string> RegexNotValid { get; set; }

        [ProtoBuf.ProtoMember(18)]
        public List<string> ContentXPath { get; set; }

        [ProtoBuf.ProtoMember(19)]
        public List<string> ContentAnanyticXPath { get; set; }

        [ProtoBuf.ProtoMember(20)]
        public Boolean AutoDelete { get; set; }

        [ProtoBuf.ProtoMember(21)]
        public Boolean ImageGetFromRoot { get; set; }

        [ProtoBuf.ProtoMember(22)]
        public IEnumerable<string> VATInfoXPath { get; set; }

        [ProtoBuf.ProtoMember(23)]
        public List<string> PromotionInfoXPath { get; set; }

        [ProtoBuf.ProtoMember(24)]
        public long CompanyID { get; set; }

        [ProtoBuf.ProtoMember(25)]
        public int ID { get; set; }

        public List<string> ShortDescriptionXPath { get; set; }

        public List<string> RegexDeliveryInfoXPath { get; set; }

        public List<string> StartDealXPath { get; set; }

        public List<string> EndDealXPath { get; set; }

        public bool RemoveLastItemClassification { get; set; }

        public bool use_selenium_crawler { get; set; }

        public int VATStatus { get; set; }

        public bool ReloadAllNoValid { get; set; }

        public bool ReloadWhenCrawlerFindNew { get; set; }

        public string SpecsXPath { get; set; }
        public string FullDescXPath { get; set; }
        public string VideoXpath { get; set; }
        public int WaitToNextCrawlerReload { get; set; }

        public bool FixedLinkShow { get; set; }

        public string LinkTest { get; set; }
        public string LinkAutoTest { get; set; } 
        public bool AutoFixLinkImage { get; set; }

        public bool DefaultRegexPrice { get; set; }

        public string RegexPrice { get; set; }
        public bool CheckPrice { get; set; }

        public int MinHourReload { get; set; }

        public int MinHourFindNew { get; set; }

        public List<string> ReviewXPath { get; set; }


        public int LimitProductValid { get; set; }
    }
}
