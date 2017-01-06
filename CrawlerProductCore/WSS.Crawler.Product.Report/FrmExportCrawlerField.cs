using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmExportCrawlerField : Form
    {
        public FrmExportCrawlerField()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.UpdateData();

        }

        private void UpdateData()
        {
            Task.Factory.StartNew(() =>
            {
                this.Invoke(new Action(() =>
                {
                    btnExport.Visible = false;
                }));

                int countCompany = 0;
                ProductAdapter productAdapter = new ProductAdapter(new SqlDb(Server.ConnectionString));
                foreach (long companyID in productAdapter.GetAllCompanyId())
                {
                    while (true)
                    {
                        try
                        {
                            countCompany++;
                            int ClassificationID = 0;
                            int Warranty = 0;
                            int Status = 0;
                            int Promotion = 0;
                            int Summary = 0;
                            int ProductContent = 0;
                            int VATInfo = 0;
                            int PromotionInfo = 0;
                            int DeliveryInfo = 0;
                            int ShortDescription = 0;
                            int Instock = 0;
                            int StartDeal = 0;
                            int EndDeal = 0;
                            int VATStatus = 0;
                            int TotalProduct = 0;
                            DataTable tblProduct = null;
                            int iPage = 1;
                            tblProduct = productAdapter.GetAllDataProduct(companyID, iPage);
                            while (tblProduct.Rows.Count > 0)
                            {
                                ShowLog(string.Format("Page:{0}", iPage));
                                TotalProduct = +tblProduct.Rows.Count;
                                foreach (DataRow rowProduct in tblProduct.Rows)
                                {
                                    if (Common.CellToInt64(rowProduct, "ClassificationID", 0) > 0) ClassificationID++;
                                    if (Common.CellToInt64(rowProduct, "Warranty", 0) > 0) Warranty++;
                                    if (Common.CellToString(rowProduct, "Promotion", "") != "") Promotion++;
                                    if (Common.CellToString(rowProduct, "Summary", "") != "") Summary++;
                                    if (Common.CellToString(rowProduct, "ProductContent", "") != "") ProductContent++;
                                    if (Common.CellToString(rowProduct, "VATInfo", "") != "") VATInfo++;
                                    if (Common.CellToString(rowProduct, "DeliveryInfo", "") != "") DeliveryInfo++;
                                    if (Common.CellToString(rowProduct, "ShortDescription", "") != "")
                                        ShortDescription++;
                                    if (Common.CellToInt(rowProduct, "Status", 0) != 0) Status++;
                                    if (Common.CellToInt(rowProduct, "VATStatus", 2) != 2) VATStatus++;
                                }
                                tblProduct = productAdapter.GetAllDataProduct(companyID, ++iPage);
                            }
                            productAdapter.UpdateFieldReport(companyID, TotalProduct, Warranty, Status, Promotion,
                                Summary, ProductContent,
                                VATInfo, PromotionInfo, ShortDescription, Instock, StartDeal, EndDeal, DeliveryInfo,
                                VATStatus);

                            ShowLog(string.Format("Updated for company {1} {0}", countCompany,
                                companyID));
                            ShowLog("Success data");
                            break;
                        }
                        catch (Exception exp)
                        {
                            ShowLog(exp.Message + exp.StackTrace);
                            Thread.Sleep(1000);
                        }

                    }

                }

                this.Invoke(new Action(() =>
                {
                    btnExport.Visible = true;

                }));
            });



        }

        private void ShowLog(string log)
        {
            this.Invoke(new Action(() =>
            {
                this.richTextBox1.AppendText("\r\n" + log);
            }));
        }
    }
}
