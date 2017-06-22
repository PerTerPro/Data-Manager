using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Ninject;

namespace QT.Entities
{
    public interface ISettingRepository
    {
        string ConnectionProduct { get; }
        int WorkerCount { get; }
        string RabbitMq { get;  }
        string QueueProductClick { get; }
    }

    public class SettingRepository : ISettingRepository
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

    public interface ICompanyDeliveryRepository
    {
        void Upsert(SettingRepository.CompanyDelivery companyDelivery);
    }


    public class CompanyDeliveryRepository : ICompanyDeliveryRepository
    {
        SqlConnection _sqlConnection;

        public CompanyDeliveryRepository(ISettingRepository settingRepository)
        {
            _sqlConnection = new SqlConnection(settingRepository.ConnectionProduct);
        }

        public void Upsert(SettingRepository.CompanyDelivery companyDelivery)
        {
            string query = @"
If Not Exists (Select Id From Company_Delivery Where CompanyId = @CompanyId) 
Begin
End

Update Company_Delivery
Set DeliveryInfo = @DeliveryInfo
Where CompanyId = @CompanyId

";

            _sqlConnection.Execute(query, new
            {
                @DeliveryInfo = companyDelivery.DeliveryInfo,
                @CompanyId = companyDelivery.CompanyId
            });
        }
    }

}
