using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.NotificationSystem.Common;

namespace Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    //Console.WriteLine("Input channel name:");
                    string channelName = "";
                    //Console.ReadLine();
                    channelName = "ContentExchange";
                    NotificationProducer noti = new NotificationProducer("rabbitMQ177", channelName, "ContentExchange.Tien.abc", true);
                    Console.WriteLine("Insert a message");
                    string message = Console.ReadLine();
                    noti.PublishMessage(message, 1);
                    Console.WriteLine("Enter number of message want to publish");
                    int x = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < x; i++)
                        noti.PublishMessage("Message " + i);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
