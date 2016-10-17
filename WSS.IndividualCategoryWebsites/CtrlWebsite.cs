using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using QT.Entities;

namespace WSS.IndividualCategoryWebsites
{
    public partial class CtrlWebsite : UserControl
    {
        public delegate void ChangedEventHandler(WssCommon.ListWebCommand command, EventArgs e);
        public event ChangedEventHandler ExcuteCommand;
        private static readonly ILog Log = LogManager.GetLogger(typeof(CtrlWebsite));
        private WssCommon.ListWebCommand _command = WssCommon.ListWebCommand.IndividualWebsitesProduct;
        public CtrlWebsite()
        {
            InitializeComponent();
        }

        public void InitControl()
        {
            websitesTableAdapter.Connection.ConnectionString = WssConnection.ConnectionIndividual;
            try
            {
                websitesTableAdapter.Fill(dBIndi.Websites);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Log.Error(exception);
            }
        }

        
        public int GetIdCurrent()
        {
            return Common.Obj2Int(idTextEdit.Text);
        }
        public string GetDomainCurrent()
        {
            return this.domainTextEdit.Text;
        }
        private void getRootProductToWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _command = WssCommon.ListWebCommand.IndividualWebsitesProduct;
            ExcuteCommand(_command, e);
        }
        private void managerRootProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _command = WssCommon.ListWebCommand.IndividualWebsitesRootProductAnalyzed;
            ExcuteCommand(_command, e);
        }

        private void gridViewWebsites_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.websitesGridControl, new Point(e.X, e.Y));
                //GetRowAt(gridView1, e.X, e.Y);
            }
        }

        private void viewTagInWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _command = WssCommon.ListWebCommand.ViewTagInWebsites;
            ExcuteCommand(_command, e);
        }
    }
}
