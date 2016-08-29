using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GABIZ.Base;

namespace QT.NewsRelation
{
    public partial class frmThreatManager : QT.Entities.frmBase
    {
        public frmThreatManager()
        {
            InitializeComponent();
        }

        private void frmThreatManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.ThreatConfig' table. You can move, or remove it, as needed.
            this.threatConfigTableAdapter.Fill(this.dB.ThreatConfig);
            // TODO: This line of code loads data into the 'dB.ThreatConfig_OrNotContain' table. You can move, or remove it, as needed.
            this.threatConfig_OrNotContainTableAdapter.Fill(this.dB.ThreatConfig_OrNotContain);
            // TODO: This line of code loads data into the 'dB.ThreatConfig_NotContain' table. You can move, or remove it, as needed.
            this.threatConfig_NotContainTableAdapter.Fill(this.dB.ThreatConfig_NotContain);
            // TODO: This line of code loads data into the 'dB.ThreatConfig_OrContain' table. You can move, or remove it, as needed.
            this.threatConfig_OrContainTableAdapter.Fill(this.dB.ThreatConfig_OrContain);
            // TODO: This line of code loads data into the 'dB.ThreatConfig_Contain' table. You can move, or remove it, as needed.
            this.threatConfig_ContainTableAdapter.Fill(this.dB.ThreatConfig_Contain);
            // TODO: This line of code loads data into the 'dB.Threat' table. You can move, or remove it, as needed.
            this.threatTableAdapter.Fill(this.dB.Threat);

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            this.threatBindingSource.EndEdit();
            this.threatTableAdapter.Update(dB.Threat);
            this.threatConfigBindingSource.EndEdit();
            this.threatConfigTableAdapter.Update(this.dB.ThreatConfig);
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            string name= this.titleTextBox.Text.ToLower().Trim();
            //var bytename = Encoding.UTF8.GetBytes(name);
            //this.iDTextBox.Text = Convert.ToBase64String(bytename);
            string newID = GABIZ.Base.Tools.DecimalToArbitrarySystem(Tools.getCRC64(name), 36);
            if (this.iDThreadTextBox.Text.Trim() == "")
            {
                this.iDThreadTextBox.Text = newID;
            }
        }

        private void iDThreadTextBox_TextChanged(object sender, EventArgs e)
        {
            this.threatConfigTableAdapter.FillBy_SelectOneByThreadID(dB.ThreatConfig, this.iDThreadTextBox.Text);
            if (dB.ThreatConfig.Rows.Count <= 0)
            {
                this.threatConfigBindingSource.AddNew();
                this.iDThread_inConfig_TextBox.Text = iDThreadTextBox.Text;
            }

        }

        private void iDConfigTextBox_TextChanged(object sender, EventArgs e)
        {
            int idConfig = QT.Entities.Common.Obj2Int(iDConfigTextBox.Text);
            this.threatConfig_ContainTableAdapter.FillBy_IDConfig(dB.ThreatConfig_Contain, idConfig);
            this.dB.ThreatConfig_Contain.IDConfigColumn.DefaultValue = idConfig.ToString();

            this.threatConfig_NotContainTableAdapter.FillBy_IDConfig(dB.ThreatConfig_NotContain, idConfig);
            this.dB.ThreatConfig_NotContain.IDConfigColumn.DefaultValue = idConfig.ToString();
        }

        private void iD_ThreadConfig_ContainTextBox_TextChanged(object sender, EventArgs e)
        {
            int idConfigContain = QT.Entities.Common.Obj2Int(iD_ThreadConfig_ContainTextBox.Text);
            this.threatConfig_OrContainTableAdapter.FillBy_IDContain(dB.ThreatConfig_OrContain, idConfigContain);
            this.dB.ThreatConfig_OrContain.IDContainColumn.DefaultValue = idConfigContain.ToString();
        }

        private void btUpdate_Contain_Click(object sender, EventArgs e)
        {
            this.threatConfigContainBindingSource.EndEdit();
            this.threatConfig_ContainTableAdapter.Update(dB.ThreatConfig_Contain);
            this.threatConfigOrContainBindingSource.EndEdit();
            this.threatConfig_OrContainTableAdapter.Update(dB.ThreatConfig_OrContain);
        }

        private void btRefreshContain_Click(object sender, EventArgs e)
        {

        }

        private void iD_ThreadConfig_NotContainTextBox_TextChanged(object sender, EventArgs e)
        {
            int idConfigContain = QT.Entities.Common.Obj2Int(iD_ThreadConfig_NotContainTextBox.Text);
            this.threatConfig_OrNotContainTableAdapter.FillBy_IDNotContain(dB.ThreatConfig_OrNotContain, idConfigContain);
            this.dB.ThreatConfig_OrNotContain.IDContainColumn.DefaultValue = idConfigContain.ToString();
        }

        private void btUpdateNotContain_Click(object sender, EventArgs e)
        {
            this.threatConfigNotContainBindingSource.EndEdit();
            this.threatConfig_NotContainTableAdapter.Update(dB.ThreatConfig_NotContain);
            this.threatConfigOrNotContainBindingSource.EndEdit();
            this.threatConfig_OrNotContainTableAdapter.Update(dB.ThreatConfig_OrNotContain);

        }

        private void btPhanTich_Click(object sender, EventArgs e)
        {
            //List<Article> lsContent = new List<Article>();
            //ThreadManager.EntitiesThreatConfig config = new ThreadManager.EntitiesThreatConfig();
            //int total=0;
            //lsContent = MySearchEngine.Search(config, MySearchEngine.ORDER_BY_DATE, MySearchEngine.RETURN_TYPE_FULL, total, 0, 20);

            //ServiceReference1.ThreadManagerSoapClient obj = new ServiceReference1.ThreadManagerSoapClient();
            //List<ServiceReference1.Article> ls1 = new List<ServiceReference1.Article>();
            //ls1 = obj.

            //ThreadManager.ThreadManager obj = new ThreadManager.ThreadManager();
            //obj.Timeout = 100000;
            ////config = obj.SelectConfigByIDThread(iDThreadTextBox.Text);
            //ThreadManager.Article[] ls;
            //int total = 0;
            //ls = obj.SearchEngine(iDThreadTextBox.Text, 0, 0, 0, 10, out total);
            ////foreach (ThreadManager.Article item in ls)
            ////{
            ////    this.dB.Article.Rows.Add(item.Id, item.Host, item.Uri, item.Title, item.Intro, item.TextContent, item.HtmlContent, item.PublishTime, item.Image, item.Tags, item.BreadCrumb, item.BreadCrumb, item.Duplicate);
            ////}
            ////this.grvContent.DataSource = ls;
            //this.xtraTabControl1.SelectedTabPage = xtraTabPage3;
        }
    }
}
