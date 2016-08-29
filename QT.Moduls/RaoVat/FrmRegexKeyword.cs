using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlSale
{
    public partial class FrmRegexKeyword : Form
    {
        public FrmRegexKeyword()
        {
            InitializeComponent();
        }

        private void regexFindKeyWordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.regexFindKeyWordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.crawlerSaleNew);
            MessageBox.Show("Saved");

        }

        private void FrmRegexKeyword_Load(object sender, EventArgs e)
        {
            this.regexFindKeyWordTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;
            // TODO: This line of code loads data into the 'crawlerSaleNew.RegexFindKeyWord' table. You can move, or remove it, as needed.
            this.regexFindKeyWordTableAdapter.Fill(this.crawlerSaleNew.RegexFindKeyWord);

        }

        private void FrmRegexKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.S)
                {
                    Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save()
        {
            //Cộng hòa xã hoi nghủ nghĩa việta nm.
            this.Validate();
            this.regexFindKeyWordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.crawlerSaleNew);

            QT.Entities.Common.ReloadRegexKeyWord();
            MessageBox.Show("Saved!");
        }
    }
}
