using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.LogJob
{
    public partial class FrmLogJobData : Form
    {
        public FrmLogJobData()
        {
            InitializeComponent();
        }
        public void LoadData(long idData)
        {
            if (idData != 0)
            {
                try
                {
                    textEditIDData.Text = idData.ToString();
                    if (checkEditLoadAll.Checked)
                        this.logJobTableAdapter.FillBy_Data(dBLogJob.LogJob, idData);
                    else
                        this.logJobTableAdapter.FillBy_DataAndDatetime(dBLogJob.LogJob, idData, ctrDateRanger1.FromDate, ctrDateRanger1.ToDate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR " + ex);
                }                
            }
        }

        private void simpleButtonViewLog_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang tải dữ liệu...");
            long iddata = Common.Obj2Int64(textEditIDData.Text);
            if (iddata != 0)
                LoadData(iddata);
            else
            {
                MessageBox.Show("ID = 0.......");
                textEditIDData.Focus();
            }
            Wait.Close();    
        }

        private void FrmLogJobData_Load(object sender, EventArgs e)
        {
            this.jobTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.jobTableAdapter.Fill(this.dBLogJob.Job);
            this.tblUserTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.tblUserTableAdapter.Fill(this.dBLogJob.tblUser);
            this.logJobTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            #region
            DataTable dtTypeData = new DataTable();
            dtTypeData.Columns.Add("TypeData", typeof(string));
            dtTypeData.Columns.Add("IDTypeData", typeof(int));
            DataRow dr = dtTypeData.NewRow();
            dr["TypeData"] = "Không xác định";
            dr["IDTypeData"] = JobTypeData.KhongXacDinh;
            dtTypeData.Rows.Add(dr);
            DataRow dr1 = dtTypeData.NewRow();
            dr1["TypeData"] = "Company";
            dr1["IDTypeData"] = JobTypeData.Company;
            dtTypeData.Rows.Add(dr1);
            DataRow dr2 = dtTypeData.NewRow();
            dr2["TypeData"] = "Product";
            dr2["IDTypeData"] = JobTypeData.Product;
            dtTypeData.Rows.Add(dr2);
            repositoryItemLookUpEditTypeData.DataSource = dtTypeData;
            #endregion
        }

        private void textEditIDData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButtonViewLog_Click(null, null);
            }
        }
        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            string caption = info.Column.Caption;
            if (info.Column.Caption == string.Empty)
                caption = info.Column.ToString();
            info.GroupText = string.Format("{0} : {1} (count= {2})", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle));
        }

        private bool expandgroup = true;
        private void simpleButtonExpandGroup_Click(object sender, EventArgs e)
        {
            if (expandgroup)
            {
                gridView1.CollapseAllGroups();
                expandgroup = false;
            }
            else
            {
                gridView1.ExpandAllGroups();
                expandgroup = true;
            }
        }
    }
}
