using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace UpdateSolrTools
{
    public class ProductCodeNormalization
    {
        private const string DoubleCodeRegex = "\\b[A-Z0-9]+\\s*\\-\\s*[A-Z0-9]+\\b";
        public static string ProductCodeRegex1 = "(\\b|\\-)[a-zA-Z]*[0-9]+[a-zA-Z]+\\S*(\\b|\\-)";
        public static string ProductCodeFirstPartRegex1 = "(\\b|\\-)[a-zA-Z]*[0-9]+";
        public static string ProductCodeRegex2 = "(\\b|\\-)[0-9]*[a-zA-Z]+[0-9]+(\\b|\\-)";
        public static string ProductCodeFirstPartRegex2 = "(\\b|\\-)[0-9]*[a-zA-Z]+";

        public static List<string> GetOtherNames(string productName)
        {
            List<string> otherNames = new List<string>();
            //double code => coupleCode
            otherNames.AddRange(GetCoupleCodeName(productName));
            var separatedCodeNames = GetSeparatedCodeName(productName);
            otherNames.AddRange(separatedCodeNames);
            foreach (var separatedCodeName in separatedCodeNames)
            {
                otherNames.AddRange(GetSeparatedCodeName(separatedCodeName));
            }
            return otherNames.Distinct().ToList();
        }

        public static List<string> GetSeparatedCodeName(string productName)
        {
            List<string> otherNames = new List<string>();
            var codeMatches1 = Regex.Matches(productName, ProductCodeRegex1);
            foreach (Match match in codeMatches1)
                foreach (Capture capture in match.Captures)
                {
                    var firstPartMatch = Regex.Match(capture.Value, ProductCodeFirstPartRegex1);
                    otherNames.Add(productName.Substring(0, capture.Index + firstPartMatch.Length) + " " +
                                   productName.Substring(capture.Index + firstPartMatch.Length));
                }
            var codeMatches2 = Regex.Matches(productName, ProductCodeRegex2);
            foreach (Match match in codeMatches2)
                foreach (Capture capture in match.Captures)
                {
                    var firstPartMatch = Regex.Match(capture.Value, ProductCodeFirstPartRegex2);
                    otherNames.Add(productName.Substring(0, capture.Index + firstPartMatch.Length) + " " +
                                   productName.Substring(capture.Index + firstPartMatch.Length));
                }
            return otherNames;
        }

        public static List<string> GetCoupleCodeName(string productName)
        {
            List<string> coupleCodeNames = new List<string>();
            var coupledMatches = Regex.Matches(productName, DoubleCodeRegex);
            foreach (Match match in coupledMatches)
                foreach (Capture capture in match.Captures)
                    coupleCodeNames.Add(productName.Substring(0, capture.Index) + capture.Value.Replace(" ", "").Replace("-", "") + productName.Substring(capture.Index + capture.Length));
            return coupleCodeNames;
        }
    }
}