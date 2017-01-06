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

            r.SetParaOfRuner("192.168.100.12_001", "-t 0 -nt 1 -QueueMq Vip.Cmp.Crl.Fn -title 172.22.1.71_001_0_Normal");
            r.SetParaOfRuner("192.168.100.12_002", "-t 0 -nt 1 -QueueMq Vip.Cmp.Crl.Rl -title 172.22.1.71_002_1_Normal");

            r.SetParaOfRuner("172.22.1.71_001", "-t 0 -nt 25 -QueueMq Vip.Cmp.Crl.Fn -title 172.22.1.71_001_0_Vip");
            r.SetParaOfRuner("172.22.1.71_002", "-t 0 -nt 25 -QueueMq Vip.Cmp.Crl.Fn -title 172.22.1.71_002_0_Vip");
            r.SetParaOfRuner("172.22.1.71_003", "-t 1 -nt 25 -QueueMq Vip.Cmp.Crl.Rl -title 172.22.1.71_003_1_Vip");
            r.SetParaOfRuner("172.22.1.71_004", "-t 1 -nt 25 -QueueMq Vip.Cmp.Crl.Rl -title 172.22.1.71_004_1_Vip");


            r.SetParaOfRuner("172.22.1.72_001", "-t 0 -nt 25 -QueueMq Vip.Cmp.Crl.Fn -title 172.22.1.72_001_0_Vip");
            r.SetParaOfRuner("172.22.1.72_002", "-t 0 -nt 25 -QueueMq Vip.Cmp.Crl.Fn -title 172.22.1.72_002_0_Vip");
            r.SetParaOfRuner("172.22.1.72_003", "-t 1 -nt 25 -QueueMq Vip.Cmp.Crl.Rl -title 172.22.1.72_003_1_Vip");
            r.SetParaOfRuner("172.22.1.72_004", "-t 1 -nt 25 -QueueMq Vip.Cmp.Crl.Rl -title 172.22.1.72_004_1_Vip");

            r.SetParaOfRuner("172.22.1.73_001", "-t 0 -nt 25 -QueueMq Normal.Cmp.Crl.Fn -title 172.22.1.73_001_0_Normal");
            r.SetParaOfRuner("172.22.1.73_002", "-t 0 -nt 25 -QueueMq Normal.Cmp.Crl.Fn -title 172.22.1.73_002_0_Normal");
            r.SetParaOfRuner("172.22.1.73_003", "-t 1 -nt 25 -QueueMq Normal.Cmp.Crl.Rl -title 172.22.1.73_003_1_Normal");
            r.SetParaOfRuner("172.22.1.73_004", "-t 1 -nt 25 -QueueMq Normal.Cmp.Crl.Rl -title 172.22.1.73_004_1_Normal");

            r.SetParaOfRuner("172.22.30.84_001", "-t 0 -nt 25 -QueueMq Normal.Cmp.Crl.Fn -title 172.22.30.84_001_0_Normal");
            r.SetParaOfRuner("172.22.30.84_002", "-t 0 -nt 25 -QueueMq Normal.Cmp.Crl.Fn -title 172.22.30.84_002_0_Normal");
            r.SetParaOfRuner("172.22.30.84_003", "-t 1 -nt 25 -QueueMq Normal.Cmp.Crl.Rl -title 172.22.30.84_003_1_Normal");
            r.SetParaOfRuner("172.22.30.84_004", "-t 1 -nt 25 -QueueMq Normal.Cmp.Crl.Rl -title 172.22.30.84_004_1_Normal");

            r.SetParaOfRuner("172.22.30.85_001", "-t 0 -nt 25 -QueueMq Normal.Cmp.Crl.Fn -title 172.22.30.85_001_0_Normal");
            r.SetParaOfRuner("172.22.30.85_002", "-t 0 -nt 25 -QueueMq Normal.Cmp.Crl.Fn -title 172.22.30.85_002_0_Normal");
            r.SetParaOfRuner("172.22.30.85_003", "-t 1 -nt 25 -QueueMq Normal.Cmp.Crl.Rl -title 172.22.30.85_003_1_Normal");
            r.SetParaOfRuner("172.22.30.85_004", "-t 1 -nt 25 -QueueMq Normal.Cmp.Crl.Rl -title 172.22.30.85_004_1_Normal");


        }

        [Test()]
        public void GetSettingRunTest()
        {
            RedisParameterCrlAdapter r = new RedisParameterCrlAdapter();
            var x = r.GetSettingRun("172.22.1.71");
            Assert.GreaterOrEqual(x.Length, 0);
        }
    }
}
