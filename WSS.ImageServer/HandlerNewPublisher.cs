using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.ImageServer
{
    public class HandlerNewPublisher
    {
        readonly ProducerBasic pb = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo),ConfigImbo.QueuePublishedWaitTrans);
        SqlDb sqlDb = new SqlDb(ConfigImbo.ConnectionNew);
        private ILog log = LogManager.GetLogger(typeof (HandlerNewPublisher));

        public void RePushJob()
        {
            
            sqlDb.ProcessDataTableLarge(@"
SELECT News_Image, News_ID
FROM [ReviewsCMS].[dbo].[NewsPublished] a
WHERE ISNULL(ImageId, '') = ''
AND ISNULL(News_Image, '') <> ''
and ISNULL(ChangeImage, 0) = 0
ORDER BY News_ID
", 10000, (row, iRow) =>
            {
                string newsImage = Common.Obj2String(row["News_Image"]);
                long newsId = Common.Obj2Int64(row["News_ID"]);
                if (!newsImage.Contains("http"))
                {
                    newsImage = @"http://review.websosanh.net/" + newsImage;
                }
                pb.PublishString(new JobPublishedWaitTrans()
                {
                    Id = newsId,
                    Url = newsImage
                }.ToJson());
                return true;
            });
        }

        internal void PushImbo(string mss)
        {
            try
            {
                JobPublishedWaitTrans job = JobPublishedWaitTrans.FromJson(mss);
                if (job != null)
                {
                    string newId = ImboImageService.PushFromUrl(ConfigImbo.PublicKey, ConfigImbo.PrivateKey, job.Url, "review", ConfigImbo.Host, ConfigImbo.Port);
                    sqlDb.RunQuery(@" Update [NewsPublished] Set ImageId = @ImageId Where News_ID = @News_ID ", CommandType.Text, new[]
                    {
                        SqlDb.CreateParamteterSQL("ImageId", newId, SqlDbType.NVarChar),
                        SqlDb.CreateParamteterSQL("News_ID", job.Id, SqlDbType.BigInt),
                    });
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
    }
}
