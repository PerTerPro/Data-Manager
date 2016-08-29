
using System;
using System.Collections.Generic;
namespace QT.Moduls.CrawlerReviewFacebook
{
    public class FacebookSubcomment
    {
        public String status { get; set; }
        public List<String> subSubComments { get; set; }
        public FacebookSubcomment()
        {
            status = "";
            subSubComments = new List<string>();
        }
    }
}