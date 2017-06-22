using System.Data.SqlClient;
using System.Linq;
using Dapper;
using QT.Moduls.Company;

namespace Websosanh.Datafeed.Imp
{
    public interface IDataFeedConfigRepository
    {
        DatafeedConfig Get(long companyId);
    }
    public class DatafeedConfigRepository:IDataFeedConfigRepository
    {
        SqlConnection _sqlConnection = new SqlConnection(@"Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");

        public DatafeedConfig Get(long companyId)
        {
            DatafeedConfig defaultConfig = DatafeedConfig.GetDefaultXMLDatafeedConfig();
            string query = @"
Select * 
From  DatafeedConfig
Where CompanyId = @CompanyId
";
            var dataFeed = _sqlConnection.Query<DatafeedConfig>(query, new {@CompanyId = companyId});
            return dataFeed.SingleOrDefault();
        }




    }
}
