using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using WSS.PropertiesMerchantMapToRoot.Entity;
using System.Configuration;
using StackExchange.Redis;
using Websosanh.Core.Drivers.Caching;
using Websosanh.Core.Drivers.Redis;

namespace WSS.PropertiesMerchantMapToRoot
{
    public partial class FrmProperties : Form
    {
        private IDatabase _database = null;
        private CacheServer _cacheMan;
        private long _rootId;
        private string _connectionString;
        public FrmProperties(long rootId)
        {
            this._rootId = rootId;
            this._connectionString = ConfigurationManager.AppSettings["connectionString"];
            this._database = RedisManager.GetRedisServer("redisPropertiesProduct").GetDatabase(1);
            this._cacheMan = CacheManager.GetCacheServer("redisPropertiesProduct");
            
            InitializeComponent();


            repositoryItemCheckEditValid.EditValueChanged += repositoryItemCheckEditValid_EditValueChanged;
        }

        void repositoryItemCheckEditValid_EditValueChanged(object sender, EventArgs e)
        {
            int ID = Common.CommonConvert.Obj2Int(this.gridView2.GetRowCellValue(this.gridView2.FocusedRowHandle, "ID"));
            bool check = Common.CommonConvert.Obj2Bool(this.gridView2.GetRowCellValue(this.gridView2.FocusedRowHandle, "Valid"));
            if (check)
            {
                check = false;
                //Do SomeThings
            }
            else
            {
                check = true;
                //Do SomeThings
            }
        }

        private void FrmProperties_Load(object sender, EventArgs e)
        {
            string Query = @"select a.ProductID,
                                    a.ID,
                                    a.PropertiesID,
                                    a.PropertiesGroupID,
                                    a.PropertiesValueID,
                                    b.Name,
                                    c.Value,
                                    b.Unit,
                                    a.Valid
                                     from Product_Properties a
                                     inner join Properties b 
                                     on a.PropertiesID = b.ID
                                     inner join PropertiesValue c 
                                     on a.PropertiesValueID = c.ID where a.ProductID = @ProductID order by a.STT";
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                Dictionary<string, string> dicRootProperties = new Dictionary<string, string>();
                var lstPropertyRoot = db.Query<Property>(Query, new { ProductID = _rootId }).ToList();
                foreach (var item in lstPropertyRoot)
                {
                    dicRootProperties.Add(item.Name, item.Value);
                }
                var lstProduct = db.Query<Product>("Select ID from product where ProductID = @ProductID", new { ProductID = _rootId }).ToList();
                foreach (var product in lstProduct)
                {
                    var lstPropertyProduct = _cacheMan.Get<List<KeyValuePair<string, string>>>("prs:" + product.ID.ToString(), true);
                    if (lstPropertyProduct != null)
                    {
                        foreach (var productProperties in lstPropertyProduct)
                        {
                            if (!dicRootProperties.ContainsKey(productProperties.Key))
                            {
                                lstPropertyRoot.Add(new Property { Valid = false, Name = productProperties.Key, Value = productProperties.Value });
                            }
                        }
                    }

                }

                gridControlProperties.DataSource = lstPropertyRoot;
                dicRootProperties.Clear();
            }
        }
    }
}
