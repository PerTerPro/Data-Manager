using MongoDB.Bson;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlSale
{
    public partial class FrmFindExtraInfo : Form
    {
        MongoDbRaoVat mongoDbAdapter = new MongoDbRaoVat();
        MySqlAdapterRaoVat mySqlAdapterRaoVat = new MySqlAdapterRaoVat();
        Dictionary<int, string> dicCity = new Dictionary<int, string>();
        Dictionary<int, string> dicRegexCity = new Dictionary<int, string>();
        Dictionary<int, string[]> dicKeyWordForTerm = new Dictionary<int, string[]>();
        SqlDb sqlDbRaoVat = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
        private bool Stoped = false;

        public FrmFindExtraInfo()
        {
            InitializeComponent();

            LoadCitys();
        }

        private void LoadCitys()
        {
            
            this.dicCity = mySqlAdapterRaoVat.GetDicCity();
            DataTable tblRegexCity = this.sqlDbRaoVat.GetTblData("SELECT * FROM RegexCity");
            foreach (DataRow row in tblRegexCity.Rows)
            {
                this.dicRegexCity.Add(Convert.ToInt32(row["id"]), Convert.ToString(row["regex"]));
            }

            int number = dicCity.Count;
            for (int i = 0; i < number; i++)
            {
                int key = dicCity.ElementAt(i).Key;
                if (this.dicRegexCity.ContainsKey(key)) dicCity[key] = this.dicRegexCity[key];

            }
        }

        Thread thread = null;

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (thread == null)
            {
                thread = new Thread(() => RunData());
                thread.Start();
            }
            else
            {
                this.Stoped = false;
            }

            this.btnRun.Visible = false;
            this.btnStop.Visible = true;
        }

        public void WriteLog(string logText)
        {
            this.Invoke(new Action(() =>
                {
                    if (this.richLogData.TextLength > 10000) this.richLogData.Clear();
                    this.richLogData.AppendText("\n" + logText);
                }));
        }

        public void RunData ()
        {
            while (!this.Stoped)
            {
                this.WriteLog("--------------------Request data to process...");
                var lstProduct = mongoDbAdapter.GetProductLastUpdateFrom(DateTime.Now, 100).Result;
                
                if (lstProduct != null && lstProduct.Count > 0)
                {
                    this.WriteLog("Number job need process:" + lstProduct.Count.ToString());
                    foreach (var product in lstProduct)
                    {
                        //Dịch City.
                        this.WriteLog(string.Format("Process for _id:{0}", (product["_id"] as BsonObjectId).ToString()));
                        string strProvince = product["province"].AsString;
                        List<int> cityIDs = new List<int>();
                        foreach (var item in dicCity)
                        {
                            string strProvinceChuan = strProvince.ToLower();
                            if (Regex.IsMatch(strProvinceChuan, item.Value))
                            {
                                cityIDs.Add(item.Key);
                            }
                        }

                        if (cityIDs.Count > 0)
                        {
                            mongoDbAdapter.UpdateCitys(product["_id"] as BsonObjectId, cityIDs);
                            this.WriteLog(string.Format("Search City => {0}", QT.Entities.Common.ConvertToString(cityIDs, ";")));
                        }

                        //Dịch Term.
                        if (!product.Contains("tasg") || product["term_ids"].BsonType==BsonType.Null)
                        {
                        }

                        mongoDbAdapter.ProcessedData(product["_id"] as BsonObjectId);
                        mongoDbAdapter.SetWaitToUpdateSolr(product["_id"] as BsonObjectId);
                    }
                }
                Thread.Sleep(10000);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Stoped = true;
            this.btnRun.Visible = true;
        }

        private void FrmFindExtraInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Stoped = true;
            Thread.Sleep(5000);
        }

        private void FrmFindExtraInfo_Load(object sender, EventArgs e)
        {
            this.btnStop.Visible = false;
        }
    }
}
