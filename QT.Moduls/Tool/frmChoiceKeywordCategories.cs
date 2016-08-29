using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using QT.Entities;
using QT.Users;
using Websosanh.Core.Common.BO;
using Websosanh.Core.Product.BAL;
using Websosanh.Core.Product.BO;
using Websosanh.Core.Product.DAL;
using System.Windows.Forms;


namespace QT.Moduls.Tool
{
    public partial class frmChoiceKeywordCategories : QT.Entities.frmBase
    {
        private int currentKeyHash;
        private string currentKeyword;
        private Tree<int,ProductCategory> productCategoryTree;
        private string connectionString;
        private bool isRefreshing = true;
        public int UserID { get; set; }
        public frmChoiceKeywordCategories()
        {
            InitializeComponent();
        }

        private void frmChoiceKeywordCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTool.KeywordCategories' table. You can move, or remove it, as needed.
            connectionString = Server.ConnectionString;
            this.keywordCategoriesTableAdapter.Connection = new SqlConnection(connectionString);
            productCategoryTree = ProductCategoryBAL.GetProductCategoryTree(connectionString);
            var comboboxItemList = new List<ObjectItem>();
            comboboxItemList.AddRange(
                productCategoryTree.GetAllNodeInLevel(2)
                    .Select(x => new ObjectItem() {Value = x.Value.ID, Text = string.Format("{1}<-{0}",productCategoryTree.GetParentNode(x.ID).Value.Name, x.Value.Name)}));
            comboboxItemList.AddRange(
                productCategoryTree.GetAllNodeInLevel(3)
                    .Select(x => new ObjectItem() { Value = x.Value.ID, Text = string.Format("{1}<-{0}", productCategoryTree.GetParentNode(x.ID).Value.Name, x.Value.Name) }));
            comboboxItemList.AddRange(
                productCategoryTree.GetAllNodeInLevel(4)
                    .Select(x => new ObjectItem() { Value = x.Value.ID, Text = string.Format("{1}<-{0}", productCategoryTree.GetParentNode(x.ID).Value.Name, x.Value.Name) }));
            object[] comboboxItemArray = comboboxItemList.OrderBy(x => x.Text).ToArray();
            comboBoxCategory1.Items.AddRange(comboboxItemArray);
            comboBoxCategory2.Items.AddRange(comboboxItemArray);
            comboBoxCategory3.Items.AddRange(comboboxItemArray);
            comboBoxCategory4.Items.AddRange(comboboxItemArray);
            comboBoxCategory5.Items.AddRange(comboboxItemArray);
        }

        private void fillNotProcessedKeyWordByUserIDToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                isRefreshing = true;
                this.keywordCategoriesTableAdapter.FillNotProcessedKeywordsByUserID(this.dBTool.KeywordCategories, ((int)(System.Convert.ChangeType(userIDToolStripTextBox.Text, typeof(int)))));
                refreshNotChoicedKeywordGrid();
            //}
            //catch (System.Exception ex)
            //{
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void refreshNotChoicedKeywordGrid()
        {
            isRefreshing = true;
                this.dataGridViewNotChoisedKeyword.Refresh();
                isRefreshing = false;
        }

        private class ObjectItem
        {
            public int Value;
            public string Text;
            public override string ToString()
            {
                return Text;
            }
        }

        private void dataGridViewNotChoisedKeyword_SelectionChanged(object sender, EventArgs e)
        {
            if(isRefreshing)
                return;
            ChangeSelectKeyword();
        }

