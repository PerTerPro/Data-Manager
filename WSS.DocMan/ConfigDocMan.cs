using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;

namespace WSS.DocMan
{
    public class ConfigDocMan 
    {
        public static string KeyRabbitMqWaitDl = "rabbitMq_DocMan_DL";
        public static string QueueDl = "DocMan.WaiDL";

        public static string ConnectionSql =
            @"Data Source=192.168.100.178;Initial Catalog=Docs;Persist Security Info=True;User ID=sa;Password=123456a@";
    }
}
