using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities;

namespace WSS.MerchantRankByWebsosanh
{
    public partial class frmCheckRank : Form
    {
        private readonly string _connectionString;
        public frmCheckRank()
        {
            InitializeComponent(); 
            _connectionString = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Thread thread = new Thread(() => Run(openFileDialog1.FileName));
                thread.Start();
            }
        }

        private void Run(string fileName)
        {
            var dictCompanyRank = new Dictionary<long, double>();
            var merchantscoreAdapter = new DBScoreTableAdapters.MerchantScoreTableAdapter();
            merchantscoreAdapter.Connection.ConnectionString = _connectionString;
            var merchantscoreTable = new DBScore.MerchantScoreDataTable();
            merchantscoreAdapter.FillAllMerchantId(merchantscoreTable);
            if (merchantscoreTable.Count > 0)
            {
                for (int i = 0; i < merchantscoreTable.Count; i++)
                {
                    long merchantId = Common.Obj2Int64(merchantscoreTable.Rows[i]["MerchantId"]);
                    dictCompanyRank.Add(merchantId, Common.Obj2Double(merchantscoreTable.Rows[i]["Score"]));
                }
            }
            try
            {
                int counter = 0;
                string line;
                List<MerchantRankInfo> listMerchantFinal = new List<MerchantRankInfo>();
                // Read the file and display it line by line.
                System.IO.StreamReader file =
                   new System.IO.StreamReader(fileName);
                while ((line = file.ReadLine()) != null)
                {
                    long idcompany = Convert.ToInt64(line.Split(',')[0]);
                    string domain = line.Split(',')[1];
                    double score = 0;
                    if (dictCompanyRank.ContainsKey(idcompany))
                    {
                        score = dictCompanyRank[idcompany];
                    }
                    MerchantRankInfo mrInfo = new MerchantRankInfo()
                    {
                        Domain = domain,
                        MerchantId = idcompany.ToString(),
                        Score = score
                    };
                    listMerchantFinal.Add(mrInfo);
                    this.Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText(string.Format("{0}.MerchantId = {1} : Score: {2}",counter,idcompany,score)+System.Environment.NewLine);
                    }));
                    counter++;
                }
                this.Invoke(new Action(() =>
                {
                    gridControl1.DataSource = listMerchantFinal;
                }));
                file.Close();
            }
            catch (Exception)
            {

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;
                    //NImageExporter imageExporter = chartControl.ImageExporter;
                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl1.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl1.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl1.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl1.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl1.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl1.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }

    public class MerchantRankInfo
    {
        public string MerchantId { set; get; }
        public string Domain { set; get; }
        public double Score { set; get; }
    }
}
