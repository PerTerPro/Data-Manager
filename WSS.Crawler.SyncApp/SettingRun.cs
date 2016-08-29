using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crawler.SyncApp
{
    public  class SettingRun
    {
        public string PathApp { get; set; }
        public string FileRun { get; set; }
        public string Parameter { get; set; }
        public string VersionCurrent { get; set; }
        public int NumberApp { get; set; }
        public static SettingRun FromJSON (string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SettingRun>(json);
        }
        internal string GetJSON()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }


    }
}
