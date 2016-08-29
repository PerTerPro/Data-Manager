using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QT.Entities
{
    public class Classification
    {
        
        private DB.ClassificationDataTable _dt;
        private DBTableAdapters.ClassificationTableAdapter _adt;
        public long ID { get; set; }
        public string Name { get; set; }
        public int IDCategory { get; set; }

        public Classification()
        { 
             _adt = new DBTableAdapters.ClassificationTableAdapter();
            _dt = new  DB.ClassificationDataTable();
            _adt.Connection.ConnectionString = Server.ConnectionString;
        }
        public void SelectOne(long id)
        {
            ID = id;
            if (_adt.Connection.State == ConnectionState.Closed) _adt.Connection.Open();
            _adt.FillBy_SelectOne(_dt, ID);
            _adt.Connection.Close();
            if (_dt.Rows.Count > 0)
            {
                Name = _dt.Rows[0]["Name"].ToString();
                IDCategory = Common.Obj2Int(_dt.Rows[0]["IDCategory"].ToString());
            }
        }
        ~Classification()
        {
            _dt.Dispose();
            _adt.Connection.Close();
            _adt.Dispose();
        }
    }
}
