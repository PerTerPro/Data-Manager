
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace QT.Entities.MyConverter
{
    public class MyBoolHander 
    {
        public static bool ConvertFromCellDataTable (DataRow row, string column, bool defaultNull)
        {
            if (row[column] == DBNull.Value) return defaultNull;
            else return Convert.ToBoolean(row[column]);
        }
    }

    public class MyIntHandler
    {
        public static Int64 ConvertFromCellDataTable(DataRow row, string column, Int64 defaultNull)
        {
            if (row[column] == DBNull.Value) return defaultNull;
            else return Convert.ToInt64(row[column]);
        }

        public static Int64 ConvertFromCellDataTable(IDataReader row, string column, Int64 defaultNull)
        {
            if (row[column] == DBNull.Value) return defaultNull;
            else return Convert.ToInt64(row[column]);
        }
    }

    public class MyStringHandler
    {

        public static string ConvertFromCellDataTable (DataRow row, string column, string defaultNull)
        {
            
            return (row[column] == DBNull.Value) ? defaultNull : Convert.ToString(row[column]);
        }

        public static string ConvertFromCellDataTable(IDataReader row, string column, string defaultNull)
        {

            return (row[column] == DBNull.Value) ? defaultNull : Convert.ToString(row[column]);
        }

        public static List<string> ConvertToList(DataRow row, string column, string defaultNull)
        {
            if (row[column] == DBNull.Value) return null;
            return null;
        }

        /// <summary>
        ///     Remove special character, stop words
        ///     Keep only letter or digit
        ///     Used to process sapo
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static String PreProcess(string text)
        {
            //text = RemoveStopWordsByBruteForce(text);
            text = RemoveSpecialCharacterAndToLower(text);
            return text;
        }

        /// <summary>
        ///     To lowwer
        ///     Remove Special character
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static String RemoveSpecialCharacterAndToLower(String text)
        {
            text = MyStringHandler.HtmlDecode(text);
            StringBuilder result = new StringBuilder();
            StringBuilder tmp = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetterOrDigit(text[i]))
                {
                    tmp.Append(Char.ToLower(text[i]));
                }
                else
                {
                    if (tmp.Length > 0)
                    {
                        result.Append(tmp);
                        result.Append(" ");
                        tmp.Remove(0, tmp.Length);
                    }
                }
            }
            if (tmp.Length > 0)
            {
                result.Append(tmp);
            }
            return result.ToString().Trim();
        }

        public static String TrimSpecialCharacter(String text)
        {
            String specialChararcterRegex = "-+:|<>\r\n\t#@ ›";
            StringBuilder builder = new StringBuilder(text);
            while (builder.Length > 0)
            {
                bool isMatch = false;
                foreach (var c in specialChararcterRegex)
                {
                    if (builder[0] == c)
                    {
                        isMatch = true;
                        break;
                    }
                }
                if (builder[0] == 160 || builder[0] == 194) //nbsp;
                    isMatch = true;
                if (!isMatch)
                    break;
                else
                    builder.Remove(0, 1);
            }
            while (builder.Length > 0)
            {
                bool isMatch = false;
                foreach (var c in specialChararcterRegex)
                {
                    if (builder[builder.Length - 1] == c)
                    {
                        isMatch = true;
                        break;
                    }
                }
                if (!isMatch)
                    break;
                else
                    builder.Remove(builder.Length - 1, 1);
            }
            //Regex.Replace(text, "[^a-zA-Z0-9% ._]()+-\"", string.Empty);
            return builder.ToString();
        }

        /// <summary>
        ///     Count number of word in a text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int CountWords(String text)
        {
            int count = 0;
            bool isWord = false;
            foreach (var c in text)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    isWord = true;
                }
                else
                {
                    if (isWord)
                    {
                        count++;
                        isWord = false;
                    }
                }
            }
            if (isWord)
                count++;
            return count;
        }

        public static String HtmlDecode(String text)
        {
            return HttpUtility.HtmlDecode(text);
        }

        public static String Reverse(String text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static String FixProductName(String productName)
        {
            StringBuilder tmp = new StringBuilder();
            int i = 0;
            while (i < productName.Length)
            {
                if (i > 0 && productName[i] == '-')
                    break;
                if (productName[i] == '(')
                {
                    while (i < productName.Length && productName[i] != ')')
                        i++;
                    if (i >= productName.Length)
                        break;
                }
                if (char.IsSeparator(productName[i]))
                    tmp.Append(' ');
                if (char.IsLetterOrDigit(productName[i]))
                    tmp.Append(productName[i]);
                i++;
            }
            return tmp.ToString();
        }

        public static int CountWordsModified(string s)
        {
            return Regex.Matches(s, @"[A-Za-z0-9]+").Count;
        }

        public static string RemoveWhiteSpace(String s)
        {
            s = s.Trim();
            bool isWhiteSpace = false;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
                if (Char.IsWhiteSpace(s[i]))
                {
                    if (isWhiteSpace == false)
                    {
                        builder.Append(' ');
                        isWhiteSpace = true;
                    }
                }
                else
                {
                    builder.Append(s[i]);
                    isWhiteSpace = false;
                }
            return builder.ToString();
        }

        #region private method

        private static bool IsNotCharacter(string s, int n)
        {
            if (n < 0 || n >= s.Length || !Char.IsLetterOrDigit(s[n]))
                return true;
            else
                return false;
        }

        #endregion
    }
}

