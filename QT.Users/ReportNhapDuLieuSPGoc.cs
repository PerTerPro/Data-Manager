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
    public partial class ReportNhapDuLieuSPGoc : QT.Entities.frmBase
    {
        public ReportNhapDuLieuSPGoc()
        {
            InitializeComponent();
        }

        private void ReportNhapDuLieuSPGoc_Load(object sender, EventArgs e)
        {
            this.viewNhapLieuSPGocTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tblUserTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tblUserTableAdapter.Fill(this.dB.tblUser);
        }

        private void btView_Click(object sender, EventArgs e)
        {
            viewNhapLieuSPGocTableAdapter.FillBy_UserID(dBPhanSP.ViewNhapLieuSPGoc,Common.Obj2Int(this.cboUser.SelectedValue), ctrDateRanger1.FromDate, ctrDateRanger1.ToDate);
            user = userNameTextBox.Text;
            this.gridView1.ExpandAllGroups();
        }

        private void btViewAll_Click(object sender, EventArgs e)
        {
            viewNhapLieuSPGocTableAdapter.FillBy_AllUser(dBPhanSP.ViewNhapLieuSPGoc, ctrDateRanger1.FromDate, ctrDateRanger1.ToDate);
            user = "All";
            this.gridView1.ExpandAllGroups();
        }
        string user = "";
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
