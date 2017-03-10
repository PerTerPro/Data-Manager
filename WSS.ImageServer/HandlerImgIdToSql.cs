using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using MongoDB.Bson;
using MongoDB.Driver;
using QT.Entities;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.ImageServer
{
    public class HandlerImgIdToSql
    {
        private readonly ImageAdapterSql _imgAdapterSql = new ImageAdapterSql();
        private readonly ProducerBasic _producerDelImbo = new ProducerBasic(RabbitMQManager.GetRabbitMQServer(ConfigImbo.KeyRabbitMqTransferImbo), ConfigImbo.QueueDelImgImbo);
        private ILog log = LogManager.GetLogger(typeof (HandlerImgIdToSql));

        public void ProcessJob(string str)
        {
            try
            {

                JobUploadedImg job = JobUploadedImg.FromJson(str);
                string imageIdOld = _imgAdapterSql.GetImageId(job.ProductId);
                if (!string.IsNullOrEmpty(imageIdOld))
                {
                    _producerDelImbo.PublishString(imageIdOld);
                }

                MongoDB.Driver.IMongoClient mongoClient = new MongoClient("mongodb://172.22.1.226:27017");
                var collection = mongoClient.GetDatabase("imbo").GetCollection<BsonDocument>("image");
                var filter = Builders<BsonDocument>.Filter.Eq("imageIdentifier", job.ImageId);
                var cursor = collection.FindSync(filter);
                while (cursor.MoveNext())
                {
                    int x = Convert.ToInt32(cursor.Current.ElementAt(0).GetValue("width"));
                    int y = Convert.ToInt32(cursor.Current.ElementAt(0).GetValue("height"));
                    _imgAdapterSql.UpdateImboProcess(job.ProductId, job.ImageId, x, y);
                    break;
                }
                //PushChangeMainInfo
                RabbitMQAdapter.Instance.PushProductToQueueChangeMainInfo(new List<long>() {job.ProductId});
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
    }
}
