using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.RaoVat
{
    public class RaoVatSQLAdapter
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(RaoVatSQLAdapter));


        public bool InserClassification(RaoVatClassification classification)
        {
            try
            {
                this.sqlDb.RunQuery("Insert Into Classification (Id, Name, Website_Id) Values (@Id, @Name, @Website_Id)",
                    CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("Id", classification.id,SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("Name",classification.name,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("Website_id",classification.website_id,SqlDbType.Int)
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private Data.SqlDb sqlDb;
        public RaoVatSQLAdapter(QT.Entities.Data.SqlDb sqlDb)
        {
            this.sqlDb = sqlDb;
        }

        public DataTable GetTblConfigXPath()
        {
            return this.sqlDb.GetTblData(@"select ID, wss_allow_auto_push
                                            , wss_last_push_reload_crawler
                                            , wss_last_push_full_crawler
                                            , Name
                                            , wss_total_product
                                            , RootLink
                                            from Config
                                            ORDER BY wss_allow_auto_push DESC");
        }

        public int GetNewID()
        {
            DataTable tbl = this.sqlDb.GetTblData("SELECT ISNULL(MAX(ConfigXPathID),0)+1 FROM ConfigXPaths", CommandType.Text, null);
            return Convert.ToInt32(tbl.Rows[0][0]);
        }

        public bool InsertConfig(ConfigXPaths config)
        {
            try
            {
                string sql = string.Format(@"INSERT INTO CONFIG 
(
  {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}
, {11}, {12} ,{13},{14}, {15}, {16}, {17}, {18} ,{19}, {20}
, {21}, {22}, {23}, {24}, {25}, @{26}, {27}, {28}, {29}, {30}
, {31}
) 
VALUES 
(
  @{0}, @{1}, @{2}, @{3}, @{4}, @{5}, @{6}, @{7}, @{8}, @{9}, @{10}
, @{11}, @{12} ,@{13},@{14}, @{15}, @{16}, @{17}, @{18} ,@{19}
, @{20}, @{21}, @{22}, @{23}, @{24}, @{25}, @{26}, @{27}, @{28}, @{29}, @{30}
, @{31}
)",
  "ConfigXPathID",
  "WebsiteID", "TimeDelay", "ItemReCrawler", "UseClearHtml", "TimeDelay", "RootLink", "TypeCrawlerData",

 "XPaths01", "XPaths02", "XPaths03", "XPaths04", "XPaths05",
 "XPaths06", "XPaths07", "XPaths08", "XPaths09", "XPaths10",

 "TitleXPaths", "PriceXPaths", "PostDateXPaths", "LastChangeXPaths", "ProvinceXPaths",
 "PhoneSalerXPaths", "QualityXPaths", "AddressXPaths", "ContentXPaths", "AvaiableXPaths"
 );
                this.sqlDb.RunQuery(sql, CommandType.Text, new SqlParameter[]{

                sqlDb.CreateParamteter("ConfigXPathID", config.ID,SqlDbType.Int)
              , sqlDb.CreateParamteter("WebsiteID",config.website_id,SqlDbType.Int)
              , sqlDb.CreateParamteter("TimeDelay",config.TimeDelay,SqlDbType.Int)
              , sqlDb.CreateParamteter("ItemReCrawler",config.ItemReCrawler,SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("UseClearHtml",config.UseClearHtml,SqlDbType.Bit)
              , sqlDb.CreateParamteter("TimeDelay",config.TimeDelay,SqlDbType.Int)
              , sqlDb.CreateParamteter("RootLink",config.RootLink,SqlDbType.Int)
              , sqlDb.CreateParamteter("TypeCrawlerData",(int)config.CategoryID,SqlDbType.Int)

              , sqlDb.CreateParamteter("XPaths01",Common.ConvertToString(config.XPathsString01,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("XPaths02",Common.ConvertToString(config.XPaths02,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("XPaths03",Common.ConvertToString(config.XPaths03,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("XPaths04",Common.ConvertToString(config.XPaths04,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("XPaths05",Common.ConvertToString(config.XPaths05,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("XPaths06",Common.ConvertToString(config.XPaths06,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("XPaths08",Common.ConvertToString(config.XPaths08,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("XPaths09",Common.ConvertToString(config.XPaths09,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("XPaths10",Common.ConvertToString(config.XPaths10,";"),SqlDbType.NVarChar)

              , sqlDb.CreateParamteter("TitleXPaths",Common.ConvertToString(config.TitleXPaths,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("PriceXPaths",Common.ConvertToString(config.PriceXPaths,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("PostDateXPaths",Common.ConvertToString(config.PostDateXPaths,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("LastChangeXPaths",Common.ConvertToString(config.LastChangeXPaths,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("ProvinceXPaths",Common.ConvertToString(config.ProvinceXPaths,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("PhoneSalerXPaths",Common.ConvertToString(config.PhoneSalerXPaths,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("AddressXPaths",Common.ConvertToString(config.AddressXPaths,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("ContentXPaths",Common.ConvertToString(config.ContentXPaths,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("AvaiableXPaths",Common.ConvertToString(config.AvaiableXPaths,";"),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("QualityXPaths",Common.ConvertToString(config.QualityXPaths,";"),SqlDbType.NVarChar)
            });
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                return false;
            }
            return true;
        }

        public ConfigXPaths GetConfigByID(long ConfigXPathID)
        {
            ConfigXPaths result = null;
            DataTable tbl = this.sqlDb.GetTblData(@"SELECT 
	a.*, b.domain AS domain_website, b.id as website_id_1
FROM CONFIG a 
INNER JOIN WebSite b ON a.ID = b.config_Id 
WHERE a.ID = @ID", CommandType.Text,
                new SqlParameter[] { new SqlParameter("ID", ConfigXPathID) });
            if (tbl.Rows.Count > 0)
            {
                result = new ConfigXPaths();
                ParseToConfigXPath(ref result, tbl.Rows[0]);
            }
            return result;
        }

        

        public List<ConfigXPaths> GetListConfig()
        {
            List<ConfigXPaths> lst = new List<ConfigXPaths>();
            ConfigXPaths result = null;
            DataTable tbl = this.sqlDb.GetTblData(@"SELECT 
	a.*, b.domain AS domain_website, b.id as website_id_1
FROM CONFIG a 
INNER JOIN WebSite b ON a.ID = b.config_Id ", CommandType.Text, null);
            if (tbl.Rows.Count > 0)
            {
                foreach (DataRow row in tbl.Rows)
                {
                    result = new ConfigXPaths();
                    ParseToConfigXPath(ref result, row);
                    lst.Add(result);
                }
            }
            return lst;
        }

        private void ParseToConfigXPath(ref ConfigXPaths config, DataRow dataRow)
        {
            config.domain = Common.CellToString(dataRow, "domain_website", "");
            config.TitleXPaths = Common.CellToString(dataRow, "TitleXPaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.PriceXPaths = Common.CellToString(dataRow, "PriceXPaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.PostDateXPaths = Common.CellToString(dataRow, "PostDateXPaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.LastChangeXPaths = Common.CellToString(dataRow, "LastChangeXPaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.ProvinceXPaths = Common.CellToString(dataRow, "ProvinceXPaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.PhoneSalerXPaths = Common.CellToString(dataRow, "PhoneSalerXPaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.AddressXPaths = Common.CellToString(dataRow, "AddressXPaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.ContentXPaths = Common.CellToString(dataRow, "ContentXPaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.AvaiableXPaths = Common.CellToString(dataRow, "AvaiableXPaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.QualityXPaths = Common.CellToString(dataRow, "QualityXPaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.tags_xpaths = Common.CellToString(dataRow, "TagXPaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.WebCategoryXPaths = Common.CellToString(dataRow, "WebCategoryXpaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();

            config.image_regex = Common.CellToString(dataRow, "image_regex", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.noimage_regex = Common.CellToString(dataRow, "noimage_regex", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();

            config.ReloadVisitUrlsRegex = Common.CellToString(dataRow, "ReloadVisitUrlsRegex", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.ReloadNoVisitUrlsRegex = Common.CellToString(dataRow, "ReloadNoVisitUrlsRegex", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.ReloadProductUrlsRegex = Common.CellToString(dataRow, "ReloadProductUrlsRegex", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.ReloadNoProductUrlRegex = Common.CellToString(dataRow, "ReloadNoProductUrlRegex", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.RegexReloadLikeFull = Common.CellToBool(dataRow, "RegexReloadLikeFull", true);

            config.extend_xpaths = Common.CellToString(dataRow, "extend_xpaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();

            config.VisitUrlsRegex = Common.CellToString(dataRow, "VisitUrlsRegex", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.NoVisitUrlRegex = Common.CellToString(dataRow, "NoVisitUrlsRegex", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.ProductUrlsRegex = Common.CellToString(dataRow, "ProductUrlsRegex", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.NoProductUrlRegex = Common.CellToString(dataRow, "NoProductUrlRegex", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.UserNameXPaths = Common.CellToString(dataRow, "UserNameXPaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.NoExtractLinkRegex = Common.CellToString(dataRow, "NoExtractLinkRegex", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.ExtractLinkRegex = Common.CellToString(dataRow, "ExtractLinkRegex", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();

            config.RegexStringToCategory = Common.GetListXPathFromString(Common.CellToString(dataRow, "RegexStringToCategory", ""));

            config.wss_last_push = Common.CellToDateTime(dataRow, "wss_last_push", SqlDb.MinDateDb);
            config.wss_allow_auto_push = Common.CellToBool(dataRow, "wss_allow_auto_push", false);
            config.wss_interval_push = Common.CellToInt(dataRow, "wss_interval_push", 60);

            config.wss_deep_full_crawler = Common.CellToInt(dataRow, "wss_deep_full_crawler", 100000);
            config.wss_deep_reload_crawler = Common.CellToInt(dataRow, "wss_deep_reload_crawler", 100);
            config.wws_last_change_config = Common.CellToDateTime(dataRow, "wws_last_change_config", SqlDb.MinDateDb);

            config.AllowExtractProductLink = Common.CellToBool(dataRow, "AllowExtractProductLink", false);
            config.ID = Common.CellToInt(dataRow, "ID", 0);
            config.TimeDelay = Common.CellToInt(dataRow, "TimeDelay", 0);
            config.ItemReCrawler = Common.CellToInt(dataRow, "ItemReCrawler", 0);
            config.UseClearHtml = Common.CellToBool(dataRow, "UseClearHtml", false);
            config.UrlTest = Common.CellToString(dataRow, "UrlTest", "");
            config.LastFullCrawler = Common.CellToDateTime(dataRow, "LastFullCrawler", new DateTime(1990, 1, 1));
            config.LastReloadCrawler = Common.CellToDateTime(dataRow, "LastReloadCrawler", new DateTime(1990, 1, 1));
            config.NumberProduct = Common.CellToInt(dataRow, "NumberProduct", 0);
            config.NumberVisited = Common.CellToInt(dataRow, "NumberVisited", 0);
            config.TotalTimeRunFull = Common.CellToInt(dataRow, "TotalTimeRunFull", 0);
            config.RootLink = Common.GetListXPathFromString(Common.CellToString(dataRow, "RootLink", ""));
            config.ThumbUrlXPaths = new List<string>() { "//article[1]//img[1]{src}" };
            config.CategoryID = Common.CellToInt(dataRow, "TypeCrawlerData", 0);
            config.ImageUrlsXPaths = Common.CellToString(dataRow, "ImageUrlsXPaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.Name = Common.CellToString(dataRow, "Name", "");
            config.website_id = Common.Obj2Int(dataRow["website_id_1"]);

            config.last_edit_xpaths = Common.CellToString(dataRow, "last_edit_xpaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.last_comment_xpaths = Common.CellToString(dataRow, "last_comment_xpaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
            config.view_count_xpaths = Common.CellToString(dataRow, "view_count_xpaths", "").Split(SqlDb.arSplit, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public bool UpdateConfigXPath(ConfigXPaths config)
        {
            try
            {
                string sqlIn = @"IF NOT EXISTS (SELECT * FROM CONFIG WHERE ID = @ID) BEGIN INSERT INTO CONFIG (ID) VALUES (@ID) END";
                this.sqlDb.RunQuery(sqlIn, CommandType.Text, new SqlParameter[]{
                    new SqlParameter("ID",config.ID)
                });

                string sql = string.Format(@"UPDATE CONFIG SET
  {1}=@{1}, {2}=@{2}, {3}=@{3}, {4}=@{4}, {5}=@{5}, {6}=@{6}, {7}=@{7}
, {8}=@{8}, {9}=@{9}, {10}=@{10}, {11}=@{11}, {12}=@{12} 
, {13}=@{13},{14}=@{14}, {15}=@{15}, {16}=@{16}, {17}=@{17}
, {18}=@{18} ,{19}=@{19}, {20}=@{20}, {21}=@{21}, {22}=@{22}, {23}= @{23}, {24} = @{24}, {25} = @{25}
, {26} = @{26}, {27}=@{27}, {28} = @{28}, {29}= @{29}, {30} = @{30}, {31}=@{31}, {32} = @{32}, {33} = @{33}, {34}=@{34}
, {35}=@{35}, {36} = @{36}, {37} = @{37}, {38}= @{38}, {39} = @{39}, {40} = @{40}, {41}=@{41}, wws_last_change_config = GETDATE(),
{42}=@{42}, {43}=@{43}, {44}=@{44}, {45} = @{45}, {46}=@{46}, {47}=@{47}
WHERE {0} = @{0}",
  "ID",
  "website_id", "ItemReCrawler", "UseClearHtml", "TimeDelay", "RootLink", "TypeCrawlerData",
 "TitleXPaths", "PriceXPaths", "PostDateXPaths", "LastChangeXPaths", "ProvinceXPaths",
 "PhoneSalerXPaths", "QualityXPaths", "AddressXPaths", "ContentXPaths", "AvaiableXPaths"
 , "NoVisitUrlsRegex", "ImageUrlsXPaths", "UserNameXPaths", "UrlTest"
 , "VisitUrlsRegex", "NoProductUrlRegex", "ProductUrlsRegex", "TagXPaths", "WebCategoryXPaths", "NoExtractLinkRegex", "ExtractLinkRegex"
 , "AllowExtractProductLink", "wss_allow_auto_push", "wss_interval_push", "wss_last_push", "wss_deep_reload_crawler"
 , "wss_deep_full_crawler", "RegexStringToCategory"
 , "ReloadNoVisitUrlsRegex", "ReloadVisitUrlsRegex", "ReloadNoProductUrlRegex", "ReloadProductUrlsRegex", "RegexReloadLikeFull", "extend_xpaths"
 , "Name", "last_edit_xpaths", "last_comment_xpaths", "image_regex", "noimage_regex", "domain", "view_count_xpaths");
                this.sqlDb.RunQuery(sql, CommandType.Text, new SqlParameter[]{
                sqlDb.CreateParamteter("ID", config.ID,SqlDbType.Int)
              , sqlDb.CreateParamteter("website_id",config.website_id,SqlDbType.Int)
              , sqlDb.CreateParamteter("ItemReCrawler",config.ItemReCrawler,SqlDbType.Int)

              , sqlDb.CreateParamteter("ReloadNoVisitUrlsRegex",Common.ConvertToString(config.ReloadNoVisitUrlsRegex),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("ReloadVisitUrlsRegex",Common.ConvertToString(config.ReloadVisitUrlsRegex),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("ReloadNoProductUrlRegex",Common.ConvertToString(config.ReloadNoProductUrlRegex),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("ReloadProductUrlsRegex",Common.ConvertToString(config.ReloadProductUrlsRegex),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("RegexReloadLikeFull",config.RegexReloadLikeFull,SqlDbType.NVarChar)

              , sqlDb.CreateParamteter("UseClearHtml",config.UseClearHtml,SqlDbType.Bit)
              , sqlDb.CreateParamteter("TimeDelay",config.TimeDelay,SqlDbType.Int)
              , sqlDb.CreateParamteter("NoExtractLinkRegex",Common.ConvertToString(config.NoExtractLinkRegex),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("ExtractLinkRegex",Common.ConvertToString(config.ExtractLinkRegex),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("AllowExtractProductLink",config.AllowExtractProductLink,SqlDbType.NVarChar)

              ,sqlDb.CreateParamteter("extend_xpaths",Common.ConvertToString(config.extend_xpaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("RootLink",Common.ConvertToString(config.RootLink),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("NoVisitUrlsRegex",Common.ConvertToString(config.NoVisitUrlRegex),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("WebCategoryXpaths",Common.ConvertToString(config.WebCategoryXPaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("VisitUrlsRegex",Common.ConvertToString(config.VisitUrlsRegex),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("NoProductUrlRegex",Common.ConvertToString(config.NoProductUrlRegex),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("ProductUrlsRegex",Common.ConvertToString(config.ProductUrlsRegex),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("TypeCrawlerData",(int)config.CategoryID,SqlDbType.Int)
              , sqlDb.CreateParamteter("UrlTest",config.UrlTest,SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("TitleXPaths",Common.ConvertToString(config.TitleXPaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("PriceXPaths",Common.ConvertToString(config.PriceXPaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("PostDateXPaths",Common.ConvertToString(config.PostDateXPaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("LastChangeXPaths",Common.ConvertToString(config.LastChangeXPaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("ProvinceXPaths",Common.ConvertToString(config.ProvinceXPaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("PhoneSalerXPaths",Common.ConvertToString(config.PhoneSalerXPaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("AddressXPaths",Common.ConvertToString(config.AddressXPaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("ContentXPaths",Common.ConvertToString(config.ContentXPaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("AvaiableXPaths",Common.ConvertToString(config.AvaiableXPaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("QualityXPaths",Common.ConvertToString(config.QualityXPaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("TagXPaths",Common.ConvertToString(config.tags_xpaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("ImageUrlsXPaths",Common.ConvertToString(config.ImageUrlsXPaths),SqlDbType.NVarChar)
              , sqlDb.CreateParamteter("UserNameXPaths",Common.ConvertToString(config.UserNameXPaths),SqlDbType.NVarChar)

            , sqlDb.CreateParamteter("wss_allow_auto_push",config.wss_allow_auto_push,SqlDbType.Bit)
            , sqlDb.CreateParamteter("wss_interval_push",config.wss_interval_push,SqlDbType.Int)
            , sqlDb.CreateParamteter("wss_last_push",config.wss_last_push,SqlDbType.DateTime)
            , sqlDb.CreateParamteter("wss_deep_reload_crawler",config.wss_deep_reload_crawler,SqlDbType.Int)
            , sqlDb.CreateParamteter("wss_deep_full_crawler",config.wss_deep_full_crawler,SqlDbType.Int)
            , sqlDb.CreateParamteter("RegexStringToCategory", Common.ConvertToString( config.RegexStringToCategory),SqlDbType.NVarChar)
            , sqlDb.CreateParamteter("Name",Common.Obj2String(config.Name),SqlDbType.NVarChar)

            , sqlDb.CreateParamteter("last_edit_xpaths",Common.ConvertToString(config.last_edit_xpaths),SqlDbType.NVarChar)
            , sqlDb.CreateParamteter("last_comment_xpaths",Common.ConvertToString(config.last_comment_xpaths),SqlDbType.NVarChar)
             , sqlDb.CreateParamteter("image_regex",Common.ConvertToString(config.image_regex),SqlDbType.NVarChar)
            , sqlDb.CreateParamteter("noimage_regex",Common.ConvertToString(config.noimage_regex),SqlDbType.NVarChar)
            , sqlDb.CreateParamteter("domain", config.domain,SqlDbType.NVarChar)
            , sqlDb.CreateParamteter("view_count_xpaths",Common.ConvertToString(config.view_count_xpaths),SqlDbType.NVarChar)
            });
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool CheckExistConfig(int p)
        {
            DataTable tbl = this.sqlDb.GetTblData("SELECT ConfigXPathID FROM ConfigXPaths WHERE ConfigXPathID = @ConfigXPathID",
                CommandType.Text, new SqlParameter[] { new SqlParameter("ConfigXPathID", p) });
            return tbl.Rows.Count != 0;
        }

        public void UpdateLastPush(int iConfig, int intTypeCrawl)
        {
            if (intTypeCrawl == 0)
            {
                //Full
                this.sqlDb.RunQuery("Update Config SET wss_last_push = getdate(), wss_last_push_full_crawler = getdate(), wss_count_run = isnull(wss_count_run,0)+1 where id = @id", CommandType.Text, new SqlParameter[] { 
                this.sqlDb.CreateParamteter("@id",iConfig,SqlDbType.Int)});
            }
            else
            {
                //Reload
                this.sqlDb.RunQuery("Update Config SET wss_last_push = getdate(), wss_last_push_reload_crawler = getdate(), wss_count_run = isnull(wss_count_run,0)+1 where id = @id", CommandType.Text, new SqlParameter[] { 
                this.sqlDb.CreateParamteter("@id",iConfig,SqlDbType.Int)});
            }
        }

        /// <summary>
        /// Các Config có thể push crawl dữ liệu
        /// </summary>
        /// <returns></returns>
        public DataTable GetTableConfigPush()
        {
            return this.sqlDb.GetTblData(@"select ID, isnull( wss_interval_push, 60) as wss_interval_push  from Config where wss_allow_auto_push = 1", CommandType.Text, null);
        }

        public int GetNumberConsumerRunning(long companyID)
        {
            throw new NotImplementedException();
        }

        public bool CheckRunning(long companyID)
        {
            return Convert.ToInt32(this.sqlDb.GetTblData("DATEDIFF(MINUTE, (SELECT ISNULL(last_job_at, '2000-1-1') as last_job_at From Config WHERE ID = @ID) , GETDATE())",
                CommandType.Text, new SqlParameter[]{
                    sqlDb.CreateParamteter("@ID",companyID,SqlDbType.BigInt)
                })) > 30;
        }

        public List<RegexCheckKeyword> GetListRegexValidLink()
        {
            throw new NotImplementedException();
        }

        public List<RegexCheckKeyword> GetListRegexBlackLink()
        {
            throw new NotImplementedException();
        }

        public DataTable GetTblWebSite()
        {
            return this.sqlDb.GetTblData("select id, domain, base_link from website", CommandType.Text, new SqlParameter[] { });
        }

        public Dictionary<long, RaoVatClassification> GetDicClassification()
        {
            Dictionary<long, RaoVatClassification> lstResult = new Dictionary<long, RaoVatClassification>();
            DataTable tbl = this.sqlDb.GetTblData("Select id, name, website_id, category_ids from classification",
                CommandType.Text, new SqlParameter[]{
                });
            foreach(DataRow row in tbl.Rows)
            {
                lstResult.Add(Convert.ToInt64(row["id"]),
                    new RaoVatClassification()
                    {
                        id=Convert.ToInt64(row["id"]),
                        name=Common.Obj2String(row["name"]),
                        website_id=Common.Obj2Int(row["website_id"]),
                        category_ids=Common.StringToArrayInt(Common.Obj2String(row["category_ids"]))
                    });
            }
            return lstResult;
        }

        public List<int> GetListConfigIDRunCrawling()
        {
            DataTable tbl = this.sqlDb.GetTblData("Select id From Config where wss_allow_auto_push = 1 ", CommandType.Text, new SqlParameter[] { });
            List<int> lst = new List<int>();
            foreach(DataRow item in tbl.Rows)
            {
                lst.Add(Convert.ToInt32(item["id"]));
            }
            return lst;
        }

        public bool CheckExistCity(int CityID)
        {
            return sqlDb.GetTblData("Select Id From RegexCity Where Id = @Id", CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("Id",CityID,SqlDbType.Int)
            }).Rows.Count > 0;
        }

        public void UpdateCity(int CityID, string Name)
        {
            this.sqlDb.RunQuery("Update RegexCity Set Name = @Name Where Id = @Id", CommandType.Text,
                  new SqlParameter[] {
                  SqlDb.CreateParamteterSQL("Id",CityID,SqlDbType.Int),
                  SqlDb.CreateParamteterSQL("Name",Name,SqlDbType.NVarChar)
                  });
        }

        public void InsertCity(int CityID, string Name)
        {
            this.sqlDb.RunQuery("Insert Into RegexCity (Id, Name, Regex) Values (@Id, @Name, '')", CommandType.Text,
             new SqlParameter[] {SqlDb.CreateParamteterSQL("Id",CityID,SqlDbType.Int),
                  SqlDb.CreateParamteterSQL("Name",Name,SqlDbType.NVarChar) });
        }

        public bool CheckExistCategories(int p)
        {
            return sqlDb.GetTblData("Select Id From Categories Where Id = @Id", CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("Id",p,SqlDbType.Int)
            }).Rows.Count > 0;
        }

        public void UpdateCategories(RaoVatCategory raoVatCategory)
        {
            this.sqlDb.RunQuery("update categories set name = @name, slug = @slug, parent_id = @parent_id, path=@path where id = @id",
                CommandType.Text, new SqlParameter[]{
               SqlDb.CreateParamteterSQL("id",raoVatCategory.id,SqlDbType.Int),
               SqlDb.CreateParamteterSQL("name",raoVatCategory.name,SqlDbType.NVarChar),
               SqlDb.CreateParamteterSQL("slug",raoVatCategory.slug,SqlDbType.NVarChar),
               SqlDb.CreateParamteterSQL("level",raoVatCategory.level,SqlDbType.Int),
               SqlDb.CreateParamteterSQL("path",raoVatCategory.path,SqlDbType.NVarChar),
                });
        }

        public void InsertCategory(RaoVatCategory raoVatCategory)
        {
            this.sqlDb.RunQuery(@"Insert Into Categories (id, name, slug, parent_id, level, path)"
                               + "Values (@id, @name, @slug, @parent_id, @level, @path)", CommandType.Text, new SqlParameter[]{
               SqlDb.CreateParamteterSQL("id",raoVatCategory.id,SqlDbType.Int),
               SqlDb.CreateParamteterSQL("name",raoVatCategory.name,SqlDbType.NVarChar),
               SqlDb.CreateParamteterSQL("slug",raoVatCategory.slug,SqlDbType.NVarChar),
               SqlDb.CreateParamteterSQL("level",raoVatCategory.level,SqlDbType.Int),
               SqlDb.CreateParamteterSQL("parent_id",raoVatCategory.level,SqlDbType.Int),
               SqlDb.CreateParamteterSQL("path",raoVatCategory.path,SqlDbType.NVarChar),
            });
        }

        public DataTable GetTableClassification(int website_id)
        {
            return this.sqlDb.GetTblData("select id, name, category_id from classification where website_id = @website_id",
                CommandType.Text, new SqlParameter[]{
                   SqlDb.CreateParamteterSQL("website_id",website_id,SqlDbType.Int)
               });

        }

        public DataTable GetTableCategories()
        {
            return this.sqlDb.GetTblData("select id, name, slug, level from categories",
                CommandType.Text, new SqlParameter[]{
                });
        }

        public void SaveMapClassificationAndCategori(long classification_id, int category_id)
        {
            this.sqlDb.RunQuery("update classification set category_id = @category_id where id = @id", CommandType.Text,
            new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("@category_id",category_id,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@id",classification_id,SqlDbType.BigInt)
                });
        }

        public Dictionary<long, int[]> GetDicMapClassificationAndCategories(int website_id)
        {
            Dictionary<long, int[]> dicData = new Dictionary<long, int[]>();
            DataTable tblDataMap = sqlDb.GetTblData("select a.id, b.path from Classification a inner join categories b on a.category_id = b.id where website_id = @website_id",
                CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("website_id",website_id,SqlDbType.Int)
                });
            foreach (DataRow row in tblDataMap.Rows)
            {
                List<int> lst = new List<int>();
                long classification = Convert.ToInt64(row["id"]);
                string[] arData = Convert.ToString(row["path"]).Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string data in arData)
                {
                    lst.Add(Convert.ToInt32(data));
                }
                dicData.Add(classification, lst.ToArray());
            }
            return dicData;
        }

        public void InsertToNeedAdapter(long product_id, string url_detail, string web_category)
        {
            try
            {
                this.sqlDb.RunQuery("insert ProductNeedCategory (id, url, web_category) values (@id, @url, @web_category)", CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("id",product_id,SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("url",url_detail,SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("web_category",web_category,SqlDbType.NVarChar)
                });
            }
            catch (Exception ex)
            {

            }
        }



        public Dictionary<int, string[]> GetDicCityAndRegex()
        {
            Dictionary<int, string[]> dicCityAndRegex = new Dictionary<int, string[]>();
            DataTable tbl = this.sqlDb.GetTblData("select id, regex, name from  RegexCity", CommandType.Text, new SqlParameter[] { });
            foreach (DataRow row in tbl.Rows)
            {
                List<string> lstRegexForCity = new List<string>();
                int id = Common.Obj2Int(row["id"]);
                string name = Common.Obj2String(row["name"]).ToLower();
                if (name != "")
                {
                    string nameKhongDau = Common.UnicodeToKoDau(name);
                    if (!lstRegexForCity.Contains(nameKhongDau) && nameKhongDau != "") lstRegexForCity.Add(nameKhongDau);

                    string nameKhongDauVaGach = Common.UnicodeToKoDauAndGach(name);
                    if (!lstRegexForCity.Contains(nameKhongDauVaGach) && nameKhongDauVaGach != "") lstRegexForCity.Add(nameKhongDauVaGach);

                    if (!lstRegexForCity.Contains(name) && name != "") lstRegexForCity.Add(name);

                    string regex = Common.Obj2String(row["regex"]).ToLower();
                    if (!lstRegexForCity.Contains(regex) && regex != "") lstRegexForCity.Add(regex);

                    dicCityAndRegex.Add(id, lstRegexForCity.ToArray());
                }
            }
            return dicCityAndRegex;
        }

        public void PushJobReload(long crc, string url, int type, int website_id)
        {
            this.sqlDb.RunQuery(@"IF NOT EXISTS (Select Top 1 * From QueueWait Where CrcUrl = @crcUrl And TypeCrawler = @TypeCrawler) 
                                  Insert Into QueueWait (ConfigID, TypeCrawler, CrcUrl, Url, Deep) 
                                  Values (@ConfigID, @TypeCrawler, @CrcUrl, @Url, @Deep)", System.Data.CommandType.Text,
                new SqlParameter[]{
                SqlDb.CreateParamteterSQL("ConfigID",website_id,System.Data.SqlDbType.Int)
                , SqlDb.CreateParamteterSQL("TypeCrawler",10,System.Data.SqlDbType.Int)
                , SqlDb.CreateParamteterSQL("Url",url,System.Data.SqlDbType.NVarChar)
                , SqlDb.CreateParamteterSQL("Deep",0,System.Data.SqlDbType.Int)
                , SqlDb.CreateParamteterSQL("CrcUrl",crc,System.Data.SqlDbType.BigInt)
                });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="crcKeyword"></param>
        /// <param name="keyword"></param>
        /// <returns>0. Update
        /// 1. Insert
        /// 2. Error</returns>
        public int UpdateKeyword(long crcKeyword, string keyword)
        {
            DataTable tbl = this.sqlDb.GetTblData("VatGiaKeyword_Upsert", CommandType.StoredProcedure, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@id", crcKeyword, SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("@name",keyword,SqlDbType.NVarChar)
            });
            if (tbl == null) return -1;
            else return (Convert.ToInt32(tbl.Rows[0][0]) == 1) ? 1 : 0;
        }



        public DataTable GetTblConfig()
        {
            return this.sqlDb.GetTblData("select id, name from config", CommandType.Text, new SqlParameter[] { });
        }

        public int GetConfigIDByWebsite(int website_id)
        {
            DataTable tbl = this.sqlDb.GetTblData("select config_id from website where id = @website_id", CommandType.Text, new SqlParameter[]{
                new SqlParameter("website_id",website_id)
            });
            return (tbl.Rows.Count == 0) ? 0 : Convert.ToInt32(tbl.Rows[0]["config_id"]);
        }

        public void SaveClassification(int website_id, string classification)
        {
            long ClassificationID = Math.Abs(GABIZ.Base.Tools.getCRC64(classification));
            this.sqlDb.RunQuery(@"If Not exists (select id from Classification Where Id = @ClassificationID) 
                                    begin
                                        insert into Classification (Id, name, website_id) 
                                        values (@ClassificationID, @name, @website_id)
                                    end
                                else 
begin
update Classification set name = @name, website_id = @website_id where id = @ClassificationID
end"
                , CommandType.Text, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("ClassificationID",ClassificationID,SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("name",classification,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("website_id",website_id,SqlDbType.Int)
            });
        }
    }
}
