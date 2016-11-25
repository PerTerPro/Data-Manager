using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;

namespace WSS.Crl.ProducProperties.Core
{
    public  class HandlerTiki : IHandlerData
    {
        public Product ParseProduct(GABIZ.Base.HtmlAgilityPack.HtmlDocument htmlDocument)
        {
            Product pt = new Product();
            var nodeProperties = htmlDocument.DocumentNode.SelectNodes(@"//table[@id='chi-tiet']//tr");
            if (nodeProperties != null)
            {
                foreach (var propertyNode in nodeProperties)
                {
                    var nodeData = propertyNode.SelectNodes("./td");
                    if (nodeData != null && nodeData.Count > 1)
                    {
                        string nameProperty = nodeData[0].InnerText.ToLower().Trim();
                        string valueProperty = nodeData[1].InnerText.Trim();
                        pt.dicValue.Add(nameProperty, valueProperty);
                    }
                }
            }
            return pt;
        }
    }
}
