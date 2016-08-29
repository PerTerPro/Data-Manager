
using System;
using System.Collections.Generic;
namespace QT.Moduls.CrawlerReviewFacebook
{
    public class LogFacebookReview
    {
        public String merchantUri { get; set; }
        public String userUri { get;set; }
        public String merchantName{get; set;}
        public String userStatus{get; set;}
        public int userRate{get; set;}
        public List<FacebookSubcomment> subComments{get; set;}

        public long datePost { get; set; }
    }
}
