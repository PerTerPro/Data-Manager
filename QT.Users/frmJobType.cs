using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QT.Users
{
    public partial class frmJobType : QT.Entities.frmBase
    {
        public frmJobType()
        {
            InitializeComponent();
        }
        public override bool Save()
        {
            this.userJobTypeBindingSource.EndEdit();
            this.userJobTypeTableAdapter.Update(dB.UserJobType);
            return true;
        }
        public override bool RefreshData()
        {
            this.userJobTypeTableAdapter.Fill(this.dB.UserJobType);
            return true;
        }
        private void frmJobType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.UserJobType' table. You can move, or remove it, as needed.
            this.userJobTypeTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.userJobTypeTableAdapter.Fill(this.dB.UserJobType);

        }
    }
}
