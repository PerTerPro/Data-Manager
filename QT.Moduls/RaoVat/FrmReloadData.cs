using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlSale
{
    public partial class FrmReloadData : Form
    {
        /// <summary>
        /// 1, 
        /// </summary>
        public int iSpecial = 0; 

        public bool bIsPause = true;
        public bool bIsRunningInMethod = false;

        public delegate void MethodRun(object objSender, BsonDocument productNeedProcess);
        public MethodRun _methodRun;
        public IMongoCollection<BsonDocument> collection;
        private bool bStared = false;


        public void RunThread(FindOptions<BsonDocument> findOption, string strQuery, string queryUpdate)
        {
            while (true)
            {
                if (!bIsPause)
                {
                    if (this.IsClosed) break;
                    WriteLog("Run a job");
                    if (this.iSpecial == 0)
                    {
                        //Xử lí.
                        //Lấy dữ liệu => Xử lí => Cập nhật dữ liệu.
                        List<MongoDB.Bson.BsonDocument> listProduct = mongoDbAdapter.GetDataProcess(this.funcOption, strQuery, this.iCollection).Result;
                        foreach (var item in listProduct)
                        {
                            //Xử lí
                            if (this._methodRun != null) this._methodRun(this, item);
                            this.WriteLog("Processed document: " + (item["_id"] as MongoDB.Bson.BsonObjectId).ToString());
                        }
                    }
                    else if (this.iSpecial == 1)
                    {
                        long iJob = mongoDbAdapter.UpdateWaitQuickReload().Result;
                        this.WriteLog(string.Format("Change state WaitQuickReload to true for {0} item", iJob.ToString()));
                    }
                }
                else
                {
                    this.WriteLog("Pause!");
                }
                Thread.Sleep(1000);
            }
        }

        public FrmReloadData()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="methodRunData"></param>
        /// <param name="iColection">0. Product, 1. Keywords</param>
        public FrmReloadData(MethodRun methodRunData, int iColection)
        {
            InitializeComponent();
            this._methodRun = methodRunData;
            this.iCollection = iColection;

            this.mongoDbAdapter = new MongoDbRaoVat();
            if (this.iCollection == 0) this.collection = this.mongoDbAdapter.colProduct;
            else if (this.iCollection == 1) this.collection = this.mongoDbAdapter.colKeyWord;
            else if (this.iCollection == 2) this.collection = this.mongoDbAdapter.colHtml;
        }

        


        private void btnStop_Click(object sender, EventArgs e)
        {
            this.bIsPause = true;
            SetStatePause();
        }

        private void FrmReloadData_Load(object sender, EventArgs e)
        {
            mongoDbAdapter = new MongoDbRaoVat();
            QT.Entities.Common.TiGiaUsd = Convert.ToInt32(ConfigurationSettings.AppSettings["TiGiaUsd"].ToString());
            SetStatePause();
        }

        public void WriteLog (string log)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    txtQueryUpdate.AppendText("\n" + log);
                }));
            }
            catch (Exception ex)
            {
            }
        }


        int aTong = 0;
        private bool IsClosed = false;
        private int iCollection = -1;
        public FindOptions<BsonDocument> funcOption = null;

        public void btnStart_Click_1(object sender, EventArgs e)
        {
            if (!this.bStared)
            {

                int iLimit = Convert.ToInt32(spinEdit1.Value);
                string strQuery = txtQuery.Text;
                string strQueryUpdate = txtFieldUpdate.Text;
                this.bStared = true;
                this.bIsPause = false;
                Thread thread = new Thread(() =>
                {
                    RunThread(this.funcOption, strQuery, strQueryUpdate);
                });
                thread.Start();
            }
            else
            {
                bIsPause = false;
                
            }
            SetStatePause();
        }

        private void SetStatePause()
        {
           this.Invoke(new Action(() =>
                {
                    btnStart.Visible = this.bIsPause;
                    btnPause.Visible = !this.bIsPause;
                }));
        }

        private void FrmReloadData_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.IsClosed = true;
        }

        public MongoDbRaoVat mongoDbAdapter { get; set; }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
