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
    public class HandlerTransferFolderTests
    {
        [Test()]
        public void TransferImageTest()
        {
            HandlerTransferFolder f = new HandlerTransferFolder();
            f.TransferImage(@"E:\IMG\_\a\anhoaphat_vn\may\may-mai-thang-ggs-5000-l_3881851287480051368.jpg");
        }
    }
}
