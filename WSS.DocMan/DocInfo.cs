using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.DocMan
{
    public class DocInfo
    {
        public DocInfo()
        {
            DocNumber = "";
            DatePublish = "";
            TypeDoc = "";
            Source = "";
            DatePost = "";
            Enable = "";
            DateEnable = "";
            ReasonNoEnable = "";
            DateNoEnable = "";
            PartNoEnable = "";
            DateUsed = "";
            DocFrom = "";
            DocRef = "";
            DocIsAlter = "";
            DocIsReplate = "";
        }

        public string DocNumber { get; set; }
        public string DatePublish { get; set; }
        public string TypeDoc { get; set; }
        public string Source { get; set; }
        public string Scope { get; set; }
        public string DatePost { get; set; }
        public string Enable { get; set; }
        public string DateEnable { get; set; }
        public string ReasonNoEnable { get; set; }
        public string DateNoEnable { get; set; }
        public string PartNoEnable { get; set; }
        public string DateUsed { get; set; }
        public string DocRef { get; set; }
        public long Id { get; set; }

        public string DocFrom { get; set; }
        public string DocIsAlter { get; set; }
        public string DocIsReplate { get; set; }
    }

}
