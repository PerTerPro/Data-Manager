using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websosanh.NotificationSystem.Common.DAL
{
    public class DefaultConnection
    {
        public static string GetConnectionString()
        {
            if (ConfigurationManager.ConnectionStrings["BackupMessageNotification"] == null)
                throw new Exception("ConnectionString BackupMessageNotification has not been configurationed");
            return ConfigurationManager.ConnectionStrings["BackupMessageNotification"].ConnectionString;
        }
    }
}
