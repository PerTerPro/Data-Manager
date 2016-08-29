using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.Tool
{
    public partial class frmChuanHoaThanhPho : QT.Entities.frmBase
    {
        public frmChuanHoaThanhPho()
        {
            InitializeComponent();
        }

        private void frmChuanHoaThanhPho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTool2.Company_Address' table. You can move, or remove it, as needed.
            this.company_AddressTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
        }

        private void btLoadData_Click(object sender, EventArgs e)
        {
            this.company_AddressTableAdapter.FillBy_ThanhPho(this.dBTool2.Company_Address);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if ((txtFrom.Text.Trim().Length > 0) && (txtTo.Text.Trim().Length > 0))
            {
                this.company_AddressTableAdapter.UpdateQuery_LikeThanhPho(txtTo.Text.Trim(), "%" + txtFrom.Text.Trim() + "%");
            }
        }
    }
}
