using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS.Core.Crawler;
using NUnit.Framework;
namespace WSS.Core.Crawler.Tests
{
    [TestFixture()]
    public class RedisParameterCrlAdapterTests
    {
        [Test()]
        public void SetParaOfRunerTest()
        {
            RedisParameterCrlAdapter r = new RedisParameterCrlAdapter();

            r.SetParaOfRuner("192.168.100.12_000", "-t 0 -nt 1 -QueueMq Vip.Cmp.Crl.Fn");

            r.SetParaOfRuner("172.22.1.71_001", "-t 0 -nt 50 -QueueMq Vip.Cmp.Crl.Fn");
            r.SetParaOfRuner("172.22.1.71_002", "-t 0 -nt 50 -QueueMq Vip.Cmp.Crl.Fn");
            r.SetParaOfRuner("172.22.1.72_001", "-t 1 -nt 50 -QueueMq Vip.Cmp.Crl.Rl");
            r.SetParaOfRuner("172.22.1.72_002", "-t 1 -nt 50 -QueueMq Vip.Cmp.Crl.Rl");

            r.SetParaOfRuner("172.22.1.73_001", "-t 0 -nt 50 -QueueMq Vip.Cmp.Crl.Fn");
            r.SetParaOfRuner("172.22.1.73_002", "-t 1 -nt 50 -QueueMq Vip.Cmp.Crl.Rl");


            r.SetParaOfRuner("172.22.30.84_001", "-t 0 -nt 50 -QueueMq Normal.Cmp.Crl.Fn");
            r.SetParaOfRuner("172.22.30.84_002", "-t 0 -nt 50 -QueueMq Normal.Cmp.Crl.Fn");

            r.SetParaOfRuner("172.22.30.85_001", "-t 1 -nt 50 -QueueMq Normal.Cmp.Crl.Rl");
            r.SetParaOfRuner("172.22.30.85_002", "-t 1 -nt 50 -QueueMq Normal.Cmp.Crl.Rl");

        }
    }
}
