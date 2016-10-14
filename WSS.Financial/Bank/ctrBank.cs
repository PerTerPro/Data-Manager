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

namespace WSS.Financial.Bank
{
    public partial class ctrBank : UserControl
    {
        public delegate void ChangedEventHandler(WssCommon.ListBankCommand command, EventArgs e);
        public event ChangedEventHandler ExcuteCommand;
        private static readonly ILog Log = LogManager.GetLogger(typeof(ctrBank));
        private WssCommon.ListBankCommand _command = WssCommon.ListBankCommand.ViewInfo;
        public ctrBank()
        {
            InitializeComponent();
        }

        public void InitControl()
        {
            bankTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            try
            {
                bankTableAdapter.Fill(dBFinancial.Bank);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Log.Error(exception);
            }
        }
        public int GetIdCurrent()
        {
            return Convert.ToInt32(bankIdTextEdit.Text);
        }
        public string GetBankCurrent()
        {
            return bankNameTextEdit.Text;
        }
        private void gridViewBank_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.bankGridControl, new Point(e.X, e.Y));
            }
        }

        private void viewInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _command = WssCommon.ListBankCommand.ViewInfo;
            ExcuteCommand(_command, e);
        }

        private void bankLendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _command = WssCommon.ListBankCommand.ViewBankLending;
            ExcuteCommand(_command, e);
        }
    }
}
