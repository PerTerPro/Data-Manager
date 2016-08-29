using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.NotificationSystem.Common;

namespace Websosanh.NotificationSystem.WriteMssToSQL
{
    static class Program
    {
        static void Main()
        {
            Worker w = new Worker();
            w.Run();
            Console.ReadLine();
        }
    }
}
