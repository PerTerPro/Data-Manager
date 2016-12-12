using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImboForm;
using NUnit.Framework;
using WSS.ImageServer;
namespace ImboForm.Tests
{
    [TestFixture()]
    public class WorkerImgIdToSqlTests
    {
        [Test()]
        public void WorkerImgIdToSqlTest()
        {
            WorkerImgIdToSql w = new WorkerImgIdToSql();
            w.StartConsume();
        }

        [Test()]
        public void InitTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void ProcessMessageTest()
        {
            Assert.Fail();
        }
    }
}
