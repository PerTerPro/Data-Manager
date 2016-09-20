using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmGetLink : Form
    {
        private static FrmGetLink frm = new FrmGetLink();
        public static List<string> GetLinks()
        {
            frm.ShowDialog(); 
            return frm.GetLinkData();
        }

        private List<string> GetLinkData()
        {
            return richTextBox1.Text.Split(new char[] {'\n', '\r'}, StringSplitOptions.None).ToList();
        }

        public FrmGetLink()
        {
            InitializeComponent();
        }

        private void FrmGetLink_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FrmGetLink_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
           
        }
    }
}
