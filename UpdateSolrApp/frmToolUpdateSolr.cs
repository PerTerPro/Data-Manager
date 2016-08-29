using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cms.PoolConnection;
using Excel;
using QT.Entities;
using SolrNet.Exceptions;
using UpdateSolrTools.ProductDatasetTableAdapters;
using UpdateSolrTools.UserDataSetTableAdapters;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Common.BO;
using Websosanh.Core.Product.BAL;
using Websosanh.Core.Product.BO;
using Websosanh.Core.Product.DAL;
using SolrNet;
using SolrNet.Commands.Parameters;
using log4net;
using UTF_Converter;
using UpdateSolrTools;
using Websosanh.Core.Drivers.Solr;


namespace UpdateSolrApp
{
    public partial class FrmToolUpdateSolr : frmBase
    {

        private string _activeSolrNodeId;
        private SolrIndexer solrIndexer;
        private string solrKeywordNodeID = "node1";
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmToolUpdateSolr));
        public FrmToolUpdateSolr()
        {
            Init();
            this.Text = "Update Solr";
            this.Text = this.Text + _productConnectionString.Substring(0, 20);
        }

        private const long ID_WEBSOSANH = 6619858476258121218;
        private Task updateTask;
        private Task updateCompany;
        private Task updateRootProductTask;
        private Task UpdateProductPropertiesTask;
        private Task runAllTask;
        private string _productConnectionString;
        private string _userConnectionString;
        private string _searchEnginesServiceUrl;

        private void InitData()
        {
            this.Invoke((MethodInvoker)delegate
            {
                panelMainControl.Enabled = false;
            });
            var listMerchantUseDatafeedID = IndexProductTools.GetListMerchantUseDatafeedID(_productConnectionString); ;
            var listSpecialMerchantID = IndexProductTools.GetListSpecialMerchantID(_productConnectionString);
            var listPriorMerchants = IndexProductTools.GetAllPriorMerchants(_productConnectionString);
            var listBadMerchant = IndexProductTools.GetAllBadMerchantId(_productConnectionString,35);
            solrIndexer.ListMerchantUseDatafeedID = listMerchantUseDatafeedID;
            solrIndexer.ListSpecialMerchantID = listSpecialMerchantID;
            solrIndexer.ListPriorMerchants = listPriorMerchants;
            solrIndexer.ListBadMerchantID = listBadMerchant;
            var regionTree = RegionBAL.GetRegionTree(_productConnectionString);
            var categoryTree = ProductCategoryBAL.GetProductCategoryTree(_productConnectionString);
            var categoryTags = IndexProductTools.GetAllCategoryTags(_productConnectionString);
            var listPrefixCategory = IndexProductTools.GetAllPrefixCategory(_productConnectionString);
            solrIndexer.RegionTree = regionTree;
            solrIndexer.CategoryTree = categoryTree;
            solrIndexer.CategoryTags = categoryTags;
            solrIndexer.ListPrefixCategory = listPrefixCategory;
            var propertyValueDictionary = WebProductPropertyBAL.GetAllPropertyValues(_productConnectionString);
            var propertyUnitDictionary = WebProductPropertyBAL.GetPropertyUnitDictionary(_productConnectionString);
            solrIndexer.PropertyUnitDictionary = propertyUnitDictionary;
            solrIndexer.PropertyValueDictionary = propertyValueDictionary;
            this.Invoke((MethodInvoker)delegate
            {
                panelMainControl.Enabled = true;
            });
        }

        private void Init()
        {
            InitializeComponent();
                _productConnectionString =
                    ConfigurationManager.ConnectionStrings["ProductConnectionString"]
                        .ToString();
                _userConnectionString =
                    ConfigurationManager.ConnectionStrings["UserConnectionString"]
                        .ToString();
                _searchEnginesServiceUrl = ConfigurationManager.AppSettings["searchEnginesServiceUrl"];
            solrIndexer = new SolrIndexer();
            solrIndexer.ConnectionStringProducts = _productConnectionString;
            solrIndexer.SolrClient = SolrProductClient.GetClient(SolrClientManager.GetSolrClient(SolrProductConstants.SOLR_NODE_PRODUCTS));
            var taskGetData = new Task(InitData);
            taskGetData.Start();
        }

        private void DoUpdateSolrRootProduct()
        {            
            string message;
            this.Invoke((MethodInvoker)delegate
                {
                    WriteLog("Updating root products...");
                });
            solrIndexer.UpdateAllRootProducts(out message, _productConnectionString,_userConnectionString,_searchEnginesServiceUrl);
            this.Invoke((MethodInvoker)delegate
            {
                this.richTextBoxInfo.AppendText(message);
            });
        }
        private void btnStop_Click(object sender, EventArgs e)
        {

            // create the cancellation token source 
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            // create the cancellation token 
            CancellationToken token = tokenSource.Token;
            // create the task 
            
            Task task = new Task(() =>
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Task cancel detected");
                        throw new OperationCanceledException(token);
                    }
                    else
                    {
                        Console.WriteLine("Int value {0}", i);
                    }
                }
            }, token);
            task.Start();
            tokenSource.Cancel();
            btnUpdateAll.Enabled = true;
        }

        private void btUpdateSolr_Click(object sender, EventArgs e)
        {
                updateTask = new Task(DoUpdateSolrIndex);
                updateTask.Start();

        }

        private void frmToolUpdateSolr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (updateTask != null)
            {
                if (updateTask.Status == TaskStatus.Running)
                {
                    updateTask.Dispose();
                    updateTask.Wait();
                    updateTask = null;
                }
            }
            if (updateCompany != null)
            {
                if (updateCompany.Status == TaskStatus.Running)
                {
                    updateCompany.Dispose();
                    updateCompany.Wait();
                    updateCompany = null;
                }
            }
            if (updateRootProductTask != null)
            {
                if (updateRootProductTask.Status == TaskStatus.Running)
                {
                    updateRootProductTask.Dispose();
                    updateRootProductTask.Wait();
                    updateRootProductTask = null;
                }
            }
            if (UpdateProductPropertiesTask != null)
            {
                if (UpdateProductPropertiesTask.Status == TaskStatus.Running)
                {
                    UpdateProductPropertiesTask.Dispose();
                    UpdateProductPropertiesTask.Wait();
                    UpdateProductPropertiesTask = null;
                }
            }

        }

        private void btUpdateSolrID_Click(object sender, EventArgs e)
        {
                updateRootProductTask = new Task(DoUpdateSolrRootProduct);
                updateRootProductTask.Start();
        }


        /// <summary>
        ///  Update toàn bộ sản phẩm gốc các giá trị thuộc tính và value cần filter và sort vào bảng 116975105
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }



      
        void DoUpdateSolrIndex()
        {
            this.Invoke((MethodInvoker)(() =>
                WriteLog(String.Format("Start download List company"))));
            var companyTableAdapter = new CompanyDataSetTableAdapters.CompanyTableAdapter();
            companyTableAdapter.Connection.ConnectionString = _productConnectionString;
            var companyDataTable = companyTableAdapter.GetAllMerchants();
            var numCompany = companyDataTable.Count;
            this.Invoke((MethodInvoker)(() =>
                WriteLog(String.Format("Downloaded {0} company", numCompany))));
            var remainCompanyList =
                solrIndexer.SolrClient.GetAllCompany().Where(x => x.Value > 0).Select(x => x.Key).Select(long.Parse).ToList();
            
            int companyIndex = 0;
            //lazada           
            foreach (var companyDataRow in companyDataTable)
            {
                try
                {
                    companyIndex++;
                    CompanyDataSet.CompanyRow tmpCompanyDataRow = companyDataRow;
                    int index = companyIndex;
                    Invoke((MethodInvoker) (() =>
                        WriteLog(String.Format("Start Update company {0} ({1}/{2})", tmpCompanyDataRow.Domain, index, numCompany))));
                    remainCompanyList.Remove(companyDataRow.ID);
                    int tryCount = 0;
                    while (true)
                    {                        
                        var numProducts = solrIndexer.UpdateAllProductOfMerchant(companyDataRow.ID, companyDataRow.Domain);
                        tryCount++;
                        if (numProducts >= 0)
                        {
                            Invoke((MethodInvoker)(() =>
                                WriteLog(String.Format("Updated company {0} - {1} products -- {2}/{3}", tmpCompanyDataRow.Domain,
                                    numProducts, index, numCompany))));
                            break;
                        }
                        else
                        {
                            Invoke((MethodInvoker)(() =>
                                WriteLog(String.Format("ERROR!!!! Update Company {0} failed - Error code {1}", tmpCompanyDataRow.Domain,
                                    numProducts))));                            
                            if (tryCount >= 4)
                                break;
                            Thread.Sleep(30000);
                        }
                    }
                }
                catch (SqlException sqlex)
                {
                    WriteLog("Do update Solr Products", sqlex);
                }
                catch (SolrConnectionException solrConnEx)
                {
                    WriteLog("Do update Solr Products", solrConnEx);
                }
            }
            try
            {
                remainCompanyList.Remove(ID_WEBSOSANH);
                foreach (var companyId in remainCompanyList)
                {
                    solrIndexer.SolrClient.DeleteByCompanyId(companyId);
                }
                solrIndexer.Commit();
                solrIndexer.Optimize();
                this.Invoke((MethodInvoker)(() => WriteLog("Commit and optimize...")));
            }
            catch (Exception ex)
            {
                WriteLog("Do update Solr Products",ex);
            }
            companyDataTable.Dispose();
            companyTableAdapter.Dispose();
        }

       
        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            this.richTextBoxInfo.Clear();
        }

        private void buttonCommitSolr_Click(object sender, EventArgs e)
        {
            var commitTask = new Task(RunCommitSolr);
            commitTask.Start();
        }

        private void RunCommitSolr()
        {
            solrIndexer.SolrClient.Commit();
            this.Invoke((MethodInvoker)delegate
            {
                this.richTextBoxInfo.AppendText("Committed");
            });
        }

        private void buttonOptimizeSolr_Click(object sender, EventArgs e)
        {
            var optimizeTask = new Task(RunOptimizeSolr);
            optimizeTask.Start();
        }
        private void RunOptimizeSolr()
        {
            solrIndexer.SolrClient.Optimize();
            this.Invoke((MethodInvoker)delegate
            {
                this.richTextBoxInfo.AppendText("Optimized");
            });
        }
        private void FrmToolUpdateSolr_Load(object sender, EventArgs e)
        {
            
        }
              

      
        private void WriteLog(string context,Exception ex)
        {
            WriteLog(context +"\n" + ex.Message + "\n" + ex.StackTrace);
        }

        private void WriteLog(string log)
        {
            this.richTextBoxInfo.AppendText(string.Format("[{0:u}] - {1}\n",DateTime.Now,log));
        }

        private void comboBoxSolrNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (tabMain.SelectedTab == tabMain.TabPages["tabPage2"])
            {
                var TaskCompany = new Task(GetDataCompany);
                TaskCompany.Start();
                
                
            }
        }
        private DataTable tblCompany;
        List<string> listWebsite;
        void GetDataCompany()
        {
            this.Invoke((MethodInvoker)(() =>
                        WriteLogCompany(String.Format("loading company... "))));
            CompanyDataSetTableAdapters.CompanyTableAdapter company = new CompanyDataSetTableAdapters.CompanyTableAdapter
            {
                Connection = { ConnectionString = _productConnectionString }
            };
            if (tblCompany == null || tblCompany.Rows.Count <= 0)
                tblCompany = company.GetData();
            this.Invoke((MethodInvoker)delegate
            {
                this.dataGridViewListCompany.DataSource = tblCompany;
            });
            if (listWebsite == null)
            {                
                listWebsite = new List<string>();
                listWebsite.Add("");
                foreach (DataRow row in tblCompany.Rows)
                {
                    string domain = row["Domain"].ToString();
                    domain = domain.Replace("www.", string.Empty);
                    listWebsite.Add(domain);
                }
            }
            this.Invoke((MethodInvoker)delegate
            {
                this.txtCompanyName.DataSource = listWebsite;
            });
            this.Invoke((MethodInvoker)(() =>
                        WriteLogCompany(String.Format("loaded " + tblCompany.Rows.Count + " company complete... "))));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtID.Text))
                    (dataGridViewListCompany.DataSource as DataTable).DefaultView.RowFilter = string.Format("Domain Like '%{0}%'", txtCompanyName.Text);
                else
                    (dataGridViewListCompany.DataSource as DataTable).DefaultView.RowFilter = string.Format("Domain Like '%{0}%' AND ID = {1}", txtCompanyName.Text, txtID.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCompanyName.Text = "";
            txtID.Text = "";
            richTxtView.Text = "";
            (dataGridViewListCompany.DataSource as DataTable).DefaultView.RowFilter = null;
        }

        private void WriteLogCompany(string context, Exception ex)
        {
            WriteLogCompany(context + "\n" + ex.Message + "\n" + ex.StackTrace);
        }

        private void WriteLogCompany(string log)
        {
            this.richTxtView.AppendText(string.Format("[{0:u}] - {1}\n", DateTime.Now, log));
        }

        private int rowIndex = 0;
        private int rowIndex2 = 0;
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.dataGridViewListCompany.Rows[this.rowIndex].IsNewRow)
                {
                    DataGridViewRow row = this.dataGridViewListCompany.Rows[this.rowIndex];
                    string domain = row.Cells["Domain"].Value.ToString();
                    long id = Convert.ToInt64(row.Cells["ID"].Value);
                    updateCompany = new Task(() => DoUpdateComapny(id, domain));
                    updateCompany.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        void DoUpdateComapny(long id, string domain)
        {
            this.Invoke((MethodInvoker)(() =>
                        WriteLogCompany(String.Format("updating... " + domain))));            
            int result = solrIndexer.UpdateAllProductOfMerchant(id, domain);
            solrIndexer.Commit();
            if (result >= 0)
                this.Invoke((MethodInvoker)(() =>
                WriteLogCompany(String.Format("update completed company " + domain +  "... insert " + result + " products"))));
            else
                if (result >= 0)
                    this.Invoke((MethodInvoker)(() =>
                    WriteLogCompany(String.Format("error " + result))));

        }
        private DataTable tblScheduleCom;
  
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridViewListCompany.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridViewListCompany.CurrentCell = this.dataGridViewListCompany.Rows[e.RowIndex].Cells[1];
                this.contextMenuStripListCompany.Show(this.dataGridViewListCompany, e.Location);
                contextMenuStripListCompany.Show(Cursor.Position);
            }
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtID.Text))
                    (dataGridViewListCompany.DataSource as DataTable).DefaultView.RowFilter = string.Format("Domain Like '%{0}%'", txtCompanyName.Text);
                else
                    (dataGridViewListCompany.DataSource as DataTable).DefaultView.RowFilter = string.Format("Domain Like '%{0}%' AND ID = {1}", txtCompanyName.Text, txtID.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtCompanyName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtID.Text))
                    (dataGridViewListCompany.DataSource as DataTable).DefaultView.RowFilter = string.Format("Domain Like '%{0}%'", txtCompanyName.Text);
                else
                    (dataGridViewListCompany.DataSource as DataTable).DefaultView.RowFilter = string.Format("Domain Like '%{0}%' AND ID = {1}", txtCompanyName.Text, txtID.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtdelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.dataGridViewListCompany.Rows[this.rowIndex].IsNewRow)
                {
                    DataGridViewRow row = this.dataGridViewListCompany.Rows[this.rowIndex];
                    string name = row.Cells["Name"].Value.ToString();
                    long id = Convert.ToInt64(row.Cells["ID"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.dataGridViewRunningCompany.Rows[this.rowIndex2].IsNewRow)
                {
                    DataGridViewRow row = this.dataGridViewRunningCompany.Rows[this.rowIndex2];
                    string name = row.Cells["Name"].Value.ToString();
                    long id = Convert.ToInt64(row.Cells["ID"].Value);
                    DataRow[] rowSch = tblScheduleCom.Select("ID = " + id);
                    tblScheduleCom.Rows.Remove(rowSch[0]);
                    dataGridViewRunningCompany.DataSource = tblScheduleCom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridViewRunningCompany.Rows[e.RowIndex].Selected = true;
                this.rowIndex2 = e.RowIndex;
                this.dataGridViewRunningCompany.CurrentCell = this.dataGridViewRunningCompany.Rows[e.RowIndex].Cells[1];
                this.contextMenuStripRunningCompany.Show(this.dataGridViewRunningCompany, e.Location);
                contextMenuStripRunningCompany.Show(Cursor.Position);
            }
        }

        private void buttonOpenExcelFile_Click(object sender, EventArgs e)
        {
            var openDataFeedFileResult = openExcelFileDialog.ShowDialog();
            if (openDataFeedFileResult == DialogResult.OK)
            {
                txtExcelFileDir.Text = string.Join(";", openExcelFileDialog.FileNames);
            }
        }

        private void buttonSelectOutputDir_Click(object sender, EventArgs e)
        {
            var folderBrowserResult = synonymsFilesOutputFolderBrowserDialog.ShowDialog();
            if (folderBrowserResult == DialogResult.OK)
            {
                textBoxOutputFilesDir.Text = synonymsFilesOutputFolderBrowserDialog.SelectedPath;
            }
        }

        private void buttonCreateSynonymFiles_Click(object sender, EventArgs e)
        {
            //
            StringBuilder autoPhrasesFileTextBuilder = new StringBuilder();
            StringBuilder synonymFileTextBuilder = new StringBuilder();
            FileStream stream = File.Open(txtExcelFileDir.Text, FileMode.Open, FileAccess.Read);

            IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);

            //excelReader.IsFirstRowAsColumnNames = true;
            //5. Data Reader methods
            
            while (excelReader.Read())
            {
                var synonymPhrases = new List<string>();
                var fieldCount = excelReader.FieldCount;
                for (int colIndex = 0; colIndex < fieldCount; colIndex ++)
                {
                    var phrase = excelReader.GetString(colIndex);
                    if (!string.IsNullOrEmpty(phrase))
                    {
                        var normalizedPhrase = SolrDriverUtilities.NormalizeSearchString(phrase);
                        if(normalizedPhrase.Split(' ').Length > 1)
                        autoPhrasesFileTextBuilder.AppendFormat("{0}\r\n",normalizedPhrase);
                        var autoPhrasePhrase = SolrDriverUtilities.ToAutoPhrase(normalizedPhrase);
                        synonymPhrases.Add(autoPhrasePhrase);
                    }
                }
                if (synonymPhrases.Count > 1)
                    synonymFileTextBuilder.AppendFormat("{0}\r\n", string.Join(",", synonymPhrases));
            }
            excelReader.Close();
            var autoPhraseFilePath = string.Format("{0}\\autoPhrases.txt", textBoxOutputFilesDir.Text);
            var synonymsFilePath = string.Format("{0}\\synonyms.txt", textBoxOutputFilesDir.Text);
            File.WriteAllText(autoPhraseFilePath,autoPhrasesFileTextBuilder.ToString(),Encoding.UTF8);
            File.WriteAllText(synonymsFilePath, synonymFileTextBuilder.ToString(), Encoding.UTF8);
        }

        private void ReIndexKeyword()
        {
            //KeywordBAL.ReIndexKeywords(_productConnectionString, solrKeywordNodes, solrKeywordNodeID);
        }

        private void buttonReIndexKeyword_Click(object sender, EventArgs e)
        {
            var reIndexKeywordTask = new Task(ReIndexKeyword);
            reIndexKeywordTask.Start();
        }

        private void buttonScheduleUpdate_Click(object sender, EventArgs e)
        {
            var scheduleTask = new Task(ScheduleUpdate);
            scheduleTask.Start();
        }

        private void ScheduleUpdate()
        {
            this.Invoke((MethodInvoker)delegate
                    {
                        buttonScheduleUpdate.Enabled = false;
                    });
            while (true)
            {
                Thread.Sleep(1000);
                if (DateTime.Now.TimeOfDay < new TimeSpan(23, 30, 0))
                    continue;
                try
                {
                    DoUpdateSolrRootProduct();
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        WriteLog("Updating Root Products",ex);
                    });
                }
                try
                {
                    DoUpdateSolrIndex();
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        WriteLog("Updating Merchant Products",ex);
                    });
                }                
                
            }
            this.Invoke((MethodInvoker)delegate
            {
                buttonScheduleUpdate.Enabled = true;
            });

        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {

        }

        private void simpleButtonUpdateProduct_Click(object sender, EventArgs e)
        {
            var productID = long.Parse(textEditProductID.Text);
            solrIndexer.UpdateRootProducts(new List<long>{productID}, _productConnectionString, _userConnectionString, _searchEnginesServiceUrl);

        }



    }

    class SolrNodeItem
    {
         public String NodeID { get; set; }
        public String NodeUrl { get; set; }

        public override string ToString()
        {
            return NodeUrl;
        }
    }
}
