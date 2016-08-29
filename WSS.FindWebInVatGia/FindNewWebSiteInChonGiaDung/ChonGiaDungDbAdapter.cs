using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.FindWebInVatGia.FindNewWebSiteInChonGiaDung
{
    public class ChonGiaDungDbAdapter
    {
        SqlDb sqlConnection = new SqlDb("Data Source=42.112.28.93;Initial Catalog=QT_2;Persist Security Info=True;User ID=wss_price;Password=HzlRt4$$axzG-*UlpuL2gYDu;connection timeout=200");
        internal void SaveLink(string link, int typeLink)
        {
           long ID = QT.Entities.Common.CrcProductID(link);
           bool bOK = sqlConnection.RunQuery("If Not Exists (Select ID From ChonGiaDung Where ID = @ID) Begin Insert Into ChonGiaDung (ID, UrlDetail, TypeLink) Values (@ID, @UrlDetail, @TypeLink) End ",
               System.Data.CommandType.Text, new SqlParameter[]{
                   SqlDb.CreateParamteterSQL("@ID",ID,System.Data.SqlDbType.BigInt),
                   SqlDb.CreateParamteterSQL("@UrlDetail",link, System.Data.SqlDbType.NVarChar),
                   SqlDb.CreateParamteterSQL("@TypeLink",typeLink,System.Data.SqlDbType.Int)
               });
        }

        internal System.Data.DataTable GetCatLink()
        {
            return this.sqlConnection.GetTblData("select ID, UrlDetail from ChonGiaDung where TypeLink = 0", System.Data.CommandType.Text,
                new SqlParameter[]{
                });
        }

        internal System.Data.DataTable GetCompanyLink()
        {
            return this.sqlConnection.GetTblData("select ID, UrlDetail from ChonGiaDung where TypeLink = 1", System.Data.CommandType.Text,
                new SqlParameter[]{
                });
        }

     
    }
}
