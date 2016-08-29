using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.RaoVat
{
    [ProtoBuf.ProtoContract]
    public class ConfigXPaths 
    {
        public override string ToString()
        {
            return
                string.Format("ID:{0}, TitleXPaths:{1}", ID, TitleXPaths);
        }

        public int second_sleep_recrawler { get; set; }

        public int number_thread { get; set; }

        public List<string> spe_car_carmaker_xpaths;
        public int wss_max_link_reload_crawler;

        public List<string> image_regex = new List<string>();
        public List<string> noimage_regex = new List<string>();
        public int max_consumer;
        public bool run_same_ip { get; set; }

        public int wss_max_link_full_crawler { get; set; }
        public int wss_deep_full_crawler { get; set; }
        public int wss_deep_reload_crawler { get; set; }
        public DateTime wss_last_push { get; set; }
        public ConfigXPaths()
        {
            UrlTest = "";
            TimeDelay = 0;
            text_special_properties_xpaths = null;
            number_special_properties_xpaths = null;
            extend_xpaths = null;
            wss_interval_push = 60;
            wss_allow_auto_push = false;
            wss_last_push = SqlDb.MinDateDb;
            wss_max_link_full_crawler = 1000000000;
            wss_max_link_reload_crawler = 100000000;
            wws_last_change_config = SqlDb.MinDateDb;
            RegexReloadLikeFull = true;
        }

        /// <summary>
        /// 4. Duyet SP goc
        /// </summary>
        [ProtoBuf.ProtoMember(1)]
        public int ID { get; set; }
        [ProtoBuf.ProtoMember(2)]
        public int website_id { get; set; }

        [ProtoBuf.ProtoMember(10)]
        public List<string> RootLink { get; set; }

        [ProtoBuf.ProtoMember(11)]
        public List<string> VisitUrlsRegex { get; set; }

        [ProtoBuf.ProtoMember(12)]
        public List<string> NoVisitUrlRegex { get; set; }

        [ProtoBuf.ProtoMember(13)]

        public List<string> ProductUrlsRegex { get; set; }
        [ProtoBuf.ProtoMember(14)]
        public int ItemReCrawler { get; set; }

        public int TimeDelay { get; set; }

        public bool UseClearHtml { get; set; }

        public List<string> XPathsString01 { get; set; }

        /// <summary>
        /// PostDate
        /// </summary>
        public List<string> XPaths02 { get; set; }

        public List<string> XPaths03 { get; set; }

        public List<string> XPaths04 { get; set; }

        public List<string> XPaths05 { get; set; }

        public List<string> XPaths06 { get; set; }

        /// <summary>
        /// Vị trí
        /// </summary>
        public List<string> XPaths08 { get; set; }



        public List<string> QualityXPaths { get; set; }

        public List<string> AvaiableXPaths { get; set; }

        public List<string> PhoneSalerXPaths { get; set; }

        public List<string> XPaths10 { get; set; }

        public List<string> ContentXPaths { get; set; }

        public List<string> ProvinceXPaths { get; set; }

        public List<string> TitleXPaths { get; set; }

        public List<string> XPaths09 { get; set; }

        public List<string> AddressXPaths { get; set; }

        public DateTime LastFullCrawler { get; set; }

        public DateTime LastReloadCrawler { get; set; }

        public int NumberProduct { get; set; }

        public int NumberVisited { get; set; }

        public int TotalTimeRunFull { get; set; }

        /// <summary>
        /// Không xác định
        /// </summary>
        public int CategoryID { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        public List<string> XPaths50 { get; set; }

        /// <summary>
        /// Quality
        /// </summary>
        public List<string> XPaths51 { get; set; }
        public List<string> XPaths52 { get; set; }
        public List<string> XPaths53 { get; set; }
        public List<string> XPaths54 { get; set; }
        public List<string> XPaths55 { get; set; }

        public List<string> XPaths21 { get; set; }

        public List<string> XPaths22 { get; set; }

        public List<string> XPaths23 { get; set; }

        public List<string> XPaths24 { get; set; }

        public List<string> XPaths25 { get; set; }

        public List<string> XPaths26 { get; set; }

        public List<string> XPaths27 { get; set; }

        public List<string> XPaths28 { get; set; }

        public List<string> XPaths29 { get; set; }

        public List<string> XPaths30 { get; set; }

        public List<string> NoProductUrlRegex { get; set; }

        public List<string> ImageUrlsXPaths { get; set; }

        public List<string> UserNameXPaths { get; set; }

        public string UrlTest { get; set; }

        public List<string> WebCategoryXPaths { get; set; }

        public List<string> ThumbUrlXPaths { get; set; }

        public SortedDictionary<string, string> text_special_properties_xpaths { get; set; }

        public SortedDictionary<string, string> number_special_properties_xpaths { get; set; }

        public List<string> extend_xpaths { get; set; }

        public List<string> tags_xpaths { get; set; }

        public List<string> NoExtractLinkRegex { get; set; }

        public List<string> ExtractLinkRegex { get; set; }

        public bool AllowExtractProductLink { get; set; }

        public int wss_interval_push { get; set; }

        public bool wss_allow_auto_push { get; set; }

        public List<string> RegexStringToCategory { get; set; }

        public DateTime wws_last_change_config { get; set; }

        public List<string> ReloadVisitUrlsRegex { get; set; }

        public List<string> ReloadNoVisitUrlsRegex { get; set; }

        public List<string> ReloadProductUrlsRegex { get; set; }

        public List<string> ReloadNoProductUrlRegex { get; set; }

        public bool RegexReloadLikeFull { get; set; }

        public List<string> RegexStringToCategorySub { get; set; }

        public string Name { get; set; }

        public List<string> last_comment_xpaths { get; set; }

        public List<string> last_edit_xpaths { get; set; }

        public List<string> PriceXPaths { get; set; }
        public List<string> PostDateXPaths { get; set; }
        public List<string> LastChangeXPaths { get; set; }
        public List<string> CategoryXPaths { get; set; }

        public string domain { get; set; }

        public List<string> view_count_xpaths { get; set; }

        public bool is_find_new { get; set; }

        public bool is_reload { get; set; }
    }
}
