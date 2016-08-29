using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.MerchantRankByWebsosanh
{
    public partial class frmGoogleSheetApi : Form
    {
        private string[] _scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        private string ApplicationName = "WssMerchantScore";
        private UserCredential _credential;
        private string _spreadsheetId = "1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms";
        private readonly string _connectionString;
        public frmGoogleSheetApi()
        {
            InitializeComponent();
            _connectionString = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
            LoadApi();
        }
        private void LoadApi()
        {
            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");

                _credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    _scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                //Console.WriteLine("Credential file saved to: " + credPath); 
            }
            //get spreadsheetId từ config
            //spreadsheetId = ....
        }

        private List<MerchantScore> listMerchantScore;
        private void btnGetGoogleSheet_Click(object sender, EventArgs e)
        {
            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = _credential,
                ApplicationName = ApplicationName,
            });

            _spreadsheetId = txtSpreadsheetId.Text;
           // String range = "Rank_Final";
            string range = txtRange.Text;

            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(_spreadsheetId, range);
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                listMerchantScore = new List<MerchantScore>();
                int index = 0;
                foreach (var row in values)
                {
                    if (index == 0)
                    {
                        index++;
                        continue;
                    } 
                    MerchantScore merchantScore = new MerchantScore();
                    merchantScore.MerchantWebsite = row[0].ToString();
                    merchantScore.MerchantId = GetIDCompanyFromWebsite(row[0].ToString());
                    merchantScore.ScoreNumberProduct1 = Common.Obj2Int(row[1].ToString());
                    merchantScore.ScoreStore1 = Common.Obj2Int(row[2].ToString());
                    merchantScore.ScoreTraffic1 = Common.Obj2Double(row[3].ToString());
                    merchantScore.ScoreAdvertisementPR1 = Common.Obj2Int(row[4].ToString());
                    merchantScore.ScoreScandal1 = Common.Obj2Int(row[5].ToString());
                    merchantScore.TotalPart1 = Common.Obj2Int(row[6].ToString());

                    merchantScore.ScoreAddressStore2 = Common.Obj2Int(row[7].ToString());
                    merchantScore.ScorePhoneNumberAvaiable2 = Common.Obj2Int(row[8].ToString());
                    merchantScore.ScoreCustomerServices2 = Common.Obj2Int(row[9].ToString());
                    merchantScore.TotalPart2 = Common.Obj2Double(row[10].ToString());

                    merchantScore.ScoreProductInformation3 = Common.Obj2Int(row[11].ToString());
                    merchantScore.ScoreWebsosanhRate3 = Common.Obj2Int(row[12].ToString());
                    merchantScore.ScoreGoogleRate3 = Common.Obj2Int(row[13].ToString());
                    merchantScore.ScoreRateWebsite3 = Common.Obj2Int(row[14].ToString());
                    merchantScore.TotalPart3 = Common.Obj2Int(row[15].ToString());

                    merchantScore.ScoreStatusProduct4 = Common.Obj2Int(row[16].ToString());

                    merchantScore.ScoreSignContract5 = Common.Obj2Int(row[17].ToString());
                    merchantScore.ScoreResignContract5 = Common.Obj2Int(row[18].ToString());
                    merchantScore.ScorePotential5 = Common.Obj2Int(row[19].ToString());
                    merchantScore.ScoreSales5 = Common.Obj2Int(row[20].ToString());
                    merchantScore.TotalPart5 = Common.Obj2Double(row[21].ToString());

                    merchantScore.Score = Common.Obj2Double(row[27].ToString());

                    listMerchantScore.Add(merchantScore);
                    index++;
                }
                gridControl1.DataSource = listMerchantScore;
            }
        }
        private long GetIDCompanyFromWebsite(string website)
        {
            long idcompany = 0;
            Regex regex1 = new Regex(@"http://[^/]+/");
            Regex regex2 = new Regex(@"https://[^/]+/");
            if (regex1.IsMatch(website))
            {
                website = regex1.Matches(website)[0].Value.Replace(@"http://www.", "").Replace(@"http://", "").Replace(@"/", "");
            }
            else if (regex2.IsMatch(website))
            {
                website = regex2.Matches(website)[0].Value.Replace(@"https://www.", "").Replace(@"https://", "").Replace(@"/", "");
            }
            else
                website = "";
            idcompany = Common.GetIDCompany(website);
            return idcompany;
        }

        private void btnUpdateSQL_Click(object sender, EventArgs e)
        {
            if (listMerchantScore.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu cập nhật");
            }
            else
            {
                Thread tr = new Thread(UpdateMerchantScoreToSQL);
                tr.Start();
            }
        }
        private void UpdateMerchantScoreToSQL()
        {
            DBScoreTableAdapters.MerchantScoreTableAdapter merchantscoreAdapter = new DBScoreTableAdapters.MerchantScoreTableAdapter();
            merchantscoreAdapter.Connection.ConnectionString = _connectionString;
            DBScore.MerchantScoreDataTable merchantscoreTable = new DBScore.MerchantScoreDataTable();
            HashSet<long> listidmerchant = new HashSet<long>();
            try
            {
                merchantscoreAdapter.FillAllMerchantId(merchantscoreTable);
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    rbMessage.AppendText("Error get list merchant in SQL: " + System.Environment.NewLine + ex.ToString());
                }));
                return;
            }
            if (merchantscoreTable.Count > 0)
            {
                for (int i = 0; i < merchantscoreTable.Count; i++)
                {
                    listidmerchant.Add(Common.Obj2Int64(merchantscoreTable.Rows[i]["MerchantId"]));
                }
            }
            foreach (var item in listMerchantScore)
            {
                if (listidmerchant.Contains(item.MerchantId))
                {
                    //update
                    try
                    {
                        merchantscoreAdapter.UpdateQuery(item.ScoreNumberProduct1, item.ScoreStore1, item.ScoreTraffic1, item.ScoreAdvertisementPR1,
                            item.ScoreScandal1, item.TotalPart1, item.ScoreAddressStore2, item.ScorePhoneNumberAvaiable2, item.ScoreCustomerServices2, item.TotalPart2,
                            item.ScoreProductInformation3, item.ScoreWebsosanhRate3, item.ScoreGoogleRate3, item.ScoreRateWebsite3, item.TotalPart3, item.ScoreStatusProduct4,
                            item.ScoreSignContract5, item.ScoreResignContract5, item.ScorePotential5, item.ScoreSales5, item.TotalPart5, item.Score,item.MerchantId);
                        this.Invoke(new Action(() =>
                        {
                            rbMessage.AppendText(item.MerchantWebsite +" update success!" + System.Environment.NewLine);
                        }));
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new Action(() =>
                        {
                            rbMessage.AppendText("Error update merchantscore: "+item.MerchantWebsite + System.Environment.NewLine + ex.ToString());
                        }));
                    }
                }
                else
                {
                    //insert
                    try
                    {
                        merchantscoreAdapter.Insert(item.MerchantId,item.ScoreNumberProduct1,item.ScoreStore1,item.ScoreTraffic1,item.ScoreAdvertisementPR1,
                            item.ScoreScandal1,item.TotalPart1,item.ScoreAddressStore2,item.ScorePhoneNumberAvaiable2,item.ScoreCustomerServices2,item.TotalPart2,
                            item.ScoreProductInformation3,item.ScoreWebsosanhRate3,item.ScoreGoogleRate3,item.ScoreRateWebsite3,item.TotalPart3,item.ScoreStatusProduct4,
                            item.ScoreSignContract5,item.ScoreResignContract5,item.ScorePotential5,item.ScoreSales5,item.TotalPart5,item.Score);
                        this.Invoke(new Action(() =>
                        {
                            rbMessage.AppendText(item.MerchantWebsite + " insert success!" + System.Environment.NewLine);
                        }));
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new Action(() =>
                        {
                            rbMessage.AppendText("Error insert merchantscore: " + item.MerchantWebsite + System.Environment.NewLine + ex.ToString());
                        }));
                    }
                }
                
            }
        }
    }
}
