using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CompanyXPath
{
    public class StructCompanyXPath
    {
        public string Serilization ()
        {
            string output = JsonConvert.SerializeObject(this);
            return output;
        }
        public long CompanyID { get; set; }
        public string Website { get; set; }
        public StructXPath structXpath { get; set; }
    }

    public class StructXPath 
    {
        public List<string> ProductNameXPath {get;set;}
        public List<string> PriceXPath {get;set;}
        public List<string> StatusXPath {get;set;}
        public List<string> ImageXPath {get;set;}


        public IEnumerable<string> VATInfoXPath { get; set; }

        public List<string> PromotionInfoXPath { get; set; }

        public List<string> OriginPriceXPath { get; set; }

        public List<string> CategoryXPath { get; set; }

        public List<string> StartDealXPath { get; set; }

        public List<string> EndDealXPath { get; set; }
    }
}
