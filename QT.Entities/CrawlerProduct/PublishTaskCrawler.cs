using QT.Entities.Model.SaleNews;
using RabbitMQ.Client;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.CrawlerProduct
{
    public class PublishTaskCrawler
    {
        //public void Pusblish (int typeCrawler)
        //{
        //    var redisMultiplexer = ConnectionMultiplexer.Connect(QT.Entities.Server.RedisDB_Host + ":" + QT.Entities.Server.RedisDB_Port);
        //    var redisDb = new RedisDb(redisMultiplexer.GetDatabase());
        //    var factoryMQ = new ConnectionFactory();
        //    factoryMQ.UserName = QT.Entities.Server.RabbitMQ_User;
        //    factoryMQ.Password = QT.Entities.Server.RabbitMQ_Pass;
        //    factoryMQ.Protocol = Protocols.DefaultProtocol;
        //    factoryMQ.HostName = QT.Entities.Server.RabbitMQ_Host;
        //    factoryMQ.Port = QT.Entities.Server.RabbitMQ_Port;
        //    factoryMQ.RequestedConnectionTimeout = 60;
        //    var connectMQ1 = factoryMQ.CreateConnection();
        //    Consummer consumer1 = new Consummer("1000", connectMQ1, frmInput.queuNameTextBox.Text);
        //    ConfigXPaths config = configXPathAdapter.GetConfigByID(iConfig);
        //    Random rand = new Random();
        //    consumer1.PushBeginLink(iConfig, typeCrawler);
        //    this.configXPathAdapter.UpdateLastPush(iConfig, typeCrawler);
        //    redisDb.SetValueSession(iConfig, RedisDb.RedisField_LastJobAt, DateTime.Now.ToString(RedisDb.Format_DateTime));
        //    consumer1.Dispose();
        //    connectMQ1.Close();
        //}
    }
}
