using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WSS.Service.Report.ProductOnClick.Error.Object
{
    public class Company
    {
        public long Id { get; set; }
        public string Domain { get; set; }
    }
}
