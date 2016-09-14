using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.QAComment.Core
{
    public class SqlCommentAdapter
    {
        public static SqlCommentAdapter _SqlCommentAdapter;
        public static SqlCommentAdapter Instance()
        {
            return (_SqlCommentAdapter == null) ? _SqlCommentAdapter = new SqlCommentAdapter() : _SqlCommentAdapter;
        }

        SqlDb _sqldb = new SqlDb(Config.ConnectionSQL);

        public List<Tuple<long, string>> GetListUrlOfSite(long companyId)
        {List<Tuple<long, string>> lstResult = new List<Tuple<long, string>>();
            DataTable tblProduct;
            var page = 1;
            do
            {
                const string query = @"SELECT     ID, DetailUrl
                                        FROM            Product
                                        WHERE        Company = @COmpanyID  AND VALID = 1
                                        ORDER BY ID
                                        OFFSET ((@Page-1)*10000) ROWS
                                        FETCH NEXT 10000 ROWS ONLY
";
                do
                {
                    tblProduct = this._sqldb.GetTblData(query, CommandType.Text, new SqlParameter[]
                {
                    SqlDb.CreateParamteterSQL("@Page", page, SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("@CompanyID", companyId, SqlDbType.BigInt)
                });
                }
                while (tblProduct == null);foreach (DataRow VARIABLE in tblProduct.Rows)
                {
                    lstResult.Add(new Tuple<long, string>(Convert.ToInt64(VARIABLE["ID"]),
                        Convert.ToString(VARIABLE["DetailUrl"])));
                }
                page++;
            } while (tblProduct.Rows.Count > 0 );
            return lstResult;
        }
    }
}
