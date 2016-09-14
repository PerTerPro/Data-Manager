using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using log4net;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.News;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.QAComment.Core
{
  

    public class PublisherSite
    {
        ProducerData _publisherJob = null;
        private ILog _log = LogManager.GetLogger(typeof(PublisherSite));

        public void PushCompanyDownload(long companyId)
        {
            Company cmp = new Company(companyId);
            string queue = Config.QueueWaitDownloadHtml + "." + cmp.Domain;


            _publisherJob = ProducerData.Instance(Config.RabbitMQServerComment);

            RabbitMQServer rabbitMqServer = RabbitMQManager.GetRabbitMQServer(Config.RabbitMQServerComment);
            var Chanel =   rabbitMqServer.CreateChannel();
            Chanel.QueueDeclare(queue, true, false, false, null);

            var productAdapter = new SqlDb(QT.Entities.Server.ConnectionString);
            DataTable tblProduct;
            var page = 1;
            do
            {
                const string query = @"SELECT     ID, DetailUrl
FROM            Product
WHERE        Company = @COmpanyID 
ORDER BY ID
OFFSET ((@Page-1)*10000) ROWS
FETCH NEXT 10000 ROWS ONLY
";
                tblProduct = productAdapter.GetTblData(query, CommandType.Text, new SqlParameter[]
                {
                    SqlDb.CreateParamteterSQL("@Page", page++, SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@CompanyID", companyId, SqlDbType.BigInt)
                });
                PushJob(tblProduct, companyId, queue);
            } while (tblProduct.Rows.Count > 0);
        }

        private void PushJob(DataTable tblProduct, long companyID, string queue)
        {
            foreach (DataRow row in tblProduct.Rows)
            {
                try
                {
                    var id = Convert.ToInt64(row["Id"]);
                    var url = Convert.ToString(row["DetailUrl"]);
                    if (companyID == 3502170206813664485)
                    {
                        url = HttpUtility.UrlDecode(url);
                        url = Regex.Match(url, "url=.*html").Captures[0].Value.Replace("url=", "");
                    }
                    _publisherJob.PushMss("", queue, true, new JobDownloadHtml()
                    {
                        Id = id,
                        Url = url,
                        CompanyId = companyID
                    }.GetByteArJSON());
                }
                catch (Exception exp)
                {
                    _log.Error(exp);
                }
            }
        }
    }
}
