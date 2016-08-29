using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace QT.Entities
{
    public class NGramKeyword
    {


        private static string NormalizeString(string _source)
        {
            if (_source.IsNormalized())
                return _source;
            else
                return _source.Normalize();
        }

        public static string removeHTMLWithLineAndSpace(string source)
        {
            if (source == null) return String.Empty;

            source = System.Text.RegularExpressions.Regex.Replace(source, "<script(.*?)>(.*?)</script>", " ");
            source = System.Text.RegularExpressions.Regex.Replace(source, "<style(.*?)>(.*?)</style>", " ");
            string pattern = @"<[!--\W*?]*?[/]*?\w+.*?>";
            string text = System.Text.RegularExpressions.Regex.Replace(source, pattern, " ");

            return NormalizeString(HttpUtility.HtmlDecode(text)).Trim();
        }


        public static List<string> ExtractKeywordBasic (string input)
        {
            input = NGramKeyword.removeHTMLWithLineAndSpace(input);
            List<string> R = new List<string>();
            string[] _sp = stringSeparate(input);
            for (int k = 0; k < _sp.Length; k++)
            {
                string[] sp = NormalizeStringToExtract(_sp[k]).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                R.AddRange(sp);
            }
            var rx = R.Distinct().ToList();
            return rx;
        }

      

        public static List<string> DoDetect(string input)
        {
            input = NGramKeyword.removeHTMLWithLineAndSpace(input);
            List<string> R = new List<string>();
            string[] _sp = stringSeparate(input);
            for (int k = 0; k < _sp.Length; k++)
            {
                string[] sp = NormalizeStringToExtract(_sp[k]).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string cache = "";
                int c = 0;
                for (int i = 0; i < sp.Length; i++)
                {
                    string cacheTrim = cache.Trim(new char[] { ' ', '.', ',', '…' });
                    if (IsCapital(sp[i]))
                    {
                        cache += sp[i] + " ";
                        c++;
                        if (IsCode(sp[i]))
                            R.Add(sp[i].Trim(new char[] { ' ', '.', ',', '…' }));
                    }
                    else
                    {
                        if (c > 2)
                            R.Add(cacheTrim);
                        else if (ForeignDetect(cache))
                            R.Add(cacheTrim);
                        cache = "";
                        c = 0;
                    }
                    if (i == sp.Length - 1)
                    {
                        if (c > 2)
                            R.Add(cacheTrim);
                        else if (ForeignDetect(cache))
                            R.Add(cacheTrim);
                        cache = "";
                        c = 0;
                    }
                }
            }
            var rx = R.Distinct().ToList();
            rx.Remove("");
            rx.Remove("AloBacsi");

            return rx;
        }

        public static bool ContainStopword(string s)
        {
            if (s.Length > 30)
                return true;
            string[] stw = new string[] { "=", "&", "?", ":", ",", ";", "theo", "ông", "bà", "mỹ", "nga" };
            string _s = s.ToLower();
            for (int i = 0; i < stw.Length; i++)
                if (_s.Contains(stw[i]))
                    return true;
            return false;
        }

        public static bool IsCapital(string s)
        {
            if (s == null)
                return false;
            if (s.Length == 0)
                return false;
            if (!Char.IsUpper(s[0]))
                return false;
            if (ContainStopword(s.Trim(new char[] { ' ', '.', ',', '…' })))
                return false;
            return true;
        }

        public static bool IsCode(string s)
        {
            if (s.Length < 3)
                return false;
            if (s.Length > 7)
                return true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > 128)
                    return false;

                if (Char.IsLower(s[i]) && !Char.IsDigit(s[i]))
                    return false;
            }
            return true;
        }

        public static string[] stringSeparate(string s)
        {
            string[] sentenceSpliter = new string[] { ". ", "\r\n", ":\"", ": ", "? ", "! ", ", ", ":", ";", "“", "”", "\"", "'", "‘", "’", "(", ")", "?", "\t" };

            string[] result = s.Split(sentenceSpliter, StringSplitOptions.RemoveEmptyEntries);
            List<string> _result = new List<string>();
            for (int i = 0; i < result.Length; i++)
            {
                string x = result[i].Trim(new char[] { ' ', '.', '\r', '\n', '\t', '-' });
                if (x != "")
                    _result.Add(x);
            }
            return _result.ToArray();
        }

        public static string NormalizeStringToExtract(string source)
        {
            int L = source.Length;
            StringBuilder sb = new StringBuilder();
            bool ws = false;//Just whitespace
            for (int i = 0; i < L; i++)
            {
                switch (source[i])
                {
                    case ':':
                    case ';':
                    case ',':
                    case '.':
                    case '?':
                    case '!':
                    case '(':
                    case ')':
                    case '/':
                    case '\\':
                    case '\'':
                    case '"':
                    case '”':
                    case '“':
                    case '‘':
                    case '’':
                        sb.Append(' ');
                        break;
                    case ' ':
                        if (!ws)
                            sb.Append(' ');
                        ws = true;
                        break;
                    default:
                        sb.Append(source[i]);
                        ws = false;
                        break;
                }
            }
            return sb.ToString();
        }

        public static bool ForeignDetect(string _s)
        {
            if (_s.Length < 3)
                return false;
            string s = _s.ToLower();
            string[] f = new string[] { "w", "f", "j", "z", "or", "nd", "os", "ob", "ck", "nm", "st", "ar", "rt", "nt",
            "nn", "mm", "bb", "rr", "er"};
            for (int i = 0; i < f.Length; i++)
            {
                if (s.Contains(f[i]))
                    return true;
            }
            return false;
        }
    }
}
