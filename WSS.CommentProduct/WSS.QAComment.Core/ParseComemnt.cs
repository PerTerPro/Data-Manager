using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;

namespace WSS.QAComment.Core
{
    public class ParseComemnt
    {
        public List<Comment> ParseComment(DsConfigurationComment.Configuration_CommentRow configuration,HtmlDocument doc, JobWaitAS job)
        {List<Comment> lst = new List<Comment>();
            var nodeReviews = doc.DocumentNode.SelectNodes(configuration.CommentListXpath);
            if (nodeReviews != null){foreach (var nodeReview in nodeReviews)
                {
                    Comment cmt = new Comment();

                    cmt.Author = GetTextReview(nodeReview, configuration.AuthorXPath);
                    cmt.Title = GetTextReview(nodeReview, configuration.ContentXPath);
                    cmt.Content = GetTextReview(nodeReview, ".//div[@itemprop='description']");
                    cmt.DatePublish = GetTextReview(nodeReview, configuration.DatePostXPath);
                    cmt.ProductId = job.Id;
                    cmt.CompanyId = job.CompanyId;
                    cmt.Url = job.Url;

                    if (!string.IsNullOrEmpty(cmt.Content))
                    {
                        lst.Add(cmt);
                    }
                }
            }
            return lst;
        }

        public string GetTextReview(HtmlNode doc, string xpath)
        {
            var nodeReview = doc.SelectSingleNode(xpath);
            if (nodeReview != null){
                if (Regex.IsMatch(xpath, @"@[^/'\]\[]+$"))
                {
                    string attribute = Regex.Match(xpath, @"@[^/'\]\[]+$").Captures[0].Value.Trim().Replace("@", "");
                    return nodeReview.Attributes[attribute].Value.ToString();
                }
                else{
                    return nodeReview.InnerText.Trim();
                }
            }
            return "";
        }
    }
}