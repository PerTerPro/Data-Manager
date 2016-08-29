
using log4net;
using QT.Entities.MyConverter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;

namespace QT.Entities.Data
{
    public class SqlDb
    {
        public static char[] arSplit = new char[] {';', '\n'};

        private static readonly ILog log = LogManager.GetLogger(typeof (SqlDb));
        private static SqlDb instance;
        private static object syncRoot = new Object();

        public bool Open()
        {
            try
            {
                this.connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public SqlDb(string connectionString)
        {
            this.connection = new SqlConnection();
            this.connection.ConnectionString = connectionString;
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
            this.sqlAdatpter = new SqlDataAdapter();
        }

        public static SqlDb Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            log.Info("New sql instance");
                            instance = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
                        }
                    }
                }
                return instance;
            }
        }

        /*************************************PAGE************************************/


        private String toString(ISet<String> set)
        {
            return string.Join(";", set);
        }



        public DataTable GetTblData(string query)
        {
            return this.GetTblData(query, CommandType.Text, null);
        }



        public DataTable GetTblData(string query, CommandType commandType, SqlParameter[] arParameter, SqlConnection connection = null, bool WaitToRun = false, int iTimeOut = 0)
        {
            while (true)
            {
                try
                {
                    this.sqlAdatpter.SelectCommand = this.command;
                    this.command.CommandText = query;
                    this.command.CommandType = commandType;
                    this.command.Parameters.Clear();
                    if (iTimeOut > 0) this.command.CommandTimeout = iTimeOut;
                    if (arParameter != null && arParameter.Count() > 0)
                        this.command.Parameters.AddRange(arParameter);
                    DataTable tbl = new DataTable();
                    this.sqlAdatpter.Fill(tbl);
                    return tbl;
                }
                catch (ThreadAbortException ex01)
                {
                    return null;
                }
                catch (Exception ex)
                {
                    log.Error("Error run sql:" + ex.Message + query);
                    if (WaitToRun == false) return null;
                    else Thread.Sleep(10000);
                }
            }
        }

        public SqlDb()
        {
            InitConnect();
        }

        ~SqlDb()
        {

        }

        public void InitConnect()
        {
            this.connection = new SqlConnection();
            this.sqlAdatpter = new SqlDataAdapter();
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
        }

        public SqlConnection connection;
        private SqlDataAdapter sqlAdatpter;
        private SqlCommand command;

        public IDataReader GetDataReader(string query, CommandType commandType, SqlParameter[] arPara)
        {
            this.command.CommandType = commandType;
            this.command.CommandText = query;
            this.command.Parameters.Clear();
            this.command.Parameters.AddRange(arPara);
            if (this.command.Connection.State == ConnectionState.Closed)
            {
                this.command.Connection.Open();
            }
            return this.command.ExecuteReader();
        }

        public bool RunQuery(string query, CommandType commandType, SqlParameter[] arPara, bool WaiRunOK = false, int TryRun = 0)
        {
            int iRun = 0;
            while (true)
            {
                try
                {
                    this.command.CommandType = commandType;
                    this.command.CommandText = query;
                    this.command.Parameters.Clear();
                    if (arPara != null)
                        this.command.Parameters.AddRange(arPara);
                    if (this.command.Connection.State == ConnectionState.Closed)
                    {
                        this.command.Connection.Open();
                    }
                    this.command.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == -2)
                    {
                        log.Error(ex.Message);
                        iRun++;
                        if (WaiRunOK == false && iRun >= TryRun) return false;
                    }
                    else
                    {
                        log.Info(ex.Message + ex.StackTrace + query + Common.ArParaToString(arPara));
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    if (!WaiRunOK)
                    {
                        log.ErrorFormat("Exception sql run" + ex.Message + ex.StackTrace + command.CommandText);
                        return false;
                    }
                    else
                    {
                        Thread.Sleep(10000);
                    }
                }
            }
        }


        public SqlParameter CreateParamteter(string namePara, object valueType, SqlDbType type)
        {
            SqlParameter para = new SqlParameter();
            para.ParameterName = namePara;
            para.SqlDbType = type;
            para.SqlValue = valueType;
            return para;
        }

        public static SqlParameter CreateParamteterSQL(string namePara, object valueType, SqlDbType type)
        {
            SqlParameter para = new SqlParameter();
            para.ParameterName = namePara;
            para.SqlDbType = type;
            para.SqlValue = valueType;
            return para;
        }




        public string GetConnection()
        {
            if (connection == null) return "";
            else return connection.ConnectionString;
        }


        public void SetConnection(string connectionString)
        {
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.ConnectionString = connectionString;
        }


        public IDataReader GetReader(string p)
        {
            command.CommandText = p;
            command.CommandType = CommandType.Text;
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {

                }
            }
            return command.ExecuteReader();
        }

        public static DateTime MinDateDb = new DateTime(1990, 1, 1);

        public DateTime GetCurrent()
        {
            return Convert.ToDateTime(this.GetTblData("SELECT a = GETDATE()").Rows[0][0]);
        }

        internal void CloseConnection()
        {
            if (this.connection.State == ConnectionState.Open) this.connection.Close();
        }





    }
}