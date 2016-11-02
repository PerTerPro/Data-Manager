using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;

namespace WSS.DocMan
{
    public class Documet
    {
        public bool Validated { get; set; }
        public int DocTypeId { get; set; }
        public string Scope { get; set; }
        public DateTime DateIssued { get; set; }
        public string WhoIssued { get; set; }
        public string DateBeginValidated { get; set; }
        public string DateEndValidated { get; set; }
        public int IdDoc { get; set; }
        public string TextDoc { get; set; }
        public string HtmlDoc { get; set; }
        public long Id { get; set; }
        public List<Tuple<HtmlNode, List<HtmlNode>, List<string>>> LstStructure;

        public void ParseDieu()
        {
            foreach (var tupleData in LstStructure)
            {
                foreach (var variable in tupleData.Item2)
                {
                    var nodeDieus = variable.SelectNodes(".//a[@name]");
                    if (nodeDieus!=null)
                    foreach (var nL in nodeDieus)
                    {
                        string a = nL.GetAttributeValue("name", "");
                        if (a != "")
                        {
                            tupleData.Item3.Add(a);
                        }
                    }
                }
            }
        }

        public bool IsValidData()
        {
            return true;
        }

        public object Url { get; set; }
    }

    public class MenuItem
    {
      
        public string Text { get; set; }
        public string Html { get; set; }
        public string Ref { get; set; }
        public string Title { get; set; }
    }
}
