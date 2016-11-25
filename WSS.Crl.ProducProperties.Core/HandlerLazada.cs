using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.ProducProperties.Core
{
    public class HandlerLazada : IHandlerData
    {
        public Product ParseProduct(GABIZ.Base.HtmlAgilityPack.HtmlDocument htmlDocument)
        {
            Product pt = new Product();
            var nodeProperties = htmlDocument.DocumentNode.SelectNodes(@"//table[@class='specification-table']//tr");
            if (nodeProperties != null)
            {
                foreach (var propertyNode in nodeProperties)
                {
                    string key = "";
                    string value = "";

                    if (propertyNode.SelectSingleNode("./td[@class='specification-table__property']") != null)
                        key = propertyNode.SelectSingleNode("./td[@class='specification-table__property']").InnerText.Trim().ToLower();
                    else if (propertyNode.SelectSingleNode("./td[@class='bold']") != null)
                    {
                        key = propertyNode.SelectSingleNode("./td[@class='bold']").InnerText.Trim().ToLower();
                        value = propertyNode.SelectSingleNode("./td[not(@class)]").InnerText.Trim();
                    }

                    if (propertyNode.SelectSingleNode("./td[@class='specification-table__value']") != null)
                        value = propertyNode.SelectSingleNode("./td[@class='specification-table__value']").InnerText.Trim();
                    if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value) && !pt.dicValue.ContainsKey(key))
                        pt.dicValue.Add(key, value);
                }
            }
            return pt;
        }
    }
}
