using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QT.Entities.Data
{
    public class RabbitMQCreator
    {
        public static IConnection CreateConnection()
        {
            int iCount = 0;
            while (true)
            {
                try
                {
                    var factoryMQ = new ConnectionFactory();

                    factoryMQ.AutomaticRecoveryEnabled = true;
                    factoryMQ.NetworkRecoveryInterval = new TimeSpan(0, 10, 0);
                    factoryMQ.UserName = QT.Entities.Server.RabbitMQ_User;
                    factoryMQ.Password = QT.Entities.Server.RabbitMQ_Pass;
                    factoryMQ.Protocol = Protocols.DefaultProtocol;
                    factoryMQ.HostName = QT.Entities.Server.RabbitMQ_Host;
                    factoryMQ.Port = QT.Entities.Server.RabbitMQ_Port;
                    factoryMQ.RequestedConnectionTimeout = 60;
                    factoryMQ.AutomaticRecoveryEnabled = true;
                    var connectMQ1 = factoryMQ.CreateConnection();

                    return connectMQ1;
                }
                catch (Exception ex)
                {
                    if (iCount < 2)
                    {
                        iCount++;
                        Thread.Sleep(1000);
                    }
                    else throw ex;
                }
            }
        }

        public static ConnectionFactory GetFactory()
        {
            var factoryMQ = new ConnectionFactory();
            factoryMQ.UserName = QT.Entities.Server.RabbitMQ_User;
            factoryMQ.Password = QT.Entities.Server.RabbitMQ_Pass;
            factoryMQ.Protocol = Protocols.DefaultProtocol;
            factoryMQ.HostName = QT.Entities.Server.RabbitMQ_Host;
            factoryMQ.Port = QT.Entities.Server.RabbitMQ_Port;
            factoryMQ.RequestedConnectionTimeout = 60;
            return factoryMQ;
        }
    }
}
