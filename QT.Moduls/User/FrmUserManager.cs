using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.User
{
    public partial class FrmUserManager : Form
    {
        public FrmUserManager()
        {
            InitializeComponent();
        }

        private void permissionUserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.permissionUserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBUser);
        }

        private void FrmUserManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUser.PermissionUser' table. You can move, or remove it, as needed.
            this.permissionUserTableAdapter.Fill(this.dBUser.PermissionUser);

        }
    }
}
