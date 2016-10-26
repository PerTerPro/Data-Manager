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

namespace WSS.Financial.Backend.Brand
{
    public partial class ctrBrand : UserControl
    {
        public delegate void ChangedEventHandler(WssCommon.ListBrandCommand command, EventArgs e);
        public event ChangedEventHandler ExcuteCommand;
        private static readonly ILog Log = LogManager.GetLogger(typeof(ctrBrand));
        private WssCommon.ListBrandCommand _command = WssCommon.ListBrandCommand.ViewItemManager;
        public ctrBrand()
        {
            InitializeComponent();
        }
        public void InitControl()
        {
            brandTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            try
            {
                brandTableAdapter.Fill(dBFinancial.Brand);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Log.Error(exception);
            }
        }
        public int GetIdCurrent()
        {
            return Convert.ToInt32(idTextEdit.Text);
        }
        public string GetBrandCurrent()
        {
            return this.nameTextEdit.Text;
        }
        private void ViewItemInBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _command = WssCommon.ListBrandCommand.ViewItemManager;
            ExcuteCommand(_command, e);
        }

        private void viewInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _command = WssCommon.ListBrandCommand.ViewInfo;
            ExcuteCommand(_command, e);
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.brandGridControl, new Point(e.X, e.Y));
                //GetRowAt(gridView1, e.X, e.Y);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            InitControl();
        }
    }
}
