using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSS_QueuPush;

namespace QueuePush
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = WSS.ManageConnectStatic.ManagerConnect.Instance().RabbitMQ_QueueTask;
            for (int i = 0; i < 1000; i++)
            {
                QueuePushHandle f = new QueuePushHandle();
                f.PushTestNewProduct();
            }
        }
    }
}
