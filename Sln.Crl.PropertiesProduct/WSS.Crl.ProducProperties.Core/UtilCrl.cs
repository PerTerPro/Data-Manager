﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WSS.Crl.ProducProperties.Core
{
    public static class UtilCrl
    {
        public static string GetUrl(string urlDb, string domain)
        {
            urlDb = System.Web.HttpUtility.UrlDecode(urlDb);
            if (domain == "lazada.vn")
            {
                var urlData = urlDb;
                urlData = System.Web.HttpUtility.UrlDecode(urlData);
                if (Regex.IsMatch(urlData, @"(?<=url=)(.*)html"))
                {
                    urlData = System.Web.HttpUtility.UrlDecode(Regex.Match(urlData, @"(?<=url=)(.*)html").Captures[0].Value);
                    return urlData;
                }
                else
                {
                    return urlData;
                }
            }
            else return urlDb;
        }
    }
}
