using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;

namespace WSS.Individual.RootProductAnalyzedService
{
    public class RootProductAnalyzedObject
    {
        //private long _rootId;
        public int CategoryId { get; set; }
        public int WebsiteId { get; set; }
        public string code { get; set; }
        public int Price { get; set; }
        public int MerchantScore { get; set; }
        public string ent { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }

        public long RootProductId
        {
            get { return Common.GetID_RootProductIDIndividual((WebsiteId+"_"+ent + " " + code).Trim().ToLower()); }
        }
    }
}
