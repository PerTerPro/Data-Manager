using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;

namespace QT.Users
{
    public partial class ReportConfigWebsite : QT.Entities.frmBase
    {
        public ReportConfigWebsite()
        {
            InitializeComponent();
        }
        string user = "";

        private void ReportConfigWebsite_Load(object sender, EventArgs e)
        {
            this.viewConfigWebTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tblUserTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tblUserTableAdapter.Fill(this.dB.tblUser);
        }

        private void btViewAll_Click(object sender, EventArgs e)
        {
            user = "All";
            this.viewConfigWebTableAdapter.FillBy_DateRange(this.dB.ViewConfigWeb, this.ctrDateRanger1.FromDate, ctrDateRanger1.ToDate);
            this.gridView1.ExpandAllGroups();
        }

        private void btView_Click(object sender, EventArgs e)
        {
            this.viewConfigWebTableAdapter.FillBy_UserRager(this.dB.ViewConfigWeb, Common.Obj2Int(this.cboUser.SelectedValue), this.ctrDateRanger1.FromDate, ctrDateRanger1.ToDate);
            this.gridView1.ExpandAllGroups();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.DefaultExt = "xls";
            this.saveFileDialog1.FileName = string.Format("logCV_{0}_date_{1}-{2}.xls", user, ctrDateRanger1.FromDate.ToString("dd_MM_yyyy"), ctrDateRanger1.ToDate.ToString("dd_MM_yyyy"));
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                QT.Entities.Wait.Show("Đang export");
                this.gridView1.ExportToXls(saveFileDialog1.FileName);
                QT.Entities.Wait.Close();
            }
        }
    }
}
