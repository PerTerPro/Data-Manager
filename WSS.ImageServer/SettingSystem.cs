using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImboForm
{
    public class SettingSystem
    {
        public string Path { get; set; }
        public int Thread { get; set; }

        public static SettingSystem GetSetting()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SettingSystem>(File.ReadAllText("Setting.txt"));
        }
    }
}
