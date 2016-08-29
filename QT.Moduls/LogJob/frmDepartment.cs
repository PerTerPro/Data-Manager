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
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void tblUserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBLogJob);

        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Department", typeof(int));
            dt.Columns.Add("Text", typeof(string));
            DataRow dr = dt.NewRow();
            dr["Department"] = UserDepartment.Code;
            dr["Text"] = "Code";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1["Department"] = UserDepartment.Config;
            dr1["Text"] = "Config";
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2["Department"] = UserDepartment.Data;
            dr2["Text"] = "Data";
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3["Department"] = UserDepartment.Content;
            dr3["Text"] = "Content";
            dt.Rows.Add(dr3);
            DataRow dr4 = dt.NewRow();
            dr4["Department"] = UserDepartment.Marketing;
            dr4["Text"] = "Marketing";
            dt.Rows.Add(dr4);
            repositoryItemLookUpEdit1.DataSource = dt;
            this.tblUserTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            // TODO: This line of code loads data into the 'dBLogJob.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.dBLogJob.tblUser);

        }
    }
}
