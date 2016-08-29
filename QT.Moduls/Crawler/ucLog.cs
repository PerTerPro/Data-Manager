using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.Crawler
{
    public partial class ucLog : UserControl
    {
        public void AddLog(string text)
        {
            if (this.richTextBox1.TextLength > 10000) this.richTextBox1.Clear();
            else this.richTextBox1.AppendText("\n" + text);
        }
        public ucLog()
        {
            InitializeComponent();
        }
    }
}
