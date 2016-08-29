using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GABIZ.Base.HtmlAgilityPack;
using log4net;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using WSS.Core.Crawler;

namespace WSS.Service.CR.CacheFailConfig
{
    public class Worker
    {
        private ILog _log = LogManager.GetLogger(typeof(Worker));
        public void Start()
        {
            ProductAdapter pa = new ProductAdapter(new SqlDb(ConfigCrawler.ConnectProduct));
            QT.Entities.Server.ConnectionString = ConfigCrawler.ConnectProduct;

            List<long> companyIds = pa.GetAllCompanyIdCrawler();

            for (int i = 0; i < companyIds.Count; i++)
            {
                long companyId = companyIds[i];
                Company company = new Company(companyId);
                Configuration configuration = new Configuration(companyId);
                ProductParse parse = new ProductParse();
                ProductEntity productEntity = new ProductEntity();

                HtmlDocument document = new HtmlDocument();
                string url = configuration.LinkTest;
                string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(url, 45, 2);

                if (!string.IsNullOrEmpty(html))
                {document.LoadHtml(html);
                    try
                    {
                        parse.Analytics(productEntity, document, configuration.LinkTest, configuration, company.Domain);
                        if (!productEntity.IsSuccessData(configuration.CheckPrice))
                        {
                            pa.GetSqlDb()
                                .RunQuery("insert into Company_FailConfig (CompanyId) Values (@CompanyId)",
                                    CommandType.Text,
                                    new SqlParameter[]
                                    {
                                        SqlDb.CreateParamteterSQL("@CompanyId", companyId, SqlDbType.BigInt)
                                    });
                        }
                    }
                    catch (Exception ex)
                    {
                        pa.GetSqlDb()
                            .RunQuery("insert into Company_FailConfig (CompanyId, Error) Values (@CompanyId, @Error)",
                                CommandType.Text,
                                new SqlParameter[]
                                {
                                    SqlDb.CreateParamteterSQL("@CompanyId", companyId, SqlDbType.BigInt),
                                    SqlDb.CreateParamteterSQL("@Error", ex.Message + "\n" + ex.StackTrace,
                                        SqlDbType.NVarChar)
                                });

                    }
                    _log.Info(string.Format("Run data {0}/  {1}", i, companyIds.Count));
                }
            }
        }
    }
}
