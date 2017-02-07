using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;
using Websosanh.Core.Drivers.Redis;

namespace WSS.Core.Crawler
{
    public class RedisParameterCrlAdapter
    {
        private IDatabase db = RedisManager.GetRedisServer(ConfigCrawler.KeyRedisCrawlerProduct).GetDatabase(2);

        public string GetParaOfRuner(string computer)
        {
            RedisValue rv = db.HashGet("para", computer);
            return (rv.IsNull) ? "" : rv.ToString();
        }

        public void SetParaOfRuner(string computer, string value)
        {
            db.HashSet("para", computer, value);

        }



        public SettingRun[] GetSettingRun(string p)
        {
            var settingRuns = new List<SettingRun>();
            foreach (var a in db.HashScan("para", p + "*", 10, 0))
            {
                string name = a.Name;
                string folder = name.Replace(p, "");

                settingRuns.Add(new SettingRun()
                {
                    FileRun = "WSS.CrawlerProduct.Run.exe",
                    Parameter = a.Value,
                    PathApp = folder,
                    Runner = p,
                    VersionCurrent = ""
                });
            }
            return settingRuns.ToArray();
        }
    }
}
