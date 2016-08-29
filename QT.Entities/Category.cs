using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QT.Entities
{
    public class Category
    {
         //ID, Name, Levels, ParentID, Description
        private DB.ListClassificationDataTable _dt;
        private DBTableAdapters.ListClassificationTableAdapter _adt;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Levels { get; set; }
        public int ParentID { get; set; }

        public Category()
        {
            _adt = new DBTableAdapters.ListClassificationTableAdapter();
            _dt = new DB.ListClassificationDataTable();
            _adt.Connection.ConnectionString = Server.ConnectionString;
        }
        public void SelectOne(int id)
        {
            ID = id;
            if (_adt.Connection.State == ConnectionState.Closed) _adt.Connection.Open();
            _adt.FillBy_SelectOne(_dt, ID);
            _adt.Connection.Close();
            if (_dt.Rows.Count > 0)
            {
                Name = _dt.Rows[0]["Name"].ToString();
                Description = _dt.Rows[0]["Description"].ToString();
                ParentID = Common.Obj2Int(_dt.Rows[0]["ParentID"].ToString());
                Levels = Common.Obj2Byte(_dt.Rows[0]["Levels"].ToString());
            }
        }
        ~Category()
        {
            _dt.Dispose();
            _adt.Connection.Close();
            _adt.Dispose();
        }
    }
}
