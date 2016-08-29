using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlSale
{
    public partial class FrmRunQuickMongo : Form
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmRunQuickMongo));
        private Thread thread;
     

        public FrmRunQuickMongo()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string queryFind = txtFind.Text;
            string queryUpdate = txtUpdate.Text;
            int iLimit = Convert.ToInt32(spinEdit1.Value);

            thread = new Thread(() => MethodUpdate(queryFind, queryUpdate, iLimit));
            thread.Start();
        }

        private void WriteLog (string log)
        {
            this.Invoke(new Action(() => { this.txtLog.AppendText("\n" + log); }));
        }

        private void MethodUpdate(string queryFind, string queryUpdate, int iLimit)
        {
            while (true)
            {
                try
                {
                    MongoDbRaoVat mongoDb = new MongoDbRaoVat();
                    
                    int i =   mongoDb.UpdateWaitQuickReload(queryFind, queryUpdate, iLimit).Result;
                    this.WriteLog(string.Format("Change state of {0} item", i));
                    Thread.Sleep(2000);
                }
                catch (ThreadAbortException ex1)
                {
                    break;
                }
                catch (Exception ex2)
                {
                    WriteLog(ex2.Message);
                    log.ErrorFormat(ex2.Message);
                    Thread.Sleep(2000);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                txtFind.Text = @"{$and:[{'wait_quick_reload':false},{'source_updated_at':{$gt:ISODate('2015-09-07T08:08:06.400Z')}}]}";
                txtUpdate.Text = @"{$set:{'wait_quick_reload':true}}";
                txtLog.Clear();
            }
            else if (comboBox1.SelectedIndex==1)
            {
                txtFind.Text = @"{$and:[{'wait_quick_reload':false},{'category_ids':{exists:false}}]}";
                txtUpdate.Text = @"{$set:{'wait_quick_reload':true}}";
                txtLog.Clear();
            }
            else if (comboBox1.SelectedIndex==2)
            {
                txtFind.Text = @" {'wait_quick_reload':{$exists:false}}";
                txtUpdate.Text = @"{$set:{'wait_quick_reload':false}}";
                txtLog.Clear();
            }
        }

        private void FrmRunQuickMongo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null && thread.IsAlive) thread.Abort();
        }
    }
}
