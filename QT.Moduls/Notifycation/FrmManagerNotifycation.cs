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

namespace QT.Moduls.Notifycation
{
    public partial class FrmNotifications : Form
    {

        bool bRunningTrack = false;
        NotifycationAdapter notifycationAdapter = new NotifycationAdapter();
        CancellationTokenSource cancellationTokenSource = null;

        public FrmNotifications()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable tblNotification = this.gridControl1.DataSource as DataTable;
            DataTable tblChanged = tblNotification.GetChanges();
            foreach (DataRow rowInfo in tblChanged.Rows)
            {
                int ID = QT.Entities.Common.Obj2Int(rowInfo["ID"]);
                bool processed = QT.Entities.Common.Obj2Bool(rowInfo["Processed"]);
                this.notifycationAdapter.SaveChangeNotify(ID, processed);
            }
            tblNotification.AcceptChanges();
            MessageBox.Show("Đã lưu");
            this.RefreshData();
        }

        private void btnStartRun_Click(object sender, EventArgs e)
        {
            if (!bRunningTrack)
            {
                this.bRunningTrack = true;
                this.btnStartRun.Text = "Stop";
                this.cancellationTokenSource = new CancellationTokenSource();
                CancellationToken cancellationToke = this.cancellationTokenSource.Token;
                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        int numberItem = 0;
                        while (true)
                        {
                            cancellationToke.ThrowIfCancellationRequested();
                            NotifycationAdapter notifyAdapterCount = new NotifycationAdapter();
                            if ((numberItem = notifyAdapterCount.GetNumberMessageWait(QT.Users.User.UserName, 0)) > 0)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    this.notifyIcon1.BalloonTipText = string.Format("{0} Message waiting...", numberItem);
                                    this.notifyIcon1.ShowBalloonTip(10000);
                                    
                                }));
                            }
                            Thread.Sleep(10000);
                        }
                    }
                    catch (OperationCanceledException op)
                    {
                        return;
                    }
                }, cancellationToke);

                
            }
            else
            {
                this.bRunningTrack = false;
                this.btnStartRun.Text = "Start";
                if (this.cancellationTokenSource != null && this.cancellationTokenSource.IsCancellationRequested)
                    this.cancellationTokenSource.Cancel();
                
            }
        }



        private void FrmManagerNotifycation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cancellationTokenSource != null
                && this.cancellationTokenSource.IsCancellationRequested == false)
            {
                if (MessageBox.Show("Tắt luôn notifycation?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    this.cancellationTokenSource.Cancel();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    if (MessageBox.Show("Ẩn Form", "Question", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Visible = false;
                    }
                }
            }
        }

        private void FrmManagerNotifycation_Load(object sender, EventArgs e)
        {
            this.notifyIcon1.BalloonTipClicked += new EventHandler(EventRunRefresh);
            this.notifyIcon1.Click += new EventHandler(EventRunRefresh);
        }

        private void EventRunRefresh(object sender, EventArgs e)
        {
            this.RefreshData();
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void RefreshData()
        {
            this.gridControl1.DataSource = notifycationAdapter.GetNotifyOfUser(QT.Users.User.UserName, 0);
        }

        private void btnNoVisible_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnPushMss_Click(object sender, EventArgs e)
        {
            FrmPushNotifycation frmPushNotifycation = new FrmPushNotifycation();
            frmPushNotifycation.Show();
        }

        public void RunTrackAuto()
        {
            this.Show();
            btnStartRun.PerformClick();
            btnNoVisible.PerformClick();
        }
    }
}
