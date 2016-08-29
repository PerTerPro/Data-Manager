using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GABIZ.Base.HtmlUrl
{
    /// <summary>
    /// Class for link Canonicalization
    /// </summary>
    public class LinkCanonicalization
    {
        /// <summary>
        /// Check blacklinks
        /// </summary>
        /// <param name="link">Input link</param>
        /// <param name="blackLabel">List of black labels</param>
        /// <returns>Is black link or not</returns>
        public static bool isBlackLinkContains(string link, string[] blackLabel)
        {
            int K = blackLabel.Length;
            for (int i = 0; i < K; i++)
            {
                if ((link + "/").ToLower().Contains(blackLabel[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static string NormalizeLink(string url, bool ToLower=true)
        {
            char[] abc = { '?', '/', '#' };
            try
            {
                Uri t = new Uri(url);
                url = t.PathAndQuery;
                while (url.Contains("//"))
                    url = url.Replace("//", "/");
                if (t.Host.StartsWith("www"))
                    url = t.ToString().Substring(0, t.ToString().IndexOf(t.Host)) + t.Host.Substring(t.Host.IndexOf(".") + 1, t.Host.Length - t.Host.IndexOf(".") - 1) + url;
                else
                    url = t.ToString().Substring(0, t.ToString().IndexOf(t.Host)) + t.Host + url;
                //loai bo Fragment trong url
                t = new Uri(url);
                url = t.ToString();
                if (t.Fragment != "")
                    url = url.Substring(0, url.Length - t.Fragment.Length);
                url = url.TrimEnd(abc);

                if (ToLower) url = url.ToLower();
                url = url.Replace("\t", "");// B?  \t (tab) trong site . - htt_p://baovanhoa.vn

                url = RemoveSessionID(url);
            }
            catch (Exception)
            {

            }
            return url;
        }

        public static string RemoveUserInfor(string s)
        {
            Match m;
            do
            {
                m = Regex.Match(s, "^((?:(?:https?)|(?:ftps?))://)(?:[^/]+@)(.*)$");
                if (m.Success)
                    s = m.Groups[1].ToString() + m.Groups[2].ToString();
                else break;
            }
            while (m.Success);

            return s;
        }

        private static string RemoveSessionID(string s)
        {
            return Regex.Replace(s, @"(jsessionid=\w+)", "");
        }

        //public static string RemoveUserInfor(string s)
        //{
        //    Match m;
        //    do
        //    {
        //        m = Regex.Match(s, "^((?:(?:https?)|(?:ftps?))://)(?:[^/]+@)(.*)$");
        //        if (m.Success)
        //            s = m.Groups[1].ToString() + m.Groups[2].ToString();
        //        else break;
        //    }
        //    while (m.Success);

        //    return s;
        //}
    }
}
