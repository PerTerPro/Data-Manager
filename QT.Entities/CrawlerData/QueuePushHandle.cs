

using QT.Entities.Data;
using QT.Entities.Model.MQTask;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS_QueuPush
{
    public class QueuePushHandle
    {
        public SqlDb sqlDb = null;

        RabbitMQ.Client.ConnectionFactory factory;
        RabbitMQ.Client.IConnection connection;
        RabbitMQ.Client.IModel chanel;

        ~QueuePushHandle()
        {
            try
            {
                chanel.Close();
                connection.AutoClose = true;
            }
            catch (Exception ex)
            {

            }
        }

        public QueuePushHandle()
        {
            sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
            factory = new RabbitMQ.Client.ConnectionFactory()
            {
                HostName = QT.Entities.Server.RabbitMQ_Host,
                Port = QT.Entities.Server.RabbitMQ_Port,
                UserName = QT.Entities.Server.RabbitMQ_User,
                Password = QT.Entities.Server.RabbitMQ_Pass
            };
            connection = factory.CreateConnection();
            chanel = connection.CreateModel();
        }

     

     

        public void PushTaskCrawReloadProductByProduct(long productID)
        {

        }


    }
}