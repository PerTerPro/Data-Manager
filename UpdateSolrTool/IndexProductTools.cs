using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UpdateSolrTools.CompanyDataSetTableAdapters;
using UpdateSolrTools.ProductDatasetTableAdapters;
using Websosanh.Core.Merchant.BO;
using Websosanh.Core.Product.BAL;

namespace UpdateSolrTools
{
    public class IndexProductTools
    {

        public static Dictionary<int, string[]> GetAllCategoryTags(string productConnectionString)
        {
            var result = new Dictionary<int, string[]>();
            var tagCategoryTableAdapter = new Tag_CategoryTableAdapter
            {
                Connection = { ConnectionString = productConnectionString }
            };
            var tagCategoryDataTable = tagCategoryTableAdapter.GetAllCategoryTag();
            for (var rowIndex = 0; rowIndex < tagCategoryDataTable.Rows.Count; rowIndex++)
            {
                int categoryID = tagCategoryDataTable[rowIndex].CategoryID;
                var tags = tagCategoryDataTable[rowIndex].Tag.Split('|');
                result.Add(categoryID, tags);
            }
            return result;
        }
        public static HashSet<long> GetListMerchantUseDatafeedID(string productConnectionString)
        {
            var listIDCompanyUseDatafeed = new HashSet<long>();
            var adtCompanyManagerType = new ManagerTypeRCompanyTableAdapter()
            {
                Connection = { ConnectionString = productConnectionString }
            };
            var companyManagerTypeDataTable = adtCompanyManagerType.GetListMerchantUseDatafeed();
            for (var rowIndex = 0; rowIndex < companyManagerTypeDataTable.Rows.Count; rowIndex++)
            {
                var companyID = companyManagerTypeDataTable[rowIndex].IDCompany;
                if (!listIDCompanyUseDatafeed.Contains(companyID))
                    listIDCompanyUseDatafeed.Add(companyID);
            }
            return listIDCompanyUseDatafeed;
        }

        public static HashSet<long> GetListSpecialMerchantID(string productConnectionString)
        {
            var listSpecialMerchantID = new HashSet<long>();
            var adtCompanyManagerType = new ManagerTypeRCompanyTableAdapter()
            {
                Connection = { ConnectionString = productConnectionString }
            };
            var companyManagerTypeDataTable = adtCompanyManagerType.GetListSpecialMerchant();
            for (var rowIndex = 0; rowIndex < companyManagerTypeDataTable.Rows.Count; rowIndex++)
            {
                var companyID = companyManagerTypeDataTable[rowIndex].IDCompany;
                if (!listSpecialMerchantID.Contains(companyID))
                    listSpecialMerchantID.Add(companyID);
            }
            return listSpecialMerchantID;
        }

        public static Dictionary<int, string> GetAllPrefixCategory(string productConnectionString)
        {
            var result = new Dictionary<int, string>();
            ListClassificationTableAdapter listClassificationTableAdapter = new ListClassificationTableAdapter
            {
                Connection = {ConnectionString = productConnectionString}
            };
            var listClassificationDataTable = listClassificationTableAdapter.GetAllPrefixCategory();
            for (int rowIndex = 0; rowIndex < listClassificationDataTable.Rows.Count; rowIndex++)
            {
                result.Add(listClassificationDataTable[rowIndex].ID, listClassificationDataTable[rowIndex].Name);
            }
            return result;
        }

        public static HashSet<long> GetAllBadMerchantId(string productConnectionString, int scoreThreshold)
        {
            var badMerchantIdSet = new HashSet<long>();
            var merchantScoreTableAdapter = new MerchantScoreTableAdapter
            {
                Connection = new SqlConnection {ConnectionString = productConnectionString}
            };
            var merchantScoreDataTable = merchantScoreTableAdapter.GetAllBadMerchant(scoreThreshold);
            for (int rowIndex = 0; rowIndex < merchantScoreDataTable.Rows.Count; rowIndex++)
            {
                badMerchantIdSet.Add(merchantScoreDataTable[rowIndex].MerchantId);
            }
            return badMerchantIdSet;
        }

