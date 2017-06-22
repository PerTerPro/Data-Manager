using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using QT.Entities;

namespace WSS.Service.Report.ProductOnClick.Error.Model
{
    public interface ISettingRepository
    {
        string ConnectionProduct { get; }
        int WorkerCount { get; }
        string RabbitMq { get; }
        string QueueProductClick { get; }
    }

    public class SettingRepository :ISettingRepository
    {

        public string ConnectionProduct
        {
            get { return Common.Obj2String(ConfigurationManager.AppSettings["ConnectionString"]); }
        }

        public int WorkerCount
        {
            get { return Common.Obj2Int(ConfigurationManager.AppSettings["WorkerCount"]); }
        }

        public string RabbitMq
        {
            get { return "rabbitMQ177"; }
        }

        public class CompanyDelivery
        {
            public long CompanyId { get; set; }
            public string DeliveryInfo { get; set; }
        }

        public string QueueProductClick
        {
            get { return @"Product.OnClick"; }
        }
    }
}
