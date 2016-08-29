using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QT.Entities
{
    public partial class frmBase : Form
    {
        public BarItemVisibility VisibleStart { get; set; }
        public BarItemVisibility VisibleStop { set; get; }
        public BarItemVisibility VisiblePause { set; get; }
        public BarItemVisibility VisibleRefresh { set; get; }
        public BarItemVisibility VisibleRestart { set; get; }
        public BarItemVisibility VisibleSave { set; get; }
        

        public bool EnabledStart { set; get; }
        public bool EnabledStop { set; get; }
        public bool EnabledPause { set; get; }
        public bool EnabledRefresh { set; get; }
        public bool EnabledRestart { set; get; }
        public bool EnabledSave { set; get; }
       


        public delegate void ChangedEventHandler(object sender, EventArgs e);
        public event ChangedEventHandler InitComplete;
       
        public frmBase()
        {
            InitializeComponent();
            this.VisibleStart = BarItemVisibility.Always;
            this.VisibleStop = BarItemVisibility.Always;
            this.VisiblePause = BarItemVisibility.Always;
            this.VisibleRefresh = BarItemVisibility.Always;
            this.VisibleRestart = BarItemVisibility.Always;
            this.VisibleSave = BarItemVisibility.Always;

            EnabledStart = true;
            EnabledStop = true;
            EnabledPause = true;
            EnabledRefresh = true;
            EnabledRestart = true;
            EnabledSave = true;
        }

        public virtual bool Start()
        {
            MessageBox.Show("Đang hoàn thiện");
            return true;
        }
        public virtual bool Stop()
        {
            MessageBox.Show("Đang hoàn thiện");
            return true;
        }
        public virtual bool RefreshData()
        {
            MessageBox.Show("Đang hoàn thiện");
            return true;
        }
        public virtual bool Pause()
        {
            MessageBox.Show("Đang hoàn thiện");
            return true;
        }
        public virtual bool Restart()
        {
            MessageBox.Show("Đang hoàn thiện");
            return true;
        }

        public virtual bool Save()
        {
            MessageBox.Show("Đang hoàn thiện");
            return true;
        }
        public virtual bool Analytics()
        {
            MessageBox.Show("Đang hoàn thiện");
            return true;
        }
        public virtual bool Log()
        {
            MessageBox.Show("Đang hoàn thiện");
            return true;
        }
        public virtual bool TestXpath()
        {
            MessageBox.Show("Đang hoàn thiện");
            return true;
        }
    }
}
