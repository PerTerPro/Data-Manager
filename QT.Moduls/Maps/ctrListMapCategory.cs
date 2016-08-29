using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace QT.Moduls.Maps
{
    public partial class ctrListMapCategory : UserControl
    {
        public ctrListMapCategory()
        {
            InitializeComponent();
        }

        private Thread processThread;
        private String _connection = "";
        bool finish = true;
        void doprocess()
        {
            finish = false;
            this.Invoke((MethodInvoker)delegate
            {
                lamess.Text = "Đang tải dữ liệu...";
            });
            if (_connection == "")
            {
                _connection = QT.Entities.Server.ConnectionString;
                this.mapClassificationTableAdapter.Connection.ConnectionString = _connection;
            }
            DB.MapClassificationDataTable dt = new DB.MapClassificationDataTable();
           
            this.mapClassificationTableAdapter.FillBy_LikeName(dt, "%" + txtSearch.Text.ToString().Trim() + "%");

            this.Invoke((MethodInvoker)delegate
            {
                lamess.Text = "Đã tải xong dữ liệu";
            });
            
            this.Invoke((MethodInvoker)delegate
            {
                this.dB.MapClassification.Rows.Clear();
                this.dB.MapClassification.Merge(dt);
                lamess.Text = "finish";
                this.dB.MapClassification.AcceptChanges();
            });
            finish = true;
            if (processThread != null)
            {
                if (processThread.IsAlive)
                {
                    processThread.Abort();
                    processThread.Join();
                    processThread = null;
                }
            }
        }

        public void AddCat(int id, string name, int cat)
        {
            mapClassificationBindingSource.AddNew();
            this.iDClassificationLabel1.Text = id.ToString();
            iDCategoryLabel1.Text = "0";
            targetIDLabel1.Text = "0";
            nameLabel1.Text = name;
            this.iDCategoryLabel1.Text = cat.ToString();
            mapClassificationBindingSource.EndEdit();
        }

        private void btBuildTree_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            if (finish)
            {
                processThread = new Thread(new ThreadStart(doprocess));
                processThread.Start();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.mapClassificationBindingSource.EndEdit();
            this.mapClassificationTableAdapter.Update(dB.MapClassification);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (this.mapClassificationBindingSource.Count > 0)
            {
                this.mapClassificationBindingSource.RemoveCurrent();
            }

        }
    }
}
