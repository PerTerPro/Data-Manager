using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.Crawler
{
    public partial class frmCrawlerViewQueue : QT.Entities.frmBase
    {
        private long _idCompany = 0;
        public frmCrawlerViewQueue(long CompanyID)
        {
            InitializeComponent();
            _idCompany = CompanyID;
        }

        public override bool RefreshData()
        {
            try
            {
                this.queueLinksTableAdapter.Connection.Open();
                this.queueLinksTableAdapter.FillBy_Company(this.dBQueue.QueueLinks, _idCompany);
                this.queueLinksTableAdapter.Connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        private void frmCrawlerViewQueue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQueue.QueueLinks' table. You can move, or remove it, as needed.
            this.queueLinksTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;
            RefreshData();
        }

        private void queueLinksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.queueLinksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQueue);

        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
