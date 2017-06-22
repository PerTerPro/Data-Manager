using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities.ProductManager
{
     public interface ISettingRepository
    {
         string ConnectionProductSql { get; set; }
         string RabbitMqProduct { get; set; }
    }
}
