using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.CrawlerProduct.ProductChange.Consumer
{
    public class Parameter
    {
        public int NumberThread { get; set; }
        public bool IsSaveCassandra { get; set; }
        public bool IsSaveToCache { get; set; }
        public bool IsSaveClassification { get; set; }
        public bool IsPushCompany { get; set; }

        public static string Para = "1. PushCompany. 2.UpdateProductSQl. 3.UpdateProductToCache. 4. IsSaveClassification 5.SaveQueueEndSession. 6. ReportRunning";

        public void Parse(string[] arg)
        {
            for (int i = 0; i < arg.Length; i = i + 2)
            {
                if (arg[i] == "-nt")
                {
                    NumberThread = Convert.ToInt32(arg[i + 1]);
                }
                else if (arg[i] == "-t")
                {
                    string[] strArCommand = arg[i + 1].Split('_');
                    foreach (var strType in strArCommand)
                    {
                        int typeRun = Convert.ToInt32(strType);
                        if (typeRun == 1) IsPushCompany = true;
                        else if (typeRun == 2) IsUpdateProductToSql = true;
                        else if (typeRun == 3) IsSaveToCache = true;
                        else if (typeRun == 4) IsSaveClassification = true;
                        else if (typeRun == 5) IsSaveToEndQueue = true;
                        else if (typeRun == 6) IsUpdateRunningCrawler = true;
                    }
                }
            }
        }

        public bool IsUpdateProductToSql { get; set; }

        public Parameter()
        {
            NumberThread = 1;
            IsPushCompany = false;
            IsUpdateProductToSql = false;
            IsSaveToEndQueue = false;
            IsSaveToCache = false;
        }

        public bool IsSaveToEndQueue { get; set; }
        public bool IsUpdateRunningCrawler { get; set; }
    }
}
