using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ImboForm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ImboForm.Tests
{
    [TestClass()]
    public class WorkerUpImgToServerTests
    {
        [TestMethod()]
        public void ProcessMessageTest()
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Factory.StartNew(() =>
                {
                    WorkerUpImgToServer w = new WorkerUpImgToServer();
                    w.StartConsume();
                });
               
            }Thread.Sleep(10000000);
        }
    }
}
