using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.ProducProperties.Core
{
    public class HandlerAdayroi:IHandlerData
    {
        public Product ParseProduct(GABIZ.Base.HtmlAgilityPack.HtmlDocument htmlDocument)
        {
            Product pt = new Product();
            var nodeProperties = htmlDocument.DocumentNode.SelectNodes(@"//div[@id='product_description']//div[@id='tab_content_product_specifications']//table//tr[@class='row-info']");
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
