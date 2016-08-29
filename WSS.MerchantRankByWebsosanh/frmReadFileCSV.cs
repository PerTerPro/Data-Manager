using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities;

namespace WSS.MerchantRankByWebsosanh
{
    public partial class frmReadFileCSV : Form
    {
        public frmReadFileCSV()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int counter = 0;
                string line;
                List<string> listLinks = new List<string>();
                // Read the file and display it line by line.
                System.IO.StreamReader file =
                   new System.IO.StreamReader(openFileDialog.FileName);
                while ((line = file.ReadLine()) != null)
                {
                    if (counter == 0)
                    {
                        counter++;
                        continue;
                    }
                    else
                    {
                        var products = line.Split(new char[] {'|'});
                        listLinks.Add(products[2]);
                        counter++;
                    }
                }

                file.Close();
                gridControl1.DataSource = listLinks;
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
}
