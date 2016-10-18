using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using GABIZ.Base.Cryptography;

namespace GABIZ.Base
{
    public class Tools
    {
        /// <summary>
        /// Converts the given decimal number to the numeral system with the
        /// specified radix (in the range [2, 36]).
        /// </summary>
        /// <param name="decimalNumber">The number to convert.</param>
        /// <param name="radix">The radix of the destination numeral system (in the range [2, 36]).</param>
        /// <returns></returns>
        public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());

            if (decimalNumber == 0)
                return "0";

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / radix;
            }

            string result = new String(charArray, index + 1, BitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result.Substring(6);
        }


        /// <summary>
        /// Remove all vietnamese characters
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>String without Vietnamese char</returns>
        public static string removeVietnamese(string source)
        {
            string sOuput = "";
            int L = source.Length;
            for (int i = 0; i < L; i++)
            {
                char c = Char.ToLower(source[i]);
                char _c = '#';
                switch (c)
                {
                    case 'a': _c = 'a';
                        break;
                    case 'à': _c = 'a';
                        break;
                    case 'á': _c = 'a';
                        break;
                    case 'ả': _c = 'a';
                        break;
                    case 'ã': _c = 'a';
                        break;
                    case 'ạ': _c = 'a';
                        break;
                    case 'ă': _c = 'a';
                        break;
                    case 'ằ': _c = 'a';
                        break;
                    case 'ắ': _c = 'a';
                        break;
                    case 'ẳ': _c = 'a';
                        break;
                    case 'ẵ': _c = 'a';
                        break;
                    case 'ặ': _c = 'a';
                        break;
                    case 'â': _c = 'a';
                        break;
                    case 'ầ': _c = 'a';
                        break;
                    case 'ấ': _c = 'a';
                        break;
                    case 'ẩ': _c = 'a';
                        break;
                    case 'ẫ': _c = 'a';
                        break;
                    case 'ậ': _c = 'a';
                        break;
                    case 'b': _c = 'b';
                        break;
                    case 'c': _c = 'c';
                        break;
                    case 'd': _c = 'd';
                        break;
                    case 'đ': _c = 'd';
                        break;
                    case 'e': _c = 'e';
                        break;
                    case 'è': _c = 'e';
                        break;
                    case 'é': _c = 'e';
                        break;
                    case 'ẻ': _c = 'e';
                        break;
                    case 'ẽ': _c = 'e';
                        break;
                    case 'ẹ': _c = 'e';
                        break;
                    case 'ê': _c = 'e';
                        break;
                    case 'ề': _c = 'e';
                        break;
                    case 'ế': _c = 'e';
                        break;
                    case 'ể': _c = 'e';
                        break;
                    case 'ễ': _c = 'e';
                        break;
                    case 'ệ': _c = 'e';
                        break;

                    case 'f': _c = 'f';
                        break;

                    case 'g': _c = 'g';
                        break;
                    case 'h': _c = 'h';
                        break;

                    case 'i': _c = 'i';
                        break;
                    case 'ì': _c = 'i';
                        break;
                    case 'í': _c = 'i';
                        break;
                    case 'ỉ': _c = 'i';
                        break;
                    case 'ĩ': _c = 'i';
                        break;
                    case 'ị': _c = 'i';
                        break;

                    case 'k': _c = 'k';
                        break;
                    case 'l': _c = 'l';
                        break;
                    case 'm': _c = 'm';
                        break;
                    case 'n': _c = 'n';
                        break;

                    case 'o': _c = 'o';
                        break;
                    case 'ò': _c = 'o';
                        break;
                    case 'ó': _c = 'o';
                        break;
                    case 'ỏ': _c = 'o';
                        break;
                    case 'õ': _c = 'o';
                        break;
                    case 'ọ': _c = 'o';
                        break;

                    case 'ô': _c = 'o';
                        break;
                    case 'ồ': _c = 'o';
                        break;
                    case 'ố': _c = 'o';
                        break;
                    case 'ổ': _c = 'o';
                        break;
                    case 'ỗ': _c = 'o';
                        break;
                    case 'ộ': _c = 'o';
                        break;

                    case 'ơ': _c = 'o';
                        break;
                    case 'ờ': _c = 'o';
                        break;
                    case 'ớ': _c = 'o';
                        break;
                    case 'ở': _c = 'o';
                        break;
                    case 'ỡ': _c = 'o';
                        break;
                    case 'ợ': _c = 'o';
                        break;

                    case 'p': _c = 'p';
                        break;
                    case 'q': _c = 'q';
                        break;
                    case 'r': _c = 'r';
                        break;
                    case 's': _c = 's';
                        break;
                    case 't': _c = 't';
                        break;

                    case 'u': _c = 'u';
                        break;
                    case 'ù': _c = 'u';
                        break;
                    case 'ú': _c = 'u';
                        break;
                    case 'ủ': _c = 'u';
                        break;
                    case 'ũ': _c = 'u';
                        break;
                    case 'ụ': _c = 'u';
                        break;

                    case 'ư': _c = 'u';
                        break;
                    case 'ừ': _c = 'u';
                        break;
                    case 'ứ': _c = 'u';
                        break;
                    case 'ử': _c = 'u';
                        break;
                    case 'ữ': _c = 'u';
                        break;
                    case 'ự': _c = 'u';
                        break;

                    case 'v': _c = 'v';
                        break;
                    case 'w': _c = 'w';
                        break;
                    case 'x': _c = 'x';
                        break;

                    case 'y': _c = 'y';
                        break;
                    case 'ỳ': _c = 'y';
                        break;
                    case 'ý': _c = 'y';
                        break;
                    case 'ỷ': _c = 'y';
                        break;
                    case 'ỹ': _c = 'y';
                        break;
                    case 'ỵ': _c = 'y';
                        break;

                    case 'z': _c = 'z';
                        break;

                    //case '0': _c = '0';
                    //    break;
                    //case '1': _c = '1';
                    //    break;
                    //case '2': _c = '2';
                    //    break;
                    //case '3': _c = '3';
                    //    break;
                    //case '4': _c = '4';
                    //    break;
                    //case '5': _c = '5';
                    //    break;
                    //case '6': _c = '6';
                    //    break;
                    //case '7': _c = '7';
                    //    break;
                    //case '8': _c = '8';
                    //    break;
                    //case '9': _c = '9';
                    //    break;
                }
                if (_c != '#')
                {
                    sOuput += _c;
                }
            }
            return sOuput;
        }

        /// <summary>
        /// Get text segment from url in order to determine title from URL
        /// </summary>
        /// <param name="URL">URL string</param>
        /// <returns>Longest segment and last segment string</returns>
        public static string[] getTitleFromURL(string URL)
        {
            string[] result = new string[2];
            string[] s = removeHTML(URL).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            int max = 0;
            int len = 0;
            for (int i = 2; i < s.Length; i++)
            {
                int l = s[i].Trim().Split('.').First().Length;
                if (l > len)
                {
                    len = l;
                    max = i;
                }
            }
            int x = s.Length - 1;
            int t = 0;
            while (int.TryParse(s[x], out t))
                x--;
            result[0] = s[max].Split('.').First();
            result[1] = s[x].Split('.').First();
            return result;
            //int k = s.Length - 1;
            //while (s[k].Trim() == "" && k > 0)
            //    k--;
            //return removeVietnamese(s[k].Split('.').First());
        }

        /// <summary>
        /// Determine point for a considered title
        /// </summary>
        /// <param name="headerText">Header text</param>
        /// <param name="linkText">Text between a tag</param>
        /// <param name="urlText">URL text</param>
        /// <param name="considerText">Considered text</param>
        /// <param name="point">Point</param>
        /// <returns>Maybe is title or not</returns>
        public static bool titleDefinition(string headerText, string linkText, string urlText, string considerText, out int point)
        {
            point = 0;
            string _considerText = removeVietnamese(considerText);
            int cW = considerText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            if (considerText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length < 2 || _considerText.Length < 3 || considerText.Length > 200) return false;

            if (cW < 4) point -= 1;

            string[] urlPro = getTitleFromURL(urlText);
            string _headerText = removeVietnamese(headerText);
            string _linkText = removeVietnamese(linkText);
            string _urlText = removeVietnamese(urlPro[0]);
            string _urlLast = removeVietnamese(urlPro[1]);

            bool titleContains = _headerText.Contains(_considerText);

            int l = considerText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            if (equalString(_considerText, _headerText, 0.9) || titleContains)
            {
                point += 1;
                if (titleContains)
                {
                    if (l > 8)
                        point += 1;
                }
            }
            string s = _considerText + _considerText;
            if (equalString(s, _headerText, 0.9) || _headerText.Contains(s))
                point += 2;
            if (equalString(_considerText, _linkText, 0.9))
                point += 3;
            if (equalString(_considerText, _urlText, 0.9) || (_urlText.Contains(_considerText) && considerText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length > 3))
                point += 2;
            if (equalString(_considerText, _urlLast, 0.9))
                point += 1;
            if (point >= 2)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Determine point for a considered title
        /// </summary>
        /// <param name="headerText">Header text</param>
        /// <param name="linkText">Text between a tag</param>
        /// <param name="urlText">URL text</param>
        /// <param name="considerText">Considered text</param>
        /// <param name="nodeName">Node name</param>
        /// <param name="hasTitleAttr">Node has title attributes or not</param>
        /// <param name="point">Point</param>
        /// <returns>Maybe is title or not</returns>
        public static bool titleDefinition(string headerText, string linkText, string urlText, string considerText, string nodeName, bool hasTitleAttr, out int point)
        {
            point = 0;
            string _considerText = removeVietnamese(considerText);
            int cW = considerText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            if (cW < 2 || _considerText.Length < 3 || considerText.Length > 200) return false;

            if (cW < 3) point -= (3 - cW);

            string[] urlPro = getTitleFromURL(urlText);
            string _headerText = removeVietnamese(headerText);
            string _linkText = removeVietnamese(linkText);
            string _urlText = removeVietnamese(urlPro[0]);
            string _urlLast = removeVietnamese(urlPro[1]);

            bool notCat = (urlPro[0] != urlPro[1]);

            string[] headerSeg = headerText.Split(new char[] { '-', '|', '»' });
            int K = headerSeg.Length;

            string _firstHeader = "";
            int max = 0;
            int len = 0;
            for (int i = 0; i < K; i++)
            {
                if (len < headerSeg[i].Length)
                {
                    len = headerSeg[i].Length;
                    max = i;
                }
            }

            _firstHeader = removeVietnamese(headerSeg[max]);

            bool titleContains = _headerText.Contains(_considerText);

            int l = considerText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            if (equalString(_considerText, _headerText, 0.9) || titleContains)
            {
                point += 1;
                if (titleContains)
                {
                    if (l > 8)
                        point += 2;
                    if (_considerText == _firstHeader && _firstHeader != _headerText)
                        point += 2;
                }
            }

            string s = _considerText + _considerText;
            if (equalString(s, _headerText, 0.9) || _headerText.Contains(s))
            {
                if (cW > 3)
                    point += 3;
                else
                    point += 2;
            }
            if (equalString(_considerText, _linkText, 0.9))
                point += 3;
            if (equalString(_considerText, _urlText, 0.9) || (_urlText.Contains(_considerText) && considerText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length > 3))
                point += 2;
            if (equalString(_considerText, _urlLast, 0.9))
                point += 1;
            if (nodeName.ToLower() == "h1")
                point += 1;
            if (hasTitleAttr)
                point += 1;
            if (_considerText.Length < _urlText.Length / 2.0 && point > 5)
                point = 3;

            if (considerText.ToUpper() == considerText)
            {
                point -= 2;
                if (cW < 4)
                    point -= 2;
            }

            if (point >= 2)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Give fuzzy membership between two string
        /// </summary>
        /// <param name="s1">String 1</param>
        /// <param name="s2">String 2</param>
        /// <param name="threshold">Threshold</param>
        /// <returns></returns>
        public static bool equalString(string s1, string s2, double threshold)
        {
            int levenshteinDistance = AdvSearching.FuzzySearch.LevenshteinDistance(s1, s2);

            // Length of the longer string:
            int length = Math.Max(s1.Length, s2.Length);

            // Calculate the score:
            double score = 1.0 - (double)levenshteinDistance / length;
            if (score >= threshold)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Give fuzzy membership between two string
        /// </summary>
        /// <param name="s1">String 1</param>
        /// <param name="s2">String 2</param>
        /// <param name="threshold">Threshold</param>
        /// <returns></returns>
        public static bool equalString(string s1, string s2, double threshold, out double mf)
        {
            int levenshteinDistance = AdvSearching.FuzzySearch.LevenshteinDistance(s1, s2);

            // Length of the longer string:
            int length = Math.Max(s1.Length, s2.Length);

            // Calculate the score:
            double score = 1.0 - (double)levenshteinDistance / length;
            mf = score;
            if (score >= threshold)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Compute similar measurement betweent two string
        /// </summary>
        /// <param name="s1">The first string</param>
        /// <param name="s2">The second string</param>
        /// <returns>Similar measurement</returns>
        public static double Similar(string s1, string s2)
        {
            int levenshteinDistance = AdvSearching.FuzzySearch.LevenshteinDistance(s1, s2);

            // Length of the longer string:
            int length = Math.Max(s1.Length, s2.Length);

            return 1.0 - (double)levenshteinDistance / length;
        }

        private static double giveTitlePoint(int countWord)
        {
            int x = countWord - 10;
            return Math.Exp((-0.5 * x * x) / 20);
        }

        public static int determineTitle(string s1)
        {
            int c1 = s1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int n1 = (int)(10 * giveTitlePoint(c1));

            string _s1 = s1.Trim();
            if (_s1 != "")
            {
                if (!Char.IsLetterOrDigit(_s1[0]))
                    n1--;
                if (_s1.Last() == ':')
                    n1 -= 5;
                if (isCapital(_s1))
                    n1 -= 5;

                if (_s1.Contains(','))
                    n1 -= 2;

                if (_s1.Contains(':'))
                    n1 -= 2;

                if (_s1.Contains('/'))
                    n1 -= 2;

                if (_s1.Contains("  "))
                    n1 -= 2;
            }

            return Math.Max(0, n1);
        }

        public static bool isCapital(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLower(s[i]))
                    return false;
            }
            return true;
        }

        public static string determineTitle(string s1, string s2)
        {
            int c1 = s1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int c2 = s2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int n1 = (int)(10 * giveTitlePoint(c1));
            int n2 = (int)(10 * giveTitlePoint(c2));

            string _s1 = s1.Trim();
            string _s2 = s2.Trim();
            if (_s1 != "")
                if (!Char.IsLetterOrDigit(_s1[0]))
                    n1--;
            if (_s2 != "")
                if (!Char.IsLetterOrDigit(_s2[0]))
                    n2--;

            if (n1 > n2)
                return s1;
            else if (n1 < n2)
                return s2;
            else
            {
                int u = Math.Min(c1, c2);
                if (u <= 11)
                {
                    if (c1 > c2) return s1;
                    else return s2;
                }
                else
                {
                    if (c1 > c2) return s2;
                    else return s1;
                }
            }
        }

        /// <summary>
        /// Method for execute innormal string (a string containt mark sign)
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>Normalized string</returns>
        public static string NormalizeString(string _source)
        {
            if (_source.IsNormalized())
                return _source;
            else
                return _source.Normalize();
        }

        /// <summary>
        /// Method for execute innormal string (a string containt mark sign)
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>Normalized string</returns>
        public static string NormalizeStringOld(string _source)
        {
            string source = _source + " ";
            int n = source.Length;
            string SS = "";
            bool special = false;
            for (int i = 0; i < n; i++)
            {
                int c = (int)source[i];
                if ((c == 768) || (c == 769) || (c == 777) || (c == 771) || (c == 803)) //If string contain special char
                {
                    special = true;
                    break;
                }
            }
            if (special)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    int k = (int)source[i + 1];
                    switch (k)
                    {
                        case 768:
                            switch (source[i])
                            {
                                case 'a': SS += "à";
                                    break;
                                case 'ă': SS += "ằ";
                                    break;
                                case 'â': SS += "â";
                                    break;
                                case 'e': SS += "è";
                                    break;
                                case 'ê': SS += "ề";
                                    break;
                                case 'i': SS += "ì";
                                    break;
                                case 'o': SS += "ò";
                                    break;
                                case 'ô': SS += "ồ";
                                    break;
                                case 'ơ': SS += "ờ";
                                    break;
                                case 'u': SS += "ù";
                                    break;
                                case 'ư': SS += "ừ";
                                    break;
                                case 'y': SS += "ỳ";
                                    break;
                                case 'A': SS += "À";
                                    break;
                                case 'Ă': SS += "Ằ";
                                    break;
                                case 'Â': SS += "Ầ";
                                    break;
                                case 'E': SS += "È";
                                    break;
                                case 'Ê': SS += "Ề";
                                    break;
                                case 'I': SS += "Ì";
                                    break;
                                case 'O': SS += "Ò";
                                    break;
                                case 'Ô': SS += "Ồ";
                                    break;
                                case 'Ơ': SS += "Ờ";
                                    break;
                                case 'U': SS += "Ù";
                                    break;
                                case 'Ư': SS += "Ừ";
                                    break;
                                case 'Y': SS += "Ỳ";
                                    break;
                            }
                            i++;
                            break;
                        case 769:
                            switch (source[i])
                            {
                                case 'a': SS += "á";
                                    break;
                                case 'ă': SS += "ắ";
                                    break;
                                case 'â': SS += "ấ";
                                    break;
                                case 'e': SS += "é";
                                    break;
                                case 'ê': SS += "ế";
                                    break;
                                case 'i': SS += "í";
                                    break;
                                case 'o': SS += "ó";
                                    break;
                                case 'ô': SS += "ố";
                                    break;
                                case 'ơ': SS += "ớ";
                                    break;
                                case 'u': SS += "ú";
                                    break;
                                case 'ư': SS += "ứ";
                                    break;
                                case 'y': SS += "ý";
                                    break;
                                case 'A': SS += "Á";
                                    break;
                                case 'Ă': SS += "Ắ";
                                    break;
                                case 'Â': SS += "Ấ";
                                    break;
                                case 'E': SS += "É";
                                    break;
                                case 'Ê': SS += "Ế";
                                    break;
                                case 'I': SS += "Í";
                                    break;
                                case 'O': SS += "Ó";
                                    break;
                                case 'Ô': SS += "Ố";
                                    break;
                                case 'Ơ': SS += "Ớ";
                                    break;
                                case 'U': SS += "Ú";
                                    break;
                                case 'Ư': SS += "Ứ";
                                    break;
                                case 'Y': SS += "Ý";
                                    break;
                            }
                            i++;
                            break;
                        case 777:
                            switch (source[i])
                            {
                                case 'a': SS += "ả";
                                    break;
                                case 'ă': SS += "ẳ";
                                    break;
                                case 'â': SS += "ẩ";
                                    break;
                                case 'e': SS += "ẻ";
                                    break;
                                case 'ê': SS += "ể";
                                    break;
                                case 'i': SS += "ỉ";
                                    break;
                                case 'o': SS += "ỏ";
                                    break;
                                case 'ô': SS += "ổ";
                                    break;
                                case 'ơ': SS += "ở";
                                    break;
                                case 'u': SS += "ủ";
                                    break;
                                case 'ư': SS += "ử";
                                    break;
                                case 'y': SS += "ỷ";
                                    break;
                                case 'A': SS += "Ả";
                                    break;
                                case 'Ă': SS += "Ẳ";
                                    break;
                                case 'Â': SS += "Ẩ";
                                    break;
                                case 'E': SS += "Ẻ";
                                    break;
                                case 'Ê': SS += "Ể";
                                    break;
                                case 'I': SS += "Ỉ";
                                    break;
                                case 'O': SS += "Ỏ";
                                    break;
                                case 'Ô': SS += "Ổ";
                                    break;
                                case 'Ơ': SS += "Ở";
                                    break;
                                case 'U': SS += "Ủ";
                                    break;
                                case 'Ư': SS += "Ử";
                                    break;
                                case 'Y': SS += "Ỷ";
                                    break;
                            }
                            i++;
                            break;
                        case 771:
                            switch (source[i])
                            {
                                case 'a': SS += "ã";
                                    break;
                                case 'ă': SS += "ẵ";
                                    break;
                                case 'â': SS += "ẫ";
                                    break;
                                case 'e': SS += "ẽ";
                                    break;
                                case 'ê': SS += "ễ";
                                    break;
                                case 'i': SS += "ĩ";
                                    break;
                                case 'o': SS += "õ";
                                    break;
                                case 'ô': SS += "ỗ";
                                    break;
                                case 'ơ': SS += "ỡ";
                                    break;
                                case 'u': SS += "ũ";
                                    break;
                                case 'ư': SS += "ữ";
                                    break;
                                case 'y': SS += "ỹ";
                                    break;
                                case 'A': SS += "Ã";
                                    break;
                                case 'Ă': SS += "Ẵ";
                                    break;
                                case 'Â': SS += "Ẫ";
                                    break;
                                case 'E': SS += "Ẽ";
                                    break;
                                case 'Ê': SS += "Ễ";
                                    break;
                                case 'I': SS += "Ĩ";
                                    break;
                                case 'O': SS += "Õ";
                                    break;
                                case 'Ô': SS += "Ỗ";
                                    break;
                                case 'Ơ': SS += "Ỡ";
                                    break;
                                case 'U': SS += "Ũ";
                                    break;
                                case 'Ư': SS += "Ữ";
                                    break;
                                case 'Y': SS += "Ỹ";
                                    break;
                            }
                            i++;
                            break;
                        case 803:
                            switch (source[i])
                            {
                                case 'a': SS += "ạ";
                                    break;
                                case 'ă': SS += "ặ";
                                    break;
                                case 'â': SS += "ậ";
                                    break;
                                case 'e': SS += "ẹ";
                                    break;
                                case 'ê': SS += "ệ";
                                    break;
                                case 'i': SS += "ị";
                                    break;
                                case 'o': SS += "ọ";
                                    break;
                                case 'ô': SS += "ộ";
                                    break;
                                case 'ơ': SS += "ợ";
                                    break;
                                case 'u': SS += "ụ";
                                    break;
                                case 'ư': SS += "ự";
                                    break;
                                case 'y': SS += "ỵ";
                                    break;
                                case 'A': SS += "Ạ";
                                    break;
                                case 'Ă': SS += "Ặ";
                                    break;
                                case 'Â': SS += "Ậ";
                                    break;
                                case 'E': SS += "Ẹ";
                                    break;
                                case 'Ê': SS += "Ệ";
                                    break;
                                case 'I': SS += "Ị";
                                    break;
                                case 'O': SS += "Ọ";
                                    break;
                                case 'Ô': SS += "Ộ";
                                    break;
                                case 'Ơ': SS += "Ợ";
                                    break;
                                case 'U': SS += "Ụ";
                                    break;
                                case 'Ư': SS += "Ự";
                                    break;
                                case 'Y': SS += "Ỵ";
                                    break;
                            }
                            i++;
                            break;
                        default: SS += source[i];
                            break;
                    }
                }
            }
            else SS = source;
            return SS;
        }

        /// <summary>
        /// Remove all HTML Tag
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>HTML Tag free string</returns>
        public static string removeHTML(string source)
        {
            if (source == null) return String.Empty;
            string pattern = @"(<[^>]+>)";
            string text = System.Text.RegularExpressions.Regex.Replace(source, pattern, string.Empty);

            return NormalizeString(HttpUtility.HtmlDecode(text).Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " ")).Trim();

            //source = Regex.Replace(source, "<.*?>", string.Empty);
            //source = Regex.Replace(source, "&nbsp;", " ");
            //return NormalizeString(HttpUtility.HtmlDecode(source).Replace("\r\n", " ").Trim());
        }

        /// <summary>
        /// Remove all a Tag and its inner text
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>HTML Tag free string</returns>
        public static string removeATagAndInnerText(string source)
        {
            if (source == null) return String.Empty;

            string s = source;

            string temp = s;

            int start = s.IndexOf("<a ");
            int end = s.IndexOf("</a>");
            while (start>=0 && end>0 && end>start)
            {
                temp = "";
                int l = s.Length - end - 4;
                
                if (start > 0)
                    temp += s.Substring(0, start);
                if (l > 0)
                    temp += s.Substring(end + 4, l);

                s = temp;
                start = s.IndexOf("<a ");
                end = s.IndexOf("</a>");
            }
            return removeHTML(temp);

            //string pattern = @"(<a\s+[^>]+>)([^>]+)(</a>)";
            //string text = System.Text.RegularExpressions.Regex.Replace(source, pattern, string.Empty);

            //return NormalizeString(HttpUtility.HtmlDecode(text).Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " ")).Trim();
        }

        /// <summary>
        /// Remove all HTML Tag
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>HTML Tag free string</returns>
        public static string removeHTMLWithLine(string source)
        {
            if (source == null) return String.Empty;
            string pattern = @"(<[^>]+>)";
            string text = System.Text.RegularExpressions.Regex.Replace(source, pattern, string.Empty);

            return NormalizeString(HttpUtility.HtmlDecode(text)).Trim();
        }

        /// <summary>
        /// Removing HTML entities while preserving line breaks
        /// </summary>
        /// <param name="source">Source html</param>
        /// <returns>HTML free text</returns>
        public static string StripHTML(string source)
        {
            try
            {
                string result;

                // Remove HTML Development formatting
                // Replace line breaks with space
                // because browsers inserts space
                result = source.Replace("\r", " ");
                // Replace line breaks with space
                // because browsers inserts space
                result = result.Replace("\n", " ");
                // Remove step-formatting
                result = result.Replace("\t", string.Empty);
                // Remove repeating spaces because browsers ignore them
                result = System.Text.RegularExpressions.Regex.Replace(result,
                                                                      @"( )+", " ");

                // Remove the header (prepare first by clearing attributes)
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*head([^>])*>", "<head>",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"(<( )*(/)( )*head( )*>)", "</head>",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(<head>).*(</head>)", string.Empty,
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                // remove all scripts (prepare first by clearing attributes)
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*script([^>])*>", "<script>",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"(<( )*(/)( )*script( )*>)", "</script>",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                //result = System.Text.RegularExpressions.Regex.Replace(result,
                //         @"(<script>)([^(<script>\.</script>)])*(</script>)",
                //         string.Empty,
                //         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"(<script>).*(</script>)", string.Empty,
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                // remove all styles (prepare first by clearing attributes)
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*style([^>])*>", "<style>",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"(<( )*(/)( )*style( )*>)", "</style>",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(<style>).*(</style>)", string.Empty,
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                // insert tabs in spaces of <td> tags
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*td([^>])*>", "\t",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                // insert line breaks in places of <BR> and <LI> tags
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*br( )*>", "\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*li( )*>", "\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                // insert line paragraphs (double line breaks) in place
                // if <P>, <DIV> and <TR> tags
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*div([^>])*>", "\r\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*tr([^>])*>", "\r\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*p([^>])*>", "\r\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                // Remove remaining tags like <a>, links, images,
                // comments etc - anything that's enclosed inside < >
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<[^>]*>", string.Empty,
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                // replace special characters:
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @" ", " ",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&bull;", " * ",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&lsaquo;", "<",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&rsaquo;", ">",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&trade;", "(tm)",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&frasl;", "/",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&lt;", "<",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&gt;", ">",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&copy;", "(c)",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&reg;", "(r)",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                // Remove all others. More can be added, see
                // http://hotwired.lycos.com/webmonkey/reference/special_characters/
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&(.{2,6});", string.Empty,
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                // for testing
                //System.Text.RegularExpressions.Regex.Replace(result,
                //       this.txtRegex.Text,string.Empty,
                //       System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                // make line breaking consistent
                result = result.Replace("\n", "\r");

                // Remove extra line breaks and tabs:
                // replace over 2 breaks with 2 and over 4 tabs with 4.
                // Prepare first to remove any whitespaces in between
                // the escaped characters and remove redundant tabs in between line breaks
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(\r)( )+(\r)", "\r\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(\t)( )+(\t)", "\t\t",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(\t)( )+(\r)", "\t\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(\r)( )+(\t)", "\r\t",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                // Remove redundant tabs
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(\r)(\t)+(\r)", "\r\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                // Remove multiple tabs following a line break with just one tab
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(\r)(\t)+", "\r\t",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                // Initial replacement target string for line breaks
                string breaks = "\r\r\r";
                // Initial replacement target string for tabs
                string tabs = "\t\t\t\t\t";
                for (int index = 0; index < result.Length; index++)
                {
                    result = result.Replace(breaks, "\r\r");
                    result = result.Replace(tabs, "\t\t\t\t");
                    breaks = breaks + "\r";
                    tabs = tabs + "\t";
                }

                // That's it.
                return result;
            }
            catch
            {
                return source;
            }
        }

        /// <summary>
        /// Compute CRC64 hash of a string
        /// </summary>
        /// <param name="s">input string</param>
        /// <returns>long CRC64</returns>
        public static long getCRC64(string s)
        {
            UnicodeEncoding _unicode = new UnicodeEncoding();
            ulong crc = 0;
            byte[] pl = _unicode.GetBytes(s);
            CRC64.Calc_crc(ref crc, pl, (uint)pl.Length);

            byte[] x = BitConverter.GetBytes(crc);

            return BitConverter.ToInt64(x, 0); //Convert.ToInt64(crc & 0x0008000000000000);
        }

        /// <summary>
        /// Compute CRC64 hash of a string
        /// </summary>
        /// <param name="s">input string</param>
        /// <returns>long CRC64</returns>
        public static ulong getuCRC64(string s)
        {
            UnicodeEncoding _unicode = new UnicodeEncoding();
            ulong crc = 0;
            byte[] pl = _unicode.GetBytes(s);
            CRC64.Calc_crc(ref crc, pl, (uint)pl.Length);

            return crc;
        }

        /// <summary>
        /// Compute CRC32 hash of string
        /// </summary>
        /// <param name="s">Input string</param>
        /// <returns>CRC32 int</returns>
        public static int getCRC32(string s)
        {
            Encoding unicode = Encoding.Unicode;
            return CRC32.Compute(unicode.GetBytes(s));
        }

        /// <summary>
        /// Count words with Regex.
        /// </summary>
        /// <param name="s">input string</param>
        /// <returns>Number of word</returns>
        public static int CountWords1(string s)
        {
            MatchCollection collection = Regex.Matches(s, @"[\S]+");
            return collection.Count;
        }

        /// <summary>
        /// Count word with loop and character tests.
        /// </summary>
        /// <param name="s">input string</param>
        /// <returns>Number of word</returns>
        public static int CountWords2(string s)
        {
            int c = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (char.IsWhiteSpace(s[i - 1]))
                {
                    if (char.IsLetterOrDigit(s[i]) || char.IsPunctuation(s[i]))
                    {
                        c++;
                    }
                }
            }
            if (s.Length > 2)
            {
                c++;
            }
            return c;
        }

        /// <summary>
        /// Count word using split
        /// </summary>
        /// <param name="s">input string</param>
        /// <returns>Number of word</returns>
        public static int CountWords3(string s)
        {
            string[] sp = s.Split(new char[] { ' ', '/', '\\', '|', '<', '>', '(', ')', '-', '–', '+', '*', '.', ',', ':', ';', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return sp.Length;
        }

        public static string sFromArray(List<string> s)
        {
            int K = s.Count;
            if (K > 0)
            {
                string result = "";

                for (int i = 0; i < K - 1; i++)
                {
                    result += s[i] + "\r\n";
                }

                result += s[K - 1];
                return result;
            }
            return "";
        }

        /// <summary>
        /// Remove all nonalphabet characters and to lower string without space in the begining and the ending
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string CutStringNoS(string source)
        {
            return source.Replace('!', ' ').Replace('-', ' ').Replace('(', ' ').Replace(')', ' ').Replace('/', ' ').Replace('\'', ' ').Replace('"', ' ').Replace(';', ' ').Replace(':', ' ').Replace(',', ' ').Replace('.', ' ').Replace('?', ' ').Replace('+', ' ').Replace('”', ' ').Replace('“', ' ').ToLower();
        }

        /// <summary>
        /// Remove all nonalphabet characters and put space at the head and the tail
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>Thêm dấu cách 2 đầu nhưng ko lower</returns>
        public static string CutStringNo(string source)
        {
            return " " + source.Replace('!', ' ').Replace('-', ' ').Replace('(', ' ').Replace(')', ' ').Replace('/', ' ').Replace('\'', ' ').Replace('"', ' ').Replace(';', ' ').Replace(':', ' ').Replace(',', ' ').Replace('.', ' ').Replace('?', ' ').Replace('+', ' ').Replace('”', ' ').Replace('“', ' ') + " ";
        }

        /// <summary>
        /// Safe trim content
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>Trimed string</returns>
        public static string TrimSEB(string source)
        {
            if (source == null)
                return null;
            else
                return source.Trim();
        }

        public static string CalculateBase64(string s)
        {
            Encoding unicode = new UnicodeEncoding();
            return HashWithSalt.ComputeHash(s, "SHA1", unicode.GetBytes("c#a1o*nt%d>-@d]v4&9d"));
        }

        public static string[] NGram(int N, string S)
        {
            string[] SP = S.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (N == 1) return SP;

            int L = SP.Length - N + 1;

            List<string> result = new List<string>();
            if (L > 0)
            {
                for (int i = 0; i < L; i++)
                {
                    string temp = "";
                    for (int j = 0; j < N - 1; j++)
                    {
                        temp += SP[i + j] + " ";
                    }
                    temp += SP[i + N - 1];
                    result.Add(temp);
                }
            }
            return result.ToArray();
        }

        public static string[] stringSeparate(string s)
        {
            string[] sentenceSpliter = new string[] { ". ", "\r\n", ":\"", ": ", "? ", "! " };

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

        public static string[] NGramDocument(int N, string Document)
        {
            string[] Sentences = stringSeparate(Document);
            List<string> result = new List<string>();
            for (int i = 0; i < Sentences.Length; i++)
            {
                result.AddRange(NGram(N, Sentences[i]));
            }
            return result.ToArray();
        }

        /// <summary>
        /// Phân tích từ khóa kết hợp ngữ nghĩa.
        /// </summary>
        /// <param name="N"></param>
        /// <param name="Document"></param>
        /// <returns></returns>
        public static string[] NGramDocumentCheckSynTax (int N, string Document)
        {
            string[] Sentences = stringSeparate(Document);
            List<string> result = new List<string>();
            for (int i = 0; i < Sentences.Length; i++)
            {
                result.AddRange(NGram(N, Sentences[i]));
            }
            return result.ToArray();
        }

        public static string stringFormat(int x, int len)
        {
            string result = x.ToString();
            int L = result.Length;
            if (L >= len)
            {
                return result.Substring(L - len, len);
            }
            else
            {
                int u = len - L;
                int i = 0;
                while (i < u)
                {
                    result = "0" + result;
                    i++;
                }
            }
            return result;
        }

        public static string stringFormat(ulong x, int len)
        {
            string result = x.ToString();
            int L = result.Length;
            if (L >= len)
            {
                return result.Substring(L - len, len);
            }
            else
            {
                int u = len - L;
                int i = 0;
                while (i < u)
                {
                    result = "0" + result;
                    i++;
                }
            }
            return result;
        }

        public static int ratePointDateTime(string s, int post)
        {
            return 10 - CountWords2(s) - Math.Abs(post);
        }

        public static bool IsFullDateAndTime(DateTime x)
        {
            if (x.Hour == 0 && x.Minute == 0 && x.Second == 0)
                return false;
            else return true;
        }

        public static string RemoveDuplicateWhiteSpace(string s)
        {
            StringBuilder result = new StringBuilder();
            int L = s.Length;
            for (int i = 0; i < L - 1; i++)
            {
                if (s[i] != ' ')
                {
                    if (s[i] != '.')
                        result.Append(s[i]);
                    else
                    {
                        if (i > 1)
                        {
                            if (!(s.Substring(i - 2, 2).ToLower() == "tp"))
                                result.Append(s[i]);
                        }
                    }
                }
                else if (s[i + 1] != ' ')
                    result.Append(s[i]);
            }
            return result.ToString();
        }

        public static string DisplayNumber(long x)
        {
            string s = x.ToString();

            StringBuilder sb = new StringBuilder();
            int L = s.Length;

            int h = L % 3;

            for (int i = 0; i < L; i++)
            {
                if (i % 3 == h)
                    sb.Append(",");
                sb.Append(s[i]);
            }
            return sb.ToString().Trim(',');
        }

        public static string GetAttributesString(HtmlAgilityPack.HtmlNode node)
        {
            List<string> s = new List<string>();

            if (node.HasAttributes)
            {
                int C = node.Attributes.Count;
                for (int i = 0; i < C; i++)
                {
                    string _name = node.Attributes[i].Name.Trim();

                    if (_name.ToLower() != "style")
                    {
                        string _value = node.Attributes[i].Value.Trim();
                        string temp = "@" + _name + "='" + _value + "'";

                        s.Add(temp.ToLower());
                    }
                }
                s.Sort();
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("//" + node.Name + "[");
            int L = s.Count;

            for (int i = 0; i < L - 1; i++)
            {
                sb.Append(s[i] + " and ");
            }

            if (L > 0)
                sb.Append(s[L - 1] + "]");

            return sb.ToString().TrimEnd('[');
        }

        public static string GetAttributesSapo(HtmlAgilityPack.HtmlNode sapoNode)
        {
            if (sapoNode.Name == "#text" && !sapoNode.HasAttributes)
                return "";

            List<string> s = new List<string>();

            if (sapoNode.HasAttributes)
            {
                int C = sapoNode.Attributes.Count;
                for (int i = 0; i < C; i++)
                {
                    string _name = sapoNode.Attributes[i].Name.Trim();

                    string _value = sapoNode.Attributes[i].Value.Trim();
                    string temp = "@" + _name + "='" + _value + "'";

                    s.Add(temp.ToLower());
                }
                s.Sort();
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("//" + sapoNode.Name + "[");
            int L = s.Count;

            for (int i = 0; i < L - 1; i++)
            {
                sb.Append(s[i] + " and ");
            }

            if (L > 0)
                sb.Append(s[L - 1] + "]");

            return sb.ToString().TrimEnd('[');
        }

        public static string GetAttributesStringWithoutValue(HtmlAgilityPack.HtmlNode node)
        {
            List<string> s = new List<string>();

            if (node.HasAttributes)
            {
                int C = node.Attributes.Count;
                for (int i = 0; i < C; i++)
                {
                    string temp = node.Attributes[i].Name.Trim();

                    s.Add(temp.ToLower());
                }
                s.Sort();
            }

            StringBuilder sb = new StringBuilder();
            int L = s.Count;

            for (int i = 0; i < L; i++)
            {
                sb.Append(s[i] + "|");
            }

            return sb.ToString().TrimEnd('|');
        }

        public static string GetSentenceFromIndex(string s, int index)
        {
            int begin = index;
            int end = index + 1;
            int L = s.Length - 1;

            if (index < 0 || index > L)
                return "";

            try
            {
                while (begin > 0 && !(s[begin] == '.' && s[begin + 1] == ' ') && !(s[begin] == '!' && s[begin + 1] == ' ') && !(s[begin] == '?' && s[begin + 1] == ' ') && s[begin] != '\n')
                {
                    //if (index - begin > 100)
                    //    if (s[begin] == ' ')
                    //        break;
                    begin--;
                }
            }
            catch (Exception) { }

            if (begin > 0) begin++;

            try
            {
                while (end < L - 1 && !(s[end] == '.' && s[end + 1] == ' ') && s[end] != '!' && s[end] != '?' && s[end] != '\n')
                {
                    //if (end - index > 100)
                    //    if (s[end] == ' ')
                    //        break;
                    end++;
                }
            }
            catch (Exception) { }

            return s.Substring(begin, end - begin).Trim();
        }

        public static string ShortCutURLForDisplay(string url, int maxLength)
        {
            string _url = url;
            if (url.StartsWith("http://"))
                _url = url.Substring(7);
            
            string[] s = _url.TrimEnd('/').Split(new char[]{'/'},StringSplitOptions.RemoveEmptyEntries);

            StringBuilder r = new StringBuilder();
            int L = s.Last().Length;
            int M = maxLength - L;

            r.Append(s[0] + "/");
            int i = 1;
            while (i < s.Length && r.Length < M)
            {
                r.Append(s[i] + "/");
                i++;
            }
            if (i < s.Length)
                r.Append(".../");
            r.Append(CutLenString(s.Last(), 20));
            return r.ToString();
        }

        public static string CutLenString(string s, int len)
        {
            if (s.Length > len)
                return s.Substring(0, len - 3) + "...";
            else
                return s;
        }

        public static string CutLenString(string[] s, char sp, int len)
        {
            if (s == null) return "";
            if (s.Length == 0) return "";

            StringBuilder r = new StringBuilder();
            r.Append(s[0]);
            r.Append(sp);

            int i = 1;

            while (i < s.Length && r.Length < len)
            {
                r.Append(s[i]);
                r.Append(sp);
                i++;
            }
            string rt = r.ToString();

            if (i < s.Length - 1)
            {
                rt = rt.TrimEnd(sp);
                rt += "...";
            }
            return rt;
        }
    }
}
