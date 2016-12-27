using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;
using NUnit.Framework;
namespace QT.Entities.Tests
{
    [TestFixture()]
    public class UtilZipFileTests
    {
        [Test()]
        public void ZipTest()
        {

            string str1 = "12312312312312";
            string str2 = "<\nconghoaxahoichunghiavietnam";

            Assert.AreEqual(str1, UtilZipFile.UnzipWithEndcode(UtilZipFile.ZipWithEndcode(str1)));
            Assert.AreEqual(str2, UtilZipFile.UnzipWithEndcode(UtilZipFile.ZipWithEndcode(str2)));
        }
    }
}
