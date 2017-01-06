using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Core.Crawler
{
    public  class SettingRun
    {
        public string PathApp { get; set; }
        public string FileRun { get; set; }
        public string Parameter { get; set; }
        public string VersionCurrent { get; set; }
        public string Runner { get; set; }
       

        public static SettingRun FromJSON(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SettingRun>(json);

        }

        public static SettingRun[] GetArFromJson (string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SettingRun[]>(json);
        }
        internal string GetJSON()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }


    }
}
