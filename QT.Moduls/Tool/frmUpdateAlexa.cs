using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using QT.Entities;

namespace QT.Moduls.Tool
{
    public partial class frmUpdateAlexa : QT.Entities.frmBase
    {
        private DBToolTableAdapters.CompanyTableAdapter adt = new DBToolTableAdapters.CompanyTableAdapter();
        private DBTool.CompanyDataTable dt = new DBTool.CompanyDataTable();
        Thread _tAlexa;
        private string _domain = "";
        private bool _finish = false;
        private bool _nhomQuanLy = true;
        private int _position = 0;
        private Alexa _alexa = new Alexa();
        public frmUpdateAlexa()
        {
            InitializeComponent();
            adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
        }
        void doThreat()
        {
            //if (chkNot.Checked == true)
            //{
            //    adt.FillByUpdateAlexa(dt, Common.CompanyStatus.CONFIG);
            //}
            //else
            //{
            //    adt.FillByUpdateAlexa(dt, Common.CompanyStatus.NOTCONFIG);
            //}
            byte type = 0;
            int idMan = 0;
            type = Common.Obj2Byte(iDTextBox.Text.Trim());
            idMan = Common.Obj2Int(txtManagerID.Text.Trim());
            if (!_nhomQuanLy)
            {
                adt.FillByUpdateAlexa(dt, type);
            }
            else
            {
                adt.FillBy_IDTypeMan(dt, idMan);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _domain = dt.Rows[i]["Domain"].ToString();
                _position = i;
                string domain = dt.Rows[i]["Domain"].ToString();
                domain = domain.Replace("http://", "");
                domain = domain.Replace("www.", "");
                var alex = Common.GetRankAlexa(domain);
                Thread.Sleep(2500);
                if (alex != null)
                {
                    adt.UpdateQuery_Alexa(alex.AlexaRankContries, alex.AlexaRank, Common.Obj2Int64(dt.Rows[i]["ID"]));
                    //if (chkNot.Checked == true)
                    //{
                        
                    //}
                    //else
                    //{
                    //    if (alex.AlexaRankContries <= 0)
                    //    {
                    //        adt.UpdateQuery_Status(Common.CompanyStatus.NOAVAILABLE, Common.Obj2Int64(dt.Rows[i]["ID"]));
                    //    }
                    //    else
                    //    {
                    //        if (Common.Obj2Byte(dt.Rows[i]["Status"].ToString()) != Common.CompanyStatus.CONFIG)
                    //        {
                    //            if (alex.AlexaRankContries < 25000)
                    //            {
                    //                adt.UpdateQuery_Status(Common.CompanyStatus.NOTCONFIG, Common.Obj2Int64(dt.Rows[i]["ID"]));
                    //            }
                    //            else
                    //            {
                    //                adt.UpdateQuery_Status(Common.CompanyStatus.NOAVAILABLE, Common.Obj2Int64(dt.Rows[i]["ID"]));
                    //            }
                    //        }
                    //        adt.UpdateQuery_Alexa(alex.AlexaRankContries, alex.AlexaRank, Common.Obj2Int64(dt.Rows[i]["ID"]));
                    //    }
                    //}

                    this.Invoke((MethodInvoker)delegate
                    {
                        laTong.Text = "running domain " + _domain + "   -- " + _position.ToString() + "/" + dt.Rows.Count.ToString();
                        laTong.Text += "\nAlexaRank: " + alex.AlexaRank.ToString();
                        laTong.Text += "\nAlexaRank in " + alex.Contries + ": " + alex.AlexaRankContries.ToString();
                    });
                }
                else
                {
                    adt.UpdateQuery_Status(Common.CompanyStatus.NOAVAILABLE, Common.Obj2Int(dt.Rows[i]["ID"]));
                }
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            _nhomQuanLy = chkNhomQuanLy.Checked;
            _tAlexa = new Thread(new ThreadStart(doThreat));
            _tAlexa.Start();
        }

        private void frmUpdateAlexa_FormClosing(object sender, FormClosingEventArgs e)
        {
            _finish = true;
            if (_tAlexa != null)
            {
                if (_tAlexa.IsAlive)
                {
                    _tAlexa.Abort();
                    _tAlexa.Join();
                    _tAlexa = null;
                }
            }
        }

        private void btupdatefulltext_Click(object sender, EventArgs e)
        {
            Alexa item = Common.GetRankAlexa("dienmayrenhat.com");
        }

        private void frmUpdateAlexa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTool.ManagerType' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dBTool.Company_Status' table. You can move, or remove it, as needed.
            this.company_StatusTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.managerTypeTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.company_StatusTableAdapter.Fill(this.dBTool.Company_Status);
            this.managerTypeTableAdapter.Fill(this.dBTool.ManagerType);

        }
    }
}
