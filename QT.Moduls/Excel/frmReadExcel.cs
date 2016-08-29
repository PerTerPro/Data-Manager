using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.Excel
{
    public partial class frmReadExcel : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmReadExcel));
        public frmReadExcel()
        {
            InitializeComponent();
        }

        private void simpleButtonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogExcel.InitialDirectory = "c:\\";
            openFileDialogExcel.Filter = "Excel 2003 files (*.xls)|*.xls|Excel 2007-2013 files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialogExcel.FilterIndex = 2;
            openFileDialogExcel.RestoreDirectory = true;

            if (openFileDialogExcel.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    gridControlDataExcel.DataSource = ReadExcel(openFileDialogExcel.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void simpleButtonAction_Click(object sender, EventArgs e)
        {

        }
        private DataTable ReadExcel(string directoryName)
        {
            DataTable dataTable = null;
            string pathOnly = string.Empty;
            string fileName = string.Empty;
            string sql = string.Empty;
            try
            {
                pathOnly = Path.GetDirectoryName(directoryName);
                fileName = Path.GetFileName(directoryName);
                sql = @"SELECT * FROM [" + fileName + "]";
                using (OleDbConnection connection = new OleDbConnection(
                    @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
                    ";Extended Properties=\"Excel 12.0; HDR=Yes; IMEX=2\""))
                {
                    using (OleDbCommand command = new OleDbCommand(sql, connection))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            dataTable = new DataTable();
                            dataTable.Locale = CultureInfo.CurrentCulture;
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("Connect by OleDbConnection fails with directory {0}!", directoryName), ex);
            }
            return dataTable;
        }
    }
}
