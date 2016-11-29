using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImboForm;
using QT.Moduls;
using QT.Moduls.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;
using DB = QT.Entities.DB;

namespace WSS.ImageServer
{
    public class HandlerCmpWaitTransf
    {
        private readonly ImageAdapterSql _imgAdapter = ImageAdapterSql.Instance();
        private readonly ProducerBasic _producerProductWaitUpImg = null;

        public HandlerCmpWaitTransf()
        {
            _producerProductWaitUpImg = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), ConfigImbo.QueueJobProductWaitUpImg);
        }

        public int PushDownloadImageByCompany(long companyId, int pageStart = 1)
        {
            int countProduct = 0;
            var  sqlDb = _imgAdapter.GetSqlDb();
            string sql =
                string.Format(@"select p.ID, p.ImagePath, p.ImageUrls
from Product p
where p.Company = {0}
order by ID asc
", companyId);
            sqlDb.ProcessDataTableLarge(sql, 100, (row,iRow) =>
            {
                _producerProductWaitUpImg.PublishString(new JobProductWaitUpImg()
                {
                    ImageUrl = Convert.ToString(row["ImageUrls"]),
                    ImgPathOld = Convert.ToString(row["ImagePath"]),
                    ProductId = Convert.ToInt64(row["ID"])
                }.ToJson());
                countProduct++;
            });
            return countProduct;
        }
    }
}
