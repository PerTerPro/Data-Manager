using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerReviewFacebook
{
    public partial class FrmManagerFacebook : Form
    {
        private string conn = string.Empty;
        public FrmManagerFacebook()
        {
            InitializeComponent();
            conn = ConfigurationSettings.AppSettings["ConnectionString"];

        }

 

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBAnalysInfo1.AnalysicInfoFacbook' table. You can move, or remove it, as needed.
            this.analysicInfoFacbookTableAdapter.Fill(this.dBAnalysInfo1.AnalysicInfoFacbook);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                analysicInfoFacbookBindingNavigatorSaveItem_Click(null, null);
            }
            if (e.Control && e.KeyCode == Keys.F5)
            {
                Form1_Load(null, null);
            }
        }

        private void analysicInfoFacbookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.analysicInfoFacbookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBAnalysInfo1);
        }
    }
}
