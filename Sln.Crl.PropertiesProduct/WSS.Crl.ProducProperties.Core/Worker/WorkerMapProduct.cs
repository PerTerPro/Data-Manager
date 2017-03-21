using log4net;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.Caching;
using Websosanh.Core.Drivers.Redis;
using WSS.LibExtra;

namespace WSS.Crl.ProducProperties.Core.Worker
{
    public class WorkerMapProduct
    {
        private static ILog log = LogManager.GetLogger(typeof(WorkerMapProduct));
        private IDatabase database = null;
        private CacheServer _cacheMan;
        private readonly SqlDb sqldb = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        private readonly SqlDb sqldbProperties = new SqlDb("Data Source=192.168.100.178;Initial Catalog=CrlProductPropertiesWss;Persist Security Info=True;User ID=sa;Password=123456a@;connection timeout=200");

        public void MapData(string domain)
        {
            this.database = RedisManager.GetRedisServer("redisPropertiesProduct").GetDatabase(1);
            this._cacheMan = CacheManager.GetCacheServer("redisPropertiesProduct");

            int i = 0;
            string PropertyName = "";
            string PropertyValue = "";
            long PropertyID = 0;
            long companyID = LibExtra.CommonConvert.Obj2Int64(this.sqldb.GetTblData(string.Format("Select ID from Company where Domain = '{0}'", domain)).Rows[0]["ID"]);
            this.sqldb.ProcessDataTableLarge(string.Format("select ID,ClassificationID from product where company = {0} order by ID", companyID), 1000, (obj, iRow) =>
            {
                long ProductID = CommonConvert.Obj2Int64(obj["ID"]);
                long ClassificationID = CommonConvert.Obj2Int64(obj["ClassificationID"]);

                string ClassificationName = this.sqldb.GetTblData(string.Format("Select Name from Classification where ID = {0}", ClassificationID)).Rows[0]["Name"].ToString();
               
                var lstProperties = _cacheMan.Get<List<KeyValuePair<string, string>>>("prs:" + ProductID, true);
                if (lstProperties != null && lstProperties.Count > 0)
                {
                    foreach (var item in lstProperties)
                    {
                        PropertyName = ClassificationName + ":" + item.Key.ToString();
                        PropertyValue = item.Value.ToString();
                        PropertyID = CommonConvert.CrcProductID(PropertyName);
                    }
                    string querytest = string.Format("Insert into PropertyItem (PropertyID, ProductID, Value) values ({0},{1},N'{2}')", PropertyID, ProductID, PropertyValue);
                    sqldbProperties.RunQuery(string.Format("Insert into Category (ID, Name, CompanyID) values ({0},N'{1}',{2})", ClassificationID, ClassificationName, companyID), CommandType.Text, new System.Data.SqlClient.SqlParameter[] { });
                    sqldbProperties.RunQuery(string.Format("Insert into Properties (ID,CategoryID, Name, CompanyID) values ({0},{1},N'{2}',{3})", PropertyID, ClassificationID, PropertyName, companyID), CommandType.Text, new System.Data.SqlClient.SqlParameter[] { });
                    sqldbProperties.RunQuery(string.Format("Insert into Product_PropertyCategory (ID, CompanyId, Name,Property_Id,CategoryID) values ({0},{1},N'{2}',{3},{4})", ProductID, companyID, PropertyName, PropertyID, ClassificationID), CommandType.Text, new System.Data.SqlClient.SqlParameter[] { });
                    sqldbProperties.RunQuery(querytest, CommandType.Text, new System.Data.SqlClient.SqlParameter[] { });
                }
                i++;
                log.InfoFormat("{0} {1}", i,ProductID);
                return true;
            });
        }
    }
}