        private void ChangeSelectKeyword()
        {
            var selectedIndex = dataGridViewNotChoisedKeyword.CurrentRow.Index;
            if(selectedIndex < 0)
                return;
            currentKeyHash = (int)dBTool.KeywordCategories.Rows[selectedIndex]["Hash"];
            currentKeyword = (string)dBTool.KeywordCategories.Rows[selectedIndex]["Keyword"];
            comboBoxCategory1.Enabled = true;
            comboBoxCategory1.SelectedIndex = -1;
            comboBoxCategory2.SelectedIndex = -1;
            comboBoxCategory3.SelectedIndex = -1;
            comboBoxCategory4.SelectedIndex = -1;
            comboBoxCategory5.SelectedIndex = -1;
        }
        private void comboBoxCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCategory2.Enabled = true;
            buttonAddKeyword.Enabled = true;
        }

        private void comboBoxCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCategory3.Enabled = true;
        }

        private void comboBoxCategory3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCategory4.Enabled = true;
        }

        private void comboBoxCategory4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCategory5.Enabled = true;
        }

        private void buttonAddKeyword_Click(object sender, EventArgs e)
        {
            AddKeyword();
        }

        
        private int dataGridViewChoisedKeywordRowIndex = 0;
        private void dataGridViewChoisedKeyword_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            { 
                this.dataGridViewChoisedKeyword.Rows[e.RowIndex].Selected = true;
                this.dataGridViewChoisedKeywordRowIndex = e.RowIndex;
                this.dataGridViewChoisedKeyword.CurrentCell = this.dataGridViewChoisedKeyword.CurrentCell;
                this.contextMenuStripDeleteRow.Show(this.dataGridViewChoisedKeyword, e.Location); 
                contextMenuStripDeleteRow.Show(Cursor.Position); }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
             dataGridViewChoisedKeyword.Rows.RemoveAt(this.dataGridViewChoisedKeywordRowIndex);
        }

        private void buttonSaveAll_Click(object sender, EventArgs e)
        {
            SaveAll();
        }

        private void AddKeyword()
        {
            ObjectItem keyword = new ObjectItem() { Value = currentKeyHash, Text = currentKeyword };
            ObjectItem category1 = null;
            ObjectItem category2 = null;
            ObjectItem category3 = null;
            ObjectItem category4 = null;
            ObjectItem category5 = null;
            if (comboBoxCategory1.SelectedIndex != -1)
                category1 = (ObjectItem)comboBoxCategory1.SelectedItem;
            if (comboBoxCategory2.SelectedIndex != -1)
                category2 = (ObjectItem)comboBoxCategory2.SelectedItem;
            if (comboBoxCategory3.SelectedIndex != -1)
                category3 = (ObjectItem)comboBoxCategory3.SelectedItem;
            if (comboBoxCategory4.SelectedIndex != -1)
                category4 = (ObjectItem)comboBoxCategory4.SelectedItem;
            if (comboBoxCategory5.SelectedIndex != -1)
                category5 = (ObjectItem)comboBoxCategory5.SelectedItem;
            dataGridViewChoisedKeyword.Rows.Add(keyword, category1, category2, category3, category4, category5);
            dBTool.KeywordCategories.Rows.RemoveAt(dataGridViewNotChoisedKeyword.CurrentRow.Index);
            refreshNotChoicedKeywordGrid();
            ChangeSelectKeyword();
        }

        private void SaveAll()
        {
            for (var rowIndex = 0; rowIndex < dataGridViewChoisedKeyword.RowCount; rowIndex++)
            {
                var cells = dataGridViewChoisedKeyword.Rows[rowIndex].Cells;
                var keyWord = (ObjectItem)cells[0].Value;
                ObjectItem category1 = cells[1].Value != null
                    ? (ObjectItem)cells[1].Value
                    : null;
                ObjectItem category2 = cells[2].Value != null
                    ? (ObjectItem)cells[2].Value
                    : null;
                ObjectItem category3 = cells[3].Value != null
                    ? (ObjectItem)cells[3].Value
                    : null;
                ObjectItem category4 = cells[4].Value != null
                    ? (ObjectItem)cells[4].Value
                    : null;
                ObjectItem category5 = cells[5].Value != null
                    ? (ObjectItem)cells[5].Value
                    : null;
                this.keywordCategoriesTableAdapter.UpdateCategories(category1 == null ? -1 : category1.Value,
                    category2 == null ? -1 : category2.Value, category3 == null ? -1 : category3.Value,
                    category4 == null ? -1 : category4.Value, category5 == null ? -1 : category5.Value,DateTime.Now,UserID, keyWord.Value
                    );
            }
            dataGridViewChoisedKeyword.Rows.Clear();
        }

        private void coppyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewNotChoisedKeyword.CurrentCell.Value != null)
            {
                Clipboard.SetDataObject(dataGridViewNotChoisedKeyword.CurrentCell.Value.ToString(), false);
            }
        }

        private void deleteRowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridViewNotChoisedKeyword.CurrentRow != null)
            {
                dBTool.KeywordCategories.Rows.RemoveAt(dataGridViewNotChoisedKeyword.CurrentRow.Index);
                this.keywordCategoriesTableAdapter.UpdateCategories(100000000, -1, -1, -1, -1,DateTime.Now,UserID, currentKeyHash);
                refreshNotChoicedKeywordGrid();
                ChangeSelectKeyword();
            }

        }

        private void dataGridViewNotChoisedKeyword_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                dataGridViewNotChoisedKeyword.Rows[e.RowIndex].Cells[e.ColumnIndex].ContextMenuStrip = contextMenuStripCoppy;
                dataGridViewNotChoisedKeyword.CurrentCell = dataGridViewNotChoisedKeyword.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void frmChoiceKeywordCategories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                AddKeyword();
            }
            if (e.KeyCode == Keys.F4)
            {
                SaveAll();
            }
        }

      


    }
}
