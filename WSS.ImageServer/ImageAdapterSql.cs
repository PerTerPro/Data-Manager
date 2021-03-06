﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using StackExchange.Redis;
using Websosanh.Core.Drivers.Redis;

namespace WSS.ImageServer
{
    public class ImageAdapterSql
    {
        private ProductAdapter _productAdapter = null;
        private ILog log = LogManager.GetLogger(typeof (ImageAdapterSql));
        private IDatabase _database = null;

        public HashSet<long> GetProductIds()
        {
            HashSet<long> hs = new HashSet<long>();
            foreach (var VARIABLE in this._database.SetScan("product_valid","*",10000))
            {
                hs.Add(Common.Obj2Int64(VARIABLE));
                if (hs.Count%10000 == 0) log.Info(string.Format("Loaded {0}", hs.Count));
            }
            return hs;
        }


        public SqlDb GetSqlDb()
        {
            return this._productAdapter.GetSqlDb();
        }

        public ImageAdapterSql()
        {
            _productAdapter = new ProductAdapter(new SqlDb(ConfigImbo.ConnectionProduct));
            _database = RedisManager.GetRedisServer("RedisImbo").GetDatabase(0);
        }
        public static ImageAdapterSql Instance()
        {
           return  new ImageAdapterSql();
        }

        public List<long> GetCompanyIdByDomain(List<string> domain)
        {
            DataTable tbl = this._productAdapter.GetSqlDb().GetTblData(
                @"
select a.ID
from Company a 
where a.Status = 1
order by a.TotalProduct asc
"
                , CommandType.Text, null);
            return (from DataRow variable in tbl.Rows select Convert.ToInt64(variable["ID"])).ToList();
        }

        public bool CheckExitProduct(long productId)
        {
            return this.GetSqlDb().GetTblData("Select Id From Product Where Id = @Id", CommandType.Text, new[]
            {
                SqlDb.CreateParamteterSQL("Id", productId, SqlDbType.BigInt)
            }).Rows.Count > 0;
        }

        public string GetImageId(long p)
        {
            DataTable tbl = this.GetSqlDb().GetTblData(string.Format(@"Select ImageId From Product Where Id = {0}", p), CommandType.Text, null);
            if (tbl.Rows.Count == 0) return "";
            else return QT.Entities.Common.Obj2String(tbl.Rows[0]["ImageId"]);
        }

        internal void UpdateImboProcess(long productId, string imageId, int with, int height)
        {
            bool bOK = this.GetSqlDb().RunQuery("Update Product Set ImageId = @ImageId, Valid = 1, ImageWidth=@ImageWidth, ImageHeight = @ImageHeight where Id = @Id", CommandType.Text, new[]
            {
                SqlDb.CreateParamteterSQL("ImageId", imageId, SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("Id", productId, SqlDbType.BigInt),
                SqlDb.CreateParamteterSQL("ImageWidth", with, SqlDbType.Int),
                SqlDb.CreateParamteterSQL("ImageHeight", height, SqlDbType.Int)

            });
        }

        public void ProcessAddProduct()
        {
            List<long> lst = new List<long>();
            this.GetSqlDb().ProcessDataTableLarge("Select Id From Product Where Valid = 1 Order By Id", 10000, (row,iRow) =>
            {
                lst.Add(Common.Obj2Int64(row["Id"]));
                if (lst.Count > 10000)
                {
                    _database.SetAdd("product_valid", lst.Select(variable => (RedisValue) variable).ToArray());
                    lst.Clear();
                }
                return true;
            });

        }
    }
}
