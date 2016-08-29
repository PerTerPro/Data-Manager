using QT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls
{
    public class Config_HaravanBizweb
    {
        public long CompanyID { set; get; }
        public string ConfigLink { set; get; }
        public string ConfigUtmSource { set; get; }


        public static Config_HaravanBizweb GetDefaultConfig()
        {
            return new Config_HaravanBizweb()
            {
                ConfigLink = "{0}products/{1}",
                ConfigUtmSource = "?utm=websosanh"
            };
        }
        public static Config_HaravanBizweb GetConfig(long companyid)
        {
            Config_HaravanBizweb config = Config_HaravanBizweb.GetDefaultConfig();
            try
            {
                DBTableAdapters.Config_HaravanBizwebTableAdapter configAdapter = new DBTableAdapters.Config_HaravanBizwebTableAdapter();
                configAdapter.Connection.ConnectionString = Server.ConnectionString;
                DB.Config_HaravanBizwebDataTable configTable = new DB.Config_HaravanBizwebDataTable();
                configAdapter.FillBy_CompanyID(configTable,companyid);
                if (configTable.Rows.Count > 0)
                {
                    config.CompanyID = companyid;
                    config.ConfigLink = configTable.Rows[0]["ConfigLink"].ToString();
                    config.ConfigUtmSource = configTable.Rows[0]["ConfigUtmSource"].ToString();
                }
            }
            catch (Exception)
            {
            }
            return config;
        }
    }
}
