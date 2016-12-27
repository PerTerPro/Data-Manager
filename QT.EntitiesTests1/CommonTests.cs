using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;
using NUnit.Framework;
using System.IO;
namespace QT.Entities.Tests
{
    [TestFixture()]
    public class CommonTests
    {
        [Test()]
        public void RemoveCommentXMLTest()
        {
            string htmlTest = @"<!--Test01-->0<!--Test02-->1";            
            string htmlAfter  = @"01";
            string x = Common.RemoveCommentXML(htmlTest);
            Assert.AreEqual(htmlAfter,x);
        }

        [Test()]
        public void RemoveScripTagTest()
        {
            string htmlTest = @"<script>0</script>1<script>2</script>";
            string htmlAfter = @"1";
            string x = Common.RemoveScripTag(htmlTest);
            Assert.AreEqual(htmlAfter, x);
        }
    }
}
