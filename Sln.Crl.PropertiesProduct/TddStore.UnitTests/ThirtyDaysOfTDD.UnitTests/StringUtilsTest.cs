using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ThirtyDaysOfTDD.UnitTests
{
    [TestFixture]
    public class StringUtilsTest
    {
        public StringUtils _stringUtils;

        [SetUp]
        public void SetupStringUtilTests()
        {
            _stringUtils=new StringUtils();
        }


        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            var sentenceToScan = "TDD is awesome!";
            var charactorToScanFor = "e";
            var expectedResult = 2;


            int result = this._stringUtils.FindNumberOfOccurences(sentenceToScan, charactorToScanFor);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldBeAbleToCountNumberOfLetterInComplexSentence()
        {
            var sentenceToScan = "Once is unique, twice is a coincidence, three times is a pattern.";
            var characterToScanFor = "n";
            var expectedResult = 5;
            int result = this._stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldGetAnArgumentExceptionWhenCharacterToScanForIsLargerCharacter()
        {
            //Arrange
            var sentenceToScan = "This test should throw an exception";
            var characterToScanFor = "xx";
            
            //Act/Assert
            Assert.Throws<ArgumentException>(() => this._stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor));
        }
    }
}
