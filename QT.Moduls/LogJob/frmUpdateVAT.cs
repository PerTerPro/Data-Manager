using log4net;
using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.LogJob
{
    public partial class frmUpdateVAT : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmUpdateVAT));
        public frmUpdateVAT()
        {
            InitializeComponent();
        }
        private void frmUpdateVAT_Load(object sender, EventArgs e)
        {
            this.configurationTableAdapter.Connection.ConnectionString =Server.ConnectionString;
            this.companyVATStatusTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.companyVATStatusTableAdapter.Fill(this.dBLogJob.CompanyVATStatus);
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DBLogJobTableAdapters.CompanyTableAdapter companyAdapter = new DBLogJobTableAdapters.CompanyTableAdapter();
            DBLogJob.CompanyDataTable companyTable = new DBLogJob.CompanyDataTable();
            DBLogJob.ConfigurationDataTable configTable = new DBLogJob.ConfigurationDataTable();
            companyAdapter.Connection.ConnectionString = Server.ConnectionString;
            for (int i = 0; i < dBLogJob.CompanyVATStatus.Rows.Count; i++)
            {
                Wait.Show(string.Format("{0}/{1}", i, dBLogJob.CompanyVATStatus.Rows.Count));
                string domain = dBLogJob.CompanyVATStatus.Rows[i]["Domain"].ToString();
                long idcompany = Common.GetIDCompany(domain);
                if (idcompany != 0)
                {
                    try
                    {
                        companyTable.Rows.Clear();
                        companyAdapter.FillBy_ID(companyTable, idcompany);
                        if (companyTable.Rows.Count > 0)
                        {
                            configTable.Rows.Clear();
                            if (dBLogJob.CompanyVATStatus.Rows[i]["VATStatus"] == DBNull.Value)
                            {
                                Log.Error("VATSTatus NULL + ID =" + idcompany + " Domain = " + domain);
                                continue;
                            }
                            int status = Common.Obj2Int(dBLogJob.CompanyVATStatus.Rows[i]["VATStatus"].ToString());
                            try
                            {
                                configurationTableAdapter.FillBy_CompanyID(configTable, idcompany);
                                if (configTable.Rows.Count > 0)
                                {
                                    try
                                    {
                                        configurationTableAdapter.UpdateVATStatus(status, idcompany);
                                    }
                                    catch (Exception ex1)
                                    {
                                        Log.Error("ERROR UPDATE + ID =" + idcompany + " Domain = " + domain,ex1);
                                    }
                                }
                                else
                                    try
                                    {
                                        configurationTableAdapter.Insert("", "", "", "", "", "", "", "", null, "", "", idcompany, "", null, 0, 0, 0, 0, "", "", "", "", "", "", "", "", null, "", "", "", "", "", "", "", "", "", null, "", null, "", "", null, null, null, null, 0, status);
                                    }
                                    catch (Exception ex2)
                                    {
                                        Log.Error("ERROR INSERT + ID =" + idcompany + " Domain = " + domain,ex2);
                                    }
                            }
                            catch (Exception exx)
                            {
                                Log.Error("ERROR fill by id configuration  ", exx);
                            }
                        }
                        else
                            Log.Error("Không có Cong ty nay ID =" + idcompany + " Domain " + domain);
                    }
                    catch (Exception ex)
                    {
                        Log.Error("ERROR fill by id COmpany ", ex);
                    }
                }
                else
                    Log.Error("ID = 0  " + domain);
                
            }
            Wait.Close();
        }
    }
}
