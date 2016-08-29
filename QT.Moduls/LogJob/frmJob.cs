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
    public partial class frmJob : Form
    {
        public frmJob()
        {
            InitializeComponent();
        }

        private void jobBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBLogJob);

        }

        private void frmJob_Load(object sender, EventArgs e)
        {
            this.jobTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            // TODO: This line of code loads data into the 'dBLogJob.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.dBLogJob.Job);

        }
    }
}
