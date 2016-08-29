using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.Company
{
    public partial class frmAddWeb : Form
    {
        public frmAddWeb()
        {
            InitializeComponent();
        }
        public string Website { set { this.textBox1.Text = value; } get { return this.textBox1.Text.Trim(); } }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmAddWeb_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
