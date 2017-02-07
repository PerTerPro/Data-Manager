using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThirtyDaysOfTDD.UnitTests
{
    public class StringUtils
    {
        public int FindNumberOfOccurences(string sentenceToScan, string charactorToScanFor)
        {
            {
                if (charactorToScanFor.Length != 1)
                    throw new ArgumentException();

                var stringToCheckAsChracterArray = sentenceToScan.ToCharArray();
                var characterToCheckFor = Char.Parse(charactorToScanFor);
                var numberOfOccurenes = 0;
                for (var charIdx = 0; charIdx < stringToCheckAsChracterArray.GetUpperBound(0); charIdx++)
                {
                    if (stringToCheckAsChracterArray[charIdx] == characterToCheckFor)
                        numberOfOccurenes++;
                }
                return numberOfOccurenes;

            }
        }
    }
}
