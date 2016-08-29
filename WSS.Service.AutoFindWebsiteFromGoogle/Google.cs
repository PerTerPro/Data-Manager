
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.Service.AutoFindWebsiteFromGoogle
{
    public class Google
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Google));
        FirefoxDriver fireFoxDriver;
        string websiteUrl = "";
        string domain = "";
        public Dictionary<string, string> GetWebsiteFromGoogle(string keyword, int pages, int timeSleep)
        {
            Regex regex = new Regex(ConfigurationManager.AppSettings["regexWebsite"]);
            Dictionary<string, string> dicWebNew = new Dictionary<string, string>();
            try
            {

                for (int i = 0; i < pages; i++)
                {
                    Thread.Sleep(timeSleep);
                    if (fireFoxDriver == null) fireFoxDriver = new FirefoxDriver();
                    string urlSearch = "https://www.google.com.vn/#q=" + System.Web.HttpUtility.UrlEncode(keyword) + "&start=" + (i * 10).ToString();
                    fireFoxDriver.Navigate().GoToUrl(urlSearch);
                    var elements = fireFoxDriver.FindElementsByXPath("//h3[@class='r']/a");
                    foreach (var element in elements)
                    {
                        websiteUrl = element.GetAttribute("href");
                        domain = QT.Entities.Common.GetDomainFromUrl(websiteUrl);
                        if (!string.IsNullOrEmpty(domain) && !dicWebNew.ContainsKey(domain) && regex.IsMatch(domain))
                        {
                            dicWebNew.Add(domain, websiteUrl);
                        }
                    }
                }
                fireFoxDriver.Close();
                fireFoxDriver = null;
            }
            catch (Exception ex01)
            {
                log.Error(ex01);

            }
            return dicWebNew;
        }
    }
}
