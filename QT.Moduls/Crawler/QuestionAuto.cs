using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.Crawler
{
    public partial class FrmQuestionAuto : Form
    {
        int iSecond = 0;
        int iMax = 10;
        private bool bReturn;

        public FrmQuestionAuto()
        {
            InitializeComponent();
        }

        private void FrmQuestionAuto_Load(object sender, EventArgs e)
        {

        }

        public static bool GetQuestionRun(string nameForm)
        {
            bool bReturn = true;
            FrmQuestionAuto frm = new FrmQuestionAuto();
            frm.Text = nameForm;
            frm.FormClosing += new FormClosingEventHandler(delegate(object obj, FormClosingEventArgs arg)
            {
                bReturn = frm.bReturn;
            });
            frm.ShowDialog();
            return bReturn;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                iSecond++;
                progressBar1.Value = Convert.ToInt32(((double)iSecond / (double)iMax) * 100);
                if (iSecond == iMax)
                {
                    this.bReturn = true;
                    this.timer1.Stop();
                    this.timer1.Dispose();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bReturn = false;
            this.timer1.Stop();
            this.timer1.Dispose();
            this.Close();
        }

        private void btnRunNow_Click(object sender, EventArgs e)
        {
            bReturn = true;
            this.timer1.Stop();
            this.timer1.Dispose();
            this.Close();
        }
    }
}
