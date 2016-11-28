using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UpdateSolrTools
{
    public class UnitNormalization
    {
        private const string numericStringRegex = "\\b[\\d]+((\\.|,)\\d+)?";

        private static string[] asciiUnitStrings = {"bit","Btu", "cell","cm","dB","dpi","g","GB" , "GHz", "gram", "Hz", "inch", "IU", "Kbps","Kcal","kg","Kva",
            "lit","l", "Lumens","m", "mAh","MB","mcg","mg","MHz","micron","ml","mm","ms","s","V","W"};

        private static string[] specialCharacterUnitStrings = { "%" };
        private static string[] vietnameseUnitStrings = {"lít", "mililít", "mét"};
        private static string[] _coupledUnitRegexArray;
        private static string[] _separatedUnitRegexArray;
        private static string[] _allUnitArray;


        static UnitNormalization()
        {
            BuildUnitRegexArray();
        }

        private static void BuildUnitRegexArray()
        {
            var allUnitArrayLength = asciiUnitStrings.Length + specialCharacterUnitStrings.Length +
                                     vietnameseUnitStrings.Length;
            _allUnitArray = new string[allUnitArrayLength];
            _coupledUnitRegexArray = new string[allUnitArrayLength];
            _separatedUnitRegexArray = new string[allUnitArrayLength];
            int currentUnitArrayIndex = 0;
            foreach (string unit in asciiUnitStrings)
            {
                _coupledUnitRegexArray[currentUnitArrayIndex] = numericStringRegex + unit.ToLower() +
                                                                              "\\b";
                _separatedUnitRegexArray[currentUnitArrayIndex] = numericStringRegex + "\\s" + unit.ToLower() + "\\b";
                _allUnitArray[currentUnitArrayIndex] = unit;
                currentUnitArrayIndex++;
            }
            foreach (string unit in specialCharacterUnitStrings)
            {
                _coupledUnitRegexArray[currentUnitArrayIndex] = numericStringRegex + unit.ToLower();
                _separatedUnitRegexArray[currentUnitArrayIndex] = numericStringRegex + "\\s" + unit.ToLower();
                _allUnitArray[currentUnitArrayIndex] = unit;
                currentUnitArrayIndex++;
            }
            foreach (string unit in vietnameseUnitStrings)
            {
                _coupledUnitRegexArray[currentUnitArrayIndex] = numericStringRegex + unit.ToLower() +
                                                                              "\\b";
                _separatedUnitRegexArray[currentUnitArrayIndex] = numericStringRegex + "\\s" + unit.ToLower() + "\\b";
                _allUnitArray[currentUnitArrayIndex] = unit;
                currentUnitArrayIndex++;
            }
        }

        public static List<string> GetUnitNormalizedName(string name)
        {
            var otherNames = new List<string>();
            for (int regexIndex = 0; regexIndex < _allUnitArray.Length; regexIndex++)
            {
                var coupledMatches = Regex.Matches(name.ToLower(), _coupledUnitRegexArray[regexIndex]);
                foreach (Match match in coupledMatches)
                {
                    foreach (Capture capture in match.Captures)
                    {
                        var endIndex = capture.Index + capture.Length - 1 - _allUnitArray[regexIndex].Length;
                        otherNames.Add(name.Substring(0, endIndex + 1) + " " + name.Substring(endIndex + 1));
                    }
                }

                var separatedMatches = Regex.Matches(name.ToLower(), _separatedUnitRegexArray[regexIndex]);
                foreach (Match match in separatedMatches)
                {
                    foreach (Capture capture in match.Captures)
                    {
                        var endIndex = capture.Index + capture.Length - 1 - _allUnitArray[regexIndex].Length - 1;
                        otherNames.Add(name.Substring(0, endIndex + 1) + name.Substring(endIndex + 2));
                    }
                }
            }
            return otherNames;
        }
    }
}