using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities;

namespace WSS.WebMerchantSupport
{
    public partial class ctrWebMerchant : UserControl
    {
        public delegate void ChangedEventHandler(WebMerchantCommon.ListCommand command, EventArgs e);
        public event ChangedEventHandler ExcuteCommand;
        private WebMerchantCommon.ListCommand _command = new WebMerchantCommon.ListCommand();
        public ctrWebMerchant()
        {
            InitializeComponent();
        }
        public void Init()
        {
            websiteProfilesTableAdapter.Connection.ConnectionString = WebMerchantConnection.WebMerchantConnectionString;
            try
            {
                websiteProfilesTableAdapter.Fill(dsWebMerchant.WebsiteProfiles);
            }
            catch (Exception ex01)
            {
                MessageBox.Show(ex01.Message);
                
            }
        }
        public int GetWebIdCurrent()
        {
            return Common.Obj2Int(webIdTextEdit.Text);
        }
        public string GetDomainCurrent()
        {
            return webDomainTextEdit.Text;
        }

        private void changeToolStripChangeProduct_Click(object sender, EventArgs e)
        {
            _command = WebMerchantCommon.ListCommand.ChangeProduct;
            ExcuteCommand(_command, e);
        }

        private void websiteProfilesGridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.websiteProfilesGridControl, new Point(e.X, e.Y));
                //GetRowAt(gridView1, e.X, e.Y);
            }
        }
        
    }
}
