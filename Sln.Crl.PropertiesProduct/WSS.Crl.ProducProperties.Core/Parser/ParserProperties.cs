using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base;
using GABIZ.Base.HtmlAgilityPack;
using Newtonsoft.Json.Linq;
using WSS.Crl.ProducProperties.Core.Entity;
using WSS.Crl.ProducProperties.Core.Storage;
using WSS.LibExtra;

namespace WSS.Crl.ProducProperties.Core.Parser
{
    public class ParserProperties : IParser
    {
        private ConfigProperty _configPropertyNomal;
        private readonly IStorageConfigCrl _storageConfigCrl;

        public ParserProperties(IStorageConfigCrl storageConfigCrl)
        {
            this._storageConfigCrl = storageConfigCrl;

        }

        public void Init(string domain)
        {
            this._configPropertyNomal = _storageConfigCrl.GetConfig(domain);
        }



        public PropertyProduct ParseData(HtmlDocument document)
        {
            PropertyProduct propertyData = new PropertyProduct();
            propertyData.Category = "";
            propertyData.Domain = _configPropertyNomal.Domain;
            propertyData.CategoryId = CommonConvert.CrcProductID(propertyData.Category);
            var nodeRows = document.DocumentNode.SelectNodes(_configPropertyNomal.XPath);
            dynamic configOtherData = JObject.Parse(_configPropertyNomal.JSonOtherConfig);
            string colH = configOtherData.IndexColHeader.ToString();
            string colB = configOtherData.IndexColData.ToString();
            if (nodeRows != null)
            {
                foreach (var variable in nodeRows)
                {
                    var nodeCell = variable.SelectNodes("./td");
                    if (nodeCell != null)
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(nodeCell[Convert.ToInt32(colH)].InnerText.Trim()) && !string.IsNullOrEmpty(nodeCell[Convert.ToInt32(colB)].InnerText.Trim()))
                            {
                                propertyData.Properties.Add(
                                nodeCell[Convert.ToInt32(colH)].InnerText.Trim(),
                                nodeCell[Convert.ToInt32(colB)].InnerText.Trim());
                            }

                        }
                        catch (Exception ex)
                        {
                            // ignored
                        }
                    }

                }
            }
            return propertyData;
        }
    }
}
