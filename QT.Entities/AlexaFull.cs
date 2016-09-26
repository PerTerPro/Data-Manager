using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities
{
    public class AlexaFull : Alexa
    {
        public AlexaFull()
            : base()
        {
            BounceRate = "";
            BounceRateChange = "";
            BounceRateChangeTitle = "";
            DailyPageView = "";
            DailyPageViewChange = "";
            DailyPageViewTitle = "";
            DailyTimeOnSite = "";
            DailyTimeOnSiteChange = "";
            DailyTimeOnSiteTitle = "";
        }
        public string BounceRate { get; set; }
        public string BounceRateChange { get; set; }
        public string BounceRateChangeTitle { get; set; }
        public string DailyPageView { get; set; }
        public string DailyPageViewChange { get; set; }
        public string DailyPageViewTitle { get; set; }
        public string DailyTimeOnSite { get; set; }
        public string DailyTimeOnSiteChange { get; set; }
        public string DailyTimeOnSiteTitle { get; set; }
    }
}
