using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QT.Users
{
     public class ChamCongUser
    {
        private DB.UserJobDataTable dtJob;
        private DBTableAdapters.UserJobTableAdapter adtJob;
        private DB.tblUserDataTable dtUser;
        private DBTableAdapters.tblUserTableAdapter adtUser;

        public ChamCongUser()
        {
            dtJob = new DB.UserJobDataTable();
            adtJob = new DBTableAdapters.UserJobTableAdapter();
            dtUser = new DB.tblUserDataTable();
            adtUser = new DBTableAdapters.tblUserTableAdapter();
            adtUser.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            adtJob.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
        }

        public bool InsertCongViec(int UserID, int jobType, string comment, DateTime dateAdd, int vote, long idCompany)
        {
            bool r = false;
            try
            {
                adtJob.Insert(
                    UserID,
                    jobType,
                    comment,
                    DateTime.Now,
                    vote,
                    idCompany);
                r = true;
            }
            catch (Exception)
            {
            }
            return r;
        }

        public int GetIDUserByIDManagerType(int IDManagerType)
        {
            int r = 0;
            try
            {
                adtUser.FillBy_IDTypeManager(dtUser, IDManagerType);
                if (dtUser.Rows.Count == 1)
                {
                    r = QT.Entities.Common.Obj2Int(dtUser.Rows[0]["ID"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
            }
            return r;
        }

        ~ChamCongUser()
        {
            adtJob.Dispose();
            dtJob.Dispose();
            adtUser.Dispose();
            dtUser.Dispose();
        }
    }
     public static class JobNhapLieuStatus
     {
         public static int NhapMoi = 1;
         public static int DaNhapXong = 2;
         public static int DaDuyet = 3;
         public static int BiLoi = 4;
         public static int BiThieu = 5;
         public static int GiaiPhong = 6;
         public static int FixLoi = 7;
         public static int DuyetAnh = 8;
         public static int NhanDienSanPham = 9;
     }

}