        public static Dictionary<long, int> GetAllPriorMerchants(string productConnectionString)
        {
            var allPriorMerchants = new Dictionary<long, int>();
            var priorMerchantTableAdapter = new PriorMerchantTableAdapter()
            {
                Connection = {ConnectionString = productConnectionString}
            };
            var priorMerchantDataTable = priorMerchantTableAdapter.GetCurrentPriorMerchants();
            for (int rowIndex = 0; rowIndex < priorMerchantDataTable.Rows.Count; rowIndex++)
            {
                allPriorMerchants.Add(priorMerchantDataTable[rowIndex].MechantId, Convert.ToInt32(priorMerchantDataTable[rowIndex].PriorityScore));
            }
            return allPriorMerchants;
        }

        #region Unit Detection

        private static string[] asciiUnitStrings = {"%", "bit","Btu", "cell","cm","dB","dpi","g","GB" , "GHz", "gram", "Hz", "inch", "IU", "Kbps","Kcal","kg","Kva",
                                                  "lit","l", "Lumens","m", "mAh","MB","mcg","mg","MHz","micron","ml","mm","ms","s","V","W"};

        private static string[] vietnameseUnitString = {"lít", "mililít", "mét"};

        private static string[] _coupledUnitRegexArray;
        private static string[] GetCoupledUnitRegexArray()
        {
            if (_coupledUnitRegexArray == null)
            {
                _coupledUnitRegexArray = new string[asciiUnitStrings.Length];
                for (int i = 0; i < asciiUnitStrings.Length; i++)
                {
                    _coupledUnitRegexArray[i] = "\\b[\\d]+[\\.,]+[\\d]+" + asciiUnitStrings[i].ToLower() + "\\b";
                }
            }
            return _coupledUnitRegexArray;
        }

        private static string[] _separatedUnitRegexArray;
        private static string[] GetSeparatedUnitRegexArray()
        {
            if (_separatedUnitRegexArray == null)
            {
                _separatedUnitRegexArray = new string[asciiUnitStrings.Length];
                for (int i = 0; i < asciiUnitStrings.Length; i++)
                {
                    _separatedUnitRegexArray[i] = "\\b[\\d\\.,]+\\s" + asciiUnitStrings[i].ToLower() + "\\b";
                }
            }
            return _separatedUnitRegexArray;
        }
        public static List<string> GetUnitNormalizedName(string name)
        {
            var otherNames = new List<string>();
            var coupledRegexStrings = GetCoupledUnitRegexArray();
            var separatedRegexStrings = GetSeparatedUnitRegexArray();
            for (int regexIndex = 0; regexIndex < asciiUnitStrings.Length; regexIndex++)
            {
                var coupledMatches = Regex.Matches(name.ToLower(), coupledRegexStrings[regexIndex]);
                foreach (Match match in coupledMatches)
                {
                    foreach (Capture capture in match.Captures)
                    {
                        var endIndex = capture.Index + capture.Length - 1 - asciiUnitStrings[regexIndex].Length;
                        otherNames.Add(name.Substring(0, endIndex + 1) + " " + name.Substring(endIndex + 1));
                        continue;
                    }
                }

                var separatedMatches = Regex.Matches(name.ToLower(), separatedRegexStrings[regexIndex]);
                foreach (Match match in separatedMatches)
                {
                    foreach (Capture capture in match.Captures)
                    {
                        var endIndex = capture.Index + capture.Length - 1 - asciiUnitStrings[regexIndex].Length - 1;
                        otherNames.Add(name.Substring(0, endIndex + 1) + name.Substring(endIndex + 2));
                        continue;
                    }
                }
            }
            return otherNames;
        }
        #endregion

        #region Product Code Detection

        public static string ProductCodeRegex1 = "(\\b|\\-)[a-zA-Z]*[0-9]+[a-zA-Z]+\\S*(\\b|\\-)";
        public static string ProductCodeFirstPartRegex1 = "(\\b|\\-)[a-zA-Z]*[0-9]+";
        public static string ProductCodeRegex2 = "(\\b|\\-)[0-9]*[a-zA-Z]+[0-9]+(\\b|\\-)";
        public static string ProductCodeFirstPartRegex2 = "(\\b|\\-)[0-9]*[a-zA-Z]+";

        private const string DoubleCodeRegex = "\\b[A-Z0-9]+\\s*\\-\\s*[A-Z0-9]+\\b";

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

        #endregion
        public static int GetNameLength(string name)
        {
            var realLenght = (double) (name.Split(SolrProductConstants.IGNORE_CHARS.ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries).Length)/3;
            return (int)Math.Round(realLenght);
        }

        //public static MerchantShortInfo GetMerchantShortInfo(long merchantID)
        //{
            
        //}
    }
}
