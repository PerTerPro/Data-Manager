using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImboForm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ImboForm.Tests
{
    [TestClass()]
    public class WorkerCmpWaitTransfTests
    {
        [TestMethod()]
        public void WorkerCmpWaitTransfTest()
        {
            WorkerCmpWaitTransf w = new WorkerCmpWaitTransf();
            w.StartConsume();
        }

        [TestMethod()]
        public void InitTest()
        {
          
        }

        [TestMethod()]
        public void ProcessMessageTest()
        {
            
        }
    }
}
