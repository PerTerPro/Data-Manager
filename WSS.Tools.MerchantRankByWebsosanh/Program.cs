using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using QT.Entities;
using System.Data.Entity.Infrastructure;
using log4net;


namespace WSS.Tools.MerchantRankByWebsosanh
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));
        private static string[] _scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        private static string _applicationName = "WssMerchantScore";
        private static UserCredential _credential;
        private static string _spreadsheetId = "1lQEUNj7tvuLxX1ZM27Xq7iDzmwp0KBk9LpyCLa9BBns";
        private static string _range = "Rank_Final";
        private static string _connectionString;
        private static List<MerchantScore> _listMerchantScore;
        static void Main(string[] args)
        {
            _connectionString = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
            _spreadsheetId = System.Configuration.ConfigurationSettings.AppSettings["SpreadsheetId"];
            _range = System.Configuration.ConfigurationSettings.AppSettings["Range"];
            LoadApi();
            GetDataFromGoogleSheet();
            UpdateDataToSql();
        }
        private static void LoadApi()
        {
            try
            {
                using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
                {
                    var credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                    credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");
                    _credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        _scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    Console.WriteLine("Credential file saved to: " + credPath);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Load Api error: " + exception);
                Log.Error("Load Api error: "+ exception);
            }
        }

        private static void GetDataFromGoogleSheet()
        {
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = _credential,
                ApplicationName = _applicationName,
            });

            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(_spreadsheetId, _range);
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                _listMerchantScore = new List<MerchantScore>();
                int index = 0;
                foreach (var row in values)
                {
                    Console.WriteLine("Get data from google sheet row {0}", index);
                    if (index == 0)
                    {
                        index++;
                        continue;
                    }
                    var merchantScore = new MerchantScore
                    {
                        MerchantWebsite = row[0].ToString(),
                        MerchantId = GetIdCompanyFromWebsite(row[0].ToString()),
                        ScoreNumberProduct1 = Common.Obj2Int(row[1].ToString()),
                        ScoreStore1 = Common.Obj2Int(row[2].ToString()),
                        ScoreTraffic1 = Common.Obj2Double(row[3].ToString()),
                        ScoreAdvertisementPR1 = Common.Obj2Int(row[4].ToString()),
                        ScoreScandal1 = Common.Obj2Int(row[5].ToString()),
                        TotalPart1 = Common.Obj2Int(row[6].ToString()),
                        ScoreAddressStore2 = Common.Obj2Int(row[7].ToString()),
                        ScorePhoneNumberAvaiable2 = Common.Obj2Int(row[8].ToString()),
                        ScoreCustomerServices2 = Common.Obj2Int(row[9].ToString()),
                        TotalPart2 = Common.Obj2Double(row[10].ToString()),
                        ScoreProductInformation3 = Common.Obj2Int(row[11].ToString()),
                        ScoreWebsosanhRate3 = Common.Obj2Int(row[12].ToString()),
                        ScoreGoogleRate3 = Common.Obj2Int(row[13].ToString()),
                        ScoreRateWebsite3 = Common.Obj2Int(row[14].ToString()),
                        TotalPart3 = Common.Obj2Int(row[15].ToString()),
                        ScoreStatusProduct4 = Common.Obj2Int(row[16].ToString()),
                        ScoreSignContract5 = Common.Obj2Int(row[17].ToString()),
                        ScoreResignContract5 = Common.Obj2Int(row[18].ToString()),
                        ScorePotential5 = Common.Obj2Int(row[19].ToString()),
                        ScoreSales5 = Common.Obj2Int(row[20].ToString()),
                        TotalPart5 = Common.Obj2Double(row[21].ToString()),
                        Score = Common.Obj2Double(row[27].ToString())
                    };
                    _listMerchantScore.Add(merchantScore);
                    index++;
                }
            }
        }
        private static long GetIdCompanyFromWebsite(string website)
        {
            long idcompany = 0;
            Regex regex1 = new Regex(@"http://[^/]+/");
            Regex regex2 = new Regex(@"https://[^/]+/");
            if (regex1.IsMatch(website))
                website = regex1.Matches(website)[0].Value.Replace(@"http://www.", "").Replace(@"http://", "").Replace(@"/", "");
            else if (regex2.IsMatch(website))
                website = regex2.Matches(website)[0].Value.Replace(@"https://www.", "").Replace(@"https://", "").Replace(@"/", "");
            else if (website.Contains(@"http://www."))
                website = website.Replace(@"http://www.", "");
            else if (website.Contains(@"https://www."))
                website = website.Replace(@"https://www.", "");
            else
                website = "";
            idcompany = Common.GetIDCompany(website);
            return idcompany;
        }
        private static void UpdateDataToSql()
        {
            if (_listMerchantScore.Count > 0)
            {
                HashSet<long> listIdMerchant = new HashSet<long>();
                var dB = new WebsosanhEntities();
                dB.Database.Connection.ConnectionString = _connectionString;
                #region Get list MerchantId in SQL

                var query = from b in dB.MerchantScores
                            select new {b.MerchantId };

                foreach (var item in query)
                {
                    listIdMerchant.Add(item.MerchantId);
                    //Console.WriteLine("get id {0}",item);
                }
                #endregion
                
                foreach (var item in _listMerchantScore)
                {
                    if (listIdMerchant.Contains(item.MerchantId))
                    {
                        dB.MerchantScores.Attach(dB.MerchantScores.Single(c => c.MerchantId == item.MerchantId));
                        ((IObjectContextAdapter) dB).ObjectContext.ApplyCurrentValues("MerchantScores", item);
                        //var merchantScore = new MerchantScore{MerchantId = item.MerchantId};
                        //dB.Entry(merchantScore).CurrentValues.SetValues(item);
                    }
                    else
                    {
                        dB.MerchantScores.Add(item);
                    }
                }
                dB.SaveChanges();
            }
        }
    }
}
