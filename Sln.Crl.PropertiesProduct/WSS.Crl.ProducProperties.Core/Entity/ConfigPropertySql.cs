﻿namespace WSS.Crl.ProducProperties.Core.Entity
{
    public class ConfigProperty
    {
        public long CompanyId { get; set; }
        public int TypeLayout { get; set; }
        public string XPath { get; set; }
        public string JSonOtherConfig { get; set; }

        public string CategoryXPath { get; set; }

        public string UrlTest { get; set; }

        public string Domain { get; set; }public bool RemoveLastItemClassification { get; set; }

        public string ToJson()
        {
            return "";}

        public int TimeDelay { get; set; }
    }
}
