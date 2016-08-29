using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QT.Entities
{
    public partial class frmShowNumber : Form
    {
        public frmShowNumber(String Name)
        {
            InitializeComponent();
            this.label1.Text = Name;
        }

        public int NumberValue
        {
            set { this.spinEdit1.Value = NumberValue; }

            get {
                int r = 0;
                r = Common.Obj2Int(this.spinEdit1.Value);
                return r;
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void spinEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
