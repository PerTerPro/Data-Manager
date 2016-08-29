using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace QT.Moduls.Notifycation
{
    public partial class FrmPushNotifycation : Form
    {
        RabbitMQServer _rabbitMQServer;
        private string connectionString = @"Data Source=192.168.100.178;Initial Catalog=Notification;Persist Security Info=True;User ID=sa;Password=123456a@";
        private DataTable tblNotification_Push = null;
        public FrmPushNotifycation()
        {
            InitializeComponent();

            _rabbitMQServer = RabbitMQManager.GetRabbitMQServer("rabbitMQ_Notification");
        }

        private void btnPushMss_Click(object sender, EventArgs e)
        {
            try
            {
                JobClient updateProductJobClient_PushCompany = new JobClient(txtExchange.Text, GroupType.Topic, txtRountingKey.Text, true, _rabbitMQServer);
                updateProductJobClient_PushCompany.PublishJob(new Job()
                {
                    Data = System.Text.Encoding.UTF8.GetBytes(string.Format("{0}:{1}", txtFrom.Text, txtMessage.Text)),
                    Type = 0
                }, 0);
                MessageBox.Show("Sended");
            }
            catch (Exception ex01)
            {
                MessageBox.Show(ex01.Message + ex01.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPushNotifycation_FormClosing(object sender, FormClosingEventArgs e)
        {
            _rabbitMQServer.Stop();
        }

        private void cmbPushInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtExchange_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPushNotifycation_Load(object sender, EventArgs e)
        {
            this.notification_PushTableAdapter.Connection.ConnectionString = connectionString;
            this.notification_PushTableAdapter.Fill(this.dBNotification.Notification_Push);
            this.nameComboBox.DataSource = this.dBNotification.Notification_Push;
            this.nameComboBox.DisplayMember = "Name";
        }

        private void notification_PushBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.notification_PushBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dBNotification);

        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataRowView rowSelected = nameComboBox.SelectedValue as System.Data.DataRowView;
                txtExchange.Text = rowSelected["Exchange"].ToString();
                txtRountingKey.Text = rowSelected["RoutingKey"].ToString();
            }
            catch (Exception ex01)
            {
                MessageBox.Show(ex01.Message);
            }
        }
    }
}
