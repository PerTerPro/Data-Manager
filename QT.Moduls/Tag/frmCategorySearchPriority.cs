using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.Tag
{
    public partial class frmCategorySearchPriority : QT.Entities.frmBase

    {
        public frmCategorySearchPriority()
        {
            InitializeComponent();
        }

        private void frmCategorySearchPriority_Load(object sender, EventArgs e)
        {
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            // TODO: This line of code loads data into the 'dBTag.ListClassification' table. You can move, or remove it, as needed.
            this.listClassificationTableAdapter.Fill(this.dBTag.ListClassification);

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        public override bool Save()
        {
            this.Validate();
            this.listClassificationBindingSource.EndEdit();
            try
            {
                this.listClassificationTableAdapter.Update(dBTag.ListClassification);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
