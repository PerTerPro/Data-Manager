using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using WSS.QAComment.Core;
using NUnit.Framework;
namespace WSS.QAComment.Core.Tests
{
    [TestFixture()]
    public class NoSqlHtmlTests
    {
        [Test()]
        public void SaveHtmTest()
        {
            //var noSql = NoSqlHtml.Instance();
            //string link = "http://www.lazada.vn/dong-ho-nam-day-thep-wilon-938-den-tang-1-pin-dong-ho-2009802.html";
            //string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(link, 45, 2);
            //noSql.SaveHtm(1, 1, html, link);
            //string str  = noSql.GetHtml(1, 1);
            //HtmlDocument doc = new HtmlDocument();
            //doc.LoadHtml(str);
            //string xpathReview = "//ul[@id='js_reviews_list']//li[@class='ratRev_reviewListRow']";
            //var nodeReviews = doc.DocumentNode.SelectNodes(xpathReview);
            //List<string> lst = new List<string>();
            //DsConfigurationComment.Configuration_CommentRow rowCOnfig = null;
            //using (var db = new DsConfigurationCommentTableAdapters.Configuration_CommentTableAdapter())
            //{
            //    DsConfigurationComment.Configuration_CommentDataTable tbl = new DsConfigurationComment.Configuration_CommentDataTable();
            //    db.FillByCompanyId(tbl, 3502170206813664485);
            //    rowCOnfig = tbl.Rows[0] as DsConfigurationComment.Configuration_CommentRow;
            //}

            //List<Comment> lst = new List<Comment>();
            //foreach (var VARIABLE in nodeReviews)
            //{
            //    Comment cmt = new Comment();
            //    cmt.Author =
            //        VARIABLE.SelectSingleNode(@"./div[@class='ratRev-revAuthor']//span[@itemprop='author']")
            //            .InnerText.Trim();
            //    cmt.Content =
            //        VARIABLE.SelectSingleNode(@"./div[@class='ratRev_revDetails']//span[@class='ratRev_revTitle']")
            //            .InnerHtml.Trim();
            //    cmt.DatePublish =
            //        VARIABLE.SelectSingleNode(
            //            @"./div[@class='ratRev_revDetails']//meta[@itemprop='datePublished']/@content").Attributes["content"].Value;

            //    lst.Add(cmt);
            //}
            //Assert.AreNotEqual(str, "");
        }



        [Test()]
        public void GetHtml()
        {
            var noSql = NoSqlCommentSystem.Instance();
            string str = noSql.GetHtml(9799686953136939, 3502170206813664485);
            Assert.AreNotEqual(str, "");
        }
    }
}
