using QT.Entities;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlerProduct
{
    public class TaskRefreshCheckConfig
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(TaskRefreshCheckConfig));
        Dictionary<long, QT.Entities.Company> dicCompany = new Dictionary<long, Entities.Company>();
        public string connectionString { get; set; }
        public void Start()
        {
            string patternQuery = "update company set ConfigSuccess = {0} where id = {1}";
            List<string> query = new List<string>();
            QT.Entities.Server.ConnectionString = this.connectionString;
            ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            foreach (DataRow row in productAdapter.GetLinkTestCrawlerAllCompany().Rows)
            {
                try
                {
                    Thread.Sleep(1000);
                    long CompanyID = Convert.ToInt64(row["Id"]);
                    string domain = Convert.ToString(row["Domain"]);
                    string LinkAutoTest = Convert.ToString(row["LinkAutoTest"]);
                    var config = new Configuration(CompanyID);
                    bool IsOK = false;
                    Product product = new Product();
                    string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHtmlNomarlTag(GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(LinkAutoTest, 45, 2));
                    if (html != "")
                    {
                        GABIZ.Base.HtmlAgilityPack.HtmlDocument doc = new GABIZ.Base.HtmlAgilityPack.HtmlDocument();
                        doc.LoadHtml(html);
                        product.Analytics(doc, LinkAutoTest,config, true, domain, null);
                        IsOK = product.IsSuccessData(config.CheckPrice);
                        query.Add(string.Format(patternQuery, IsOK == true ? "1" : "0", CompanyID));
                        if (query.Count > 10)
                        {

                        }
                    }
                }
                catch (Exception ex01)
                {
                    log.Error(ex01);
                }
            }

        }
    }
}