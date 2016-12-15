﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.ImageServer;
using NUnit.Framework;
namespace WSS.ImageServer.Tests
{
    [TestFixture()]
    public class HandlerTransRootProductTests
    {
        [Test()]
        public void ProcessFixJobTest()
        {
            	
             HandlerTransRootProduct h = new HandlerTransRootProduct();
            h.ProcessFixJob(new JobRootProductWaitTrans()
            {
                Id = 18779,
                ImageId = "vB2NtEi6GlaD"
            }.ToJson());
        }
    }
}
