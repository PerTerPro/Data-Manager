using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GABIZ.Base;
using System.Threading;
using DevExpress.XtraTreeList.Nodes;
using QT.Entities;

namespace QT.Moduls.Maps
{
    public partial class ctrTreeCompany : UserControl
    {
        public delegate void ChangedEventHandler(List<String> ListName, EventArgs e);
        public event ChangedEventHandler CreateNode;

        public delegate void MapEventHandler(List<int> ListID, List<String> ListName, int cat, EventArgs e);
        public event MapEventHandler MapNode;



        public delegate void IDCategoryChangeHandler(long IDcat);
        public event IDCategoryChangeHandler IDCateChange;

        public delegate void LevelMapChangeHandler(int level);
        public event LevelMapChangeHandler LevelMapChange;

        public ctrTreeCompany()
        {
            InitializeComponent();
        }
        private Thread processThread;
        private List<int> visitedCRC;
        private String _connection = "";
        bool isBusy = false;
        bool finish = true;
        void doprocess()
        {
            finish = false;
            DB.TreeClassificationDataTable dttree = new DB.TreeClassificationDataTable();
            this.Invoke((MethodInvoker)delegate
            {
                lamess.Text = "Đang tải dữ liệu...";
            });
            this.dB.Classification.Clear();
            this.dB.TreeClassification.Clear();
            if (_connection == "")
            {
                _connection = QT.Entities.Server.ConnectionString;
                this.classificationTableAdapter.Connection.ConnectionString = _connection;
            }

            if (this.chkDaMap.Checked)
            {
                this.classificationTableAdapter.FillBy_Search_DaMap(this.dB.Classification, "%" + txtSearch.Text.ToString().Trim() + "%");
            }
            else
            {
                this.classificationTableAdapter.FillBy_Search_ChuaMap(this.dB.Classification, "%" + txtSearch.Text.ToString().Trim() + "%");
            }

            this.Invoke((MethodInvoker)delegate
            {
                lamess.Text = "Đã tải xong dữ liệu";
            });
            visitedCRC = new List<int>();
            int k = 0;
            foreach (var dr in dB.Classification)
            {
                k++;
                //this.Invoke((MethodInvoker)delegate
                //{
                //    lamess.Text = k.ToString() + "/" + dB.Classification.Count.ToString();
                //});
                String mapCat = dr.Name.ToString().Trim();
                if (mapCat.Length > 0)
                {
                    List<string> rowMap = new List<string>();
                    rowMap.AddRange(mapCat.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries));
                    string ss = "";
                    if (dr.IDCat > 0) ss = " cat " + dr.NameCat.ToString();
                    if (rowMap.Count < Common.Obj2Int(txtLevel.Text))
                    {
                        rowMap[rowMap.Count - 1] += " - " + dr.Count.ToString() + ss;
                    }
                    else
                    {
                        rowMap[Common.Obj2Int(txtLevel.Text) - 1] += " - " + dr.Count.ToString() + ss;
                    }
                    for (int i = 0; i < rowMap.Count; i++)
                    {
                        if (i >= Common.Obj2Int(txtLevel.Text.Trim())) break;
                        if (rowMap[i].Trim().Length > 0)
                        {
                            int s_crc = Tools.getCRC32(rowMap[i].Trim());
                            int index = visitedCRC.BinarySearch(s_crc);
                            if (index < 0)
                            {
                                visitedCRC.Insert(~index, s_crc);
                                int parentid = 0;
                                if (i > 0)
                                {
                                    parentid = Tools.getCRC32(rowMap[i - 1].Trim());
                                }
                                while (isBusy)
                                    Thread.Sleep(10);
                                isBusy = true;
                                dttree.Rows.Add(
                                       s_crc,
                                       rowMap[i].Trim(),
                                       parentid,
                                       mapCat,
                                       0,
                                       dr.ID);
                                isBusy = false;
                            }
                        }
                    }
                }
            }
            dttree.AcceptChanges();
            this.Invoke((MethodInvoker)delegate
            {
                dB.TreeClassification.Rows.Clear();
                this.dB.TreeClassification.Merge(dttree);
                lamess.Text = "finish";
                dB.TreeClassification.AcceptChanges();
                this.treeList1.ExpandAll();
            });
            finish = true;
            if (processThread != null)
            {
                if (processThread.IsAlive)
                {
                    processThread.Abort();
                    processThread.Join();
                    processThread = null;
                }
            }
        }
        private void LoadData()
        {
            if (finish)
            {
                processThread = new Thread(new ThreadStart(doprocess));
                processThread.Start();
            }
        }
        private void btBuildTree_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData();
            }

        }

        private void btAddNote_Click(object sender, EventArgs e)
        {
            List<String> s = new List<string>();
            s.Add(this.nameLabel1.Text);
            CreateNode(s, e);
        }

        private void btAddRoot_Click(object sender, EventArgs e)
        {
            List<String> s = new List<string>();
            int count = this.treeList1.FocusedNode.Nodes.Count;
            TreeListNode nodeParent = this.treeList1.FocusedNode;
            TreeListNodes tn = this.treeList1.FocusedNode.Nodes;
            for (int i = 0; i < count; )
            {
                this.treeList1.MoveNext();
                TreeListNode node = this.treeList1.FocusedNode;
                if (node.Level == nodeParent.Level + 1)
                {
                    s.Add(this.nameLabel1.Text);
                    i++;
                }
            }
            CreateNode(s, e);
        }

        private void btAddRootCat_Click(object sender, EventArgs e)
        {
            int value = 0;
            QT.Entities.frmShowNumber frm = new Entities.frmShowNumber("ID Chuyên mục");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                value = frm.NumberValue;
            }
            frm.Dispose();

            List<int> s = new List<int>();
            List<string> n = new List<string>();
            int count = this.treeList1.FocusedNode.Nodes.Count;
            TreeListNode nodeParent = this.treeList1.FocusedNode;
            TreeListNodes tn = this.treeList1.FocusedNode.Nodes;
            for (int i = 0; ; )
            {
                this.treeList1.MoveNext();
                TreeListNode node = this.treeList1.FocusedNode;
                if (node.Level == nodeParent.Level) { break; }
                if (node.Level == nodeParent.Level + 1)
                {
                    if (node.Nodes.Count == 0)
                    {
                        s.Add(Entities.Common.Obj2Int(this.iDClassificationLabel1.Text));
                        n.Add(this.nameLabel1.Text);
                        i++;
                    }
                }
                if (node.Level == nodeParent.Level + 2)
                {
                    if (node.Nodes.Count == 0)
                    {
                        s.Add(Entities.Common.Obj2Int(this.iDClassificationLabel1.Text));
                        n.Add(this.nameLabel1.Text);
                        i++;
                    }
                }
                if (node.Level == nodeParent.Level + 3)
                {
                    if (node.Nodes.Count == 0)
                    {
                        s.Add(Entities.Common.Obj2Int(this.iDClassificationLabel1.Text));
                        n.Add(this.nameLabel1.Text);
                        i++;
                    }
                }
            }
            MapNode(s, n, value, e);
        }

        private void btAddNoteCate_Click(object sender, EventArgs e)
        {
            int value = 0;
            QT.Entities.frmShowNumber frm = new Entities.frmShowNumber("ID Chuyên mục");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                value = frm.NumberValue;
            }
            frm.Dispose();
            List<int> s = new List<int>();
            List<String> n = new List<string>();
            s.Add(Entities.Common.Obj2Int(this.iDClassificationLabel1.Text));
            n.Add(this.nameLabel1.Text);
            MapNode(s, n, value, e);
        }

        private void iDClassificationLabel1_TextChanged(object sender, EventArgs e)
        {
            long id = Common.Obj2Int64(iDClassificationLabel1.Text.Trim());
            IDCateChange(id);
        }

        private void txtLevel_EditValueChanged(object sender, EventArgs e)
        {
            LevelMapChange(Common.Obj2Int(txtLevel.Text));
        }
    }
}
