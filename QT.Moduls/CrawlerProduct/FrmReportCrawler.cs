using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmReportCrawler : Form
    {
        private SqlDb sql = new SqlDb(QT.Entities.Server.ConnectionString);
        private DataTable tblReport = null;
        private DataTable tblCompany = null;

        public FrmReportCrawler()
        {
            InitializeComponent();

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string proc = comboBox1.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedIndex == 5 || comboBox1.SelectedIndex == 6)
                {
                    if (!string.IsNullOrEmpty(txtCompanyID.Text))
                    {
                        string Domain = txtCompanyID.Text;
                        tblCompany = sql.GetTblData("Select ID from Company where Domain = @Domain or ID = " + Domain + " and Status = 1", CommandType.Text, new SqlParameter[]{
                            sql.CreateParamteter("@Domain",Domain,SqlDbType.NVarChar)
                        });

                        if (tblCompany != null && tblCompany.Rows.Count > 0)
                        {
                            long CompanyID = QT.Entities.Common.Obj2Int64(tblCompany.Rows[0]["ID"]);
                            tblReport = sql.GetTblData(proc, CommandType.StoredProcedure, new SqlParameter[] { 
                                sql.CreateParamteter("@CompanyID",CompanyID,SqlDbType.BigInt)
                            });
                            gridControlReport.DataSource = tblReport;

                        }
                        else
                        {
                            MessageBox.Show("Domain ko đúng hoặc chưa có trong hệ thống!");
                        } 
                    }
                    else
                    {
                        MessageBox.Show("Bạn phải nhập ID công ty để thực hiện");
                    }
                }
                else
                {
                    txtCompanyID.Enabled = false;
                    tblReport = sql.GetTblData(proc, CommandType.StoredProcedure, new SqlParameter[] { });
                    gridControlReport.DataSource = tblReport;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridControlReport.DataSource = null;
            gridView1.Columns.Clear();
            if (comboBox1.SelectedIndex == 5 || comboBox1.SelectedIndex == 6)
            {
                txtCompanyID.Enabled = true;
                
            }
            else
            {
                txtCompanyID.Enabled = false;
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
