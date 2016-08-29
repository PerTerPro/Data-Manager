using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls
{
    public partial class FrmFixPhone : Form
    {
        SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);
        public FrmFixPhone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            DataTable tbl = sqlDb.GetTblData(@"SELECT a.ID, b.Id as CompanyAddress_ID, a.Website, a.Domain, LTRIM(RTRIM(ISNULL(a.Phone, ''))) AS PhoneInCompany, LTRIM(RTRIM(ISNULL(b.Phone,''))) AS PhoneInCompanyAddress, CONVERT(BIT,1) AS Success
            , TotalProduct
    FROM Company a 
LEFT JOIN Company_Address b on a.ID = b.CompanyID
WHERE 
(LTRIM(RTRIM(ISNULL(a.Phone, '')))!= '' 
OR 
LTRIM(RTRIM(ISNULL(b.Phone,'')))  != '')
AND TotalProduct>0", CommandType.Text, null);

            foreach(DataRow rowInfo in tbl.Rows)
            {
                string strPhone = QT.Entities.Common.Obj2String(rowInfo["PhoneInCompany"]);
                if (!CheckRegexPhone(strPhone))
                {
                    rowInfo["Success"] = false;
                    continue;
                }

                strPhone = QT.Entities.Common.Obj2String(rowInfo["PhoneInCompanyAddress"]);
                if (!CheckRegexPhone(strPhone))
                {
                    rowInfo["Success"] = false;
                    continue;
                }

            }

            this.gridControl1.DataSource = tbl;
        }

        private void FrmFixPhone_Load(object sender, EventArgs e)
        {
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(DrawCell);
        }

        private void DrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if ( e.Column.FieldName=="PhoneInCompany"||e.Column.FieldName=="PhoneInCompanyAddress")
            {
                
            }
        }

        private bool CheckRegexPhone(string strPhone)
        {
            string phone = strPhone.Replace(" ", "").Replace(".", "");
            string[] arPhone = phone.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string aPhone in arPhone)
            {
                if (!IsPhoneSuccess(aPhone)) return false;
            }
            return true;
        }

        private bool IsPhoneSuccess(string aPhone)
        {
            if (!Regex.IsMatch(aPhone, @"[\d\.\)\(\-\+]*")) return false;
            if (aPhone.Length > 8 && (Regex.IsMatch(aPhone, @"^+84[\d]+$") ||
                Regex.IsMatch(aPhone, @"^84[\d]+$") ||
                Regex.IsMatch(aPhone, @"^\(\d\d\)[\d]+$") ||
                Regex.IsMatch(aPhone, @"^[\d]+$"))) return true;
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }

        private void SaveData()
        {
            string query = "update company set phone = @phone where id = @company_id; update company_address set phone = @phone_2 where id = @company_address_id";
            DataTable tblCompanyPhone = this.gridControl1.DataSource as DataTable;
            DataTable tblCompanyPhoneChange = tblCompanyPhone.GetChanges();
            foreach(DataRow rowCompany in tblCompanyPhoneChange.Rows)
            {
                sqlDb.RunQuery(query, CommandType.Text, new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("phone_1",rowCompany["PhoneInCompany"].ToString(),SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("phone_2",rowCompany["PhoneInCompanyAddress"].ToString(),SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("company_id",rowCompany["ID"].ToString(),SqlDbType.BigInt),
                    SqlDb.CreateParamteterSQL("company_address_id",rowCompany["CompanyAddress_ID"].ToString(),SqlDbType.BigInt)
               });
            }
        }

        private void btnExportExcell_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                this.gridControl1.ExportToXlsx(saveFileDialog.FileName);
                System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
        }
    }
}
