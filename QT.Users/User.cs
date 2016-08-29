using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QT.Users
{
    public class User
    {
        public static string UserName
        {
            set;
            get;
        }
        public static int UserID
        {
            set;
            get;
        }
        public static List<int> PermisionID
        {
            set;
            get;
        }
    }
    public static class Permission
    {
        public static int ADMIN = 1;
        public static int ThietLapQuyenHeThong = 2;
        public static int ThietLapThuocTinhSanPham = 3;
        public static int PhanCongNhapDuLieu = 4;
        public static int XemBaoCaoConfigWeb = 6;
        public static int ConfigWeb = 7;
        public static int NhapSanPhamGoc = 9;
        public static int PhanTichSanPhamGoc = 8;
        public static int ThietLapSanPham = 10;
        public static int NhapSPMarketing = 11;
    }
    public class User_Permission
    {
        private DBTableAdapters.User_PermisionTableAdapter adt;
        private DB.User_PermisionDataTable dt;
        public User_Permission()
        {
            adt = new DBTableAdapters.User_PermisionTableAdapter();
            dt = new DB.User_PermisionDataTable();
            adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
        }

        ~User_Permission()
        {
            adt.Dispose();
        }

        public Boolean CheckPermission(int IDUser, int IdPermission)
        {
            bool r = false;
            try
            {
                adt.FillBy_IDUser_IDPermission(dt, IDUser, IdPermission);
                if (dt.Rows.Count > 0)
                    r = true;
            }
            catch (Exception)
            {
                r = false;
            }
            return r;
        }
    }
}
